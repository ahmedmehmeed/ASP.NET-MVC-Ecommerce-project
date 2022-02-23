using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.Models;

namespace ECommerce.MetaData
{
    public class ProductMetaData
    { 
        public int Id { get; set; }


        [Required(ErrorMessage = "You must Enter A Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "You must Enter Price")]

        public int Price { get; set; }
        [Required(ErrorMessage = "You must Enter Price")]
        public int OldPrice { get; set; }
        [Required(ErrorMessage = "You must Upload Image Og The Product")]
        [DataType(DataType.DateTime)]
        public string Date { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "You must Enter Category Id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }


    }
}
