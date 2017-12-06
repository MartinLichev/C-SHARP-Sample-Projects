using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingEligibility
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"        PROGRAM FOR CHECKING IF SOMEONE IS ELIGIBLE TO VOTE! ");
            Console.WriteLine("\n============================================================");

            Console.Write("\nPLEASE, INPUT YOUR AGE: ");
            int input = int.Parse(Console.ReadLine());

            string voteeligibility = (input >= 18) ? "CANDIDATE IS ELIGIBLE TO VOTE!" : "CANIDATE IS NOT ELIGIBLE TO VOTE!";

            Console.WriteLine("\n{0}",voteeligibility);
        }
    }
}
