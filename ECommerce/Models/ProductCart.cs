﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ProductCart
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Cart Cart { get; set; }

    }
}
