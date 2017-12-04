using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ADO.NetDisconectedModel
{
    public class ManipulationwithSqlDataBaseWithDisconnectedModel
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"     PROGRAM FOR READING DATA FROM SQL DATA BASE, USING DISCONNECTED MODEL");
            Console.WriteLine("\n=========================================================================");


            string connection = "Data Source = DESKTOP-QP4R54P; DataBase = FamousCitcoms; Integrated Security = true";

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FamousCitcoms", connection);

            DataSet data = new DataSet();

            adapter.Fill(data, "FamousCitcoms");

            DataTable datatable = data.Tables["FamousCitcoms"];

            foreach (DataRow rows in datatable.Rows)
            {
                Console.WriteLine($"{rows[0]} {rows[1]} {rows[2]}");
            }

            
        }
    }
}



            


            

