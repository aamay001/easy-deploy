namespace Easy_Deploy.Utilities
{
    partial class LogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
            this.olvLogList = new BrightIdeasSoftware.ObjectListView();
            this.olvLogDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLogType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLogMessage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statInfoVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statWarnVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statErrorVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statCErrorVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statSecuVal = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.olvLogList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvLogList
            // 
            this.olvLogList.AllColumns.Add(this.olvLogDate);
            this.olvLogList.AllColumns.Add(this.olvLogType);
            this.olvLogList.AllColumns.Add(this.olvLogMessage);
            this.olvLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvLogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvLogDate,
            this.olvLogType,
            this.olvLogMessage});
            this.olvLogList.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvLogList.FullRowSelect = true;
            this.olvLogList.GridLines = true;
            this.olvLogList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvLogList.Location = new System.Drawing.Point(12, 12);
            this.olvLogList.Name = "olvLogList";
            this.olvLogList.ShowGroups = false;
            this.olvLogList.Size = new System.Drawing.Size(659, 603);
            this.olvLogList.SmallImageList = this.imageList;
            this.olvLogList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvLogList.TabIndex = 0;
            this.olvLogList.UseAlternatingBackColors = true;
            this.olvLogList.UseCompatibleStateImageBehavior = false;
            this.olvLogList.View = System.Windows.Forms.View.Details;
            // 
            // olvLogDate
            // 
            this.olvLogDate.AspectName = "Time";
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
            this.olvLogMessage.ToolTipText = "";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "StatusAnnotations_Information_16xLG_color.png");
            this.imageList.Images.SetKeyName(1, "StatusAnnotations_Warning_16xLG_color.png");
            this.imageList.Images.SetKeyName(2, "StatusAnnotations_Critical_16xLG.png");
            this.imageList.Images.SetKeyName(3, "StatusAnnotations_Critical_16xLG_color.png");
            this.imageList.Images.SetKeyName(4, "security_Shields_Blank_16xLG.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statInfoVal,
            this.toolStripStatusLabel2,
            this.statWarnVal,
            this.toolStripStatusLabel3,
            this.statErrorVal,
            this.toolStripStatusLabel4,
            this.statCErrorVal,
            this.toolStripStatusLabel5,
            this.statSecuVal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "INFO :";
            // 
            // statInfoVal
            // 
            this.statInfoVal.Name = "statInfoVal";
            this.statInfoVal.Size = new System.Drawing.Size(13, 17);
            this.statInfoVal.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel2.Text = "WARNING :";
            // 
            // statWarnVal
            // 
            this.statWarnVal.Name = "statWarnVal";
            this.statWarnVal.Size = new System.Drawing.Size(13, 17);
            this.statWarnVal.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel3.Image")));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel3.Text = "ERROR :";
            // 
            // statErrorVal
            // 
            this.statErrorVal.Name = "statErrorVal";
            this.statErrorVal.Size = new System.Drawing.Size(13, 17);
            this.statErrorVal.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel4.Image")));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "CRITICAL ERROR :";
            // 
            // statCErrorVal
            // 
            this.statCErrorVal.Name = "statCErrorVal";
            this.statCErrorVal.Size = new System.Drawing.Size(13, 17);
            this.statCErrorVal.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel5.Image")));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel5.Text = "SECURITY :";
            // 
            // statSecuVal
            // 
            this.statSecuVal.Name = "statSecuVal";
            this.statSecuVal.Size = new System.Drawing.Size(13, 17);
            this.statSecuVal.Text = "0";
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 640);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.olvLogList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogViewer";
            this.Text = "Easy Deploy+ Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogViewer_FormClosing);
            this.Load += new System.EventHandler(this.LogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvLogList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvLogList;
        private BrightIdeasSoftware.OLVColumn olvLogDate;
        private BrightIdeasSoftware.OLVColumn olvLogType;
        private BrightIdeasSoftware.OLVColumn olvLogMessage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statInfoVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statWarnVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statErrorVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel statCErrorVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel statSecuVal;
    }
}