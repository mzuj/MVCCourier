using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourier.Models
{
    public class PackageModel
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Adres")]
        public string Adress { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data dostarczenia")]
        public DateTime DueDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data zrealizowania")]
        public DateTime? DateDelivered { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Cena")]
        public decimal? Price { get; set; }

        [Display(Name = "Dostarczono")]
        public bool IsDelivered { get; set; }

        [Display(Name = "Kurier")]
        public string Courier { get; set; }
    }
}