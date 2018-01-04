using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSumOfEvenNumbers1To100WithLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"    PROGRAM FOR FINDING ""SUM OF EVEN NUMBERS"" FROM 1 TO 100");
            Console.WriteLine("\n========================================================");

            int[] numbers = new int[101];

            int sum = 0;

            for(int a = 0; a < numbers.Length; a++)
            {
                numbers[a] += a;
            }

            for(int a = 0; a < numbers.Length; a++)
            {
                if(numbers[a] % 2 == 0)
                {
                    sum += numbers[a];
                }
            }

            Console.WriteLine("\nTHE SUM OF THE \"EVEN\" NUMBERS FROM 1 TO 100 IS:{0} ",sum);

        }
    }
}



  
