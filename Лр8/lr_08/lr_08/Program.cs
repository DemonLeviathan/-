using System;
using static lr_08.User;

namespace lr_08
{
    public class Programm
    {
        static string result = "";

        static string DeleteSpace(string str) // 1
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }

        static string DeleteSeparator(string str) // 2
        {
            result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == ',') || (str[i] == ':') || (str[i] == ';') || (str[i] == '.') || (str[i] == '-'))
                {
                    continue;
                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }

        static string AddSymbol(string str) // 3
        {
            result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 's')
                {
                    result += '*';
                }
                else
                {
                    result += '$';
                }
            }
            return result;
        }

        static string UpperCase(string str) // 4
        {
            str = str.ToUpper();
            return str;
        }

        static string ConcatWithSlash(string str1, string str2) // 5
        {
            result = str1 + "|" + str2;
            return result;
        }

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

            Console.WriteLine("---------------------------");

            Func<string, string> func1 = DeleteSpace;
            Console.WriteLine(func1("string without spaces"));

            Func<string, string> func2 = DeleteSeparator;
            Console.WriteLine(func2("string, without separators: no comma; no - dot."));

            Func<string, string> func3 = AddSymbol;
            Console.WriteLine(func3("string str s"));

            Func<string, string> func4 = UpperCase;
            Console.WriteLine(func4("string in upper case"));

            Func<string, string, string> func5 = ConcatWithSlash;
            Console.WriteLine(func5("part1", "part2"));
        }
    }
}