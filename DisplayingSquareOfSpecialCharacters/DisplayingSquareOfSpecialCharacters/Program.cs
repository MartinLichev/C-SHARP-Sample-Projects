using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingSquareOfSpecialCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR DISPLAYING SQUARE OF SPECIAL CHARACTERS");
            Console.WriteLine("\n============================================================");

            for(int a = 0; a < 6; a++ )
            {
                for(int b = 0; b < 10; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
