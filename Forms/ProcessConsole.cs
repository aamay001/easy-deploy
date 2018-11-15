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
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class ProcessConsole : Form
    {
        public static List<LogEntry> logEntries = new List<LogEntry>();
        public static String currentExecutableOrCommand = "";
        private ListViewColumnSorter lvwColumnSorter;

        // Stat Objects
        private int MSIOK = 0;
        private int MSIWARN = 0;
        private int MSIERR = 0;
        private int MSIWAIT = 0;
        private int MSIERRCODE = 0;
        private Object StatSetLock;

        // MSI Logging
        public String MSILoggingDir = "";
        public String MSIProductName = "";
        public bool MSIDeployment = false;
        private List<String> MSILogFiles;
        public bool MSIDeploymentStillRunning = false;
        private bool pollingActive = false;
        private Object pollingLock;

        String pingHostString = "";

        public ProcessConsole()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            log.ListViewItemSorter = lvwColumnSorter;
            MSILogFiles = new List<String>();
            pollingLock = new Object();
            StatSetLock = new Object();
        }

        public void ClearMSI()
        {
            //MSILoggingDir = "";
            MSIDeployment = false;
            MSILogFiles.Clear();
            ActualMSILog.Text = "";
            LogFileLocation.Text = "";
            MSIOK = 0;
            MSIWARN = 0;
            MSIERR = 0;
            MSIWAIT = 0;
            MSICountTable.Items[0].SubItems[1].Text = "0";
            MSICountTable.Items[1].SubItems[1].Text = "0";
            MSICountTable.Items[2].SubItems[1].Text = "0";
            MSIStatProductName.Text = "";
            MSIStatProductVersion.Text = "";            
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processList.SelectedIndex > -1 && processList.SelectedIndex < ProcessManager.outputList.Count)
            {
                try
                {
                    console.Text = ProcessManager.outputList[processList.SelectedIndex];
                }

                catch
                {
                    MessageBox.Show("Error openening output file.", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void clearSelect_Click(object sender, EventArgs e)
        {
            processList.SelectedIndex = -1;
            console.Text = "";
        }

        private delegate void AddProcessToListDel(String s);
        public void AddProcessToList(String s)
        {
            if (processList.InvokeRequired)
            {
                AddProcessToListDel a = new AddProcessToListDel(AddProcessToList);
                object[] args = new object[] { s };
                Invoke(a, args);
            }

            else
            {
                processList.Items.Add(s);
            }
        }

        private void ProcessConsole_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void MSIProcessStarted(String HostName)
        {
            MSIStatSet(HostName, "Process has been started. Waiting for process to finish.", "WAITING");

            if (!MSILogFiles.Contains(MSILoggingDir + "\\" + HostName) )
                MSILogFiles.Add(MSILoggingDir.Replace("%computername%", HostName) + "\\" + HostName);
        }

        private void MSIProcessCouldNotBeStarted(String HostName)
        {
            MSIStatSet(HostName, "Process could not be started.", "FAIL");
        }

        private delegate void AddLogEntryDel(String Host, String S);
        public void AddLogEntry(String Host, String S)
        {
            if (log.InvokeRequired)
            {
                AddLogEntryDel a = new AddLogEntryDel(AddLogEntry);
                object[] args = new object[] { Host, S };
                Invoke(a, args);
            }

            else
            {
                List<LogEntry> queueToAdd = new List<LogEntry>();
                StringReader reader = new StringReader(S);
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    if (Host == "Deployment")
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, S));
                    }

                    else if (currentLine.Contains("started on " + Host))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, (MSIDeployment ? "MSI - " + MSIProductName : currentExecutableOrCommand) + " started with process ID " + currentLine.Substring(currentLine.LastIndexOf(' ') + 1, currentLine.Length - currentLine.LastIndexOf(' ') - 1)));

                        if (MSIDeployment)
                            MSIProcessStarted(Host);
                    }

                    else if (currentLine.Contains("Timeout accessing"))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Connection timed out."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    else if (currentLine.Contains("is an incompatible version"))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Incompatible PSExec Version. " + reader.ReadLine() + " " + reader.ReadLine()));
                    }

                    else if (currentLine.Contains("Couldn't access " + Host))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Host is inaccessible. Could not start PSExec service on remote computer."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    else if (currentLine.Contains("unknown user name or bad password"))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Authentication failed. Invalid username or password."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    else if (currentLine == "Process manually aborted by user.")
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Process manually aborted by user."));
                    }

                    else if (currentLine.Contains("Logon failure: account currently disabled."))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Authentication failed. The user account is disabled."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    else if (currentLine == "Access is denied.")
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Unable to establish connection. Access was denied."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    else if (currentLine.Contains("cannot find the path specified"))
                    {
                        queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "Process could not be started. Specified path not found."));

                        if (MSIDeployment)
                            MSIProcessCouldNotBeStarted(Host);
                    }

                    currentLine = reader.ReadLine();
                }

                if (queueToAdd.Count == 0)
                {
                    queueToAdd.Add(new LogEntry(DateTime.Now, Host, S, "No Log Data Found"));

                    if (MSIDeployment)
                        MSIProcessCouldNotBeStarted(Host);
                }

                UpdateLog(queueToAdd);
            }
        }

        private void UpdateLog(List<LogEntry> queueToAdd)
        {
            for (int i = queueToAdd.Count - 1; i >= 0; i--)
            {
                LogEntry e = queueToAdd[i];
                log.Items.Add( e.LoggedTime.ToLongTimeString() + " " + e.LoggedTime.ToShortDateString());
                int count = log.Items.Count;
                log.Items[count -1].SubItems.Add(e.HostIP);
                log.Items[count - 1].SubItems.Add( e.LogLineMessage );

                if (e.LogLineMessage.Contains("started with process ID"))
                {
                    log.Items[count - 1].StateImageIndex = 0;
                }

                else if (e.LogLineMessage.Contains("Host is inaccessible. Could not start PSExec"))
                {
                    log.Items[count - 1].StateImageIndex = 1;
                }

                else if (e.HostIP == "Deployment")
                {
                    log.Items[count - 1].StateImageIndex = 3;
                }

                else if (e.LogLineMessage.Contains("Authentication failed."))
                {
                    log.Items[count - 1].StateImageIndex = 4;
                }

                else
                {
                    log.Items[count - 1].StateImageIndex = 2;
                }
            }
        }

        private void ProcessConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void log_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (!ProcessManager.processing)
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                log.Sort();
            }

            else
            {
                MessageBox.Show("A deployement is currently in progress. Sorting options will be available once the deployment is complete.",
                                 "Deployment in Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PrepareForDeployment()
        {
            logEntries.Clear();
            log.Items.Clear();
            LogFileLocation.Text = "";
            MSIprogressBar.Value = 0;
            MSIDeploymentPercentage.Text = "0%";
            ActualMSILog.Text = "";
            MSILogList.Items.Clear();
            MSILogFiles.Clear();
            processList.Items.Clear();
            console.Clear();

            if (MSIDeployment)
            {
                for (int i = 0; i < ProcessManager.deployNameList.Count; i++)
                {
                    String Name = ProcessManager.deployNameList[i];
                    MSILogList.Items.Add(Name, Name, -1);
                    MSILogList.Items[i].SubItems.Add("Waiting for process to be started.");
                    MSILogList.Items[i].StateImageIndex = imageList.Images.IndexOfKey("CLIENT DISC");
                }

                MSIprogressBar.Maximum = ProcessManager.deployNameList.Count;
                tabControl1.SelectedIndex = 2;
            }            

            else
            {
                tabControl1.SelectedIndex = 0;
            }

            // Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = 0;
            lvwColumnSorter.Order = SortOrder.Ascending;

            // Perform the sort with these new sort options.
            log.Sort();            
        }

        private void msiLogPollingTimer_Tick(object sender, EventArgs e)
        {
            if (!ProcessManager.processing && MSILogFiles.Count == 0)
            {
                msiLogPollingTimer.Enabled = false;
                AddLogEntry("Deployment", "MSI logging has stopped.");
                return;
            }

            if (!pollingActive)
            {
                if (MSILogFiles.Count == 0)
                    return;

                Thread T = new Thread(new ThreadStart(PollMSILogs));
                T.Start();
            }
        }

        private delegate void MSIStatSetDel(String HostName, String stat, String statImgKey);
        private void MSIStatSet(String HostName, String stat, String statImgKey)
        {

            if (MSILogList.InvokeRequired)
            {
                MSIStatSetDel a = new MSIStatSetDel(MSIStatSet);
                object[] args = new object[] { HostName, stat, statImgKey };
                Invoke(a, args);
            }

            else
            {

                int i = 0;

                do
                {
                    i = MSILogList.Items.IndexOfKey(HostName);

                } while (i < 0);

                lock (StatSetLock)
                {
                    MSILogList.Items[i].SubItems[1].Text = stat;
                    MSILogList.Items[i].StateImageIndex = imageList.Images.IndexOfKey(statImgKey);

                    MSIOK = 0;
                    MSIWARN = 0;
                    MSIERR = 0;
                    MSIWAIT = 0;
                    MSIERRCODE = 0;

                    for (int j = 0; j < MSILogList.Items.Count; j++)
                    {
                        int Index = MSILogList.Items[j].StateImageIndex;

                        if (Index == 0)
                            MSIOK++;
                        else if (Index == 1)
                            MSIERR++;
                        else if (Index == 2)
                            MSIWARN++;
                        else if (Index == 8)
                            MSIWAIT++;
                        else if (Index == 9)
                            MSIERRCODE++;
                    }

                    MSICountTable.Items[0].SubItems[1].Text = MSIOK.ToString();
                    MSICountTable.Items[1].SubItems[1].Text = MSIWARN.ToString();
                    MSICountTable.Items[2].SubItems[1].Text = MSIERR.ToString();
                    MSICountTable.Items[3].SubItems[1].Text = MSIWAIT.ToString();
                    MSICountTable.Items[4].SubItems[1].Text = MSIERRCODE.ToString();

                    if (MSIprogressBar.Value < MSIprogressBar.Maximum)
                    {
                        MSIprogressBar.Value = MSIOK + MSIWARN + MSIERR + MSIERRCODE;
                        MSIDeploymentPercentage.Text = ((int)(Math.Round(((double)MSIprogressBar.Value / (double)MSIprogressBar.Maximum) * 100, 0))).ToString() + "%";
                    }
                }
            }
        }

        private delegate void PollDel();
        private void PollMSILogs()
        {
            lock (pollingLock)
            {
                pollingActive = true;

                for (int i = 0; i < MSILogFiles.Count; i++)
                {
                    if (File.Exists(MSILogFiles[i] + ".txt"))
                    {
                        try
                        {
                            String thisLogHostName = MSILogFiles[i].Substring(MSILogFiles[i].LastIndexOf("\\") + 1);
                            String thisLogFile = MSILogFiles[i] + ".txt";

                            FileStream logFile = new FileStream(thisLogFile, FileMode.Open, FileAccess.Read);
                            StreamReader reader = new StreamReader(logFile);

                            bool indeterminate = true;

                            while (!reader.EndOfStream)
                            {
                                String line = reader.ReadLine();

                                if (line.Contains("Product") && line.Contains(MSIProductName))
                                {
                                    if (line.Contains("Success") || line.Contains("success") )
                                    {
                                        MSIStatSet(thisLogHostName, "Package was successfully installed.", "OK");
                                    }

                                    else if (line.Contains("fail") || line.Contains("Fail") || line.Contains("error") || line.Contains("Error") || line.Contains("Disk full: Out of disk space"))
                                    {
                                        bool errorCode = false;

                                        // Check for specifi error codes
                                        while (!reader.EndOfStream)
                                        {
                                            line = reader.ReadLine();

                                            if (line.Contains("Windows Installer reconfigured") && line.Contains("Reconfiguration success or error status: 1638"))
                                            {
                                                MSIStatSet(thisLogHostName, "Another version of this product is already installed. Installation cannot continue.", "ERROR");
                                                errorCode = true;
                                                break;
                                            }
                                        }

                                        if ( !errorCode)
                                            MSIStatSet(thisLogHostName, "Package installation failed." + (line.Contains("Disk full: Out of disk space") ? " Disk out of space." : ""), "ERROR");
                                    }

                                    MSILogFiles.Remove(thisLogFile.Replace(".txt", ""));
                                    i--;
                                    indeterminate = false;
                                    break;
                                }

                                else if (line.Contains("Failed to connect to server"))
                                {
                                    MSIStatSet(thisLogHostName, "Package installation failed.", "ERROR");

                                    MSILogFiles.Remove(thisLogFile.Replace(".txt", ""));
                                    i--;
                                    indeterminate = false;
                                    break;
                                }

                                else if (line.Contains("Failed to grab mutex for logging"))
                                {
                                    MSIStatSet(thisLogHostName, "Package installation failed.", "ERROR");

                                    MSILogFiles.Remove(thisLogFile.Replace(".txt", ""));
                                    i--;
                                    indeterminate = false;
                                    break;
                                }
                            }

                            reader.Close();
                            logFile.Close();

                            if (indeterminate)
                            {
                                MSIStatSet(thisLogHostName, "Indeterminate log was found.", "FAIL");
                                MSILogFiles.Remove(thisLogFile.Replace(".txt", ""));
                                i--;
                            }

                        }
                        catch { }
                    }
                }

                pollingActive = false;
            }
        }

        private void ProcessConsole_Load(object sender, EventArgs e)
        {

        }

        private void MSILogList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MSILogList.SelectedIndices.Count > 0)
            {
                if (MSILogList.SelectedIndices[0] >= 0)
                {
                    try
                    {
                        int SelectedIndex = MSILogList.SelectedIndices[0];
                        String ThisHost = MSILogList.Items[SelectedIndex].Text;
                        String ThisLogFile = MSILoggingDir.Replace("%computername%", ThisHost) + ThisHost + ".txt";
                        LogFileLocation.Text = ThisLogFile;

                        if (File.Exists(ThisLogFile))
                        {
                            FileStream logFile = new FileStream(ThisLogFile, FileMode.Open, FileAccess.Read);
                            StreamReader reader = new StreamReader(logFile);
                            ActualMSILog.Text = reader.ReadToEnd();
                            reader.Close();
                            logFile.Close();
                            OpenLog.Enabled = true;
                        }

                        else
                        {
                            ActualMSILog.Text = "Log not availble.";
                            OpenLog.Enabled = false;
                        }
                    }
                    catch
                    {
                        ActualMSILog.Text = "Log file is currently in use. Try again.";
                        OpenLog.Enabled = false;
                    }
                }

                else
                {
                    ActualMSILog.Text = "Error accessing log. Try again.";
                    OpenLog.Enabled = false;
                }

            }
            else
            {
                ActualMSILog.Text = "No Hostname or IP selected.";
                OpenLog.Enabled = false;
            }
        }        

        private void log_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (log.Items.Count > 0)
                {
                    if (log.SelectedIndices.Count > 0)
                    {
                        if (log.SelectedIndices[0] > -1)
                        {
                            String theHIPname = log.Items[log.SelectedIndices[0]].SubItems[1].Text;

                            if (theHIPname != "Deployment")
                            {
                                hostName.Text = theHIPname;
                                contextMenu.Show(MousePosition);
                            }
                        }
                    }
                }
            }
        }

        private void processList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (processList.Items.Count > 0)
                {
                    if (processList.SelectedIndex > -1)
                    {
                        hostName.Text = processList.Items[processList.SelectedIndex].ToString();
                        contextMenu.Show(MousePosition);
                    }
                }
            }
        }

        private void MSILogList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MSILogList.Items.Count > 0)
                {
                    if (MSILogList.SelectedIndices.Count > 0)
                    {
                        if (MSILogList.SelectedIndices[0] > -1)
                        {
                            String theHIPname = MSILogList.Items[MSILogList.SelectedIndices[0]].Text;

                            if (theHIPname != "Deployment")
                            {
                                hostName.Text = theHIPname;
                                contextMenu.Show(MousePosition);
                            }
                        }
                    }
                }
            }
        }

        private void pingHost_Click(object sender, EventArgs e)
        {
            pingHostString = hostName.Text;
            Thread t = new Thread( new ThreadStart(PingHost));
            t.Start();
        }

        private void PingHost()
        {
            Ping pingSender = new Ping();

            try
            {
                PingReply reply = pingSender.Send(pingHostString, 5000);
                MessageBox.Show(reply.Status == IPStatus.Success ? "Ping OK." : "Ping failed.", "Ping: " + pingHostString, MessageBoxButtons.OK, reply.Status == IPStatus.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }

            catch
            {
                MessageBox.Show("Network device could not be found.", "Ping Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void remoteToHost_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("mstsc", "/v:" + hostName.Text);
            Process.Start(info);
        }

        private void mangementConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\RemoteManagement.msc"))
            {
                try
                {
                    File.Copy(Settings.LOCAL_UPDATE_DIR + "\\RemoteManagement.msc", Directory.GetCurrentDirectory() + "\\RemoteManagement.msc");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Aquiring RemoteMangement.msc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ProcessStartInfo info = new ProcessStartInfo("mmc", "\"" + Directory.GetCurrentDirectory() + "\\RemoteManagement.msc\" /computer:" + hostName.Text);
            Process.Start(info);
        }

        private void openAdminShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFormAccess.mainForm.IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainFormAccess.mainForm.IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(MainFormAccess.mainForm.LaunchAdminShare));
            t.Start();
        }

        private void publicDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MainFormAccess.mainForm.IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainFormAccess.mainForm.IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(MainFormAccess.mainForm.LaunchAdminShareWin7PubDesk));
            t.Start();
        }

        private void publicStartMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFormAccess.mainForm.IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainFormAccess.mainForm.IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(MainFormAccess.mainForm.LaunchAdminShareWin7PubStartMenu));
            t.Start();
        }

        private void publicDesktopToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MainFormAccess.mainForm.IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainFormAccess.mainForm.IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(MainFormAccess.mainForm.LaunchAdminShareWinXPPubDesk));
            t.Start();
        }

        private void publicStartMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MainFormAccess.mainForm.IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainFormAccess.mainForm.IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(MainFormAccess.mainForm.LaunchAdminShareWinXPPubStartMenu));
            t.Start();
        }

        private void OpenLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(LogFileLocation.Text))
            {
                Process.Start(LogFileLocation.Text);
            }
        }        
    }
}
