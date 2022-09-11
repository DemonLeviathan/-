using System;

namespace lr_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool BooleanVariable = true;
            Console.WriteLine($"Boolean Variable: {BooleanVariable}");

            byte ByteVariable = 13;
            Console.WriteLine($"ByteVariable: {ByteVariable}");

            sbyte SbyteVariable = -47;
            Console.WriteLine($"SbyteVariable: {SbyteVariable}");

            Console.Write("Enter Char variable: ");
            char CharVariable = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Char variable: {CharVariable}");

            Console.Write("Enter Decimal variable: ");
            decimal DecimalVariable = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Decimal variable: {DecimalVariable}");

            double DoubleVariable = 74.256;
            Console.WriteLine($"Double variable: {DoubleVariable}");

            float FloatVariable = (float)DoubleVariable;
            Console.WriteLine($"Float variable: {FloatVariable}");

            short ShortVariable = 52;
            Console.WriteLine($"Short variable: {ShortVariable}");

            int IntVariable = ShortVariable;
            Console.WriteLine($"Int variable: {IntVariable}");

            long LongVariable = IntVariable;
            Console.WriteLine($"Long variable: {LongVariable}");

            Console.Write("Enter Uint variable: ");
            uint UintVariable = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"Uint variable: {UintVariable}");

            ulong UlongVariable = UintVariable;
            Console.WriteLine($"Ulong variable: {UlongVariable}");

            ushort UshortVariable = (ushort)UintVariable;
            Console.WriteLine($"Ushort variable: {UshortVariable}");

            int IntVariable2 = ByteVariable;
            Console.WriteLine($"Int variable 2: {IntVariable2}");

            int DoubleVariable2 = SbyteVariable;
            Console.WriteLine($"Double variable 2: {DoubleVariable2}");

            object BoxIntVariable = IntVariable;
            int UnboxIntVariable = (int)BoxIntVariable;

            object BoxBooleanVariable = BooleanVariable;
            bool UnboxBooleanVariable = (bool)BoxBooleanVariable;

            object BoxCharVariable = CharVariable;
            char UnboxCharVariable = (char)BoxCharVariable;

            object BoxFloatVariable = FloatVariable;
            float UnboxFloatVariable = (float)BoxFloatVariable;

            object BoxDoubleVariable = DoubleVariable;
            double UnboxDoubleVariable = (double)BoxDoubleVariable;

            var UnknowTypeVariable1 = 172;
            var UnknowTypeVariable2 = 'g';
            var UnknowTypeVariable3 = 15.7;
            Type type1 = UnknowTypeVariable1.GetType();
            Type type2 = UnknowTypeVariable2.GetType();
            Type type3 = UnknowTypeVariable3.GetType();
            Console.WriteLine("First variable type: {0}", type1);
            Console.WriteLine("Second variable type: {0}", type2);
            Console.WriteLine("Third variable type: {0}", type3);

            int? NullVariable = null;
            Console.WriteLine("Null variable: {0}", NullVariable);
            
        }
    }
}
