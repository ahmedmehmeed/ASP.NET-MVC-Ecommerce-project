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

        [Required(ErrorMessage = "You must Enter A Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter A Discription")]

        public string Description { get; set; }
        [Required(ErrorMessage = "You must Enter A Price")]

        public int Price { get; set; }
        [Required(ErrorMessage = "You must Enter An Old Price")]

        public int OldPrice { get; set; }

        public string Date { get; set; }
        [Required(ErrorMessage = "You must Enter An Image")]

        public string Image { get; set; }
        [Required(ErrorMessage = "You must Enter ")]

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual List<ProductInfo> ProductInfo { get; set; }
        

    }
}
