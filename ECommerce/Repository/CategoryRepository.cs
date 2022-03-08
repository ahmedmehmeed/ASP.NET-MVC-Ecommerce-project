using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        ECommerceEntity Db;

        public CategoryRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }

        public List<Category> Getall()
        {
            List<Category> categorylist = Db.Categories.ToList();
            return categorylist;
        }

        public Category GetById(int id)
        {
            Category category = Db.Categories.FirstOrDefault(e => e.Id == id);
            return category;

        }
        public List<Product> Getallproductsbycatid(int catid)
        {
            List<Product> productlist = Db.Products.Where(e=>e.CategoryId==catid).ToList();
            return productlist;
        }
        public void Insert(Category category)
        {

            Db.Categories.Add(category);
            Db.SaveChanges();
        }

        public void Update(int id, Category newcategory)
        {
            Category oldcategory = Db.Categories.FirstOrDefault(e => e.Id == id);
            oldcategory.Name = newcategory.Name;


            Db.SaveChanges();

        }

        public void Delete(int id)
        {
            Category category = Db.Categories.FirstOrDefault(e => e.Id == id);
            Db.Categories.Remove(category);
            Db.SaveChanges();
        }

    }
}
