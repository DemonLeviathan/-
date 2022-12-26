using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lr_11
{
    static public class Reflector
    {
        static public void GetName(object obj)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType(obj.ToString());
            Assembly assembly1 = type.Assembly;
            Console.WriteLine("Name: {0}, CodeBase: {1}", assembly1.FullName, assembly1.CodeBase);
        }

        static public void IsConstructurs(object obj)
        {
            ConstructorInfo constructor = obj.GetType().GetConstructor(Type.EmptyTypes);
            if (constructor != null)
            {
                Console.WriteLine("Constucturs is");
            }
            else
            {
                Console.WriteLine("No constructures");
            }
        }

        static public void GetMethod(object obj)
        {
            Type type = Type.GetType(obj.ToString());
            foreach (MethodInfo info in type.GetMethods())
            {
                Console.WriteLine(info.Name);
            }
        }

        static public void GetField(object obj)
        {
            Type type = Type.GetType(obj.ToString());

            foreach (FieldInfo fieldInfo in type.GetFields())
                Console.WriteLine(fieldInfo);
            foreach (PropertyInfo propertyInfo in type.GetProperties())
                Console.WriteLine(propertyInfo);
        }

        static public void GetInterface(object obj)
        {
            Type type = Type.GetType(obj.ToString());

            foreach (Type interface1 in type.GetInterfaces())
            {
                Console.WriteLine(interface1);
            }
        }

        static public void PrintMethod(object obj, string parm)
        {
            Type type = Type.GetType(obj.ToString());

            MethodInfo[] method = type.GetMethods();
            Console.WriteLine("Method from {0} with parameters {1}", obj, parm);

            for (int i = 0; i < method.Length; i++)
            {
                ParameterInfo[] parameters = method[i].GetParameters();
                for (int j = 0; j < parameters.Length; j++)
                {
                    //Console.WriteLine(parameters[j].ToString());
                    if (parm == parameters[j].ParameterType.Name)
                        Console.WriteLine(method[i].Name);
                }
            }
        }

        static public void Invoke(string name, string generate)
        {
            Type type = Type.GetType(name);

            List<string> args = File.ReadAllLines("D:\\Универ\\3-й семестр\\Лабы ООП\\Лр11\\lr_11\\lr_11\\in.txt").ToList();
            List<string>[] args2 = new List<string>[] { args };

            try
            {
                object obj = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod(generate);
                Console.WriteLine(method.Invoke(obj, args2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Create(string currentClassName, string parm)
        {
            Type type = Type.GetType(currentClassName);
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            object obj = Activator.CreateInstance(type, args: parm);
            Console.WriteLine(obj.ToString());
        }

        public static void InfoToFile(string obj)
        {
            Type type = Type.GetType(obj.ToString());
            string path = "D:\\Универ\\3-й семестр\\Лабы ООП\\Лр11\\lr_11\\lr_11\\reflector.txt";
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine($"-----------------{obj}-----------------");
                sw.WriteLine($"Assembly:" + type.Assembly);
                foreach (ConstructorInfo constructorInfo in type.GetConstructors())
                    sw.WriteLine(constructorInfo);
                sw.WriteLine($"Methodds:");
                foreach (MethodInfo methodInfo in type.GetMethods())
                    sw.WriteLine(methodInfo.Name);
                sw.WriteLine($"Fields and properties:");
                foreach (FieldInfo fieldInfo in type.GetFields())
                    sw.WriteLine(fieldInfo);
                foreach (PropertyInfo propertyInfo in type.GetProperties())
                    sw.WriteLine(propertyInfo);
                sw.WriteLine($"Interfaces:");
                foreach (Type interfaceMapping in type.GetInterfaces())
                    sw.WriteLine(interfaceMapping);
                sw.WriteLine();
            }
        }
    }
}
