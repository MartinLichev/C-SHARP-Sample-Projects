using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueriesTraining
{
    public class Cars
    {
        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        private string brand;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        private int yearofproduction;

        public int YearOfProduction
        {
            get
            {
                return yearofproduction;
            }
            set
            {
                value = yearofproduction;
            }
        }

        public Cars(string model, string brand, int yearofproduction)
        {
            this.model = model;
            this.brand = brand;
            this.yearofproduction = yearofproduction;
        }

    }


}
