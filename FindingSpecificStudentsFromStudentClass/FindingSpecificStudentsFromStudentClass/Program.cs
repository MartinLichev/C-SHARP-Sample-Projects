using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSpecificStudentsFromStudentClass
{
    public class FindingSpecificStudentFromStudentClass: Student
    {
        public FindingSpecificStudentFromStudentClass(string Firstname, string Lastname, int Age) : base( Firstname, Lastname, Age)
        {

        }
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM FOR FINDING SPECIFIC STUDENT OUT OF STUDENT CLASS");
            Console.WriteLine("\n=================================================================");

            FindingSpecificStudent();


            
            


        }
    }
}
