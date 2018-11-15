using Easy_Deploy.Properties;
using Easy_Deploy.Utilities;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Easy_Deploy.CollectionManagement
{
    /// <summary>
    /// Simple struct container for storing an AD cache.
    /// </summary>
    public struct ActiveDirectoryCache
    {
        public String DomainName;
        public List<EasyDeployCollectionMember> Computers;
    }

    public enum ActiveDirectoryInterfaceStatus
    {
        Unknown = -1,
        Unavailable = 0,
        Available = 2,
        Synchronizing = 3,
        Synchronized = 4,
        Initializing = 5
    }

    class ActiveDirectoryInterface
    {
        static private String CACHE_DATA_LOCATION = Environment.GetEnvironmentVariable("temp") + "\\EasyDeploy+\\";
        static private String CACHE_FILE_NAME = "adcache.xml";

        public List<EasyDeployCollectionMember> Computers
        {
            get { return computers; }
        }
        private List<EasyDeployCollectionMember> computers = new List<EasyDeployCollectionMember>();

        public ActiveDirectoryCache Cache
        {
            get { return cache; }
        }
        private ActiveDirectoryCache cache = new ActiveDirectoryCache();

        public bool CacheFound
        {
            get { return cacheFound; }
        }
        private bool cacheFound = false;
        private bool initialCacheBuilding = false;

        public String CurrentDomain
        {
            get { return domain; }
        }
        private String domain;

        public ActiveDirectoryInterfaceStatus Status
        {
            get { return status; }
        }
        private ActiveDirectoryInterfaceStatus status = ActiveDirectoryInterfaceStatus.Unknown;

        public DateTime LastUpdateTime
        {
            get { return lastUpdateTime; }
        }
        private DateTime lastUpdateTime = DateTime.MinValue;

        private bool initialized = false;
        private bool abort = false;

        private object objLock = new object();

        public event EventHandler StatusChanged;

        public ActiveDirectorySearch Search
        {
            get { return search; }
        }
        private ActiveDirectorySearch search = new ActiveDirectorySearch();

        public event EventHandler SearchComplete;        

        /// <summary>
        /// Initializes the Active Directory interface. Determines if the computer
        /// is domain joined and processes any synchronization if needed.
        /// </summary>
        public void Initialize()
        {
            SetStatus(ActiveDirectoryInterfaceStatus.Initializing);

            if ( !IsComputerDomainJoined() )
            {
                SetStatus(ActiveDirectoryInterfaceStatus.Unavailable);
                Log.Information("Active Directory unavailable.");
                return;
            }

            else
            {
                if ( IsDomainControllerAvailable() )
                {
                    search.SearchComplete += Search_SearchComplete;

                    if ( CacheFileExists() )
                    {
                        LoadCacheFile();
                        SetStatus(ActiveDirectoryInterfaceStatus.Available);
                    }

                    if ( cacheFound )
                    {
                        if (Settings.Default.AutoUpdateActiveDirectory)
                        {
                            Synchronize();
                        }

                        else
                            Log.Information("Active Directory cache was last updated on " + LastUpdateTime.ToString());
                    }
                    
                    else
                    {
                        initialCacheBuilding = true;
                        Synchronize();
                    }                 
                }
            }

            initialized = true;
            Log.Information("Active Directory interface initialized." );

            if (cacheFound)
                Log.Information("Active Directory cache loaded.");

            if ( initialCacheBuilding )
                Log.Information("Active Directory interface is building initial cache.");
        }        

        private void OnStatusChanged(object sender, EventArgs e)
        {
            EventHandler handler = StatusChanged;

            if ( handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Aborts synchronization.
        /// </summary>
        public void Abort()
        {
            abort = true;
        }

        /// <summary>
        /// Launches the Active Directory update thread.
        /// </summary>
        public void Synchronize()
        {
            if (status != ActiveDirectoryInterfaceStatus.Synchronizing)
            {
                abort = false;
                ThreadPool.QueueUserWorkItem(BeginDownload);
            }
        }

        /// <summary>
        /// Processes the Active Directory synchronization and updates the cache file.
        /// </summary>
        private void BeginDownload(object state)
        {
            lock (objLock)
            {
                if (initialized)
                {
                    if (status == ActiveDirectoryInterfaceStatus.Initializing || 
                        status == ActiveDirectoryInterfaceStatus.Synchronized || 
                        status == ActiveDirectoryInterfaceStatus.Available)
                    {
                        SetStatus(ActiveDirectoryInterfaceStatus.Synchronizing);
                        Log.Information("Active Directory sync started.");

                        try
                        {
                            computers.Clear();
                            DirectoryEntry entry = new DirectoryEntry("LDAP://" + CurrentDomain);
                            DirectorySearcher mySearcher = new DirectorySearcher(entry);
                            mySearcher.Asynchronous = true;
                            mySearcher.Filter = ("(objectClass=computer)");
                            mySearcher.SizeLimit = int.MaxValue;
                            mySearcher.PageSize = int.MaxValue;
                            SearchResultCollection FoundResults = mySearcher.FindAll();

                            foreach (SearchResult resEnt in FoundResults)
                            {
                                if (abort)
                                {
                                    Log.Information("Active Directory sync aborted.");
                                    return;
                                }

                                DirectoryEntry p = resEnt.GetDirectoryEntry();
                                String ComputerName = p.Name;

                                if (ComputerName.StartsWith("CN="))
                                {
                                    ComputerName = ComputerName.Remove(0, 3);
                                }
                                computers.Add(new EasyDeployCollectionMember(ComputerName));
                            }

                            mySearcher.Dispose();
                            entry.Dispose();
                            computers = computers.OrderBy(x => x.Name).ToList();
                            lastUpdateTime = DateTime.Now;
                            SaveCacheFile();
                            SetStatus(ActiveDirectoryInterfaceStatus.Synchronized);
                            initialCacheBuilding = false;
                            GC.Collect();
                            Log.Information("Active Directory sync complete.");
                        }

                        catch (Exception e)
                        {
                            Log.Error("Active Directory sync error.", e);
                            SetStatus(ActiveDirectoryInterfaceStatus.Unavailable);
                        }
                    }
                }

                else
                {
                    Log.Warning("Active Directory Interface must be initialized before starting the sync thread.");
                }
            }
        }

        /// <summary>
        /// Compares the local machines domain name vs the computer name.
        /// If they are different, then computer has been joined to a domain.
        /// </summary>
        /// <returns></returns>
        private bool IsComputerDomainJoined()
        {
            domain = Environment.UserDomainName.ToUpper();

            if (domain == Environment.MachineName)
                return false;

            else
                return true;
        }

        /// <summary>
        /// Get's the list of domain controller IP's and pings them to see if
        /// they are available. Only one needs to be available to return true.
        /// </summary>
        /// <returns></returns>
        private bool IsDomainControllerAvailable()
        {
            try
            {
                // get root of the directory data tree on a directory server
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://rootDSE");

                // get the hostname of the directory server of your root
                string dcHostname = dirEntry.Properties["dnsHostname"].Value.ToString();
                IPAddress[] ipAddresses = Dns.GetHostAddresses(dcHostname);
                Ping pingSender = new Ping();

                for (int i = 0; i < ipAddresses.Count(); i++)
                {
                    try
                    {
                        PingReply reply = pingSender.Send(ipAddresses[i].ToString(), 1000);
                        if (reply.Status == IPStatus.Success)
                        {
                            return true;
                        }
                    }

                    catch
                    {
                        Log.Information("Domain controller at " + ipAddresses[i].ToString() + " could not be reached.");
                    }
                }
            }

            catch ( Exception e )
            {
                Log.Error("Domain controller availability could not be determined.", e);
            }

            return false;
        }

        /// <summary>
        /// Checks to see if the Active Directory Cache exists. If it doesn't,
        /// checks to see if the temp app folder exsts; creates directory is it doesn't exist.
        /// </summary>
        /// <returns></returns>
        public bool CacheFileExists()
        {
            if ( File.Exists(CACHE_DATA_LOCATION + CACHE_FILE_NAME) )
            {
                return true;
            }

            if ( !Directory.Exists(CACHE_DATA_LOCATION) )
            {
                Directory.CreateDirectory(CACHE_DATA_LOCATION);
            }

            return false;
        }

        /// <summary>
        /// Loads the cache file.
        /// </summary>
        private void LoadCacheFile()
        {
            try
            {                
                FileStream file = new FileStream(CACHE_DATA_LOCATION + CACHE_FILE_NAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                ActiveDirectoryCache cacheLoad = (ActiveDirectoryCache)XmlToObject.Parse(reader.ReadToEnd(), typeof(ActiveDirectoryCache));
                reader.Close();

                if (cacheLoad.DomainName == CurrentDomain)
                {
                    cacheFound = true;
                    cache = cacheLoad;
                    lastUpdateTime = File.GetLastWriteTime(CACHE_DATA_LOCATION + CACHE_FILE_NAME);                    
                }
            }

            catch ( Exception e )
            {
                Log.Error("Cache file could not be loaded.", e);
            }
        }

        /// <summary>
        /// Writes the Active Directory cache to the file system.
        /// </summary>
        private void SaveCacheFile()
        {
            try
            {
                cache.Computers = computers.ToList();
                cache.DomainName = CurrentDomain;
                FileStream file = new FileStream(CACHE_DATA_LOCATION + CACHE_FILE_NAME, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(ObjectToXml.DumpString(cache));
                writer.Close();
                Log.Information("Cache file updated.");
            }
            
            catch ( Exception e )
            {
                Log.Error("Cache file could no be saved.", e);
            }        
        }

        /// <summary>
        /// Deletes the cache file.
        /// </summary>
        public void DeleteCacheFile()
        {
            try
            {
                File.Delete(CACHE_DATA_LOCATION + CACHE_FILE_NAME);
                Log.Information("Cache file deleted.");
            }

            catch (Exception e)
            {
                Log.Error("Unable to delete cache file.", e);
                throw e;
            }
        }

        /// <summary>
        /// Sets the status of the interface and raises the status changed event.
        /// </summary>
        /// <param name="state"></param>
        private void SetStatus(ActiveDirectoryInterfaceStatus state)
        {
            status = state;
            OnStatusChanged(null, null);
        }

        public void SearchFor(String keyword)
        {
            search.Key = keyword;
            search.Find();
        }

        private void Search_SearchComplete(object sender, EventArgs e)
        {
            CollectionResources.Manager.ActiveCollection.Members.Clear();
            CollectionResources.Manager.ActiveCollection.AddMembers(CollectionResources.ActiveDirectory.Search.Results);            
            OnSearchComplete(this, e);
        }

        private void OnSearchComplete(object sender, EventArgs e)
        {
            EventHandler handler = SearchComplete;

            if (handler != null)
            {
                handler(sender, e);
            }
        }
    }
}
