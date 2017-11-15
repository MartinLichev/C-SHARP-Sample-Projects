using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class CalculatingBonusPointsoutOfGameSecondScenario
{
    static void Main()
    {
        Console.WriteLine(@"             PROGRAM FOR CALCULATING BONUS POINTS OUT OF A ""SPECIFIC GAME"" ");
        Console.WriteLine("\n================================================================================");
        Console.Write("\nPLEASE, INPUT POINTS BASED ON THE RESULT OF THE GAME, IN THE RANGE (1-9): ");
        int a = Convert.ToInt32(Console.ReadLine());
        bool points1 = (a <= 3);
        bool points2 = (a > 3) && (a <= 6);
        bool points3 = (a >= 7) && (a <= 9);

        if (points1)
        {
            Console.WriteLine("\nDEAR PLAYER, YOUR BONUS POINT, BASED ON THE RESULT OF \"THE GAME\" ARE: " + (a * 5));

        }
        else if (points2)
        {
            Console.WriteLine("\nDEAR PLAYER, YOUR BONUS POINT, BASED ON THE RESULT OF \"THE GAME\" ARE: " + (a * 10));

        }
        else if (points3)
        {
            Console.WriteLine("\nDEAR PLAYER, YOUR BONUS POINT, BASED ON THE RESULT OF \"THE GAME\" ARE: " + (a * 50));
        }
    }


    }
