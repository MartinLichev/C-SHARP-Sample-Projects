using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class EvenOrOdd
{
    static void Main()
    {
        Console.WriteLine(@"             PROGRAM FOR CHECKING, IF NUMBER IS ""EVEN"" OR ""ODD"" ");
        Console.WriteLine("\n=======================================================================");
        Console.Write("\nPLEASE, INPUT NUMBER :");
        int a = int.Parse(Console.ReadLine());
        int b = 2;
        int c = 0;
        bool even = (a % b) == c;
        bool odd = (a % b) > c;

        if (a == c)
        {
            Console.WriteLine("\nTHE NUMBER, YOU HAVE ENTERED IS NEITHER \"EVEN\" OR \"ODD\", IT IS: " + a);
        }
        else if (even)
        {
            Console.WriteLine("\nTHE NUMBER, YOU HAVE ETERED IS \"EVEN\", IT IS: " + a);
        }
        else if (odd)
        {
            Console.WriteLine("\nTHE NUMBER, YOU HAVE ENTERED IS \"ODD\", IT IS: " + a);
        }
    }
}

          

  

        
              