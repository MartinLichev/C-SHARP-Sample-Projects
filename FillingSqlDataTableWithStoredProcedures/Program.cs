using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataTraining
{
    public class SqlDataTableFilling
    {

        //Filling Sql Data Table with Stored Procedure, using Connected Model
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          FILLING ""SQL DATABASE TABLE"" ");
            Console.WriteLine("\n===================================");

            using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-QP4R54P; DataBase = TrainingDataBase2; Integrated Security = true"))
            {
                connection.Open();

                for (int a = 0; a < 10; a++)
                {
                    Console.Write("\nPLEASE, INPUT VALUE FOR \"MovieName\" TO INSERT INTO \"CartoonMovies\" DATA TABLE: ");
                    string MovieName = Console.ReadLine();

                    Console.Write("\nPLEASE, INPUT VALUE FOR \"CharacterName\" TO INSERT INTO \"CartoonMovies\" DATA TABLE: ");
                    string CharacterName = Console.ReadLine();

                    SqlCommand command = new SqlCommand("InsertIntoCartoonMovies", connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MovieName", MovieName);
                    command.Parameters.AddWithValue("@CharacterName", CharacterName);

                    object insert = command.ExecuteNonQuery();
                }
            }
        }
    }
}



           

 
