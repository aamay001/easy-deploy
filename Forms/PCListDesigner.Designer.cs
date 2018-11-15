namespace PsTools_Easy_Deploy_Tool
{
    partial class PCListDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCListDesigner));
            this.addSelected = new System.Windows.Forms.Button();
            this.remSelected = new System.Windows.Forms.Button();
            this.addAll = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearPreview = new System.Windows.Forms.Button();
            this.clearSelected = new System.Windows.Forms.Button();
            this.openList = new System.Windows.Forms.Button();
            this.saveList = new System.Windows.Forms.Button();
            this.Use = new System.Windows.Forms.Button();
            this.openComputerList = new System.Windows.Forms.OpenFileDialog();
            this.manualPC = new System.Windows.Forms.TextBox();
            this.manAdd = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.octet1 = new System.Windows.Forms.NumericUpDown();
            this.octet2 = new System.Windows.Forms.NumericUpDown();
            this.octet3 = new System.Windows.Forms.NumericUpDown();
            this.SubnetScanGroup = new System.Windows.Forms.GroupBox();
            this.scanSubnet = new System.Windows.Forms.Button();
            this.ManualGroup = new System.Windows.Forms.GroupBox();
            this.adCheck = new System.Windows.Forms.CheckBox();
            this.adSearchGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adSearchCaseSensitive = new System.Windows.Forms.CheckBox();
            this.adSearchStartsWith = new System.Windows.Forms.CheckBox();
            this.adSearchContains = new System.Windows.Forms.CheckBox();
            this.adSearch = new System.Windows.Forms.Button();
            this.adSearchKey = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchResultsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumSelectedComps = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subnetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveButtons = new System.Windows.Forms.GroupBox();
            this.AddAllAvailable = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ListIOGroup = new System.Windows.Forms.GroupBox();
            this.candidates = new System.Windows.Forms.ListView();
            this.main = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.octet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octet3)).BeginInit();
            this.SubnetScanGroup.SuspendLayout();
            this.ManualGroup.SuspendLayout();
            this.adSearchGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SearchGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MoveButtons.SuspendLayout();
            this.ListIOGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSelected
            // 
            this.addSelected.ForeColor = System.Drawing.Color.Green;
            this.addSelected.Location = new System.Drawing.Point(6, 19);
            this.addSelected.Name = "addSelected";
            this.addSelected.Size = new System.Drawing.Size(64, 39);
            this.addSelected.TabIndex = 2;
            this.addSelected.Text = "Add >>";
            this.addSelected.UseVisualStyleBackColor = true;
            this.addSelected.Click += new System.EventHandler(this.addSelected_Click);
            // 
            // remSelected
            // 
            this.remSelected.ForeColor = System.Drawing.Color.Red;
            this.remSelected.Location = new System.Drawing.Point(6, 64);
            this.remSelected.Name = "remSelected";
            this.remSelected.Size = new System.Drawing.Size(64, 39);
            this.remSelected.TabIndex = 3;
            this.remSelected.Text = "<< Rem";
            this.remSelected.UseVisualStyleBackColor = true;
            this.remSelected.Click += new System.EventHandler(this.remSelected_Click);
            // 
            // addAll
            // 
            this.addAll.ForeColor = System.Drawing.Color.Green;
            this.addAll.Location = new System.Drawing.Point(6, 220);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(64, 39);
            this.addAll.TabIndex = 4;
            this.addAll.Text = "All >>";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Click += new System.EventHandler(this.addAll_Click);
            // 
            // removeAll
            // 
            this.removeAll.ForeColor = System.Drawing.Color.Red;
            this.removeAll.Location = new System.Drawing.Point(6, 265);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(64, 39);
            this.removeAll.TabIndex = 5;
            this.removeAll.Text = "<< All";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected Computers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search/Scan Results";
            // 
            // clearPreview
            // 
            this.clearPreview.ForeColor = System.Drawing.Color.Red;
            this.clearPreview.Location = new System.Drawing.Point(6, 329);
            this.clearPreview.Name = "clearPreview";
            this.clearPreview.Size = new System.Drawing.Size(64, 39);
            this.clearPreview.TabIndex = 15;
            this.clearPreview.Text = "Clear Search";
            this.clearPreview.UseVisualStyleBackColor = true;
            this.clearPreview.Click += new System.EventHandler(this.clearPreview_Click);
            // 
            // clearSelected
            // 
            this.clearSelected.ForeColor = System.Drawing.Color.Red;
            this.clearSelected.Location = new System.Drawing.Point(6, 374);
            this.clearSelected.Name = "clearSelected";
            this.clearSelected.Size = new System.Drawing.Size(64, 39);
            this.clearSelected.TabIndex = 16;
            this.clearSelected.Text = "Clear Selected";
            this.clearSelected.UseVisualStyleBackColor = true;
            this.clearSelected.Click += new System.EventHandler(this.clearSelected_Click);
            // 
            // openList
            // 
            this.openList.Location = new System.Drawing.Point(6, 10);
            this.openList.Name = "openList";
            this.openList.Size = new System.Drawing.Size(75, 23);
            this.openList.TabIndex = 5;
            this.openList.Text = "Open List";
            this.openList.UseVisualStyleBackColor = true;
            this.openList.Click += new System.EventHandler(this.openList_Click);
            // 
            // saveList
            // 
            this.saveList.Location = new System.Drawing.Point(554, 10);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(75, 23);
            this.saveList.TabIndex = 6;
            this.saveList.Text = "Save List";
            this.saveList.UseVisualStyleBackColor = true;
            this.saveList.Click += new System.EventHandler(this.saveList_Click);
            // 
            // Use
            // 
            this.Use.Location = new System.Drawing.Point(635, 10);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(75, 23);
            this.Use.TabIndex = 7;
            this.Use.Text = "Use List";
            this.Use.UseVisualStyleBackColor = true;
            this.Use.Click += new System.EventHandler(this.Use_Click);
            // 
            // openComputerList
            // 
            this.openComputerList.Filter = "Text File|*.txt";
            this.openComputerList.Title = "Select Computer List";
            this.openComputerList.FileOk += new System.ComponentModel.CancelEventHandler(this.openComputerList_FileOk);
            // 
            // manualPC
            // 
            this.manualPC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.manualPC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.manualPC.Location = new System.Drawing.Point(15, 19);
            this.manualPC.Name = "manualPC";
            this.manualPC.Size = new System.Drawing.Size(181, 20);
            this.manualPC.TabIndex = 24;
            this.manualPC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualPC_KeyDown);
            // 
            // manAdd
            // 
            this.manAdd.Location = new System.Drawing.Point(305, 18);
            this.manAdd.Name = "manAdd";
            this.manAdd.Size = new System.Drawing.Size(75, 23);
            this.manAdd.TabIndex = 26;
            this.manAdd.Text = "Add";
            this.manAdd.UseVisualStyleBackColor = true;
            this.manAdd.Click += new System.EventHandler(this.manAdd_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Plan Text|*.txt";
            this.saveFile.Title = "Save List";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // octet1
            // 
            this.octet1.Location = new System.Drawing.Point(16, 21);
            this.octet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.octet1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.octet1.Name = "octet1";
            this.octet1.Size = new System.Drawing.Size(57, 20);
            this.octet1.TabIndex = 27;
            this.octet1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.octet1.Click += new System.EventHandler(this.octet1_Click);
            this.octet1.Enter += new System.EventHandler(this.octet1_Enter);
            // 
            // octet2
            // 
            this.octet2.Location = new System.Drawing.Point(79, 21);
            this.octet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.octet2.Name = "octet2";
            this.octet2.Size = new System.Drawing.Size(57, 20);
            this.octet2.TabIndex = 28;
            this.octet2.Click += new System.EventHandler(this.octet2_Click);
            this.octet2.Enter += new System.EventHandler(this.octet2_Enter);
            // 
            // octet3
            // 
            this.octet3.Location = new System.Drawing.Point(142, 21);
            this.octet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.octet3.Name = "octet3";
            this.octet3.Size = new System.Drawing.Size(57, 20);
            this.octet3.TabIndex = 29;
            this.octet3.Click += new System.EventHandler(this.octet3_Click);
            this.octet3.Enter += new System.EventHandler(this.octet3_Enter);
            // 
            // SubnetScanGroup
            // 
            this.SubnetScanGroup.Controls.Add(this.scanSubnet);
            this.SubnetScanGroup.Controls.Add(this.octet1);
            this.SubnetScanGroup.Controls.Add(this.octet3);
            this.SubnetScanGroup.Controls.Add(this.octet2);
            this.SubnetScanGroup.Location = new System.Drawing.Point(13, 22);
            this.SubnetScanGroup.Name = "SubnetScanGroup";
            this.SubnetScanGroup.Size = new System.Drawing.Size(320, 53);
            this.SubnetScanGroup.TabIndex = 31;
            this.SubnetScanGroup.TabStop = false;
            this.SubnetScanGroup.Text = "Subnet Scan";
            // 
            // scanSubnet
            // 
            this.scanSubnet.Location = new System.Drawing.Point(219, 18);
            this.scanSubnet.Name = "scanSubnet";
            this.scanSubnet.Size = new System.Drawing.Size(86, 23);
            this.scanSubnet.TabIndex = 30;
            this.scanSubnet.Text = "Scan";
            this.scanSubnet.UseVisualStyleBackColor = true;
            this.scanSubnet.Click += new System.EventHandler(this.scanSubnet_Click);
            // 
            // ManualGroup
            // 
            this.ManualGroup.Controls.Add(this.adCheck);
            this.ManualGroup.Controls.Add(this.manualPC);
            this.ManualGroup.Controls.Add(this.manAdd);
            this.ManualGroup.Location = new System.Drawing.Point(339, 22);
            this.ManualGroup.Name = "ManualGroup";
            this.ManualGroup.Size = new System.Drawing.Size(390, 53);
            this.ManualGroup.TabIndex = 32;
            this.ManualGroup.TabStop = false;
            this.ManualGroup.Text = "Manual Add";
            // 
            // adCheck
            // 
            this.adCheck.AutoSize = true;
            this.adCheck.Location = new System.Drawing.Point(213, 22);
            this.adCheck.Name = "adCheck";
            this.adCheck.Size = new System.Drawing.Size(86, 17);
            this.adCheck.TabIndex = 27;
            this.adCheck.Text = "Check in AD";
            this.adCheck.UseVisualStyleBackColor = true;
            // 
            // adSearchGroup
            // 
            this.adSearchGroup.Controls.Add(this.label3);
            this.adSearchGroup.Controls.Add(this.adSearchCaseSensitive);
            this.adSearchGroup.Controls.Add(this.adSearchStartsWith);
            this.adSearchGroup.Controls.Add(this.adSearchContains);
            this.adSearchGroup.Controls.Add(this.adSearch);
            this.adSearchGroup.Controls.Add(this.adSearchKey);
            this.adSearchGroup.Location = new System.Drawing.Point(13, 81);
            this.adSearchGroup.Name = "adSearchGroup";
            this.adSearchGroup.Size = new System.Drawing.Size(716, 52);
            this.adSearchGroup.TabIndex = 33;
            this.adSearchGroup.TabStop = false;
            this.adSearchGroup.Text = "Active Directory Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Search Options :";
            // 
            // adSearchCaseSensitive
            // 
            this.adSearchCaseSensitive.AutoSize = true;
            this.adSearchCaseSensitive.Location = new System.Drawing.Point(504, 23);
            this.adSearchCaseSensitive.Name = "adSearchCaseSensitive";
            this.adSearchCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.adSearchCaseSensitive.TabIndex = 29;
            this.adSearchCaseSensitive.Text = "Case Sensitive";
            this.adSearchCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // adSearchStartsWith
            // 
            this.adSearchStartsWith.AutoSize = true;
            this.adSearchStartsWith.Checked = true;
            this.adSearchStartsWith.CheckState = System.Windows.Forms.CheckState.Checked;
            this.adSearchStartsWith.Location = new System.Drawing.Point(420, 23);
            this.adSearchStartsWith.Name = "adSearchStartsWith";
            this.adSearchStartsWith.Size = new System.Drawing.Size(78, 17);
            this.adSearchStartsWith.TabIndex = 28;
            this.adSearchStartsWith.Text = "Starts With";
            this.adSearchStartsWith.UseVisualStyleBackColor = true;
            // 
            // adSearchContains
            // 
            this.adSearchContains.AutoSize = true;
            this.adSearchContains.Location = new System.Drawing.Point(347, 23);
            this.adSearchContains.Name = "adSearchContains";
            this.adSearchContains.Size = new System.Drawing.Size(67, 17);
            this.adSearchContains.TabIndex = 27;
            this.adSearchContains.Text = "Contains";
            this.adSearchContains.UseVisualStyleBackColor = true;
            // 
            // adSearch
            // 
            this.adSearch.Location = new System.Drawing.Point(620, 19);
            this.adSearch.Name = "adSearch";
            this.adSearch.Size = new System.Drawing.Size(86, 23);
            this.adSearch.TabIndex = 26;
            this.adSearch.Text = "Search";
            this.adSearch.UseVisualStyleBackColor = true;
            this.adSearch.Click += new System.EventHandler(this.adSearch_Click);
            // 
            // adSearchKey
            // 
            this.adSearchKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.adSearchKey.Location = new System.Drawing.Point(16, 21);
            this.adSearchKey.Name = "adSearchKey";
            this.adSearchKey.Size = new System.Drawing.Size(223, 20);
            this.adSearchKey.TabIndex = 25;
            this.adSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adSearchKey_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.searchResultsCount,
            this.toolStripStatusLabel2,
            this.NumSelectedComps});
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Search Results: ";
            // 
            // searchResultsCount
            // 
            this.searchResultsCount.Name = "searchResultsCount";
            this.searchResultsCount.Size = new System.Drawing.Size(13, 17);
            this.searchResultsCount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel2.Text = "Selected Computers:";
            // 
            // NumSelectedComps
            // 
            this.NumSelectedComps.Name = "NumSelectedComps";
            this.NumSelectedComps.Size = new System.Drawing.Size(13, 17);
            this.NumSelectedComps.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SearchGroup
            // 
            this.SearchGroup.Controls.Add(this.SubnetScanGroup);
            this.SearchGroup.Controls.Add(this.ManualGroup);
            this.SearchGroup.Controls.Add(this.adSearchGroup);
            this.SearchGroup.Location = new System.Drawing.Point(12, 30);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(741, 146);
            this.SearchGroup.TabIndex = 1;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeDirectoryToolStripMenuItem,
            this.subnetsToolStripMenuItem,
            this.hostsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activeDirectoryToolStripMenuItem
            // 
            this.activeDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.activeDirectoryToolStripMenuItem.Name = "activeDirectoryToolStripMenuItem";
            this.activeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.activeDirectoryToolStripMenuItem.Text = "Active Directory";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // subnetsToolStripMenuItem
            // 
            this.subnetsToolStripMenuItem.Name = "subnetsToolStripMenuItem";
            this.subnetsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.subnetsToolStripMenuItem.Text = "Local Subnets";
            // 
            // hostsToolStripMenuItem
            // 
            this.hostsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingAllToolStripMenuItem});
            this.hostsToolStripMenuItem.Name = "hostsToolStripMenuItem";
            this.hostsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hostsToolStripMenuItem.Text = "Search";
            // 
            // pingAllToolStripMenuItem
            // 
            this.pingAllToolStripMenuItem.Name = "pingAllToolStripMenuItem";
            this.pingAllToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pingAllToolStripMenuItem.Text = "Ping All";
            this.pingAllToolStripMenuItem.Click += new System.EventHandler(this.pingAllToolStripMenuItem_Click);
            // 
            // MoveButtons
            // 
            this.MoveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveButtons.Controls.Add(this.AddAllAvailable);
            this.MoveButtons.Controls.Add(this.addSelected);
            this.MoveButtons.Controls.Add(this.remSelected);
            this.MoveButtons.Controls.Add(this.addAll);
            this.MoveButtons.Controls.Add(this.removeAll);
            this.MoveButtons.Controls.Add(this.clearPreview);
            this.MoveButtons.Controls.Add(this.clearSelected);
            this.MoveButtons.Location = new System.Drawing.Point(343, 203);
            this.MoveButtons.Name = "MoveButtons";
            this.MoveButtons.Size = new System.Drawing.Size(78, 422);
            this.MoveButtons.TabIndex = 3;
            this.MoveButtons.TabStop = false;
            // 
            // AddAllAvailable
            // 
            this.AddAllAvailable.ForeColor = System.Drawing.Color.Green;
            this.AddAllAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAllAvailable.ImageIndex = 0;
            this.AddAllAvailable.ImageList = this.imageList;
            this.AddAllAvailable.Location = new System.Drawing.Point(6, 130);
            this.AddAllAvailable.Name = "AddAllAvailable";
            this.AddAllAvailable.Size = new System.Drawing.Size(64, 39);
            this.AddAllAvailable.TabIndex = 17;
            this.AddAllAvailable.Text = ">>";
            this.AddAllAvailable.UseVisualStyleBackColor = true;
            this.AddAllAvailable.Click += new System.EventHandler(this.AddAllAvailable_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "OK");
            this.imageList.Images.SetKeyName(1, "ERROR");
            this.imageList.Images.SetKeyName(2, "FAIL");
            this.imageList.Images.SetKeyName(3, "EVENT");
            this.imageList.Images.SetKeyName(4, "AUTH");
            this.imageList.Images.SetKeyName(5, "CLIENT CON");
            this.imageList.Images.SetKeyName(6, "CLIENT DISC");
            this.imageList.Images.SetKeyName(7, "POST MES");
            this.imageList.Images.SetKeyName(8, "WAITING");
            this.imageList.Images.SetKeyName(9, "ERROR CODE");
            // 
            // ListIOGroup
            // 
            this.ListIOGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListIOGroup.Controls.Add(this.openList);
            this.ListIOGroup.Controls.Add(this.saveList);
            this.ListIOGroup.Controls.Add(this.Use);
            this.ListIOGroup.Location = new System.Drawing.Point(25, 631);
            this.ListIOGroup.Name = "ListIOGroup";
            this.ListIOGroup.Size = new System.Drawing.Size(716, 39);
            this.ListIOGroup.TabIndex = 35;
            this.ListIOGroup.TabStop = false;
            // 
            // candidates
            // 
            this.candidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.candidates.CausesValidation = false;
            this.candidates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.main});
            this.candidates.FullRowSelect = true;
            this.candidates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.candidates.LabelWrap = false;
            this.candidates.Location = new System.Drawing.Point(24, 203);
            this.candidates.Name = "candidates";
            this.candidates.Size = new System.Drawing.Size(306, 422);
            this.candidates.StateImageList = this.imageList;
            this.candidates.TabIndex = 36;
            this.candidates.UseCompatibleStateImageBehavior = false;
            this.candidates.View = System.Windows.Forms.View.Details;
            this.candidates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.candidates_MouseDoubleClick);
            // 
            // main
            // 
            this.main.Width = 200;
            // 
            // selected
            // 
            this.selected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selected.CausesValidation = false;
            this.selected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.selected.FullRowSelect = true;
            this.selected.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.selected.LabelWrap = false;
            this.selected.Location = new System.Drawing.Point(435, 203);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(306, 422);
            this.selected.StateImageList = this.imageList;
            this.selected.TabIndex = 37;
            this.selected.UseCompatibleStateImageBehavior = false;
            this.selected.View = System.Windows.Forms.View.Details;
            this.selected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selected_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // PCListDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 709);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.candidates);
            this.Controls.Add(this.ListIOGroup);
            this.Controls.Add(this.MoveButtons);
            this.Controls.Add(this.SearchGroup);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PCListDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy - Computers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCListDesigner_FormClosing);
            this.Load += new System.EventHandler(this.PCListDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.octet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octet3)).EndInit();
            this.SubnetScanGroup.ResumeLayout(false);
            this.ManualGroup.ResumeLayout(false);
            this.ManualGroup.PerformLayout();
            this.adSearchGroup.ResumeLayout(false);
            this.adSearchGroup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SearchGroup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MoveButtons.ResumeLayout(false);
            this.ListIOGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSelected;
        private System.Windows.Forms.Button remSelected;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearPreview;
        private System.Windows.Forms.Button clearSelected;
        private System.Windows.Forms.Button openList;
        private System.Windows.Forms.Button saveList;
        private System.Windows.Forms.Button Use;
        private System.Windows.Forms.OpenFileDialog openComputerList;
        private System.Windows.Forms.TextBox manualPC;
        private System.Windows.Forms.Button manAdd;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.NumericUpDown octet1;
        private System.Windows.Forms.NumericUpDown octet2;
        private System.Windows.Forms.NumericUpDown octet3;
        private System.Windows.Forms.GroupBox SubnetScanGroup;
        private System.Windows.Forms.Button scanSubnet;
        private System.Windows.Forms.GroupBox ManualGroup;
        private System.Windows.Forms.CheckBox adCheck;
        private System.Windows.Forms.GroupBox adSearchGroup;
        private System.Windows.Forms.TextBox adSearchKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button adSearch;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox adSearchCaseSensitive;
        private System.Windows.Forms.CheckBox adSearchStartsWith;
        private System.Windows.Forms.CheckBox adSearchContains;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel searchResultsCount;
        private System.Windows.Forms.GroupBox SearchGroup;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel NumSelectedComps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.GroupBox MoveButtons;
        private System.Windows.Forms.ToolStripMenuItem subnetsToolStripMenuItem;
        private System.Windows.Forms.GroupBox ListIOGroup;
        private System.Windows.Forms.ListView candidates;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader main;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView selected;
        private System.Windows.Forms.Button AddAllAvailable;
        private System.Windows.Forms.ToolStripMenuItem hostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingAllToolStripMenuItem;
    }
}