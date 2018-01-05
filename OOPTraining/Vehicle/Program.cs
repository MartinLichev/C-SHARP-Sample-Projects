using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Program:Car
    {
        public Program(string model, string brand, int registrationnumber,string color, int yearsofservice, int seatsnumber, string fueltype) :base( model, brand, registrationnumber, color, yearsofservice, seatsnumber, fueltype)
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR DISPLAYING VEHICLE DETAILS");
            Console.WriteLine("\n==========================================");

            Car car = new Car("COUPET", "RENAULT", 122344356, "BROWN", 20, 4, "DIESEL");

            DisplayCarDetails(car);




        }
    }
}
