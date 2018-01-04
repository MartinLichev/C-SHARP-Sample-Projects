using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheLargestOutOf3Numbers
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR FINDING THE LARGEST OUT OF ""3"" NUMBERS");
            Console.WriteLine("\n==========================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"3RD\" NUMBER: ");
            int input3 = int.Parse(Console.ReadLine());

            if((input1 > input2) && (input1 > input3))
            {
                Console.WriteLine($"\n{input1} IS THE LARGEST!");
            }
            if((input2 > input1) && (input2 > input3))
            {
                Console.WriteLine($"\n{input2} IS THE LARGEST!");
            }
            if((input3 > input1) && (input3 > input2))
            {
                Console.WriteLine($"\n{input3} IS THE LARGEST!");
            }
            if((input1 == input2) && (input1 == input3))
            {
                Console.WriteLine("\nTHE THREE NUMBERS ARE \"EQUAL\" !");
            }
        }
    }
}
