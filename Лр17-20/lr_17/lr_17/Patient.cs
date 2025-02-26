﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class Patient : Symptoms, IPatient
    {
        public string Name { get; set; }
        public Patient(string Name)
        {
            this.Name = Name;
        }

        public int pain_lvl;
        public void Tell(string semp)
        {
            Console.WriteLine(semp);
        }

        Disease product = new Disease();
        public override void Symp1()
        {
            this.Disease.Nurse = new Nurse { Analis = "Sneezing" };
        }
        public override void Symp2()
        {
            this.Disease.Hospital = new Hospital { Deag = "Cough" };
        }

        // ------------

        public IPatient Clone()
        {
            return new Patient(Name);
        }
        public void GetInfo()
        {
            Console.WriteLine("Patient {0}", Name);
        }
        //--------------------Adapter-----------
        public void Ache(IDoctor transport)
        {
            transport.Treat();
        }

    }
}
