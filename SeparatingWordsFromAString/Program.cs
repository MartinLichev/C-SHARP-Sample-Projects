using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparatingWordsFromAString
{
    public class SeparatingWordsFromString
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"       PROGRAM FOR SEPARATING WORDS FROM A STRING FROM THE INPUT");
            Console.WriteLine("\n===============================================================");

            Console.Write("\nPLEASE, INPUT A SENTENCE AND PRESS \"ENTER\" ONCE READY: ");

            string input = Console.ReadLine();

            string[] splitter = input.Split();

            Console.WriteLine("\nTHE SENTENCE YOU HAVE INPUT, HAS THE FOLLOWING WORDS IN IT!");

            for(int a=0; a < splitter.Length; a++)
            {
                Console.WriteLine($"\nWORD {a}:{splitter[a]}");
            }

        }
    }
}
