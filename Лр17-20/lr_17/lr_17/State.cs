using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class Сhamber
    {
        public IChamberState State { get; set; }

        public Сhamber(IChamberState ws)
        {
            State = ws;
        }

        public void Simple()
        {
            State.Simple(this);
        }
        public void VIP()
        {
            State.VIP(this);
        }
    }

    public interface IChamberState
    {
        void Simple(Сhamber chamber);
        void VIP(Сhamber chamber);
    }

    public class FirstLvl : IChamberState
    {
        public void Simple(Сhamber chamber)
        {
            Console.WriteLine("Surface cleaning");
            chamber.State = new SecLvl();
        }

        public void VIP(Сhamber chamber)
        {
            Console.WriteLine("Just cleaning");
        }
    }

    public class SecLvl : IChamberState
    {
        public void Simple(Сhamber chamber)
        {
            Console.WriteLine("Let's put trash under carpet");
            chamber.State = new ThrLvl();
        }

        public void VIP(Сhamber chamber)
        {
            Console.WriteLine("Clean little dirties");
            chamber.State = new FirstLvl();
        }
    }

    public class ThrLvl : IChamberState
    {
        public void Simple(Сhamber chamber)
        {
            Console.WriteLine("Let's think it's clean");
        }

        public void VIP(Сhamber chamber)
        {
            Console.WriteLine("Clean to shine");
            chamber.State = new ThrLvl();
        }
    }
}
