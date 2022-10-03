using System;

namespace lr_02
{

    public class Airline
    {
        public string destination;
        public int flight_number;
        public string plane_type;
        public string leave_time;
        public string week_day;
        public string[] week = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sutarday", "Sunday" };
        static int flight_num;
        static string type;
        public static int Flight_num => flight_num;
        public static string Type => type;
        public readonly string place = "Riga";
        public readonly string IdDedstination;
        public const string PLACE = "Minsk";
        static int count = 0;

        public Airline() // 1
        {
            count++;
            int day = 5;
            for (int i = 0; i < 7; i++)
            {
                if (day > 7)
                {
                    Console.WriteLine("Uncorrect value, try again");
                    Console.WriteLine("Enter day number on week: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }

                if (day == i)
                {
                    week_day = week[i - 1];
                    break;
                }

            }

            destination = "Madrid";
            flight_number = 455;
            plane_type = "Ty-134";
            leave_time = "18:00";
        }

        public Airline(int day, string location, ref int number, string time, string type) // 2
        {
            count++;
            for (int i = 0; i < 7; i++)
            {
                if (day > 7)
                {
                    Console.WriteLine("Uncorrect value, try again");
                    Console.WriteLine("Enter day number on week: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }

                if (day == i)
                {
                    week_day = week[i - 1];
                    break;
                }

            }
            destination = location;
            plane_type = type;
            flight_number = number;
            leave_time = time;
        }

        public Airline(string type, string location = "London", int day = 7, int number = 457, string time = "9:30") // 3 
        {
            // string destination, int flight_number = 457, string plane_type = "Ty-134"
            count++;
            destination = location;
            plane_type = type;
            for (int i = 0; i < 8; i++)
            {
                if (day > 7)
                {
                    Console.WriteLine("Uncorrect value, try again");
                    Console.WriteLine("Enter day number on week: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }

                if (day == i)
                {
                    week_day = week[i - 1];
                    break;
                }

            }
            flight_number = number;
            ref int NumPointer = ref flight_number;
            leave_time = time;
        }

        public Airline(out int result, ref int num, string location)
        {
            result = num + 1;

        }
        static Airline()
        {
            flight_num = 457;
            if (flight_num == 457)
            {
                type = "Il-86";
            }
            else
                type = "Ty-134";
        }

        public void Print()
        {
            Console.WriteLine($"Destination: {destination}, flight number: {flight_number}, type of plane - {plane_type}, day {week_day}, leave time {leave_time}");
            Console.WriteLine("Counter: " + count);
        }
        static public void PrintCounter()
        {
            Console.WriteLine("Counter: " + Airline.count.ToString());
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return (flight_number / count);
        }

        public override string ToString()
        {
            return PLACE;
        }
        
    }

    class A
    {
        private string place;
        A() { }
        public string Place
        {
            get { return place; }
            private set { place = value; }
        }

        public void PrintA()
        {
            Console.WriteLine("Place is {0}", Place);
        }
    }
    public partial class B
        {
            public void B1()
            {
                Console.WriteLine("This is part 1");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 557;
            Airline var1 = new Airline();
            Airline var2 = new Airline(2, "Berlin", ref n, "02:45", "Ty-134");
            Airline var3 = new Airline("Il-86");
            B var4 = new B();
            Airline.PrintCounter();
            //Console.WriteLine();

            var1.Print();
            var2.Print();
            var3.Print();
            Console.WriteLine(Airline.Type);
            var4.B1();
            var4.B2();

            /* A var4 = new A();*/
        }
    }
}
