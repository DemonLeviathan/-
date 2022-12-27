using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public class VISLog
    {
        string path = @"D:\Универ\3-й семестр\Лабы ООП\Лр12\lr_12\lr_12\vislogfile.txt";
        public void Write(string text)
        {
            using (StreamWriter fstream = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                fstream.WriteLine("File name: {0}", Path.GetFileName(path));
                fstream.WriteLine("File location: {0}", path);
                fstream.WriteLine("Date: {0}", DateTime.Now);
                fstream.WriteLine(text);
                fstream.WriteLine("--------------------------");
            }
        }

        public string Read()
        {
            string path = @"D:\Универ\3-й семестр\Лабы ООП\Лр12\lr_12\lr_12\vislogfile.txt";
            StreamReader reader = new StreamReader(path);
            return reader.ReadToEnd();
        }

        public void Search(string text)
        {
            string path = @"D:\Универ\3-й семестр\Лабы ООП\Лр12\lr_12\lr_12\vislogfile.txt";
            string[] findInfo = File.ReadAllLines(path);

            for(int i = 0; i < findInfo.Length; i++)
            {
                if (findInfo[i].Contains(text))
                {
                    Console.WriteLine("{0} is in file", text);
                }
                else
                    Console.WriteLine("{0} isn't in file", text);
            }
        }
    }
}
