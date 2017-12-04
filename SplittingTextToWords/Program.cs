using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplittingTextToWords
{
    public class SplittingTextToWords
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR SEPARATING TEXT TO ""WORDS"" ");
            Console.WriteLine("\n==================================================");

            string text = "Pacino is currently co-president, along with Ellen Burstyn and Harvey Keitel, of the Actors Studio.";

            Console.WriteLine("\nTHE FOLLOWING TEXT IS GIVEN:\"{0}\" ",text);
            Console.WriteLine("\nSEPARATED TO \"WORDS\", IT IS!");

            string[] split = text.Split();

            for(int a = 0; a < split.Length; a++)
            {
                Console.WriteLine($"\nWORD {a}:{split[a]}");
            }

        }
    }
}
