using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDogs
{
    public class TwoDogs: Dog
    {
        public TwoDogs(string name, string breed, int age): base(name, breed, age)
        {

        }
        public static void Main(string[] args)
        {

            Console.WriteLine(@"         PROGRAM FOR DISPLAYING ""TWO DOGS"" BEHAVIOR");
            Console.WriteLine("\n=====================================================");

            Dog dog1 = new Dog("JACKIE", "PIT-BULL", 5);
            Dog dog2 = new Dog("MICHAEL", "DACKEL", 7);
            dog1.Greet("JACKIE", "PIT-BULL", 5);
            Console.WriteLine("\n=====================================================");
            dog2.Greet("MICHAEL", "DACKEL", 7);
            Console.WriteLine("\n=====================================================");
            dog1.Sleep("JACKIE", 5);
            Console.WriteLine("\n=====================================================");
            dog2.Sleep("MICHAEL", 2);
            Console.WriteLine("\n=====================================================");
            dog1.Sing("JACKIE");
            Console.WriteLine("\n=====================================================");
            dog2.Sing("MICHAEL");
            Console.WriteLine("\n=====================================================");
            
           
        }
    }
}
