using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;

namespace lr_13
{
    public class Serializer
    {
        public static void ToBinary<T>(T obj) where T : class // Serialization to binary
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Binary.bin", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, obj);
            }
        }

        public static void FromBinary<T>(ref T container) where T : class // Deserialization from binary
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Binary.bin", FileMode.OpenOrCreate))
            {
                container = binaryFormatter.Deserialize(fileStream) as T;
            }
        }

        public static void ToSoap<T>(T obj) where T : class // Serialization to soap
        {
            var soapFormatter = new SoapFormatter();
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Soap.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fileStream, obj);
            }
        }

        public static void FromSoap<T>(ref T container) where T : class // Deserialization from Soap
        {
            var soapFormatter = new SoapFormatter();
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Soap.soap", FileMode.OpenOrCreate))
            {
                container = soapFormatter.Deserialize(fileStream) as T;
            }
        }

        public static void ToJSON<T>(T obj) where T : class // Serialization to JSON
        {
            var jsonFormatter = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string serialized = JsonConvert.SerializeObject(obj, jsonFormatter);

            using (var fileStream = new StreamWriter(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\json.json"))
            {
                fileStream.Write(serialized);
            }
        }

        public static void FromJSON<T>(ref T container) where T : class // Deserialization from JSON
        {
            var jsonFormatter = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            using (var fileStream = new StreamReader(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\json.json"))
            {
                string json = fileStream.ReadToEnd();
                container = JsonConvert.DeserializeObject<T>(json, jsonFormatter);
            }
        }

        public static void ToXML<T>(T obj) where T : class // Serialization to XML
        {
            var xmlFormatter = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Xml.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fileStream, obj);
            }
        }

        public static void FromXML<T>(ref T container) where T : class // Deserialization to XML
        {
            var xmlFormatter = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\Универ\3-й семестр\Лабы ООП\Лр13\lr_13\lr_13\Xml.xml", FileMode.OpenOrCreate))
            {
                container = xmlFormatter.Deserialize(fileStream) as T;
            }
        }

        public static void SerializeAll<T>(T obj) where T : class
        {
            ToBinary(obj);
            ToSoap(obj);
            ToJSON(obj);
            ToXML(obj);
        }

        public static void DeserializeAll<T>(ref T container) where T : class
        {
            FromBinary(ref container);
            FromSoap(ref container);
            FromJSON(ref container);
            FromXML(ref container);
        }
    }
}

