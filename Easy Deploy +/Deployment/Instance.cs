using System;
using System.Collections.Generic;

namespace Easy_Deploy.Deployment
{
    class Instance
    {
        public Deployment.Configuration Settings
        {
            get { return configuration; }
        }
        private Deployment.Configuration configuration;

        public Deployment.StatusProvider Status
        {
            get { return status; }
        }
        private Deployment.StatusProvider status;

        public List<String> Computers
        {
            get { return computers; }
        }
        private List<String> computers = new List<String>();

        public String Name
        {
            get { return name; }
        }
        private String name = "";

        /// <summary>
        /// Provide the status handle. Use to make status changes.
        /// </summary>
        /// <returns></returns>
        public Deployment.StatusProvider GetStatusHandle()
        {
            return status;
        }

        /// <summary>
        /// Deployment Instance constructor.
        /// </summary>
        /// <param name="_Name">Deployment name used for user identification.</param>
        /// <param name="_Settings">Deployment settings configuration.</param>
        /// <param name="_Computers">List of computers to deploy to.</param>
        public Instance(String _Name, Deployment.Configuration _Settings, List<String> _Computers)
        {
            name = _Name;
            configuration = _Settings;
            computers = _Computers;
            status = new Deployment.StatusProvider(this);
        }
    }
}
