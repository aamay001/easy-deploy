using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace PsTools_Easy_Deploy_Tool.Forms
{
    public partial class Deployment_Prep : Form
    {
        public Deployment_Prep()
        {
            InitializeComponent();
        }

        Thread PrepThread;
        bool cancelled;

        private void Deployment_Prep_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = ProcessManager.deployNameList.Count;
            progressBar1.Value = 0;
            StatusLabel.Text = "Verifying Directories : " + ProcessManager.deployNameList[0];
            cancelled = false;

            PrepThread = new Thread(new ThreadStart(PrepFunc));
            PrepThread.Start();
        }

        private void PrepFunc()
        {
            for (int i = 0; i < ProcessManager.deployNameList.Count; i++)
            {
                if (cancelled)
                    break;

                String thisHost = ProcessManager.deployNameList[i];

                if (!Directory.Exists(Settings.LOGGING_DIR.Replace("%computername%", thisHost)))
                {
                    try
                    {
                        Directory.CreateDirectory(Settings.LOGGING_DIR.Replace("%computername%", thisHost));
                    }

                    catch
                    {

                    }                    
                }

                if (!Directory.Exists(Settings.LOGGING_DIR.Replace("%computername%", thisHost) + "\\MSI"))
                {
                    try
                    {
                        Directory.CreateDirectory(Settings.LOGGING_DIR.Replace("%computername%", thisHost) + "\\MSI");
                    }

                    catch
                    {

                    }
                }

                else if (File.Exists(Settings.LOGGING_DIR.Replace("%computername%", thisHost) + "\\MSI" + "\\" + thisHost + ".txt"))
                {
                    File.Delete(Settings.LOGGING_DIR.Replace("%computername%", thisHost) + "\\MSI" + "\\" + thisHost + ".txt");
                }

                if (cancelled)
                    break;

                IncrementProgress();
            }
        }

        private delegate void IncrementProgressDel();
        private void IncrementProgress()
        {
            if (cancelled)
                return;

            if (progressBar1.InvokeRequired)
            {
                try
                {
                    IncrementProgressDel a = new IncrementProgressDel(IncrementProgress);
                    Invoke(a);
                }
                catch { }
            }

            else
            {
                try
                {
                    progressBar1.PerformStep();
                    prepPercent.Text = ((int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100)).ToString() + "%";

                    if (progressBar1.Value < progressBar1.Maximum - 1)
                        StatusLabel.Text = "Verifying Directories : " + ProcessManager.deployNameList[progressBar1.Value];

                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
                catch { }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cancelled = true;
        }
    }
}
