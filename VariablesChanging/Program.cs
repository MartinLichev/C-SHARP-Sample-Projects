using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class SumOf4numbersInputAssigment
{
    static void Main()
    {
        Console.WriteLine(@"      PROGRAM FOR CALCULATING THE SUM OF FOUR NUMBERS:");
        Console.WriteLine("=======================================================");
        Console.WriteLine("PLEASE, INPUT \"4\" NUMBERS:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("THE SUM OF THIS \"4\" NUMBERS IS: " + a + "+" + b + "+" + c + "+" + d + "+" + "=" + (a + b + c + d));
    }
}
