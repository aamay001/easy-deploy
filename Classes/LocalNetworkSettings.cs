using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using PsTools_Easy_Deploy_Tool;

static public class LocalNetworkSettings
{
    public static List<String> AvailableDNSServers;
    public static bool DnsOK = false;
    public static Decimal subnetParseOctet1 = 0;
    public static Decimal subnetParseOctet2 = 0;
    public static Decimal subnetParseOctet3 = 0;
    public static List<String> AvailableSubnets = new List<String>();
    public static string IPAddress = "";

    public static void CheckForLocalDNSServers()
    {
        AvailableDNSServers = new List<String>();

        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface adapter in adapters)
        {
            IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
            IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
            if (dnsServers.Count > 0)
            {                
                foreach (IPAddress dns in dnsServers)
                {
                    if (!AvailableDNSServers.Contains(dns.ToString()) && !dns.IsIPv6SiteLocal)
                    {
                        AvailableDNSServers.Add(dns.ToString());
                    }
                }
            }
        }
    }

    public static void GetLocalSubnets()
    {
        String subnet = "";
        AvailableSubnets.Clear();

        try
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    if (IPAddress == "")
                        IPAddress = ip.ToString();

                    subnet = ip.ToString().Substring(0, ip.ToString().LastIndexOf('.') + 1);

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

                    subnetParseOctet1 = Convert.ToDecimal(subnet.Substring(0, i1));
                    subnetParseOctet2 = Convert.ToDecimal(subnet.Substring(i1 + 1, i2 - i1 - 1));
                    subnetParseOctet3 = Convert.ToDecimal(subnet.Substring(i2 + 1, i3 - i2 - 1));

                    AvailableSubnets.Add(subnetParseOctet1.ToString() + "." +
                                                                subnetParseOctet2.ToString() + "." +
                                                                subnetParseOctet3.ToString() + ".");                    
                }
            }
        }
        catch
        {

        }
    }

    public static void GetLocalIPAddress()
    {
        try
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    IPAddress = ip.ToString();
                    return;
                }
            }
        }

        catch
        {
            IPAddress = "";
        }
    }
}
