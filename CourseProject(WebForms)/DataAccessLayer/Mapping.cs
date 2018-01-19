using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Mapping
    {
        public static BusinessObjects.Book ToBookBusinessEntity(DataEntity.Books item)
        {
            var result = new BusinessObjects.Book();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Author = item.Author;
            result.ISBN = item.ISBN;
            result.NumberOfPages = item.NumberOfPages;
            result.YearOfPublishing = item.YearOfPublishing;

            return result;
        }

        public static DataEntity.Books ToBooksDataEntity(BusinessObjects.Book item)
        {
            var result = new DataEntity.Books();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Author = item.Author;
            result.ISBN = item.ISBN;
            result.NumberOfPages = item.NumberOfPages;
            result.YearOfPublishing = item.YearOfPublishing;

            return result;
        }

        public static BusinessObjects.Author ToAuthorsBusinessEntity(DataEntity.Authors item)
        {
            var result = new BusinessObjects.Author();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Gender = item.Gender;
            result.YearOfBirth = item.YearOfBirth;

            return result;
        }

        public static DataEntity.Authors ToAuthorsDataEntity(BusinessObjects.Author item)
        {
            var result = new DataEntity.Authors();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Gender = item.Gender;
            result.YearOfBirth = item.YearOfBirth;

            return result;
        }

        public static BusinessObjects.Tenant ToTenantsBusinessEntity(DataEntity.Tenants item)
        {
            var result = new BusinessObjects.Tenant();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Gender = item.Gender;
            result.Email = item.Email;
            result.IDCard = item.IDCard;
            result.PhoneNumber = item.PhoneNumber;
            result.UniqueCitizenshipNumber = item.UniqueCitizenshipNumber;
            result.Address = item.Address;
            

            return result;
        }

        public static DataEntity.Tenants ToTenantsDataEntity(BusinessObjects.Tenant item)
        {
            var result = new DataEntity.Tenants();

            result.ID = item.ID;
            result.Name = item.Name;
            result.Gender = item.Gender;
            result.Email = item.Email;
            result.IDCard = item.IDCard;
            result.PhoneNumber = item.PhoneNumber;
            result.UniqueCitizenshipNumber = item.UniqueCitizenshipNumber;
            result.Address = item.Address;


            return result;
        }
    }
}
