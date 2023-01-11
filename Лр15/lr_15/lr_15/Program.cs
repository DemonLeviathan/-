using System;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Console;

namespace lr_15
{
    partial class Programm
    {
        static void Main(string[] args)
        {
            Action action = new Action(SieveOfEratosthenes);
            Stopwatch stopwatch = Stopwatch.StartNew();
            task1 = Task.Factory.StartNew(action);
            task1.Wait();
            task1.Dispose();
            stopwatch.Stop();

            Console.WriteLine($"Task 1 completed: {task1.IsCompleted.ToString()}");
            Console.WriteLine($"Status: {task1.Status.ToString()}");
            Console.WriteLine($"Compliting time: {stopwatch.Elapsed}");

            Console.WriteLine("-------------------------------------------");

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            (task1 = new Task(action, tokenSource.Token)).Start();
            tokenSource.Cancel();

            Console.WriteLine($"Status: {task1.Status}");
            Console.WriteLine("Cancel token was work");

            Console.WriteLine("-------------------------------------------");

            Task<int>   rand1 = new Task<int>(Sum),
                        rand2 = new Task<int>(Mult),
                        rand3 = new Task<int>(Diff);
            rand1.Start();
            Console.WriteLine($"First value: {rand1.Result}");

            rand2.Start();
            Console.WriteLine($"Second value: {rand2.Result}");

            rand3.Start();
            Console.WriteLine($"Third value: {rand3.Result}");

            Task<int> result = new Task<int>(() => Average(rand1.Result, rand2.Result, rand3.Result));
            result.Start();
            Console.WriteLine($"Result value: {result.Result}");

            Console.WriteLine("-------------------------------------------");

            Task<int> con1 = new Task<int>(Sum);
            Task<int> con2 = con1.ContinueWith((task) => Mult());
            Task<int> con3 = con2.ContinueWith((task) => Diff());
            Task<int> con4 = con3.ContinueWith((task) => Average(con1.Result, con2.Result, con3.Result));
            con1.Start();

            Console.WriteLine($"First value: {con1.Result}");
            Console.WriteLine($"Second value: {con2.Result}");
            Console.WriteLine($"Third value: {con3.Result}");
            Console.WriteLine($"Result value: {con4.Result}");

            con1.Dispose();
            con2?.Dispose();
            con3?.Dispose();
            con4.Dispose();

            Task<int> wait = Task.Run(() => Enumerable.Range(1, 10000).Count(n => (n % 3 == 0)));
            TaskAwaiter<int> awaiter = wait.GetAwaiter();
            awaiter.OnCompleted(() => { int result = awaiter.GetResult();
                Console.WriteLine(result);
            });
            Console.WriteLine(awaiter.GetResult());
            Console.WriteLine("-------------------------------------------");

            Stopwatch sw = Stopwatch.StartNew();
            int[] ints1 = new int[1000000];
            int[] ints2 = new int[1000000];
            Random random = new Random();
            sw.Restart();

            for (int i = 0; i < ints1.Length; i++)
            {
                ints1[i] = random.Next(0, 100);
                ints2[i] = random.Next(0, 100);
            }

            sw.Stop();
            Console.WriteLine($"Time of compliting array through for: {sw.Elapsed}");

            sw.Restart();

            Parallel.ForEach<int>(ints1, (i) =>
            {
                ints1[i] = random.Next(0, 100);
                ints2[i] = random.Next(0, 100);
            });
            Console.WriteLine($"Time of compliting array through foreach: {sw.Elapsed}");

            Parallel.Invoke(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Parallel compliting of block 1: {i}");
                }
                Console.WriteLine("Block 1 in ready");
            },
            () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Parallel compliting of block 2: {i}");
                }
                Console.WriteLine("Block 2 in ready");

            });
            Console.WriteLine("-------------------------------------------");

            block = new BlockingCollection<string>(5);
            Task Shop = new Task(AddProduct);
            Task Client = new Task(PurchasedProduct);
            Shop.Start();
            Client.Start();
            Shop.Wait();
            Client.Wait();

            Console.WriteLine("-------------------------------------------");

            Async();
            string it = Console.ReadLine();
            Console.WriteLine($"{it} {it} {it} Enter... ");
            ReadKey();
        }
    }
}
