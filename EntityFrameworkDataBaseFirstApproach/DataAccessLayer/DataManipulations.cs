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
    public class DataManipulations
    {

        public static ToysDataBaseEntities data = new ToysDataBaseEntities();
        public static void CreateToysRecord(BusinessObjects.Toys item)
        {
            var input = Mapping.ToToysDataEntity(item);

            data.Toys.Add(input);

            data.SaveChanges();
        }

        public static void CreateToysStoresRecord(BusinessObjects.ToysStores item)
        {
            var input = Mapping.ToToysStoresDataEntity(item);

            data.ToysStores.Add(input);

            data.SaveChanges();
        }

        public static void DeleteToysRecord(int id)
        {

            var databaseitem = data.Toys.FirstOrDefault(a => a.Id == id);

            if(databaseitem != null)
            {
                data.Toys.Remove(databaseitem);

                data.SaveChanges();
            }

        }

        public static void DeleteToysStoresRecord(int id)
        {

            var databaseitem = data.ToysStores.FirstOrDefault(a => a.Id == id);

            if(databaseitem != null)
            {
                data.ToysStores.Remove(databaseitem);

                data.SaveChanges();
            }
        }

        public static void ReadAllFromToys()
        {
            var read = data.Toys.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Id} {element.Description} {element.Owner} {element.Size}");
            }
        }

        public static void ReadAllFromToysStores()
        {
            var read = data.ToysStores.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Id} {element.Location} {element.Size} {element.StoreOwner} {element.ToysCount}");
            }

        }

    }
}
