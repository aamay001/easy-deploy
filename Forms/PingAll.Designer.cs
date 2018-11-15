namespace PsTools_Easy_Deploy_Tool
{
    partial class PingAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingAll));
            this.pingList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.done = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.doneAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.ButtonGroup = new System.Windows.Forms.GroupBox();
            this.KeepAlive = new System.Windows.Forms.CheckBox();
            this.fraction = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorStat = new System.Windows.Forms.Label();
            this.failStat = new System.Windows.Forms.Label();
            this.okStat = new System.Windows.Forms.Label();
            this.totalStat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runningThreads = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ThreadStartTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pingList
            // 
            this.pingList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pingList.AutoArrange = false;
            this.pingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.pingList.FullRowSelect = true;
            this.pingList.GridLines = true;
            this.pingList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.pingList.LabelWrap = false;
            this.pingList.Location = new System.Drawing.Point(12, 57);
            this.pingList.MultiSelect = false;
            this.pingList.Name = "pingList";
            this.pingList.Size = new System.Drawing.Size(358, 334);
            this.pingList.StateImageList = this.imageList;
            this.pingList.TabIndex = 0;
            this.pingList.UseCompatibleStateImageBehavior = false;
            this.pingList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Host/IP";
            this.columnHeader1.Width = 249;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ping";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 87;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "OK.png");
            this.imageList.Images.SetKeyName(1, "ERROR.png");
            this.imageList.Images.SetKeyName(2, "FAIL.png");
            // 
            // done
            // 
            this.done.Enabled = false;
            this.done.Location = new System.Drawing.Point(277, 46);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 1;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 11);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // doneAction
            // 
            this.doneAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doneAction.FormattingEnabled = true;
            this.doneAction.Items.AddRange(new object[] {
            "Check all OK",
            "Uncheck all FAIL",
            "Remove all FAIL",
            "Remove all ERROR",
            "Remove all ERROR and FAIL"});
            this.doneAction.Location = new System.Drawing.Point(183, 19);
            this.doneAction.Name = "doneAction";
            this.doneAction.Size = new System.Drawing.Size(169, 21);
            this.doneAction.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Done Action:";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(6, 46);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "Cancel";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonGroup.Controls.Add(this.KeepAlive);
            this.ButtonGroup.Controls.Add(this.stop);
            this.ButtonGroup.Controls.Add(this.done);
            this.ButtonGroup.Controls.Add(this.doneAction);
            this.ButtonGroup.Controls.Add(this.label1);
            this.ButtonGroup.Location = new System.Drawing.Point(12, 431);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(358, 75);
            this.ButtonGroup.TabIndex = 8;
            this.ButtonGroup.TabStop = false;
            // 
            // KeepAlive
            // 
            this.KeepAlive.AutoSize = true;
            this.KeepAlive.Location = new System.Drawing.Point(189, 50);
            this.KeepAlive.Name = "KeepAlive";
            this.KeepAlive.Size = new System.Drawing.Size(80, 17);
            this.KeepAlive.TabIndex = 8;
            this.KeepAlive.Text = "Don\'t Close";
            this.KeepAlive.UseVisualStyleBackColor = true;
            // 
            // fraction
            // 
            this.fraction.AutoSize = true;
            this.fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraction.Location = new System.Drawing.Point(117, 16);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(26, 16);
            this.fraction.TabIndex = 9;
            this.fraction.Text = "0/0";
            this.fraction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.errorStat);
            this.groupBox1.Controls.Add(this.failStat);
            this.groupBox1.Controls.Add(this.okStat);
            this.groupBox1.Controls.Add(this.totalStat);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 37);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // errorStat
            // 
            this.errorStat.AutoSize = true;
            this.errorStat.Location = new System.Drawing.Point(270, 15);
            this.errorStat.Name = "errorStat";
            this.errorStat.Size = new System.Drawing.Size(32, 13);
            this.errorStat.TabIndex = 3;
            this.errorStat.Text = "Error:";
            // 
            // failStat
            // 
            this.failStat.AutoSize = true;
            this.failStat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.failStat.Location = new System.Drawing.Point(186, 15);
            this.failStat.Name = "failStat";
            this.failStat.Size = new System.Drawing.Size(26, 13);
            this.failStat.TabIndex = 2;
            this.failStat.Text = "Fail:";
            // 
            // okStat
            // 
            this.okStat.AutoSize = true;
            this.okStat.Location = new System.Drawing.Point(95, 15);
            this.okStat.Name = "okStat";
            this.okStat.Size = new System.Drawing.Size(24, 13);
            this.okStat.TabIndex = 1;
            this.okStat.Text = "Ok:";
            // 
            // totalStat
            // 
            this.totalStat.AutoSize = true;
            this.totalStat.Location = new System.Drawing.Point(9, 15);
            this.totalStat.Name = "totalStat";
            this.totalStat.Size = new System.Drawing.Size(34, 13);
            this.totalStat.TabIndex = 0;
            this.totalStat.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Threads Started:";
            // 
            // runningThreads
            // 
            this.runningThreads.AutoSize = true;
            this.runningThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningThreads.Location = new System.Drawing.Point(226, 16);
            this.runningThreads.Name = "runningThreads";
            this.runningThreads.Size = new System.Drawing.Size(114, 16);
            this.runningThreads.TabIndex = 12;
            this.runningThreads.Text = "Threads Running:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ThreadStartTimer
            // 
            this.ThreadStartTimer.Interval = 1;
            this.ThreadStartTimer.Tick += new System.EventHandler(this.ThreadStartTimer_Tick);
            // 
            // PingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(382, 518);
            this.Controls.Add(this.runningThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.ButtonGroup);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pingList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 2048);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 39);
            this.Name = "PingAll";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy - Ping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PingAll_FormClosing);
            this.Load += new System.EventHandler(this.PingAll_Load);
            this.Resize += new System.EventHandler(this.PingAll_Resize);
            this.ButtonGroup.ResumeLayout(false);
            this.ButtonGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView pingList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox doneAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.GroupBox ButtonGroup;
        private System.Windows.Forms.Label fraction;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorStat;
        private System.Windows.Forms.Label failStat;
        private System.Windows.Forms.Label okStat;
        private System.Windows.Forms.Label totalStat;
        private System.Windows.Forms.CheckBox KeepAlive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label runningThreads;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer ThreadStartTimer;
    }
}