using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class ShowingQuotientSign
{
    static void Main()
    {
        Console.WriteLine(@"     PROGRAM FOR SHOWING THE QUOTIENT SIGN BETWEEN ""2"" NUMBERS, WHEN DIVIDING THEM ");
        Console.WriteLine("\n============================================================================");
        Console.Write("\nPLEASE, INPUT FIRST NUMBER: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("\nPLEASE, INPUT SECOND NUMBER: ");
        int b = Convert.ToInt32(Console.ReadLine());
        bool positive = (a >= 0) || (b >= 0);
        bool negative = (a < 0) || (b < 0);
        bool ApositiveBnegative = (a >= 0) || (b < 0);
        bool AnegativeBpositive = (a < 0) || (b >= 0);



        if (AnegativeBpositive)
        {
            Console.WriteLine("\nAFTER THE DIVISION OF THE \"TWO\" NUMBERS, THE NEW NUMBER WILL BE WITH \"+\" SIGN!");

        }
        else if (positive)
        {
            Console.WriteLine("\nAFTER THE DIVISION OF THE \"TWO\" NUMBERS, THE NEW NUMBER WILL BE WITH \"+\" SIGN!");
        }
        else if (ApositiveBnegative)
        {
            Console.WriteLine("\nAFTER THE DIVISION OF THE \"TWO\" NUMBERS, THE NEW NUMBER WILL BE WITH \"-\" SIGN!");
        }
        else if(negative)
        {
            Console.WriteLine("\nAFTER THE DIVISION OF THE \"TWO\" NUMBERS, THE NEW NUMBER WILL BE WITH \"-\" SIGN!");
        }

    






    }
}