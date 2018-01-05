using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicle
{
    public class Program:MotorBike
    {
        public Program(string model, string brand, int yearofmanufacturing, double maxspeed): base(model, brand, yearofmanufacturing, maxspeed)
        {

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(@"        PROGRAM FOR DISPLAYING INFORMATION ABOUT MOTOR-VEHICLE ");
            Console.WriteLine("\n======================================================");

            MotorBike bike = new MotorBike("TURBO-X", "BMW", 1999, 120.20);
            MotorBike bike1 = new MotorBike("VIPER", "YAMAHA", 2015, 200.10);
            MotorBike bike2 = new MotorBike("GTX", "MITSUBISHI", 2010, 210.20);

            DisplayMotorBike(bike);

            DisplayMotorBike(bike1);

            DisplayMotorBike(bike2);




        }
    }
}
