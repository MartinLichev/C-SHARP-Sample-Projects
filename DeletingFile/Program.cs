using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeletingFile
{
   public class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"       PROGRAM FOR DELETING A FILE FROM THE MACHINE");
            Console.WriteLine("\n==================================================");

            File.Delete(@"D:\CSHARP\EXERCISES\training.txt");


        }
    }
}
