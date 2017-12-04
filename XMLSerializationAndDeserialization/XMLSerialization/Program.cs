using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace XMLSerialization
{

    public class Program : Car
    {
        public static List<Car> carlist = new List<Car>();

        public static void Main(string[] args)
        {


            //SerializeXML();
            //DeserializeXML();
            SerializeToBinary();

        }

        //Directory.CreateDirectory(@"D:\XMLSERIALIZATION\");
        //File.Create(@"D:\XMLSERIALIZATION\xmlserializaton.xml");

        public static void SerializeXML()
        {


            carlist.AddRange(new Car[]
            {
                new Car {Brand = "MERCEDES",Model = "S-CLASS",Yearofmanufacturing = 2001 },
                new Car {Brand = "BMW",Model = "COUPET",Yearofmanufacturing = 1998 },
                new Car {Brand = "MERCEDES",Model = "BENZ",Yearofmanufacturing = 2008 },
                new Car {Brand = "RENAULT",Model = "CLIO",Yearofmanufacturing = 2010 },
                new Car {Brand = "VOLKSWAGEN",Model = "PASSAT",Yearofmanufacturing = 1995 },
                new Car {Brand = "SHEVROLET",Model = "CAPTIVA",Yearofmanufacturing = 2011 },

            });




            using (StreamWriter writer = new StreamWriter(@"D:\XMLSERIALIZATION\xmlserializaton.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                serializer.Serialize(writer, carlist);
            }
        }

        public static void DeserializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));

            using (StreamReader reader = new StreamReader(@"D:\XMLSERIALIZATION\xmlserializaton.xml"))
            {

                var cars = (List<Car>)serializer.Deserialize(reader);

                foreach (var element in cars)
                {
                    Console.WriteLine($"{element.Brand} {element.Model} {element.Yearofmanufacturing}");
                }
            }
        }



        public static void SerializeToBinary()
        {

            //Directory.CreateDirectory(@"D:\BINARYFORMATTING");

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream file = new FileStream(@"D:\BINARYFORMATTING\binaryformat.bin", FileMode.Open))
            {
                formatter.Serialize(file, carlist);
            }

        }
    }
}

            
  







    


 

