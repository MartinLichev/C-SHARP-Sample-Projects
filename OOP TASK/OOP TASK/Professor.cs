using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Details;


public class Professor : Lecturer
{
    public Professor(string firstname, string lastname, int yearsofservice, string universityname, string subject, string honoristitle) : base(firstname, lastname, yearsofservice, universityname, subject)
    {

    }

    public static void DisplayingHonorisAndYearsOfService(string firstname, string honoristitle, int yearsofservice)
    {
        Console.WriteLine("I AM {0}, AND MY TITLE IS {1}, I TEACH FOR {2} YEARS", firstname, honoristitle, yearsofservice);
    }

    public override void HomeWorkCheck()
    {
        base.HomeWorkCheck();
        Console.WriteLine("YOU ARE NOT STUDENTS ANY LONGER, IF YOU DO NOT WRITE YOU HOMEWORK YOU ARE GOING TO BE EXPELED!");
    }

    public static void ConductInExams()
    {
        Console.WriteLine("DEAR STUDENTS, I CAN CONDUCT IN EXAMS.");
    }
}

