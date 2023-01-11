using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class Nurse : ICure, INurse
    {
        string Name = "Dr. Jackson";
        public void Grugs()
        {
            Console.WriteLine("Your cures");
        }
        public string Analis { get; set; }

        //-----------------------------
        public void HelpToTreat()
        {
            Console.WriteLine("I am instead doctor and i can help");
        }
    }
}
