using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsPatternDesign
{
    public class SpecialCharacterDesignPattern
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM, FOR DISPLAYING A PATTERN OF CERTAIN ""SYMBOL"" ");
            Console.WriteLine("\n===================================================");

            char symbol ='\0';

            try
            {
                Console.Write("\nPLEASE, INPUT A SPECIAL \"SYMBOL\": ");
                char input = char.Parse(Console.ReadLine());
                symbol += input;
            }

            catch(SystemException)
            {
                Console.Write("\nPLEASE, INPUT A SPECIAL SYMBOL, WHICH IS \"ONE\" CHARACTER IN LENGTH: ");
                char input = char.Parse(Console.ReadLine());
                symbol += input;
                
            }

            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
