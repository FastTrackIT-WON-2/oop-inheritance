using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public static class FileManager
    {
        public static void BulkCopy(string destinationPath, params File[] files)
        {
            if (files is null || files.Length == 0)
            {
                Console.WriteLine("FileManager :: No files to copy!");
                return;
            }

            foreach (File f in files)
            {
                f.Copy(destinationPath);
            }
        }
    }
}
