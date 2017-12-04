using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Details;


public class Assistant : Lecturer
{
    public Assistant(string firstname, string lastname, int yearsofservice, string universityname, string subject, bool isassistantornot) : base(firstname, lastname, yearsofservice, universityname, subject)
    {

    }

    public static void AssistantIntroduction(string firstname, string lastname, int yearofservice, string universityname, string subject)
    {
        Console.WriteLine("MY NAME IS {0}, {1}, I AM ASSISTANT FOR {2} YEARS IN {3}, ON THE SUBJECT OF {4}.", firstname, lastname, yearofservice, universityname,subject);
    }

    public static void WritingScienceArticles(string firstname)
    {
        Console.WriteLine("MY NAME IS {0}, AND I CAN WRITE SCIENCE ARTICLES",firstname);
    }

    public override void HomeWorkCheck()
    {
        base.HomeWorkCheck();
        Console.WriteLine("YOU ARE NOT IN SHOOL ANY MORE SO HOMEWORKS ARE GOING TO BE HARD FROM NOW ON!");
    }

    public static void CheckingExams(string firstname)
    {
        Console.WriteLine("DEAR STUDENTS, I AM {0}, I TEACH IN {0} AND I CAN CHECK EXAMS.",firstname);
    }
}

