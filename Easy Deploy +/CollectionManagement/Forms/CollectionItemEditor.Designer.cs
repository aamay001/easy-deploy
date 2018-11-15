namespace Easy_Deploy.CollectionManagement
{ 
    partial class CollectionItemEditor
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNewCollectionName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(85, 48);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(282, 23);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Enter a name for your new collection.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Easy_Deploy.Properties.Resources.collectionRoot;
            this.pictureBox1.Location = new System.Drawing.Point(47, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNewCollectionName
            // 
            this.txtNewCollectionName.Location = new System.Drawing.Point(47, 82);
            this.txtNewCollectionName.Name = "txtNewCollectionName";
            this.txtNewCollectionName.Size = new System.Drawing.Size(452, 30);
            this.txtNewCollectionName.TabIndex = 4;
            this.txtNewCollectionName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewCollectionName_KeyUp);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(416, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 32);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(43, 126);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(178, 23);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid collection name!";
            this.lblError.Visible = false;
            // 
            // CollectionItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 176);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewCollectionName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollectionItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Deploy+ New Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNewCollectionName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblError;
    }
}