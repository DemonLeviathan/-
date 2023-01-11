using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class NursingStaff
    {
        private int patients = 15; // average quantity of patients per day
        private int patience = 10; // level of stress

        public void Visit()
        {
            if (patients > 0)
            {
                patience--;
                Console.WriteLine($"Visit of patients. {--patients} patients are yet");
            }
            else
                Console.WriteLine("NEED IN REST!!!");
        }

        public NurseMemento SaveState()
        {
            Console.WriteLine("Remember. Still: {0} patients, {1} - calm level", patients, patience);
            return new NurseMemento(patients, patience);
        }

        public void RestoreState(NurseMemento memento)
        {
            this.patients = memento.Patients;
            this.patience = memento.Patience;
            Console.WriteLine("Remember and think, may be else. Still: {0} patients, {1} - calm level", patients, patience);
        }
    } // Memento

    public class NurseMemento
    {
        public int Patients { get; private set; }
        public int Patience { get; private set; }

        public NurseMemento(int patients, int patience)
        {
            this.Patients = patients;
            this.Patience = patience;
        }
    }

    class DayHistory
    {
        public Stack<NurseMemento> History { get; private set; }
        public DayHistory()
        {
            History = new Stack<NurseMemento>();
        }
    }
}
