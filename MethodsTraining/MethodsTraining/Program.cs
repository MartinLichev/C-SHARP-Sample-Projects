using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class DisplayingTriangleWithMethod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR DISPLAYING TRIANGLE OUT OF CERTAIN NUMBER FROM THE ""INPUT"" ");
            Console.WriteLine("\n============================================");

            Console.Write("\nPLEASE, INPUT NUMBER: ");
            int input = int.Parse(Console.ReadLine());
            DisplayTriangle(input);


        }


        public static void DisplayTriangle(int input)
        {

            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(input);
                }

                Console.WriteLine();
            }
        }
    }
}





