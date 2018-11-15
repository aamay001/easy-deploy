namespace Easy_Deploy.CollectionManagement
{
    partial class Console
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deployment", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Collections", 0, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statADSync = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblstatCollectionMembersCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newCollectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.createFolderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteItemtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tVCollections = new System.Windows.Forms.TreeView();
            this.ilCollections = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.SubnetScanGroup = new System.Windows.Forms.GroupBox();
            this.btnScanSubnet = new System.Windows.Forms.Button();
            this.numOctet1 = new System.Windows.Forms.NumericUpDown();
            this.numOctet3 = new System.Windows.Forms.NumericUpDown();
            this.numOctet2 = new System.Windows.Forms.NumericUpDown();
            this.ManualGroup = new System.Windows.Forms.GroupBox();
            this.chkCheckManualPCInAD = new System.Windows.Forms.CheckBox();
            this.txtManualPC = new System.Windows.Forms.TextBox();
            this.btnManualAdd = new System.Windows.Forms.Button();
            this.ADSearchGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkADSearchCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkADSearchStartsWith = new System.Windows.Forms.CheckBox();
            this.chkADSearchContains = new System.Windows.Forms.CheckBox();
            this.btnSearchAD = new System.Windows.Forms.Button();
            this.txtADSearchKey = new System.Windows.Forms.TextBox();
            this.olvCollectionViewer = new BrightIdeasSoftware.ObjectListView();
            this.olvDeviceName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeviceManufacturer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeviceModel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeviceOS = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvArchitecture = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDeviceStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvIPAddresses = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ilMemberStates = new System.Windows.Forms.ImageList(this.components);
            this.collectionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.getDeviceInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unavailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuTitleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.newCollecitonContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderContectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteItemContectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameItemContectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.useForDeploymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SearchGroup.SuspendLayout();
            this.SubnetScanGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOctet2)).BeginInit();
            this.ManualGroup.SuspendLayout();
            this.ADSearchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCollectionViewer)).BeginInit();
            this.collectionMenuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionToolStripMenuItem,
            this.activeDirectoryToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1199, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.createFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator2,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(78, 19);
            this.collectionToolStripMenuItem.Text = "Collections";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addToolStripMenuItem.Text = "New Collection";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.createFolderToolStripMenuItem.Text = "New Folder";
            this.createFolderToolStripMenuItem.Click += new System.EventHandler(this.createFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // activeDirectoryToolStripMenuItem
            // 
            this.activeDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncToolStripMenuItem,
            this.toolStripSeparator7,
            this.deleteCacheToolStripMenuItem});
            this.activeDirectoryToolStripMenuItem.Name = "activeDirectoryToolStripMenuItem";
            this.activeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(103, 19);
            this.activeDirectoryToolStripMenuItem.Text = "Active Directory";
            this.activeDirectoryToolStripMenuItem.DropDownOpening += new System.EventHandler(this.activeDirectoryToolStripMenuItem_DropDownOpening);
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.syncToolStripMenuItem.Text = "Sync";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // deleteCacheToolStripMenuItem
            // 
            this.deleteCacheToolStripMenuItem.Name = "deleteCacheToolStripMenuItem";
            this.deleteCacheToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteCacheToolStripMenuItem.Text = "Delete Cache File";
            this.deleteCacheToolStripMenuItem.Click += new System.EventHandler(this.deleteCacheToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statADSync,
            this.lblstatCollectionMembersCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 566);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1199, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statADSync
            // 
            this.statADSync.Image = global::Easy_Deploy.Properties.Resources.loadanim;
            this.statADSync.Name = "statADSync";
            this.statADSync.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.statADSync.Size = new System.Drawing.Size(48, 20);
            this.statADSync.Text = "AD";
            // 
            // lblstatCollectionMembersCount
            // 
            this.lblstatCollectionMembersCount.Image = global::Easy_Deploy.Properties.Resources.collectionMember;
            this.lblstatCollectionMembersCount.Name = "lblstatCollectionMembersCount";
            this.lblstatCollectionMembersCount.Size = new System.Drawing.Size(146, 20);
            this.lblstatCollectionMembersCount.Text = "Collection Members: 0";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCollectionToolStripButton,
            this.createFolderToolStripButton,
            this.deleteItemtoolStripButton,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1199, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newCollectionToolStripButton
            // 
            this.newCollectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newCollectionToolStripButton.Image = global::Easy_Deploy.Properties.Resources.collection;
            this.newCollectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newCollectionToolStripButton.Name = "newCollectionToolStripButton";
            this.newCollectionToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newCollectionToolStripButton.Text = "newCollectionToolStripButton";
            this.newCollectionToolStripButton.ToolTipText = "New Collection";
            this.newCollectionToolStripButton.Click += new System.EventHandler(this.newCollectionToolStripButton_Click);
            // 
            // createFolderToolStripButton
            // 
            this.createFolderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createFolderToolStripButton.Image = global::Easy_Deploy.Properties.Resources.folder;
            this.createFolderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createFolderToolStripButton.Name = "createFolderToolStripButton";
            this.createFolderToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.createFolderToolStripButton.Text = "New Folder";
            this.createFolderToolStripButton.Click += new System.EventHandler(this.createFolderToolStripButton_Click);
            // 
            // deleteItemtoolStripButton
            // 
            this.deleteItemtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemtoolStripButton.Image = global::Easy_Deploy.Properties.Resources.actionDelete;
            this.deleteItemtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemtoolStripButton.Name = "deleteItemtoolStripButton";
            this.deleteItemtoolStripButton.Size = new System.Drawing.Size(24, 24);
            this.deleteItemtoolStripButton.Text = "Delete Item";
            this.deleteItemtoolStripButton.ToolTipText = "Delete Item";
            this.deleteItemtoolStripButton.Click += new System.EventHandler(this.deleteItemtoolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tVCollections);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.splitContainer1.Panel1MinSize = 213;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 950;
            this.splitContainer1.Size = new System.Drawing.Size(1199, 514);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 3;
            // 
            // tVCollections
            // 
            this.tVCollections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVCollections.HideSelection = false;
            this.tVCollections.ImageIndex = 0;
            this.tVCollections.ImageList = this.ilCollections;
            this.tVCollections.Location = new System.Drawing.Point(5, 5);
            this.tVCollections.Name = "tVCollections";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Deployment";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "Collections\\Deployment";
            treeNode1.Text = "Deployment";
            treeNode1.ToolTipText = "This is the deployment collection.";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Collections";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Tag = "Collections";
            treeNode2.Text = "Collections";
            treeNode2.ToolTipText = "This is the root of your collections.";
            this.tVCollections.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tVCollections.SelectedImageIndex = 0;
            this.tVCollections.ShowNodeToolTips = true;
            this.tVCollections.Size = new System.Drawing.Size(239, 504);
            this.tVCollections.TabIndex = 0;
            this.tVCollections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVCollections_AfterSelect);
            this.tVCollections.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tVCollections_MouseDown);
            // 
            // ilCollections
            // 
            this.ilCollections.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCollections.ImageStream")));
            this.ilCollections.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCollections.Images.SetKeyName(0, "DBSchema_12823_16x.png");
            this.ilCollections.Images.SetKeyName(1, "arrow_Forward_color_16xLG.png");
            this.ilCollections.Images.SetKeyName(2, "list_16xMD.png");
            this.ilCollections.Images.SetKeyName(3, "folder_Closed_16xLG.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.CausesValidation = false;
            this.splitContainer2.Panel1.Controls.Add(this.SearchGroup);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.olvCollectionViewer);
            this.splitContainer2.Panel2.Controls.Add(this.collectionMenuStrip);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.splitContainer2.Size = new System.Drawing.Size(951, 514);
            this.splitContainer2.SplitterDistance = 190;
            this.splitContainer2.TabIndex = 0;
            // 
            // SearchGroup
            // 
            this.SearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroup.Controls.Add(this.SubnetScanGroup);
            this.SearchGroup.Controls.Add(this.ManualGroup);
            this.SearchGroup.Controls.Add(this.ADSearchGroup);
            this.SearchGroup.Location = new System.Drawing.Point(3, 5);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(940, 175);
            this.SearchGroup.TabIndex = 2;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search";
            // 
            // SubnetScanGroup
            // 
            this.SubnetScanGroup.Controls.Add(this.btnScanSubnet);
            this.SubnetScanGroup.Controls.Add(this.numOctet1);
            this.SubnetScanGroup.Controls.Add(this.numOctet3);
            this.SubnetScanGroup.Controls.Add(this.numOctet2);
            this.SubnetScanGroup.Location = new System.Drawing.Point(19, 24);
            this.SubnetScanGroup.Name = "SubnetScanGroup";
            this.SubnetScanGroup.Size = new System.Drawing.Size(341, 65);
            this.SubnetScanGroup.TabIndex = 31;
            this.SubnetScanGroup.TabStop = false;
            this.SubnetScanGroup.Text = "Subnet Scan";
            // 
            // btnScanSubnet
            // 
            this.btnScanSubnet.Location = new System.Drawing.Point(238, 23);
            this.btnScanSubnet.Name = "btnScanSubnet";
            this.btnScanSubnet.Size = new System.Drawing.Size(86, 33);
            this.btnScanSubnet.TabIndex = 30;
            this.btnScanSubnet.Text = "Scan";
            this.btnScanSubnet.UseVisualStyleBackColor = true;
            // 
            // numOctet1
            // 
            this.numOctet1.Location = new System.Drawing.Point(16, 25);
            this.numOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOctet1.Name = "numOctet1";
            this.numOctet1.Size = new System.Drawing.Size(57, 25);
            this.numOctet1.TabIndex = 27;
            // 
            // numOctet3
            // 
            this.numOctet3.Location = new System.Drawing.Point(158, 25);
            this.numOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOctet3.Name = "numOctet3";
            this.numOctet3.Size = new System.Drawing.Size(57, 25);
            this.numOctet3.TabIndex = 29;
            // 
            // numOctet2
            // 
            this.numOctet2.Location = new System.Drawing.Point(87, 25);
            this.numOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOctet2.Name = "numOctet2";
            this.numOctet2.Size = new System.Drawing.Size(57, 25);
            this.numOctet2.TabIndex = 28;
            // 
            // ManualGroup
            // 
            this.ManualGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualGroup.Controls.Add(this.chkCheckManualPCInAD);
            this.ManualGroup.Controls.Add(this.txtManualPC);
            this.ManualGroup.Controls.Add(this.btnManualAdd);
            this.ManualGroup.Location = new System.Drawing.Point(366, 24);
            this.ManualGroup.Name = "ManualGroup";
            this.ManualGroup.Size = new System.Drawing.Size(558, 65);
            this.ManualGroup.TabIndex = 32;
            this.ManualGroup.TabStop = false;
            this.ManualGroup.Text = "Manual Add";
            // 
            // chkCheckManualPCInAD
            // 
            this.chkCheckManualPCInAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCheckManualPCInAD.AutoSize = true;
            this.chkCheckManualPCInAD.Location = new System.Drawing.Point(366, 27);
            this.chkCheckManualPCInAD.Name = "chkCheckManualPCInAD";
            this.chkCheckManualPCInAD.Size = new System.Drawing.Size(99, 23);
            this.chkCheckManualPCInAD.TabIndex = 27;
            this.chkCheckManualPCInAD.Text = "Check in AD";
            this.chkCheckManualPCInAD.UseVisualStyleBackColor = true;
            // 
            // txtManualPC
            // 
            this.txtManualPC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManualPC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtManualPC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtManualPC.Location = new System.Drawing.Point(15, 25);
            this.txtManualPC.Name = "txtManualPC";
            this.txtManualPC.Size = new System.Drawing.Size(316, 25);
            this.txtManualPC.TabIndex = 24;
            // 
            // btnManualAdd
            // 
            this.btnManualAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManualAdd.Location = new System.Drawing.Point(467, 23);
            this.btnManualAdd.Name = "btnManualAdd";
            this.btnManualAdd.Size = new System.Drawing.Size(75, 33);
            this.btnManualAdd.TabIndex = 26;
            this.btnManualAdd.Text = "Add";
            this.btnManualAdd.UseVisualStyleBackColor = true;
            // 
            // ADSearchGroup
            // 
            this.ADSearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADSearchGroup.Controls.Add(this.label3);
            this.ADSearchGroup.Controls.Add(this.chkADSearchCaseSensitive);
            this.ADSearchGroup.Controls.Add(this.chkADSearchStartsWith);
            this.ADSearchGroup.Controls.Add(this.chkADSearchContains);
            this.ADSearchGroup.Controls.Add(this.btnSearchAD);
            this.ADSearchGroup.Controls.Add(this.txtADSearchKey);
            this.ADSearchGroup.Location = new System.Drawing.Point(19, 95);
            this.ADSearchGroup.Name = "ADSearchGroup";
            this.ADSearchGroup.Size = new System.Drawing.Size(905, 65);
            this.ADSearchGroup.TabIndex = 33;
            this.ADSearchGroup.TabStop = false;
            this.ADSearchGroup.Text = "Active Directory Search";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Search Options :";
            // 
            // chkADSearchCaseSensitive
            // 
            this.chkADSearchCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkADSearchCaseSensitive.AutoSize = true;
            this.chkADSearchCaseSensitive.Location = new System.Drawing.Point(684, 26);
            this.chkADSearchCaseSensitive.Name = "chkADSearchCaseSensitive";
            this.chkADSearchCaseSensitive.Size = new System.Drawing.Size(109, 23);
            this.chkADSearchCaseSensitive.TabIndex = 29;
            this.chkADSearchCaseSensitive.Text = "Case Sensitive";
            this.chkADSearchCaseSensitive.UseVisualStyleBackColor = true;
            this.chkADSearchCaseSensitive.CheckedChanged += new System.EventHandler(this.chkADSearchCaseSensitive_CheckedChanged);
            // 
            // chkADSearchStartsWith
            // 
            this.chkADSearchStartsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkADSearchStartsWith.AutoSize = true;
            this.chkADSearchStartsWith.Checked = true;
            this.chkADSearchStartsWith.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkADSearchStartsWith.Location = new System.Drawing.Point(558, 26);
            this.chkADSearchStartsWith.Name = "chkADSearchStartsWith";
            this.chkADSearchStartsWith.Size = new System.Drawing.Size(92, 23);
            this.chkADSearchStartsWith.TabIndex = 28;
            this.chkADSearchStartsWith.Text = "Starts With";
            this.chkADSearchStartsWith.UseVisualStyleBackColor = true;
            this.chkADSearchStartsWith.CheckedChanged += new System.EventHandler(this.chkADSearchStartsWith_CheckedChanged);
            // 
            // chkADSearchContains
            // 
            this.chkADSearchContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkADSearchContains.AutoSize = true;
            this.chkADSearchContains.Location = new System.Drawing.Point(453, 26);
            this.chkADSearchContains.Name = "chkADSearchContains";
            this.chkADSearchContains.Size = new System.Drawing.Size(78, 23);
            this.chkADSearchContains.TabIndex = 27;
            this.chkADSearchContains.Text = "Contains";
            this.chkADSearchContains.UseVisualStyleBackColor = true;
            this.chkADSearchContains.CheckedChanged += new System.EventHandler(this.chkADSearchContains_CheckedChanged);
            // 
            // btnSearchAD
            // 
            this.btnSearchAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchAD.Location = new System.Drawing.Point(803, 23);
            this.btnSearchAD.Name = "btnSearchAD";
            this.btnSearchAD.Size = new System.Drawing.Size(86, 33);
            this.btnSearchAD.TabIndex = 26;
            this.btnSearchAD.Text = "Search";
            this.btnSearchAD.UseVisualStyleBackColor = true;
            this.btnSearchAD.Click += new System.EventHandler(this.btnSearchAD_Click);
            // 
            // txtADSearchKey
            // 
            this.txtADSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtADSearchKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtADSearchKey.Location = new System.Drawing.Point(16, 24);
            this.txtADSearchKey.Name = "txtADSearchKey";
            this.txtADSearchKey.Size = new System.Drawing.Size(272, 25);
            this.txtADSearchKey.TabIndex = 25;
            this.txtADSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtADSearchKey_KeyDown);
            // 
            // olvCollectionViewer
            // 
            this.olvCollectionViewer.AllColumns.Add(this.olvDeviceName);
            this.olvCollectionViewer.AllColumns.Add(this.olvDeviceManufacturer);
            this.olvCollectionViewer.AllColumns.Add(this.olvDeviceModel);
            this.olvCollectionViewer.AllColumns.Add(this.olvDeviceOS);
            this.olvCollectionViewer.AllColumns.Add(this.olvArchitecture);
            this.olvCollectionViewer.AllColumns.Add(this.olvDeviceStatus);
            this.olvCollectionViewer.AllColumns.Add(this.olvIPAddresses);
            this.olvCollectionViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvDeviceName,
            this.olvDeviceManufacturer,
            this.olvDeviceModel,
            this.olvDeviceOS,
            this.olvArchitecture,
            this.olvDeviceStatus,
            this.olvIPAddresses});
            this.olvCollectionViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvCollectionViewer.FullRowSelect = true;
            this.olvCollectionViewer.GridLines = true;
            this.olvCollectionViewer.HasCollapsibleGroups = false;
            this.olvCollectionViewer.LabelWrap = false;
            this.olvCollectionViewer.Location = new System.Drawing.Point(0, 28);
            this.olvCollectionViewer.Name = "olvCollectionViewer";
            this.olvCollectionViewer.ShowGroups = false;
            this.olvCollectionViewer.Size = new System.Drawing.Size(946, 287);
            this.olvCollectionViewer.SmallImageList = this.ilMemberStates;
            this.olvCollectionViewer.TabIndex = 1;
            this.olvCollectionViewer.UseCompatibleStateImageBehavior = false;
            this.olvCollectionViewer.View = System.Windows.Forms.View.Details;
            // 
            // olvDeviceName
            // 
            this.olvDeviceName.AspectName = "Name";
            this.olvDeviceName.Text = "Name";
            this.olvDeviceName.Width = 175;
            // 
            // olvDeviceManufacturer
            // 
            this.olvDeviceManufacturer.AspectName = "Manufacturer";
            this.olvDeviceManufacturer.Text = "Manufacturer";
            this.olvDeviceManufacturer.Width = 125;
            // 
            // olvDeviceModel
            // 
            this.olvDeviceModel.AspectName = "Model";
            this.olvDeviceModel.Text = "Model";
            this.olvDeviceModel.Width = 125;
            // 
            // olvDeviceOS
            // 
            this.olvDeviceOS.AspectName = "OperatingSystem";
            this.olvDeviceOS.Text = "Operating System";
            this.olvDeviceOS.Width = 150;
            // 
            // olvArchitecture
            // 
            this.olvArchitecture.AspectName = "Architecture";
            this.olvArchitecture.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvArchitecture.Text = "Architecture";
            this.olvArchitecture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvArchitecture.Width = 100;
            // 
            // olvDeviceStatus
            // 
            this.olvDeviceStatus.AspectName = "PingState";
            this.olvDeviceStatus.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeviceStatus.Text = "Status";
            this.olvDeviceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvDeviceStatus.Width = 100;
            // 
            // olvIPAddresses
            // 
            this.olvIPAddresses.AspectName = "IPAddresses";
            this.olvIPAddresses.FillsFreeSpace = true;
            this.olvIPAddresses.Text = "IP Address";
            this.olvIPAddresses.Width = 100;
            // 
            // ilMemberStates
            // 
            this.ilMemberStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMemberStates.ImageStream")));
            this.ilMemberStates.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMemberStates.Images.SetKeyName(0, "StatusAnnotations_Complete_and_ok_16xMD_color.png");
            this.ilMemberStates.Images.SetKeyName(1, "StatusAnnotations_Warning_16xMD_color.png");
            this.ilMemberStates.Images.SetKeyName(2, "StatusAnnotationRed_No_16xMD.png");
            this.ilMemberStates.Images.SetKeyName(3, "StatusAnnotations_Help_and_inconclusive_16xMD_color.png");
            this.ilMemberStates.Images.SetKeyName(4, "Synchronize_16xMD.png");
            // 
            // collectionMenuStrip
            // 
            this.collectionMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.collectionMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.collectionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDeviceInformationToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.collectionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.collectionMenuStrip.Name = "collectionMenuStrip";
            this.collectionMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.collectionMenuStrip.Size = new System.Drawing.Size(946, 28);
            this.collectionMenuStrip.TabIndex = 0;
            this.collectionMenuStrip.Text = "menuStrip1";
            // 
            // getDeviceInformationToolStripMenuItem
            // 
            this.getDeviceInformationToolStripMenuItem.Image = global::Easy_Deploy.Properties.Resources.collectionMember;
            this.getDeviceInformationToolStripMenuItem.Name = "getDeviceInformationToolStripMenuItem";
            this.getDeviceInformationToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.getDeviceInformationToolStripMenuItem.Text = "Get Device Details";
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Image = global::Easy_Deploy.Properties.Resources.function;
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.pingToolStripMenuItem.Text = "Ping";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.unavailableToolStripMenuItem,
            this.availableToolStripMenuItem,
            this.errorToolStripMenuItem,
            this.allToolStripMenuItem});
            this.deleteToolStripMenuItem1.Image = global::Easy_Deploy.Properties.Resources.actionDelete;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(82, 24);
            this.deleteToolStripMenuItem1.Text = "Remove";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
            // 
            // unavailableToolStripMenuItem
            // 
            this.unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
            this.unavailableToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.unavailableToolStripMenuItem.Text = "Unavailable";
            this.unavailableToolStripMenuItem.Click += new System.EventHandler(this.unavailableToolStripMenuItem_Click);
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            this.availableToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.availableToolStripMenuItem.Text = "Available";
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.availableToolStripMenuItem_Click);
            // 
            // errorToolStripMenuItem
            // 
            this.errorToolStripMenuItem.Name = "errorToolStripMenuItem";
            this.errorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.errorToolStripMenuItem.Text = "Error";
            this.errorToolStripMenuItem.Click += new System.EventHandler(this.errorToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuTitleItem,
            this.toolStripSeparator4,
            this.newCollecitonContextMenuItem,
            this.newFolderContectMenuItem,
            this.toolStripSeparator5,
            this.deleteItemContectMenuItem,
            this.renameItemContectMenuItem,
            this.toolStripSeparator6,
            this.useForDeploymentToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(180, 154);
            // 
            // contextMenuTitleItem
            // 
            this.contextMenuTitleItem.AutoToolTip = true;
            this.contextMenuTitleItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuTitleItem.Enabled = false;
            this.contextMenuTitleItem.Name = "contextMenuTitleItem";
            this.contextMenuTitleItem.Size = new System.Drawing.Size(179, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // newCollecitonContextMenuItem
            // 
            this.newCollecitonContextMenuItem.Name = "newCollecitonContextMenuItem";
            this.newCollecitonContextMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newCollecitonContextMenuItem.Text = "New Collection";
            this.newCollecitonContextMenuItem.Click += new System.EventHandler(this.newCollecitonContextMenuItem_Click);
            // 
            // newFolderContectMenuItem
            // 
            this.newFolderContectMenuItem.Name = "newFolderContectMenuItem";
            this.newFolderContectMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newFolderContectMenuItem.Text = "New Folder";
            this.newFolderContectMenuItem.Click += new System.EventHandler(this.newFolderContectMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // deleteItemContectMenuItem
            // 
            this.deleteItemContectMenuItem.Name = "deleteItemContectMenuItem";
            this.deleteItemContectMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteItemContectMenuItem.Text = "Delete";
            this.deleteItemContectMenuItem.Click += new System.EventHandler(this.deleteItemContectMenuItem_Click);
            // 
            // renameItemContectMenuItem
            // 
            this.renameItemContectMenuItem.Name = "renameItemContectMenuItem";
            this.renameItemContectMenuItem.Size = new System.Drawing.Size(179, 22);
            this.renameItemContectMenuItem.Text = "Rename";
            this.renameItemContectMenuItem.Click += new System.EventHandler(this.renameItemContectMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(176, 6);
            // 
            // useForDeploymentToolStripMenuItem
            // 
            this.useForDeploymentToolStripMenuItem.Name = "useForDeploymentToolStripMenuItem";
            this.useForDeploymentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.useForDeploymentToolStripMenuItem.Text = "Use for Deployment";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // CollectionManagementConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1199, 591);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1215, 630);
            this.Name = "CollectionManagementConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Deploy+ Collection Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CollectionManagerUI_FormClosing);
            this.Load += new System.EventHandler(this.CollectionManagerUI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.SearchGroup.ResumeLayout(false);
            this.SubnetScanGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOctet2)).EndInit();
            this.ManualGroup.ResumeLayout(false);
            this.ManualGroup.PerformLayout();
            this.ADSearchGroup.ResumeLayout(false);
            this.ADSearchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCollectionViewer)).EndInit();
            this.collectionMenuStrip.ResumeLayout(false);
            this.collectionMenuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tVCollections;
        private System.Windows.Forms.ImageList ilCollections;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox SearchGroup;
        private System.Windows.Forms.GroupBox SubnetScanGroup;
        private System.Windows.Forms.Button btnScanSubnet;
        private System.Windows.Forms.NumericUpDown numOctet1;
        private System.Windows.Forms.NumericUpDown numOctet3;
        private System.Windows.Forms.NumericUpDown numOctet2;
        private System.Windows.Forms.GroupBox ManualGroup;
        private System.Windows.Forms.CheckBox chkCheckManualPCInAD;
        private System.Windows.Forms.TextBox txtManualPC;
        private System.Windows.Forms.Button btnManualAdd;
        private System.Windows.Forms.GroupBox ADSearchGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkADSearchCaseSensitive;
        private System.Windows.Forms.CheckBox chkADSearchStartsWith;
        private System.Windows.Forms.CheckBox chkADSearchContains;
        private System.Windows.Forms.Button btnSearchAD;
        private System.Windows.Forms.TextBox txtADSearchKey;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newCollectionToolStripButton;
        private System.Windows.Forms.ToolStripButton createFolderToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteItemtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem newCollecitonContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderContectMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem deleteItemContectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameItemContectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuTitleItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem useForDeploymentToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView olvCollectionViewer;
        private System.Windows.Forms.MenuStrip collectionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem getDeviceInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private BrightIdeasSoftware.OLVColumn olvDeviceName;
        private BrightIdeasSoftware.OLVColumn olvDeviceManufacturer;
        private BrightIdeasSoftware.OLVColumn olvDeviceModel;
        private BrightIdeasSoftware.OLVColumn olvDeviceOS;
        private BrightIdeasSoftware.OLVColumn olvArchitecture;
        private BrightIdeasSoftware.OLVColumn olvDeviceStatus;
        private BrightIdeasSoftware.OLVColumn olvIPAddresses;
        private System.Windows.Forms.ToolStripStatusLabel statADSync;
        private System.Windows.Forms.ToolStripStatusLabel lblstatCollectionMembersCount;
        private System.Windows.Forms.ToolStripMenuItem unavailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ImageList ilMemberStates;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}