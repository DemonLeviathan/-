﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    partial class Program
    {
        class Singleton
        {
            private static Singleton instance;

            private Singleton()
            { }

            public static Singleton getInstance()
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        class App
        {
            public Settings Settings;
            public void SetOptions(string[] op)
            {
                Settings = Settings.getInstance(op);
            }
        }

        class Settings
        {
            private static Settings instance;

            public string[] Options { get; private set; }


            protected Settings(string[] options)
            {
                Options = options;
            }

            public static Settings getInstance(string[] options)
            {
                if (instance == null)
                    instance = new Settings(options);
                return instance;
            }

            public string Show()
            {
                return $"Background color {Options[0]}, text color {Options[1]}, text size {Options[2]}";
            }
        }

    }
}
