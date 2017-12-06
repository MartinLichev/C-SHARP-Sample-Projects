using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingDayInNumberAndDisplayInWord
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"      PROGRAM FOR WRITING ANY DAY IN NUMBER AND DISPLAYING IT IN ""WORD"" ");
            Console.WriteLine("\n=========================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER, TO SEE WHAT DAY IS TODAY!: ");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: Console.WriteLine("MONDAY!");
                    break;
                case 2: Console.WriteLine("TUESDAY!");
                    break;
                case 3: Console.WriteLine("WEDNESDAY!");
                    break;
                case 4: Console.WriteLine("THURSDAY!");
                    break;
                case 5: Console.WriteLine("FRIDAY!");
                    break;
                case 6: Console.WriteLine("SATURDAY!");
                    break;
                case 7: Console.WriteLine("SUNDAY!");
                    break;
                default: Console.WriteLine("\nINVALID DAY ENTERED, PLEASE TRY AGAIN!");
                    break;
            }

        }
    }
}


  

      

