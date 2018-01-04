using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingMatrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@" PROGRAM FOR FILLING MATRIX WITH NUMBERS" );
            Console.WriteLine("\n========================================");

            int rowsandcolumns = 5;

            int[,] matrix = new int[rowsandcolumns, rowsandcolumns];

            for(int a = 0; a < matrix.GetLength(0); a++)
            {
                for(int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nAFTER FILLING THE ELEMENTS IN THE \"MATRIX\" ARE THE FOLLOWING: ");

            for(int a = 0; a < matrix.GetLength(0); a++)
            {
                for(int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write(matrix[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
