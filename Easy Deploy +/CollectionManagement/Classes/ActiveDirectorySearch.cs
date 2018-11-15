using System;
using System.Collections.Generic;
using System.Threading;

namespace Easy_Deploy.CollectionManagement
{
    public struct ActiveDirectorySearchOptions
    {
        public bool UseKeyAsPrefix
        {
            get { return prefix; }
            set { prefix = value; }
        }
        private bool prefix;

        public bool CaseSensitive
        {
            get { return caseSensitive; }
            set { caseSensitive = value; }
        }
        private bool caseSensitive;

        public bool KeyContained
        {
            get { return contained; }
            set { contained = value; }
        }
        private bool contained;

        public ActiveDirectorySearchOptions( bool _UseKeyAsPrefix, bool _CaseSensitive, bool _KeyContained )
        {
            prefix = _UseKeyAsPrefix;
            caseSensitive = _CaseSensitive;
            contained = _KeyContained;
        }
    }

    public class ActiveDirectorySearch
    {
        public String Key
        {
            get { return key; }
            set { key = value; }
        }
        private String key = "";

        public ActiveDirectorySearchOptions Options;

        public List<EasyDeployCollectionMember> Results;

        public event EventHandler SearchComplete;
        private object tlock = new object();

        public ActiveDirectorySearch()
        {
            Options = new ActiveDirectorySearchOptions(true, false, false);
        }

        private void OnSearchComplete(object sender, EventArgs e)
        {
            EventHandler handler = SearchComplete;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void Find()
        {
            ThreadPool.QueueUserWorkItem(SearchThread);      
        }

        private void SearchThread(object state)
        {
            lock(tlock)
            {
                List<EasyDeployCollectionMember> results = null;

                if ( CollectionResources.ActiveDirectory.CacheFound &&
                     CollectionResources.ActiveDirectory.Status != ActiveDirectoryInterfaceStatus.Synchronized)
                {
                    results = CollectionResources.ActiveDirectory.Cache.Computers.FindAll
                        (
                            x => x.Name.Equals(key) ||
                            (Options.UseKeyAsPrefix ? x.Name.StartsWith(key) : false) ||

                            ((Options.UseKeyAsPrefix && !Options.CaseSensitive) ?
                            (x.Name.StartsWith(key.ToLower()) || x.Name.StartsWith(key.ToUpper())) : false) ||

                            (Options.KeyContained ? x.Name.Contains(key) : false) ||
                            ((Options.KeyContained && !Options.CaseSensitive) ? (x.Name.Contains(key.ToLower()) || x.Name.Contains(key.ToUpper())) : false)
                        );
                }

                else
                {
                    results = CollectionResources.ActiveDirectory.Computers.FindAll
                        (
                            x => x.Name.Equals(key) ||
                            (Options.UseKeyAsPrefix ? x.Name.StartsWith(key) : false) ||

                            ((Options.UseKeyAsPrefix && !Options.CaseSensitive) ?
                            (x.Name.StartsWith(key.ToLower()) || x.Name.StartsWith(key.ToUpper())) : false) ||

                            (Options.KeyContained ? x.Name.Contains(key) : false) ||
                            ((Options.KeyContained && !Options.CaseSensitive) ? (x.Name.Contains(key.ToLower()) || x.Name.Contains(key.ToUpper())) : false)
                        );
                }

                Results = results;

                OnSearchComplete(null, null);
            }
        }
    }
}
