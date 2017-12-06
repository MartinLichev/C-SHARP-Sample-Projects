using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingIfYearIsLeapOrNot
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"     PROGRAM FOR CHECKING, IF CERTAIN YEAR IS ""LEAP"" OR ""NOT LEAP"" ");
            Console.WriteLine("\n======================================================================");


            Console.Write("\nPLEASE, INPUT CERTAIN YEAR: ");
            long input = long.Parse(Console.ReadLine());

            string leapornotleap = (input % 4 == 0) ? "IT IS A LEAP YEAR!" : "IT IS NOT A LEAP YEAR";

            Console.WriteLine(leapornotleap);
        }
    }
}

                    





    
