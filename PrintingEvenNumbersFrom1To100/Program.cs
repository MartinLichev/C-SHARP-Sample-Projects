using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class FindingTheEvenNumbersFrom1To100
{
    static void Main()
    {
        Console.WriteLine(@"       PROGRAM FOR FINDING THE SUM OF THE ""EVEN"" NUMBERS FROM ""1"" TO ""100"" ");
        Console.WriteLine("\n=====================================================================");
        Console.Write("\nTHE SUM OF THE \"EVEN\" NUMBERS IN THE RANGE\"1-100\"ARE:");

        int sum = 0;
        for (int a = 1; a <= 100; a++)
        {
            sum += a;
            int c = a % 2;
            if (c == 0)
            {
                Console.Write("{0}+", a);
            }
                
        }
                Console.Write("={0}",sum);
    }
}
