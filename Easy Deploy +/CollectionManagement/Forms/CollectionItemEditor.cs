using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Easy_Deploy.CollectionManagement
{
    public partial class CollectionItemEditor : Form
    {
        private const int GOOD_NAME = 0;
        private const int NAME_EXISTS = 1;
        private const int INVALID_CHARACTERS = 2;
        private const int RESERVED_NAME = 3;
        private const int EMPTY_NAME = 4;
        private int ErrorCode = -1;

        private String NewItemDestination = "";
        private bool IsNewItemAFolder = false;
        private bool Rename = false;
 
        public CollectionItemEditor( String RootLocation, bool isFolder, bool Renaming )
        {
            InitializeComponent();
            NewItemDestination = RootLocation;
            IsNewItemAFolder = isFolder;
            Rename = Renaming;

            if (isFolder)
            {
                lblMessage.Text = lblMessage.Text.Replace("collection", "folder");
                pictureBox1.Image = Properties.Resources.folder;
            }

            if (Renaming)
            {
                Text = "Easy Deploy+ Rename Item";
                lblMessage.Text = "Enter a new name for your item.";
            }
        }

        public void ShowRenameColectionDialog( EasyDeployCollection Collection )
        {
            txtNewCollectionName.Text = Collection.Name;
            ShowNewCollectionDialog();
            Collection.Name = txtNewCollectionName.Text;
        }

        public EasyDeployCollection ShowNewCollectionDialog()
        {
            BeginDialog:

            DialogResult result = ShowDialog();

            if ( result == DialogResult.OK )
            {
                if (ErrorCode > GOOD_NAME)
                {
                    if (ErrorCode == INVALID_CHARACTERS)
                        lblError.Text = "Name contains invalid characters!";

                    else if (ErrorCode == NAME_EXISTS)
                        lblError.Text = "Name already exists!";

                    else if (ErrorCode == RESERVED_NAME)
                        lblError.Text = "Invalid name. Name is reserved!";

                    else if (ErrorCode == EMPTY_NAME)
                        lblError.Text = "Invalid name. Empty name.";

                    ErrorCode = -1;
                    lblError.Visible = true;
                    goto BeginDialog;
                }

                else
                {
                    if (Rename)
                        return null;

                    else 
                        return new EasyDeployCollection(txtNewCollectionName.Text, IsNewItemAFolder, NewItemDestination);
                }
            }

            return null;            
        }

        /// <summary>
        /// Checks to see if a collection contains an invalid character,
        /// a name that's already in use
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private int IsNewCollectionNameValid(String Name)
        {
            if (Name.Length == 0)
                return EMPTY_NAME;

            foreach (EasyDeployCollection C in CollectionResources.Manager.UserCollections.Where( p => p.NodePath == NewItemDestination) )
            {
                if (C.Name == Name)
                {
                    return NAME_EXISTS; ;
                }
            }

            if (Name.Contains("\\"))
                return INVALID_CHARACTERS;

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (Name.Contains(Convert.ToString(c)))
                    return INVALID_CHARACTERS;
            }

            if (Name == "Deployment" || Name == "Collections")
                return RESERVED_NAME;

            return GOOD_NAME;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ErrorCode = IsNewCollectionNameValid(txtNewCollectionName.Text);
        }

        private void txtNewCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, null);                
                e.Handled = true;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
