namespace PsTools_Easy_Deploy_Tool
{
    partial class SettingsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsManager));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LogDirDisplay = new System.Windows.Forms.TextBox();
            this.AutoUpADOnStartCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LocalUpdateDirDisplay = new System.Windows.Forms.TextBox();
            this.DirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LogDirDisplay);
            this.groupBox2.Controls.Add(this.AutoUpADOnStartCheckBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LocalUpdateDirDisplay);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(324, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logging Directory:";
            // 
            // LogDirDisplay
            // 
            this.LogDirDisplay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LogDirDisplay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.LogDirDisplay.Enabled = false;
            this.LogDirDisplay.Location = new System.Drawing.Point(20, 114);
            this.LogDirDisplay.Name = "LogDirDisplay";
            this.LogDirDisplay.Size = new System.Drawing.Size(379, 20);
            this.LogDirDisplay.TabIndex = 10;
            // 
            // AutoUpADOnStartCheckBox
            // 
            this.AutoUpADOnStartCheckBox.Enabled = false;
            this.AutoUpADOnStartCheckBox.Location = new System.Drawing.Point(20, 185);
            this.AutoUpADOnStartCheckBox.Name = "AutoUpADOnStartCheckBox";
            this.AutoUpADOnStartCheckBox.Size = new System.Drawing.Size(254, 17);
            this.AutoUpADOnStartCheckBox.TabIndex = 9;
            this.AutoUpADOnStartCheckBox.Text = "Auto update active directory on application start.\r\n";
            this.AutoUpADOnStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(324, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Local Update Directory:";
            // 
            // LocalUpdateDirDisplay
            // 
            this.LocalUpdateDirDisplay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LocalUpdateDirDisplay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.LocalUpdateDirDisplay.Enabled = false;
            this.LocalUpdateDirDisplay.Location = new System.Drawing.Point(20, 44);
            this.LocalUpdateDirDisplay.Name = "LocalUpdateDirDisplay";
            this.LocalUpdateDirDisplay.Size = new System.Drawing.Size(379, 20);
            this.LocalUpdateDirDisplay.TabIndex = 5;
            // 
            // DirectoryBrowser
            // 
            this.DirectoryBrowser.Description = "Select Directory";
            this.DirectoryBrowser.ShowNewFolderButton = false;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(336, 252);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(93, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Close";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SettingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 287);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Deploy - Options";
            this.Load += new System.EventHandler(this.SettingsManager_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LocalUpdateDirDisplay;
        private System.Windows.Forms.CheckBox AutoUpADOnStartCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogDirDisplay;
        private System.Windows.Forms.FolderBrowserDialog DirectoryBrowser;
        private System.Windows.Forms.Button ApplyButton;
    }
}