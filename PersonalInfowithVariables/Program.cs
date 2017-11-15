using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class Variables_and_PersonalInfo
{
    static void Main()
    {
        string personName = "Dimitar";
        int personAge = 49;
        string eyesColor = "brown";
        decimal bankAccount = 500.5M;
        char specialCharacter = 'D';
        object personGender = "male";

        Console.WriteLine("BASIC PROGRAM FOR DETERMINING PERSON'S CHARACTERISTICS");
        Console.WriteLine("======================================================");
        Console.WriteLine(@"         PERSONAL INFORMATION");
        Console.WriteLine("======================================================");
        Console.WriteLine(@"         NAME:{0}", personName);
        Console.WriteLine(@"         AGE:{0}", personAge);
        Console.WriteLine(@"         SEX:{0}", personGender);
        Console.WriteLine(@"         EYES-COLOR:{0}", eyesColor);
        Console.WriteLine(@"         SPECIAL-CHARACTER:{0}", specialCharacter);
        Console.WriteLine(@"         BANKACCOUNT-SUM:{0}", bankAccount);
    }

}
