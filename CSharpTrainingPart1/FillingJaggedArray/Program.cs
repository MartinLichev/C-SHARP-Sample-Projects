using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingJaggedArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"      PROGRAM FOR FILLING JAGGED ARRAY");
            Console.WriteLine("\n=====================================");


            int[][] numbers = new int[4][];


            numbers[0] = new int[10];

            numbers[1] = new int[5];

            numbers[2] = new int[8];

            numbers[3] = new int[12];


            Console.WriteLine("\nPLEASE, INPUT TOTAL OF 35 NUMBERS: ");

            for(int a = 0; a < numbers.Length; a++)
            {
                for(int b = 0; b < numbers[a].Length; b++)
                {
                    numbers[a][b] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nTHE JAGGED ARRAY WITH THIS NUMBERS, HAS THE FOLLOWING ELEMENTS IN IT!");

            for(int a = 0; a < numbers.Length; a++)
            {
                for(int b = 0; b < numbers[a].Length; b++)
                {
                    Console.Write(numbers[a][b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
