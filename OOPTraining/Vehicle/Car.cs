using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car
    {
        string model;
        string brand;
        int registrationnumber;
        string color;
        int yearsofservice;
        int seatsnumber;
        string fueltype;

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

        public int Registrationnumber
        {
            get
            {
                return registrationnumber;
            }

            set
            {
                registrationnumber = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
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

        public int Seatsnumber
        {
            get
            {
                return seatsnumber;
            }

            set
            {
                seatsnumber = value;
            }
        }

        public string Fueltype
        {
            get
            {
                return fueltype;
            }

            set
            {
                fueltype = value;
            }
        }

        public Car(string model, string brand, int registrationnumber, string color, int yearsofservice, int seatsnumber, string fueltype)
        {
            this.model = model;
            this.brand = brand;
            this.registrationnumber = registrationnumber;
            this.color = color;
            this.yearsofservice = yearsofservice;
            this.seatsnumber = seatsnumber;
            this.fueltype = fueltype;
        }

        public static void DisplayCarDetails(Car @object)
        {
            Console.WriteLine("\nTHE CAR MODEL IS {0}", @object.model);
            Console.WriteLine("\nTHE CAR BRAND IS {0}", @object.brand);
            Console.WriteLine("\nTHE CAR REGISTRATIONNUMBER IS {0}", @object.registrationnumber);
            Console.WriteLine("\nTHE CAR COLOR IS {0}", @object.color);
            Console.WriteLine("\nTHE CAR HAS TOTAL OF {0} SEATS", @object.seatsnumber);
            Console.WriteLine("\nTHE CAR FUEL-TYPE IS {0}", @object.fueltype);

        }
    }
}
