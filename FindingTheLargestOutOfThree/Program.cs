using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheLargestOutOfThree
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine(@"      PROGRAM FOR FINDING THE LARGEST OUT OF ""THREE"" NUMBERS");
            Console.WriteLine("\n=============================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write("\nPLEASE, INPUT \"3RD\" NUMBER: ");
            int input3 = int.Parse(Console.ReadLine());


            if((input1 > input2) && (input2 > input3))
            {
                Console.WriteLine("\n\"1ST\" NUMBER - {0} IS THE LARGEST!", input1);
            }
            else if((input2 > input1) && (input2 > input3))
            {
                Console.WriteLine("\n\"2ND\" NUMBER - {0} IS THE LARGEST!", input2);
            }
            else if((input3 > input1) && (input3 > input2))
            {
                Console.WriteLine("\n\"3RD\" NUMBER - {0} IS THE LARGEST!", input3);
            }
        }
    }
}
