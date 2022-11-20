using lr_06;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace lr_06
{
    public abstract class Fighter : IFighters
    {
        public string name { get; set; }
        public string weapon { get; set; }
        public string skill { get; set; }
        public int average_damage;
        public int IDFighter { get; set; }

        public Fighter(string weapon1, string skill1, int ID, int damage, string Name)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
            this.name = name;
        }

        public int DamageEX
        {
            get => this.average_damage;
            set
            {
                if (value < 0)
                {
                    throw new DamageExeption("Damage can't be less than 0", value);
                }
                else
                    average_damage = value;
            }
        }

        public virtual void Actions()
        {
            Console.WriteLine("Weapon of {0} - {1}, skill - {2}, average damage - {3}", name, weapon, skill, average_damage);
        }
    }
    sealed class Hunter : Fighter
    {
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public Hunter(string weapon, string skill1, int ID, int damage, string Name) : base(weapon, skill1, ID, damage, Name)
        {
            this.Weapon = weapon;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
            name = Name;
            if (average_damage < 0)
            {
                throw new DamageExeption("Error. Damage can't be less than 0", average_damage);
            }
        }

        public override void Actions()
        {
            Console.WriteLine("Hunters ID - {0}, weapon - {1}, skill - {2}, avarage damage - {3}", IDFighter, weapon, skill, average_damage);
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

        public Shaman(string weapon1, string skill1, int ID, int damage, string Name) : base(weapon1, skill1, ID, damage, Name)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
            name = Name;
        }
    }

    public partial class Archer : Fighter
    {
        public Archer(string weapon1, string skill1, int ID, int damage, string Name) : base(weapon1, skill1, ID, damage, Name)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
            name = Name;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }

    }

    class Psychic : Fighter
    {
        public Psychic(string weapon1, string skill1, int ID, int damage, string Name) : base(weapon1, skill1, ID, damage, Name)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
            name = Name;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }
    enum Functions
    {
        Add,
        Remove,
        Show,

    }

    public struct Options
    {
        //public string action;
        //public int skill;
        public int Damage;
       /* public void Actions()
        {
            Console.WriteLine($"Action {action} on skill {skill}");
        }*/
        public Options(int damage)
        {
            this.Damage = damage;
            if (this.Damage < 0)
            {
                throw new Exception("Damage can't be less than 0");
            }
        }
    }

    // eponymous methods
    abstract class BaseClone
    {
        public abstract bool DoClone();
    }

    class UserClass : BaseClone, ICloneable
    {

        public override bool DoClone()
        {
            Console.WriteLine("Method from abstract class");
            return true;
        }
    }

    class Printer
    {
        public void IAmPrinting(Fighter obj)
        {
            Console.WriteLine(obj.GetType().Name + " " + obj.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Hunter hunter = new Hunter("gun", "shot", 1, 107, "Hunter");
            Shaman shaman = new Shaman("book of curses", "curse", 2, 94, "Shaman");
            Archer archer = new Archer("bow", "firebolt", 3, 123, "Archer");
            Psychic psychic = new Psychic("tarot", "mind capture", 4, 77, "Psychic");*/

            /* hunter.Actions();
             shaman.Actions();
             archer.Actions();
             psychic.Actions();*/
            /*archer.Fighter_Skill();*/

            UserClass userClass = new UserClass();

            //userClass.DoClone();

            object obj1 = new Hunter("gun", "shot", 1, 107, "Hunter");
            object obj2 = new Archer("bow", "firebolt", 3, 123, "Archer");
            object obj3 = new Shaman("book of curses", "curse", 2, 94, "Shaman");

            /*Console.WriteLine(obj1 is Hunter);
            Console.WriteLine(obj2 is Hunter);
            Console.WriteLine(obj3 is Shaman);*/

            IEnumerable<string> list1 = new[] { "hunter", "shaman", "archer", "psychic" };
            IList<string> list2 = list1 as IList<string>;

            if (list2 != null)
            {
                //Console.WriteLine(list2[0] + " " + list2[list2.Count - 2]);
            }
            /*Console.WriteLine(hunter.GetType() + " " + hunter.ToString());
            Console.WriteLine(shaman.GetType() + " " + shaman.ToString());
            Console.WriteLine(archer.GetType() + " " + archer.ToString());
            Console.WriteLine(psychic.GetType() + " " + psychic.ToString());*/

            /*Console.WriteLine();
            Console.WriteLine();*/
            //Printer printer = new Printer();
            //Fighter[] array = { hunter, shaman, archer, psychic };

            /*for (int i = 0; i < array.Length; i++)
            {
                printer.IAmPrinting(array[i]);
            }*/

            // 5 lr

            //Army army = new Army();
            ArmyController army = new ArmyController();

            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();

            try
            {
                Hunter hunter = new Hunter("gun", "shot", 1, -107, "Hunter");
                Shaman shaman = new Shaman("book of curses", "curse", 2, 94, "Shaman");
                Archer archer = new Archer("bow", "firebolt", 3, 123, "Archer");
                Psychic psychic = new Psychic("tarot", "mind capture", 4, 77, "Psychic");

                if (hunter.average_damage > 0)
                {
                    Console.WriteLine("norm");
                }
                /*army.Add(hunter);
                army.Add(shaman);
                army.Add(archer);
                army.Add(psychic);
                army.Show();
                army.AttackPower();
                army.SortFighters();*/
            }
            catch (DamageExeption ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Uncorrect value: {ex.Damage}");
                fileLogger.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("Ended #1");
            }

            try
            {
                int x = 7;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ended #2");
            }

            try
            {
                int[] array = new int[3] { 1, 2, 3 };
                array[4] = 7;
            }
            catch (Exception ex) when (ex.Source.Length < 3)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Extention");
            }
            finally
            {
                Console.WriteLine("Ended #3");
            }

            try
            {

            }
            catch
            {

            }
        }
    }
}