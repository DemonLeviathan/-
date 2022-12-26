using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lr_11
{
    public class Person
    {
        public string name;
        public string Name 
        { 
            get { return name;}
            set { name = value; } 
        }
        public Person(string name) => Name = name;
        public Person()
        { }

        public void ToConsole(List<string> vs)
        {
            foreach (string str in vs)
                Console.WriteLine(str);
        }

        public override string ToString()
        {
            return "Task: My name - " + name;
        }
    }
    public class User
    {
        public User(int weight) => Weight = weight;
        public User(string location) => Location = location;
        public int Weight { get; set; }
        public string Location { get; set; }

        public void Compression(int weight)
        {
            Weight = weight / 2;
            Compress?.Invoke($"Compressed weight of file is {Weight}");
        }

        public void Movement(string location)
        {
            Location = location;
            Move?.Invoke($"New file location is {Location}");
        }

        public delegate void UserMessage(string message);
        event UserMessage? Move;
        public event UserMessage? Compress;

        string result = "";
    }

    public class Book
    {
        public Book()
        { }

        public string Name { get; set; }
        public Book(string name) => Name = name;
    }
}
