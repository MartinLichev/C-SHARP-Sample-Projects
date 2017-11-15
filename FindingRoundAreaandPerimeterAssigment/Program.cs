using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RoundPerimeterandArea
{
    static void Main()
    {

        double pi = 3.14;
        double a = 2;
        Console.WriteLine(@"                 PROGRAM FOR FINDING AREA AND PERIMETER OF ROUND BY INPUT RADIUS");
        Console.WriteLine("=====================================================================================");
        Console.WriteLine("BY DEFAULT WE HAVE THE SPECIAL NUMBER \"pi\" WITH VALUE (3.14).");
        Console.WriteLine("PLEASE, IPUT VALUE OF RADIUS FOR THE ROUND: ");
        int r = Convert.ToInt32(Console.ReadLine());
        double c = Math.Pow(r, a);
        Console.WriteLine("THE AREA OF THE ROUND BY THE MATH FORMULA (S = pi x r2) IS: " + (pi * c));
        Console.WriteLine("=====================================================================================");
        Console.WriteLine("THE PERIMETER OF THE ROUND BY THE MATH FORMULA (P = 2 x pi x r) IS: " + (a * pi * r));



    }

}