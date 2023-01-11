using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_15
{
    partial class Programm
    {
        public static void toAsync()
        {
            for (int i = 0; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ,  ");
                    Thread.Sleep(1000);
                }
            }
        }

        public static async void Async()
        {
            Console.WriteLine("Async method: ");
            await Task.Run(() => toAsync());
            Console.WriteLine("Completed");
        }
    }
}
