using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingNameOfMothByInput
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"     PROGRAM FOR DISPLAYING NAME OF A MONTH, BY USER INPUT ");
            Console.WriteLine("\n==========================================================");

            Console.Write("\nPLEASE, INPUT NUMBER OF A CERTAIN MONTH: ");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: Console.WriteLine("\nTHE CURRENT MONTH IS \"JANUARY\"!");
                    break;
                case 2: Console.WriteLine("\nTHE CURRENT MONTH IS \"FEBRUARY\"!");
                    break;
                case 3: Console.WriteLine("\nTHE CURRENT MONTH IS \"MARCH\"!");
                    break;
                case 4: Console.WriteLine("\nTHE CURRENT MONTH IS \"APRIL\"!");
                    break;
                case 5: Console.WriteLine("\nTHE CURRENT MONTH IS \"MAY\"!");
                    break;
                case 6: Console.WriteLine("\nTHE CURRENT MONTH IS \"JUNE\"!");
                    break;
                case 7: Console.WriteLine("\nTHE CURRENT MONTH IS \"JULY\"!");
                    break;
                case 8: Console.WriteLine("\nTHE CURRENT MONTH IS \"AUGUST\"!");
                    break;
                case 9: Console.WriteLine("\nTHE CURRENT MONTH IS \"SEPTEMBER\"!");
                    break;
                case 10: Console.WriteLine("\nTHE CURRENT MONTH IS \"OCTOBER\"!");
                    break;
                case 11: Console.WriteLine("\nTHE CURRENT MONTH IS \"NOVEMBER\"!");
                    break;
                case 12: Console.WriteLine("\nTHE CURRENT MONTH IS \"DECEMBER\"!");
                    break;
                default: Console.WriteLine("\nINCORRECT FORMAT, PLEASE TRY AGAIN!");
                    break;
                    
            }
        }
    }
}
