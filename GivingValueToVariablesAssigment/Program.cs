using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class VariablesTypes
{
    static void Main()
    {

        int a = -180;
        short b = 5;
        ulong c = 9834289023490;
        double d = 7.7;
        double e = 9.802349004;
        uint f = 1999;
        long g = 123456789123456789;

        Console.WriteLine("BASIC PROGRAM FOR GIVING VALUES TO SPECIFIC VARIABLES");
        Console.WriteLine("=====================================================");
        Console.WriteLine("\"uint\" has value: {0}", a);
        Console.WriteLine("\"short\" has value: {0}", b);
        Console.WriteLine("\"ulong\" has value: {0}", c);
        Console.WriteLine("\"double\" has value: {0}", d);
        Console.WriteLine("\"double\" has value: {0}", e);
        Console.WriteLine("\"int\" has value: {0}", f);
        Console.WriteLine("\"long\" has value: {0}", g);
    }
}