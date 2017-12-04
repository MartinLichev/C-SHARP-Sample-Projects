using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NetConnectedModel
{
    public class ReadingDataFromSqlDataBaseUsingConnectedModel:Actors
    {

        public static List<Actors> actorslist = new List<Actors>();
        public static List<FamousCitcoms> famouscitcomslist = new List<FamousCitcoms>();

        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM FOR READING DATA FROM ""SQL DATA BASE"" USING CONNECTED MODEL");
            Console.WriteLine("\n=============================================================================");

            using (SqlConnection connection = new SqlConnection("Data Source =DESKTOP-QP4R54P; DataBase = FamousCitcoms; Integrated Security = true"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM FamousCitcoms", connection);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    FamousCitcoms famouscitcoms = new FamousCitcoms();
                    famouscitcoms.name = reader[0].ToString();
                    famouscitcoms.famousactor = reader[1].ToString();
                    famouscitcoms.datefirstaired = Convert.ToInt32(reader[2]);



                    famouscitcomslist.Add(famouscitcoms);
                }
            }

            using (SqlConnection connection1 = new SqlConnection("Data Source =DESKTOP-QP4R54P; DataBase = FamousCitcoms; Integrated Security = true"))
            {
                connection1.Open();


                SqlCommand command1 = new SqlCommand("SELECT * FROM Actors", connection1);

                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    Actors actors = new Actors();

                    actors.actorname = reader1[0].ToString();
                    actors.actorage = Convert.ToInt32(reader1[1]);

                    actorslist.Add(actors);


                }
            }

           
            DisplayActorsList();
            Console.WriteLine("\n==================================");
            DisplayFamousCitcoms();
            Console.WriteLine("\n==================================");
            JoinTwoRecords();
            Console.WriteLine("\n==================================");
            SelectionUponSpecificCriteria();
            Console.WriteLine("\n==================================");
            SelectCertainRecords();
            Console.WriteLine("\n==================================");
            SingleSelection();
            Console.WriteLine("\n==================================");
            OrderAlphabetically();
            
           
           
        }

        public static void DisplayActorsList()
        {
            var select = from actor
                         in actorslist
                         orderby actor.actorname
                         ascending
                         select actor;

            foreach (var element in select)
            {
                Console.WriteLine($"{element.actorname} {element.actorage}");
            }
            
        }

        public static void DisplayFamousCitcoms()
        {
            var select = from citcom
                         in famouscitcomslist
                         orderby citcom.famousactor
                         ascending
                         select citcom;

            foreach(var element in select)
            {
                Console.WriteLine($"{element.famousactor} {element.name} {element.datefirstaired}");
            }
                       
                         
        }

        public static void JoinTwoRecords()
        {
            var join = from actor 
                       in actorslist
                       join citcom
                       in famouscitcomslist
                       on actor.actorname equals
                       citcom.famousactor orderby
                       actor.actorname ascending
                       select new {actorslist = actor, famouscitcomslist = citcom};

            foreach(var element in join)
            {
                Console.WriteLine($"{element.actorslist.actorname} {element.actorslist.actorage} {element.famouscitcomslist.name} {element.famouscitcomslist.famousactor} {element.famouscitcomslist.datefirstaired}");
            }
        }

        //using LAMBDA Expresssion
        public static void SelectionUponSpecificCriteria()
        {
            var special = actorslist.Where(a => a.actorage > 50);


            foreach(var element in special)
            {
                Console.WriteLine($"{element.actorname} {element.actorage}");
            }
        }

        //the same record selection using LAMBDA Expression
        public static void SelectCertainRecords()
        {
            var selectspecial = from actor
                                in actorslist
                                where actor.actorage > 50
                                select actor;


            foreach(var element in selectspecial)
            {
                Console.WriteLine($"{element.actorname} {element.actorage}");
            }
        }

        //select only one record upon specific criteria

        public static void SingleSelection()
        {
            var singleselect = from citcom
                               in famouscitcomslist
                               where citcom.name == "F.R.I.E.N.D.S"
                               select citcom;

            foreach(var element in singleselect)
            {
                Console.WriteLine($"{element.name} {element.famousactor} {element.datefirstaired}");
            }
        }


        //ordering with LINQ alphabetically
        public static void OrderAlphabetically()
        {
            var order = from actor
                        in actorslist
                        orderby actor.actorname
                        ascending
                        select actor;

            foreach(var element in order)
            {
                Console.WriteLine($"{element.actorname} {element.actorage}");
            }
        }


    }
}

