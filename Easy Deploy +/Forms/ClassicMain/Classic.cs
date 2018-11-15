using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Easy_Deploy.Utilities;
using BrightIdeasSoftware;
using Easy_Deploy.Deployment;
using Easy_Deploy.CollectionManagement;
using Easy_Deploy.Utilities.Forms;
using System.Threading;

namespace Easy_Deploy.Forms
{
    
    public partial class Classic : Form
    {
        private String workingDirectory = "";        

        public Classic()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLogToConsole();                     
            Log.Information("Easy Deploy+ Classic UI loaded.");
            LocalNetworkSettings.Initialize();
            CollectionResources.Initialize();
            CollectionResources.ActiveDirectory.StatusChanged += ActiveDirectoryInterface_StatusChanged;            
        }

        private void ActiveDirectoryInterface_StatusChanged(object sender, EventArgs e)
        {
            SetADSyncImage(CollectionResources.ActiveDirectory.Status);            
        }

        private delegate void SetADSyncImageDel(ActiveDirectoryInterfaceStatus S);
        private void SetADSyncImage( ActiveDirectoryInterfaceStatus Status )
        {
            if (statusStrip.InvokeRequired)
            {
                SetADSyncImageDel a = new SetADSyncImageDel(SetADSyncImage);
                object[] args = new object[] { Status };
                Invoke(a, args);
            }

            else
            {
                if ( Status == ActiveDirectoryInterfaceStatus.Synchronizing)
                {
                    statusActiveDirSync.Enabled = true;
                    statusActiveDirSync.Visible = true;
                    statusActiveDirSync.Image = Properties.Resources.loadanim;
                }

                else
                {
                    statusActiveDirSync.Image = null;
                    statusActiveDirSync.Enabled = false;
                    statusActiveDirSync.Visible = false;
                }

                statusActiveDirSync.Text = "Active Directory: " + Status.ToString();
            }
        }

        private void btnStartDeployment_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Code that runs before the application closes completely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Classic_FormClosing(object sender, FormClosingEventArgs e)
        {
            CollectionResources.ActiveDirectory.Abort();
            DisconnectLogFromConsole();
        }

        #region Console Log Updating

        /// <summary>
        /// Cause the Log list UI to update when new entries are added to the log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entries_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateLogConsole();
        }

        /// <summary>
        /// Hook the Log into the Classic UI Console / Log Tab in the 
        /// information section.
        /// </summary>
        private void ConnectLogToConsole()
        {
            Log.Entries.CollectionChanged += Entries_CollectionChanged;
            olvLogDate.ImageGetter = new ImageGetterDelegate(LogItemImageGetter);
            olvConsoleLog.SetObjects(Log.Entries);
            UpdateLogConsole();
        }

        /// <summary>
        /// Stop Log from updates to the Console / Log Tab.
        /// </summary>
        private void DisconnectLogFromConsole()
        {
            Log.Entries.CollectionChanged -= Entries_CollectionChanged;
        }

        /// <summary>
        /// Gets the image index for an added message to the messages view.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public object LogItemImageGetter(object rowObject)
        {
            LogEntry M = (LogEntry)rowObject;
            return (int)M.Type;
        }        

        /// <summary>
        /// Refresh the Console / Log list view.
        /// </summary>
        private void UpdateLogConsole()
        {
            try
            {
                olvConsoleLog.BuildList();
            }

            catch ( Exception e)
            {
                Log.Error("Debug code.", e);
            }

        }
        #endregion

        #region Control Events

        /// <summary>
        /// Use System Checkbox; disables use credentials checkbox, username, and password textboxes
        /// when it it checked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSystem.Checked)
            {
                chkUseCredentials.Enabled = false;
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
            }

            else
            {
                chkUseCredentials.Enabled = true;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
            }
        }

        /// <summary>
        /// Use Credentials checkbox; disables the use system checkbox when checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseCredentials.Checked)
                chkSystem.Enabled = false;

            else
                chkSystem.Enabled = true;
        }

        /// <summary>
        /// Interactive Session checkbox; displays a message to the user when checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkInteractive_CheckedChanged(object sender, EventArgs e)
        {
            if ( chkInteractive.Checked )
            {
                MessageBox.Show("Interactive process requires an account with local admin rights on the remote machine. Make sure to use proper credentials.",
                                "Easy Deploy+ Interactive", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Checks all computers in the computer list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAllComputers_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < chklstSelectedComputers.Items.Count; i++ )
                chklstSelectedComputers.SetItemChecked(i, true);
        }

        /// <summary>
        /// Unchecked all chekced computers in the computer list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAllComputers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstSelectedComputers.Items.Count; i++)
                chklstSelectedComputers.SetItemChecked(i, false);
        }

        /// <summary>
        /// Opend the file open dialog for the executable when the file to execute 
        /// textbox is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExecutingFile_Click(object sender, EventArgs e)
        {
            try
            {
                fodExecutionFile.ShowDialog();
            }

            catch ( Exception ex)
            {
                Log.CriticalError("Fatal error.", ex);
            }
        }

        /// <summary>
        /// File Open Dialog OK. Sets the file to be executed in the executable textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fodExecutionFile_FileOk(object sender, CancelEventArgs e)
        {
            txtExecutingFile.Text = fodExecutionFile.FileName;
            txtExecutingFile.Select(0, 0);
        }

        /// <summary>
        /// Clear button in the deployment section. Clears the executable textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExecutingFile.Text = "";
        }

        /// <summary>
        /// Workgin Directory checkbox; brings up the Working Directory Selection
        /// dialog when the checkbox is cheked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkWorkingDir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWorkingDir.Checked)
            {
                WorkingDirectorySelection WorkDirSel = new WorkingDirectorySelection(workingDirectory);
                workingDirectory = WorkDirSel.ShowSelectionDialog();

                if ( workingDirectory == "")
                {
                    chkWorkingDir.Checked = false;                    
                }

                else
                {
                    Log.Information("Working Directory was enabled.");
                    Log.Information("Working Directory is set to " + workingDirectory);
                }
            }

            else
            {
                workingDirectory = "";
                Log.Information("Working Directory was disabled.");
            }
        }

        #endregion

        private void btnSelectComputers_Click(object sender, EventArgs e)
        {
            CollectionResources.Console.Show();
        }

        private void olvConsoleLog_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (e.Model != null)
                {
                    LogEntry selectedItem = ((LogEntry)(e.Model));
                    LogEntryDetailViewer dv = new LogEntryDetailViewer(selectedItem);
                    dv.ShowDialog();
                }
            }
        }

        private void clearStoredCollectionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComputerCollections = "";
            Properties.Settings.Default.Save();
        }
    }
}
