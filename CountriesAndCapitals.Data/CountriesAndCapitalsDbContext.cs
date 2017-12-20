using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CountriesAndCapitals.Models;

namespace CountriesAndCapitals.Data
{
    public class CountriesAndCapitalsDbContext:DbContext
    {
        public CountriesAndCapitalsDbContext(): base("CapitalsAndCountriesDataBase")
        {

        }
        public virtual IDbSet<Capitals> Capitals { get; set; }

        public virtual IDbSet<Countries> Countries { get; set; }


    }
}
