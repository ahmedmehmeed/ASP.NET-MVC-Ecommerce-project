using Ecommerce.Models;
using Ecommerce.View_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        ECommerceEntity Db;
        public ProductRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }

        public List<Product> Getall()
        {
            List<Product> productlist = Db.Products.ToList();
            return productlist;
        }

        public Product GetById(int id)
        {
            Product product = Db.Products.FirstOrDefault(e => e.Id == id);
            return product;

        }


        public List<Product> GetLastSeven()
        {
            List<Product> product = Db.Products.OrderByDescending(e => e.Date).Take(7).ToList();
            return product;

        }



        public void Insert(ProductViewModel productViewModel)
        {
            Product Product = new Product();

            Product.Name = productViewModel.Name;
            Product.Price = productViewModel.Price;
            Product.CategoryId = productViewModel.CategoryId;
            Product.Description = productViewModel.Description;
            Product.Image = productViewModel.image;
            Product.Date = DateTime.Now.ToString("dd-MM-yyyy");



            Db.Products.Add(Product);
            Db.SaveChanges();

        }

        public void Update(int id, ProductViewModel productViewModel)
        {
            Product oldproduct = Db.Products.FirstOrDefault(e => e.Id == id);
            oldproduct.Name = productViewModel.Name;
            oldproduct.Price = productViewModel.Price;
            oldproduct.CategoryId = productViewModel.CategoryId;
            oldproduct.Description = productViewModel.Description;
            oldproduct.Date = DateTime.Now.ToString("dd-MM-yyyy");
            oldproduct.Image = productViewModel.image;

            Db.SaveChanges();

        }
        public void Delete(int id)
        {
            Product product = Db.Products.FirstOrDefault(e => e.Id == id);
            Db.Products.Remove(product);
            Db.SaveChanges();
        }
    }
}
