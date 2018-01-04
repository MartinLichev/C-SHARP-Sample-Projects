using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingArrayOnlyWithEvenNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR FILLING ARRAY ONLY WITH EVEN NUMBERS FROM 1 TO 100 ");
            Console.WriteLine("\n===================================================================");

            int[] numbers = new int[101];

            for(int a = 1; a < 101; a++)
            {

                
                if(a % 2 == 0)
                {
                    numbers[a] += a;
                }
            }


            Console.Write("\nAFTER, FILLING THE ARRAY HAS THE FOLLOING ELEMENTS IN IT: ");

            foreach(int element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
