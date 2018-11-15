using System;
using System.Windows.Forms;
using Easy_Deploy.Utilities;
using System.Threading;
using BrightIdeasSoftware;

namespace Easy_Deploy.CollectionManagement
{
    partial class Console : Form
    {
        ADSearchStatUI SearchStat;

        #region Form Functions
        public Console()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precent form from completely closing. When the form is closing, cancel
        /// the close request and hide the form instead.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectionManagerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void CollectionManagerUI_Load(object sender, EventArgs e)
        {
            olvDeviceName.ImageGetter = new ImageGetterDelegate(CollectionMemberImageGetter);
            LoadCollections();            
            CollectionResources.Manager.UserCollections.CollectionChanged += UserCollections_CollectionChanged;
            CollectionResources.ActiveDirectory.StatusChanged += ActiveDirectoryInterface_StatusChanged;
            ActiveDirectoryInterface_StatusChanged(null, null);
            CollectionResources.ActiveDirectory.SearchComplete += ActiveDirectoryInterface_SearchComplete;
            ThreadPool.QueueUserWorkItem(InitSearchStatUI);
        }    
        
        public object CollectionMemberImageGetter(object rowObject)
        {
            EasyDeployCollectionMember M = (EasyDeployCollectionMember)rowObject;
            return (int)M.PingState;
        }  

        #endregion

        #region Collection Tree Veiw Selection Management

        private void UserCollections_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            tVCollections.BeginUpdate();

            if (e.NewItems != null)
            {
                foreach (EasyDeployCollection C in e.NewItems)
                {
                    tVCollections.SelectedNode.Nodes.Add(C.FullName, C.Name, C.IsCollectionFolder ? 3 : 2, C.IsCollectionFolder ? 3 : 2).Parent.ExpandAll();
                }
            }

            tVCollections.EndUpdate();
            CollectionResources.Manager.SaveCollectionData();
        }        

