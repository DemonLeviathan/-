using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class Doctor : ICure, IDoctor
    {
        public string Name { get; set; }
        public void Analyze(int pain_lvl)
        {
            if (pain_lvl < 5) Console.WriteLine("You are healthy");
            if (pain_lvl > 5 && pain_lvl < 10) Console.WriteLine("We will watch you now");
            if (pain_lvl > 10) Console.WriteLine("To psyhushka!!!!");
        }
        public void Grugs()
        {
            Console.WriteLine("Your cures");
        }
        // Builder 
        public Disease Find(Symptoms syms)
        {
            syms.FindDis();
            syms.Symp1();
            syms.Symp2();
            return syms.Disease;
        }
        //--------------------
        public void Treat()
        {
            Console.WriteLine("I am treating you");
        }
    }

    public abstract class Symptoms
    {
        public Disease Disease { get; private set; }
        public void FindDis()
        {
            Disease = new Disease();
        }
        public abstract void Symp1();
        public abstract void Symp2();
    }
}
