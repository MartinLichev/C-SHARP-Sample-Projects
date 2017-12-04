using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharactersChangePosition
{
    public class StringCharactersChangePosition
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM, FOR CHANGING PLACE OF CERTAIN CHARACTERS IN A ""STRING"" ");
            Console.WriteLine("\n==========================================================================");

            string name = "MARTIN LICHEV";

            string[] split = name.Split();

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);





        }
    }
}
