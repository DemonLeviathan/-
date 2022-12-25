using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_10
{
    public class Airline
    {
        public string destination;
        public int flight_number;
        public string plane_type;
        public int leave_time;
        public string week_day;
        public string[] week = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sutarday", "Sunday" };
        static int flight_num;
        static string type;
        public static int Flight_num => flight_num;
        public static string Type => type;
        public readonly string place = "Riga";
        public readonly string IdDestination;
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
            leave_time = 18;
        }

        public Airline(int day, string location, int number, int time, string type) // 2
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

        public Airline(string type, string location = "London", int day = 7, int number = 457, int time = 9) // 3 
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
    }
}
