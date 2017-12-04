using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Details
{
    public class FindingTheLargestAndSmallestNumbers
    {
        public static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine(@"      PROGRAM FOR FINDING THE ""LARGEST"" AND ""SMALLEST"" NUMBERS OUT OF ""10"" ");
            Console.WriteLine("\n================================================================================");


            int[] numbersarray = new int[10];

            int smallestnumber = numbersarray[0];

            int largestnumber = numbersarray[0];


            Console.Write("\nPLEASE, INPUT \"10\" NUMBERS: ");

            for (int a = 0; a < 10; a++)
            {

                int input = int.Parse(Console.ReadLine());

                numbersarray[a] += input;

                if (numbersarray[a] > largestnumber)
                {
                    largestnumber = numbersarray[a];
                }
            }

            for (int a = 0; a < numbersarray.Length; a++)
            {
                if (numbersarray[a] < smallestnumber)
                {
                    smallestnumber = numbersarray[a];
                }
            }

            Console.WriteLine("\nTHE LARGEST NUMBER IS - {0}", largestnumber);


            Console.WriteLine("\nTHE SMALLEST NUMBER IS - {0}", smallestnumber);
        }
    }
}
 
            
