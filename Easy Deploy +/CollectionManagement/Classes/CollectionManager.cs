using Easy_Deploy.Utilities;
using System;
using System.Collections.ObjectModel;

namespace Easy_Deploy.CollectionManagement
{
    public class CollectionManager
    {
        public EasyDeployCollection DeploymentCollection = new EasyDeployCollection();

        public ObservableCollection<EasyDeployCollection> UserCollections = new ObservableCollection<EasyDeployCollection>();

        public EasyDeployCollection ActiveCollection;     
        
        /// <summary>
        /// Returns an EasyDeployCollection object by looking it up using
        /// the collections full name.
        /// </summary>
        /// <param name="FullName"></param>
        /// <returns></returns>
        public EasyDeployCollection GetCollection( String FullName )
        {
            if (FullName == "Deployment")
                return DeploymentCollection;

            foreach (EasyDeployCollection c in UserCollections)
                if (c.FullName == FullName)
                    return c;

            return null;
        }

        /// <summary>
        /// Save user collection data to the application settings.
        /// </summary>
        public void SaveCollectionData()
        {
            try
            {
                Properties.Settings.Default.ComputerCollections = ObjectToXml.DumpString(UserCollections);
                Properties.Settings.Default.Save();
            }

            catch (Exception e)
            {
                Log.CriticalError(e.Message);
            }
        }

        /// <summary>
        /// Loads user collection data from the application settings.
        /// </summary>
        public void LoadCollectionData()
        {
            if (Properties.Settings.Default.ComputerCollections.Length > 0)
            {
                try
                {
                    UserCollections = (ObservableCollection<EasyDeployCollection>)XmlToObject.Parse
                        (
                            Properties.Settings.Default.ComputerCollections,
                            typeof(ObservableCollection<EasyDeployCollection>)
                        );
                }

                catch (Exception e)
                {
                    Log.Error("Error loading collection data. ", e);
                    throw (e);
                }
            }
        }
    }
}
