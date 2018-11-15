namespace Easy_Deploy.Forms
{
    partial class WorkingDirectorySelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingDirectorySelection));
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInvalidChars = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the working directory the executable will use on the remote \r\nmachine.";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWorkingDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtWorkingDirectory.Location = new System.Drawing.Point(32, 75);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(533, 30);
            this.txtWorkingDirectory.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(393, 115);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(83, 32);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Select";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOK.Location = new System.Drawing.Point(482, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Done";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInvalidChars
            // 
            this.lblInvalidChars.AutoSize = true;
            this.lblInvalidChars.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidChars.Location = new System.Drawing.Point(28, 121);
            this.lblInvalidChars.Name = "lblInvalidChars";
            this.lblInvalidChars.Size = new System.Drawing.Size(237, 23);
            this.lblInvalidChars.TabIndex = 5;
            this.lblInvalidChars.Text = "Path contains invalid characters!";
            this.lblInvalidChars.Visible = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the working directory.";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Easy_Deploy.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WorkingDirectorySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(587, 176);
            this.Controls.Add(this.lblInvalidChars);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkingDirectorySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Deploy+ Working Directory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInvalidChars;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}