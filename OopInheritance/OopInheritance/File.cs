using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class File
    {
        public File(string name, string extension)
        {
            this.Name = name;
            this.Extension = extension;
        }

        public string Name
        {
            get;
        }

        public string Extension
        {
            get;
        }

        public void Open()
        {
            Console.WriteLine($"Opening file '{this.Name}.{this.Extension}'");
        }

        public void Copy(string destinationPath)
        {
            Console.WriteLine($"Copying file '{this.Name}.{this.Extension}' to '{destinationPath}'");
        }

        public static void GetRootFolder()
        {
            Console.WriteLine($@"Root folder is 'C:\'");
        }
    }
}
