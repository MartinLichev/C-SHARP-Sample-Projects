using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingLargestOutOf2Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR DISPLAYING THE ""LARGEST OUT OF TWO NUMBERS"" ");
            Console.WriteLine("\n================================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());

            if(input1 > input2)
            {
                Console.WriteLine($"\n{input1} IS THE LARGEST");
            }
            if(input2 > input1)
            {
                Console.WriteLine($"\n{input2} IS THE LARGEST");
            }
            if(input1 == input2)
            {
                Console.WriteLine($"\n{input1} AND {input2} ARE EQUAL!");
            }

        }
    }
}
