using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class GetTraingleArea
{
    static void Main()
	{ 
       int sideA = 8;
	   int heightB = 10;
	   int number = 2;
	   string TriangleFormula = ((sideA * heightB) / 2);
	  
	  
	  Console.WriteLine("BASIC PROGRAM FOR GETTING THE ARE OF A TRIANGLE:");
      Console.WriteLine("================================================");
      Console.WriteLine("WE ARE GIVEN TWO SIDES OF THE TRIANGLE!");
	  Console.WriteLine("\"sideA\" HAS A GIVEN VALUE OF:",sideA);
	  Console.WriteLine("\"heightB\" HAS A GIVEN VALUE OF:",heightB);
      Console.WriteLine("THE FORMULA FOR FINDING THE AREA OF A TRIANGLE IS: S= a X h / 2");
	  Console.WriteLine("THE AREA OF OUR GIVEN TRIANGLE IS: S = {0} X {1} / 2 = {2}",sideA, heightB, TriangleFormula);
	}
   } 