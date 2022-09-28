using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DbHelper: DbContext
    {
        public DbHelper():base("name=myDatabaseConnection")
        {
            Database.SetInitializer<DbHelper>(new CreateDatabaseIfNotExists<DbHelper>());
        }

        public DbSet<Student> Students { set; get; }
    }
}
