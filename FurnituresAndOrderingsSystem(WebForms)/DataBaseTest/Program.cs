using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessObjects;
using DataEntity;
using DataAccessLayer;


namespace DataBaseTest
{
    public class DataBaseTest
    {
        public static FurnituresAndOrdersDataBaseEntities entity = new FurnituresAndOrdersDataBaseEntities();
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1,
                Name = "Plastic Chair",
                Description = "comfty chair made of rubber plastic",
                Height = 90,
                Width = 110,
                CountryOfOrigin = "Germany",

            };



        }
    }
}
