using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Models
{
    public class Cart
    {
      
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Count { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }
        public virtual Customer Customer { get; set; }

       }
}
