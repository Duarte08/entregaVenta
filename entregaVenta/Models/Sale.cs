using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ventasControl.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Client { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? PaidDate { get; set; }

        public bool IsPaid { get; set; }

        public ICollection<SalesProduct> SalesProducts { get; set; }
    }
}
