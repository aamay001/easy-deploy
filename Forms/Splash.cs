using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class Splash : Form
    {
        Thread adLoadThread;
        Form1 parent;

        public Splash(Form1 p)
        {
            InitializeComponent();
            parent = p;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            adLoadThread = new Thread(new ThreadStart(ActiveDir.GetComputers));
            adLoadThread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += .05;
                return;
            }

            if (adLoadThread != null)
            {
                if (adLoadThread.ThreadState == ThreadState.Running)
                {
                    return;
                }
            }

            timer1.Enabled = false;
            Close();
            parent.Show();
        }

        private void ShowAbout()
        {

        }
    }
}
