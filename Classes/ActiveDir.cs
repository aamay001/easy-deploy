using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using PsTools_Easy_Deploy_Tool;
using System.Net;
using System.Net.NetworkInformation;

public struct ActiveDirCacheFile
{
    public String DomainName;
    public List<String> Computers;
}

static public class ActiveDir
{
    static public List<String> Computers = new List<String>();
    static public List<String> CachedAD = new List<String>();
    static public List<List<String>> OUs = new List<List<String>>();
    static public bool cacheFound = false;
    static public bool adUpdating = false;
    static public bool adUpToDate = false;
    static public bool adNotAvailable = false;
    static public bool DCAvailable = false;
    static public DateTime LastUpdate;
    static private Thread UpdateThread = new Thread( new ThreadStart(BeginADDownload) );
    static public bool Abort = false;

    static private ActiveDirCacheFile LoadCacheFile()
    {
        ActiveDirCacheFile cache;
        FileStream file = new FileStream(Directory.GetCurrentDirectory() + "\\adcache.xml", FileMode.Open, FileAccess.Read);
        XmlSerializer serializer = new XmlSerializer(typeof(ActiveDirCacheFile));
        cache = (ActiveDirCacheFile)serializer.Deserialize(file);
        file.Close();

        return cache;
    }

    static private void WriteCacheFile()
    {
        ActiveDirCacheFile cache = new ActiveDirCacheFile();
        cache.DomainName = Environment.UserDomainName;
        cache.Computers = Computers;

        FileStream file = new FileStream(Directory.GetCurrentDirectory() + "\\adcache.xml", FileMode.Create, FileAccess.Write);
        XmlSerializer serializer = new XmlSerializer(typeof(ActiveDirCacheFile));
        serializer.Serialize(file, cache);
        file.Close();
    }

    static public void GetComputers()
    {
        LocalNetworkSettings.GetLocalIPAddress();

        if (Environment.UserDomainName.ToUpper() == Environment.MachineName)
        {
            adNotAvailable = true;
            return;
        }

        try
        {
            // get root of the directory data tree on a directory server
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://rootDSE");
            // get the hostname of the directory server of your root (I'm assuming that's what you want)
            string dnsHostname = dirEntry.Properties["dnsHostname"].Value.ToString();
            IPAddress[] ipAddresses = Dns.GetHostAddresses(dnsHostname);

            Ping pingSender = new Ping();
            
            for (int i = 0; i < ipAddresses.Count(); i++)
            {
                try
                {
                    PingReply reply = pingSender.Send(ipAddresses[i].ToString(), 1000);
                    if ( reply.Status == IPStatus.Success )
                    {
                        DCAvailable = true;
                        break;
                    }
                }

                catch {}
            }
        }

        catch { }

        cacheFound = false;
        CachedAD.Clear();

        if (File.Exists("adcache.xml"))
        {
            ActiveDirCacheFile cache = LoadCacheFile();

            if (Environment.UserDomainName == cache.DomainName)
            {
                cacheFound = true;
                LastUpdate = File.GetLastWriteTime("adcache.xml");

                foreach (String s in cache.Computers)
                {
                    CachedAD.Add(s);
                }
            }
        }

        if (cacheFound && Settings.AUTO_UPDATE_AD_ON_STARTUP)
        {
            Thread UpdateThread = new Thread(new ThreadStart(BeginADDownload));
            UpdateThread.Start();
        }

        else if (cacheFound && !Settings.AUTO_UPDATE_AD_ON_STARTUP)
        {
            AppConsole.WriteLine("Cached AD was loaded.");
        }

        else
        {
            if (adUpToDate)
                MessageBox.Show("Please wait!\n\nError: Cahced AD was not found.\n\nClick OK to continue. This process can take several minutes.", "Active Directory Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            BeginADDownload();
        }
    }

    static private void BeginADDownload()
    {
        if (DCAvailable)
        {
            AppConsole.WriteLine("Active Directory started updating.");
            adUpToDate = false;
            adUpdating = true;

            try
            {
                Computers.Clear();
                OUs.Clear();

                DirectoryEntry entry = new DirectoryEntry("LDAP://" + Environment.UserDomainName);
                DirectorySearcher mySearcher = new DirectorySearcher(entry);
                mySearcher.Asynchronous = true;
                mySearcher.Filter = ("(objectClass=computer)");
                mySearcher.SizeLimit = int.MaxValue;
                mySearcher.PageSize = int.MaxValue;
                SearchResultCollection FoundResults = mySearcher.FindAll();

                foreach (SearchResult resEnt in FoundResults)
                {
                    if (Abort)
                        return;

                    DirectoryEntry p = resEnt.GetDirectoryEntry();
                    String ComputerName = p.Name;

                    if (ComputerName.StartsWith("CN="))
                    {
                        ComputerName = ComputerName.Remove(0, 3);
                    }
                    
                    /*
                    OUs.Add(new List<string>());
                    OUs[OUs.Count - 1].Add(ComputerName);
                    while (true)
                    {
                        String pName = p.Parent.Name.Remove(0, 3);

                        OUs[OUs.Count - 1].Add(pName);

                        if (pName.ToUpper() == Environment.UserDomainName)
                            break;

                        p = p.Parent;
                    }
                    */

                    Computers.Add(ComputerName);                    
                }

                mySearcher.Dispose();
                entry.Dispose();

                Computers.Sort();

                WriteCacheFile();

                LastUpdate = DateTime.Now;
            }

            catch (Exception e)
            {
                MessageBox.Show("Active Directory update failed. " + e.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppConsole.WriteLine("Active Directory update failed.");

                if (cacheFound)
                {
                    Computers.Clear();

                    foreach (String c in CachedAD)
                    {
                        Computers.Add(c);
                    }
                }
            }

            adUpdating = false;
            adUpToDate = true;
            AppConsole.WriteLine("Active Directory finished updating.");
        }

        else
        {
            AppConsole.WriteLine("Domain controller could not be reached. Cached AD was loaded.");
        }
    }

    static public void StopUpdate()
    {
        Abort = true;

        try
        {
            UpdateThread.Abort();            
        }
        catch { }
    }
}

