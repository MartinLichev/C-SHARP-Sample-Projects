using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class PrintingPersonalInformation

{
    static void Main()
    {
        Console.WriteLine(@"          PROGRAM FOR PRINTING PERSONAL INFORMATION");
        Console.WriteLine("\n==================================================");
        string FirstName = "MARTIN";
        string LastName = "LICHEV";
        string FullName = FirstName + " " + LastName;
        int Age = 26;
        string Gender = "MALE";
        string ColorOfEyes = "BROWN";
        Console.WriteLine("\nYOUR FIRST NAME IS:{0}",FirstName);
        Console.WriteLine("YOUR LAST NAME IS:{0}",LastName);
        Console.WriteLine("YOUR FULL NAME IS:{0}", FullName);
        Console.WriteLine("YOU ARE {0} OF AGE",Age);
        Console.WriteLine("YOUR GENDER IS {0}",Gender);
        Console.WriteLine("YOU HAVE {0} EYES",ColorOfEyes);
    }
}