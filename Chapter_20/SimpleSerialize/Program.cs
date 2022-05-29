using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using SimpleSerialize;


namespace SimpleSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");

            JamesBondCar jbc = new()
            {
                CanFly = true,
                CanSubmerge = false,
                TheRadio = new()
                {
                    StationPresets = new() { 89.3, 105.1, 97.1 },
                    HasTweeters = true
                }
            };
            
            Person p = new()
            {
                FirstName = "James",
                IsAlive = true
            };
            //
            // SaveAsXmlFormat(jbc, "CarData.xml");
            // Console.WriteLine("=> Saved car in XML format!");
            //
            // SaveAsXmlFormat(p, "PersonData.xml");
            // Console.WriteLine("=> Saved person in XML format!");
            
            //SaveListOfCarsAsXml();
            // List<JamesBondCar> cars = ReadAsXmlFormat<List<JamesBondCar>>("CarCollection.xml");
            // cars.ForEach(Console.WriteLine);
            
            SaveAsJsonFormat(jbc,"CarData.json");
            Console.WriteLine("=> Saved car in JSON format!");
            
            SaveAsJsonFormat(p, "PersonData.json");
            Console.WriteLine("=> Saved person in JSON format!");

        }

        static void SaveAsXmlFormat<T>(T objGraph, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));

            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }

        static void SaveListOfCarsAsXml()
        {
            List<JamesBondCar> myCars = new() { new JamesBondCar {CanFly = true, CanSubmerge = true}, new JamesBondCar {CanFly = true, CanSubmerge = true}, new JamesBondCar {CanFly = true, CanSubmerge = true}};

            using (Stream fStream = new FileStream("CarCollection.xml", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
                xmlFormat.Serialize(fStream,myCars);
            }

            Console.WriteLine("=> Saved list of cars!");
        }

        static T ReadAsXmlFormat<T>(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));

            using Stream fStream = new FileStream(fileName, FileMode.Open);
            T obj = default;
            obj = (T)xmlFormat.Deserialize(fStream);
            return obj;
        }

        static void SaveAsJsonFormat<T>(T objGraph, string fileName)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IncludeFields = true, WriteIndented = true};
            File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));
        }
    }
}