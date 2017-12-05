using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollarsWithNestedLoops
{
    public class TriangleOfDollarsWithNestedLoops
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM FOR DISPLAYING TRIANGLE OF ""DOLLARS"" WITH NESTED LOOPS");
            Console.WriteLine("\n========================================================================");

            for(int a = 0; a <= 10; a++)
            {
                for(int b = 0; b < a; b++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

        }
    }
}
