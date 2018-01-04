using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfWhileLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"   PROGRAM FOR USAGE OF WHILE LOOP");
            Console.WriteLine("\n=================================");

            int a = 0;

            while(a <= 100)
            {
                Console.WriteLine(a++);
            }
        }
    }
}
