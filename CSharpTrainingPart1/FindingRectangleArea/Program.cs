using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRectangleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR FINDING THE ""AREA"" OF RECTANGLE ");
            Console.WriteLine("\n====================================================");


            Console.Write("\nPLEASE, INPUT \"1ST\" SIDE: ");
            double input1 = double.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT \"2ND\" SIDE: ");
            double input2 = double.Parse(Console.ReadLine());

            GetRectangleArea(input1, input2);


           
        }

        public static double GetRectangleArea(double a, double b)
        {
            double c = a * b;
            return c;
        }
    }
}
