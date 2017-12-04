using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Personal.Details;

public class DifferentJobs
{
    static void Main()
    {
        Console.WriteLine(@"         PROGRAM FOR DISPLAYING INFORMATION FOR DIFFERENT JOB TYPES AND THEIR ACTIVITIES. ");
        Console.WriteLine("\n=============================================================================================");

        Teacher teacher = new Teacher("NIKOLAY", "DANEV", 5, "HISTORY CLASS");
        Lecturer lecturer = new Lecturer("CHAVDAR", "KIRILOV", 10, "SOFIA UNIVERSITY", "ARCHAEOLOGY");
        Assistant assistant = new Assistant("IVAYLO", "LOZANOV", 8, "GREEN UNIVERSITY", "PHLOSOPHY", true);
        Professor professor = new Professor("TOTKO", "STOYANOV", 25, "MATHS UNIVERISTY", "METHODOLOGY", "PROFESSOR");
        CollegeTeacher collegeteacher = new CollegeTeacher("RUMI", "LAZAROVA", 15, "ENGLISH LANGUAGE", "AMERICAN COLLEGE");
        SchoolTeacher schoolteacher = new SchoolTeacher("VESELA", "POPOVA", 2, "MATHS COURSES");


        Teacher.TeacherIntroduction("NIKOLAY", "DANEV", 5, "HISTORY CLASS");
        teacher.Greeting("NIKOLAY");
        teacher.HomeWorkCheck();
        Teacher.SayingGoodbye("NIKOLAY");
        Console.WriteLine("\n=============================================================================================");
        Lecturer.LecturerIntroduction("CHAVDAR", "KIRILOV", 10, "SOFIA UNIVERISTY");
        lecturer.Greeting("CHAVDAR");
        lecturer.TeachingInClass("CHAVDAR");
        lecturer.TeachingInClass("CHAVDAR", "KIRILOV");
        lecturer.TeachingInClass("CHAVDAR", "ARCHAEOLOGY", 10);
        lecturer.HomeWorkCheck();
        Console.WriteLine("\n=============================================================================================");
        Assistant.AssistantIntroduction("IVAYLO", "LOZANOV", 8, "GREEN UNIVERSITY", "PHLOSOPHY");
        assistant.Greeting("IVAYLO");
        assistant.TeachingInClass("IVAYLO");
        assistant.HomeWorkCheck();
        Assistant.WritingScienceArticles("CHAVDAR");
        Assistant.CheckingExams("CHAVDAR");
        Console.WriteLine("\n=============================================================================================");
        professor.Greeting("TOTKO");
        Professor.DisplayingHonorisAndYearsOfService("TOTKO", "PROFESSOR", 25);
        Professor.ConductInExams();
        professor.TeachingInClass("TOTKO");
        professor.HomeWorkCheck();
        Console.WriteLine("\n=============================================================================================");
        SchoolTeacher.SchoolTeacherIntroduction("VESELA", "POPOVA", 2, "MATHS COURSES");
        schoolteacher.Greeting("VESELA");
        SchoolTeacher.MakeChildrenHappy();
        SchoolTeacher.DisplayClasses();
        schoolteacher.HomeWorkCheck();
        Console.WriteLine("\n=============================================================================================");
        CollegeTeacher.CollegeTeacherIntroduction("RUMI", "LAZAROVA", 15, "ENGLISH LANGUAGE", "AMERICAN COLLEGE");
        collegeteacher.HomeWorkCheck();









    }
}

