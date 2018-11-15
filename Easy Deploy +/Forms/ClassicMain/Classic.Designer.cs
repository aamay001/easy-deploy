namespace Easy_Deploy.Forms
{
    partial class Classic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classic));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.installRDPWrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRDPWrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.failureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCurrentProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killPsExecexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStoredCollectionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDeployment = new System.Windows.Forms.GroupBox();
            this.txtArgsOrCommand = new System.Windows.Forms.TextBox();
            this.txtExecutingFile = new System.Windows.Forms.TextBox();
            this.btnSelectComputers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.numConnectionTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSessionNum = new System.Windows.Forms.NumericUpDown();
            this.chkInteractive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDontWait = new System.Windows.Forms.CheckBox();
            this.chkWorkingDir = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkUseCredentials = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpComputers = new System.Windows.Forms.GroupBox();
            this.chklstSelectedComputers = new System.Windows.Forms.CheckedListBox();
            this.btnClearAllComputers = new System.Windows.Forms.Button();
            this.btnCheckAllComputers = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusActiveDirSync = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpLogInfo = new System.Windows.Forms.GroupBox();
            this.tcInfoTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.olvConsoleLog = new BrightIdeasSoftware.ObjectListView();
            this.olvLogDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLogType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLogMessage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListConsoleLog = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.olvDeploymentsQuickStat = new BrightIdeasSoftware.ObjectListView();
            this.olvDeploymentName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentRuntime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentSuccess = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentFail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentTotal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentPercentageComplete = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeploymentMessage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.fodExecutionFile = new System.Windows.Forms.OpenFileDialog();
            this.btnStartDeployment = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.grpDeployment.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSessionNum)).BeginInit();
            this.grpCredentials.SuspendLayout();
            this.grpComputers.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpLogInfo.SuspendLayout();
            this.tcInfoTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvConsoleLog)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDeploymentsQuickStat)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.computersToolStripMenuItem,
            this.reportingToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1151, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.installRDPWrapperToolStripMenuItem,
            this.removeRDPWrapperToolStripMenuItem,
            this.toolStripSeparator2,
            this.pingToolStripMenuItem,
            this.pingCheckedToolStripMenuItem,
            this.toolStripSeparator3,
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem});
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.computersToolStripMenuItem.Text = "Computers";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // installRDPWrapperToolStripMenuItem
            // 
            this.installRDPWrapperToolStripMenuItem.Name = "installRDPWrapperToolStripMenuItem";
            this.installRDPWrapperToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.installRDPWrapperToolStripMenuItem.Text = "Install RDP Wrapper";
            // 
            // removeRDPWrapperToolStripMenuItem
            // 
            this.removeRDPWrapperToolStripMenuItem.Name = "removeRDPWrapperToolStripMenuItem";
            this.removeRDPWrapperToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removeRDPWrapperToolStripMenuItem.Text = "Remove RDP Wrapper";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            // 
            // pingCheckedToolStripMenuItem
            // 
            this.pingCheckedToolStripMenuItem.Name = "pingCheckedToolStripMenuItem";
            this.pingCheckedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pingCheckedToolStripMenuItem.Text = "Ping Checked";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.failureToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportingToolStripMenuItem.Text = "Reports";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.processToolStripMenuItem.Text = "Processing";
            // 
            // failureToolStripMenuItem
            // 
            this.failureToolStripMenuItem.Name = "failureToolStripMenuItem";
            this.failureToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.failureToolStripMenuItem.Text = "Failure";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopAllProcessingToolStripMenuItem,
            this.stopCurrentProcessToolStripMenuItem,
            this.killPsExecexeToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // stopAllProcessingToolStripMenuItem
            // 
            this.stopAllProcessingToolStripMenuItem.Name = "stopAllProcessingToolStripMenuItem";
            this.stopAllProcessingToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.stopAllProcessingToolStripMenuItem.Text = "Stop All Processing";
            // 
            // stopCurrentProcessToolStripMenuItem
            // 
            this.stopCurrentProcessToolStripMenuItem.Name = "stopCurrentProcessToolStripMenuItem";
            this.stopCurrentProcessToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.stopCurrentProcessToolStripMenuItem.Text = "Stop Current Process";
            // 
            // killPsExecexeToolStripMenuItem
            // 
            this.killPsExecexeToolStripMenuItem.Name = "killPsExecexeToolStripMenuItem";
            this.killPsExecexeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.killPsExecexeToolStripMenuItem.Text = "Kill PsExec.exe";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearStoredCollectionDataToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // clearStoredCollectionDataToolStripMenuItem
            // 
            this.clearStoredCollectionDataToolStripMenuItem.Name = "clearStoredCollectionDataToolStripMenuItem";
            this.clearStoredCollectionDataToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearStoredCollectionDataToolStripMenuItem.Text = "Clear Stored Collection Data";
            this.clearStoredCollectionDataToolStripMenuItem.Click += new System.EventHandler(this.clearStoredCollectionDataToolStripMenuItem_Click);
            // 
            // grpDeployment
            // 
            this.grpDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeployment.Controls.Add(this.txtArgsOrCommand);
            this.grpDeployment.Controls.Add(this.txtExecutingFile);
            this.grpDeployment.Controls.Add(this.btnSelectComputers);
            this.grpDeployment.Controls.Add(this.btnClear);
            this.grpDeployment.Controls.Add(this.label2);
            this.grpDeployment.Controls.Add(this.label1);
            this.grpDeployment.Controls.Add(this.label5);
            this.grpDeployment.Location = new System.Drawing.Point(15, 36);
            this.grpDeployment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeployment.Name = "grpDeployment";
            this.grpDeployment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeployment.Size = new System.Drawing.Size(306, 230);
            this.grpDeployment.TabIndex = 0;
            this.grpDeployment.TabStop = false;
            this.grpDeployment.Text = "Deployment";
            // 
            // txtArgsOrCommand
            // 
            this.txtArgsOrCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArgsOrCommand.Location = new System.Drawing.Point(14, 136);
            this.txtArgsOrCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArgsOrCommand.Name = "txtArgsOrCommand";
            this.txtArgsOrCommand.Size = new System.Drawing.Size(279, 25);
            this.txtArgsOrCommand.TabIndex = 2;
            // 
            // txtExecutingFile
            // 
            this.txtExecutingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExecutingFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExecutingFile.Location = new System.Drawing.Point(14, 57);
            this.txtExecutingFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExecutingFile.Name = "txtExecutingFile";
            this.txtExecutingFile.ReadOnly = true;
            this.txtExecutingFile.Size = new System.Drawing.Size(279, 25);
            this.txtExecutingFile.TabIndex = 0;
            this.txtExecutingFile.Click += new System.EventHandler(this.txtExecutingFile_Click);
            // 
            // btnSelectComputers
            // 
            this.btnSelectComputers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectComputers.Image = global::Easy_Deploy.Properties.Resources.collectionMember;
            this.btnSelectComputers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectComputers.Location = new System.Drawing.Point(14, 181);
            this.btnSelectComputers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectComputers.Name = "btnSelectComputers";
            this.btnSelectComputers.Size = new System.Drawing.Size(279, 30);
            this.btnSelectComputers.TabIndex = 3;
            this.btnSelectComputers.Text = "Computers";
            this.btnSelectComputers.UseVisualStyleBackColor = true;
            this.btnSelectComputers.Click += new System.EventHandler(this.btnSelectComputers_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(224, 89);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arguments or command:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "File to execute:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "1";
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.numConnectionTimeOut);
            this.grpSettings.Controls.Add(this.label6);
            this.grpSettings.Controls.Add(this.cbxPriority);
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.numSessionNum);
            this.grpSettings.Controls.Add(this.chkInteractive);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.chkDontWait);
            this.grpSettings.Controls.Add(this.chkWorkingDir);
            this.grpSettings.Controls.Add(this.chkOverwrite);
            this.grpSettings.Controls.Add(this.chkCopy);
            this.grpSettings.Location = new System.Drawing.Point(327, 37);
            this.grpSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSettings.Size = new System.Drawing.Size(273, 230);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // numConnectionTimeOut
            // 
            this.numConnectionTimeOut.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numConnectionTimeOut.Location = new System.Drawing.Point(204, 53);
            this.numConnectionTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numConnectionTimeOut.Name = "numConnectionTimeOut";
            this.numConnectionTimeOut.Size = new System.Drawing.Size(57, 22);
            this.numConnectionTimeOut.TabIndex = 7;
            this.numConnectionTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "2";
            // 
            // cbxPriority
            // 
            this.cbxPriority.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Items.AddRange(new object[] {
            "Low",
            "Below Normal",
            "Normal",
            "Above Normal",
            "High",
            "Realtime"});
            this.cbxPriority.Location = new System.Drawing.Point(126, 191);
            this.cbxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(135, 23);
            this.cbxPriority.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Run Priority :";
            // 
            // numSessionNum
            // 
            this.numSessionNum.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSessionNum.Location = new System.Drawing.Point(204, 137);
            this.numSessionNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSessionNum.Name = "numSessionNum";
            this.numSessionNum.Size = new System.Drawing.Size(57, 22);
            this.numSessionNum.TabIndex = 5;
            this.numSessionNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkInteractive
            // 
            this.chkInteractive.AutoSize = true;
            this.chkInteractive.Location = new System.Drawing.Point(19, 134);
            this.chkInteractive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInteractive.Name = "chkInteractive";
            this.chkInteractive.Size = new System.Drawing.Size(150, 23);
            this.chkInteractive.TabIndex = 4;
            this.chkInteractive.Text = "Interactive - Session :";
            this.chkInteractive.UseVisualStyleBackColor = true;
            this.chkInteractive.CheckedChanged += new System.EventHandler(this.chkInteractive_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Connection Timeout :";
            // 
            // chkDontWait
            // 
            this.chkDontWait.AutoSize = true;
            this.chkDontWait.Location = new System.Drawing.Point(19, 105);
            this.chkDontWait.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDontWait.Name = "chkDontWait";
            this.chkDontWait.Size = new System.Drawing.Size(88, 23);
            this.chkDontWait.TabIndex = 2;
            this.chkDontWait.Text = "Don\'t Wait";
            this.chkDontWait.UseVisualStyleBackColor = true;
            // 
            // chkWorkingDir
            // 
            this.chkWorkingDir.AutoSize = true;
            this.chkWorkingDir.Location = new System.Drawing.Point(19, 163);
            this.chkWorkingDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWorkingDir.Name = "chkWorkingDir";
            this.chkWorkingDir.Size = new System.Drawing.Size(135, 23);
            this.chkWorkingDir.TabIndex = 3;
            this.chkWorkingDir.Text = "Working Directory";
            this.chkWorkingDir.UseVisualStyleBackColor = true;
            this.chkWorkingDir.CheckedChanged += new System.EventHandler(this.chkWorkingDir_CheckedChanged);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(97, 76);
            this.chkOverwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(86, 23);
            this.chkOverwrite.TabIndex = 1;
            this.chkOverwrite.Text = "Overwrite";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Location = new System.Drawing.Point(19, 76);
            this.chkCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(59, 23);
            this.chkCopy.TabIndex = 0;
            this.chkCopy.Text = "Copy";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // grpCredentials
            // 
            this.grpCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.txtUserName);
            this.grpCredentials.Controls.Add(this.chkUseCredentials);
            this.grpCredentials.Controls.Add(this.chkSystem);
            this.grpCredentials.Controls.Add(this.label9);
            this.grpCredentials.Controls.Add(this.label8);
            this.grpCredentials.Controls.Add(this.label7);
            this.grpCredentials.Location = new System.Drawing.Point(606, 36);
            this.grpCredentials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCredentials.Size = new System.Drawing.Size(298, 186);
            this.grpCredentials.TabIndex = 2;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(14, 117);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(271, 25);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(14, 60);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 25);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.WordWrap = false;
            // 
            // chkUseCredentials
            // 
            this.chkUseCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseCredentials.AutoSize = true;
            this.chkUseCredentials.Location = new System.Drawing.Point(170, 154);
            this.chkUseCredentials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUseCredentials.Name = "chkUseCredentials";
            this.chkUseCredentials.Size = new System.Drawing.Size(118, 23);
            this.chkUseCredentials.TabIndex = 17;
            this.chkUseCredentials.Text = "Use Credentials";
            this.chkUseCredentials.UseVisualStyleBackColor = true;
            this.chkUseCredentials.CheckedChanged += new System.EventHandler(this.chkUseCredentials_CheckedChanged);
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Location = new System.Drawing.Point(14, 154);
            this.chkSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(94, 23);
            this.chkSystem.TabIndex = 16;
            this.chkSystem.Text = "Use System";
            this.chkSystem.UseVisualStyleBackColor = true;
            this.chkSystem.CheckedChanged += new System.EventHandler(this.chkSystem_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "3";
            // 
            // grpComputers
            // 
            this.grpComputers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpComputers.Controls.Add(this.chklstSelectedComputers);
            this.grpComputers.Controls.Add(this.btnClearAllComputers);
            this.grpComputers.Controls.Add(this.btnCheckAllComputers);
            this.grpComputers.Location = new System.Drawing.Point(910, 36);
            this.grpComputers.Name = "grpComputers";
            this.grpComputers.Size = new System.Drawing.Size(227, 599);
            this.grpComputers.TabIndex = 4;
            this.grpComputers.TabStop = false;
            this.grpComputers.Text = "Computers";
            // 
            // chklstSelectedComputers
            // 
            this.chklstSelectedComputers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstSelectedComputers.CausesValidation = false;
            this.chklstSelectedComputers.CheckOnClick = true;
            this.chklstSelectedComputers.FormattingEnabled = true;
            this.chklstSelectedComputers.Location = new System.Drawing.Point(16, 26);
            this.chklstSelectedComputers.Name = "chklstSelectedComputers";
            this.chklstSelectedComputers.Size = new System.Drawing.Size(198, 524);
            this.chklstSelectedComputers.TabIndex = 0;
            // 
            // btnClearAllComputers
            // 
            this.btnClearAllComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllComputers.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllComputers.Location = new System.Drawing.Point(121, 556);
            this.btnClearAllComputers.Name = "btnClearAllComputers";
            this.btnClearAllComputers.Size = new System.Drawing.Size(93, 34);
            this.btnClearAllComputers.TabIndex = 2;
            this.btnClearAllComputers.Text = "Clear All";
            this.btnClearAllComputers.UseVisualStyleBackColor = true;
            this.btnClearAllComputers.Click += new System.EventHandler(this.btnClearAllComputers_Click);
            // 
            // btnCheckAllComputers
            // 
            this.btnCheckAllComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAllComputers.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAllComputers.Location = new System.Drawing.Point(16, 556);
            this.btnCheckAllComputers.Name = "btnCheckAllComputers";
            this.btnCheckAllComputers.Size = new System.Drawing.Size(93, 34);
            this.btnCheckAllComputers.TabIndex = 1;
            this.btnCheckAllComputers.Text = "Check All";
            this.btnCheckAllComputers.UseVisualStyleBackColor = true;
            this.btnCheckAllComputers.Click += new System.EventHandler(this.btnCheckAllComputers_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusActiveDirSync});
            this.statusStrip.Location = new System.Drawing.Point(0, 645);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1151, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusActiveDirSync
            // 
            this.statusActiveDirSync.Name = "statusActiveDirSync";
            this.statusActiveDirSync.Size = new System.Drawing.Size(0, 17);
            // 
            // grpLogInfo
            // 
            this.grpLogInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLogInfo.Controls.Add(this.tcInfoTabs);
            this.grpLogInfo.Location = new System.Drawing.Point(15, 272);
            this.grpLogInfo.Name = "grpLogInfo";
            this.grpLogInfo.Size = new System.Drawing.Size(889, 363);
            this.grpLogInfo.TabIndex = 6;
            this.grpLogInfo.TabStop = false;
            this.grpLogInfo.Text = "Information";
            // 
            // tcInfoTabs
            // 
            this.tcInfoTabs.Controls.Add(this.tabPage1);
            this.tcInfoTabs.Controls.Add(this.tabPage2);
            this.tcInfoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInfoTabs.ImageList = this.imageList;
            this.tcInfoTabs.Location = new System.Drawing.Point(3, 21);
            this.tcInfoTabs.Name = "tcInfoTabs";
            this.tcInfoTabs.SelectedIndex = 0;
            this.tcInfoTabs.Size = new System.Drawing.Size(883, 339);
            this.tcInfoTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.olvConsoleLog);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console/Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // olvConsoleLog
            // 
            this.olvConsoleLog.AllColumns.Add(this.olvLogDate);
            this.olvConsoleLog.AllColumns.Add(this.olvLogType);
            this.olvConsoleLog.AllColumns.Add(this.olvLogMessage);
            this.olvConsoleLog.BackColor = System.Drawing.Color.White;
            this.olvConsoleLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvLogDate,
            this.olvLogType,
            this.olvLogMessage});
            this.olvConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvConsoleLog.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvConsoleLog.ForeColor = System.Drawing.Color.Black;
            this.olvConsoleLog.FullRowSelect = true;
            this.olvConsoleLog.Location = new System.Drawing.Point(3, 3);
            this.olvConsoleLog.MultiSelect = false;
            this.olvConsoleLog.Name = "olvConsoleLog";
            this.olvConsoleLog.SelectAllOnControlA = false;
            this.olvConsoleLog.SelectColumnsMenuStaysOpen = false;
            this.olvConsoleLog.SelectColumnsOnRightClick = false;
            this.olvConsoleLog.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvConsoleLog.ShowGroups = false;
            this.olvConsoleLog.ShowItemToolTips = true;
            this.olvConsoleLog.Size = new System.Drawing.Size(869, 303);
            this.olvConsoleLog.SmallImageList = this.imageListConsoleLog;
            this.olvConsoleLog.SortGroupItemsByPrimaryColumn = false;
            this.olvConsoleLog.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvConsoleLog.TabIndex = 0;
            this.olvConsoleLog.UseCompatibleStateImageBehavior = false;
            this.olvConsoleLog.View = System.Windows.Forms.View.Details;
            this.olvConsoleLog.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvConsoleLog_CellClick);
            // 
            // olvLogDate
            // 
            this.olvLogDate.AspectName = "Time";
            this.olvLogDate.AspectToStringFormat = " {0}";
            this.olvLogDate.Text = "Date";
            this.olvLogDate.Width = 200;
            // 
            // olvLogType
            // 
            this.olvLogType.AspectName = "Type";
            this.olvLogType.Text = "Type";
            this.olvLogType.Width = 100;
            // 
            // olvLogMessage
            // 
            this.olvLogMessage.AspectName = "Message";
            this.olvLogMessage.FillsFreeSpace = true;
            this.olvLogMessage.Text = "Message";
            // 
            // imageListConsoleLog
            // 
            this.imageListConsoleLog.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListConsoleLog.ImageStream")));
            this.imageListConsoleLog.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListConsoleLog.Images.SetKeyName(0, "StatusAnnotations_Information_16xLG.png");
            this.imageListConsoleLog.Images.SetKeyName(1, "StatusAnnotations_Warning_16xLG.png");
            this.imageListConsoleLog.Images.SetKeyName(2, "StatusAnnotations_Critical_16xLG.png");
            this.imageListConsoleLog.Images.SetKeyName(3, "StatusAnnotations_Critical_16xLG_color.png");
            this.imageListConsoleLog.Images.SetKeyName(4, "Security_Shields_Alert_16xLG.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.olvDeploymentsQuickStat);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deployments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // olvDeploymentsQuickStat
            // 
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentName);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentStatus);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentRuntime);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentSuccess);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentFail);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentTotal);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentPercentageComplete);
            this.olvDeploymentsQuickStat.AllColumns.Add(this.olvDeploymentMessage);
            this.olvDeploymentsQuickStat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvDeploymentName,
            this.olvDeploymentStatus,
            this.olvDeploymentRuntime,
            this.olvDeploymentSuccess,
            this.olvDeploymentFail,
            this.olvDeploymentTotal,
            this.olvDeploymentPercentageComplete,
            this.olvDeploymentMessage});
            this.olvDeploymentsQuickStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDeploymentsQuickStat.FullRowSelect = true;
            this.olvDeploymentsQuickStat.Location = new System.Drawing.Point(3, 3);
            this.olvDeploymentsQuickStat.Name = "olvDeploymentsQuickStat";
            this.olvDeploymentsQuickStat.ShowGroups = false;
            this.olvDeploymentsQuickStat.Size = new System.Drawing.Size(869, 299);
            this.olvDeploymentsQuickStat.TabIndex = 0;
            this.olvDeploymentsQuickStat.UseCompatibleStateImageBehavior = false;
            this.olvDeploymentsQuickStat.View = System.Windows.Forms.View.Details;
            // 
            // olvDeploymentName
            // 
            this.olvDeploymentName.AspectName = "Name";
            this.olvDeploymentName.Text = "Name";
            this.olvDeploymentName.Width = 175;
            // 
            // olvDeploymentStatus
            // 
            this.olvDeploymentStatus.AspectName = "State";
            this.olvDeploymentStatus.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentStatus.Text = "Status";
            this.olvDeploymentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentStatus.Width = 80;
            // 
            // olvDeploymentRuntime
            // 
            this.olvDeploymentRuntime.AspectName = "Runtime";
            this.olvDeploymentRuntime.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentRuntime.Text = "Runtime";
            this.olvDeploymentRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentRuntime.Width = 70;
            // 
            // olvDeploymentSuccess
            // 
            this.olvDeploymentSuccess.AspectName = "SuccessCount";
            this.olvDeploymentSuccess.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentSuccess.Text = "Sucess";
            this.olvDeploymentSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvDeploymentFail
            // 
            this.olvDeploymentFail.AspectName = "FailCount";
            this.olvDeploymentFail.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentFail.Text = "Failed";
            this.olvDeploymentFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvDeploymentTotal
            // 
            this.olvDeploymentTotal.AspectName = "TotalCount";
            this.olvDeploymentTotal.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentTotal.Text = "Total";
            this.olvDeploymentTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvDeploymentPercentageComplete
            // 
            this.olvDeploymentPercentageComplete.AspectName = "PercentComplete";
            this.olvDeploymentPercentageComplete.AspectToStringFormat = "{0}%";
            this.olvDeploymentPercentageComplete.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentPercentageComplete.Text = "Progress";
            this.olvDeploymentPercentageComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeploymentPercentageComplete.Width = 80;
            // 
            // olvDeploymentMessage
            // 
            this.olvDeploymentMessage.AspectName = "CurrentCommand";
            this.olvDeploymentMessage.FillsFreeSpace = true;
            this.olvDeploymentMessage.Text = "Message";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "application_16xLG.png");
            this.imageList.Images.SetKeyName(1, "active_x_16xLG.png");
            // 
            // fodExecutionFile
            // 
            this.fodExecutionFile.Filter = "All Files|*.*";
            this.fodExecutionFile.Title = "Easy Deploy+ File to Execute";
            this.fodExecutionFile.FileOk += new System.ComponentModel.CancelEventHandler(this.fodExecutionFile_FileOk);
            // 
            // btnStartDeployment
            // 
            this.btnStartDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDeployment.Image = global::Easy_Deploy.Properties.Resources.actionRun;
            this.btnStartDeployment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartDeployment.Location = new System.Drawing.Point(606, 227);
            this.btnStartDeployment.Name = "btnStartDeployment";
            this.btnStartDeployment.Size = new System.Drawing.Size(298, 39);
            this.btnStartDeployment.TabIndex = 3;
            this.btnStartDeployment.Text = "Start Deploy+";
            this.btnStartDeployment.UseVisualStyleBackColor = true;
            this.btnStartDeployment.Click += new System.EventHandler(this.btnStartDeployment_Click);
            // 
            // Classic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1151, 667);
            this.Controls.Add(this.grpLogInfo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpComputers);
            this.Controls.Add(this.btnStartDeployment);
            this.Controls.Add(this.grpCredentials);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpDeployment);
            this.Controls.Add(this.mainMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1167, 706);
            this.Name = "Classic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Classic_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.grpDeployment.ResumeLayout(false);
            this.grpDeployment.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSessionNum)).EndInit();
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.grpComputers.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpLogInfo.ResumeLayout(false);
            this.tcInfoTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvConsoleLog)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvDeploymentsQuickStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem installRDPWrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRDPWrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem failureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCurrentProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killPsExecexeToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDeployment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArgsOrCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExecutingFile;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSessionNum;
        private System.Windows.Forms.CheckBox chkInteractive;
        private System.Windows.Forms.NumericUpDown numConnectionTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDontWait;
        private System.Windows.Forms.CheckBox chkWorkingDir;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.Button btnSelectComputers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCredentials;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkUseCredentials;
        private System.Windows.Forms.CheckBox chkSystem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnStartDeployment;
        private System.Windows.Forms.GroupBox grpComputers;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox grpLogInfo;
        private System.Windows.Forms.TabControl tcInfoTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnClearAllComputers;
        private System.Windows.Forms.Button btnCheckAllComputers;
        private System.Windows.Forms.CheckedListBox chklstSelectedComputers;
        private BrightIdeasSoftware.ObjectListView olvConsoleLog;
        private BrightIdeasSoftware.OLVColumn olvLogDate;
        private BrightIdeasSoftware.OLVColumn olvLogType;
        private BrightIdeasSoftware.OLVColumn olvLogMessage;
        private System.Windows.Forms.ImageList imageListConsoleLog;
        private BrightIdeasSoftware.ObjectListView olvDeploymentsQuickStat;
        private BrightIdeasSoftware.OLVColumn olvDeploymentName;
        private BrightIdeasSoftware.OLVColumn olvDeploymentStatus;
        private BrightIdeasSoftware.OLVColumn olvDeploymentRuntime;
        private BrightIdeasSoftware.OLVColumn olvDeploymentSuccess;
        private BrightIdeasSoftware.OLVColumn olvDeploymentFail;
        private BrightIdeasSoftware.OLVColumn olvDeploymentTotal;
        private BrightIdeasSoftware.OLVColumn olvDeploymentPercentageComplete;
        private BrightIdeasSoftware.OLVColumn olvDeploymentMessage;
        private System.Windows.Forms.OpenFileDialog fodExecutionFile;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStoredCollectionDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusActiveDirSync;
    }
}

