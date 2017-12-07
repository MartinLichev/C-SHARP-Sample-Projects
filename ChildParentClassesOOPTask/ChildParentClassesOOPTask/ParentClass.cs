using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentClassesOOPTask
{
    public class ParentClass
    {
        private string name;

        public string Name
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

        public ParentClass(string name)
        {
            this.name = name;
        }

        public void ParentGreet(string name)
        {
            Console.WriteLine("\nHI, I AM {0} AND I GREET YOU ALL!", name);
        }
    }
}
