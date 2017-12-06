using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"     PROGRAM FOR CHECKING IF A NUMBER IS ""EVEN"" OR ""ODD"" ");
            Console.WriteLine("\n============================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER: ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("\nTHE NUMBER IS \"EVEN\" ");
            }
            else if(input % 2 == 1)
            {
                Console.WriteLine("\nTHE NUMBER IS \"ODD\" ");
            }
        }
    }
}
