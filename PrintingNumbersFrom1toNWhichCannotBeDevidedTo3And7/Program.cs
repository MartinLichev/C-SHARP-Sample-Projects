using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class PrinitngNumbersFrom1toNNotDevidedTo3And7
{
    static void Main()
    {
        Console.WriteLine(@"      PROGRAM FOR PRINTING NUMBERS FROM 1 TO N, NOT DEVIDED TO ""3"" AND ""7"" ");
        Console.WriteLine("\n==============================================================================");
        Console.Write("\nPLEASE, INPUT A NUMBER:");
        int input = int.Parse(Console.ReadLine());
        Console.Write("\nTHE CONSECUTIVE NUMBERS, UNTIL \"{0}\" ARE:", input);



        //int devision = 0;
        for (int a = 1; a <= input; a++)
        {


            if ((a % 3 > 0) && (a % 7 > 0))
            {
                Console.Write("{0};", a);
            }
        }
    }
}

            
            

            
            
                        
            
            
 




        
