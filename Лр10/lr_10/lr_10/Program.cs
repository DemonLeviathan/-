using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lr_10
{
    public class Programm
    {
        static void Main(string[] args)
        {
            string[] month = { "December" , "January", "February", "March", "April", "May",  "September", "October", "November", "June", "July", "Auguast", };

            var selectedbylength = from m in month where m.Length == 5 select m;

            Console.WriteLine("Selected by length: ");
            foreach (string monthstr in selectedbylength)
            {
                Console.WriteLine(monthstr);
            }
            Console.WriteLine("-----------------------");

            Console.WriteLine("Selected summer and winter months: ");
            var selected_summer_winter_month = from m in month where Array.IndexOf(month, m) < 3 || Array.IndexOf(month, m) > 8 select m;
            foreach (string monthstr in selected_summer_winter_month)
            {
                Console.Write(monthstr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Selection by alphabet: ");
            var selectedinalphabet = from m in month  orderby m select m;
            foreach (string monthstr in selectedinalphabet)
            {
                Console.Write(monthstr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Selected with u: ");
            var selectedcontainsU = month.Where(m => m.ToLower().Contains("u"));
            foreach (string monthstr in selectedcontainsU)
            {
                Console.Write(monthstr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Selected with name length longer than 3: ");
            var selectednamelength = month.Where(m => m.Length > 3);
            foreach (string monthstr in selectednamelength)
            {
                Console.Write(monthstr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            // ========================================
            Airline airline = new Airline(2, "Berlin", 2, 2, "Ty-134");
            Airline airline1 = new Airline(4, "London", 4, 19, "Ty-134");
            Airline airline2 = new Airline(3, "Stokholm", 3, 22, "Ty-134");
            Airline airline3 = new Airline(1, "Luxemburg", 1, 17, "Ty-134");
            Airline airline4 = new Airline(7, "Oslo", 7, 6, "Ty-134");
            Airline airline5 = new Airline(7, "Paris", 7, 10, "Ty-134");
            Airline airline6 = new Airline(6, "Praga", 6, 11, "Ty-134");
            Airline airline7 = new Airline(3, "Madrid", 3, 15, "Ty-134");
            Airline airline8 = new Airline(3, "Gamburg", 5, 2, "Ty-134");
            Airline airline9 = new Airline(5, "Leipzig", 5, 19, "Ty-134");

            List<Airline> airlines = new List<Airline>();

            airlines.Add(airline);
            airlines.Add(airline1);
            airlines.Add(airline2);
            airlines.Add(airline3);
            airlines.Add(airline4);
            airlines.Add(airline5);
            airlines.Add(airline6);
            airlines.Add(airline7);
            airlines.Add(airline8);
            airlines.Add(airline9);

            var selectflight = airlines.Where(a => a.destination.Contains("Leipzig"));
            foreach (var flight in selectflight)
            {
                Console.Write(flight.destination + " - " + flight.week_day + " " + flight.leave_time);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            var selectflight1 = from a in airlines where a.week_day == "Monday" select a;
            var selectflight4 = from a in airlines where a.week_day == "Wednesday" || a.week_day == "Friday" select a;
            var selectflight2 = from f in selectflight1 where f.leave_time < 20 select f;
            var selectflight3 = from f in selectflight4 where f.leave_time > 17 select f;
            foreach (var flight in selectflight2)
            {
                Console.Write(flight.destination + " - " + flight.week_day + " " + flight.leave_time);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            foreach (var flight in selectflight3)
            {
                Console.Write(flight.destination + " - " + flight.week_day + " " + flight.leave_time + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            var orderbytime = airlines.OrderBy(a => a.leave_time);
            foreach (var flight in orderbytime)
            {
                Console.Write(flight.destination + " - " + flight.week_day + " " + flight.leave_time + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            /*foreach (var elem in airlines)
            {
                Console.WriteLine(elem);
            }*/
        }
    }
}