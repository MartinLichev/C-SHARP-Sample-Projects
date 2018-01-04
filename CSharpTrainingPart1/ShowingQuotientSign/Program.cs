using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingQuotientSign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"         PROGRAM FOR DISPLAYING, IF CERTAIN NUMBER IS ""POSITIVE"" OR ""NEGATIVE"" ");
            Console.WriteLine("\n==================================================================================");

            Console.Write("\nPLEASE, INPUT A \"NUMBER\": ");
            int input = int.Parse(Console.ReadLine());

            if(input < 0)
            {
                Console.WriteLine("\nTHE NUMBER YOU HAVE INPUT IS \"NEGATIVE\" !");
            }
            if(input >= 0)
            {
                Console.WriteLine("\nTHE NUMBER YOU HAVE INPUT IS \"POSITIVE\" !");
            }
        }
    }
}
