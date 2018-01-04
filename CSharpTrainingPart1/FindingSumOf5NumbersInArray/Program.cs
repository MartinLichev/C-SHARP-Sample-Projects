using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSumOf5NumbersInArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR FINDING ""SUM OF 5 NUMBERS IN ARRAY"" ");
            Console.WriteLine("\n======================================================");

            int[] mynumbers = new int[5];

            int sum = 0;

            Console.Write("\nPLEASE, INPUT \"5\" NUMBERS IN THE ARRAY: ");


            for(int a = 0; a < 5; a++)
            {
                int input = int.Parse(Console.ReadLine());

                mynumbers[a] += input;
                sum += mynumbers[a];


            }

            Console.WriteLine("\nTHE SUM OF THE NUMBERS IN THE ARRAY IS {0}!",sum);


  
            
        }
    }
}
