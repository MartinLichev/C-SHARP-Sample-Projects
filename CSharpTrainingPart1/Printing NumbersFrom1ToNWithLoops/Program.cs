using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_NumbersFrom1ToNWithLoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"       PROGRAM FOR PRINTING NUMBERS FROM 1 TO N USING LOOPS");
            Console.WriteLine("\n==========================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER TO WHICH YOU WOULD LIKE TO PRINT ALL \"CONSECUTIVE NUMBERS\": ");

            int input = int.Parse(Console.ReadLine());

            WithForLoop(input);
            //WithDoWhileLoop(input);
            //WithWhileLoop(input);
        }


        public static void WithForLoop(int number)
        {
            
            for(int a = 1; a <= number; a++)
            {
                Console.WriteLine(a);
            }

            
        }

        public static void WithDoWhileLoop(int number)
        {
            int a = 1;

            do
            {
                Console.WriteLine(a++);

            } while (a <= number);
        }

        public static void WithWhileLoop(int number)
        {
            int a = 1;

            while(a <= number)
            {
                Console.WriteLine(a++);
            }

        }
        
        
    }
}
