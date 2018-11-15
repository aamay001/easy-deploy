using Easy_Deploy.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Easy_Deploy.CollectionManagement
{
    public partial class ADSearchStatUI : Form
    {            
        public ADSearchStatUI( )
        {
            InitializeComponent();
        }

        private void ADSearchProcessor_Shown(object sender, EventArgs e)
        {
            

        }

        private void SearchProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void ADSearchStatUI_Shown(object sender, EventArgs e)
        {
            
        }

        private void ADSearchStatUI_VisibleChanged(object sender, EventArgs e)
        {
            if (CollectionResources.ActiveDirectory.Status == ActiveDirectoryInterfaceStatus.Synchronizing &&
                CollectionResources.ActiveDirectory.CacheFound)
            {
                lblMessage.Text = "Searching... (using cache)";
            }

            else
            {
                lblMessage.Text = "Searching...";
            }
        }
    }
}
