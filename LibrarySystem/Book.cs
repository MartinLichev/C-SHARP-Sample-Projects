using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public long ISBNNumber { get; set; }

        public int NumberOfPages { get; set; }

        public int YearOfPublishing { get; set; }

        public virtual ICollection<Author> Authors { get; set; }




    }
}
