﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ECommerce.Models
{
    public class ECommEntity:DbContext
    {
        public ECommEntity()
        {

        }
        public ECommEntity(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Courier> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JKQGKJ0\SQLEXPRESS;Initial Catalog=ECommerceDB;Integrated Security=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add restrict on delete 
          


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }




            base.OnModelCreating(modelBuilder);



            // make three prop as primary key
            modelBuilder.Entity<ProductInfo>().HasKey(table => new {
                table.Prod_ID,
                table.Color,
                table.Image,
                table.Size

            });
        }

    }
}
 