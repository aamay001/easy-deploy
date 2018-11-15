using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Easy_Deploy.Utilities
{    
    /// <summary>
    /// Log entry type.
    /// </summary>
    public enum LogEntryType
    {
        INFO,
        WARNING,
        ERROR,
        CRITICAL_ERROR,
        SECURITY
    }

    /// <summary>
    /// Log Entry Container
    /// </summary>
    public class LogEntry
    {
        public DateTime Time;
        public LogEntryType Type;
        public String Message;
        public String Detail;
        
        /// <summary>
        /// Returns a formmated string of the LogEntry
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return Time.ToShortDateString() + " " + Time.ToShortTimeString() + " [" + Type.ToString() + "] : " + Message;
        }
    }

    /// <summary>
    /// Static global log for the server.
    /// </summary>
    public static class Log
    {
        const int MAX_LOG_FILE_SIZE = 16000000;
        public static bool OutputToConsole = false;

        public static int Infos { get { return inf; } }
        private static int inf = 0;

        public static int Warnings { get { return warn; } }
        private static int warn = 0;

        public static int Errors { get { return err; } }
        private static int err = 0;

        public static int CriticalErrors { get { return cerr; } }
        private static int cerr = 0;

        public static int Securitys { get { return sec; } }
        private static int sec = 0;
        
        /// <summary>
        /// Collection of logged messages.
        /// </summary>
        public static ObservableCollection<LogEntry> Entries { get { return entries; } }
        private static ObservableCollection<LogEntry> entries = new ObservableCollection<LogEntry>();

        public static LogViewer Viewer;

        /// <summary>
        /// Adds an Error message to the log.
        /// </summary>
        /// <param name="Message"></param>
        public static LogEntry Error(String Message)
        {
            LogEntry Entry = new LogEntry();
            Entry.Message = Message;
            Entry.Time = DateTime.Now;
            Entry.Type = LogEntryType.ERROR;
            Entry.Detail = null;
            entries.Add(Entry);
            err++;

            if (OutputToConsole)
                Console.WriteLine(Entry.ToString());

            return Entry;
        }

        /// <summary>
        /// Adds an Error to the log with a detail string.
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="Detail"></param>
        public static void Error( String Message, Exception Detail)
        {
            LogEntry Entry = Error(Message);
            Entry.Detail = GetFormattedDetail(Detail);
        }

        /// <summary>
        /// Adds a Warning message to the log.
        /// </summary>
        /// <param name="Message"></param>
        public static void Warning(String Message)
        {
            LogEntry Entry = new LogEntry();
            Entry.Message = Message;
            Entry.Time = DateTime.Now;
            Entry.Type = LogEntryType.WARNING;
            entries.Add(Entry);
            warn++;

            if (OutputToConsole)
                Console.WriteLine(Entry.ToString());
        }

        /// <summary>
        /// Adds an Information message to the log.
        /// </summary>
        /// <param name="Message"></param>
        public static void Information(String Message)
        {
            LogEntry Entry = new LogEntry();
            Entry.Message = Message;
            Entry.Time = DateTime.Now;
            Entry.Type = LogEntryType.INFO;
            entries.Add(Entry);
            inf++;

            if (OutputToConsole)
                Console.WriteLine(Entry.ToString());
        }

        /// <summary>
        /// Adds a Critical Error message to the log.
        /// </summary>
        /// <param name="Message"></param>
        public static LogEntry CriticalError(String Message)
        {
            LogEntry Entry = new LogEntry();
            Entry.Message = Message;
            Entry.Time = DateTime.Now;
            Entry.Type = LogEntryType.CRITICAL_ERROR;
            entries.Add(Entry);
            cerr++;

            if (OutputToConsole)
                Console.WriteLine(Entry.ToString());

            return Entry;
        }

        /// <summary>
        /// Adds an Error to the log with a detail string.
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="Detail"></param>
        public static void CriticalError(String Message, Exception Detail)
        {
            LogEntry Entry = CriticalError(Message);
            Entry.Detail = GetFormattedDetail(Detail);
        }

        /// <summary>
        /// Adds a security message to the log.
        /// </summary>
        /// <param name="Message"></param>
        public static void Security(String Message)
        {
            LogEntry Entry = new LogEntry();
            Entry.Message = Message;
            Entry.Time = DateTime.Now;
            Entry.Type = LogEntryType.SECURITY;
            entries.Add(Entry);
            sec++;

            if (OutputToConsole)
                Console.WriteLine(Entry.ToString());
        }

        /// <summary>
        /// Writes the full log to a file. Checks to see if the lof file exists.
        /// If the file exists and is < 16MB the current log is appended to the old 
        /// log. If the file is > 16 MB, the file is renamed and a new log is created.
        /// </summary>
        /// <param name="FileName">String containing the Logs file name.</param>
        public static void WriteLog(String FileName)
        {
            try
            {
                FileStream file;

                if (File.Exists(FileName))
                {
                    FileInfo fileProperties = new FileInfo(FileName);

                    if (fileProperties.Length > MAX_LOG_FILE_SIZE)
                    {
                        File.Copy(FileName, DateTime.Now.ToShortDateString().Replace("/", "") + "_" + FileName);
                        File.Delete(FileName);
                        file = new FileStream(FileName, FileMode.CreateNew, FileAccess.Write);                        
                    }
                    else
                    {
                        file = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                    }
                }

                else
                {
                    file = new FileStream(FileName, FileMode.CreateNew, FileAccess.Write);
                }

                StreamWriter Writer = new StreamWriter(file);

                for (int i = 0; i < entries.Count; i++)
                {
                    LogEntry Entry = entries[i];
                    Writer.WriteLine(Entry.ToString());
                }

                Writer.Close();
                file.Close();
            }

            catch ( Exception ex )
            {
                Console.WriteLine(DateTime.Now.ToLongDateString() + ": [ERROR] Log file could not be written. " + ex.Message);
            }
        }

        /// <summary>
        /// Writes the log to the same directory as the executable with name Log.txt
        /// </summary>
        public static void WriteLog()
        {
            WriteLog("Log.txt");
        }

        /// <summary>
        /// Show the log viewer form.
        /// </summary>
        public static void Show()
        {
            if (Viewer == null)
                Viewer = new LogViewer();

            Viewer.Show();
        }

        /// <summary>
        /// Returns the open status of the Log Viewer.
        /// </summary>
        /// <returns></returns>
        public static bool IsLogViewerOpen()
        {
            if (Viewer == null)
                return false;

            return Viewer.Visible;
        }

        private static String GetFormattedDetail(Exception e)
        {
            return "Data: " + e.Data + Environment.NewLine + Environment.NewLine +
                   "Help Link: " + e.HelpLink + Environment.NewLine + Environment.NewLine +
                   "Message: " + e.Message + Environment.NewLine + Environment.NewLine +
                   "Source: " + e.Source + Environment.NewLine + Environment.NewLine +
                   "Stack Trace: " + e.StackTrace + Environment.NewLine + Environment.NewLine +
                   "Target Site: " + e.TargetSite + Environment.NewLine + Environment.NewLine +
                   "Exeception String: " + e.ToString();
        }
    }
}
