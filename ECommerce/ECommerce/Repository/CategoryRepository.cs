using ECommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ECommEntity context;

        public CategoryRepository()
        {

        }

        public CategoryRepository(ECommEntity _context)
        {
            context = _context;
        }




        public void Delete(int id)
        {
            Category category = context.Categories.FirstOrDefault(e => e.Id == id);
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<Category> Getall()
        {
            List<Category> categorylist = context.Categories.ToList();
            return categorylist;
        }

        public Category GetById(int id)
        {
            Category category = context.Categories.FirstOrDefault(e => e.Id == id);
            return category;

        }




        public void Insert(Category category)
        {


            context.Categories.Add(category);
            context.SaveChanges();

        }

        public void Update(int id, Category newcategory)
        {
            Category oldcategory = context.Categories.FirstOrDefault(e => e.Id == id);
            oldcategory.Name = newcategory.Name;


            context.SaveChanges();

        }





    }
}
