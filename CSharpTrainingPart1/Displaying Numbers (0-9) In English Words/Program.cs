using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Displaying_Numbers__0_9__In_English_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR DISPLAYING NUMBERS (0-9) IN ENGLISH WORDS ");
            Console.WriteLine("\n==========================================================");

            Console.Write("\nPLEASE, INPUT \"NUMBER\" FROM 0 TO 9: ");
            int input1 = int.Parse(Console.ReadLine());



                switch (input1)
                {
        
                    case 0:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"ZERO\" !");
                        break;
                    case 1:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"ONE\" !");

                        break;
                    case 2:
                        Console.WriteLine("THE NUMBWER YOU HAVE INPUT IS \"TWO\" !");

                        break;
                    case 3:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"THREE\" !");
                        break;
                    case 4:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"FOUR\" !");
                        break;
                    case 5:
                        Console.WriteLine("THEW NUMBER YOU HAVE INPUT IS \"FIVE\" !");
                        break;
                    case 6:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"SIX\" !");
                        break;
                    case 7:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"SEVEN\" !");
                        break;
                    case 8:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"EIGHT\" !");
                        break;
                    case 9:
                        Console.WriteLine("THE NUMBER YOU HAVE INPUT IS \"NINE\" !");
                        break;
                    default:
                        Console.WriteLine("INCORRECT INPUT, PLEASE TRY AGAIN!");
                        break;


                }

                
        }
    }
}
