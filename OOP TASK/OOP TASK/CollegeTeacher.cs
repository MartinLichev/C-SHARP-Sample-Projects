using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Details;


public class CollegeTeacher : Teacher
{
    public CollegeTeacher(string firstname, string lastname, int yearsofservice, string subject, string nameofcollege) : base(firstname, lastname, yearsofservice, subject)
    {

    }

    public static void CollegeTeacherIntroduction(string firstname, string lastname, int yearofservice, string nameofcollege, string subject)
    {
        Console.WriteLine("MY NAME IS {0}, {1}, I AM COLLEGE-TEACHER FOR {2} YEARS IN {3}, ON THE SUBJECT OF {4}.", firstname, lastname, yearofservice, nameofcollege, subject);
    }

    public override void HomeWorkCheck()
    {
        base.HomeWorkCheck();
    }
}

