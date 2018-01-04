using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingNamesOfTheMonthsByNumberInputWithLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR PRINTING THE NAMES OF THE MONTHS, BY NUMBER INPUT");
            Console.WriteLine("\n=================================================================");


            Console.Write("\nPLEASE, INPUT NUMBER FROM 1 TO 12 TO SEE WHICH MONTH IT IS, WRITTEN IN LETTERS: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"JANUARY\"!");
                    break;
                case 2:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"FEBRUARY\"!");
                    break;
                case 3:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"MARCH\"!");
                    break;
                case 4:
                    Console.WriteLine("THE NUMBER YOU HAVE CHOOSEN IS \"APRIL\"!");
                    break;
                case 5:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"MAY\"!");
                    break;
                case 6:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"JUNE\"!");
                    break;
                case 7:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"JULY\"!");
                    break;
                case 8:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"AUGUST\"!");
                    break;
                case 9:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"SEPTEMBER\"!");
                    break;
                case 10:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"OCTOBER\"!");
                    break;
                case 11:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"NOVEMBER\"!");
                    break;
                case 12:
                    Console.WriteLine("THE MONTH YOU HAVE CHOOSEN IS \"DECEMBER\"!");
                    break;
                default:
                    Console.WriteLine("INCORRECT INPUT, PLEASE TRY AGAIN!");
                    break;

            }
        }
    }
}

        

