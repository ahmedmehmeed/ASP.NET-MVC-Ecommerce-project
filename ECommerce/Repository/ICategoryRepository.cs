using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface ICategoryRepository
    {
        void Delete(int id);
        List<Category> Getall();
        Category GetById(int id);
        List<Product> Getallproductsbycatid(int catid);
        void Insert(Category category);
        void Update(int id, Category newcategory);
    }
}