using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArraysFilling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR FILLING TWO ARRAYS WITH ""STRINGS"" ");
            Console.WriteLine("\n===================================================");

            string[] names = { "Martin", "Dimitar", "Elena", "Ognyan", "Lilly" };

            string[] names2 = new string[5];


            Console.WriteLine("\nTHE ELEMENTS IN THE ARRAY IN REVERSE, ARE THE FOLLOWING: ");


            Array.Reverse(names);

            foreach(string element in names)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\nAFTER, FILLING-UP, THE SECOND ARRAY HAS THE FOLLOWING ELEMENTS: ");


            for(int a = 0, b = 0; a < names.Length && b < names2.Length; a++, b++)
            {
                names2[a] += names[b];

            }

            foreach(string element in names2)
            {
                Console.Write(element + " ");
            }

            

            
        }
    }
}
