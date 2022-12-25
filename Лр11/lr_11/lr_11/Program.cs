using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace lr_11
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Programm programm = new Programm();
            Console.WriteLine("Name of assembly");
            Reflector.GetName("lr_11.Person");
            Console.WriteLine("------------------------");
            Console.WriteLine("Is any constructors?: ");
            Reflector.IsConstructurs("lr_11.Person");
            Console.WriteLine("------------------------");

            Console.WriteLine("All public methods: ");
            Reflector.GetMethod("lr_11.Person");
            Console.WriteLine("------------------------");

            Console.WriteLine("Information about fields and class properties: ");
            Reflector.GetField("lr_11.Person");
            Console.WriteLine("------------------------");

            Console.WriteLine("Interfaces: ");
            Reflector.GetInterface("lr_11.Person");
            Console.WriteLine("------------------------");


            Console.WriteLine("Calling class method by invoke: ");
            Reflector.PrintMethod("lr_11.Person", "String");
            Console.WriteLine("------------------------");

        }
    }
}