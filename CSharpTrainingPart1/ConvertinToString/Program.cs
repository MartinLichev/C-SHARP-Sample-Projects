using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertinToString
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"       PROGRAM FOR GETTING ""TO STRING"" SPECIFIC VARIABLES ");
            Console.WriteLine("\n===========================================================");

            Console.Write("\nPLEASE, INPUT \"1ST\" NUMBER: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" NUMBER: ");
            int input2 = int.Parse(Console.ReadLine());

            int input3 = input1;
            input2 = input1;
            input1 = input2;

            Console.WriteLine(input3);
            Console.WriteLine(input2);
        }
    }
}
