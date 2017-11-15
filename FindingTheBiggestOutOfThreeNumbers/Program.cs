using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class FindingTheBiggestOutOfThreeNumbers
{
    static void Main()
    {


        Console.WriteLine(@"  PROGRAM FOR FINDING THE ""BIGGEST"" OUT OF ""THREE"" NUMBERS, BY INPUT");
        Console.WriteLine("\n=======================================================================");


        int biggest = 0;
        int number = 0;
        

        for (int a = 0; a < 3; a++)
        {
            Console.Write("\nPLEASE, INPUT A NUMBER:");
            number = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                biggest = number;
            }
            else if(number>biggest)
            {
                biggest = number;
            }
        }
        Console.WriteLine("\nTHE LARGEST NUMBER IS:{0}",biggest);
      
    }
}
            

        
        
    
