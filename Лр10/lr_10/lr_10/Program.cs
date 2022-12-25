using System;

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
        }
    }
}