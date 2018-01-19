using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Nullable<long> ISBN { get; set; }
        public Nullable<int> NumberOfPages { get; set; }
        public Nullable<int> YearOfPublishing { get; set; }
    }
}
