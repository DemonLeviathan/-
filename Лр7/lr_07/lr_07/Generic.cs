using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_07
{
    public class CollectionType<T> : IOptions<T> /*where T : Fighter   | where T : ClassArray    */
    {
        List<T> list { get; set; }  

        public CollectionType()
        {
            list = new List<T>();   
        }
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Remove(T obj)
        {
            list.Remove(obj);
        }

        public void Watch()
        {
            foreach (T obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }

    class FileWriter
    {
        public void Writee(string filename, CollectionType<ClassArray> obj)
        {
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                writer.WriteLineAsync(obj.ToString());
            }
        }

        public void Read(string filename, CollectionType<ClassArray> obj)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
