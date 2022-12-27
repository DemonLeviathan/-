using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace lr_12
{
    public class Programm
    {
        static void Main(string[] args)
        {
            string path = "vislogfile.txt";

            File.WriteAllText(path, "-----Logging-------\n");
            DriveInfo[] drives = DriveInfo.GetDrives();
            

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