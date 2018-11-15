using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Easy_Deploy.CollectionManagement
{
    static class CollectionResources
    {
        static public Console Console;
        static public ActiveDirectoryInterface ActiveDirectory;
        static public CollectionManager Manager;

        static public void Initialize()
        {            
            ThreadPool.QueueUserWorkItem(InitializeCollectionManager);
            ThreadPool.QueueUserWorkItem(InitialzeActiveDirectory);
            Console = new Console();
        }

        static private void InitialzeActiveDirectory(object state)
        {
            ActiveDirectory = new ActiveDirectoryInterface();
            ActiveDirectory.Initialize();
        }

        static private void InitializeCollectionManager(object state)
        {
            Manager = new CollectionManager();
        }
    }
}
