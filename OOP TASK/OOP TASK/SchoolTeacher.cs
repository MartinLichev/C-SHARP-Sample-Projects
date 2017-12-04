using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Details;


public class SchoolTeacher : Teacher
{
    private string[] classes;

    public string[] Classes
    {
        get
        {
            return classes;
        }
        set
        {
            classes = value;
        }
    }
    public SchoolTeacher(string firstname, string lastname, int yearsofservice, string subject) : base(firstname, lastname, yearsofservice, subject)
    {

    }

    public static void SchoolTeacherIntroduction(string firstname, string lastname, int yearofservice,string subject)
    {
        Console.WriteLine("MY NAME IS {0}, {1}, I AM SCHOOL-TEACHER FOR {2} YEARS, ON THE SUBJECT OF {3}.", firstname, lastname, yearofservice,subject);
    }


    public static void DisplayClasses()
    {
        string[] classes = { "1B", "8A", "11G", "7V", "12A" };

        Console.WriteLine("\nTHE CLASSES THAT ARE BEING TEACHED ARE:");

        for (int a = 0; a < classes.Length; a++)
        {
            Console.WriteLine("{0};", classes[a]);
        }
    }

    public override void HomeWorkCheck()
    {
        base.HomeWorkCheck();
    }

    public static void MakeChildrenHappy()
    {
        Console.WriteLine("I AM VERY FUNNY, I SHOULD BE A \"CLOWN\" ");

    }
}
