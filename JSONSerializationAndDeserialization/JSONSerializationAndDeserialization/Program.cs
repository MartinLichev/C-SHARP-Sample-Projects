using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace JSONSerializationAndDeserialization
{
    public class Program : Person
    {
        public static List<Person> personlist = new List<Person>();
        public static void Main(string[] args)
        {
            personlist.AddRange(new Person[]
                {

                new Person {Firstname = "MARTIN", Lastname = "LICHEV", Age = 27 },
                new Person {Firstname = "DIMITAR", Lastname = "LICHEV", Age = 50 },
                new Person {Firstname = "SAMUIL", Lastname = "KAMBUROV", Age = 27 },
                new Person {Firstname = "NIKOLAY", Lastname = "DANEV", Age =26 },
                new Person {Firstname = "ELENA", Lastname = "LICHEVA", Age =50 },

                });


            //SerealizeJSON();
            DeserializeJSON();


        }




        public static void SerealizeJSON()
        {

            //Directory.CreateDirectory(@"D:\JSONSERIALIZATION");
            //File.Create(@"D:\JSONSERIALIZATION\jsonserialization.json");

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter writer = new StreamWriter(@"D:\JSONSERIALIZATION\jsonserialization.json"))
            {
                serializer.Serialize(writer, personlist);
            }

            using (StreamReader reader = new StreamReader(@"D:\JSONSERIALIZATION\jsonserialization.json"))
            {
                string content = reader.ReadLine();

                while (content != null)
                {
                    Console.WriteLine(content);
                    content = reader.ReadLine();
                }
            }

        }

        public static void DeserializeJSON()
        {
            JsonSerializer serializer = new JsonSerializer();


            using (StreamReader reader1 = new StreamReader(@"D:\JSONSERIALIZATION\jsonserialization.json"))
            {

                var people = (List<Person>)serializer.Deserialize(reader1,typeof(List<Person>));

                foreach (var element in people)
                {
                    Console.WriteLine($"{element.Firstname} {element.Lastname} {element.Age}");
                }
            }
        }
    }
}


