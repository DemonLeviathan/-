using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;

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
    }
}