using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithArrayOfNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"      PROGRAM FOR USING METHOD, THAT TAKES ARRAY OF NUMBERS");
            Console.WriteLine("\n==========================================================");

            Console.Write("\nPLEASE, INPUT \"10\" NUMBERS:");

            int[] numbers = new int[10];

            for (int a = 0; a < 10; a++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[a] += input;
            }

            Console.WriteLine("\nTHE NUMBER FROM THE INPUT IN REVERSE ARE: ");

            DisplayingNumbersInReverse(numbers);


        }

        public static void DisplayingNumbersInReverse(int[] numbers)
        {

            Array.Reverse(numbers);

            foreach (int element in numbers)
            {

                Console.Write(element + " ");
            }
        }
    }
}
