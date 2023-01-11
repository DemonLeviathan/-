using System.IO;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace lr_17
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            // Builder 
            Doctor doctor = new Doctor();
            Symptoms builder = new Patient("White");
            Disease ryeBread = doctor.Find(builder);
            Console.WriteLine(ryeBread.ToString());
            Console.WriteLine("-----------------------------------");

            //Singleton
            App app = new App();
            string[] options = { "Black", "Times New Roman", "105%" };
            string[] options2 = { "Blue", "Colibri", "96fr" };
            app.SetOptions(options2);
            app.Settings = Settings.getInstance(options);
            Console.WriteLine(app.Settings.Show());
            Console.WriteLine("-----------------------------------");

            IPatient pat = new Patient("Black");
            pat.GetInfo();
            IPatient clonepatient = pat.Clone();
            clonepatient.GetInfo();
            Console.WriteLine("-----------------------------------");

            // Abstaract Factory 
            Sick homeSick = new Sick(new HomeSickFactory());
            homeSick.Put();
            homeSick.Drink();
            Console.WriteLine("-----------------------------------");

            Sick hospSick = new Sick(new HospitalSickFactory());
            hospSick.Put();
            hospSick.Drink();
            Console.WriteLine("-----------------------------------------------------");

            //Adapter
            Patient patient = new Patient("qwerty");
            patient.Ache(doctor);
            Nurse nurse = new Nurse();
            IDoctor doctor1 = new NurseToDoctor(nurse);
            patient.Ache(doctor1);
            Console.WriteLine("-----------------------------------");

            // Decorator
            Diagnosis diagnosis1 = new Cough();
            diagnosis1 = new HeadAche(diagnosis1);
            Console.WriteLine("Diagnose: {0}", diagnosis1.Name);
            Console.WriteLine("Level of illness: {0}", diagnosis1.GetPain());
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            Diagnosis diagnosis2 = new Nausea();
            diagnosis2 = new StrongNausea(diagnosis2);
            Console.WriteLine("Diagnose: {0}", diagnosis2.Name);
            Console.WriteLine("Level of illness: {0}", diagnosis2.GetPain());
            Console.WriteLine("-----------------------------------");

            //State
            Сhamber сhamber = new Сhamber(new FirstLvl());
            сhamber.Simple();
            сhamber.VIP();
            сhamber.VIP();
            Console.WriteLine("-----------------------------------");

            //Memento
            NursingStaff nursingStaff = new NursingStaff();
            nursingStaff.Visit();
            DayHistory day = new DayHistory();
            day.History.Push(nursingStaff.SaveState());
            nursingStaff.Visit();
            nursingStaff.RestoreState(day.History.Pop());
            nursingStaff.Visit();
            Console.WriteLine("-----------------------------------");

            //Iterator
            Library library = new Library();
            MedStudent reader = new MedStudent();
            reader.SeeBooks(library);
            Console.WriteLine("-----------------------------------");

        }
    }
}