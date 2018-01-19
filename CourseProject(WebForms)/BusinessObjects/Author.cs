using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> YearOfBirth { get; set; }
    }
}
