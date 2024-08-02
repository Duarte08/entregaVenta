using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ventasControl.Models
{
    public class SalesProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SalesId { get; set; }
        public Sale Sale { get; set; }

        [Required]
        public int ProductsId { get; set; }
        public Product Product { get; set; }
    }
}