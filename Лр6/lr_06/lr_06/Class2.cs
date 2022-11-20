using lr_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_06
{
    public class Army
    {
        public List<Fighter> Fighters { get; set; }

        public Army()
        {
            Fighters = new List<Fighter>();
        }
        public void Add(Fighter index)
        {
            Fighters.Add(index);
        }

        public void Remove(int index)
        {
            Fighters.RemoveAt(index);
        }

        public void Show()
        {
            foreach (Fighter index in Fighters)
            {
                Console.WriteLine(index);
            }
        }
    }

    public class ArmyController : Army
    {
        public void AttackPower()
        {
            int max = 0;
            for (int i = 0; i < Fighters.Count; i++)
            {
                if (max < Fighters[i].average_damage)
                {
                    max = Fighters[i].average_damage;
                }
            }
            Console.WriteLine("The most powerful fighter with damage: " + max);

            for (int i = 0; i < Fighters.Count; i++)
            {
                if (max == Fighters[i].average_damage)
                {
                    Console.WriteLine(Fighters[i].name + " - is the strongest fighter");
                }
            }

        }

        public void SortFighters()
        {
            var sorted = Fighters.OrderBy(f => f.average_damage).ToList();
            // Console.WriteLine(sorted);
        }

        public void DamageExep(int damage)
        {
            if (damage < 0)
            {
                throw new DamageExeption("Error. Damage can't be less than 0", damage);
            }
        }

    }
}