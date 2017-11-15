using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

public class WritingnNumbersInEnglishWords
{
    static void Main()
    {
        Console.WriteLine(@"           PROGRAM FOR WRITING NUMBER;(0-9) IN ENGLISH WORDS ");
        Console.WriteLine("\n===============================================================");
        Console.Write("\nPLEASE, INPUT A NUMBER IN THE RANGE FROM \"0-9\" : ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"ZERO\" ", a);
        }
        else if (a == 1)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"ONE\" ", a);
        }
        else if (a == 2)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"TWO\" ", a);
        }
        else if (a == 3)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"THREE\" ", a);
        }
        else if (a == 4)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"FOUR\" ", a);
        }
        else if (a == 5)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"FIVE\" ", a);
        }
        else if (a == 6)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"SIX\" ", a);
        }
        else if (a == 7)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"SEVEN\" ", a);

        }
        else if (a == 8)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"EIGHT\" ", a);
        }
        else if (a == 9)
        {
            Console.WriteLine("\nTHE NUMBER YOU HAVE ENTERED IS {0} AND THIS TRANSFORMED TO WORD IS:\"NINE\" ", a);
        }
    }
}