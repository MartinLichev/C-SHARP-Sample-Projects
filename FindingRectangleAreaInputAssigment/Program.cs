using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RectangleAreaFinding
{
    static void Main()
    {
        Console.WriteLine(@"             BASIC MATH PROGRAM FOR FINDING RECTANGLE ARE BY GIVEN THE TWO SIDES");
        Console.WriteLine("============================================================================================");
        Console.WriteLine("PLEASE, INPUT THE TWO SIDES OF THE RECTANGLE.!THEY CAN BE BOTH FRACTIONAL NUMBERS!");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("THE ARE OF THE RECTANGLE BY THE MATH FORMULA \"S = a x b\" IS: " + (a * b));



    }

}
    