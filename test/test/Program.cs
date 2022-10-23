using System;

namespace test
{
    public partial class Profile : IPossible, IComparable
    {
        public string username = "user1";
        public string password = "password";
        public string email = "email.gmail";
        public string otherusername = "user2";


        public Profile(string username, string password, string email)
        {

        }
        public Profile(string iusername)
        {
            this.username = iusername;
        }
        public static bool operator ==(Profile user1, Profile user2)
        {
            if (user1.username == user2.username)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Profile user1, Profile user2)
        {
            if (user1.username == user2.username)
            {
                return false;
            }
            else
                return true;
        }
        public void Profile1(string username, string password, string email)
        {
            if (username != "user1")
            {
                Console.WriteLine("Uncorrect username, try again");
            }

            else if (password != "password")
            {
                Console.WriteLine("Uncorrect password, try again");
            }

            else if (email != "email.gmail")
            {
                Console.WriteLine("Uncorrect email, try again");
            }

            else
            {
                Console.WriteLine("Corrert");
            }
        }

        public bool Check()
        {
            return password.Length < 8;
        }

        public int CompareTo(object obj)
        {
            Profile profile = obj as Profile;
            return username.CompareTo(profile.username);
        }
    }

    interface IPossible
    {
        bool Check();
    }
    class Programm
    {
        static void Main(string[] args)
        {
            float max = float.MaxValue;
            int min = int.MinValue;
            float diff = max - min;
            Console.WriteLine($"Difference: {diff}");

            string[,] Array = { {"aaa", "bbb", "ccc" }, {"ddd", "eee", "fff" } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{Array[i, j]}" + " ");
                }
                Console.WriteLine();
            }

            Profile var1 = new Profile("user1", "password", "email.gmail");
            Profile var2 = new Profile("user2", "password", "email.gmail");
            Profile var3 = new Profile("password");
            var1.Equals(var2);
            var1.Profile1("user1", "password", "email.gmail");
            var3.Profile2("password");

            Profile[] profiles = new Profile[3];
            profiles[0] = new Profile("user1", "password", "email.gmail");
            profiles[1] = new Profile("user2", "pass_word", "email1.gmail");
            profiles[2] = new Profile("user3", "pass__word", "email2.gmail");
            
        }
    }
}