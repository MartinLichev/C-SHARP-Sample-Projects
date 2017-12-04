using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqQueriesTraining;

namespace LinqQueriesTraining
{
    public class TrainingInLinqQueries : Cars
    {
        public TrainingInLinqQueries(string brand, string model, int yearofproduction) : base(model, brand, yearofproduction)
        {

        }
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR TRAINING IN LINQ QUERIES");
            Console.WriteLine("\n=============================================");


            //training on LAMBDA and LINQ expressions

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evennumbers = numbers.Where(a => a % 2 == 0);

            foreach (var element in evennumbers)
            {
                Console.WriteLine(element);
            }


            //more exercises on LAMBDA and LINQ expressions

            var People = new[]
            {
                new {FirstName ="MARTIN", LastName ="LICHEV", Age =27 },
                new {FirstName ="DIMITAR", LastName ="LICHEV",Age =50},
                new {FirstName ="ANGEL", LastName ="LICHEV",Age =55},
                new {FirstName ="LILLY", LastName ="LICHEVA",Age = 23},
            };

            var undercertainage = People.Where(a => a.Age < 50);

            foreach (var element in undercertainage)
            {
                Console.WriteLine(element);
            }


            // exercises on LINQ 

            List<int> mylist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            var evennumbers1 = from integer in mylist where integer % 2 == 0 select integer;

            foreach (var element in evennumbers)
            {
                Console.WriteLine(element);
            }


            // more xomplex LINQ exercises 

            Cars car1 = new Cars("COUPET", "MERCEDES", 1990);
            Cars car2 = new Cars("SEDAN", "BMW", 1999);
            Cars car3 = new Cars("SHEVROLET", "CAPTIVA", 1980);
            Cars car4 = new Cars("ASTRA", "OPEL", 1982);



            List<object> myobjectlist = new List<object>();
            myobjectlist.Add(car1);
            myobjectlist.Add(car2);
            myobjectlist.Add(car3);
            myobjectlist.Add(car4);


            var cars = myobjectlist.Where()



            // another training in Linq 

            string[] countries = { "ALBANIA", "BULGARIA", "TURKEY", "BOTSWANA", "GHANA", "GREECE", "AMERICA", "COSTA RICA" };

            var test = from name in countries where name.StartsWith("A") select name;

            foreach (var element in test)
            {

                Console.WriteLine(element);
            }

            Console.WriteLine("\n=======================================================================");

            var test1 = from name in countries where name.Contains("T") select name;

            foreach(var element in test1)
            {
                Console.WriteLine(element);
            }

            //using LAMBDA Expression

            Console.WriteLine("\n=====================================================================");

            var test2 = countries.Where(a => a.Contains("T"));

            foreach(var element in test2)
            {
                Console.WriteLine(element);
            }


        }
    }
}



            









            

  

        

            
