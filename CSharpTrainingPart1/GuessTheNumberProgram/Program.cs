using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"   PROGRAM FOR GUESSING A SPECIFIC NUMBER FROM INPUT");
            Console.WriteLine("\n===================================================");

            Random random = new Random();

            int number = random.Next(0, 10);

            for (int a = 0; a <= 10; a++)
            {
                Console.Write("\nPLEASE, INPUT A \"RANDOM\" NUMBER, IN THE RANGE FROM 1 TO 10: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if(input == number)
                {
                    Console.WriteLine("\nCONGRATULATIONS, YOU HAVE GUESSED THE NUMBER!");
                }
                else if(input > number)
                {
                    Console.WriteLine("\nYOU ARE CLOSE, THE NUMBER YOU HAVE ENTERED IS BIGGER THAN THE \"RANDOM NUMBER\"!");

                }
                else if(input < number)
                {
                    Console.WriteLine("\nYOU ARE CLOSE, THE NUMBER YOU HAVE ENTERD IS SMALLER THAN THE \"RANDOM NUMBER\"!");
                }
            }

        }
    }
}
            