        /// <summary>
        /// Load stored collection data from application settings.
        /// </summary>
        private void LoadCollections()
        {
            try
            {
                CollectionResources.Manager.LoadCollectionData();

                if (Properties.Settings.Default.ComputerCollections != "")
                {                    
                    tVCollections.BeginUpdate();
                    foreach (EasyDeployCollection C in CollectionResources.Manager.UserCollections)
                    {
                        try
                        {
                            tVCollections.Nodes.Find(C.NodePath, true)[0].Nodes.Add(C.FullName, C.Name, C.IsCollectionFolder ? 3 : 2, C.IsCollectionFolder ? 3 : 2).Parent.ExpandAll();
                        }

                        catch ( Exception ex)
                        {
                            Log.Error("Collection tree load error.", ex);
                        }
                    }

                    tVCollections.ExpandAll();
                    tVCollections.EndUpdate();
                }
            }
            catch 
            {
                MessageBox.Show("An error occured while loading collection data. See log for more information.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change menu strip options based on wat the user has selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tVCollections_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == tVCollections.Nodes[1]) // Root Node
            {
                RootNodeSelectionSetControls();
                SetActiveCollection("");
            }

            else if (e.Node == tVCollections.Nodes[0]) // Deployment Collection
            {
                DeploymentCollectionSelectionSetControls();
                SetActiveCollection("Deployment");
            }

            else
            {
                UserCollectionSelected();
                SetActiveCollection(e.Node.FullPath);
            }
        }

        private void SetActiveCollection(String FullName)
        {
            if (FullName == "")
                CollectionResources.Manager.ActiveCollection = null;

            CollectionResources.Manager.ActiveCollection = CollectionResources.Manager.GetCollection(FullName);
            UpdateCollectionViewer();
        }

        /// <summary>
        /// Resets the object list view with the updated members in the active collection.
        /// </summary>
        private void UpdateCollectionViewer()
        {
            if (CollectionResources.Manager.ActiveCollection != null)
            {
                olvCollectionViewer.SetObjects(CollectionResources.Manager.ActiveCollection.Members);
                lblstatCollectionMembersCount.Text = "Collection Members: " + CollectionResources.Manager.ActiveCollection.Members.Count;
            }
        }

        /// <summary>
        /// When the deployment collection is selected from the tree view,
        /// change what options are available in the Collections menu in the 
        /// menu strip.
        /// </summary>
        private void DeploymentCollectionSelectionSetControls()
        {
            SearchGroup.Enabled = true;
            deleteToolStripMenuItem.Enabled = false;
            deleteItemtoolStripButton.Enabled = false;
            deleteItemContectMenuItem.Enabled = false;
            renameToolStripMenuItem.Enabled = false;
            renameItemContectMenuItem.Enabled = false;
            createFolderToolStripMenuItem.Enabled = false;
            createFolderToolStripButton.Enabled = false;
            newFolderContectMenuItem.Enabled = false;
            addToolStripMenuItem.Enabled = false;
            newCollecitonContextMenuItem.Enabled = false;
            newCollectionToolStripButton.Enabled = false;
            useForDeploymentToolStripMenuItem.Enabled = false;
            SetFormAvailableOptions();            
        }

        /// <summary>
        /// Checks to see what componenets are available and enables
        /// the use of those features.
        /// </summary>
        private void SetFormAvailableOptions()
        {
            if (CollectionResources.ActiveDirectory.Status == ActiveDirectoryInterfaceStatus.Unavailable)
                SetADOptionsEnabled(false);

            else
                SetADOptionsEnabled(true);
        }

        /// <summary>
        /// Sets the enable state of Active Directory options
        /// in the form.
        /// </summary>
        /// <param name="state"></param>
        private void SetADOptionsEnabled(bool state)
        {
            ADSearchGroup.Enabled = state;
            chkCheckManualPCInAD.Enabled = state;
            activeDirectoryToolStripMenuItem.Enabled = state;
        }

        /// <summary>
        /// When the root node is selected from the tree view,
        /// change what options are available in the Collections menu in the 
        /// menu strip.
        /// </summary>
        private void RootNodeSelectionSetControls()
        {
            SearchGroup.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            deleteItemtoolStripButton.Enabled = false;
            deleteItemContectMenuItem.Enabled = false;
            renameToolStripMenuItem.Enabled = false;
            renameItemContectMenuItem.Enabled = false;
            createFolderToolStripMenuItem.Enabled = true;
            newFolderContectMenuItem.Enabled = true;
            createFolderToolStripButton.Enabled = true;
            addToolStripMenuItem.Enabled = true;
            newCollectionToolStripButton.Enabled = true;
            newCollecitonContextMenuItem.Enabled = true;
            useForDeploymentToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// When an item in the  user collection space is selected from the tree view,
        /// change what options are available in the Collections menu in the 
        /// menu strip.
        /// </summary>
        private void UserCollectionSelected()
        {            
            deleteToolStripMenuItem.Enabled = true;
            deleteItemtoolStripButton.Enabled = true;
            deleteItemContectMenuItem.Enabled = true;
            renameToolStripMenuItem.Enabled = true;
            renameItemContectMenuItem.Enabled = true;

            if (tVCollections.SelectedNode.SelectedImageIndex == 3) // Folder Selected
            {
                createFolderToolStripMenuItem.Enabled = true;
                createFolderToolStripButton.Enabled = true;
                newFolderContectMenuItem.Enabled = true;
                addToolStripMenuItem.Enabled = true;
                newCollecitonContextMenuItem.Enabled = true;
                newCollectionToolStripButton.Enabled = true;
                SearchGroup.Enabled = false;
                useForDeploymentToolStripMenuItem.Enabled = false;
            }

            else
            {
                createFolderToolStripMenuItem.Enabled = false;
                newFolderContectMenuItem.Enabled = false;
                createFolderToolStripButton.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                newCollecitonContextMenuItem.Enabled = false;
                newCollectionToolStripButton.Enabled = false;
                SearchGroup.Enabled = true;
                useForDeploymentToolStripMenuItem.Enabled = true;
                SetFormAvailableOptions();
            }
        }

        #endregion

        #region Menu Item Event Functions
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewCollection();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }        

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewFolder();
        }

        #endregion

        #region Core Modification Functions

        /// <summary>
        /// Adds a collection folder to the collection manager.
        /// </summary>
        private void CreateNewFolder()
        {
            CollectionItemEditor NCUI = new CollectionItemEditor(tVCollections.SelectedNode.FullPath, true, false);
            EasyDeployCollection newCollection = NCUI.ShowNewCollectionDialog();

            if (newCollection != null)
                CollectionResources.Manager.UserCollections.Add(newCollection);
        }

        /// <summary>
        /// Displayes dialog for renaming an item in the colleciont manager. Renames an item 
        /// from the result of the dialog and update any subnodes that need to be updated.
        /// </summary>
        private void RenameItem()
        {
            EasyDeployCollection item = CollectionResources.Manager.GetCollection(tVCollections.SelectedNode.FullPath);
            String oldFullName = item.FullName;
            CollectionItemEditor NCUI = new CollectionItemEditor(item.FullName, item.IsCollectionFolder, true);
            NCUI.ShowRenameColectionDialog(item);
            tVCollections.BeginUpdate();
            tVCollections.SelectedNode.Text = item.Name;
            tVCollections.SelectedNode.Name = item.FullName;

            if ( item.IsCollectionFolder )
            {
                for (int j = 0; j < CollectionResources.Manager.UserCollections.Count; j++)
                {
                    EasyDeployCollection EC = CollectionResources.Manager.UserCollections[j];

                    if (EC.FullName.StartsWith(oldFullName) )
                    {
                        String currentNodePath = EC.NodePath;
                        String currentNodeFullName = EC.FullName;
                        EC.NodePath = currentNodePath.Replace(oldFullName, item.FullName);
                        tVCollections.Nodes.Find(currentNodeFullName, true)[0].Name = EC.FullName;                     
                    }
                }
            }

            tVCollections.EndUpdate();
            CollectionResources.Manager.SaveCollectionData();
        }

        /// <summary>
        /// Displayes the dialog for adding a new collection to the collection manager. Adds a new collection
        /// from the result of the dialog.
        /// </summary>
        private void CreateNewCollection()
        {
            CollectionItemEditor NCUI = new CollectionItemEditor(tVCollections.SelectedNode.FullPath, false, false);
            EasyDeployCollection newCollection = NCUI.ShowNewCollectionDialog();

            if (newCollection != null)
                CollectionResources.Manager.UserCollections.Add(newCollection);
        }

        /// <summary>
        /// Displays a dialog to confirm an item removal. Removes the item based on the result and
        /// updates the collection manager.
        /// </summary>
        private void DeleteItem()
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to delete " + tVCollections.SelectedNode.Text + "?" + (tVCollections.SelectedNode.ImageIndex == 3 ? " All child collections and folders will also be deleted!" : ""),
                                                   "Easy Deploy+ Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tVCollections.BeginUpdate();

                for (int i = 0; i < CollectionResources.Manager.UserCollections.Count; i++)
                {
                    EasyDeployCollection C = CollectionResources.Manager.UserCollections[i];

                    if (tVCollections.SelectedNode.Name == C.FullName)
                    {
                        if (C.IsCollectionFolder)
                        {
                            for (int j = 0; j < CollectionResources.Manager.UserCollections.Count; j++)
                            {
                                EasyDeployCollection EC = CollectionResources.Manager.UserCollections[j];

                                if (EC.FullName.StartsWith(C.FullName) && EC != C)
                                {
                                    CollectionResources.Manager.UserCollections.Remove(EC);
                                    j--;
                                }
                            }
                        }

                        tVCollections.Nodes.Remove(tVCollections.SelectedNode);
                        CollectionResources.Manager.UserCollections.Remove(C);
                        break; 
                    }
                }

                tVCollections.EndUpdate();
            }
        }

        #endregion

        #region Collection Working Functions

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (olvCollectionViewer.SelectedObjects != null)
            {
                if (olvCollectionViewer.SelectedObjects.Count > 0)
                {
                    foreach (object member in olvCollectionViewer.SelectedObjects)
                    {
                        CollectionResources.Manager.ActiveCollection.Members.Remove((EasyDeployCollectionMember)member);
                    }

                    UpdateCollectionViewer();
                }
            }
        }

        private void unavailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CollectionResources.Manager.ActiveCollection != null)
            {
                foreach (EasyDeployCollectionMember member in CollectionResources.Manager.ActiveCollection.Members)
                {
                    if (member.PingState == PingStatus.Unavailable)
                    {
                        CollectionResources.Manager.ActiveCollection.Members.Remove(member);
                    }
                }

                UpdateCollectionViewer();
            }
        }

        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CollectionResources.Manager.ActiveCollection != null)
            {
                foreach (EasyDeployCollectionMember member in CollectionResources.Manager.ActiveCollection.Members)
                {
                    if (member.PingState == PingStatus.Available)
                    {
                        CollectionResources.Manager.ActiveCollection.Members.Remove(member);
                    }
                }

                UpdateCollectionViewer();
            }
        }

        private void errorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CollectionResources.Manager.ActiveCollection != null)
            {
                foreach (EasyDeployCollectionMember member in CollectionResources.Manager.ActiveCollection.Members)
                {
                    if (member.PingState == PingStatus.Error)
                    {
                        CollectionResources.Manager.ActiveCollection.Members.Remove(member);
                    }
                }

                UpdateCollectionViewer();
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CollectionResources.Manager.ActiveCollection != null)
            {
                CollectionResources.Manager.ActiveCollection.Members.Clear();
                UpdateCollectionViewer();
            }
        }

        #endregion

        #region Tool Strip Item Funtions

        private void newCollectionToolStripButton_Click(object sender, EventArgs e)
        {
            CreateNewCollection();
        }

        private void createFolderToolStripButton_Click(object sender, EventArgs e)
        {
            CreateNewFolder();
        }

        private void deleteItemtoolStripButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
        #endregion

        #region Context Menu and Context Menu Item Event Functions

        private void ShowCollectionItemContextMenu()
        {
            if (tVCollections.SelectedNode != null && tVCollections.SelectedNode.Name != "Deployment" )
            {
                if (tVCollections.SelectedNode.Name != "Collections")
                {
                    EasyDeployCollection selectedItem = CollectionResources.Manager.GetCollection(tVCollections.SelectedNode.Name);
                    contextMenuTitleItem.Text = selectedItem.Name;
                    contextMenuTitleItem.ToolTipText = selectedItem.IsCollectionFolder ? "Folder Item" : "Collection Item";
                    contextMenuTitleItem.Image = (selectedItem.IsCollectionFolder ? ilCollections.Images[3] : ilCollections.Images[2]);
                }

                else
                {
                    contextMenuTitleItem.Text = "Collections";
                    contextMenuTitleItem.ToolTipText = "Collections Root";
                    contextMenuTitleItem.Image = Properties.Resources.collectionRoot;
                }
                contextMenuStrip.Show(MousePosition);
            }
        }

        private void tVCollections_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowCollectionItemContextMenu();
            }
        }

        private void newCollecitonContextMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewCollection();
        }

        private void newFolderContectMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewFolder();
        }

        private void deleteItemContectMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void renameItemContectMenuItem_Click(object sender, EventArgs e)
        {
            RenameItem();
        }
        
        #endregion

        #region Active Directory Search

        private void btnSearchAD_Click(object sender, EventArgs e)
        {            
            ProcessSearch();
        }

        private void ProcessSearch()
        {
            if ( ( CollectionResources.ActiveDirectory.Status == ActiveDirectoryInterfaceStatus.Synchronizing || 
                   CollectionResources.ActiveDirectory.Status == ActiveDirectoryInterfaceStatus.Initializing ) &&
                 !CollectionResources.ActiveDirectory.CacheFound)
            {
                MessageBox.Show("Active Directory Search is currently unavailable. Initial cache is being created.",
                                 Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else

            {
                SearchStat.Show();
                CollectionResources.ActiveDirectory.SearchFor(txtADSearchKey.Text);
            }
        }

        private void ActiveDirectoryInterface_SearchComplete(object sender, EventArgs e)
        {
            UpdateCollectionViewer();
            HideSearchStatForm();
        }

        private void chkADSearchStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            CollectionResources.ActiveDirectory.Search.Options.UseKeyAsPrefix = chkADSearchStartsWith.Checked;
        }

        private void chkADSearchContains_CheckedChanged(object sender, EventArgs e)
        {
            CollectionResources.ActiveDirectory.Search.Options.KeyContained = chkADSearchContains.Checked;
        }

        private void chkADSearchCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            CollectionResources.ActiveDirectory.Search.Options.CaseSensitive = chkADSearchCaseSensitive.Checked;
        }

        private void InitSearchStatUI(object state)
        {
            SearchStat = new ADSearchStatUI();
        }

        private void txtADSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                ProcessSearch();

        }

        private void ActiveDirectoryInterface_StatusChanged(object sender, EventArgs e)
        {
            SetADSyncImage(CollectionResources.ActiveDirectory.Status);
        }

        private delegate void HideSearchStatFormDel();
        private void HideSearchStatForm()
        {
            if (InvokeRequired)
            {
                HideSearchStatFormDel a = new HideSearchStatFormDel(HideSearchStatForm);
                Invoke(a);
            }

            else
            {
                SearchStat.Hide();
            }
        }


        private delegate void SetADSyncImageDel(ActiveDirectoryInterfaceStatus S);
        private void SetADSyncImage(ActiveDirectoryInterfaceStatus Status)
        {
            if (InvokeRequired)
            {
                SetADSyncImageDel a = new SetADSyncImageDel(SetADSyncImage);
                object[] args = new object[] { Status };
                Invoke(a, args);
            }

            else
            {
                if (Status == ActiveDirectoryInterfaceStatus.Synchronizing)
                {
                    statADSync.Image = Properties.Resources.loadanim;
                }

                else if (Status == ActiveDirectoryInterfaceStatus.Synchronized)
                {
                    statADSync.Image = Properties.Resources.statOK;
                }

                else if ( Status == ActiveDirectoryInterfaceStatus.Unavailable)
                {
                    statADSync.Image = Properties.Resources.statNo;
                }
                else
                {
                    statADSync.Image = null;
                }

                statADSync.Text = "Active Directory: " + Status.ToString();
            }
        }
        #endregion

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveDirectoryInterfaceStatus stat = CollectionResources.ActiveDirectory.Status;

            if ( stat == ActiveDirectoryInterfaceStatus.Synchronizing || 
                 stat == ActiveDirectoryInterfaceStatus.Initializing)
            {
                MessageBox.Show("Active Directory is " + stat.ToString().ToLower() + ". Try again after current process completes.",
                                 Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                CollectionResources.ActiveDirectory.Synchronize();
            }
        }

        private void deleteCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the Active Directory cache?",
                                                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    CollectionResources.ActiveDirectory.DeleteCacheFile();
                    Log.Information("Active Directory cache deleted.");
                    MessageBox.Show("Active Directory cache deleted.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                }

                catch( Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void activeDirectoryToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if ( CollectionResources.ActiveDirectory.CacheFileExists() )
            {
                deleteCacheToolStripMenuItem.Enabled = true;
            }

            else
            {
                deleteCacheToolStripMenuItem.Enabled = false;
            }
        }
    }
}
