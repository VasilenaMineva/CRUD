using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ORM_Vasilena_11a.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext():base("ApplicationDBContext") { }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
