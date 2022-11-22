using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_07
{
    public class CollectionType<T> : IOptions<T> where T : ClassArray
    {
        List<T> list { get; set; }  

        public CollectionType()
        {
            list = new List<T>();   

            if (list != null)
            {

            }
        }
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Remove(T obj)
        {
            list.Remove(obj);
        }

        public void See()
        {
            foreach (T obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
