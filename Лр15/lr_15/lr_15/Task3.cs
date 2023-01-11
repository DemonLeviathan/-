using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_15
{
    partial class Programm
    {
        public static int Sum()
        {
            Random random = new Random();
            return random.Next(1, 15) + random.Next(1, 15);
        }

        public static int Mult()
        {
            Random random = new Random();
            return random.Next(1, 15) * random.Next(1, 15);
        }

        public static int Diff()
        {
            Random random = new Random();
            return random.Next(15, 25) - random.Next(0, 15);
        }

        public static int Average(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }
    }
}
