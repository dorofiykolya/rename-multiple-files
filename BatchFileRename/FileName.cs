using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileRename
{
    class FileName
    {
        public string name;
        public string path;
        public string extension;
        public string fullName;

        public string newName;
        public string newExtension;
        public string directory;

        public string Name
        {
            get { return fullName; }
        }

        public string NewName
        {
            get { return newName + newExtension; }
        }
    }
}
