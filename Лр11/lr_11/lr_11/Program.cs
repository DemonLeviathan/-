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
            User user = new User(17);
            Book book = new Book();
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
            Console.WriteLine("------------------------------------------------------");


            Console.WriteLine("Name of assembly");
            Reflector.GetName("lr_11.User");
            Console.WriteLine("------------------------");
            Console.WriteLine("Is any constructors?: ");
            Reflector.IsConstructurs("lr_11.User");
            Console.WriteLine("------------------------");

            Console.WriteLine("All public methods: ");
            Reflector.GetMethod("lr_11.User");
            Console.WriteLine("------------------------");

            Console.WriteLine("Information about fields and class properties: ");
            Reflector.GetField("lr_11.User");
            Console.WriteLine("------------------------");

            Console.WriteLine("Interfaces: ");
            Reflector.GetInterface("lr_11.User");
            Console.WriteLine("------------------------");


            Console.WriteLine("Calling class method by invoke: ");
            Reflector.PrintMethod("lr_11.User", "String");
            Console.WriteLine("-----------------------------------------------------");


            Console.WriteLine("Name of assembly");
            Reflector.GetName("lr_11.Book");
            Console.WriteLine("------------------------");
            Console.WriteLine("Is any constructors?: ");
            Reflector.IsConstructurs("lr_11.Book");
            Console.WriteLine("------------------------");

            Console.WriteLine("All public methods: ");
            Reflector.GetMethod("lr_11.Book");
            Console.WriteLine("------------------------");

            Console.WriteLine("Information about fields and class properties: ");
            Reflector.GetField("lr_11.Book");
            Console.WriteLine("------------------------");

            Console.WriteLine("Interfaces: ");
            Reflector.GetInterface("lr_11.Book");
            Console.WriteLine("------------------------");


            Console.WriteLine("Calling class method by invoke: ");
            Reflector.PrintMethod("lr_11.Book", "String");
            Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine("Name of assembly");
            //Reflector.GetName("lr_11.Object");
            //Console.WriteLine("------------------------");
            Console.WriteLine("Is any constructors?: ");
            Reflector.IsConstructurs("System.Object");
            Console.WriteLine("------------------------");

            Console.WriteLine("All public methods: ");
            Reflector.GetMethod("System.Object");
            Console.WriteLine("------------------------");

            Console.WriteLine("Information about fields and class properties: ");
            Reflector.GetField("System.Object");
            Console.WriteLine("------------------------");

            Console.WriteLine("Interfaces: ");
            Reflector.GetInterface("System.Object");
            Console.WriteLine("------------------------");


            Console.WriteLine("Calling class method by invoke: ");
            Reflector.PrintMethod("System.Object", "String");
            Console.WriteLine("-----------------------------------------------");

            Reflector.InfoToFile("lr_11.Person");
            Reflector.InfoToFile("lr_11.User");
            Reflector.InfoToFile("lr_11.Book");

            Reflector.Invoke("lr_11.Person", "ToConsole");
            Console.WriteLine();
            Reflector.Create("lr_11.Person", "Student");
        }
    }
}