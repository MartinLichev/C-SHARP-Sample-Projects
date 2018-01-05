using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicle
{
    public class MotorBike
    {
        string model;
        string brand;
        int yearofmanufacturing;
        double maxspeed;

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

        public int Yearofmanufacturing
        {
            get
            {
                return yearofmanufacturing;
            }

            set
            {
                yearofmanufacturing = value;
            }
        }

        public double Maxspeed
        {
            get
            {
                return maxspeed;
            }

            set
            {
                maxspeed = value;
            }
        }

        public MotorBike(string model, string brand, int yearofmanufacturing, double maxspeed)
        {
            this.model = model;
            this.brand = brand;
            this.yearofmanufacturing = yearofmanufacturing;
            this.maxspeed = maxspeed;
        }

        public static void DisplayMotorBike(MotorBike @object)
        {
            Console.WriteLine("\nTHE MOTOR-BIKE MODEL IS {0}",@object.model);
            Console.WriteLine("\nTHE MOTOR-BIKE BRAND IS {0}",@object.brand);
            Console.WriteLine("\nTHE MOTOR-BIKE YEAR OF MANUFACTURING IS {0}",@object.yearofmanufacturing);
            Console.WriteLine("\nTHE MOTOR-BIKE MAX SPEED IS {0}", @object.maxspeed);

        }
    }
}
