using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_12
{
    public class FindAndWrite
    {
        private const string path = @"vislogfile.txt";

        public static void Actions()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    int count = 0;
                    Console.WriteLine("Enter key word to search on log file: ");
                    string keyword = Console.ReadLine();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(keyword))
                        {
                            Console.WriteLine("Found: ");
                            Console.WriteLine(line);
                            count++;
                        }
                    }
                    Console.WriteLine("Quantity of found lists: {0}", count);
                }

                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    int count = 0;
                    Console.WriteLine("Enter date for searching in log file: ");
                    string date = Console.ReadLine();
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(date))
                        {
                            Console.WriteLine("Found: ");
                            Console.WriteLine(line);
                            count++;
                        }
                    }
                    Console.WriteLine("Quantity of lists: {0}", count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
