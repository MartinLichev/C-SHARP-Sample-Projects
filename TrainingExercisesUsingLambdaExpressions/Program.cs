using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingExercisesUsingLambdaExpressionsAndLinq;


class Program
{
    public Program(string firstname, string surname, string lastname)
    {

    }
    public static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"       PROGRAM FOR TRAINING IN LAMBDA EXPRESSIONS");
        Console.WriteLine("\n=================================================");

        //LambdaExpressionOrderByInArray();
        //LambdaExpressionEvenNumbersInArray();
        //LambdaExpressionWithArrayOfStrings();
        //LinqMethod();
        //OrderByWithLinqDescending();
        //OrderByWithLinqAscendingOrder();
        //LinqWithListCollection();
        //LinqListOfNumbersCollection();
        //LinqWithCollectionOfStrings();
        //LambdaOnList();
        AnotherLinqExampleWithCollectionOfObjects();





    }

    //using lambda expression with Array
    public static void LambdaExpressionEvenNumbersInArray()
    {
        int[] numbers = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        var evennumbers = numbers.Where(a => a % 2 == 0);

        foreach (var element in evennumbers)
        {
            Console.WriteLine(element);
        }
    }


    //another lambda expression with Array 
    public static void LambdaExpressionOrderByInArray()
    {
        int[] numbers2 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        var order = numbers2.OrderByDescending(a => a == 10);

        foreach (var element in order)
        {
            Console.WriteLine(element);
        }
    }

    //lambda expression with Array of Strings

    public static void LambdaExpressionWithArrayOfStrings()
    {
        string[] names = new[] { "MARTIN", "DIMITAR", "ANGEL", "OGNYAN", "ELENA", "KAMEN", "LILLY" };

        var orderby = names.OrderBy(a => a);

        foreach (var element in orderby)
        {
            Console.WriteLine(element);
        }
    }


    //training with LINQ

    public static void LinqMethod()
    {
        string[] names = new[] { "SOFIA", "LOVDIV", "VARNA", "BURGAS", "VELIKO TARNOVO" };

        var orderby = from name in names where name == "SOFIA" select name;

        foreach (var element in orderby)
        {
            Console.WriteLine(element);
        }
    }

    // orderby with Linq in Descending Order
    public static void OrderByWithLinqDescending()
    {
        int[] numbers = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        var orderby = from number in numbers orderby number descending select number;

        foreach (var element in orderby)
        {
            Console.WriteLine(element);
        }

    }

    // orderby with Linq in Ascending Order

    public static void OrderByWithLinqAscendingOrder()
    {
        int[] numbers = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        var orderby = from number in numbers orderby number ascending select number;

        foreach (var element in orderby)
        {
            Console.WriteLine(element);
        }
    }




    //using Linq in a different collections

    public static void LinqWithListCollection()
    {
        // creating instance of our Person Class

        List<Person> people = new List<Person>()
            {
               new Person("MARTIN","DIMITROV","LICHEV"),
               new Person("DIMITAR","HRISTOV","LICHEV"),
               new Person("ANGEL","HRISTOV","LICHEV"),
               new Person("LILLY","ANGELOVA","LICHEVA"),
               new Person("ELENA","GEORGIEVA","BEROVA"),

            };

        //Ordeeing the elements in the List Alphabetically by first name
        var orderby = from person in people orderby person.Firstname ascending select person;

        foreach (Person element in orderby)
        {
            Console.WriteLine($"{element.Firstname} {element.Surname} {element.Lastname}");
        }

        //Ordering elements in the List By Descending Order By First Name
        var queryoperation = from person in people orderby person.Firstname descending select person;

        foreach (Person element in queryoperation)
        {
            Console.WriteLine($"{element.Firstname} {element.Surname} {element.Lastname}");
        }
    }


    public static void AnotherLinqExampleWithCollectionOfObjects()
    {
        List<River> rivers = new List<River>
            {
                new River("AMAZONKA",6992),
                new River("NILE",6900),
                new River("DANUBE",2300),
                new River("STRUMA",500)

            };

        //Ordering the elements in The List By Name and By Ascending Order
        var orderby1 = from river in rivers orderby river.Name ascending select river;

        foreach (River element in orderby1)
        {
            Console.WriteLine($"{element.Name} {element.Length}");
        }

        //Ordering the elements in The List By Certain Criteria and By Length

        var certaincriteria = from river in rivers where river.Length > 6000 select river;

        foreach(River element in  certaincriteria)
        {
            Console.WriteLine($"{element.Length} {element.Name}");
        }

      
    }


   //using Linq to manipulate List Of Numbers Collection

    public static void LinqListOfNumbersCollection()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Add(8);
        numbers.Add(9);
        numbers.Add(10);

        var orderby = from number in numbers orderby number descending select number;

        foreach (var element in orderby)
        {
            Console.WriteLine(element);
        }
    }

    //using Linq on List Of String Collection

    public static void LinqWithCollectionOfStrings()
    {
        List<string> universities = new List<string>();
        universities.Add("SOFIA UNIVERSITY");
        universities.Add("UNSS");
        universities.Add("TECHNICAL UNIVERSITY");
        universities.Add("SOFTWARE UNIVERSITY");
        universities.Add("AMERICAN UNIVERSITY");

        var names = from name in universities orderby name ascending select name;

        foreach (var element in names)
        {
            Console.WriteLine(element);
        }

        var tolower = from name in universities select name.ToLower();

        foreach (var element in tolower)
        {
            Console.WriteLine(element);
        }

        var tobedecided = from name in universities where name.Contains("A") select name;

        foreach (var element in tobedecided)
        {
            Console.WriteLine(element);
        }
    }

    //using LAMBDA Expression on List Collection

    public static void LambdaOnList()
    {
        List<string> countries = new List<string>();

        countries.Add("BULGARIA");
        countries.Add("BRAZIL");
        countries.Add("COLUMBIA");
        countries.Add("ARGENTINA");
        countries.Add("CUBA");

        var ordering = countries.Where(a => a.Contains("C"));

        foreach (var element in ordering)
        {
            Console.WriteLine(element);
        }

    }
}


  
        

         



