using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingElectricityBill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"          PROGRAM FOR CALCULATING ELECTICITY BILL, BASED UPON CONSUMPTION");
            Console.WriteLine("\n========================================================================");


            long id = 0;
            string name = null;
            int consumption = 0;

            Console.Write("\nPLEASE, INPUT YOUR \"ID\":");
            long input1 = long.Parse(Console.ReadLine());
            id += input1;

            Console.Write("\nPLEASE, INPUT YOUR \"NAME\":");
            string input2 = Console.ReadLine();
            name += input2;

            Console.Write("\nPLEASE, INPUT YOUR \"UNIT-CONSUMPTION\":");
            int input3 = int.Parse(Console.ReadLine());
            consumption += input3;

            if(input3 <=199)
            {
                Console.WriteLine("\nYOUR ELECTRICITY-BILL IS {0}$.",(input3 * 1.20));
            }
            else if((input3 >=200) && (input3 <400))
            {
                Console.WriteLine("\nYOUR ELECTRICITY-BILL IS {0}$.", (input3 * 1.50));
            }
            else if((input3 >=400) && (input3 < 600 ))
            {
                Console.WriteLine("\nYOUR ELECTRICITY-BILL IS {0}$.", (input3 * 1.80));
            }
            else if(input3 >=600 )
            {
                Console.WriteLine("\nYOUR ELECTRICITY-BILL IS {0}$.", (input3 * 2.00));
            }
        }
    }
}
