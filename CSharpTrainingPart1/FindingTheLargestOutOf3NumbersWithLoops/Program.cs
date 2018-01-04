using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheLargestOutOf3NumbersWithLoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"   PROGRAM FOR FINDING THE LARGEST OUT OF ""THREE NUMBERS"" WITH LOOPS");
            Console.WriteLine("\n=====================================================================");


            int[] numbers = new int[3];

            Console.Write("\nPLEASE, INPUT THREE NUMBERS: ");

            for(int a = 0; a < 3; a++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers[a] += input;
            }

            Console.Write("\nTHE LARGEST NUMBER IS: ");

            Console.WriteLine(LargestNumberWithForLoop(numbers));



        }


        public static int LargestNumberWithForLoop(int [] numbers)
        {
            int largest = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                if(numbers[a] > largest)
                {
                    largest = numbers[a];
                }
            }

            return largest;
        }


        public static int LargestNumberWithWhileLoop(int [] numbers)
        {
            int largest = 0;

            int a = 0;

            while (a < numbers.Length)
            {
                
                if(numbers[a] > largest)
                {
                    
                    largest = numbers[a];
                }
            }

            return largest;


        }

        public static int LargestNumberWithDoWhileLoop(int [] numbers)
        {
            int largest = 0;

            int a = 0;

            do
            {
                
                
                if (numbers[a] > largest)
                {
                    largest = numbers[a];
                }

            } while (a < numbers.Length);

            return largest;
        }
    }
}
