using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNumberWithIfStatement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR FINDING, IF CERTAIN NUMBER IS ""ODD"" OR ""EVEN"" ");
            Console.WriteLine("\n===================================================================");

            Console.Write("\nPLEASE, ENTER A NUMBER: ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("\nTHE NUMBER YOU HAVE INPUT IS \"EVEN\" " );
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("\nTHE NUMBER YOU HAVE INPUT IS \"ODD\" ");
            }
            if (input == 0)
            {
                Console.WriteLine("\nTHE NUMBER YOU HAVE INPUT IS EQUAL TO \"0\" ");
            }
        }
    }
}
