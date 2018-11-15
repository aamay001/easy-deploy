using System;
using System.Collections.Generic;

namespace Easy_Deploy.Deployment
{
    enum DeploymentState
    {
        IDLE = 0,
        PREPARING = 1,
        RUNNING = 2,
        FINALIZING = 3,
        COMPLETE = 4,
        SCHEDULED = 5,
        ABORTED = 6,
        FAILED = 7
    }

    class StatusProvider
    {
        private Deployment.Instance Deployment;
        public DeploymentState State;
        public uint Runtime = 0;
        public uint SuccessCount = 0;
        public uint FailCount = 0;
        public uint TotalCount
        {
            get { return (uint)Deployment.Computers.Count; }
        }
        public String CurrentDevice = "";
        public decimal PercentComplete
        {
            get
            {
                return (((decimal)SuccessCount + (decimal)FailCount) / (decimal)TotalCount) * 100.0m;
            }
        }
        public String CurrentCommand = "";
        public String Name
        {
            get { return Deployment.Name; }
        }
        public Dictionary<String, String> OutputMessages = new Dictionary<String, String>();

        /// <summary>
        /// Deployment Instance status provider constructor.
        /// </summary>
        /// <param name="_Instance"></param>
        public StatusProvider(Deployment.Instance _Instance)
        {
            Deployment = _Instance;
            State = DeploymentState.IDLE;
            CurrentDevice = Deployment.Computers[0];
        }
    }
}
