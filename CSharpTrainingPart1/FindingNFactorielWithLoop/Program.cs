using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingNFactorielWithLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FINDING ""N-FACTORIEL"" FOR INPUT NUMBER");
            Console.WriteLine("\n=======================================================");


            Console.Write("\nPLEASE, INPUT NUMBER: ");
            int input = int.Parse(Console.ReadLine());

            int factoriel = 1;


            Console.Write("\nTHE FACTORIEL OF {0} IS ", input);

            for(int a = input; a > 0; a--)
            {
                Console.Write("{0} x ",a);
                factoriel *= a;

            }

            Console.WriteLine("={0}",factoriel);



            
        }
    }
}
