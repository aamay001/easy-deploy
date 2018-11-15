using System;
using System.Windows.Forms;
using Easy_Deploy.Utilities;
using Easy_Deploy.Forms;

namespace Easy_Deploy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Log.Information("Easy Deploy+ application started.");                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Classic());
            }

            catch( Exception e )
            {
                Log.Information("Exception caught | Program.cs Line 29.");
                Log.Error(e.Message);
            }

            Log.Information("Easy Deploy+ application ended.");
            Log.WriteLog();
        }
    }
}
