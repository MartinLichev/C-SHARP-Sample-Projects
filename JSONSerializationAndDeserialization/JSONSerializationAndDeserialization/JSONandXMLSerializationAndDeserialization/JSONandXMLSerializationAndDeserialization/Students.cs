using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HomeWork18
{
    [Serializable()]
    public class Student
    {

        private string name;
        private int age;
        private string description;
        private double coursegrade;

        [XmlElement("Name")]
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

        [XmlElement ("Age")]
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
        [XmlElement ("Description")]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        [XmlElement ("Coursegrade")]
        public double Coursegrade
        {
            get
            {
                return coursegrade;
            }

            set
            {
                coursegrade = value;
            }
        }

        public static List<Student> studentslist = new List<Student>();
    }
}
