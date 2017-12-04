using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Details;


public class Teacher : Person
{
    public string subject;
    private string firstname;
    private string lastname;
    private int yearsofservice;

    public string Subject
    {
        get
        {
            return subject;
        }
        set
        {
            subject = value;
        }
    }

   

    public Teacher(string firstname, string lastname, int yearsofservice, string subject) : base(firstname, lastname, yearsofservice)
    {

    }

    


    public virtual void HomeWorkCheck()
    {
        Console.WriteLine("I AM CHECKING THE HOMEWORK!");
    }

    public override void Greeting(string firstname)
    {
        base.Greeting(firstname);
        Console.WriteLine("GOOD DAY STUDENTS, I AM YOUR TEACHER-{0}",firstname );
    }


    public static void TeacherIntroduction(string firstname, string lastname, int yearofservice, string subject)
    {
        Console.WriteLine("MY NAME IS {0}, {1}, I AM TEACHER FOR {2} YEARS IN {3}.",firstname,lastname,yearofservice,subject);
    }
    public static void SayingGoodbye(string firstname)
    {
        Console.WriteLine("I {0}, WANT TO SAY TO YOU GOODBYE!",firstname);
    }
}

