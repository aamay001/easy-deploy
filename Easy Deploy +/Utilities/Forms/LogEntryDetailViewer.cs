using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Deploy.Utilities.Forms
{
    public partial class LogEntryDetailViewer : Form
    {
        public LogEntryDetailViewer(LogEntry Entry)
        {
            InitializeComponent();

            lblMessage.Text = Entry.Message;
            lblTime.Text = Entry.Time.ToString();
            lblType.Text = Entry.Type.ToString();
            txtDetail.Text = Entry.Detail;
            txtDetail.Select(0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
