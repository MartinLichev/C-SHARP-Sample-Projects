using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectingIndexOutOfArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR SELECTING ""SPECIFIC INDEX"" OUT OF ARRAY");
            Console.WriteLine("\n===========================================================");

            int[] numbers = new int[20];


            Console.WriteLine("\nPLEASE, INPUT NUMBERS FROM 1 TO 20: ");

            for(int a = 0; a < numbers.Length; a++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers[a] += input;
            }

            int change = 0;

            numbers[9] = change;

            Console.Write("\nAFTER, WE CHANGE THE 10TH ELEMENT OF THE ARRAY, IT HAS THE FOLLOWING ELEMENTS IN IT: ");

            foreach(int element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
