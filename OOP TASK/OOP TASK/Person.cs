using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Personal.Details
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int yearsofservice;

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

        public int Yearsofservice
        {
            get
            {
                return yearsofservice;
            }

            set
            {
                yearsofservice = value;
            }
        }

        public Person(string firstname, string lastname, int yearsofservice)
        {

        }

        public virtual void Greeting(string firstname)
        {
            Console.WriteLine("HELLO, THERE MY NAME IS {0}!", firstname);
        }

        
    
    }
}