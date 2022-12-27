using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public static class VISDiskInfo
    {
        //DriveInfo[] drives = DriveInfo.GetDrives();
        public static void PrintDiskInfo(DriveInfo[] drives)
        {
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
            }
        }
    }
}
