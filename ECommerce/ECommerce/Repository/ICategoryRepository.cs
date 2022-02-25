using ECommerce.Models;
using System.Collections.Generic;

namespace ECommerce.Repository
{
    public interface ICategoryRepository
    {
        void Delete(int id);
        List<Category> Getall();
        Category GetById(int id);
        void Insert(Category category);
        void Update(int id, Category newcategory);
    }
}