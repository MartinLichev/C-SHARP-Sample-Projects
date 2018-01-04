using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"         PROGRAM FOR WRITING PERSONAL INFO");
            Console.WriteLine("===========================================");

            DateTime current = DateTime.Now;

            Console.WriteLine(current);

            

            int years = 27;

            string name = "Martin";

            string gender = "male";

            string eyescolor = "brown";

            Console.WriteLine("HELLO {0}",name);
            Console.WriteLine("YOU ARE {0}, YEARS OLD!",years);
            Console.WriteLine("YOUR GENDER IS - {0}",gender);
            Console.WriteLine("YOUR EYES ARE {0}!",eyescolor);
        }
    }
}
