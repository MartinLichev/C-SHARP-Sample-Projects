using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class FindingTheGreateroutOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine(@"                PROGRAM FOR FINDING THE ""GREATEST"" OUT OF THREE NUMBERS ");
        Console.WriteLine("\n===========================================================================");
        Console.Write("\nPLEASE, INPUT FIRST NUMBER: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("\nPLEASE, INPUT SECOND NUMBER: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("\nPLEASE, INPUT THIRD NUMBER: ");
        int c = int.Parse(Console.ReadLine());

        bool compare1 = ((a > b) && (a > c));
        bool compare2 = ((b > a) && (b > c));
        bool compare3 = ((c > a) && (c > b));

        if (compare1)
        {
            Console.WriteLine("\nTHE \"GREATEST\" NUMBER OUT OF THE THREE NUMBERS IS:" + a);

        }
        else if (compare2)
        {
            Console.WriteLine("\nTHE \"GREATEST\" NUMBER OUT OF THE THREE NUMBERS IS: " + b);

        }
        else if (compare3)
        {
            Console.WriteLine("\nTHE \"GREATEST\" NUMBER OUT OF THE THREE NUMBERS IS: " + c);
        }
    }
}