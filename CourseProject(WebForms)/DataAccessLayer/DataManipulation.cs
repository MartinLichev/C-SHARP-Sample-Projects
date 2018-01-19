using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;
using BusinessObjects;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class DataManipulation
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();


        public static BusinessObjects.Book ReadFromBook(int id)
        {
            var book = new BusinessObjects.Book();

            var databaseitem = entity.Books.FirstOrDefault(a => a.ID == id);

            return Mapping.ToBookBusinessEntity(databaseitem);
        }

        public static BusinessObjects.Author ReadFromAuthor(int id)
        {
            var author = new BusinessObjects.Author();

            var databaseitem = entity.Authors.FirstOrDefault(a => a.ID == id);

            return Mapping.ToAuthorsBusinessEntity(databaseitem);
        }

        public static BusinessObjects.Tenant ReadFromTenant(int id)
        {
            var tenant = new BusinessObjects.Tenant();

            var databaseitem = entity.Tenants.FirstOrDefault(a => a.ID == id);

            return Mapping.ToTenantsBusinessEntity(databaseitem);
        }
        public static List<Books> ReadAllFromBooks()
        {
            var read = entity.Books.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Name} {element.Author} {element.ISBN} {element.NumberOfPages} {element.YearOfPublishing}");
            }

            return read;
        }

        public static List<Authors> ReadAllFromAuthors()
        {
            var read = entity.Authors.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Name} {element.Gender} {element.YearOfBirth}");
            }

            return read;
        }

        public static List<Tenants> ReadAllFromTenants()
        {
            var read = entity.Tenants.ToList();

            foreach(var element in read)
            {
                Console.WriteLine($"{element.Name} {element.Gender} {element.IDCard} {element.PhoneNumber} {element.UniqueCitizenshipNumber} {element.Email} {element.Address}");
            }

            return read;
        }

        public static void CreateBooksRecord(BusinessObjects.Book item)
        {
            var map = Mapping.ToBooksDataEntity(item);

            entity.Books.Add(map);

            entity.SaveChanges();
        }

        public static void CreateAuthorsRecord(BusinessObjects.Author item)
        {
            var map = Mapping.ToAuthorsDataEntity(item);

            entity.Authors.Add(map);

            entity.SaveChanges();
        }

        public static void CreateTenantsRecord(BusinessObjects.Tenant item)
        {
            var map = Mapping.ToTenantsDataEntity(item);

            entity.Tenants.Add(map);

            entity.SaveChanges();
        }

        public static void DeleteBooksRecord(string name)
        {
            var databaseitem = entity.Books.FirstOrDefault(a => a.Name == name);

            if(databaseitem != null)
            {
                entity.Books.Remove(databaseitem);

                entity.SaveChanges();
            }
        }

        public static void DeleteAuthorsRecord(string name)
        {
            var databaseitem = entity.Authors.FirstOrDefault(a => a.Name == name);

            if(databaseitem != null)
            {
                entity.Authors.Remove(databaseitem);

                entity.SaveChanges();
            }
        }

        public static void DeleteTenantsRecord(string name)
        {
            var databaseitem = entity.Tenants.FirstOrDefault(a => a.Name == name);

            if(databaseitem != null)
            {
                entity.Tenants.Remove(databaseitem);

                entity.SaveChanges();
            }

        }

        public static void UpdateAuthorsRecord(BusinessObjects.Author item, int id)
        {
            var map = Mapping.ToAuthorsDataEntity(item);

            var databaseitem = entity.Authors.FirstOrDefault(a => a.ID == id);

            if (databaseitem != null)
            {
                databaseitem.Name = item.Name;
                databaseitem.Gender = item.Gender;
                databaseitem.YearOfBirth = item.YearOfBirth;

                entity.SaveChanges();
                
            }
        }

        public static void UpdateBooksRecord(BusinessObjects.Book item, int id)
        {
            var map = Mapping.ToBooksDataEntity(item);

            var databaseitem = entity.Books.FirstOrDefault(a => a.ID == id);

            if(databaseitem != null)
            {
                databaseitem.Name = item.Name;
                databaseitem.Author = item.Author;
                databaseitem.ISBN = item.ISBN;
                databaseitem.NumberOfPages = item.NumberOfPages;
                databaseitem.YearOfPublishing = item.YearOfPublishing;

                entity.SaveChanges();
                
            }
        }

        public static void UpdateTenantsRecord(BusinessObjects.Tenant item, int id)
        {
            var map = Mapping.ToTenantsDataEntity(item);

            var databaseitem = entity.Tenants.FirstOrDefault(a => a.ID == id);

            if(databaseitem != null)
            {
                databaseitem.Name = item.Name;
                databaseitem.Gender = item.Gender;
                databaseitem.Email = item.Email;
                databaseitem.Address = item.Address;
                databaseitem.IDCard = item.IDCard;
                databaseitem.PhoneNumber = item.PhoneNumber;
                databaseitem.UniqueCitizenshipNumber = item.UniqueCitizenshipNumber;

                entity.SaveChanges();
            }
        }
            

        
    }
}
