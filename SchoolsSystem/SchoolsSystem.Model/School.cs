using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsSystem.Model
{
    public class School
    {
        public int SchoolId { get; set; }

        public string Name { get; set; }

        public string DistrictLocation { get; set; }

        public int YearOfOpening { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}
