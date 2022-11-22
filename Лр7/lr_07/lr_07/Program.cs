using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace lr_07
{
    public class ClassArray
    {
        public ClassArray()
        {

        }
        public char[] charArray;

        public char this[char Index]
        {
            get { return charArray[Index]; }
            set { charArray[Index] = value; }
        }

        public ClassArray(char[] icharArray)
        {
            this.charArray = icharArray;
        }

        // overload


        public static ClassArray operator -(ClassArray array1, ClassArray array2)
        {

            ClassArray difArray = new ClassArray(new char[array1.charArray.Length]);

            Array.Resize(ref array1.charArray, array1.charArray.Length + array2.charArray.Length);
            Array.Copy(array2.charArray, 0, array1.charArray, array1.charArray.Length - array2.charArray.Length, array2.charArray.Length);

            for (int i = 0; i < array1.charArray.Length; i++)
            {
                array1.charArray[i] -= 'a';
            }

            return array1;
        }

        public static ClassArray operator +(ClassArray array1, ClassArray array2)
        {
            Array.Resize(ref array1.charArray, array1.charArray.Length + array2.charArray.Length);
            Array.Copy(array2.charArray, 0, array1.charArray, array1.charArray.Length - array2.charArray.Length, array2.charArray.Length);

            return array1;
        }

        public static bool operator >(ClassArray array1, ClassArray array2)
        {
            for (int i = 0; i < array1.charArray.Length; i++)
            {
                if ((array1.charArray[i] == 'p') && (array2.charArray[i] == 'g'))
                {
                    return false;
                }

            }
            return true;

        }

        public static bool operator <(ClassArray array1, ClassArray array2)
        {
            for (int i = 0; i < array1.charArray.Length; i++)
            {
                if ((array1.charArray[i] == 'y') && (array2.charArray[i] == 't'))
                {
                    return true;
                }

            }
            return false;
        }

        public static bool operator ==(ClassArray array1, ClassArray array2)
        {
            for (int i = 0; i < array1.charArray.Length; i++)
            {
                if (array1.charArray.SequenceEqual(array2.charArray))
                    return true;
            }
            return false;
        }

        public static bool operator !=(ClassArray array1, ClassArray array2)
        {
            for (int i = 0; i < array1.charArray.Length; i++)
            {
                if (array1.charArray.SequenceEqual(array2.charArray))
                    return false;
            }
            return true;
        }

        public void Print()
        {
            Console.WriteLine();
        }

    }

    public class Production
    {
        public int ID;
        public string Organization;

        public Production(int id, string org)
        {
            this.ID = id;
            this.Organization = org;
        }

        public void Print()
        {
            Console.Write("Organization: " + Organization + "  ");
        }
        public class Developer
        {
            public string developer;
            public int ID;
            public string department;

            public Developer(string dev, int id, string dep)
            {
                this.ID = id;
                this.department = dep;
                this.developer = dev;
            }

            public void Print()
            {
                Console.WriteLine("Department: {0}, developer: {1}", department, developer);
            }
        }


    }

    static class StatisticOperation
    {
        public static void Sum(int[] newIntArray)
        {
            Console.WriteLine(newIntArray.Sum());
        }

        public static void Difference(int[] newIntArray)
        {
            Console.WriteLine(newIntArray.Max() - newIntArray.Min());
        }

        public static void Counter(int[] newIntArray)
        {
            Console.WriteLine(newIntArray.Length);
        }

        public static string VowelsDeleting(string str)
        {
            str = Regex.Replace(str, "(?i)[aeyuio]", "");
            return str;
        }

        public static string FirstFiveElementsDeleting(string str)
        {
            str = str.Remove(0, 5);
            return str;
        }

    }

    class Programm
    {
        static void Main(string[] args)
        {
            ClassArray Array1 = new ClassArray(new char[] { 'p', 'r', 'o', 'g', 'r', 'a', 'm' });
            ClassArray Array2 = new ClassArray(new char[] { 'g', 'r', 'o', 'd', 'n', 'o' });
            ClassArray Array3 = Array1 + Array2;

            Console.WriteLine("Overload + : ");
            for (int i = 0; i < Array3.charArray.Length; i++)
            {
                Console.Write(Array3.charArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Overload - : ");
            ClassArray Array4 = Array1 - Array2;
            for (int i = 0; i < Array4.charArray.Length; i++)
            {
                Console.Write(Array4.charArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Overload == : ");
            if (Array1 == Array2)
                Console.WriteLine("The same arrays");
            else
                Console.WriteLine("The different arrays");
            Console.WriteLine();

            Console.WriteLine("Overload != : ");
            if (Array1 != Array2)
                Console.WriteLine("The different arrays");
            else
                Console.WriteLine("The same arrays");
            Console.WriteLine();

            Console.WriteLine("Overload > : ");
            if (Array1 > Array2)
                Console.WriteLine("Letters p and g in arrays");
            else
                Console.WriteLine("no p and g in arrays");
            Console.WriteLine();

            Console.WriteLine("Overload < : ");
            if (Array1 < Array2)
                Console.WriteLine("Letters y and t in arrays");
            else
                Console.WriteLine("no y and t in arrays");
            Console.WriteLine();

            Production Company = new Production(1765, "SpaceX");
            Production.Developer dev = new Production.Developer("Viktarovich I.", 15754, "development");

            /*Company.Print();
            dev.Print();*/

            int[] IntArray = new int[] { 13, 27, 33 };
            //Console.Write("Sum of elements:  ");
            //StatisticOperation.Sum(IntArray);
            //Console.WriteLine();

            //Console.Write("Difference between minimal and maxinal elements:  ");
            //StatisticOperation.Difference(IntArray);
            //Console.WriteLine();

            //Console.Write("Number of elements:  ");
            //StatisticOperation.Counter(IntArray);
            //Console.WriteLine();

            string str = "Software Engeneering";
            string printstring = StatisticOperation.VowelsDeleting(str);
            //Console.WriteLine("String without vowels:  {0}", printstring);

            //Console.WriteLine();
            string deletefiveelements = StatisticOperation.FirstFiveElementsDeleting(str);
            //Console.WriteLine("String after deleting first 5 elements: {0}", deletefiveelements);
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            try 
            {
                CollectionType<ClassArray> collectionType = new CollectionType<ClassArray>();
                //CollectionType<ClassArray> collectionType2 = new CollectionType<ClassArray>();
                CollectionType<string> collectionType1 = new CollectionType<string>();
                CollectionType<string> collectionType2 = new CollectionType<string>();
                CollectionType<string> collectionType3 = new CollectionType<string>();

                collectionType.Add(Array1 + Array2);
                collectionType.Add(Array2);
                collectionType.Add(Array3);
                //collectionType.Remove(Array4);
                //collectionType.See();
                
                collectionType1.Add("string 1");
                collectionType1.Add("srting 2");
                collectionType1.Add("string 3");
                collectionType1.Add("string 4");
                collectionType1.Add("string 5");
                collectionType1.See();

                CollectionType<int> collectionType4 = new CollectionType<int>();
                CollectionType<int> collectionType5 = new CollectionType<int>();
                collectionType5.Add(1);
                collectionType5.Add(2);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }


        }
    }
}