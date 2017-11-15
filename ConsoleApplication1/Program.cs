using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class SwitchStatement
{
    static void Main()
    {
        Console.WriteLine(@"      PROGRAM FOR PRINTING THE MONTH BY GIVEN ""INPUT OF A NUMBER"" ");
        Console.WriteLine("\n===================================================================");

        for (int a = 0; a < 12; a++)
        {
            Console.Write("\nPLEASE, INPUT A \"NUMBER\" IN THE RANGE OF \"1-12\":");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Console.WriteLine("\nTHE CURRENT MONTH IS \"JANUARY\"! "); break;
                case 2: Console.WriteLine("\nTHE CURRENT MONTH IS \"FEBRUARY\"! "); break;
                case 3: Console.WriteLine("\nTHE CURRENT MONTH IS \"MARCH\"! "); break;
                case 4: Console.WriteLine("\nTHE CURRENT MONTH IS \"APRIL\"! "); break;
                case 5: Console.WriteLine("\nTHE CURRENT MONTH IS \"MAY\"! "); break;
                case 6: Console.WriteLine("\nTHE CURRENT MONTH IS \"JUNE\"! "); break;
                case 7: Console.WriteLine("\nTHE CURRENT MONTH IS \"JULY\"! "); break;
                case 8: Console.WriteLine("\nTHE CURRENT MONTH IS \"AUGUST\"! "); break;
                case 9: Console.WriteLine("\nTHE CURRENT MONTH IS \"SEMPTEMBER\"! "); break;
                case 10: Console.WriteLine("\nTHE CURRENT MONTH IS \"OCTOBER\"! "); break;
                case 11: Console.WriteLine("\nTHE CURRENT MONTH IS \"NOVEMBER\"! "); break;
                case 12: Console.WriteLine("\nTHE CURRENT MONTH IS \"DECEMBER\"! "); break;
            }
        }
    }
}
           
