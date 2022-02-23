using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.MetaData;

namespace ECommerce.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual List<ProductInfo> ProductInfo { get; set; }
        

    }
}
