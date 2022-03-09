using Ecommerce.View_Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ecommerce.Models
{
    public class ECommerceEntity:IdentityDbContext
    {
        public ECommerceEntity()
        {
                
        }
        public ECommerceEntity(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
       
        public DbSet<Cart> Carts { get; set; }
        
        public DbSet<OrderedProduct> OrderedProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {optionsBuilder.UseLazyLoadingProxies();
            //don't forget to change!!
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2S4PV11\\SQLEXPRESS;Initial Catalog=ECommerceDB;Integrated Security=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // add restrict on delete 

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }




            base.OnModelCreating(modelBuilder);
            // make three prop as primary key


            modelBuilder.Entity<OrderedProduct>().HasKey(table => new {
                table.OrderId,
                table.ProductId,
                

                });


            modelBuilder.Entity<LoginViewModel>().HasKey(table => new {
                table.username,
                
            });

            modelBuilder.Entity<RoleViewModel>().HasKey(table => new {
                table.Role,

            });

        }

        public DbSet<Ecommerce.View_Models.LoginViewModel> LoginViewModel { get; set; }

        public DbSet<Ecommerce.View_Models.RoleViewModel> RoleViewModel { get; set; }

    }
}
