using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;

namespace lr_13
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Hunter hunter = new Hunter("gun", "shot", 1);
            Shaman shaman = new Shaman("book of curses", "curse", 2);
            Archer archer = new Archer("bow", "firebolt", 3);
            Psychic psychic = new Psychic("tarot", "mind capture", 4);

            /* XmlDocument xml = new XmlDocument();
             xml.Load(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Xml.xml");
             XmlElement xmlElement = xml.DocumentElement;

             XmlNodeList nodeList = xmlElement.SelectNodes("Fighters");
             foreach (XmlNode x in nodeList)
             {
                 Console.WriteLine(x.InnerText);
             }*/

            
        }
    }
}