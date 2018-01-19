using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataEntity;
using System.Data.Entity;
using DataAccessLayer;

namespace DataBaseTest
{
    public class Program
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        public static void Main(string[] args)
        {
            BusinessObjects.Author a1 = new BusinessObjects.Author()
            {
                Name ="Stephen King",
                Gender = "male",
                YearOfBirth = 1950,
            };

            BusinessObjects.Book b1 = new BusinessObjects.Book()
            {
                Name = "The Dark Tower",
                Author = "Stephen King",
                ISBN = 10002344545,
                NumberOfPages = 500,
                YearOfPublishing = 1995,
                
            };

            BusinessObjects.Tenant t1 = new BusinessObjects.Tenant()
            {
                Name = "Martin Lichev",
                Address = "Bul.Tsarigradsko shose 81",
                Email = "Martin.Lichev1@gmail.com",
                PhoneNumber = 0898797829,
                Gender = "male",
                IDCard = 121334235198,
                UniqueCitizenshipNumber = 9101177109,

            };

            BusinessObjects.Tenant t2 = new BusinessObjects.Tenant()
            {
                Name = "Elena Licheva",
                Address = "Mladost 3, blok 327, vh.A",
                Email = "elicheva1968@gmail.com",
                PhoneNumber = 0895551230,
                Gender = "female",
                IDCard = 123456789015,
                UniqueCitizenshipNumber = 6805108701,
            };

            BusinessObjects.Book b2 = new BusinessObjects.Book()
            {
                Name = "Winnie The Pooh",
                Author = "Allen Milan",
                ISBN = 11122277781,
                NumberOfPages = 210,
                YearOfPublishing = 1980,
            };
            

        }
    }
}
