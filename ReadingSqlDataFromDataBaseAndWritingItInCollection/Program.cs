using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ReadingSqlDataFromDataBaseAndWritingItInCollection
{
    public class WritingDataFromSQLDataBaseToCollection
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"        PROGRAM FOR DISPLAYING DATA FROM ""SQL DATA-BASE TABLE"" ");
            Console.WriteLine("\n================================================================");

            using (SqlConnection connection = new SqlConnection("Data Source =DESKTOP-QP4R54P; DataBase = TrainingDataBase2; Integrated Security = true"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("JoiningAllCartoonTables", connection);

                command.CommandType = CommandType.StoredProcedure;


                List<LooneyTunes> cartooncharacters = new List<LooneyTunes>();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LooneyTunes looneytunes = new LooneyTunes();
                    looneytunes.Charactername = reader[0].ToString();
                    looneytunes.Type = reader[1].ToString();
                    looneytunes.Firstappearance = Convert.ToInt32(reader[2]);
                    looneytunes.Moviename = reader[3].ToString();
                    looneytunes.Setname = reader[4].ToString();
                    looneytunes.Setdescription = reader[5].ToString();

                    cartooncharacters.Add(looneytunes);
                }


                foreach (LooneyTunes element in cartooncharacters)
                {
                    Console.WriteLine($"{element.Charactername} {element.Type} {element.Firstappearance} {element.Moviename} {element.Setname} {element.Setdescription}");
                }


                Console.WriteLine("\n===================================================================================================");
                //sorting the elements in "Characters" List Collection, using LINQ

                var sort = from character in cartooncharacters orderby character.Charactername select character;

                foreach(LooneyTunes element in sort)
                {
                    Console.WriteLine($"{element.Charactername}");
                }

                //sorting the element in "Characters" List Collection, usingLINQ

                Console.WriteLine("\n====================================================================================================");
                var sortdescending = from character in cartooncharacters orderby character.Charactername descending select character;

                foreach(LooneyTunes element in sortdescending)
                {
                    Console.WriteLine($"{element.Charactername}");
                }

                //another sorting of the element in "Characters" List Colelection By Year Of Appearance

                Console.WriteLine("\n====================================================================================================");

                var sortbyyear = from character in cartooncharacters orderby character.Firstappearance select character;


                foreach(LooneyTunes element in sortbyyear)
                {
                    Console.WriteLine($"{element.Firstappearance} {element.Charactername}");
                }

                Console.WriteLine("\n===================================================================================================");
                //manipulation of The List Collection, using Lambda Expressions

                var lambdasort = cartooncharacters.Where(character => character.Firstappearance == 1996);

                foreach(LooneyTunes element in lambdasort)
                {
                    Console.WriteLine($"{element.Charactername} {element.Type} {element.Firstappearance} {element.Setdescription} {element.Setname}");
                }

                    using (StreamWriter writer = new StreamWriter(@"D:\READING_AND_WRITING_DEMO\LooneyTunesData.txt"))
                    {
                        foreach (LooneyTunes element in cartooncharacters)
                        {
                        writer.WriteLine($"{element.Charactername} {element.Type} {element.Firstappearance} {element.Moviename} {element.Setname} {element.Setdescription}");
                        }
                    }
                }
            }
        }
    }

