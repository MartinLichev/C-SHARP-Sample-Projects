using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class MathSum
{
    static void Main()
    {
        int a = 10;
        int b = 2;
        int c = 8;
        int d = 12;

        Console.WriteLine("BASIC MATH PROGRAM FOR CALCULATING THE SUM OF \"4\" NUMBERS");
        Console.WriteLine("THE 1ST NUMBER HAS A VALUE: {0}", a);
        Console.WriteLine("THE 2ND NUMBER HAS A VALUE: {0}", b);
        Console.WriteLine("THE 3RD NUMBER HAS A VALUE: {0}", c);
        Console.WriteLine("THE 4TH NUMBER HAS A VALUE: {0}", d);
        Console.WriteLine("THE SUM OF THOSE FOUR NUMBERS IS: " + a + "+" + b + "+" + c + "+" + d + "=" + (a + b + c + d));
    }
}