using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.Entity;
using DataEntity;
using BusinessObjects;


namespace DataBaseTest
{
    public class Program:DataManipulations
    {
        public static ToysDataBaseEntities data = new ToysDataBaseEntities();
        public static void Main(string[] args)
        {
            BusinessObjects.Toys toy = new BusinessObjects.Toys
            {
                Id=1,
                Description = "white action-figure with black pants",
                Owner = "Martin Lichev",
                Size = 2000,
            };

            BusinessObjects.ToysStores stores = new BusinessObjects.ToysStores
            {
                Id = 1,
                Location = "near, the capital \"Downtown\" ",
                Size = 30000,
                StoreOwner ="Dimitar Lichev",
                ToysCount = 500,
            };

            BusinessObjects.Toys toy1 = new BusinessObjects.Toys
            {
                Id =1, 
                Description ="Barbie figure, for the girls",
                Owner = "Lilly Licheva",
                Size = 200,
            };

            BusinessObjects.ToysStores store1 = new BusinessObjects.ToysStores
            {

                Id=1,
                Location = "near The Central Railways Station",
                Size = 2000,
                StoreOwner ="Petur Petrov",
                ToysCount = 2000,
            };

            CreateToysRecord(toy);

            CreateToysStoresRecord(stores);

            ReadAllFromToys();

            ReadAllFromToysStores();

            DeleteToysRecord(1);

            DeleteToysStoresRecord(1);

            UpdateToysRecord(toy1, 1);

            UpdateToysStoresRecord(store1, 1);


        }

        public static void UpdateToysRecord(BusinessObjects.Toys item, int id)
        {
            var input = Mapping.ToToysDataEntity(item);

            var databaseitem = data.Toys.FirstOrDefault(a => a.Id == id);

            if (databaseitem != null)
            {
                databaseitem.Id = input.Id;
                databaseitem.Description = input.Description;
                databaseitem.Owner = input.Owner;
                databaseitem.Size = input.Size;
                data.SaveChanges();
            }
        }


        public static void UpdateToysStoresRecord(BusinessObjects.ToysStores item, int id)
        {
            var input = Mapping.ToToysStoresDataEntity(item);

            var databaseitem = data.ToysStores.FirstOrDefault(a => a.Id == id);

            if (databaseitem != null)
            {
                databaseitem.Id = input.Id;
                databaseitem.Location = input.Location;
                databaseitem.Size = input.Size;
                databaseitem.StoreOwner = input.StoreOwner;
                databaseitem.ToysCount = input.ToysCount;
                data.SaveChanges();
            }
        }
    }
}
