using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingBonusPointsOutOfGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"     PROGRAM FOR CALCULATING BONUS POINTS OUT OF A GAME!");
            Console.WriteLine("\n=======================================================");

            Console.Write("\nPLEASE, INPUT NUMBER TO SEE YOU BONUS POINTS FOR THE GAME!");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 5));
                    break;
                case 2:
                    Console.WriteLine("YOUR BONUS POINT ARE = {0}", (input * 5));
                    break;
                case 3:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 5));
                    break;
                case 4:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 10));
                    break;
                case 5:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 10));
                    break;
                case 6:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 10));
                    break;
                case 7:
                    Console.WriteLine("YPUR BONUS POINTS ARE = {0}", (input * 50));
                    break;
                case 8:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 50));
                    break;
                case 9:
                    Console.WriteLine("YOUR BONUS POINTS ARE = {0}", (input * 50));
                    break;
            }
        }
    }
}
