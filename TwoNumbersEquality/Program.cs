using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersEquality
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"         PROGRAM FOR CHECKING EQUALITY OF ""TWO"" NUMBERS WITH CONDITIONAL STATEMENT");
            Console.WriteLine("\n===================================================================================");


            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());


            if(input1 > input2)
            {
                Console.WriteLine("\n\"1ST\" NUMBER - {0} IS GREATER THAN \"2ND\" NUMBER - {1}",input1, input2);
            }
            else if(input2 > input1)
            {
                Console.WriteLine("\n\"2ND\" NUMBER - {0} IS GREATER THAN \"1ST\" NUMBER - {1}",input2, input1);
            }
            else if(input1 == input2)
            {
                Console.WriteLine("\nTHE TWO NUMBERS ARE EQUAL!");
            }
        }
    }
}
