using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrintingNumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine(@"         PROGRAM FOR PRINTING THE NUMBERS FROM ""1 TO N"", BY INPUT ");
        Console.WriteLine("\n===================================================================");
        Console.Write("\nPLEASE, INPUT A NUMBER:");
        int input = int.Parse(Console.ReadLine());

        Console.Write("\nALL THE CONSECUTIVE NUMBERS TO NUMBER \"{0}\" ARE:",input);

        for(int a=1;a<=input;a++)
        {
            Console.Write("{0}; ",a);
        }
    }
}