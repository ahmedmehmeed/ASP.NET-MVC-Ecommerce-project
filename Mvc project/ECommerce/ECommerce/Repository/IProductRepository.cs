using ECommerce.Models;
using ECommerce.ModelViews;
using System.Collections.Generic;

namespace ECommerce.Repository
{
    public interface IProductRepository
    {
        void Delete(int id);
        List<Product> Getall();
        Product GetById(int id);
        List<Product> GetLastSeven();
        void Insert(ProductModelView productModelView);
        void Update(int id, ProductModelView productModelView);
    }
}