using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using Personal.Details;


public class Lecturer : Teacher
{

    public Lecturer(string firstname, string lastname, int yearsofservice, string universityname, string subject) : base(firstname, lastname, yearsofservice, subject)
    {

    }

    public static void LecturerIntroduction(string firstname, string lastname, int yearofservice, string universityname)
    {
        Console.WriteLine("MY NAME IS {0}, {1}, I AM LECTURER FOR {2} YEARS IN {3}.", firstname, lastname, yearofservice,universityname);
    }

    public override void HomeWorkCheck()
    {
        base.HomeWorkCheck();
        Console.WriteLine("THE HOMEWORKS IN THE UNIVERSITY ARE MUCH HARDER, THAN IN SCHOOL!");
    }

    public void TeachingInClass(string firstname)
    {
        Console.WriteLine("DEAR STUDENTS, I AM {0} AND TODAY WE WILL HAVE LECTURE!", firstname);
    }

    public void TeachingInClass(string firstname, string lastname)
    {
        Console.WriteLine("DEAR STUDENT, I AM {0}, {1} AND I AM TEACHING YOU HOW TO STUDY HARD!", firstname, Lastname);
    }

    public void TeachingInClass(string firstname,string lastname,int yearofservice)
    {
        Console.WriteLine("DEAR STUDENTS, I WILL BE TEACHING YOU ON \"MATHS\", MY NAME IS {0}, {1} AND I AM TEACHING FOR {2} YEARS.",firstname,lastname,yearofservice);
    }

    public override void Greeting(string firstname)
    {
        base.Greeting(firstname);
    }



}

