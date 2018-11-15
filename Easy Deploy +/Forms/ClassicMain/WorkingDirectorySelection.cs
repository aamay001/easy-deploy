using System;
using System.Windows.Forms;
using System.IO;

namespace Easy_Deploy.Forms
{
    public partial class WorkingDirectorySelection : Form
    {
        private bool pathContainsInvalidChars = false;

        public WorkingDirectorySelection( String Current )
        {
            InitializeComponent();
            txtWorkingDirectory.Text = Current;
        }

        public String ShowSelectionDialog()
        {
            BeginDialog: 

            DialogResult result = ShowDialog();

            if ( result == DialogResult.Yes)
            {
                if (pathContainsInvalidChars)
                {
                    pathContainsInvalidChars = false;
                    lblInvalidChars.Visible = true;

                    goto BeginDialog;
                }

                else
                {
                    return txtWorkingDirectory.Text;
                }
            }

            return "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach( char c in Path.GetInvalidPathChars() )
            {
                if (txtWorkingDirectory.Text.Contains(Convert.ToString(c)))
                {
                    pathContainsInvalidChars = true;
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if ( result == DialogResult.OK )
            {
                txtWorkingDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
