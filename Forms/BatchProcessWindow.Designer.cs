namespace PsTools_Easy_Deploy_Tool
{
    partial class BatchProcessWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchProcessWindow));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.percentage = new System.Windows.Forms.Label();
            this.currentStatus = new System.Windows.Forms.Label();
            this.Skip = new System.Windows.Forms.Button();
            this.StopAll = new System.Windows.Forms.Button();
            this.moreInfo = new System.Windows.Forms.Button();
            this.animTimer = new System.Windows.Forms.Timer(this.components);
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.dBox = new System.Windows.Forms.GroupBox();
            this.Next = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.dBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(431, 30);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(212, 78);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(27, 16);
            this.percentage.TabIndex = 1;
            this.percentage.Text = "0%";
            // 
            // currentStatus
            // 
            this.currentStatus.AutoSize = true;
            this.currentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatus.Location = new System.Drawing.Point(12, 18);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(74, 16);
            this.currentStatus.TabIndex = 2;
            this.currentStatus.Text = "Initializing...";
            // 
            // Skip
            // 
            this.Skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Skip.Location = new System.Drawing.Point(12, 102);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(87, 31);
            this.Skip.TabIndex = 3;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // StopAll
            // 
            this.StopAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopAll.Location = new System.Drawing.Point(356, 102);
            this.StopAll.Name = "StopAll";
            this.StopAll.Size = new System.Drawing.Size(87, 31);
            this.StopAll.TabIndex = 4;
            this.StopAll.Text = "Stop All";
            this.StopAll.UseVisualStyleBackColor = true;
            this.StopAll.Click += new System.EventHandler(this.StopAll_Click);
            // 
            // moreInfo
            // 
            this.moreInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moreInfo.FlatAppearance.BorderSize = 0;
            this.moreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfo.Location = new System.Drawing.Point(194, 114);
            this.moreInfo.Name = "moreInfo";
            this.moreInfo.Size = new System.Drawing.Size(56, 19);
            this.moreInfo.TabIndex = 5;
            this.moreInfo.Text = "\\/";
            this.moreInfo.UseVisualStyleBackColor = true;
            this.moreInfo.Click += new System.EventHandler(this.moreInfo_Click);
            // 
            // animTimer
            // 
            this.animTimer.Interval = 4;
            this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // totalTimer
            // 
            this.totalTimer.Interval = 1000;
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
            // 
            // currentTimer
            // 
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // dBox
            // 
            this.dBox.Controls.Add(this.Next);
            this.dBox.Controls.Add(this.CurrentTime);
            this.dBox.Controls.Add(this.TotalTime);
            this.dBox.Location = new System.Drawing.Point(12, 94);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(431, 81);
            this.dBox.TabIndex = 6;
            this.dBox.TabStop = false;
            this.dBox.Text = "Details";
            this.dBox.Visible = false;
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Location = new System.Drawing.Point(6, 25);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(32, 13);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next:";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Location = new System.Drawing.Point(301, 51);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(70, 13);
            this.CurrentTime.TabIndex = 4;
            this.CurrentTime.Text = "Current Time:";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(311, 25);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(60, 13);
            this.TotalTime.TabIndex = 1;
            this.TotalTime.Text = "Total Time:";
            // 
            // BatchProcessWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 145);
            this.Controls.Add(this.moreInfo);
            this.Controls.Add(this.StopAll);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.currentStatus);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchProcessWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy - Processing Deployment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchProcessWindow_FormClosing);
            this.dBox.ResumeLayout(false);
            this.dBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label currentStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button StopAll;
        private System.Windows.Forms.Button moreInfo;
        private System.Windows.Forms.Timer animTimer;
        private System.Windows.Forms.Timer totalTimer;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.GroupBox dBox;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label Next;
    }
}