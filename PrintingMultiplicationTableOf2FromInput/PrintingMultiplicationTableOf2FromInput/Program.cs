using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMultiplicationTableOf2FromInput
{
    public class PrintingMultiplicationTableOf2UntilInput
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"      PROGRAM FOR PRINTING NUMBERS, UNTIL ""INPUT"" MULTIPLIED BY ""2"" ");
            Console.WriteLine("\n=======================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER: ");
            int input = int.Parse(Console.ReadLine());


            int num = 1;
            for (int a = 0; a <= input; a++)
            {
                 
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
