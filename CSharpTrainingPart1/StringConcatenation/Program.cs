using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"          PROGRAM FOR TAKING ""TWO NAMES"" AND CONCATENATING THEM IN ""ONE STRING"" ");
            Console.WriteLine("\n===================================================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NAME: ");
            string input1 = Console.ReadLine();

            Console.Write("\nPLEASE, INPUT \"2ND\" NAME: ");
            string input2 = Console.ReadLine();

            string concat = input1+ " " + input2;

            Console.WriteLine("\nTHE CONCATENATION OF THE TWO STRINGS IS - {0}",concat);
        }
    }
}
