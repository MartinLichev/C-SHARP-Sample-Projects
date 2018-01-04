using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingAreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FINDING THE ""AREA OF CIRCLE"" ");
            Console.WriteLine("\n==============================================");

            Console.Write("\nPLEASE, INPUT \"RADIUS\" OF THE CIRCLE: ");
            double input = double.Parse(Console.ReadLine());

            double pi = 3.14;

            Console.Write("\nTHE AREA OF THE CIRCLE IS: ");
            Console.WriteLine(GetCircleArea(pi, input));

        }


        public static double GetCircleArea(double a , double b)
        {
            double c = a * (b * b);
            return c;
        }
    }
}
