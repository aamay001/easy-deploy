using System;
using System.Collections.Generic;
using System.Net;

namespace Easy_Deploy.CollectionManagement
{
    public enum PingStatus
    {
        Available = 0,
        Unavailable = 1,
        Error = 2,
        Unknown = 3,
        Refreshing = 4
    }

    /// <summary>
    /// Extended Collection Member used in the Collection Manager
    /// when user requests informatoin gathering of collection members.
    /// </summary>
    public class EasyDeployCollectionMember
    {
        public String Name = "";
        public String Manufacturer = "";
        public String Model = "";
        public PingStatus PingState = PingStatus.Unknown;
        public String OperatingSystem = "";
        public String Architecture = "";
        public List<String> IPAddress = new List<String>();

        public EasyDeployCollectionMember()
        {
        }

        public EasyDeployCollectionMember(String _Name)
        {
            Name = _Name;
        }

        public EasyDeployCollectionMember( String _Name, String _Man, String _Model, PingStatus _Ping, String _OS, String _Arch, List<String> _IP)
        {
            Manufacturer = _Man;
            Model = _Model;
            PingState = _Ping;
            OperatingSystem = _OS;
            Architecture = _Arch;
            IPAddress = _IP;
        }
    }    
}
