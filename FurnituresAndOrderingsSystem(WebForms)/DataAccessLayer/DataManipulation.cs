using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataEntity;
using BusinessObjects;

namespace DataAccessLayer
{
    public class DataManipulation
    {

        public static FurnituresAndOrdersDataBaseEntities entity = new FurnituresAndOrdersDataBaseEntities();
        public static void CreateOrdersRecord(Order item)
        {
            var map = Mapping.ToOrdersDataEntity(item);

            entity.Orders.Add(map);

            entity.SaveChanges();

        }


        public static void DeleteOrdersRecord(int id)
        {
            var databaseitem = entity.Orders.FirstOrDefault(a => a.Id == id);

            if (databaseitem != null)
            {
                entity.Orders.Remove(databaseitem);

                entity.SaveChanges();
            }
        }

        public static void ReadAllFromOrders()
        {
            var read = entity.Orders.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Id} {element.Name} {element.Description} {element.Height} {element.Width} {element.CountryOfOrigin}");
            }
        }

        public static void UpdateOrdersRecord(Order item, int id)
        {
            var map = Mapping.ToOrdersDataEntity(item);

            var databaseitem = entity.Orders.FirstOrDefault(a => a.Id == id);

            if(databaseitem != null)
            {
                databaseitem.Id = item.Id;
                databaseitem.Name = item.Name;
                databaseitem.Description = item.Description;
                databaseitem.Height = item.Height;
                databaseitem.Width = item.Width;
                databaseitem.CountryOfOrigin = item.CountryOfOrigin;

                entity.SaveChanges();
            }
        }

    }
}
