using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssigmentP2
{
    class Program
    {
        static void Main(string[] args)

        {

            string name1 = "Programming";
            Console.WriteLine(@"        PROGRAM FOR TRANSFORMING ""STRINGS""   ");
            Console.WriteLine("===============================================================");
            Console.WriteLine(@"""Programming"" string." );
            name1 = name1.Substring( 0,3);
            int a = name1.IndexOf("o");
            Console.WriteLine(name1);
            Console.WriteLine(a);

        }
    }
}
