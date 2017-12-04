using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSpecificStudentsFromStudentClass
{
    public class Student 
    {

        private string firstname;
        private string lastname;
        private int age;

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Student(string Firstname, string Lastname, int Age)
        {
            firstname = Firstname;
            lastname = Lastname;
            age = Age;


        }


        public static void FindingSpecificStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student("MARTIN","LICHEV",15),
                new Student("OGNYAN","RADENKOV",18),
                new Student("MARLON","NAKOV",17),
                new Student("ORLIN","OPRALOV",17),
                new Student("DIMITAR","PETROV",15),
                new Student("PLAMEN","MOLOV",17),
                new Student("VASIL","PETROV",18)
            };


            var order = from student in students orderby student.Firstname ascending select student;


            foreach(Student element in order)
            {
                Console.WriteLine($"{element.Firstname} {element.Lastname} {element.Age}");
            }



           





        }
    }
}
