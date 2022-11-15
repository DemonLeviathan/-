using lr_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_06
{
    public partial class Archer : Fighter
    {
        public void Fighter_Skill()
        {
            Console.WriteLine($"Archer weapon is {weapon} with {skill} skill");
        }
    }
}