using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class WorkingDirSet : Form
    {
        Form1 parent;

        public WorkingDirSet(Form1 p, String current)
        {
            InitializeComponent();
            enteredPath.Text = current;
            enteredPath.SelectAll();
            parent = p;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (enteredPath.Text.Length >= 3)
            {
                if (enteredPath.Text[enteredPath.Text.Length - 1] == '\\')
                    enteredPath.Text = enteredPath.Text.Remove(enteredPath.Text.Length - 1 , 1);

                parent.workPath = enteredPath.Text;
                AppConsole.WriteLine("Working Directory Set: " + enteredPath.Text);
                Close();
            }

            else
            {
                MessageBox.Show("Working path cannot be empty! Please enter a working directory path.", "Enter Working Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void WorkingDirSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enteredPath.Text.Length < 3)
                parent.relWorkingPath.Checked = false;
        }

        private void enteredPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                okBtn_Click(sender, e);
            }

            else if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        private void WorkingDirSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        private void okBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }
    }
}
