//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PackageModel
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string Adress { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsDelivered { get; set; }
        public string Courier { get; set; }
    }
}
