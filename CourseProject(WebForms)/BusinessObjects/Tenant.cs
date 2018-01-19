using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Tenant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> IDCard { get; set; }
        public Nullable<long> UniqueCitizenshipNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public Nullable<long> PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
