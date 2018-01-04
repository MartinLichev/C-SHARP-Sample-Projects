using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR JAGGED ARRAYS");
            Console.WriteLine("\n=============================");


            int[][] myarray = new int[4][];

            myarray[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            myarray[1] = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            myarray[2] = new int[] { 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

            myarray[3] = new int[] { 0, 0, 20, 20, };


            for(int a = 0; a < myarray.Length; a++)
            {
                for(int b = 0; b < myarray[a].Length; b++)
                {
                    Console.Write(myarray[a][b] + " ");

                }
                Console.WriteLine();
            }


        }
    }
}


            



                
