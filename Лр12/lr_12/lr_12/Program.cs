using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lr_12.VISDiskInfo;

namespace lr_12
{
    public class Programm
    {
        static void Main(string[] args)
        {
            string path = "vislogfile.txt";
            string dir = "visdir";

            File.WriteAllText(path, "-----Logging-------\n");
            DriveInfo[] drives = DriveInfo.GetDrives();
            //VISDiskInfo disk = new VISDiskInfo();

            PrintDiskInfo(drives);
            VISFileInfo.FileInf(path);
            VISDirInfo.DirInfo(@"D:\Универ\3-й семестр\Лабы ООП\Лр12\lr_12\lr_12");
            VISFileManager.Read(@"D:\");
            VISFileManager.Create("VISInspect", "visdirinfo", "visdirinfo2");

            VISFileManager.Zip();
            VISFileManager.Unzip(@"D:\Универ\3-й семестр\Лабы ООП\Лр12\VISInspect\VISUnzip");
            FindAndWrite.Actions();

            /*DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }*/

        }
    }
}