using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostitiveOrNegativeNumberCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"        PROGRAM FOR CHECKING, IF GIVEN NUMBER IS POSITIVE OR NEGATIVE ");
            Console.WriteLine("\n=====================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER: ");
            int input = int.Parse(Console.ReadLine());

            if(input > 0)
            {
                Console.WriteLine("\nTHE NUMBER - {0} IS POSITIVE!",input);
            }
            else if(input < 0)
            {
                Console.WriteLine("\nTHE NUMBER - {0} IS NEGATIVE!",input);
            }
            else if(input == 0)
            {
                Console.WriteLine("\nTHE NUMBER IS \"0\" ");
            }

        }
    }
}
