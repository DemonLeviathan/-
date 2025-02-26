﻿using System;

namespace lr_07
{
    public abstract class Fighter : IFighters
    {
        public string weapon;
        public string skill;
        public int IDFighter;
        // public string[] Fighters = { "Hunter", "Shaman", "Archer", "Psychic" };

        public Fighter(string weapon1, string skill1, int ID)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;

        }

        public virtual void Actions()
        {
            Console.WriteLine("Weapon of {0} - {1}, skill - {2}", IDFighter, weapon, skill);
        }
    }
    sealed class Hunter : Fighter
    {
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public Hunter(string weapon, string skill1, int ID) : base(weapon, skill1, ID)
        {
            this.Weapon = weapon;
            skill = skill1;
            IDFighter = ID;
        }

        public override void Actions()
        {
            Console.WriteLine("Hunters ID - {0}, weapon - {1}, skill - {2}", IDFighter, weapon, skill);
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }

    class Shaman : Fighter
    {
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
                return true;
        }

        public override int GetHashCode()
        {
            return IDFighter * 111;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }

        public Shaman(string weapon1, string skill1, int ID) : base(weapon1, skill1, ID)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
        }
    }

    class Archer : Fighter
    {
        public Archer(string weapon1, string skill1, int ID) : base(weapon1, skill1, ID)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }

    class Psychic : Fighter
    {
        public Psychic(string weapon1, string skill1, int ID) : base(weapon1, skill1, ID)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }

    // eponymous methods
    abstract class BaseClone
    {
        public abstract void DoClone();
    }

    class UserClass : BaseClone, ICloneable
    {
  
        public override void DoClone()
        {
            Console.WriteLine("Method from abstract class");
        }

        void ICloneable.DoClone()
        {
            Console.WriteLine("Method from interface");
        }
    }

    class Printer
    {
        public void IAmPrinting(Fighter obj)
        {
            Console.WriteLine(obj.GetType().Name + " " + obj.ToString());
        }
    }

    /*class Program
    {
        static void Main(string[] args)    
        {
            Hunter hunter = new Hunter("gun", "shot", 1);
            Shaman shaman = new Shaman("book of curses", "curse", 2);
            Archer archer = new Archer("bow", "firebolt", 3);
            Psychic psychic = new Psychic("tarot", "mind capture", 4);

            hunter.Actions();
            shaman.Actions();
            archer.Actions();
            psychic.Actions();

            Console.WriteLine();

            UserClass userClass = new UserClass();
            ICloneable cloneable = new UserClass();

            userClass.DoClone();
            cloneable.DoClone();
            Console.WriteLine();

            object obj1 = new Hunter("gun", "shot", 1);
            object obj2 = new Archer("bow", "firebolt", 3);
            object obj3 = new Shaman("book of curses", "curse", 2);

            Console.WriteLine(obj1 is Hunter);
            Console.WriteLine(obj2 is Hunter);
            Console.WriteLine(obj3 is Shaman);

            IEnumerable<string> list1 = new[] { "hunter", "shaman", "archer", "psychic" };
            IList<string> list2 = list1 as IList<string>;

            if (list2 != null)
            {
                Console.WriteLine(list2[0] + " " + list2[list2.Count - 2]);
            }
            Console.WriteLine(hunter.GetType() + " " + hunter.ToString());
            Console.WriteLine(shaman.GetType() + " " + shaman.ToString());
            Console.WriteLine(archer.GetType() + " " + archer.ToString());
            Console.WriteLine(psychic.GetType() + " " + psychic.ToString());

            Console.WriteLine();
            Printer printer = new Printer();
            Fighter[] array = { hunter, shaman, archer, psychic};

            for (int i = 0; i < array.Length; i++)
            {
                printer.IAmPrinting(array[i]);
            }
        }
    }    */
}