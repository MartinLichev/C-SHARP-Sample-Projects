using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingAreaOfTriangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"      PROGRAM FOR GETTING ""AREA OF A TRIANGLE"" ");
            Console.WriteLine("\n================================================");


            Console.Write("\nPLEASE, INPUT \"1ST\" SIDE OF TRIANGLE: " );
            double input1 = double.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" SIDE OF TRAINGLE: ");
            double input2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTHE TRIANGLE OUT OF THIS TWO SIDES HAS THE FOLLOWING AREA - {0}", GetTriangleArea(input1, input2));

        }


        public static double GetTriangleArea(double a, double b)
        {
            double c = (a * b) / 2;
            return c;
        }
    }
}
