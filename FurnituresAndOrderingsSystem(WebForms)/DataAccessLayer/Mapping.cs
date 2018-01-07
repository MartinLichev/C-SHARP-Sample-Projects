using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Orders = BusinessObjects.Order;
using DataEntity;



namespace DataAccessLayer
{
    public class Mapping
    {
        public static BusinessObjects.Order ToOrdersBusinessEntity(DataEntity.Orders item)
        {
            var result = new BusinessObjects.Order();
            result.Id = item.Id;
            result.Name = item.Name;
            result.Description = item.Description;
            result.Height = item.Height;
            result.Width = item.Width;
            result.CountryOfOrigin = item.CountryOfOrigin;
            return result;
        }

        public static DataEntity.Orders ToOrdersDataEntity(BusinessObjects.Order item)
        {
            var result = new DataEntity.Orders();
            result.Id = item.Id;
            result.Name = item.Name;
            result.Description = item.Description;
            result.Height = item.Height;
            result.Width = item.Width;
            result.CountryOfOrigin = item.CountryOfOrigin;
            return result;
        }


        
    }
}
