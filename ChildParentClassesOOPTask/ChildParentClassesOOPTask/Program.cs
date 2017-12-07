using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentClassesOOPTask
{
    public class ChildParentClasses: ChildClass
    {
        public ChildParentClasses(string name):base(name)
        {

        }
        public static void Main(string[] args)
        {

            Console.WriteLine(@"        PROGRAM, FOR DISPLAYING BASIC ""OOP"" INHERITANCE BETWEEN CHILD AND PARENT CLASSES!");
            Console.WriteLine("\n==========================================================================================");

            ParentClass parent = new ParentClass("PARENT");
            ChildClass child = new ChildClass("CHILD");
            parent.ParentGreet("PARENT");
            child.ChildGreet("CHILD");
        }
    }
}
