using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingNumber4TimesInRow
{
    public class DisplayingNumber4TimesInRow
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR DISPLAYING NUMBER, FROM THE INPUT ""4"" TIMES IN A ROW.");
            Console.WriteLine("\n============================================================================");

            int numberrow = 0;


            Console.Write("\nPLEASE, INPUT  A NUMBER: ");

            int input = int.Parse(Console.ReadLine());

            numberrow += input;

            Console.WriteLine("\nTHE NUMBER, FROM THE INPUT, DISPLAYED IN A ROW OF \"FOUR\" IS! ");


            for (int a = 0; a < 4; a++)
            {
                Console.Write($"{numberrow} ");
            }

            Console.WriteLine();

            for (int a = 0; a < 4; a++)
            {
                Console.Write($"{numberrow}");
            }

            Console.WriteLine();

            for (int a = 0; a < 4; a++)
            {
                Console.Write($"{numberrow} ");
            }

            Console.WriteLine();

            for (int a = 0; a < 4; a++)
            {
                Console.Write($"{numberrow}");
            }

            Console.WriteLine();
        }
    }
}



 


               





  
            

           

 