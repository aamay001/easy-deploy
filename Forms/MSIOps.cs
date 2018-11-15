using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WindowsInstaller;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class MSIOps : Form
    {
        public MSIOps(String msiP)
        {
            InitializeComponent();

            logDirectory.Text = Settings.LOGGING_DIR + "\\MSI\\";
            installer.Text = msiP;

            Type t = Type.GetTypeFromProgID("WindowsInstaller.Installer");
            Installer inst = (Installer)Activator.CreateInstance(t);
            Database d = inst.OpenDatabase( msiP, MsiOpenDatabaseMode.msiOpenDatabaseModeReadOnly);
            WindowsInstaller.View v = d.OpenView( "SELECT * FROM Property WHERE Property = 'ProductName'");
            v.Execute(null);
            Record r = v.Fetch();
            MSIProductName.Text = r.get_StringData(2);

            v = d.OpenView("SELECT * FROM Property WHERE Property = 'ProductVersion'");
            v.Execute(null);
            r = v.Fetch();
            MSIPVersion.Text = r.get_StringData(2);
        }

        private void statusLogging_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void useComputerName_CheckedChanged(object sender, EventArgs e)
        {
            logName.Text = "%computername%.txt";
            logName.Enabled = !useComputerName.Checked;
        }

        public String GetCommandString()
        {
            return (uninstall.Checked ? "/x \"" : reInstall.Checked ? "/faumsv \"" : "/i \"") + installer.Text + "\" " +

                   (silentInstall.Checked ? "/qn " : "") +

                   (allUsers.Checked ? "ALLUSERS=\"1\" " : "") +

                   (noRestart.Checked ? "REBOOT=\"R\" " : "") + 

                   (forceRestart.Checked ? "REBOOT=\"F\" " : "" ) +

                   (statusLogging.Checked ? "/Li \"" + logDirectory.Text + logName.Text + "\"" : "");
        }

        private void reInstall_CheckedChanged(object sender, EventArgs e)
        {
            uninstall.Enabled = !reInstall.Checked;

            if (reInstall.Checked)
                uninstall.Checked = !reInstall.Checked;
        }

        private void uninstall_CheckedChanged(object sender, EventArgs e)
        {
            reInstall.Enabled = !uninstall.Checked;

            if ( uninstall.Checked )
                reInstall.Checked = !uninstall.Checked;
        }

        private void noRestart_CheckedChanged(object sender, EventArgs e)
        {
            forceRestart.Enabled = !noRestart.Checked;

            if ( forceRestart.Checked )
                forceRestart.Checked = !noRestart.Checked;
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (statusLogging.Checked)
            {
                MainFormAccess.mainForm.PConsoleAccess().MSILoggingDir = logDirectory.Text;
                MainFormAccess.mainForm.PConsoleAccess().MSIDeployment = true;
                MainFormAccess.mainForm.PConsoleAccess().MSIProductName = MSIProductName.Text;
            }            
            
            Close();
        }

        private void forceRestart_CheckedChanged(object sender, EventArgs e)
        {
            noRestart.Enabled = !forceRestart.Checked;

            if (noRestart.Checked)
                noRestart.Checked = !forceRestart.Checked;
        }

        private void logDirectory_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
