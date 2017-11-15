using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class StringAssigment
{
    static void Main()
    {
        string myStr = "Hello World";
        string extract1 = myStr.Substring(0,5);
        string extract2 = myStr.Substring(5);
        myStr = myStr.Replace("World", "Programing");
        int a = myStr.Length;
        int b = myStr.IndexOf("W");
        myStr = myStr.ToUpper();
        Console.WriteLine(@"         PROGRAM FOR PRACTICING WITH THE ""STRINGS"" ");
        Console.WriteLine("================================================================");
        Console.WriteLine(extract1);
        Console.WriteLine(extract2);
        Console.WriteLine(myStr);
        Console.WriteLine(a);
        Console.WriteLine(b);
        


    }
}
