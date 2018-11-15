using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace PsTools_Easy_Deploy_Tool
{
    public partial class SettingsManager : Form
    {
        private String UserSavePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\EasyDeploy\\";

        public SettingsManager()
        {
            InitializeComponent();
        }

        private void SettingsManager_Load(object sender, EventArgs e)
        {
            LocalUpdateDirDisplay.Text = Settings.LOCAL_UPDATE_DIR;
            AutoUpADOnStartCheckBox.Checked = Settings.AUTO_UPDATE_AD_ON_STARTUP;
            LogDirDisplay.Text = Settings.LOGGING_DIR;
            groupBox2.Select();

            if (!Directory.Exists(UserSavePath))
                Directory.CreateDirectory(UserSavePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = DirectoryBrowser.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                LocalUpdateDirDisplay.Text = DirectoryBrowser.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = DirectoryBrowser.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                LocalUpdateDirDisplay.Text = DirectoryBrowser.SelectedPath;
            }
        }

        private void ApplyButton_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}
