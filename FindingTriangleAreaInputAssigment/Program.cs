using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class FindindTriangleArea
{
    static void Main()
    {


        int A = 2;
        Console.WriteLine(@"            BASIC MATH PROGRAM FOR FINDING TRIANGLE AREA");
        Console.WriteLine("=============================================================");
        Console.WriteLine("PLEASE, INPUT ONE SIDE OF THE TRIANGLE AND A HEIGH:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("==============================================================");
        Console.WriteLine("THE AREA OF THE TRIANGLE BY THE MATH FORMULA \"S = a x ha / 2\" IS: "+ (a* b)/A);

    }

}