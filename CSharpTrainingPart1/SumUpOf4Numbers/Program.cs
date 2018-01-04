using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUpOf4Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR GETTING THE ""SUM"" OF 4 NUMBERS");
            Console.WriteLine("\n================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"3RD\" NUMBER: ");
            int input3 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"4RD\" NUMBER: ");
            int input4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTHE \"SUM\" OF THE FOUR NUMBERS IS: {0}", ((input1+ input2)+(input3+ input4)));
        }
    }
}
