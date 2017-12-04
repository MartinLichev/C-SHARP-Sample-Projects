using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HomeWork18
{
    public class Program: Student
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"      PROGRAM FOR DOING SERIALIZATION AND DESERIZLIZATION WITH ""XML"" AND ""JSON"" ");
            Console.WriteLine("\n===================================================================================");


            //Directory.CreateDirectory(@"D:\HOMEWORK18\");

            //File.Create(@"D:\HOMEWORK18\xmlserialization.xml");

            //File.Create(@"D:\HOMEWORK18\jsonserialization.json");

            studentslist.AddRange(new Student[]
            {
                new Student {Name = "MARTIN",Age = 27,Description = "very clever student!",Coursegrade = 6.00 },
                new Student {Name ="ANGEL", Age = 30, Description ="very tall, and little lazy!", Coursegrade = 4.40 },
                new Student {Name = "IVAN", Age = 18, Description ="very skinny and always late for classes!", Coursegrade = 5.10 },
                new Student {Name = "HRISTO", Age = 22, Description ="very good friend and communicativre!", Coursegrade = 5.80 },
                new Student {Name = "PETKAN", Age = 26, Description = "very good at maths and tidy!",Coursegrade = 5.05 },
                new Student {Name = "GEORGI",Age = 30,Description = "always, speaking in class!",Coursegrade = 3.50 },
                new Student {Name ="ROZA", Age = 19, Description ="very beautifull lady!", Coursegrade = 3.00 },
                new Student {Name = "MILENA", Age = 29, Description ="has always poor marks on \"exams\" !", Coursegrade = 3.90 },
                new Student {Name = "PETER", Age = 22, Description ="very good friend and communicativre!", Coursegrade = 5.80 },
                new Student {Name = "ATANAS", Age = 27, Description = "always chatting on his phone with someone!",Coursegrade = 4.50 },

            });

            SerializeToXML();
            Console.WriteLine("\n========================================================");
            ReadingXMLFromFile();
            Console.WriteLine("\n========================================================");
            SerializeToJSON();
            Console.WriteLine("\n========================================================");
            ReadingFromJSON();
            Console.WriteLine("\n========================================================");
            XMLDeserialization();
            Console.WriteLine("\n========================================================");
            JSONDeserialization();
                
            


        }


        public static void SerializeToXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

            using(StreamWriter writer = new StreamWriter(@"D:\HOMEWORK18\xmlserialization.xml"))
            {
                serializer.Serialize(writer, studentslist);
            }
        }


        public static void ReadingXMLFromFile()
        {
            using (StreamReader reader = new StreamReader(@"D:\HOMEWORK18\xmlserialization.xml"))
            {
                string content = reader.ReadLine();

                while(content != null)
                {
                    Console.WriteLine(content);
                    content = reader.ReadLine();
                }
            }
        }
        public static void SerializeToJSON()
        {


            JsonSerializer serializer = new JsonSerializer();
            
            using (StreamWriter writer = new StreamWriter(@"D:\HOMEWORK18\jsonserialization.json"))
            {
                serializer.Serialize(writer, studentslist);
            }

        }

        public static void ReadingFromJSON()
        {
            using (StreamReader reader = new StreamReader(@"D:\HOMEWORK18\jsonserialization.json"))
            {
                string content = reader.ReadLine();

                while(content!=null)
                {
                    Console.WriteLine(content);
                    content = reader.ReadLine();
                }
            }
        }

        public static void XMLDeserialization()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using(StreamReader reader = new StreamReader(@"D:\HOMEWORK18\xmlserialization.xml"))
            {
                var students = (List<Student>)serializer.Deserialize(reader);

                foreach(var element in students)
                {
                    Console.WriteLine($"{element.Name} {element.Age} {element.Description} {element.Coursegrade}");
                }
            }
        }

        public static void JSONDeserialization()
        {

            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader(@"D:\HOMEWORK18\jsonserialization.json"))
            {
                var student = (List<Student>)serializer.Deserialize(reader,typeof(List<Student>));

                foreach(var element in student)
                {
                    Console.WriteLine($"{element.Name} {element.Age} {element.Description} {element.Coursegrade}");
                }
            }
        }
    }
}
