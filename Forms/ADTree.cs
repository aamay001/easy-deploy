using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsTools_Easy_Deploy_Tool.Forms
{
    public partial class ADTree : Form
    {
        public ADTree()
        {
            InitializeComponent();
        }

        private void ADTree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(Environment.UserDomainName);

            for (int i = 0; i < ActiveDir.OUs.Count; i++)
            {
                for (int j = ActiveDir.OUs[i].Count - 1; j >= 0; j--)
                {
                    String Key = ActiveDir.OUs[i][j];

                    if (treeView1.Nodes.ContainsKey(Key))
                    {
                        continue;
                    }

                    else
                    {
                        treeView1.Nodes[0].Nodes.Add(Key, Key);
                    }
                }
            }
        }
    }
}
