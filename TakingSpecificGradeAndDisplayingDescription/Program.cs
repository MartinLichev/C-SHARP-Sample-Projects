using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingSpecificGradeAndDisplayingDescription
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"   PROGRAM FOR TAKING A SPECIFIC ""GRADE MARK"" AND DISPLAYING THE EQUIVALENT DESCRIPTION");
            Console.WriteLine("\n========================================================================================");


            Console.Write("\nPLEASE, INPUT A SPECIFIC \"GRADE MARK\": ");
            char input = char.Parse(Console.ReadLine().ToUpper());

            switch(input)
            {
                case 'A': Console.WriteLine("\nTHE MARK IS \"EXCELLENT\"!");
                    break;
                case 'B': Console.WriteLine("\nTHE MARK IS \"VERY GOOD\"!");
                    break;
                case 'C': Console.WriteLine("\nTHE MARK IS \"GOOD\"!");
                    break;
                case 'D': Console.WriteLine("\nTHE MARK IS \"DECENT\"!");
                    break;
                case 'E': Console.WriteLine("\nTHE MARK IS \"AVERAGE\"!");
                    break;
                case 'F': Console.WriteLine("\nTHE MARK IS \"FAIL\"!");
                    break;
            }
                
        }
    }
}
