using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem;

namespace Startup.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var data = new LibraryDbContext())
            {

                Book book = new Book { Author = "Jack", Name = "Billy", Id = 1, ISBNNumber = 10000000, NumberOfPages = 256, YearOfPublishing = 1991 };

                data.Books.Add(book);

                data.SaveChanges();
            }
        }
    }
}
            
                
