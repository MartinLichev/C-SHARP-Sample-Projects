using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortWithArray
{
    public class SelectionSortInArray
    {
        public static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR ""SORTING"" ELEMENTS IN AN ARRAY ");
            Console.WriteLine("\n======================================================");

            Console.Write("\nPLEASE INPUT \"5\" NUMBGERS: ");

            int[] numbersarray = new int[5];


            for (int a = 0; a < numbersarray.Length; a++)
            {
                int input = int.Parse(Console.ReadLine());
                numbersarray[a] += input;
            }


            Console.WriteLine("\nTHE NUMBERS, PLACED IN AN ARRAY, ARE THE FOLLOWING: ");

            foreach (int element in numbersarray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nTHE NUMBERS, IN THE ARRAY SORTED IN ASCENDING ORDER ARE: ");

            for(int a = 0; a < numbersarray.Length - 1 ; a++)
            {
                for(int b = a+1; b < numbersarray.Length; b++)
                {
                    if(numbersarray[a] > numbersarray[b])
                    {
                        int temp = numbersarray[a];

                        numbersarray[a] = numbersarray[b];

                        numbersarray[b] = temp;
                    }
                }
            }


            foreach(int element in numbersarray)
            {
                Console.WriteLine(element);
            }
        }
    }
}



  