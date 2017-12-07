using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentClassesOOPTask
{
    public class ChildClass:ParentClass
    {
        private string name;

        public string Name1
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        public ChildClass(string name) : base(name)
        {
            this.Name1 = Name;
        }

        public void ChildGreet(string name)
        {
            Console.WriteLine("\nHI, I AM {0} AND I GREET YOU ALL!", name);
        }
    }
}
