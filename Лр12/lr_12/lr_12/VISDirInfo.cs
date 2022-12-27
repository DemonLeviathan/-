using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public static class VISDirInfo
    {
        public static void DirInfo(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine("Quantity of files: " + dirInfo.GetFiles().Length);
            Console.WriteLine("Creation time: " + dirInfo.CreationTime);
            Console.WriteLine("Quantity of subdirectories: " + dirInfo.GetDirectories().Length);
            Console.WriteLine("List of parent directories: " + dirInfo.Parent);
        }
    }
}
