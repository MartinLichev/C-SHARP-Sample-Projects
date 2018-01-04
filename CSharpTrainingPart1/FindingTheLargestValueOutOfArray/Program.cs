using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheLargestValueOutOfArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FINDING THE LARGEST VALUE OUT OF ARRAY");
            Console.WriteLine("\n=====================================================");

            int[] numbers = new int[5];

            int largest = numbers[0];

            for (int a = 0; a < numbers.Length; a++)
            {


                int input = int.Parse(Console.ReadLine());
                numbers[a] += input;

                if (largest < numbers[a])
                {
                    largest = numbers[a];
                }


            }

            Console.WriteLine("\nTHE LARGEST VALUE IN THE ARRAY IS {0}",largest);
        }
    }
}

            


