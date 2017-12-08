using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolsSystem.Model;

namespace SchoolsSystem.Data
{
    public class SchoolsDbContext: DbContext
    {

		public SchoolsDbContext():base("SchoolsDataBase")
        {

        }
		public DbSet<School> Schools { get; set; } 

		public DbSet<Student> Students { get; set; }
    }
}
