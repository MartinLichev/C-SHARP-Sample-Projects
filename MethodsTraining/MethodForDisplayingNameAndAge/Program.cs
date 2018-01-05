using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForDisplayingNameAndAge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR DISPLAYING ""NAME AND AGE"", USING METHOD ");
            Console.WriteLine("\n=========================================================");

            Console.Write("\nPLEASE, INPUT NAME: ");
            string input1 = Console.ReadLine();

            Console.Write("\nPLEASE, INPUT AGE: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================");

            DisplayName(input1);
            Console.WriteLine("===========================");
            DisplayAge(input1,input2);


        }


        public static void DisplayName(string name)
        {

            Console.WriteLine("HELLO THERE! YOUR NAME IS {0}",name);
        }

        public static void DisplayAge(string name, int age)
        {
            Console.WriteLine("{0}.YOU ARE {1} YEARS OLD!", name, age);
        }
    }
}
