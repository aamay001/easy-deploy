using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.DirectoryServices;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using PsTools_Easy_Deploy_Tool.Forms;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class PCListDesigner : Form
    {
        CheckedListBox UseList;
        private bool searchInProgress = false;
        private int runningPingThreads = 0;
        private List<int> timeSinceLastChecked;
        private Object pingThreadCountLock;
        private bool abortPing = false;

        public PCListDesigner()
        {
            InitializeComponent();
        }

        private void PCListDesigner_Load(object sender, EventArgs e)
        {
            getSubnets();
            abortPing = false;
            pingThreadCountLock = new Object();
            timeSinceLastChecked = new List<int>();            
        }

        public void initUseList(CheckedListBox l)
        {
            UseList = l;
        }

        private void addSelected_Click(object sender, EventArgs e)
        {
            selected.BeginUpdate();
            BeginCandUpdate();
            for (int i = 0; i < candidates.SelectedItems.Count; i++)
            {
                ListViewItem selItem = candidates.SelectedItems[i];
                if (!selected.Items.ContainsKey(selItem.Text))
                {
                    selected.Items.Add(selItem.Text, selItem.Text, 0).StateImageIndex = selItem.StateImageIndex;
                }

                candidates.Items.RemoveByKey(selItem.Text);
                --i;
            }
            EndCandUpdate();
            selected.EndUpdate();            
        }

        private void remSelected_Click(object sender, EventArgs e)
        {
            selected.BeginUpdate();
            BeginCandUpdate();
            for (int i = 0; i < selected.SelectedItems.Count; i++)
            {
                ListViewItem liTem = selected.SelectedItems[i];
                AddCandidate(liTem.Text);
                selected.Items.RemoveByKey(liTem.Text);
                --i;
            }
            EndCandUpdate();
            selected.EndUpdate();
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            selected.BeginUpdate();
            for (int i = 0; i < candidates.Items.Count; i++)
            {
                ListViewItem liTem = candidates.Items[i];
                selected.Items.Add(liTem.Text, liTem.Text, 0).StateImageIndex = liTem.StateImageIndex;
            }
            selected.EndUpdate();
            candidates.Items.Clear();
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            BeginCandUpdate();
            for (int i = 0; i < selected.Items.Count; i++)
            {
                ListViewItem liTem = selected.Items[i];
                AddCandidate(liTem.Text);
            }
            EndCandUpdate();
            selected.Items.Clear();

            RunPing();
        }

        private void RemoveDoublesInSelected()
        {
            for (int i = 0; i < selected.Items.Count; i++)
            {
                if (ContainsDouble(i))
                {
                    selected.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private delegate bool ContainsDoubleDel( int i);
        private bool ContainsDouble( int i )
        {
            if ( selected.InvokeRequired )
            {
                ContainsDoubleDel a = new ContainsDoubleDel( ContainsDouble );
                object [] args = new object[] { i }; 
                return (bool)Invoke( a, args );
            }

            else
            {
                String key = selected.Items[i].Text;
                if (selected.Items.IndexOfKey(key) != i)
                    return true;

                else
                    return false;
            }
        }

        private void clearPreview_Click(object sender, EventArgs e)
        {
            candidates.Items.Clear();
        }

        private void clearSelected_Click(object sender, EventArgs e)
        {
            selected.Items.Clear();
        }

        private void openList_Click(object sender, EventArgs e)
        {
            openComputerList.ShowDialog();
        }

        private void openComputerList_FileOk(object sender, CancelEventArgs e)
        {
            Thread readThread = new Thread( new ThreadStart(openListThreaded));
            readThread.Start();
        }

        private void openListThreaded()
        {
            FileStream file = new FileStream(openComputerList.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            BeginCandUpdate();
            while (!reader.EndOfStream)
            {
                AddCandidate(reader.ReadLine());
            }
            EndCandUpdate();
            reader.Close();
            file.Close();

            RunPing();
        }

        private delegate void ClearCandidateDel();
        private void ClearCandidates()
        {
            if (candidates.InvokeRequired)
            {
                ClearCandidateDel a = new ClearCandidateDel(ClearCandidates);
                Invoke(a);
            }

            else
            {
                candidates.Items.Clear();
            }
        }

        private void manAdd_Click(object sender, EventArgs e)
        {
            SearchGroup.Enabled = false;
            Cursor = Cursors.WaitCursor;

            if (candidates.Items.ContainsKey(manualPC.Text.ToUpper()) ||
                candidates.Items.ContainsKey(manualPC.Text.ToLower()) ||
                candidates.Items.ContainsKey(manualPC.Text) ||
                selected.Items.ContainsKey(manualPC.Text.ToUpper()) ||
                selected.Items.ContainsKey(manualPC.Text.ToLower()) ||
                selected.Items.ContainsKey(manualPC.Text))
            {
                MessageBox.Show("Computer is already in one of the lists.", "Computer Exists ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SearchGroup.Enabled = true;
                Cursor = Cursors.Default;
                manualPC.Focus();
                manualPC.SelectAll();
                return;
            }

            if (adCheck.Checked)
            {
                if (!CompInDomain(manualPC.Text) &&
                    !CompInDomain(manualPC.Text.ToLower()) &&
                    !CompInDomain(manualPC.Text.ToUpper()))
                {
                    MessageBox.Show("Computer account was not found in AD.", "Computer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SearchGroup.Enabled = true;
                    Cursor = Cursors.Default;
                    manualPC.Focus();
                    manualPC.SelectAll();
                    return;
                }
            }

            selected.Items.Add(manualPC.Text, manualPC.Text, 0);
            SearchGroup.Enabled = true;
            manualPC.Focus();
            manualPC.SelectAll();
            Cursor = Cursors.Default;
        }

        public bool CompInDomain(string username)
        {
            if (ActiveDir.cacheFound && ActiveDir.adUpdating)
            {
                if (ActiveDir.CachedAD.Contains(username))
                    return true;

                else
                    return false;
            }

            else
            {
                if (ActiveDir.Computers.Contains(username))
                    return true;

                else
                    return false;
            }
        }

        private void saveList_Click(object sender, EventArgs e)
        {
            if (selected.Items.Count == 0)
            {
                MessageBox.Show("There are no computers in the list. Add computers to your list.", "No Computers Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                FileStream file = new FileStream(saveFile.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);

                for (int i = 0; i < selected.Items.Count; i++)
                    writer.WriteLine(selected.Items[i].Text);

                writer.Close();
                file.Close();
            }

            catch
            {
                MessageBox.Show("An error happened while trying to save your file. Please make sure you have the proper permissions to write to the directory.", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Use_Click(object sender, EventArgs e)
        {
            bool clearOk = true;
            RemoveDoublesInSelected();

            if ( UseList.Items.Count > 0 )
            {
                DialogResult result = MessageBox.Show( "This will clear the Selected Computers List in the main form. Continue?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if (result == System.Windows.Forms.DialogResult.No)
                    clearOk = false;
            }

            if ( clearOk )
            {
                UseList.Items.Clear();

                foreach (ListViewItem o in selected.Items)
                    UseList.Items.Add(o.Text);

                Close();
            }
        }

        private void getSubnets()
        {
            LocalNetworkSettings.GetLocalSubnets();
            subnetsToolStripMenuItem.DropDownItems.Clear();
            foreach (String s in LocalNetworkSettings.AvailableSubnets)
            {
                subnetsToolStripMenuItem.DropDownItems.Add(s);
                subnetsToolStripMenuItem.DropDownItems[subnetsToolStripMenuItem.DropDownItems.Count - 1].Click += new EventHandler(subnetDropDownMenuItem_Click);
            }

            octet1.Value = LocalNetworkSettings.subnetParseOctet1;
            octet2.Value = LocalNetworkSettings.subnetParseOctet2;
            octet3.Value = LocalNetworkSettings.subnetParseOctet3;

#if DEBUG
            LocalNetworkSettings.DnsOK = true;
            return;
#endif
                
            // Check if any of the Available DNS Server are local DNS Servers
            foreach (String s in LocalNetworkSettings.AvailableDNSServers)
            {
                for (int i = 0; i < subnetsToolStripMenuItem.DropDownItems.Count; i++)
                {
                    if (s.Substring(0, octet1.Value.ToString().Length) == subnetsToolStripMenuItem.DropDownItems[i].ToString().Substring( 0, octet1.Value.ToString().Length ))
                    {
                        LocalNetworkSettings.DnsOK = true;
                        break;
                    }
                }
            }
        }

        private void subnetDropDownMenuItem_Click(object sender, EventArgs e)
        {
            string subnet = ((ToolStripMenuItem)(sender)).Text;
            int i1 = -1;
            int i2 = -1;
            int i3 = -1;

            for (int i = 0; i < subnet.Length; i++)
            {
                if (i1 == -1)
                {
                    if (subnet[i] == '.')
                        i1 = i;
                }

                else if (i2 == -1)
                {
                    if (subnet[i] == '.')
                        i2 = i;
                }

                else if (i3 == -1)
                {
                    if (subnet[i] == '.')
                        i3 = i;
                }
            }

            octet1.Value = Convert.ToDecimal(subnet.Substring(0, i1));
            octet2.Value = Convert.ToDecimal(subnet.Substring(i1 + 1, i2 - i1 - 1));
            octet3.Value = Convert.ToDecimal(subnet.Substring(i2 + 1, i3 - i2 - 1));
        }

        private void scanSubnet_Click(object sender, EventArgs e)
        {
            candidates.Items.Clear();
            Thread t = new Thread(new ThreadStart(GoDnsSearch));
            t.Start();
        }

        private void adSearch_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(GoSearch));
            t.Start();
        }

        private void GoDnsSearch()
        {
            EnableSearchKey(false);

            DNSScanner dq = new DNSScanner(octet1.Value.ToString() + "." + octet2.Value.ToString() + "." + octet3.Value.ToString() + ".");
            dq.ShowDialog();
            
            BeginCandUpdate();
            ClearCandidates();
            foreach (String h in dq.Hosts)
                AddCandidate(h);
            EndCandUpdate();

            searchResultsCount.Text = dq.Hosts.Count.ToString();

            EnableSearchKey(true);

            RunPing();
        }

        private void GoSearch()
        {
            EnableSearchKey(false);

            List<String> results;

            if (ActiveDir.cacheFound && (ActiveDir.adUpdating || !ActiveDir.DCAvailable ))
            {
                results = ActiveDir.CachedAD.FindAll(     x => x.Equals(adSearchKey.Text) ||
                    
                                                          (adSearchStartsWith.Checked ? x.StartsWith(adSearchKey.Text) : false) || 

                                                          ((adSearchStartsWith.Checked && !adSearchCaseSensitive.Checked) ? 
                                                          (x.StartsWith(adSearchKey.Text.ToLower()) || x.StartsWith(adSearchKey.Text.ToUpper())) : false ) ||

                                                          (adSearchContains.Checked ? x.Contains(adSearchKey.Text) : false ) ||

                                                          ( (adSearchContains.Checked && !adSearchCaseSensitive.Checked) ? (x.Contains(adSearchKey.Text.ToLower()) ||
                                                          x.Contains(adSearchKey.Text.ToUpper())) : false )
                                                    );               
            }

            else
            {
                results = ActiveDir.Computers.FindAll(    x => x.Equals(adSearchKey.Text) ||

                                                          (adSearchStartsWith.Checked ? x.StartsWith(adSearchKey.Text) : false) ||

                                                          ((adSearchStartsWith.Checked && !adSearchCaseSensitive.Checked) ?
                                                          (x.StartsWith(adSearchKey.Text.ToLower()) || x.StartsWith(adSearchKey.Text.ToUpper())) : false) ||

                                                          (adSearchContains.Checked ? x.Contains(adSearchKey.Text) : false) ||

                                                          ((adSearchContains.Checked && !adSearchCaseSensitive.Checked) ? (x.Contains(adSearchKey.Text.ToLower()) ||
                                                          x.Contains(adSearchKey.Text.ToUpper())) : false)
                                                    );
            }

            BeginCandUpdate();
            ClearCandidates();
            foreach (String currentComp in results)
                AddCandidate(currentComp);
            EndCandUpdate();       
    
            searchResultsCount.Text = results.Count.ToString();
            EnableSearchKey(true);

            RunPing();

            if (ActiveDir.adUpdating)
            {
                MessageBox.Show( "Results acquired from Active Directory cache created on " + ActiveDir.LastUpdate.ToShortDateString() +
                                " at " + ActiveDir.LastUpdate.ToShortTimeString() + ".", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }            
        }

        private delegate void BeginCandUpdateDel();
        private void BeginCandUpdate()
        {
            if (candidates.InvokeRequired)
            {
                BeginCandUpdateDel a = new BeginCandUpdateDel(BeginCandUpdate);
                Invoke(a);
            }

            else
            {
                candidates.BeginUpdate();
            }
        }

        private delegate void EndCandUpdateDel();
        private void EndCandUpdate()
        {
            if (candidates.InvokeRequired)
            {
                EndCandUpdateDel a = new EndCandUpdateDel(EndCandUpdate);
                Invoke(a);
            }

            else
            {
                candidates.EndUpdate();
            }
        }

        private delegate void AddCand(String s);
        private void AddCandidate(String s)
        {
            if (candidates.InvokeRequired)
            {
                AddCand a = new AddCand(AddCandidate);
                object[] args = new object[] { s };
                Invoke(a, args);
            }

            else
            {
                candidates.Items.Add(s, s, 0).StateImageIndex = 8;
            }
        }
        
        private delegate void EnableSK(bool b);
        private void EnableSearchKey(bool b)
        {
            if (adSearchGroup.InvokeRequired)
            {
                EnableSK a = new EnableSK(EnableSearchKey);
                object[] args = new object[] { b };
                Invoke(a, args);
            }

            else
            {
                SearchGroup.Enabled = b;
                MoveButtons.Enabled = b;
                ListIOGroup.Enabled = b;
                candidates.Enabled = b;
                selected.Enabled = b;
                searchInProgress = !b;

                if (b == false)
                    Cursor = Cursors.WaitCursor;
                else
                    Cursor = Cursors.Default;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!ActiveDir.adNotAvailable)
            {
                if (ActiveDir.adUpdating)
                {
                    if (Text == "Computers" || Text == "Computers - AD Last Update: " + ActiveDir.LastUpdate.ToShortDateString() + " " + ActiveDir.LastUpdate.ToShortTimeString())
                        Text = "Computers - AD Updating";

                    else
                        Text = "Computers";

                    updateToolStripMenuItem.Enabled = false;
                }

                if (ActiveDir.adUpToDate || !ActiveDir.DCAvailable)
                {
                    if (Text == "Computers" || Text == "Computers - AD Updating")
                    {
                        Text = "Computers - AD Last Update: " + ActiveDir.LastUpdate.ToShortDateString() + " " + ActiveDir.LastUpdate.ToShortTimeString();
                    }

                    if (updateToolStripMenuItem.Enabled == false)
                    {
                        updateToolStripMenuItem.Enabled = true;
                    }
                }
            }

            else
            {
                Text = "Computers";
                adSearchGroup.Enabled = false;
                adCheck.Enabled = false;
                activeDirectoryToolStripMenuItem.Enabled = false;
            }

            if (!LocalNetworkSettings.DnsOK)
            {
                SubnetScanGroup.Enabled = false;
                subnetsToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (SubnetScanGroup.Enabled == false)
                {
                    SubnetScanGroup.Enabled = true;
                    subnetsToolStripMenuItem.Enabled = true;
                }
            }

            if (runningPingThreads > 0)
            {
                if (!label2.Text.Contains("Ping Running"))
                    label2.Text += " - Ping Running";
            }

            else
            {
                if (label2.Text.Contains("Ping Running"))
                    label2.Text = label2.Text.Remove(label2.Text.LastIndexOf(" - Ping Running"), 15);
            }

            NumSelectedComps.Text = selected.Items.Count.ToString();
        }

        private void adSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                adSearch_Click(sender, e);
        }

        private void manualPC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                manAdd_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveDir.GetComputers();
        }

        private void octet1_Enter( object sender, EventArgs e )
        {
            octet1.Select( 0, octet1.Value.ToString().Length );
        }

        private void octet2_Enter( object sender, EventArgs e )
        {
            octet2.Select( 0, octet2.Value.ToString().Length );
        }

        private void octet3_Enter( object sender, EventArgs e )
        {
            octet3.Select( 0, octet3.Value.ToString().Length );
        }

        private void octet1_Click( object sender, EventArgs e )
        {
            octet1_Enter( sender, e );
        }

        private void octet2_Click( object sender, EventArgs e )
        {
            octet2_Enter( sender, e );
        }

        private void octet3_Click( object sender, EventArgs e )
        {
            octet3_Enter( sender, e );
        }

        private void PCListDesigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            DNSScanner.abort = true;
            abortPing = true;
            MainFormAccess.mainForm.Focus();
        }

        private void candidates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (candidates.SelectedIndices.Count > 0)
            {
                if (candidates.SelectedIndices[0] >= 0)
                {
                    ListViewItem cand = candidates.Items[candidates.SelectedIndices[0]];

                    if (!selected.Items.ContainsKey(cand.Text))
                    {
                        selected.Items.Add(cand.Text, cand.Text, 0).StateImageIndex = cand.StateImageIndex;                        
                    }

                    candidates.Items.RemoveByKey(cand.Text);
                }
            }
        }

        private void selected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selected.SelectedIndices.Count > 0)
            {
                if (selected.SelectedIndices[0] >= 0)
                {
                    String item = selected.Items[selected.SelectedIndices[0]].Text;
                    AddCandidate(item);
                    selected.Items.RemoveByKey(item);
                }
            }
        }

        private void RunPing()
        {
            Thread T = new Thread(new ThreadStart(pingCandidates));
            T.Start();
        }

        private delegate KeyValuePair<String, int> GetCandidateDel(int i);
        private KeyValuePair<String, int> GetCandidate(int i)
        {
            if (candidates.InvokeRequired)
            {
                GetCandidateDel a = new GetCandidateDel(GetCandidate);
                object[] args = new object[] { i };
                return (KeyValuePair<String, int>)Invoke(a, args);
            }

            else
            {
                try
                {
                    ListViewItem item = candidates.Items[i];
                    return new KeyValuePair<string, int>(item.Text, item.StateImageIndex);
                }

                catch
                {
                    return new KeyValuePair<String, int>("", -1);
                }
            }
        }

        private void pingCandidates()
        {
            while(runningPingThreads > 0)
            {
                Thread.SpinWait(10);
            }

            for (int i = 0; i < candidates.Items.Count; i++)
            {
                if (searchInProgress)
                    return;

                if (abortPing)
                    return;

                while (runningPingThreads > 1024) ;

                KeyValuePair<String,int> item = GetCandidate(i);

                if ( item.Value == 0 )
                    continue;

                Thread T = new Thread(new ThreadStart(() => pingHost(item.Key)));
                T.Start();
            }
        }

        private delegate void SetCandidateStateDel(string key, int i);
        private void SetCandidateState(string key, int i)
        {
            if (searchInProgress)
                return;

            if (candidates.InvokeRequired)
            {
                SetCandidateStateDel a = new SetCandidateStateDel(SetCandidateState);
                object[] args = new object[] { key, i };
                Invoke(a, args);
            }

            else
            {
                try
                {
                    candidates.Items[key].StateImageIndex = i;
                }

                catch
                {
                }
            }
        }

        private void pingHost(string key)
        {
            if (searchInProgress)
                return;

            if (abortPing)
                return;

            try
            {
                lock (pingThreadCountLock)
                {
                    runningPingThreads++;
                }

                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(key, 100);

                if (reply.Status == IPStatus.Success)
                {
                    SetCandidateState(key, 0);
                }

                else
                {
                    SetCandidateState(key, 2);
                }
            }

            catch
            {
                SetCandidateState(key, 1);

                lock (pingThreadCountLock)
                {
                    runningPingThreads--;
                }

                return;
            }

            lock (pingThreadCountLock)
            {
                runningPingThreads--;
            }
        }

        private void AddAllAvailable_Click(object sender, EventArgs e)
        {
            if (runningPingThreads > 0)
            {
                DialogResult r = MessageBox.Show("Easy Deploy is still checking for host availability. Try again in a few seconds.", "Easy Deploy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selected.BeginUpdate();
            for (int i = 0; i < candidates.Items.Count; i++)
            {
                ListViewItem liTem = candidates.Items[i];

                if (liTem.StateImageIndex == 0)
                {
                    selected.Items.Add(liTem.Text, liTem.Text, 0).StateImageIndex = liTem.StateImageIndex;
                    candidates.Items.RemoveAt(i);
                    --i;
                }
            }
            selected.EndUpdate();
        }

        private void pingAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunPing();
        }
    }
}
