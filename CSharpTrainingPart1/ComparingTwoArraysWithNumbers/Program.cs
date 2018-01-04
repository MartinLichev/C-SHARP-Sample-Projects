using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingTwoArraysWithNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR COMPARING TWO ARRAYS WITH NUMBERS");
            Console.WriteLine("\n=================================================");

            int[] numbers1 = new int[10];

            int[] numbers2 = new int[10];

            Console.Write("\nPLEASE, INPUT NUMBERS IN THE \"1ST ARRAY\" :");

            for(int a = 0; a < numbers1.Length; a++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers1[a] += input;
            }

            Console.Write("\nPLEASE, INPUT NUMBERS IN THE \"2ND ARRAY\" :");

            for(int a = 0; a < numbers2.Length; a++)
            {
                int input2 = int.Parse(Console.ReadLine());

                numbers2[a] += input2;
            }


            for(int a = 0; a < numbers1.Length; a++)
            {
                for (int b = 0; b < numbers2.Length; b++)
                {
                    if (numbers1[a] == numbers2[b])
                    {
                        Console.WriteLine("\nELEMENT {0} FROM 1ST ARRAY AND ELEMENT {1} FROM SECOND ARRAY ARE EQUAL!", numbers1[a], numbers2[b]);
                    }
                }
            }

        }
    }
}
