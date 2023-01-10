using System.Runtime.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace lr_13
{
    [Serializable]
    public abstract class Fighter
    {
        /*SerializationBinder Binder { get; set; }
        StreamingContext Context { get; set; }
        ISurrogateSelector SurrogateSelector { get; set; }*/
       /* object Deserialize (Stream serializationStream);
        void Serialize(Stream serializationStream, object graph);*/

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

    [Serializable]
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

    [Serializable]
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

    [Serializable]
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

    [Serializable]
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
}
