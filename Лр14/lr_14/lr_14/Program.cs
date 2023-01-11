using System;
using System.Xml.Linq;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace lr_11
{
    public class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    Console.WriteLine($"ID: {process.Id} Name: {process.ProcessName}");
                    Console.WriteLine($"Priority: {process.BasePriority}");
                    //Console.WriteLine($"Start time: {process.StartTime}");
                    //Console.WriteLine($"Main module: {process.PrivilegedProcessorTime}");
                    //Console.WriteLine($"Total processor time: {process.TotalProcessorTime}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error #1: " + ex.Message);
            }

            Console.WriteLine("------------------------------------------------------");

            try
            {
                AppDomain domain = AppDomain.CurrentDomain;
                Console.WriteLine($"Name: {domain.FriendlyName}");
                Console.WriteLine($"Base directory: {domain.BaseDirectory}");

                Assembly[] assemblies = domain.GetAssemblies();
                foreach (Assembly assembly in assemblies)
                    Console.WriteLine(assembly.GetName().Name);

                MakeNewDomain();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error #2: " + ex.Message);
            }

            Console.WriteLine("------------------------------------------------------");

            try
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                Thread thread = new Thread(CountNums);
                thread.Name = "New stream";
                thread.Start(num);
                thread.Join();

                Thread thread1 = new Thread(CountOddNum) { Name = "OddNumbersThread", };
                Thread thread2 = new Thread(CountEvenNum) { Name = "EvenNumbersThread", };
                thread1.Start(num);
                thread2.Start(num);

                thread1.Join();
                thread2.Join();
                Console.WriteLine("-------------------------");

                File.WriteAllText("file3.txt", " ");

                Thread thread3 = new Thread(OddNum) { Name = "Odd" };
                Thread thread4 = new Thread(EvenNum) { Name = "Even" };
                thread3.Start(num);
                thread4.Start(num);
                thread3.Join();
                thread4.Join();

                Console.WriteLine("-------------------------");

                int number = 0;
                TimerCallback timer = new TimerCallback(Count);
                Timer timer1 = new Timer(timer, number, 0, 1000);
                Console.WriteLine("What time is it?");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error #3: " + ex.Message);
            }
        }

        static void MakeNewDomain()
        {
            AppDomain app = AppDomain.CreateDomain("DemoDomain");
            InfoDomain(app);
            AppDomain.Unload(app);
        }

        static void InfoDomain(AppDomain domain)
        {
            Console.WriteLine("---Info about new domain---");
            Console.WriteLine($"Name: {domain.FriendlyName}\n ID: {domain.Id}\n Location: {domain.BaseDirectory}");

            var context = new AssemblyLoadContext(name: domain.FriendlyName, isCollectible: true);
            Assembly assembly = context.LoadFromAssemblyPath(domain.BaseDirectory);
        }

        static void Count(object obj)
        {
            Console.WriteLine($"Time: {DateTime.Now.ToLongTimeString()}");
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void CountNums(object obj)
        {
            using (StreamWriter sw = new StreamWriter("file.txt", false))
            {
                sw.WriteLine("Simple numbers");
            }

            Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
            Console.WriteLine($"Thread priority: {Thread.CurrentThread.Priority.ToString()}");
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId.ToString()}");
            Console.WriteLine($"Thread status: {Thread.CurrentThread.ThreadState.ToString()}");

            if (obj is int n)
            {
                for (int i = 1; i < n; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                        using (StreamWriter sw = new StreamWriter("file.txt", true))
                        {
                            sw.WriteLine(i);
                            sw.Close();
                        }
                    }
                }
            }
        }
        static string locker = "null";
        static void CountOddNum(object obj)
        {
            lock (locker)
            {
                if (obj is int n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter("file2.txt", true))
                            {
                                sw.WriteLine(i);
                            }
                        }
                    }
                }
            }
        }

        static void CountEvenNum(object obj)
        {

            if (obj is int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        using (StreamWriter sw = new StreamWriter("file2.txt", true))
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
        }

        static void OddNum(object obj)
        {
            Monitor.Enter(locker);
            {
                if (obj is int n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter("file3.txt", true))
                            {
                                sw.WriteLine(i);
                            }
                        }
                    }
                }
            }
            Monitor.Exit(locker);
        }

        static void EvenNum(object obj)
        {
            if (obj is int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                        File.AppendAllText("file3.txt", $"{i} \n");
                    }
                }
            }
        }
    }
}