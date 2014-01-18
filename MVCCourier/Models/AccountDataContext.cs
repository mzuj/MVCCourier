using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCourier.Models
{
    public class AccountDataContext : DbContext
    {
        public DbSet<RegisterModel> Users { get; set; }

        static AccountDataContext()
        {
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MVCCourier.Models.AccountDataContext>());
        }
    }
}