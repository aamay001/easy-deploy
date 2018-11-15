using System;
using System.Collections.Generic;
using System.Linq;

namespace Easy_Deploy.CollectionManagement
{
    public class EasyDeployCollection
    {
        private readonly String NODE_PATH_DELIMETER = "\\";

        public bool IsCollectionFolder
        {
            get { return isFolder; }
            set { isFolder = value; }
        }
        private bool isFolder = false;

        public String NodePath
        {
            get { return nodepath; }
            set { nodepath = value; }
        }
        private String nodepath = "";

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String name = "";

        public String FullName
        {
            get { return nodepath + NODE_PATH_DELIMETER + name; }
        }

        public List<EasyDeployCollectionMember> Members
        {
            get { return members; }
            set { members = value; }
        }
        private List<EasyDeployCollectionMember> members = new List<EasyDeployCollectionMember>();

        public DateTime DateCreated = DateTime.Now;

        /// <summary>
        /// Default constructor. Needed for serialization.
        /// </summary>
        public EasyDeployCollection()
        {
        }

        /// <summary>
        /// Constructor for collection folder. Used for logical structure in the tree view.
        /// </summary>
        /// <param name="_Name"></param>
        /// <param name="_IsFolder"></param>
        /// <param name="NP"></param>
        public EasyDeployCollection( String _Name, bool _IsFolder, String NP)
        {
            isFolder = _IsFolder;
            name = _Name;            
            nodepath = NP;
        }

        /// <summary>
        /// Constructor for a collection with list of member names.
        /// </summary>
        /// <param name="_Name">Collection name.</param>
        /// <param name="_Members">List of member names.</param>
        /// <param name="NP">Node path in the tree view.</param>
        public EasyDeployCollection( String _Name, List<String> _Members, String NP)
        {
            isFolder = false;
            members = new List<EasyDeployCollectionMember>();

            for ( int i = 0; i < _Members.Count; i++ )
                members.Add(new EasyDeployCollectionMember(_Members[i]));

            name = _Name;
            nodepath = NP;
        }

        /// <summary>
        /// Renames a collection to a new name.
        /// </summary>
        /// <param name="NewName">New name to give the collection.</param>
        public void Rename(String NewName)
        {
            name = NewName;
        }

        /// <summary>
        /// Adds a collections of members to the members of this collection.
        /// </summary>
        /// <param name="NewMemebers"></param>
        public void AddMembers(List<EasyDeployCollectionMember> NewMembers)
        {
            if (NewMembers == null)
                return;

            foreach (EasyDeployCollectionMember cm in NewMembers )
            {
                Members.Add(cm);
            }

            Members = Members.OrderBy(x => x.Name).ToList();
        }
    }
}
