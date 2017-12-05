using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheLargestValueWithMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"  PROGRAM FOR FINDING THE ""LARGEST VALUE"" WITH METHOD");
            Console.WriteLine("\n======================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("THE LARGEST OUT OF THE \"TWO\" NUMBERS IS:{0}" ,GetMax(input1,input2));
            

        }


        public static int GetMax(int input1, int input2)
        {
            if(input1 > input2)
            {
                return input1;
            }
            else if(input2 > input1)
            {
                return input2;
            }

            return 0;

            
        }
    }
}
