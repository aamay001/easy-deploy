using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsTools_Easy_Deploy_Tool
{
    class AppConsole
    {
        // UI Black Box
        static RichTextBox display;
        static public Form1 parent;
        static String consoleCache;
        static List < String > que = new List<String>();
        static List <DateTime> queTime = new List<DateTime>();

        static public void  Init(RichTextBox d, Form1 p)
        {
            display = d;
            parent = p;

            for ( int i = 0; i < que.Count; i++ )
            {
                String message = queTime[i].ToShortDateString() + " " + queTime[i].ToLongTimeString() + "> " + que[i];
                consoleCache = (parent.credentials.Checked && parent.password.Text.Length > 0 ? message.Replace(parent.password.Text, "******") : message) + "\n\n" + consoleCache;
                WriteToDisplay();
            }

            que.Clear();
        }

        static public void WriteLine(String s)
        {
            if (parent != null)
            {
                s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "> " + s;
                consoleCache = (parent.credentials.Checked && parent.password.Text.Length > 0 ? s.Replace(parent.password.Text, "******") : s) + "\n\n" + consoleCache;
                WriteToDisplay();
            }

            else
            {
                que.Add(s);
                queTime.Add(DateTime.Now);
            }
        }

        static public void Clear()
        {
            consoleCache = "";
            WriteToDisplay();
        }

        private delegate void WriteToDisplayDel();
        static private void WriteToDisplay()
        {
            if (display.InvokeRequired)
            {
                WriteToDisplayDel a = new WriteToDisplayDel(WriteToDisplay);
                parent.Invoke(a);
            }

            else
            {
                if (display.InvokeRequired)
                    WriteToDisplay();

                else
                {
                    try
                    {
                        display.Text = consoleCache;
                        display.Select(display.Text.Length, 0);
                    }
                    catch
                    {
                        que.Add(consoleCache);
                    }
                }
            }
        }
    }
}
