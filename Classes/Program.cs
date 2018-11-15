using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PsTools_Easy_Deploy_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!File.Exists("PsExec.exe"))
            {
                MessageBox.Show("PsExec.Exe is missing. The application cannot continue.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
                Application.Run(new Form1());                
#else
                try
                {
                    Application.Run(new Form1());
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace + "\n" + e.Data, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#endif
            }
        }
    }
}
