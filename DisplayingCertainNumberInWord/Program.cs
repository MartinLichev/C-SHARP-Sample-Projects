using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingCertainNumberInWord
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"         PROGRAM FOR DISPLAYING CERTAIN NUMBER(FROM 1-10) IN WORD!");
            Console.WriteLine("\n======================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER: ");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("\nONE!");
                    break;
                case 2:
                    Console.WriteLine("\nTWO!");
                    break;
                case 3:
                    Console.WriteLine("\nTHREE!");
                    break;
                case 4:
                    Console.WriteLine("\nFOUR!");
                    break;
                case 5:
                    Console.WriteLine("\nFIVE!");
                    break;
                case 6:
                    Console.WriteLine("\nSIX!");
                    break;
                case 7:
                    Console.WriteLine("\nSEVEN!");
                    break;
                case 8:
                    Console.WriteLine("\nEIGHT!");
                    break;
                case 9:
                    Console.WriteLine("\nNINE!");
                    break;
                case 10:
                    Console.WriteLine("\nTEN!");
                    break;
                default:
                    Console.WriteLine("\nINCORRECT FORMAT, PLEASE TRY AGAIN!");
                    break;
            }
        }
    }
}

