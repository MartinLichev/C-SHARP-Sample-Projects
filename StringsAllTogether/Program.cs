using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class StringsAllTogether

{
    static void Main()
    {

        Console.WriteLine("PLEASE, INPUT FIRST AND LAST NAME:");
        string FirstName = Console.ReadLine();
        string LastName = Console.ReadLine();
        string FullName = FirstName + " " + LastName;
        Console.WriteLine("YOUR FULL NAME IS: {0}", FullName);
    }
}