using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Tenant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long IDCardNumbers { get; set; }

        public int UniqueCitizenshipNumber { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
