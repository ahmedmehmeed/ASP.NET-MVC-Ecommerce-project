using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ECommerce.ModelViews;
using System;

namespace ECommerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommEntity context;

        public ProductRepository()
        {

        }

        public ProductRepository(ECommEntity _context)
        {
            context = _context;
        }




        public void Delete(int id)
        {
            Product product = context.Products.FirstOrDefault(e => e.Id == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public List<Product> Getall()
        {
            List<Product> productlist = context.Products.ToList();
            return productlist;
        }

        public Product GetById(int id)
        {
            Product product = context.Products.FirstOrDefault(e => e.Id == id);
            return product;

        }


        public List<Product> GetLastSeven()
        {
            List<Product> product = context.Products.Include(e => e.ProductInfo).OrderByDescending(e => e.Date).Take(7).ToList();
            return product;

        }



        public void Insert(ProductModelView productModelView)
        {
            Product Product = new Product();

            Product.Name = productModelView.Name;
            Product.Price = productModelView.Price;
            Product.CategoryId = productModelView.CategoryId;
            Product.Description = productModelView.Description;
            Product.Description = productModelView.Description;
            Product.Image = productModelView.Image;


            context.Products.Add(Product);
            context.SaveChanges();

        }

        public void Update(int id, ProductModelView productModelView)
        {
            Product oldproduct = context.Products.FirstOrDefault(e => e.Id == id);
            oldproduct.Name = productModelView.Name;
            oldproduct.Price = productModelView.Price;     
            oldproduct.CategoryId = productModelView.CategoryId;
            oldproduct.Description = productModelView.Description;
            oldproduct.Date = DateTime.Now.ToString("dd-MM-yyyy");
            oldproduct.Description = productModelView.Description;
            oldproduct.Image = productModelView.Image;

            context.SaveChanges();

        }









    }
}
