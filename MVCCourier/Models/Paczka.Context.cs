﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCourier.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PaczkaEntity : DbContext
    {
        public PaczkaEntity()
            : base("name=PaczkaEntity")
        {
        }
        
        public DbSet<PackageModel> PackageModels { get; set; }
    }
}
