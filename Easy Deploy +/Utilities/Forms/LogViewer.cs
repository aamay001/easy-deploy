using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Easy_Deploy.Utilities
{
    public partial class LogViewer : Form
    {
        private int previousSize = 0;

        public LogViewer()
        {
            InitializeComponent();
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            olvLogDate.ImageGetter = new ImageGetterDelegate(MessageItemImageGetter);
            UpdateLogView();
            Log.Entries.CollectionChanged += Entries_CollectionChanged;            
        }


        /// <summary>
        /// Update the list when the log is updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Entries_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            try
            {
                UpdateLogView();
            }

            catch
            {

            }
        }

        /// <summary>
        /// Gets the image index for an added message to the messages view.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public object MessageItemImageGetter(object rowObject)
        {
            LogEntry M = (LogEntry)rowObject;
            return (int)M.Type;
        }  
      
        /// <summary>
        /// Update the controls in the form.
        /// </summary>
        private void UpdateLogView()
        {
            statCErrorVal.Text = Log.CriticalErrors.ToString();
            statInfoVal.Text = Log.Infos.ToString();
            statWarnVal.Text = Log.Warnings.ToString();
            statErrorVal.Text = Log.Errors.ToString();
            statSecuVal.Text = Log.Securitys.ToString();
            olvLogList.SetObjects(Log.Entries);
            previousSize = Log.Entries.Count;
        }

        private void LogViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
