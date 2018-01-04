using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@" PROGRAM FOR MAKING ""OPERATIONS WITH STRINGS"" ");
            Console.WriteLine("=================================================");

            string mystring = "HELLO WORLD";

            string[] split = mystring.Split(' ');


            foreach(string element in split)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine(mystring.Length);

            string name = "OGNYAN";

            Console.WriteLine(GetLength(name));

            Console.WriteLine(mystring.IndexOf('W'));

            Console.WriteLine(mystring.ToUpper());
            Console.WriteLine(mystring.ToLower());

            Console.WriteLine(mystring.Replace("HELLO", "PROGRAMMING"));


        }


        public static string GetLength(string name)
        {
            return name.Length.ToString();
        }
    }
}


