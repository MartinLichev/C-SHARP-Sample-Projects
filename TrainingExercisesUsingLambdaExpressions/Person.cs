using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingExercisesUsingLambdaExpressionsAndLinq
{
    public class Person
    {
        private string firstname;
        private string surname;
        private string lastname;

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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
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
        public Person(string firstname, string surname, string lastname)
        {
            Firstname = firstname;
            Surname = surname;
            Lastname = lastname;

        }
    }
}


