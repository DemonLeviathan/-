using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_15
{
    partial class Programm
    {
        public static BlockingCollection<string> block;
        public static void AddProduct()
        {
            Random random = new Random();
            int x;
            List<string> list = new List<string>() { "Computer", "Laptop", "Phone", "TV", "keyboard"}; 
            for (int i = 0; i < list.Count; i++)
            {
                x = random.Next(0, list.Count - 1);
                Console.WriteLine($"Product was added: {list[x]}");
                block.Add(list[x]);
                list.RemoveAt(x);
                Thread.Sleep(random.Next(1, 5));
            }
            block.CompleteAdding();
        }

        public static void PurchasedProduct()
        {
            string str;
            while (block.IsAddingCompleted == false)
            {
                if (block.TryTake(out str) == true)
                    Console.WriteLine($"Product was purchased: {str}");
                if (block.TryTake(out str) != true)
                    Console.WriteLine("Purchaser is gone out");
            }
        }
    }
}
