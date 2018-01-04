using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"     PROGRAM FOR DISPLAYING ""PERSONAL INFO FROM THE INPUT"" ");
            Console.WriteLine("\n============================================================");

            Console.Write("\nPLEASE, INPUT \"NAME\": ");
            string name = Console.ReadLine();

            Console.WriteLine("\nPLEASE, INPUT \"EYES COLOUR\": ");
            string eyescolour = Console.ReadLine();

            Console.WriteLine("\nPLEASE, INPUT \"AGE\" : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPLEASE, INPUT \"HEIGHT\": ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("\nYOUR PERSONAL INFO IS: ");

            Console.WriteLine(name);
            Console.WriteLine(eyescolour);
            Console.WriteLine(age);
            Console.WriteLine(height);

        }
    }
}
