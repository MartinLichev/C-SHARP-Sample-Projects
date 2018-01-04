using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrintingStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR PRINTING ""STRINGS"" FROM INPUT ");
            Console.WriteLine("\n===============================================");

            string[] names = new string[5];


            Console.Write("\nPLEASE, INPUT \"FIVE STRINGS\": ");

            for(int a = 0; a < names.Length; a++)
            {
                string input = Console.ReadLine();
                names[a] += input;
            }


            Console.WriteLine("\nTHE NAMES IN THE ARRAY ARE THE FOLLOWING: ");

            foreach(string element in names)
            {
                Console.WriteLine(element);
            }

        }
    }
}
