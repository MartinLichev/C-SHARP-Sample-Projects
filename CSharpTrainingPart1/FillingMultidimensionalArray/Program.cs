using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingMultidimensionalArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FILLING MULTIDIMENSIONAL ARRAY");
            Console.WriteLine("\n=============================================");

            Console.Write("\nPLEASE INPUT THE NUMBER OF ROWS FOR THE \"MULTIDIMENSIONAL ARRAY\": ");

            int rowsinput = int.Parse(Console.ReadLine());

            Console.Write("\nPLEASE, INPUT THE NUMBER OF COLUMNS FOR THE \"MULTIDIMENSIONAL ARRAY\": ");

            int columnsinput = int.Parse(Console.ReadLine());

            int[,] numbers = new int[rowsinput, columnsinput];

            Console.WriteLine("\nPLEASE, INPUT THE NUMBERS TO BE STORED IN THE \"MULTIDIMENSIONAL ARRAY\": ");

            for(int a = 0; a < numbers.GetLength(0); a++)
            {
                for(int b = 0; b < numbers.GetLength(1); b++)
                {
                    numbers[a, b] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("\nTHE MULTIDIMENSIONAL ARRAY HAS THE FOLLOWING ELEMENTS IN IT!");

            for(int a = 0; a < numbers.GetLength(0); a++)
            {
                for(int b = 0; b < numbers.GetLength(1); b++)
                {
                    Console.Write(numbers[a,b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
