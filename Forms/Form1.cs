using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.DirectoryServices;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.Configuration;
using PsTools_Easy_Deploy_Tool.Forms;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class Form1 : Form
    {
        // Child Forms
        static public PCListDesigner listMaker = new PCListDesigner();
        static private ProcessConsole processConsole = new ProcessConsole();
        static public BatchProcessWindow prepareWindow = new BatchProcessWindow();

        //Static Reference to Start Button
        static Button StartRef = null;

        //Change Log
        static private ChangeLog clog = new ChangeLog();

        // Command Handling
        List<String> commandList;

        // Ping Use
        public String pingHostString;
        public String IsCompAvailablePingString = "";
        static public PingAll pingAllWindow = new PingAll();

        // Relative working path (if set)
        public String workPath = "";

        // About Box
        static private AboutBox1 about = new AboutBox1();
        bool update;

        // Easy Menu Settings Container
        public List<DeploySettings> allSettings = new List<DeploySettings>();

        // MSI Logs
        public static List<String> MSILogs = new List<String>();

        public static Splash screen;

        public Form1()
        {            
            InitializeComponent();
            Hide();
        }

        private void CheckForUpdate()
        {
            if (File.Exists(Settings.LOCAL_UPDATE_DIR + "Easy Deploy.exe"))
            {
                FileVersionInfo serverVersion = FileVersionInfo.GetVersionInfo(Settings.LOCAL_UPDATE_DIR + "Easy Deploy.exe");
                FileVersionInfo current = FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + "\\Easy Deploy.exe");
                Version s = new Version(serverVersion.ProductVersion);
                Version c = new Version(current.ProductVersion);

                if (s > c)
                {
                    update = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update = false;            
            CheckForUpdate();

            if (update)
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\edupdater.exe");
                Close();
                return;
            }

            screen = new Splash(this);
            screen.ShowDialog();

            StartRef = startDeploy;
            MainFormAccess.Init(this);

            LocalNetworkSettings.CheckForLocalDNSServers();
            AppConsole.Init(consoleDisplay, this);         
            commandList = new List<String>();
            username.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            username.Select(username.Text.Length, 0);
            listMaker.initUseList(selectedComputers);
            deployTo.SelectedIndex = 2;
            priority.SelectedIndex = 2;
            //loadEasyFile();
        }        

        private void deployTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            startDeploy.Enabled = true;
            lookUpGroup.Enabled = true;

            if (deployTo.SelectedIndex == 2) // SELECTED COMPUTERS
            {
                selectedComputers.Focus();
            }
        }

        private void selectFileToExecute_Click(object sender, EventArgs e)
        {
            openExecutable.ShowDialog();
        }

        private void checkAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectedComputers.Items.Count; i++)
                selectedComputers.SetItemChecked(i, true);
        }

        private void clearAllChecked_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectedComputers.Items.Count; i++)
                selectedComputers.SetItemChecked(i, false);
        }

        private void openExecutable_FileOk(object sender, CancelEventArgs e)
        {
            PConsoleAccess().ClearMSI();
            executable.Text = openExecutable.FileName;            
        }

        private void writeSelectedComputerList()
        {
            FileStream file = new FileStream("selectedComputers.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            for (int i = 0; i < selectedComputers.CheckedItems.Count; i++)
                writer.WriteLine(selectedComputers.CheckedItems[i].ToString());

            writer.Close();
            file.Close();
        }

        private String buildMultiProcessCommand(String pc)
        {
            String command = "";

            command += "\\\\" + pc + " ";
            ProcessManager.deployNameList.Add(pc);

            command += "-h ";

            if (interactive.Checked)
                command += "-i " + isessionNum.Value.ToString() + " ";

            if (wait.Checked)
                command += "-d ";

            if (relWorkingPath.Checked)
                command += "-w \"" + workPath + "\" ";

            if (copy.Checked)
                command += "-c ";

            if (forceCopy.Checked)
                command += "-f ";

            if (timeOut.Value > 0)
                command += "-n " + timeOut.Value + " ";

            if (credentials.Checked)
                command += "-u " + username.Text + " -p " + password.Text + " ";

            else if (systemAccount.Checked)
                command += "-s ";

            if (priority.SelectedIndex != 2)
            {
                if (priority.SelectedIndex == 0) // LOW
                    command += "-low ";

                else if (priority.SelectedIndex == 1) // BELOW NORMAL
                    command += "-belownormal ";

                else if (priority.SelectedIndex == 3) // ABOVE NORMAL
                    command += "-abovenormal ";

                else if (priority.SelectedIndex == 4) // HIGH
                    command += "-high ";

                else if (priority.SelectedIndex == 5) // REALTIME
                    command += "-realtime ";
            }

            if (executable.Text.Length > 0)
                command += "\"" + executable.Text + "\" ";

            command += arguments.Text.Replace("%computername%", pc);

            return command;
        }

        private delegate void ClearAllLists();
        private void clearLists()
        {
            if (processConsole.processList.InvokeRequired)
            {
                ClearAllLists a = new ClearAllLists(clearLists);
                Invoke(a);
            }

            else
            {
                commandList.Clear();
                processConsole.processList.Items.Clear();
                ProcessConsole.logEntries.Clear();
                ProcessManager.processList.Clear();
                ProcessManager.outputList.Clear();
                ProcessManager.deployNameList.Clear();
            }            
        }

        private void startDeploy_Click(object sender, EventArgs e)
        {
            clearLists();

            if (deployTo.SelectedIndex == 3)
            {
                MessageBox.Show("Deployment to Domain not possible. Feature disabled for security reasons.", "Unable to Deploy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (executable.Text.Length == 0 && arguments.Text.Length == 0)
            {
                MessageBox.Show("You have not selected a file to execute or provided a command.", "Nothing to Execute", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                selectFileToExecute.Focus();
                return;
            }

            if (credentials.Checked)
            {
                if (username.Text.Length < 1)
                {
                    MessageBox.Show("Please enter your user name.", "Credentials Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    username.Focus();
                    return;
                }

                else if (password.Text.Length < 1)
                {
                    MessageBox.Show("Please enter your password.", "Credentials Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    password.Focus();
                    return;
                }
            }

            if (deployTo.SelectedIndex == 2) // SELECTED COMPUTERS
            {
                if (selectedComputers.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please check atleast one computer from the computer list.", "Computer Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    selectedComputers.Focus();
                    return;
                }
            }

            commandList.Clear();

            for (int i = 0; i < selectedComputers.CheckedItems.Count; i++)
            {
                String computer = selectedComputers.CheckedItems[i].ToString();
                commandList.Add(buildMultiProcessCommand(computer));
            }

            for (int i = 0; i < commandList.Count; i++)
            {
                ProcessManager.AddProcess(commandList[i]);
            }

            bool MSIPrepCancelled = false;
            if (processConsole.MSIDeployment)
            {
                Deployment_Prep MSIPrep = new Deployment_Prep();
                DialogResult result = MSIPrep.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    MSIPrepCancelled = true;
                }

                processConsole.MSIprogressBar.Maximum = ProcessManager.deployNameList.Count;                
            }

            if (!MSIPrepCancelled)
            {
                processConsole.PrepareForDeployment();
                processConsole.Show();

                ProcessConsole.currentExecutableOrCommand = (executable.Text.Length > 0 ? executable.Text + " " + arguments.Text : arguments.Text);
                ProcessManager.StartProcessing();

                processConsole.AddLogEntry("Deployment", "Deployment started.");

                ControlBox = false;
                exitToolStripMenuItem.Enabled = false;
            }

            else
            {
                processConsole.AddLogEntry("Deployment", "Deployment cancelled.");
            }
        }

        private void clearExec_Click(object sender, EventArgs e)
        {
            executable.Text = "";
            arguments.Text = "";
            processConsole.ClearMSI();
        }

        private void systemAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (systemAccount.Checked)
            {
                credentials.Enabled = false;
                password.Enabled = false;
                username.Enabled = false;
            }

            else
            {
                credentials.Enabled = true;
                password.Enabled = true;
                username.Enabled = true;
            }
        }

        private void credentials_CheckedChanged(object sender, EventArgs e)
        {
            if (credentials.Checked)
                systemAccount.Enabled = false;

            else
                systemAccount.Enabled = true;
        }

        private void customListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listMaker.selected.BeginUpdate();
            listMaker.selected.Items.Clear();
            foreach (String o in selectedComputers.Items)
            {
                listMaker.selected.Items.Add(o, o, 0);
            }
            listMaker.selected.EndUpdate();
            listMaker.ShowDialog();
        }        

        private void killAllProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager.KillAll();
            prepareWindow.Hide();
            reEnableExitOps();
        }

        private delegate void reEnableExitOpsDel();
        public void reEnableExitOps()
        {
            if (this.InvokeRequired)
            {
                reEnableExitOpsDel a = new reEnableExitOpsDel(reEnableExitOps);
                Invoke(a);
            }

            else
            {
                ControlBox = true;
                startDeploy.Enabled = true;
                exitToolStripMenuItem.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void killCurrentProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager.KillCurrentProcess();            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void compCountTimer_Tick(object sender, EventArgs e)
        {
            totalComps.Text = selectedComputers.Items.Count.ToString();
            selComps.Text = selectedComputers.CheckedItems.Count.ToString();            
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConsole.Clear();
        }

        private void stopPsExecexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] psexec = Process.GetProcessesByName("PsExec");
            if (psexec.Count() > 0)
            {
                psexec[0].Kill();
                AppConsole.WriteLine("PsExec.exe was manually aborted by User.");
            }

            else
            {
                AppConsole.WriteLine("PsExec.exe is not running.");
            }
        }

        private void executable_TextChanged(object sender, EventArgs e)
        {
            if (executable.Text != "")
            {
                if (File.Exists(executable.Text))
                {
                    FileInfo info = new FileInfo(executable.Text);

                    if (info.Extension == ".msi" || info.Extension == ".mst" )
                    {
                        MSIOps MSIWindow = new MSIOps(openExecutable.FileName);
                        DialogResult result = MSIWindow.ShowDialog();
                        arguments.Text = MSIWindow.GetCommandString();
                        executable.Text = "C:\\Windows\\System32\\msiexec.exe";
                        wait.Checked = true;
                        copy.Checked = false;
                        forceCopy.Checked = false;
                        interactive.Checked = false;
                        relWorkingPath.Checked = false;
                        PConsoleAccess().MSIStatProductName.Text = MSIWindow.MSIProductName.Text;
                        PConsoleAccess().MSIStatProductVersion.Text = MSIWindow.MSIPVersion.Text;
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

        private void selectedComputers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (selectedComputers.Items.Count > 0)
                {
                    if (selectedComputers.SelectedIndex > -1)
                    {
                        hostName.Text = selectedComputers.Items[selectedComputers.SelectedIndex].ToString();
                        contextMenu.Show(MousePosition);
                    }
                }
            }
        }

        private void remoteToHost_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("mstsc", "/v:" + hostName.Text);
            Process.Start(info);
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clog.ShowDialog();
        }

        private void pingAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pingAllWindow.loadSelectedComputers( false );
            pingAllWindow.firstInit = true;
            pingAllWindow.ShowDialog();                       
        }

        private void pingAllCheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pingAllWindow.loadSelectedComputers( true );
            pingAllWindow.firstInit = true;
            pingAllWindow.ShowDialog();                       
        }

        private void mangementConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( !File.Exists(Directory.GetCurrentDirectory() + "\\RemoteManagement.msc") )
            {
                try
                {
                    File.Copy( Settings.LOCAL_UPDATE_DIR + "\\RemoteManagement.msc", Directory.GetCurrentDirectory() + "\\RemoteManagement.msc");
                }

                catch ( Exception ex )
                {
                    MessageBox.Show(ex.Message, "Error Aquiring RemoteMangement.msc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ProcessStartInfo info = new ProcessStartInfo("mmc", "\"" + Directory.GetCurrentDirectory() +"\\RemoteManagement.msc\" /computer:" + hostName.Text);
            Process.Start(info);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PConsoleAccess().ClearMSI();
            SetOpsForRestartShutdownCmd();
            arguments.Text = "shutdown -r -t 0";
            MessageBox.Show("Click \"Start Deploy\" to execute command.", "Restart Command Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
            startDeploy.Focus();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PConsoleAccess().ClearMSI();
            SetOpsForRestartShutdownCmd();
            arguments.Text = "shutdown -s -t 0";
            MessageBox.Show("Click \"Start Deploy\" to execute command.", "Shutdown Command Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
            startDeploy.Focus();
        }

        private void installRDPWrapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\RDPWInst.exe"))
            {
                PConsoleAccess().ClearMSI();
                SetOpsForRDPWrapperInstall();
                MessageBox.Show("Click \"Start Deploy\" to execute command.", "Wrapper Install Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startDeploy.Focus();
            }

            else
            {
                MessageBox.Show("RDPWInst.exe is missing. Make sure RDPWinst.exe is in the same directory as Easy Deploy.exe.", "Easy Deploy - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeRDPWrapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\RDPWInst.exe"))
            {
                PConsoleAccess().ClearMSI();
                SetOpsForRDPWrapperRemove();
                MessageBox.Show("Click \"Start Deploy\" to execute command.", "Wrapper Remove Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startDeploy.Focus();
            }

            else
            {
                MessageBox.Show("RDPWInst.exe is missing. Make sure RDPWinst.exe is in the same directory as Easy Deploy.exe.", "Easy Deploy - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void SetOpsForRestartShutdownCmd()
        {
            PConsoleAccess().ClearMSI();
            credentials.Checked = false;
            systemAccount.Checked = true;
            timeOut.Value = 2;
            wait.Checked = true;
            copy.Checked = false;
            forceCopy.Checked = false;
            executable.Clear();
        }

        private void SetOpsForRDPWrapperRemove()
        {
            PConsoleAccess().ClearMSI();
            credentials.Checked = true;
            systemAccount.Checked = false;
            timeOut.Value = 2;
            wait.Checked = true;
            copy.Checked = true;
            forceCopy.Checked = true;
            executable.Text = Directory.GetCurrentDirectory() + "\\RDPWInst.exe";
            arguments.Text = "-u";
        }

        private void SetOpsForRDPWrapperInstall()
        {
            PConsoleAccess().ClearMSI();
            credentials.Checked = true;
            systemAccount.Checked = false;
            timeOut.Value = 2;
            wait.Checked = true;
            copy.Checked = true;
            forceCopy.Checked = true;
            executable.Text = Directory.GetCurrentDirectory() + "\\RDPWInst.exe";
            arguments.Text = "-i";
        }

        /*
        private void loadEasyFile()
        {
            try
            {
                List<DeploySettings> newSettings;
                FileStream file = new FileStream( Settings.EASY_DB_LOCATION + "applist.xml", FileMode.Open, FileAccess.Read );
                XmlSerializer serializer = new XmlSerializer( typeof( List<DeploySettings> ) );
                newSettings = (List<DeploySettings>)serializer.Deserialize( file );
                file.Close();

                foreach (DeploySettings d in newSettings)
                    allSettings.Add( d );

                for (int i = 0; i < allSettings.Count; i++)
                {
                    if (allSettings[i].Type == 0) // Executable
                    {
                        bool exists = false;
                        for (int ii = 0; i < commandsToolStripMenuItem.DropDownItems.Count; ii++)
                        {
                            if (allSettings[i].Name == commandsToolStripMenuItem.DropDownItems[ii].Text)
                                exists = true;
                        }

                        if (!exists)
                        {
                            applicationsToolStripMenuItem.DropDownItems.Add(allSettings[i].Name);
                            applicationsToolStripMenuItem.DropDownItems[applicationsToolStripMenuItem.DropDownItems.Count - 1].Click += new EventHandler(Form1_Click);
                        }
                    }

                    else if (allSettings[i].Type == 1) // Commands
                    {
                        bool exists = false;
                        for (int ii = 0; i < commandsToolStripMenuItem.DropDownItems.Count; ii++)
                        {
                            if (allSettings[i].Name == commandsToolStripMenuItem.DropDownItems[ii].Text)
                                exists = true;
                        }

                        if (!exists)
                        {
                            commandsToolStripMenuItem.DropDownItems.Add(allSettings[i].Name);
                            commandsToolStripMenuItem.DropDownItems[commandsToolStripMenuItem.DropDownItems.Count - 1].Click += new EventHandler(Form1_Click);
                        }
                    }
                }

                List<String> items = new List<String>();

                foreach ( Control c in commandsToolStripMenuItem.DropDownItems )
                    items.Add( c.Text);

                items.Sort();

                for (int i = 0; i < items.Count; i++)
                    commandsToolStripMenuItem.DropDownItems[i].Text = items[i];

                AppConsole.WriteLine( "Easy App configs loaded." );
            }

            catch
            {
                AppConsole.WriteLine( "Easy App configs could not be loaded." );
            }
        }
        

        private void SortEasyAppConfigNames()
        {
            List<String> items = new List<String>();

            foreach (Control c in commandsToolStripMenuItem.DropDownItems)
                items.Add(c.Text);

            items.Sort();

            for (int i = 0; i < items.Count; i++)
                commandsToolStripMenuItem.DropDownItems[i].Text = items[i];

            items = new List<String>();

            foreach (Control c in applicationsToolStripMenuItem.DropDownItems)
                items.Add(c.Text);

            items.Sort();

            for (int i = 0; i < items.Count; i++)
                applicationsToolStripMenuItem.DropDownItems[i].Text = items[i];
        }
         * */

        void Form1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allSettings.Count; i++)
            {
                if (allSettings[i].Name == ((ToolStripMenuItem)(sender)).Text)
                {
                    // Set the settings
                    ClearDeployOps();
                    SetEasySettings(allSettings[i]);
                }
            }
        }

        private void ClearDeployOps()
        {
            systemAccount.Checked = false;
            credentials.Checked = false;
            copy.Checked = false;
            forceCopy.Checked = false;
            wait.Checked = false;
            priority.SelectedIndex = 2;
            executable.Clear();
            arguments.Clear();
        }

        private void SetEasySettings(DeploySettings d)
        {
            systemAccount.Checked = d.UseSystem;
            credentials.Checked = d.UseCredentials;
            timeOut.Value = (decimal)d.ConnectionTimeout;
            copy.Checked = d.CopyExecutable;
            forceCopy.Checked = d.OverwriteExisting;
            wait.Checked = d.DontWait;
            priority.SelectedIndex = d.RunPriorityIndex;

            if ( d.Executable.Length > 0 )
                executable.Text = d.Executable;

            if ( d.CommandArgs.Length > 0 )
                arguments.Text = d.CommandArgs;

            MessageBox.Show("Click \"Start Deploy\" to run the command.", "Easy Settings Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void relWorkingPath_CheckedChanged(object sender, EventArgs e)
        {
            if (relWorkingPath.Checked)
            {
                WorkingDirSet dialog = new WorkingDirSet(this, workPath);
                dialog.ShowDialog();
            }
        }

        private void interactive_CheckedChanged(object sender, EventArgs e)
        {
            if (interactive.Checked)
                MessageBox.Show("Interactive process requires a local account on the remote machine. Make sure to use the proper credentials.",
                                "Interactive Process", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void openAdminShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(LaunchAdminShare));
            t.Start();
        }

        public void LaunchAdminShare()
        {
            if (IsComputerAvailable())
            {
                try
                {
                    Process.Start("explorer.exe", "\\\\" + IsCompAvailablePingString + "\\C$");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "PsExec Error: " + e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show(IsCompAvailablePingString + " is not available. Try again later.", "Host Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IsCompAvailablePingString = "";
        }

        private bool IsComputerAvailable()
        {
            Ping pingSender = new Ping();

            try
            {
                PingReply reply = pingSender.Send(IsCompAvailablePingString, 2000);

                if (reply.Status == IPStatus.Success)
                    return true;
            }

            catch
            {
                return false;
            }

            return false;
        }

        private delegate void DisableStartDel();
        public void DisableStart()
        {
            if (StartRef.InvokeRequired)
            {
                DisableStartDel a = new DisableStartDel(DisableStart);
                Invoke(a);
            }

            else
            {
                StartRef.Enabled = false;
            }
        }

        private delegate void EnableStartDel();
        public void EnableStart()
        {
            if (StartRef.InvokeRequired)
            {
                EnableStartDel a = new EnableStartDel(EnableStart);
                Invoke(a);
            }

            else
            {
                StartRef.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProcessManager.processing)
            {
                DialogResult result = MessageBox.Show("A deployment is currently in progress. Are you sure you want to close the application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.No)
                {               
                    e.Cancel = true;
                    return;
                }
            }

            ProcessManager.KillAll();
            ActiveDir.StopUpdate();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedComputers.Items.RemoveAt(selectedComputers.SelectedIndex);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selectedComputers.Items[selectedComputers.SelectedIndex].ToString());
        }

        private void ListEditButton_Click( object sender, EventArgs e )
        {
            customListToolStripMenuItem_Click( sender, e );
        }

        private void publicDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(LaunchAdminShareWin7PubDesk));
            t.Start();
        }

        public void LaunchAdminShareWin7PubDesk()
        {
            if (IsComputerAvailable())
            {
                try
                {
                    Process.Start("explorer.exe", "\\\\" + IsCompAvailablePingString + "\\C$\\Users\\Public\\Desktop");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "PsExec Error: " + e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            else
            {
                MessageBox.Show(IsCompAvailablePingString + " is not available. Try again later.", "Host Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IsCompAvailablePingString = "";
        }

        public void LaunchAdminShareWin7PubStartMenu()
        {
            if (IsComputerAvailable())
            {
                try
                {
                    Process.Start("explorer.exe", "\\\\" + IsCompAvailablePingString + "\\C$\\ProgramData\\Microsoft\\Windows\\Start Menu");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "PsExec Error: " + e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show(IsCompAvailablePingString + " is not available. Try again later.", "Host Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IsCompAvailablePingString = "";
        }

        private void publicStartMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsCompAvailablePingString != "")
            {
                MessageBox.Show("Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread(new ThreadStart(LaunchAdminShareWin7PubStartMenu));
            t.Start();

        }

        private void publicDesktopToolStripMenuItem2_Click( object sender, EventArgs e )
        {
            if (IsCompAvailablePingString != "")
            {
                MessageBox.Show( "Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread( new ThreadStart( LaunchAdminShareWinXPPubDesk ) );
            t.Start();
        }

        public void LaunchAdminShareWinXPPubDesk()
        {
            if (IsComputerAvailable())
            {
                try
                {
                    Process.Start( "explorer.exe", "\\\\" + IsCompAvailablePingString + "\\C$\\Documents and Settings\\All Users\\Desktop" );
                }
                catch (Exception e)
                {
                    MessageBox.Show( e.Message, "PsExec Error: " + e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            else
            {
                MessageBox.Show( IsCompAvailablePingString + " is not available. Try again later.", "Host Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }

            IsCompAvailablePingString = "";
        }

        public void LaunchAdminShareWinXPPubStartMenu()
        {
            if (IsComputerAvailable())
            {
                try
                {
                    Process.Start( "explorer.exe", "\\\\" + IsCompAvailablePingString + "\\C$\\Documents and Settings\\All Users\\Start Menu" );
                }
                catch (Exception e)
                {
                    MessageBox.Show( e.Message, "PsExec Error: " + e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            else
            {
                MessageBox.Show( IsCompAvailablePingString + " is not available. Try again later.", "Host Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }

            IsCompAvailablePingString = "";
        }

        private void publicStartMenuToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            if (IsCompAvailablePingString != "")
            {
                MessageBox.Show( "Application is busy checking another host. Please try again.", "Application Busy", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            IsCompAvailablePingString = hostName.Text;

            Thread t = new Thread( new ThreadStart( LaunchAdminShareWinXPPubStartMenu ) );
            t.Start();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }

        delegate void ShowConsoleDel();
        public void ShowProcessConsole()
        {
            if (processConsole.InvokeRequired)
            {
                ShowConsoleDel a = new ShowConsoleDel(ShowProcessConsole);
                Invoke(a);
            }
            else
            {
                processConsole.clearSelect_Click(null, null);

                if (!processConsole.Visible)
                {
                    processConsole.Show();
                }

                else if (processConsole.WindowState == FormWindowState.Minimized)
                {
                    processConsole.WindowState = FormWindowState.Normal;
                }

                else
                {
                    processConsole.Focus();
                }
            }
        }

        private void openProcessConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProcessConsole();
        }

        private void arguments_TextChanged(object sender, EventArgs e)
        {
            
        }

        private delegate bool IsPConsoleVis();
        public bool IsProcessConsoleVisible()
        {
            if (processConsole.InvokeRequired)
            {
                IsPConsoleVis a = new IsPConsoleVis(IsProcessConsoleVisible);
                Invoke(a);
            }

            else
            {
                return processConsole.Visible;
            }

            return false;
        }

        public ProcessConsole PConsoleAccess()
        {
            return processConsole;
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsManager SetWin = new SettingsManager();
            SetWin.ShowDialog();
        }

                  
    }
}
