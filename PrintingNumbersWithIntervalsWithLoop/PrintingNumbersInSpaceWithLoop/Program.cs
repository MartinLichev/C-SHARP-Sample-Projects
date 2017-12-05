using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingNumbersInSpaceWithLoop
{
    public class PrintingNumbersInSpaceWithLoop
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"       PROGRAM FOR DISPLAYING NUMBERS, FROM ""USER INPUT"" IN INTERVALS");
            Console.WriteLine("\n======================================================================");

            Console.Write("\nPLEASE, INPUT NUMBER TO WHICH YOU WANT NUMBERS, PRINTED IN INTERVALS OF \"3\": ");
            int input = int.Parse(Console.ReadLine());

            for (int a = 3; a <= input; a++)
            {
                Console.WriteLine(a);
                a += 2;
            }
        }
    }
}


