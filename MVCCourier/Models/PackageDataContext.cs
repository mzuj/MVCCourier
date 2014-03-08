using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCourier.Models
{
    public class PackageDataContext : DbContext
    {
        public DbSet<PackageModel> Packages { get; set; }

        static PackageDataContext()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PackageDataContext>());
        }
    }
}