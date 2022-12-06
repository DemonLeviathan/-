using System;
using static lr_08.User;

namespace lr_08
{
    public class Programm
    {
        static void Main(string[] args)
        {
            User user1 = new User(155);
            User user2 = new User("disk C");
            User user3 = new User(255);
            User user4 = new User("disk E");

            user1.Compression(200);
            Console.WriteLine($"File weight {user1.Weight}");
            user2.Movement("dick D");
            Console.WriteLine($"Users file was moved to {user2.Location}");

            user3.Compression(743);
            Console.WriteLine($"File weight {user3.Weight}");
            user4.Movement("recycle bin");
            Console.WriteLine($"Users file was moved to {user4.Location}");

            //user1.Compress += Compression;
        }
    }
}