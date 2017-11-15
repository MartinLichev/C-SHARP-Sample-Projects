using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class PrintingTheCurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine(@"          PROGRAM FOR PRINTING THE ""CURRENT DATE AND TIME"" ");
        Console.WriteLine("\n============================================================");

        DateTime current = DateTime.Now;
        Console.WriteLine("\nTHE CURRENT DATE AND TIME IS:{0}",current);
    }
}