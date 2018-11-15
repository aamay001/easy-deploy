namespace PsTools_Easy_Deploy_Tool
{
    partial class MSIOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSIOps));
            this.label1 = new System.Windows.Forms.Label();
            this.installer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uninstall = new System.Windows.Forms.CheckBox();
            this.reInstall = new System.Windows.Forms.CheckBox();
            this.forceRestart = new System.Windows.Forms.CheckBox();
            this.noRestart = new System.Windows.Forms.CheckBox();
            this.allUsers = new System.Windows.Forms.CheckBox();
            this.silentInstall = new System.Windows.Forms.CheckBox();
            this.statusLogging = new System.Windows.Forms.CheckBox();
            this.logDirectory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logDirLabel = new System.Windows.Forms.Label();
            this.logName = new System.Windows.Forms.TextBox();
            this.logNameLable = new System.Windows.Forms.Label();
            this.useComputerName = new System.Windows.Forms.CheckBox();
            this.done = new System.Windows.Forms.Button();
            this.MSIProductName = new System.Windows.Forms.TextBox();
            this.MSIPVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSI Package:";
            // 
            // installer
            // 
            this.installer.Location = new System.Drawing.Point(12, 77);
            this.installer.Name = "installer";
            this.installer.ReadOnly = true;
            this.installer.Size = new System.Drawing.Size(384, 20);
            this.installer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uninstall);
            this.groupBox1.Controls.Add(this.reInstall);
            this.groupBox1.Controls.Add(this.forceRestart);
            this.groupBox1.Controls.Add(this.noRestart);
            this.groupBox1.Controls.Add(this.allUsers);
            this.groupBox1.Controls.Add(this.silentInstall);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Execution Options";
            // 
            // uninstall
            // 
            this.uninstall.AutoSize = true;
            this.uninstall.Location = new System.Drawing.Point(258, 31);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(66, 17);
            this.uninstall.TabIndex = 5;
            this.uninstall.Text = "Uninstall";
            this.uninstall.UseVisualStyleBackColor = true;
            this.uninstall.CheckedChanged += new System.EventHandler(this.uninstall_CheckedChanged);
            // 
            // reInstall
            // 
            this.reInstall.AutoSize = true;
            this.reInstall.Location = new System.Drawing.Point(258, 66);
            this.reInstall.Name = "reInstall";
            this.reInstall.Size = new System.Drawing.Size(108, 17);
            this.reInstall.TabIndex = 4;
            this.reInstall.Text = "Reinstall / Repair";
            this.reInstall.UseVisualStyleBackColor = true;
            this.reInstall.CheckedChanged += new System.EventHandler(this.reInstall_CheckedChanged);
            // 
            // forceRestart
            // 
            this.forceRestart.AutoSize = true;
            this.forceRestart.Location = new System.Drawing.Point(137, 66);
            this.forceRestart.Name = "forceRestart";
            this.forceRestart.Size = new System.Drawing.Size(90, 17);
            this.forceRestart.TabIndex = 3;
            this.forceRestart.Text = "Force Restart";
            this.forceRestart.UseVisualStyleBackColor = true;
            this.forceRestart.CheckedChanged += new System.EventHandler(this.forceRestart_CheckedChanged);
            // 
            // noRestart
            // 
            this.noRestart.AutoSize = true;
            this.noRestart.Location = new System.Drawing.Point(19, 66);
            this.noRestart.Name = "noRestart";
            this.noRestart.Size = new System.Drawing.Size(100, 17);
            this.noRestart.TabIndex = 2;
            this.noRestart.Text = "Prevent Restart";
            this.noRestart.UseVisualStyleBackColor = true;
            this.noRestart.CheckedChanged += new System.EventHandler(this.noRestart_CheckedChanged);
            // 
            // allUsers
            // 
            this.allUsers.AutoSize = true;
            this.allUsers.Location = new System.Drawing.Point(137, 31);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(67, 17);
            this.allUsers.TabIndex = 1;
            this.allUsers.Text = "All Users";
            this.allUsers.UseVisualStyleBackColor = true;
            // 
            // silentInstall
            // 
            this.silentInstall.AutoSize = true;
            this.silentInstall.Location = new System.Drawing.Point(19, 31);
            this.silentInstall.Name = "silentInstall";
            this.silentInstall.Size = new System.Drawing.Size(88, 17);
            this.silentInstall.TabIndex = 0;
            this.silentInstall.Text = "Quiet - No UI";
            this.silentInstall.UseVisualStyleBackColor = true;
            // 
            // statusLogging
            // 
            this.statusLogging.AutoSize = true;
            this.statusLogging.Checked = true;
            this.statusLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusLogging.Enabled = false;
            this.statusLogging.Location = new System.Drawing.Point(19, 29);
            this.statusLogging.Name = "statusLogging";
            this.statusLogging.Size = new System.Drawing.Size(174, 17);
            this.statusLogging.TabIndex = 6;
            this.statusLogging.Text = "Log Package Status Messages";
            this.statusLogging.UseVisualStyleBackColor = true;
            this.statusLogging.CheckedChanged += new System.EventHandler(this.statusLogging_CheckedChanged);
            // 
            // logDirectory
            // 
            this.logDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.logDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.logDirectory.Enabled = false;
            this.logDirectory.Location = new System.Drawing.Point(19, 80);
            this.logDirectory.Name = "logDirectory";
            this.logDirectory.Size = new System.Drawing.Size(347, 20);
            this.logDirectory.TabIndex = 7;
            this.logDirectory.TextChanged += new System.EventHandler(this.logDirectory_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logDirLabel);
            this.groupBox2.Controls.Add(this.logName);
            this.groupBox2.Controls.Add(this.logNameLable);
            this.groupBox2.Controls.Add(this.useComputerName);
            this.groupBox2.Controls.Add(this.statusLogging);
            this.groupBox2.Controls.Add(this.logDirectory);
            this.groupBox2.Location = new System.Drawing.Point(407, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 209);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            this.groupBox2.Visible = false;
            // 
            // logDirLabel
            // 
            this.logDirLabel.AutoSize = true;
            this.logDirLabel.Enabled = false;
            this.logDirLabel.Location = new System.Drawing.Point(16, 61);
            this.logDirLabel.Name = "logDirLabel";
            this.logDirLabel.Size = new System.Drawing.Size(73, 13);
            this.logDirLabel.TabIndex = 12;
            this.logDirLabel.Text = "Log Directory:";
            // 
            // logName
            // 
            this.logName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.logName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.logName.Enabled = false;
            this.logName.Location = new System.Drawing.Point(81, 161);
            this.logName.Name = "logName";
            this.logName.Size = new System.Drawing.Size(285, 20);
            this.logName.TabIndex = 10;
            this.logName.Text = "%computername%.txt";
            // 
            // logNameLable
            // 
            this.logNameLable.AutoSize = true;
            this.logNameLable.Enabled = false;
            this.logNameLable.Location = new System.Drawing.Point(16, 164);
            this.logNameLable.Name = "logNameLable";
            this.logNameLable.Size = new System.Drawing.Size(59, 13);
            this.logNameLable.TabIndex = 9;
            this.logNameLable.Text = "Log Name:";
            // 
            // useComputerName
            // 
            this.useComputerName.AutoSize = true;
            this.useComputerName.Checked = true;
            this.useComputerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useComputerName.Enabled = false;
            this.useComputerName.Location = new System.Drawing.Point(19, 129);
            this.useComputerName.Name = "useComputerName";
            this.useComputerName.Size = new System.Drawing.Size(190, 17);
            this.useComputerName.TabIndex = 8;
            this.useComputerName.Text = "Use Computer Name as Log Name";
            this.useComputerName.UseVisualStyleBackColor = true;
            this.useComputerName.CheckedChanged += new System.EventHandler(this.useComputerName_CheckedChanged);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(12, 237);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(384, 29);
            this.done.TabIndex = 9;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // MSIProductName
            // 
            this.MSIProductName.Location = new System.Drawing.Point(12, 29);
            this.MSIProductName.Name = "MSIProductName";
            this.MSIProductName.ReadOnly = true;
            this.MSIProductName.Size = new System.Drawing.Size(276, 20);
            this.MSIProductName.TabIndex = 10;
            // 
            // MSIPVersion
            // 
            this.MSIPVersion.Location = new System.Drawing.Point(294, 29);
            this.MSIPVersion.Name = "MSIPVersion";
            this.MSIPVersion.ReadOnly = true;
            this.MSIPVersion.Size = new System.Drawing.Size(102, 20);
            this.MSIPVersion.TabIndex = 11;
            this.MSIPVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Version:";
            // 
            // MSIOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 278);
            this.ControlBox = false;
            this.Controls.Add(this.done);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSIPVersion);
            this.Controls.Add(this.MSIProductName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.installer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSIOps";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Deploy - Windows Installer Options";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox installer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox uninstall;
        private System.Windows.Forms.CheckBox reInstall;
        private System.Windows.Forms.CheckBox forceRestart;
        private System.Windows.Forms.CheckBox noRestart;
        private System.Windows.Forms.CheckBox allUsers;
        private System.Windows.Forms.CheckBox silentInstall;
        private System.Windows.Forms.TextBox logDirectory;
        private System.Windows.Forms.CheckBox statusLogging;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox useComputerName;
        private System.Windows.Forms.TextBox logName;
        private System.Windows.Forms.Label logNameLable;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label logDirLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox MSIProductName;
        public System.Windows.Forms.TextBox MSIPVersion;
    }
}