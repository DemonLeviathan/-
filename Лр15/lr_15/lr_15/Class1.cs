using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lr_15
{
    partial class Programm
    {
        public static Task task1;
        public static void SieveOfEratosthenes()
        {
            int N = 1000;
            WriteLine($"Current ID: {Task.CurrentId.ToString()}");
            List<int> ints = new List<int>();
            for (int i = 2; i < N; i++)
            {
                ints.Add(i);
            }

            for (int i = 0; i < ints.Count; i++)
            {
                for (int j = 2; j < N; j++)
                {
                    ints.Remove(ints[i] * j);
                }
            }

            WriteLine($"Simple numbers from {N}: ");

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
