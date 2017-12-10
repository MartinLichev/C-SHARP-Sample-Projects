using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LibrarySystem
{
    public class LibraryDbContext :DbContext
    {
		public LibraryDbContext(): base("LibrarySystem")
        {

        }
		public IDbSet<Author> Authors { get; set; }

		public IDbSet<Book> Books { get; set; }

		public IDbSet<Tenant> Tenants { get; set; }


    }
}
