using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastConditionalStatement
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"       PROGRAM FOR DISPLAYING THE ""CURRENT WEATHER CONDITION"", BASED ON INPUT");
            Console.WriteLine("\n==============================================================================");

            Console.Write("\nPLEASE, INPUT A NUMBER TO SEE WHAT IS THE \"WEATHER FORECAST\" FOR TODAY: ");
            int input = int.Parse(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("\nTHE WEATHER IS FREEZING COLD!");
                Console.WriteLine("DO NOT GO, OUTSIDE!");
            }
            else if ((input > 0) && (input <= 10))
            {
                Console.WriteLine("\nTHE WEATHER IS VERY COLD!");
                Console.WriteLine("\nDRESS, VERY WELL, WHEN GOING OUTSIDE!");
            }
            else if ((input > 10) && (input <= 20))
            {
                Console.WriteLine("\nTHE WEATHER IS COLD!");
                Console.WriteLine("\nDRINK, SOMETHING HOT, AND STAY NEAR THE \"FIREPLACE\" ");
            }
            else if ((input > 20) && (input <= 30))
            {
                Console.WriteLine("\nTHE TEMPERATURES ARE GOOD!");
                Console.WriteLine("\nYOU CAN GO OUTSIDE FOR A WALK!");

            }
            else if ((input > 30) && (input <= 40))
            {
                Console.WriteLine("\nTHE WEATHER IS HOT OUTSIDE!");
                Console.WriteLine("\nDRINK, SOMETHING COLD, IF YOU ARE THIRSTY!");
            }
            else if (input > 40)
            {
                Console.WriteLine("\nTHE WEATHER IS VERY HOT!");
                Console.WriteLine("\nDO NOT GO OUTSIDE, OR WILL GET SUN-BURN!");
            }
        }
    }
}
               

