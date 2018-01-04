using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingLargestAmong10Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR FINDING LARGEST NUMBER, AMONG 10 NUMBERS");
            Console.WriteLine("\n========================================================");

            int[] numbers = new int[10];

            int largest = numbers[0];
            int smallest = numbers[0];

            Console.WriteLine("\nPLEASE, INPUT 10 NUMBERS: ");

            for (int a = 0; a < numbers.Length; a++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[a] += input;
            }

            for(int a = 0; a < numbers.Length; a++)
            {
                if(numbers[a] > largest)
                {
                    largest = numbers[a];
                }
                
            }

            Console.WriteLine("\nTHE LARGEST NUMBER IN THE ARRAY IS {0}", largest);
        }
    }
}
