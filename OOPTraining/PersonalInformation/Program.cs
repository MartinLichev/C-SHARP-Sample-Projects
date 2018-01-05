using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformation
{
    public class Program:Person
    {
        public Program(string firstname, string lastname, int age):base (firstname, lastname, age)
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR DISPLAYING PERSONAL INFORMATION");
            Console.WriteLine("\n===============================================");


            Person p1 = new Person("MARTIN", "LICHEV", 27);
            Person p2 = new Person("DIMITAR", "LICHEV", 50);
            Person p3 = new Person("ELENA", "BEROVA", 50);
            Person p4 = new Person("LILLY", "LICHEVA", 25);
            Person p5 = new Person("ANGEL", "LICHEV", 55);

            object[] people =
            {
                p1,
                p2,
                p3,
                p4,
                p5,
            };

            foreach(Person element in people)
            {
                Console.WriteLine($"\n{element.Firstname}");
                Console.WriteLine($"\n{element.Lastname}");
                Console.WriteLine($"\n{element.Age}");
            }



        }
    }
}
