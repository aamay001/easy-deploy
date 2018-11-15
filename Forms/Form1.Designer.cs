namespace PsTools_Easy_Deploy_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.systemAccount = new System.Windows.Forms.CheckBox();
            this.credentials = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListEditButton = new System.Windows.Forms.Button();
            this.clearExec = new System.Windows.Forms.Button();
            this.arguments = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectFileToExecute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.executable = new System.Windows.Forms.TextBox();
            this.deployTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startDeploy = new System.Windows.Forms.Button();
            this.openExecutable = new System.Windows.Forms.OpenFileDialog();
            this.lookUpGroup = new System.Windows.Forms.GroupBox();
            this.selectedComputers = new System.Windows.Forms.CheckedListBox();
            this.checkAll = new System.Windows.Forms.Button();
            this.clearAllChecked = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.consoleDisplay = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalComps = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.selComps = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.installRDPWrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pingAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingAllCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProcessConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killAllProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killCurrentProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopPsExecexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compCountTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hostName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pingHost = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteToHost = new System.Windows.Forms.ToolStripMenuItem();
            this.mangementConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAdminShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicDesktopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.publicStartMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsXpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicDesktopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.publicStartMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEasyFile = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.timeOut = new System.Windows.Forms.NumericUpDown();
            this.copy = new System.Windows.Forms.CheckBox();
            this.wait = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.forceCopy = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.relWorkingPath = new System.Windows.Forms.CheckBox();
            this.isessionNum = new System.Windows.Forms.NumericUpDown();
            this.interactive = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.removeRDPWrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lookUpGroup.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOut)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isessionNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.systemAccount);
            this.groupBox1.Controls.Add(this.credentials);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // systemAccount
            // 
            this.systemAccount.AutoSize = true;
            this.systemAccount.Location = new System.Drawing.Point(15, 128);
            this.systemAccount.Name = "systemAccount";
            this.systemAccount.Size = new System.Drawing.Size(82, 17);
            this.systemAccount.TabIndex = 5;
            this.systemAccount.Text = "Use System";
            this.systemAccount.UseVisualStyleBackColor = true;
            this.systemAccount.CheckedChanged += new System.EventHandler(this.systemAccount_CheckedChanged);
            // 
            // credentials
            // 
            this.credentials.AutoSize = true;
            this.credentials.Location = new System.Drawing.Point(144, 128);
            this.credentials.Name = "credentials";
            this.credentials.Size = new System.Drawing.Size(100, 17);
            this.credentials.TabIndex = 4;
            this.credentials.Text = "Use Credentials";
            this.credentials.UseVisualStyleBackColor = true;
            this.credentials.CheckedChanged += new System.EventHandler(this.credentials_CheckedChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(15, 95);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(229, 20);
            this.password.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(15, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(229, 20);
            this.username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Console:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ListEditButton);
            this.groupBox2.Controls.Add(this.clearExec);
            this.groupBox2.Controls.Add(this.arguments);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.selectFileToExecute);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.executable);
            this.groupBox2.Location = new System.Drawing.Point(271, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deployment";
            // 
            // ListEditButton
            // 
            this.ListEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEditButton.Image = global::PsTools_Easy_Deploy_Tool.Properties.Resources.computer;
            this.ListEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListEditButton.Location = new System.Drawing.Point(13, 155);
            this.ListEditButton.Name = "ListEditButton";
            this.ListEditButton.Size = new System.Drawing.Size(221, 31);
            this.ListEditButton.TabIndex = 12;
            this.ListEditButton.Text = "Computers";
            this.ListEditButton.UseVisualStyleBackColor = true;
            this.ListEditButton.Click += new System.EventHandler(this.ListEditButton_Click);
            // 
            // clearExec
            // 
            this.clearExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearExec.ForeColor = System.Drawing.Color.Red;
            this.clearExec.Location = new System.Drawing.Point(208, 13);
            this.clearExec.Name = "clearExec";
            this.clearExec.Size = new System.Drawing.Size(26, 23);
            this.clearExec.TabIndex = 0;
            this.clearExec.Text = "X";
            this.clearExec.UseVisualStyleBackColor = true;
            this.clearExec.Click += new System.EventHandler(this.clearExec_Click);
            // 
            // arguments
            // 
            this.arguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arguments.Location = new System.Drawing.Point(13, 120);
            this.arguments.Name = "arguments";
            this.arguments.Size = new System.Drawing.Size(221, 20);
            this.arguments.TabIndex = 2;
            this.arguments.TextChanged += new System.EventHandler(this.arguments_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Arguments or Command:";
            // 
            // selectFileToExecute
            // 
            this.selectFileToExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileToExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileToExecute.Location = new System.Drawing.Point(208, 76);
            this.selectFileToExecute.Name = "selectFileToExecute";
            this.selectFileToExecute.Size = new System.Drawing.Size(26, 23);
            this.selectFileToExecute.TabIndex = 1;
            this.selectFileToExecute.Text = ">";
            this.selectFileToExecute.UseVisualStyleBackColor = true;
            this.selectFileToExecute.Click += new System.EventHandler(this.selectFileToExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File to Execute:";
            // 
            // executable
            // 
            this.executable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executable.Location = new System.Drawing.Point(13, 53);
            this.executable.Name = "executable";
            this.executable.ReadOnly = true;
            this.executable.Size = new System.Drawing.Size(221, 20);
            this.executable.TabIndex = 0;
            this.executable.TextChanged += new System.EventHandler(this.executable_TextChanged);
            // 
            // deployTo
            // 
            this.deployTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deployTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deployTo.Enabled = false;
            this.deployTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deployTo.FormattingEnabled = true;
            this.deployTo.Items.AddRange(new object[] {
            "Host Name or IP Address",
            "Computer List",
            "Selected Computers",
            "Current Domain"});
            this.deployTo.Location = new System.Drawing.Point(29, 192);
            this.deployTo.Name = "deployTo";
            this.deployTo.Size = new System.Drawing.Size(221, 21);
            this.deployTo.TabIndex = 3;
            this.deployTo.Visible = false;
            this.deployTo.SelectedIndexChanged += new System.EventHandler(this.deployTo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deploy To:";
            this.label5.Visible = false;
            // 
            // startDeploy
            // 
            this.startDeploy.Location = new System.Drawing.Point(10, 178);
            this.startDeploy.Name = "startDeploy";
            this.startDeploy.Size = new System.Drawing.Size(255, 36);
            this.startDeploy.TabIndex = 5;
            this.startDeploy.Text = "Start Deploy";
            this.startDeploy.UseVisualStyleBackColor = true;
            this.startDeploy.Click += new System.EventHandler(this.startDeploy_Click);
            // 
            // openExecutable
            // 
            this.openExecutable.Filter = "All Files|*.*";
            this.openExecutable.Title = "Select File to Execute";
            this.openExecutable.FileOk += new System.ComponentModel.CancelEventHandler(this.openExecutable_FileOk);
            // 
            // lookUpGroup
            // 
            this.lookUpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpGroup.Controls.Add(this.selectedComputers);
            this.lookUpGroup.Controls.Add(this.checkAll);
            this.lookUpGroup.Controls.Add(this.clearAllChecked);
            this.lookUpGroup.Location = new System.Drawing.Point(790, 27);
            this.lookUpGroup.Name = "lookUpGroup";
            this.lookUpGroup.Size = new System.Drawing.Size(247, 600);
            this.lookUpGroup.TabIndex = 4;
            this.lookUpGroup.TabStop = false;
            this.lookUpGroup.Text = "Computers";
            // 
            // selectedComputers
            // 
            this.selectedComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedComputers.FormattingEnabled = true;
            this.selectedComputers.Location = new System.Drawing.Point(6, 22);
            this.selectedComputers.Name = "selectedComputers";
            this.selectedComputers.Size = new System.Drawing.Size(235, 544);
            this.selectedComputers.Sorted = true;
            this.selectedComputers.TabIndex = 0;
            this.selectedComputers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectedComputers_MouseDown);
            // 
            // checkAll
            // 
            this.checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAll.Location = new System.Drawing.Point(12, 571);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(110, 23);
            this.checkAll.TabIndex = 10;
            this.checkAll.Text = "Check All";
            this.checkAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // clearAllChecked
            // 
            this.clearAllChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearAllChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllChecked.Location = new System.Drawing.Point(126, 571);
            this.clearAllChecked.Name = "clearAllChecked";
            this.clearAllChecked.Size = new System.Drawing.Size(110, 23);
            this.clearAllChecked.TabIndex = 11;
            this.clearAllChecked.Text = "Clear All";
            this.clearAllChecked.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearAllChecked.UseVisualStyleBackColor = true;
            this.clearAllChecked.Click += new System.EventHandler(this.clearAllChecked_Click);
            // 
            // consoleDisplay
            // 
            this.consoleDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleDisplay.BackColor = System.Drawing.Color.Black;
            this.consoleDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.consoleDisplay.DetectUrls = false;
            this.consoleDisplay.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDisplay.ForeColor = System.Drawing.Color.White;
            this.consoleDisplay.Location = new System.Drawing.Point(9, 274);
            this.consoleDisplay.Name = "consoleDisplay";
            this.consoleDisplay.ReadOnly = true;
            this.consoleDisplay.Size = new System.Drawing.Size(772, 353);
            this.consoleDisplay.TabIndex = 7;
            this.consoleDisplay.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalComps,
            this.toolStripStatusLabel2,
            this.selComps});
            this.statusStrip.Location = new System.Drawing.Point(0, 632);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel1.Text = "Total Computers:";
            // 
            // totalComps
            // 
            this.totalComps.Name = "totalComps";
            this.totalComps.Size = new System.Drawing.Size(13, 17);
            this.totalComps.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel2.Text = "Selected Computers:";
            // 
            // selComps
            // 
            this.selComps.Name = "selComps";
            this.selComps.Size = new System.Drawing.Size(13, 17);
            this.selComps.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.computersToolStripMenuItem,
            this.processingToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "App";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customListToolStripMenuItem,
            this.toolStripSeparator2,
            this.installRDPWrapperToolStripMenuItem,
            this.removeRDPWrapperToolStripMenuItem,
            this.toolStripSeparator4,
            this.pingAllToolStripMenuItem,
            this.pingAllCheckedToolStripMenuItem,
            this.toolStripSeparator3,
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem});
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.computersToolStripMenuItem.Text = "Computers";
            // 
            // customListToolStripMenuItem
            // 
            this.customListToolStripMenuItem.Name = "customListToolStripMenuItem";
            this.customListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.customListToolStripMenuItem.Text = "Edit List";
            this.customListToolStripMenuItem.Click += new System.EventHandler(this.customListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // installRDPWrapperToolStripMenuItem
            // 
            this.installRDPWrapperToolStripMenuItem.Name = "installRDPWrapperToolStripMenuItem";
            this.installRDPWrapperToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.installRDPWrapperToolStripMenuItem.Text = "Install RDP Wrapper";
            this.installRDPWrapperToolStripMenuItem.Click += new System.EventHandler(this.installRDPWrapperToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // pingAllToolStripMenuItem
            // 
            this.pingAllToolStripMenuItem.Name = "pingAllToolStripMenuItem";
            this.pingAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pingAllToolStripMenuItem.Text = "Ping";
            this.pingAllToolStripMenuItem.Click += new System.EventHandler(this.pingAllToolStripMenuItem_Click);
            // 
            // pingAllCheckedToolStripMenuItem
            // 
            this.pingAllCheckedToolStripMenuItem.Name = "pingAllCheckedToolStripMenuItem";
            this.pingAllCheckedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pingAllCheckedToolStripMenuItem.Text = "Ping Checked";
            this.pingAllCheckedToolStripMenuItem.Click += new System.EventHandler(this.pingAllCheckedToolStripMenuItem_Click);
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
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProcessConsoleToolStripMenuItem,
            this.clearConsoleToolStripMenuItem});
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processingToolStripMenuItem.Text = "Processing";
            // 
            // openProcessConsoleToolStripMenuItem
            // 
            this.openProcessConsoleToolStripMenuItem.Name = "openProcessConsoleToolStripMenuItem";
            this.openProcessConsoleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openProcessConsoleToolStripMenuItem.Text = "Process Reports";
            this.openProcessConsoleToolStripMenuItem.Click += new System.EventHandler(this.openProcessConsoleToolStripMenuItem_Click);
            // 
            // clearConsoleToolStripMenuItem
            // 
            this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearConsoleToolStripMenuItem.Text = "Clear Console";
            this.clearConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearConsoleToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killAllProcessesToolStripMenuItem,
            this.killCurrentProcessToolStripMenuItem,
            this.stopPsExecexeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.optionsToolStripMenuItem.Text = "Debug";
            // 
            // killAllProcessesToolStripMenuItem
            // 
            this.killAllProcessesToolStripMenuItem.Name = "killAllProcessesToolStripMenuItem";
            this.killAllProcessesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.killAllProcessesToolStripMenuItem.Text = "Stop All Processing";
            this.killAllProcessesToolStripMenuItem.Click += new System.EventHandler(this.killAllProcessesToolStripMenuItem_Click);
            // 
            // killCurrentProcessToolStripMenuItem
            // 
            this.killCurrentProcessToolStripMenuItem.Name = "killCurrentProcessToolStripMenuItem";
            this.killCurrentProcessToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.killCurrentProcessToolStripMenuItem.Text = "Stop Current Process";
            this.killCurrentProcessToolStripMenuItem.Click += new System.EventHandler(this.killCurrentProcessToolStripMenuItem_Click);
            // 
            // stopPsExecexeToolStripMenuItem
            // 
            this.stopPsExecexeToolStripMenuItem.Name = "stopPsExecexeToolStripMenuItem";
            this.stopPsExecexeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.stopPsExecexeToolStripMenuItem.Text = "Stop PsExec.exe";
            this.stopPsExecexeToolStripMenuItem.Click += new System.EventHandler(this.stopPsExecexeToolStripMenuItem_Click);
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
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // compCountTimer
            // 
            this.compCountTimer.Enabled = true;
            this.compCountTimer.Tick += new System.EventHandler(this.compCountTimer_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostName,
            this.toolStripSeparator1,
            this.pingHost,
            this.remoteToHost,
            this.mangementConsoleToolStripMenuItem,
            this.openAdminShareToolStripMenuItem,
            this.toolStripSeparator5,
            this.copyToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(186, 170);
            // 
            // hostName
            // 
            this.hostName.Enabled = false;
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(185, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // pingHost
            // 
            this.pingHost.Name = "pingHost";
            this.pingHost.Size = new System.Drawing.Size(185, 22);
            this.pingHost.Text = "Ping";
            this.pingHost.Click += new System.EventHandler(this.pingHost_Click);
            // 
            // remoteToHost
            // 
            this.remoteToHost.Name = "remoteToHost";
            this.remoteToHost.Size = new System.Drawing.Size(185, 22);
            this.remoteToHost.Text = "Start Remote Session";
            this.remoteToHost.Click += new System.EventHandler(this.remoteToHost_Click);
            // 
            // mangementConsoleToolStripMenuItem
            // 
            this.mangementConsoleToolStripMenuItem.Name = "mangementConsoleToolStripMenuItem";
            this.mangementConsoleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mangementConsoleToolStripMenuItem.Text = "Mangement Console";
            this.mangementConsoleToolStripMenuItem.Click += new System.EventHandler(this.mangementConsoleToolStripMenuItem_Click);
            // 
            // openAdminShareToolStripMenuItem
            // 
            this.openAdminShareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicDesktopToolStripMenuItem,
            this.windowsXpToolStripMenuItem});
            this.openAdminShareToolStripMenuItem.Name = "openAdminShareToolStripMenuItem";
            this.openAdminShareToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openAdminShareToolStripMenuItem.Text = "Open Admin Share";
            this.openAdminShareToolStripMenuItem.Click += new System.EventHandler(this.openAdminShareToolStripMenuItem_Click);
            // 
            // publicDesktopToolStripMenuItem
            // 
            this.publicDesktopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicDesktopToolStripMenuItem1,
            this.publicStartMenuToolStripMenuItem});
            this.publicDesktopToolStripMenuItem.Name = "publicDesktopToolStripMenuItem";
            this.publicDesktopToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.publicDesktopToolStripMenuItem.Text = "Windows 7";
            // 
            // publicDesktopToolStripMenuItem1
            // 
            this.publicDesktopToolStripMenuItem1.Name = "publicDesktopToolStripMenuItem1";
            this.publicDesktopToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.publicDesktopToolStripMenuItem1.Text = "Public Desktop";
            this.publicDesktopToolStripMenuItem1.Click += new System.EventHandler(this.publicDesktopToolStripMenuItem1_Click);
            // 
            // publicStartMenuToolStripMenuItem
            // 
            this.publicStartMenuToolStripMenuItem.Name = "publicStartMenuToolStripMenuItem";
            this.publicStartMenuToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.publicStartMenuToolStripMenuItem.Text = "Public Start Menu";
            this.publicStartMenuToolStripMenuItem.Click += new System.EventHandler(this.publicStartMenuToolStripMenuItem_Click);
            // 
            // windowsXpToolStripMenuItem
            // 
            this.windowsXpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicDesktopToolStripMenuItem2,
            this.publicStartMenuToolStripMenuItem1});
            this.windowsXpToolStripMenuItem.Name = "windowsXpToolStripMenuItem";
            this.windowsXpToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.windowsXpToolStripMenuItem.Text = "Windows Xp";
            // 
            // publicDesktopToolStripMenuItem2
            // 
            this.publicDesktopToolStripMenuItem2.Name = "publicDesktopToolStripMenuItem2";
            this.publicDesktopToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.publicDesktopToolStripMenuItem2.Text = "Public Desktop";
            this.publicDesktopToolStripMenuItem2.Click += new System.EventHandler(this.publicDesktopToolStripMenuItem2_Click);
            // 
            // publicStartMenuToolStripMenuItem1
            // 
            this.publicStartMenuToolStripMenuItem1.Name = "publicStartMenuToolStripMenuItem1";
            this.publicStartMenuToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.publicStartMenuToolStripMenuItem1.Text = "Public Start Menu";
            this.publicStartMenuToolStripMenuItem1.Click += new System.EventHandler(this.publicStartMenuToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openEasyFile
            // 
            this.openEasyFile.Filter = "XML|*.xml";
            this.openEasyFile.Title = "Open Application Deploy Settings List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Connection Time Out:";
            // 
            // timeOut
            // 
            this.timeOut.Location = new System.Drawing.Point(135, 20);
            this.timeOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(79, 20);
            this.timeOut.TabIndex = 1;
            this.timeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Location = new System.Drawing.Point(21, 47);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(105, 17);
            this.copy.TabIndex = 2;
            this.copy.Text = "Copy executable";
            this.copy.UseVisualStyleBackColor = true;
            // 
            // wait
            // 
            this.wait.AutoSize = true;
            this.wait.Location = new System.Drawing.Point(21, 93);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(155, 17);
            this.wait.TabIndex = 4;
            this.wait.Text = "Don\'t wait for each process";
            this.wait.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Run Priority:";
            // 
            // priority
            // 
            this.priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.priority.FormattingEnabled = true;
            this.priority.Items.AddRange(new object[] {
            "Low",
            "Below Normal",
            "Normal",
            "Above Normal",
            "High",
            "Realtime"});
            this.priority.Location = new System.Drawing.Point(88, 165);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(127, 21);
            this.priority.TabIndex = 8;
            // 
            // forceCopy
            // 
            this.forceCopy.AutoSize = true;
            this.forceCopy.Location = new System.Drawing.Point(21, 70);
            this.forceCopy.Name = "forceCopy";
            this.forceCopy.Size = new System.Drawing.Size(109, 17);
            this.forceCopy.TabIndex = 3;
            this.forceCopy.Text = "Overwrite existing";
            this.forceCopy.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Instances:";
            this.label8.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.relWorkingPath);
            this.groupBox3.Controls.Add(this.isessionNum);
            this.groupBox3.Controls.Add(this.interactive);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.forceCopy);
            this.groupBox3.Controls.Add(this.priority);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.wait);
            this.groupBox3.Controls.Add(this.copy);
            this.groupBox3.Controls.Add(this.timeOut);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(519, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 199);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // relWorkingPath
            // 
            this.relWorkingPath.AutoSize = true;
            this.relWorkingPath.Location = new System.Drawing.Point(21, 140);
            this.relWorkingPath.Name = "relWorkingPath";
            this.relWorkingPath.Size = new System.Drawing.Size(111, 17);
            this.relWorkingPath.TabIndex = 7;
            this.relWorkingPath.Text = "Working Directory";
            this.relWorkingPath.UseVisualStyleBackColor = true;
            this.relWorkingPath.CheckedChanged += new System.EventHandler(this.relWorkingPath_CheckedChanged);
            // 
            // isessionNum
            // 
            this.isessionNum.Location = new System.Drawing.Point(148, 115);
            this.isessionNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.isessionNum.Name = "isessionNum";
            this.isessionNum.Size = new System.Drawing.Size(79, 20);
            this.isessionNum.TabIndex = 6;
            this.isessionNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // interactive
            // 
            this.interactive.AutoSize = true;
            this.interactive.Location = new System.Drawing.Point(21, 116);
            this.interactive.Name = "interactive";
            this.interactive.Size = new System.Drawing.Size(125, 17);
            this.interactive.TabIndex = 5;
            this.interactive.Text = "Interactive - Session:";
            this.interactive.UseVisualStyleBackColor = true;
            this.interactive.CheckedChanged += new System.EventHandler(this.interactive_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.startDeploy);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.deployTo);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(772, 228);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // removeRDPWrapperToolStripMenuItem
            // 
            this.removeRDPWrapperToolStripMenuItem.Name = "removeRDPWrapperToolStripMenuItem";
            this.removeRDPWrapperToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removeRDPWrapperToolStripMenuItem.Text = "Remove RDP Wrapper";
            this.removeRDPWrapperToolStripMenuItem.Click += new System.EventHandler(this.removeRDPWrapperToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 654);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lookUpGroup);
            this.Controls.Add(this.consoleDisplay);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1022, 692);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lookUpGroup.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeOut)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isessionNum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectFileToExecute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox executable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox deployTo;
        private System.Windows.Forms.TextBox arguments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openExecutable;
        private System.Windows.Forms.GroupBox lookUpGroup;
        public System.Windows.Forms.CheckedListBox selectedComputers;
        private System.Windows.Forms.Button clearAllChecked;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button clearExec;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.RichTextBox consoleDisplay;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.CheckBox credentials;
        public System.Windows.Forms.CheckBox systemAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProcessConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killAllProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killCurrentProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalComps;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel selComps;
        private System.Windows.Forms.Timer compCountTimer;
        private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopPsExecexeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem pingHost;
        private System.Windows.Forms.ToolStripMenuItem remoteToHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hostName;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pingAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingAllCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangementConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openEasyFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown timeOut;
        private System.Windows.Forms.CheckBox copy;
        private System.Windows.Forms.CheckBox wait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.CheckBox forceCopy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown isessionNum;
        private System.Windows.Forms.CheckBox interactive;
        public System.Windows.Forms.CheckBox relWorkingPath;
        private System.Windows.Forms.ToolStripMenuItem openAdminShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Button startDeploy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ListEditButton;
        private System.Windows.Forms.ToolStripMenuItem publicDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicDesktopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem publicStartMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsXpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicDesktopToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem publicStartMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem installRDPWrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem removeRDPWrapperToolStripMenuItem;
    }
}

