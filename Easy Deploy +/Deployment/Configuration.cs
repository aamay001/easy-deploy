using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Easy_Deploy.Deployment
{
    /// <summary>
    /// Deployment run priority used for PsExec Flag
    /// </summary>
    enum RunPriority
    {
        LOW = 0,
        BELOW_NORMAL = 1,
        NORMAL = 2,
        ABOVE_NORMAL = 3,
        HIGH = 4,
        REALTIME = 5
    }

    /// <summary>
    /// Deployment configuration container. Stores deployment settings for an
    /// instance of a Deployment.
    /// </summary>
    class Configuration
    {
        public String Executable
        {
            get { return executable; }
        }
        private String executable = "";

        public String CommandArguments
        {
            get { return commandArgs; }
        }
        private String commandArgs = "";

        public bool CopyExecutable
        {
            get { return copyExecutable; }
        }
        private bool copyExecutable = false;

        public bool OverwriteExisting
        {
            get { return overwriteExisting; }
        }
        private bool overwriteExisting = false;

        public bool DontWait
        {
            get { return dontWait; }
        }
        private bool dontWait = false;
        
        public bool UseWorkingDirectory
        {
            get { return useWorkingDir; }
        }
        private bool useWorkingDir = false;

        public String WorkingDirectory
        {
            get { return workingDir; }
        }
        private String workingDir = "";

        public bool UseInteractiveSession
        {
            get { return useIntSess; }
        }
        private bool useIntSess = false;
        
        public int SessionNumber
        {
            get { return sessionNum; }
        }
        private int sessionNum = 0;

        public byte ConnectionTimeout
        {
            get { return connectionTimeout; }
        }
        private byte connectionTimeout = 0;        

        public RunPriority Priority
        {
            get { return runpriority; }
        }
        private RunPriority runpriority = RunPriority.NORMAL;        

        public bool UseSystem
        {
            get { return useSystem; }
        }
        private bool useSystem = false;

        public bool UseCredentials
        {
            get { return useCredentials; }
        }
        private bool useCredentials = false;

        private Configuration()
        {
        }

        /// <summary>
        /// Deployment configuration data object.
        /// </summary>
        /// <param name="_Executable">File to be executed on the remote machine.</param>
        /// <param name="_CommandArgs">Command line arguments for the executable or a command to execute on the remote machine.</param>
        /// <param name="_Copy">Determines if the executable will be copied to the remote machine.</param>
        /// <param name="_Overwrite">If the executable is being copied, causes it to be overwritten on the remote machine if it already exists.</param>
        /// <param name="_DontWait">Determines if PsExec should wait for the exectuable to finish running</param>
        /// <param name="_UseWorkingDir">Use to specify a working directory for the executable on the remote machine.</param>
        /// <param name="_WorkingDir">The specified working directory.</param>
        /// <param name="_UseInteractive">Causes executable to be launched withing the context of a specific session.</param>
        /// <param name="_SessionNum">Session number to use for interactive execution.</param>
        /// <param name="_TimeOut">Time PsExec will wait for connection before giving up.</param>
        /// <param name="_Priority">Execution runtime priority on remote machine.</param>
        /// <param name="_System">Determines if PsExec will use the System account to launch the executable.</param>
        /// <param name="_Credentials">Determines if the PsExec will use specified credentials to launch the executable.</param>
        public Configuration( String _Executable, String _CommandArgs, bool _Copy, bool _Overwrite, 
                              bool _DontWait, bool _UseWorkingDir, String _WorkingDir, bool _UseInteractive, 
                              int _SessionNum, byte _TimeOut, RunPriority _Priority, bool _System, bool _Credentials )
        {
            executable = _Executable;
            commandArgs = _CommandArgs;
            copyExecutable = _Copy;
            overwriteExisting = _Overwrite;
            dontWait = _DontWait;
            useWorkingDir = _UseWorkingDir;
            workingDir = _WorkingDir;
            useIntSess = _UseInteractive;
            sessionNum = _SessionNum;
            connectionTimeout = _TimeOut;
            runpriority = _Priority;
            useSystem = _System;
            useCredentials = _Credentials;
        }
    }
}
