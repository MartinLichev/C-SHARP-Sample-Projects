using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class FindingTheGreaterNumber
{
    static void Main()
    {
        Console.WriteLine(@"              PROGRAM, FOR FINDING THE GREATER OUT OF ""2"" NUMBERS ");
        Console.WriteLine("\n==========================================================================");
        Console.Write("\nPLEASE, INPUT FIRST NUMBER: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPLEASE, INPUT SECOND NUMBER: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("\nTHE NUMBER, {0} IS THE GREATER OUT OF THIS TWO NUMBERS! ", a);
        }
        else if (b > a)
        {
            Console.WriteLine("\nTHE NUMBER, {0} IS THE \"GREATER\" OUT OF THIS TWO NUMBERS! ", b);
        }
    }
}