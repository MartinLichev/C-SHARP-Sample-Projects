using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfDoWhileLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"    PROGRAM FOR USAGE OF ""DO-WHILE"" LOOP");
            Console.WriteLine("\n=========================================");

            int a = 0;


            do
            {
                Console.WriteLine(a++);

            } while (a <= 100);
        }
    }
}
