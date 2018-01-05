using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForChekingIfNumberExistsInArrayOrNot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR CHECKING, IF SPECIFIC NUMBER EXISTS IN GIVEN ARRAY OR NOT");
            Console.WriteLine("\n===================================================================");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,};

            Console.Write("\nPLEASE, INPUT RANDOM NUMBER: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDOES THE ARRAY, CONTAINS THE ENTERED NUMBER ? {0}",CheckingIfNumberIsContained(numbers,input));

        }

        public static bool CheckingIfNumberIsContained(int[] numbers, int input)
        {
            for(int a = 0; a < numbers.Length; a++)
            {
                if (numbers.Contains(input))
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
