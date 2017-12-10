using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Author
    {

        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string Gender { get; set; }

        public int YearOfBirth { get; set; }

        public Book Book { get; set; }



    }
}
