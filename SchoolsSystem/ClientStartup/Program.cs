using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolsSystem.Data;
using SchoolsSystem.Model;

namespace ClientStartup
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(@"    PROGRAM FOR CREATING SQL DATABASE, USING CODE FIRST APPROACH AND ""ENTITY FRAMEWORK"" ");
            Console.WriteLine("\n=========================================================================================");

            using (var data = new SchoolsDbContext())
            {

                var student = new Student
                {
                    FirstName = "NIKOLAY",
                    LastName = "DANEV",
                    Age = 16,
                    StudentId = 1,
                };

                data.Students.Add(student);

                data.SaveChanges();
            }

            using (var data = new SchoolsDbContext())
            {
                var school = new School
                {
                    Name = "128 SOY NIKOLAY HAITOV",
                    DistrictLocation = "DOWNTOWN",
                    YearOfOpening = 1987,
                };
            }

            using (var data = new SchoolsDbContext())
            {
                List<School> schoolslist = new List<School>
                {
                    new School {Name = "138SOY VASIL ZLATARSKI",DistrictLocation = "GEO MILEV ", YearOfOpening = 1979 },
                    new School {Name = "91SOY IVAN SHISHMAN", DistrictLocation = "REDUTA", YearOfOpening = 1991 },
                    new School {Name = "119OY ELISAVETA BAGRIANA", DistrictLocation = "IZTOK", YearOfOpening = 1998},
                    new School {Name = "31SOU SUCHEM", DistrictLocation = "SITNIAKOVO", YearOfOpening = 1965 },
                    new School {Name = "1SOY ENGLISH HIGHSCHOOL", DistrictLocation = "DOWNTOWN", YearOfOpening = 1995 },
                    new School {Name = "145SOY EMILIAN STANEV", DistrictLocation = "ZAHARNA FABRIKA", YearOfOpening = 1989 },
                };


                foreach (School element in schoolslist)
                {
                    data.Schools.Add(element);
                }

                data.SaveChanges();
            }

            using (var data = new SchoolsDbContext())
            {
                List<Student> studentslist = new List<Student>
                {
                    new Student {FirstName = "MARLON", LastName = "NAKOV", Age = 15, StudentId = 1 },
                    new Student {FirstName = "MARTIN", LastName = "LICHEV", Age = 17, StudentId = 2 },
                    new Student {FirstName = "PETUR", LastName = "PETROV", Age = 16, StudentId = 3 },
                    new Student {FirstName = "MARIA", LastName = "PEKOVA", Age = 17, StudentId = 4 },
                    new Student {FirstName = "BOGDAN", LastName = "TODOROV", Age = 16, StudentId =5 },
                };

                foreach (Student element in studentslist)
                {
                    data.Students.Add(element);
                }

                data.SaveChanges();
            }

            using (var data = new SchoolsDbContext())
            {
                var select = data.Students
                    .Where(s => s.FirstName == "NIKOLAY")
                    .ToList();

                foreach (var element in select)
                {
                    Console.WriteLine($"{element.FirstName} {element.LastName} {element.Age} {element.StudentId}");
                }

            }

            using (var data = new SchoolsDbContext())
            {
                var select = data.Students.Where(s => s.Age > 16).ToList();

                foreach (var element in select)
                {
                    Console.WriteLine($"{element.FirstName} {element.LastName} {element.Age} {element.StudentId}");
                }
            }

            using (var data = new SchoolsDbContext())
            {
                var selectall = from student
                                in data.Students
                                orderby student.FirstName
                                ascending
                                select student;

                foreach (var element in selectall)
                {
                    Console.WriteLine($"{element.FirstName} {element.LastName} {element.Age} {element.StudentId}");
                }

            }


            using (var data = new SchoolsDbContext())
            {
                var join = from student
                           in data.Students
                           join school
                           in data.Schools
                           on student.StudentId
                           equals school.SchoolId
                           select new
                           {
                               Student = student.FirstName,
                               School = school.Name
                           };

                foreach(var element in join)
                {
                    Console.WriteLine($"{element.Student} {element.School}");
                }

            }

        }
    }
}
                          
 
               
               

