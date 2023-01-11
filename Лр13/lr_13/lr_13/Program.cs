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

            //Serializer.SerializeAll(shaman);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\XML.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList childnodes = xRoot.SelectNodes("Hunter");//SelectNodes(): выборка по запросу коллекции узлов в виде объекта XmlNodeList
            foreach (XmlNode n in childnodes)//XPath
            {
                Console.WriteLine(n.InnerText);//InnerText возвращает текстовое значение узла
            }

            XmlNodeList childnode = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnode)
            {
                Console.WriteLine(n.Name); //Name возвращает название узла.
            }

            XDocument xdoc = new XDocument();
            XElement person1 = new XElement("person");
            XAttribute NameAttr1 = new XAttribute("name", "Ваня");
            XElement SurElem1 = new XElement("surname", "Иванов");
            XElement AgeElem1 = new XElement("age", 37);
            person1.Add(NameAttr1);
            person1.Add(SurElem1);
            person1.Add(AgeElem1);


            XElement person2 = new XElement("person");
            XAttribute NameAttr2 = new XAttribute("name", "Вася");
            XElement SurElem2 = new XElement("surname", "Петров");
            XElement AgeElem2 = new XElement("age", 41);
            person2.Add(NameAttr2);
            person2.Add(SurElem2);
            person2.Add(AgeElem2);

            // создаем корневой элемент
            XElement people = new XElement("people");
            people.Add(person1);
            people.Add(person2);
            xdoc.Add(people);
            xdoc.Save(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\NewXML.xml");

            Console.WriteLine("Введите возраст для поиска");
            string ageXML = Console.ReadLine();
            var allAlbums = people.Elements("person");

            foreach (var item in allAlbums)
            {
                if (item.Element("age").Value == ageXML)
                {
                    Console.WriteLine(item.Value);
                }
            }

            Console.WriteLine("Введите имя для поиска");
            string nameXML = Console.ReadLine();
            foreach (var item in allAlbums)
            {
                if (item.Attribute("name").Value == nameXML)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}

