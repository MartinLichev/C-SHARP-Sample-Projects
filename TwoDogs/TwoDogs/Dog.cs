using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDogs
{
    public class Dog : IAnimal
    {
        private string name;
        private string breed;
        private int age;

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

        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
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

        public Dog(string name, string breed, int age)
        {

        }

        public void Greet(string name, string breed, int age)
        {
            Console.WriteLine("\nHELLO, MY NAME IS {0}, I AM - {1}, AND I AM {2} OF AGE!",name, breed, age);
        }

        public void Sleep(string name, int hours)
        {
            Console.WriteLine("HI, I {0} AM VERY TIRED AND WILL SLEEP FOR {1} hours!",name, hours);
        }

        public void Sing(string name)
        {
            Console.WriteLine("HI, I {0} WILL SING A SONG FOR YOU ALL!", name);
        }
    }
}
