using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_08
{
    public class User
    {
        //UserMessage userMessage = Add;
        /*void Add(int x) => Console.WriteLine("w");*/
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

       /* public delegate void Message();
        
        public void MessageofCompression() => Console.WriteLine("Compression completed");
        public void MessegeofMovement() => Console.WriteLine("Movement completed");

        Message message = MessageofCompression;
        message();*/

        //public void Compression(int weight) => Weight = weight / 2; 

        public delegate void UserMessage(string message);
        event UserMessage? Move;
        public event UserMessage? Compress;

        string result = "";

        //delegate bool Predicate<in T>(T obj);
    }
}
