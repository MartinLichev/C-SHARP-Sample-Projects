using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

public class CalculatingBonusPoints
{
    static void Main()
    {
        Console.WriteLine(@"            PROGRAM FOR CALCULATING BONUS POINTS OUT OF A ""SPECIFIC GAME"" ");
        Console.WriteLine("\n===============================================================================");
        Console.Write("\nPLEASE, ENTER YOUR POINTS OUT OF THE GAME, IN THE (1-9) RANGE: ");
        int a = int.Parse(Console.ReadLine());
        int multiple1 = 5;
        int multiple2 = 10;
        int multyple3 = 50;

        if (a == 1)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 5));

        }
        else if (a == 2)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 5));
        }
        else if (a == 3)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 5));
        }
        else if (a == 4)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 10));
        }
        else if (a == 5)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 10));
        }
        else if (a == 6)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 10));
        }
        else if (a == 7)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 50));
        }
        else if (a == 8)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 50));
        }
        else if (a == 9)
        {
            Console.WriteLine("\nDEAR \"PLAYER\", YOUR BONUS POINTS OUT OF THE GAME ARE:{0}", (a * 50));
        }
    }
}