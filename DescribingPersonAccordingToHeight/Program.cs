using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribingPersonAccordingToHeight
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine(@"        PROGRAM FOR ACCEPTING PERSON'S HEIGHT AND DESCRIBING HIM ");
            Console.WriteLine("\n================================================================");

            Console.Write("\nPLEASE, INPUT YOU HEIGHT: ");
            double input = double.Parse(Console.ReadLine());

            if(input >= 175)
            {
                Console.WriteLine("\nYOU ARE TALL!");
            }
            else if((input < 175) && (input >= 165))
            {
                Console.WriteLine("\nYOU ARE NOT SO TALL!");
            }
            else
            {
                Console.WriteLine("\nYOU ARE SHORT!");
            }
        }
    }
}



