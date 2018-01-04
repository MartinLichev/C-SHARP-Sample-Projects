using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublingASpecificNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"      PROGRAM FOR GETTING A SPECIFIC NUMBER FROM THE INPUT, INTO ""DOUBLE"" ");
            Console.WriteLine("\n===========================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER: ");
            double input = double.Parse(Console.ReadLine());

            Console.Write("\nTHE SPECIFIC NUMBER TO \"DOUBLE\" IS: ");
            Console.WriteLine(Math.Pow(input, 2));
        }
    }
}
