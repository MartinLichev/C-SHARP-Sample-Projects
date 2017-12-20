using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys = BusinessObjects.Toys;
using ToysStores = BusinessObjects.ToysStores;
using DataEntity;

namespace DataAccessLayer
{
    public class Mapping
    {

        public static BusinessObjects.Toys ToToysBusinessEntity(DataEntity.Toys toys)
        {
            var result = new BusinessObjects.Toys();
            result.Id = toys.Id;
            result.Description = toys.Description;
            result.Owner = toys.Owner;
            result.Size = toys.Size;

            return result;
        }

        public static BusinessObjects.ToysStores ToToysStoresBusinessEntity(DataEntity.ToysStores stores)
        {
            var result = new BusinessObjects.ToysStores();

            result.Id = stores.Id;
            result.Location = stores.Location;
            result.Size = stores.Size;
            result.StoreOwner = stores.StoreOwner;
            result.ToysCount = stores.ToysCount;

            return result;
        }

        public static DataEntity.Toys ToToysDataEntity(BusinessObjects.Toys toys)
        {

            var result = new DataEntity.Toys();

            result.Id = toys.Id;
            result.Description = toys.Description;
            result.Owner = toys.Owner;
            result.Size = toys.Size;

            return result;
        }

        public static DataEntity.ToysStores ToToysStoresDataEntity(BusinessObjects.ToysStores stores)
        {
            var result = new DataEntity.ToysStores();

            result.Id = stores.Id;
            result.Location = stores.Location;
            result.Size = stores.Size;
            result.StoreOwner = stores.StoreOwner;
            result.ToysCount = stores.ToysCount;


            return result;
        }


    }
}
