using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Deploy.Utilities
{
    public class EasyIPAddress: IEquatable<EasyIPAddress> 
    {
        private IPAddress ip;

        public List<int> Octets
        {
            get { return octets; }
        }
        private List<int> octets = new List<int>(4); 

        public String Subnet
        {
            get { return subnetwork; }
        }
        private String subnetwork = "";

        public EasyIPAddress( IPAddress address )
        {
            ip = address;
            GetOctets();
        }

        public override String ToString()
        {
            return ip.ToString();
        }

        /// <summary>
        /// Check to see if the other networks first octet 
        /// matches this networks first octet.
        /// </summary>
        /// <param name="otherIP"></param>
        /// <returns></returns>
        public bool IsLocalTo( EasyIPAddress otherIP )
        {
            if ( octets[0] == otherIP.Octets[0] )
            {
                return true;
            }

            return false;
        }

        public override bool Equals( object obj)
        {
            if (obj == null)
                return false;

            EasyIPAddress other = obj as EasyIPAddress;

            if (other != null)
            {
                return Equals(other);
            }

            return false;
        }
        public bool Equals( EasyIPAddress other)
        {
            if (other == null)
                return false;            

            return ip.Equals(other.ip); ;
        }
        public override int GetHashCode()
        {
            return ip.GetHashCode();
        }

        /// <summary>
        /// Returns the network portiong of an IP address.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private void GetOctets()
        {
            String subnet = ip.ToString().Substring(0, ip.ToString().LastIndexOf('.') + 1);

            int i1 = -1;
            int i2 = -1;
            int i3 = -1;

            // Get the indecies for the '.' in the subnet to parse the value
            for (int i = 0; i < subnet.Length; i++)
            {
                if (i1 == -1)
                {
                    if (subnet[i] == '.')
                        i1 = i;
                }

                else if (i2 == -1)
                {
                    if (subnet[i] == '.')
                        i2 = i;
                }

                else if (i3 == -1)
                {
                    if (subnet[i] == '.')
                        i3 = i;
                }
            }

            octets.Add((int)Convert.ToDecimal(subnet.Substring(0, i1)));
            octets.Add((int)Convert.ToDecimal(subnet.Substring(i1 + 1, i2 - i1 - 1)));
            octets.Add((int)Convert.ToDecimal(subnet.Substring(i2 + 1, i3 - i2 - 1)));
            octets.Add((int)Convert.ToInt32(ip.ToString().Substring(ip.ToString().LastIndexOf('.') + 1)));
            subnetwork = String.Join(".", octets[0], octets[1], octets[3]);
        }
    }
    
    static public class LocalNetworkSettings
    {
        static public bool IsInitalized
        {
            get { return initialized; }
        }
        static private bool initialized = false;

        static public List<EasyIPAddress> DNSServers
        {
            get { return dnsServers; }
        }
        static private List<EasyIPAddress> dnsServers = new List<EasyIPAddress>();

        static public List<EasyIPAddress> IPAddresses
        {
            get { return ipAddresses; }
        }
        static private List<EasyIPAddress> ipAddresses = new List<EasyIPAddress>();

        /// <summary>
        /// Initializes the LocalNetworkSettings class. Collects network information.
        /// </summary>
        static public void Initialize()
        {
            try
            {
                GetLocalIPAddresses();
                GetDNSServersAddresses();
                initialized = true;
                Log.Information("Network information initialized.");
            }

            catch
            {
                Log.CriticalError("Network information could not be initialized.");
            }
        }

        /// <summary>
        /// Recollected network information if initialized has previously been called.
        /// </summary>
        static public void Refresh()
        {
            if ( initialized )
            {
                GetLocalIPAddresses();
                GetDNSServersAddresses();
                Log.Information("Network information updated.");
            }

            else
            {
                Log.Information("Network information must be initialized tp refresh.");
            }
        }

        /// <summary>
        /// Collect all of the local IP addresses for this machine.
        /// </summary>
        static private void GetLocalIPAddresses()
        {
            ipAddresses.Clear();

            try
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        ipAddresses.Add(new EasyIPAddress(ip));
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Unable to collect local IP addresses.", e);
                throw e;
            }
        }

        /// <summary>
        /// Collect all of the DNS Servers IP addresses listed on this
        /// machine.
        /// </summary>
        static private void GetDNSServersAddresses()
        {
            dnsServers.Clear();

            try
            {
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    IPAddressCollection servers = adapterProperties.DnsAddresses;
                    if (dnsServers.Count > 0)
                    {
                        foreach (IPAddress dns in servers)
                        {
                            EasyIPAddress newDns = new EasyIPAddress(dns);

                            if (!dnsServers.Contains(newDns) && !dns.IsIPv6SiteLocal)
                            {
                                dnsServers.Add(newDns);
                            }
                        }
                    }
                }
            }

            catch ( Exception e)
            {
                Log.Error("Unable to collect DNS server information.", e);
                throw e;
            }
        }

        /// <summary>
        /// Checks to see if an IP address is part of one of the same networks
        /// that the local machine is a memeber of.
        /// </summary>
        /// <param name="checkIP"></param>
        /// <returns></returns>
        static public bool IsIPLocal(EasyIPAddress checkIP )
        {
            foreach( EasyIPAddress ip in ipAddresses)
            {
                if (checkIP.IsLocalTo(ip))
                    return true;
            }
            return false;            
        }        
    }
}
