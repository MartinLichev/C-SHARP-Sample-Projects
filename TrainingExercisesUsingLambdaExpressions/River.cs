using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercisesUsingLambdaExpressionsAndLinq
{
    public class River
    {
        private string name;
        private double length;

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

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public River(string name, double length)
        {
            Name = name;
            Length = length;
        }


        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Length);
        }
    }
}
