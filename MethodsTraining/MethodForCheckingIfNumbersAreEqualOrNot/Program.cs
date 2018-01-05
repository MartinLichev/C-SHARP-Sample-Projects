using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForCheckingIfNumbersAreEqualOrNot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"   PROGRAM FOR CHECKING, IF ""2 NUMBERS"" ARE EQUAL OR NOT");
            Console.WriteLine("\n=========================================================");

            Console.Write("\nPLEASE, INPUT \"1ST NUMBER\": ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND NUMBER\": ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nARE THE TWO, ENTERED NUMBERS, EQUAL ? {0}", ComparingTwoNumbers(input1, input2));


        }


        public static bool ComparingTwoNumbers(int input1, int input2)
        {
            if(input1 == input2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
