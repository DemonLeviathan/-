using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public static class VISFileManager
    {
        
        public static void Read(string disk)
        {
            DirectoryInfo dir = new DirectoryInfo(disk);
            foreach (DirectoryInfo name in dir.GetDirectories())
            {
                Console.WriteLine(name.Name);   
            }
        }

        public static void Create(string dirname, string filename, string filename2)
        {
            string path = @"D:\Универ\3-й семестр\Лабы ООП\Лр12\" + dirname;
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
            }
            
            string filepath = path + "\\" + filename + ".txt";
            FileInfo fileInfo = new FileInfo(filepath);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            try
            {
                using StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default);
                writer.WriteLine(fileInfo);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string filepath2 = path + "\\" + filename2 + ".txt";

            try
            {
                File.Copy(filepath, filepath2, true);
                File.Delete(filepath);
            }
            catch
            {
                Console.WriteLine("Such file is in");
            }

        }

        public static void VISFiles(string path, string ex)
        {
            string dirPath = @"D:\Универ\3-й семестр\Лабы ООП\Лр12\VISFiles";
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                dir.Create();
            }

            DirectoryInfo dir2 = new DirectoryInfo(path);

            foreach (FileInfo file in dir2.GetFiles())
            {
                if (file.Extension == ("." + ex))
                {
                    file.CopyTo(dirPath + "\\" + file.Name, true);
                }
            }

            try
            {
                dir.MoveTo(@"D:\Универ\3-й семестр\Лабы ООП\Лр12\VISInspect\VISFiles");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Zip()
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\Универ\3-й семестр\Лабы ООП\Лр12\VISInspect\VISFiles");
            try
            {
                ZipFile.CreateFromDirectory(info.FullName, info.FullName + ".zip");
            }
            catch
            {
                Console.WriteLine("Archive was created");
            }
            //VISLog.Write($"Archive creation", info.FullName, $"{info.FullName}.zip");
        }

        public static void Unzip(string dirname)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\Универ\3-й семестр\Лабы ООП\Лр12\VISInspect\VISFiles");
            try
            {
                ZipFile.ExtractToDirectory(info.FullName + ".zip", dirname);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Archive was upzipped");
        }
    }
}
