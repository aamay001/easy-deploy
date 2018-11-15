using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class PingAll : Form
    {
        private const int MAX_NUM_THREADS = 255;
        private const int PING_TIMEOUT = 1100;
        private List<String> hosts;
        private List<int> indexes;
        bool onlyWorkingWithCheckedItems;
        private static bool stopSignal;
        private static bool pingRunning; 
        private static int currentNum;
        public bool firstInit;
        int totalNum;
        int okStatI;
        int failStatI;
        int errorStatI;
        private static int run;
        private static int runningThreadCount;
        private static Object CounterLock = new Object();

        public PingAll()
        {
            InitializeComponent();
            hosts = new List<String>();
            indexes = new List<int>();
            stopSignal = false;
            pingRunning = false;
            firstInit = true;
        }

        private void PingAll_Load(object sender, EventArgs e)
        {
        }

        private delegate void ChangeStopButtonTextDel(String s);
        private void ChangeStopButtonText(String s)
        {
            if (stop.InvokeRequired)
            {
                ChangeStopButtonTextDel a = new ChangeStopButtonTextDel(ChangeStopButtonText);
                object[] args = new object[] { s };
                Invoke(a, s);
            }

            else
            {
                stop.Text = s;
            }
        }

        private void ResetStats()
        {
            totalStat.Text = "Total: 0";
            okStat.Text = "Ok: 0";
            failStat.Text = "Fail: 0";
            errorStat.Text = "Error: 0";
            okStatI = failStatI = errorStatI = 0;
            run = 0;
        }

        private void ResetFormsOps()
        {
            doneAction.SelectedIndex = -1;
            stopSignal = false;
            done.Enabled = false;
            progressBar1.Value = 0;
            ChangeStopButtonText("Abort");
        }

        public void loadSelectedComputers(bool checkedOnly)
        {
            ResetStats();
            ResetFormsOps();
            onlyWorkingWithCheckedItems = checkedOnly;

            if (firstInit)
            {
                firstInit = false;

                hosts.Clear();
                pingList.Items.Clear();

                if (checkedOnly)
                {
                    for (int i = 0; i < MainFormAccess.mainForm.selectedComputers.CheckedItems.Count; i++)
                    {
                        pingList.Items.Add(MainFormAccess.mainForm.selectedComputers.CheckedItems[i].ToString());
                        pingList.Items[i].SubItems.Add("");
                        hosts.Add(pingList.Items[i].Text);
                        indexes.Add(i);
                    }
                }

                else
                {
                    for (int i = 0; i < MainFormAccess.mainForm.selectedComputers.Items.Count; i++)
                    {
                        pingList.Items.Add(MainFormAccess.mainForm.selectedComputers.Items[i].ToString());
                        pingList.Items[i].SubItems.Add("");
                        hosts.Add(pingList.Items[i].Text);
                        indexes.Add(i);
                    }
                }
            }

            else
            {
                foreach (int i in indexes)
                    SetPingResult("", i);
            }

            totalNum = hosts.Count;
            fraction.Text = "0/" + totalNum;
            progressBar1.Maximum = hosts.Count;
            totalStat.Text = "Total: " + totalNum.ToString();
            run = totalNum;
            runningThreadCount = 0;

            if (hosts.Count > 0)
            {
                pingRunning = true;
                currentNum = 0;
                ThreadStartTimer.Enabled = true;
            }

            else
            {
                IncreaseProgress("Done");
            }
        }

        private void AbortPing()
        {
            IncreaseProgress("Aborted");
        }

        private void PingThreadFunction()
        {
            if (stopSignal)
            {
                return;
            }

            int i = 0;

            lock (CounterLock)
            {
                i = currentNum;
                runningThreadCount++;
                currentNum++;
            }

            if (i >= pingList.Items.Count)
                return;

            SetPingResult("WORKING", i);
            String pingHostString = hosts[i];

            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(pingHostString, PING_TIMEOUT);

                if (reply.Status == IPStatus.Success)
                {
                    SetPingResult("OK", i);
                }

                else
                {
                    SetPingResult("FAIL", i);
                }
            }

            catch
            {
                SetPingResult("ERROR", i);
            }

            IncreaseProgress(pingHostString);

            lock (CounterLock)
            {
                run--;
                runningThreadCount--;
            }            
        }

        private void WaitForThreadsToFinish()
        {
            bool notDone = false;

            do
            {
                if (runningThreadCount == 0)
                    run = 0;

                if (run > 0)
                    notDone = true;

                else if (run == 0)
                {
                    runningThreadCount = 0;
                    notDone = false;
                }

            } while (notDone);

            IncreaseProgress("Done");
        }

        private delegate void IncreaseProgressDel(String nC);
        private void IncreaseProgress(String nextComp)
        {
            if (progressBar1.InvokeRequired )
            {
                IncreaseProgressDel a = new IncreaseProgressDel(IncreaseProgress);
                object[] args = new object[] { nextComp };
                Invoke(a, args);
            }

            else
            {
                if (nextComp == "Done" || nextComp == "Aborted")
                {                                                        
                    okStat.Text = "Ok: " + okStatI.ToString();
                    errorStat.Text = "Error: " + errorStatI.ToString();
                    failStat.Text = "Fail: " + failStatI.ToString();
                    pingRunning = false;
                    ChangeStopButtonText("Restart");
                    stop.Enabled = true;
                    done.Enabled = true;                    
                }

                else
                {
                    fraction.Text = currentNum + "/" + totalNum;
                    progressBar1.PerformStep();                    
                }                
            }
        }        

        private delegate void SetPingResultDel(String res, int i);
        private void SetPingResult(String result, int i)
        {
            if (pingList.InvokeRequired)
            {
                SetPingResultDel a = new SetPingResultDel( SetPingResult );
                object[] args = new object[] { result, i };
                Invoke( a, args );
            }

            else
            {
                pingList.Items[i].SubItems[1].Text = result;

                if (result == "OK")
                {
                    pingList.Items[i].StateImageIndex = 0;
                    okStatI++;
                    okStat.Text = "Ok: " + okStatI.ToString();
                }

                else if (result == "ERROR")
                {
                    pingList.Items[i].StateImageIndex = 1;
                    errorStatI++;
                    errorStat.Text = "Error: " + errorStatI.ToString();
                }

                else if (result == "FAIL")
                {
                    pingList.Items[i].StateImageIndex = 2;
                    failStatI++;
                    failStat.Text = "Fail: " + failStatI.ToString();
                }

                else if (result == "")
                {
                    pingList.Items[i].StateImageIndex = -1;
                }
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pingList.Items.Count; i++)
            {
                if (doneAction.SelectedIndex == 0) // Check all OK 
                {
                    if (onlyWorkingWithCheckedItems)
                    {
                        if (pingList.Items[i].SubItems[1].Text == "OK")
                        {
                            MainFormAccess.mainForm.selectedComputers.SetItemChecked( MainFormAccess.mainForm.selectedComputers.Items.IndexOf( MainFormAccess.mainForm.selectedComputers.CheckedItems[i] ), true );
                            pingList.Items.RemoveAt(i);
                            hosts.RemoveAt( i );
                            --i;
                        }
                    }

                    else
                    {
                        if (pingList.Items[i].SubItems[1].Text == "OK")
                            MainFormAccess.mainForm.selectedComputers.SetItemChecked( i, true );
                    }
                }

                else if (doneAction.SelectedIndex == 1) // Uncheck all Fail and ERROR
                {
                    if (pingList.Items[i].SubItems[1].Text == "FAIL" )
                    {
                        if (onlyWorkingWithCheckedItems)
                        {
                            MainFormAccess.mainForm.selectedComputers.SetItemChecked( MainFormAccess.mainForm.selectedComputers.Items.IndexOf( MainFormAccess.mainForm.selectedComputers.CheckedItems[i] ), false );
                            pingList.Items.RemoveAt(i);
                            hosts.RemoveAt( i );
                            --i;
                        }

                        else
                        {
                            MainFormAccess.mainForm.selectedComputers.SetItemChecked( i, false );
                        }                        
                    }
                }

                else if ( doneAction.SelectedIndex == 3 || doneAction.SelectedIndex == 2 || doneAction.SelectedIndex == 4) // Remove all Fail
                {
                    if (pingList.Items[i].SubItems[1].Text == "FAIL")
                    {
                        pingList.Items.RemoveAt(i);
                        hosts.RemoveAt( i );

                        if (onlyWorkingWithCheckedItems)
                        {
                            MainFormAccess.mainForm.selectedComputers.Items.RemoveAt( MainFormAccess.mainForm.selectedComputers.Items.IndexOf( MainFormAccess.mainForm.selectedComputers.CheckedItems[i] ) );
                        }

                        else
                        {
                            MainFormAccess.mainForm.selectedComputers.Items.RemoveAt( i );
                        }

                        --i;
                    }

                    else if (pingList.Items[i].SubItems[1].Text == "ERROR")
                    {
                        pingList.Items.RemoveAt(i);
                        hosts.RemoveAt( i );

                        if (onlyWorkingWithCheckedItems)
                        {
                            MainFormAccess.mainForm.selectedComputers.Items.RemoveAt( MainFormAccess.mainForm.selectedComputers.Items.IndexOf( MainFormAccess.mainForm.selectedComputers.CheckedItems[i] ) );
                        }

                        else
                        {
                            MainFormAccess.mainForm.selectedComputers.Items.RemoveAt( i );
                        }

                        --i;
                    }
                }
            }

            if (!KeepAlive.Checked)
            {
                Refresh();
                Close();
            }

            else
            {
                indexes.Clear();

                for (int i = 0; i < hosts.Count; i++)
                {
                    indexes.Add( i );
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (pingRunning)
            {
                stopSignal = true;
                stop.Enabled = false;
                run = runningThreadCount;
            }

            else
            {
                loadSelectedComputers(onlyWorkingWithCheckedItems);
            }            
        }

        private void PingAll_Resize(object sender, EventArgs e)
        {

        }

        private void PingAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pingRunning)
            {
                stopSignal = true;
                stop.Enabled = false;
                e.Cancel = true;
            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            runningThreads.Text = "Threads Running: " + runningThreadCount.ToString();
        }

        private void ThreadStartTimer_Tick(object sender, EventArgs e)
        {
            if (stopSignal)
            {
                pingRunning = false;
                ThreadStartTimer.Enabled = false;
                Thread WaitThread = new Thread(new ThreadStart(WaitForThreadsToFinish));
                WaitThread.Start();
                return;
            }

            if (currentNum == totalNum)
            {
                ThreadStartTimer.Enabled = false;
                Thread WaitThread = new Thread(new ThreadStart(WaitForThreadsToFinish));
                WaitThread.Start();
                return;
            }

            // Start this thread
            Thread T = new Thread(new ThreadStart(PingThreadFunction));
            T.Start();
        }
    }
}
