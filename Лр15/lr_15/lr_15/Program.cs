using System;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

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
        }
    }
}
