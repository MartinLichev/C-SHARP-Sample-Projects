using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingMatrixArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FILLING ""MATRIX"" ARRAY ");
            Console.WriteLine("\n========================================");


            int n = 4;

            int[,] mynumbers = new int[n, n];


            Console.Write("\nPLEASE, ENTER NUMBERS TO FILL THE \"MATRIX\": ");

            for(int a =0; a < mynumbers.GetLength(0); a++)
            {
                for(int b = 0; b < mynumbers.GetLength(1); b++)
                {
                    mynumbers[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nTHE NUMBERS IN THE \"MATRIX\" ARE THE FOLLOWING: ");

            for(int a = 0; a < mynumbers.GetLength(0); a++)
            {
                for(int b = 0; b < mynumbers.GetLength(1); b++)
                {
                    Console.Write(mynumbers[a,b] + " ");
                }
                Console.WriteLine();
            }


            for(int a = 0; a < mynumbers.GetLength(0); a++)
            {
                for(int b = 0; b < mynumbers.GetLength(1); b++)
                {
                    if(mynumbers[a,b] % 2 == 1)
                    {
                        mynumbers[a, b] *= 2;
                    }
                }
            }
            Console.WriteLine("\nTHE \"EVEN\" NUMBERS IN THE ARRAY, AFTER THE MULTIPLACATION OF \"2\" ARE THE FOLLOWING: ");

            for(int a = 0; a < mynumbers.GetLength(0); a++)
            {
                for(int b = 0; b < mynumbers.GetLength(1); b++)
                {
                    Console.Write(mynumbers[a,b] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}

            



