using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace PsTools_Easy_Deploy_Tool
{
    static public class ProcessManager
    {
        static Thread mainThread;
        static public List <ProcessStartInfo> processList = new List<ProcessStartInfo>();
        static private List<Process> instances = new List<Process>();
        static public List<String> deployNameList = new List<String>();
        static public List<String> outputList = new List<String>();   
        static private String incrementString = "";
        static private String incrementString2 = "";
        static public bool processing = false;
        static private int currentHostIndex = 0;

        static public void AddProcess(String command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("PsExec.exe", command.TrimEnd(new char[]{' '}) );
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.ErrorDialog = true;
            startInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            startInfo.StandardOutputEncoding = Encoding.UTF8;
            processList.Add(startInfo);
        }

        static public void StartProcessing()
        {
            MainFormAccess.mainForm.DisableStart();            
            processing = true;

            if (MainFormAccess.mainForm.PConsoleAccess().MSIDeployment)
            {
                MainFormAccess.mainForm.PConsoleAccess().msiLogPollingTimer.Enabled = true;
                MainFormAccess.mainForm.PConsoleAccess().AddLogEntry("Deployment", "MSI logging has been initiated.");
            }

            instances.Clear();
            AppConsole.WriteLine("Deployment Processing Started.");
            StartProcessWindow();
            mainThread = new Thread(new ThreadStart(ProcessThreadFunction));
            mainThread.Start();
        }

        static private void StartProcessWindow()
        {
            Form1.prepareWindow.initialize(processList.Count);
            Form1.prepareWindow.Show();
        }

        static private void IncrementBar()
        {
            Form1.prepareWindow.IncrementBar();
        }

        static private void SetDeployingToString()
        {
            Form1.prepareWindow.SetIncrementString(incrementString, incrementString2);
        }

        static void EndProcessWindow()
        {
            Form1.prepareWindow.SetIncrementString("Done!", "Done!");
            AppConsole.WriteLine("Processing Completed.");
            MainFormAccess.mainForm.PConsoleAccess().AddLogEntry("Deployment", "Deployment finished.");

            processing = false;
            MainFormAccess.mainForm.EnableStart();
            MainFormAccess.mainForm.reEnableExitOps();

            if (!MainFormAccess.mainForm.IsProcessConsoleVisible())
                ShowConsole();

            if (MainFormAccess.mainForm.PConsoleAccess().MSIDeployment)
            {
                MessageBox.Show("Easy Deploy has finished starting all processes for this MSI Deployment. " +
                                "MSI Logging will stop once all packages have finished running.", "Easy Deploy - MSI Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        static void ShowConsole()
        {
            MainFormAccess.mainForm.ShowProcessConsole();
        }

        static public void WriteRawData(String file)
        {
            try
            {
                FileStream fstream = new FileStream(file, FileMode.Create, FileAccess.Write);
                XmlSerializer serializer = new XmlSerializer(typeof(List<String>));
                XmlTextWriter xmlWriter = new XmlTextWriter(fstream, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                serializer.Serialize(xmlWriter, outputList);
                fstream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Output data could not be written to the data collection directory.\n\nDetails\n\n" + e.Message + "\n\n" + file, "Data Collection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static private void ProcessThreadFunction()
        {
            for (int i = 0; i < processList.Count; i++)
            {
                outputList.Add("");
                currentHostIndex = i;

                using (Process p = Process.Start(processList[i]))
                {
                    instances.Add(p);
                    AppConsole.WriteLine("Executing: PsExec.exe " + processList[i].Arguments);
                    incrementString = "Deploying to: " + deployNameList[i];
                    incrementString2 = "Next: " + ((i + 1) < deployNameList.Count ? deployNameList[i + 1] : "");
                    SetDeployingToString();
                    StreamReader reader = new StreamReader(p.StandardError.BaseStream);
                    outputList[i] = reader.ReadToEnd().Replace("\r\n", "\n");
                    reader.Close();
                    reader = new StreamReader(p.StandardOutput.BaseStream);
                    outputList[i] += reader.ReadToEnd().Replace("\r\n", "\n");
                    reader.Close();
                    MainFormAccess.mainForm.PConsoleAccess().AddProcessToList(deployNameList[i]);
                    IncrementBar();

                    // CODE TO ADD LOG ITEMS
                    MainFormAccess.mainForm.PConsoleAccess().AddLogEntry(deployNameList[i], outputList[i]);
                }
            }

            EndProcessWindow();
        }

        static public void KillAll()
        {
            if (processing)
            {
                AppConsole.WriteLine("Stopping all processing.");
                Process[] psexec = Process.GetProcesses();
                processing = false;
                mainThread.Abort();
                Process p;

                if (instances.Count > 0)
                {
                    p = instances[instances.Count - 1];

                    try
                    {
                        if (p != null)
                        {
                            p.Kill();
                        }
                    }
                    catch (Exception e)
                    {
                        AppConsole.WriteLine("Process " + p.Id.ToString() + " could not be aborted. " + e.Message.ToString());
                    }
                }

                AppConsole.WriteLine("Deployment was manually aborted by user.");
                MainFormAccess.mainForm.PConsoleAccess().AddLogEntry("Deployment", "Deployment was manually aborted by user.");
            }

            else
            {
                AppConsole.WriteLine("No deployment to stop.");
            }
        }

        static public void KillCurrentProcess()
        {
            string currentHost = "";

            if ( deployNameList.Count > 0 )
                currentHost = deployNameList[currentHostIndex];

            Process[] psexec = Process.GetProcessesByName("PsExec");

            if (psexec.Count() > 0)
            {
                try
                {
                    psexec[0].Kill();
                    psexec[0].Dispose();
                    AppConsole.WriteLine("Process was manually aborted by user.");

                    if ( currentHost != "" )
                        MainFormAccess.mainForm.PConsoleAccess().AddLogEntry(currentHost, "Process manually aborted by user.");
                }
                catch
                {
                    AppConsole.WriteLine("Process could not be aborted.");
                }
            }

            else
            {
                AppConsole.WriteLine("No process running.");
            }
        }
    }
}
