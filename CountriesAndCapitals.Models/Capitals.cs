using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAndCapitals.Models
{
    public class Capitals
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryName { get; set; }

        public long Size { get; set; }

        public long Population { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
