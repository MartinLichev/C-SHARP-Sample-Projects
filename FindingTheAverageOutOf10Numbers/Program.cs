using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheAverageOutOf10Numbers
{
    public class FindingTheAverageNumberOutOf10Numbers
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"            PROGRAM FOR, FINDING THE AVERAGE NUMBERS");
            Console.WriteLine("\n===================================================");

            double[] numbers = new double[10];

            Console.Write("\nPLEASE, INPUT 10 \"RANDOM\" NUMBERS: ");

            for(int a = 0; a < 10; a++)
            {
                double input = double.Parse(Console.ReadLine());
                numbers[a] += input;
            }

            double sum = 0;
            



            for(int a=0; a < numbers.Length; a++)
            {
                sum += numbers[a];
            }

            Console.WriteLine("\nTHE AVERAGE OF THIS \"10\" NUMBERS, FROM THE INPUT IS: {0} ",(sum/10));


            

        }
    }
}
