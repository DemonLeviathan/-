using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public static class VISFileInfo
    {
        public static void FileInf(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("Way: " + fileInfo.DirectoryName);
            Console.WriteLine("File name: " + fileInfo.Name);
            Console.WriteLine("Size: " + fileInfo.Length);
            Console.WriteLine("File Extension: " + fileInfo.Extension);
            Console.WriteLine("Creation/change time: " + fileInfo.CreationTime);
        }
    }
}
