using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_05
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
}
