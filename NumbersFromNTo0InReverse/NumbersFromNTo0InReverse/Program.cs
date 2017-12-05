using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromNTo0InReverse
{
    public class NumbersFromNto0InReverse
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"      PROGRAM FOR DISPLAYING NUMBERS FROM ""N"" BY USER INPUT TO ""0"" IN REVERSE ORDER ");
            Console.WriteLine("\n=======================================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER FROM WHICH YOU WANT TO START THE LOOP: " );
            int input = int.Parse(Console.ReadLine());

            for( int a = input; a > 0; a--)
            {
                Console.WriteLine(a);
            }
        }
    }
}
