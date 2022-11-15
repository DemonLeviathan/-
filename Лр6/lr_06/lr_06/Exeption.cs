using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_06
{
    public class FighterExeption : System.Exception
        {
            public string Error { get; set; }
            public FighterExeption(string message, string value)
                : base(message)
            {
                this.Error = value;
            }

        }
 
    public class DamageExeption : FighterExeption
    {
        private int damage;
        public string weapon { get; set; } = "";
        public string skill1 { get; set; } = "";
        public int ID { get; set; } = 0;

        public int Damage 
        { 
            get => damage;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Damage can't be less than 0");
                }
                else
                {
                    damage = value;
                }
            }
        }
        public DamageExeption(string message, int value)
            : base(message, "Error #1: Uncorrect number of damage")
        {
            this.Damage = value;
        }
    }

    class IDExeption : FighterExeption
    {
        public int IDExe { get; set; }
        public IDExeption(string message, int value)
            : base(message, "Error #2: Uncorrect ID")
        {
            this.IDExe = value;
        }

    }

    public class DateExeption : FighterExeption
    {
        public int Year { get; set; }
        public DateExeption(string message, int erroryear)
            : base(message, "Error code 1: Uncorrect date")
        {
            this.Year = erroryear;
        }
    }

    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(FighterExeption exeption)
        {
            DamageExeption damageEx = exeption as DamageExeption;
            IDExeption IDEx = exeption as IDExeption;
            DateExeption dateEx = exeption as DateExeption;

            string filePath = @"D:\Универ\3-й семестр\Лабы ООП\Лр6\lr_06\lr_06\log.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
            streamWriter.WriteLine(DateTime.Now);

            if (dateEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", dateEx.Error, dateEx.Message, dateEx.Year);
            }

            if (damageEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", damageEx.Error, damageEx.Message, damageEx.Damage);
            }

            if (IDEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", IDEx.Error, IDEx.Message, IDEx.IDExe);
            }
        }
    }

    public class ConsoleLogger
    {
        public ConsoleLogger() { }

        public void WriteLog(FighterExeption exeption)
        {
            DamageExeption damageEx = exeption as DamageExeption;
            IDExeption IDEx = exeption as IDExeption;
            DateExeption dateEx = exeption as DateExeption;

            Console.WriteLine(DateTime.Now);

            if (dateEx != null)
            {
                Console.WriteLine("{0}{1} {2}", dateEx.Error, dateEx.Message, dateEx.Year);
            }

            if (damageEx != null)
            {
                Console.WriteLine("{0}{1} {2}", damageEx.Error, damageEx.Message, damageEx.Damage);
            }

            if (IDEx != null)
            {
                Console.WriteLine("{0}{1} {2}", IDEx.Error, IDEx.Message, IDEx.IDExe);
            }
        }
    }
}
