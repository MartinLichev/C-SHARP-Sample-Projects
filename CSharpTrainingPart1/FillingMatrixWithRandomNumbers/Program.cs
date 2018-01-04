using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingMatrixWithRandomNumbersandFindingMaxAndMin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR FILLING ARRAY WITH RANDOM NUMBERS");
            Console.WriteLine("\n===================================================");

            int rowsandcolumns = 3;

            int[,] numbers = new int[rowsandcolumns, rowsandcolumns];

            int max = numbers[0,0];
            int min = numbers[0,0];

            for (int a = 0; a < numbers.GetLength(0); a++)
            {
                for (int b = 0; b < numbers.GetLength(1); b++)
                {
                    numbers[a, b] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }


            for(int a = 0; a < numbers.GetLength(0); a++)
            {
                for(int b = 0; b < numbers.GetLength(1); b++)
                {
                    if(max < numbers[a,b])
                    {
                        max = numbers[a, b];
                    }
                }
            }

            Console.WriteLine("\nTHE MAX NUMBER IN THE MATRIX IS {0}",max);


            for(int a = 0; a < numbers.GetLength(0); a++)
            {
                for(int b = 0; b < numbers.GetLength(1); b++)
                {
                    if(numbers[a, b] < min)
                    {
                        min = numbers[a, b];
                    }
                }
            }

            Console.WriteLine("\nTHE MIN VALUE IN THE ARRAY IS {0}",min);
        }
    }
}



