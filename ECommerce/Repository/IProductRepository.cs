using Ecommerce.Models;
using Ecommerce.View_Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IProductRepository
    {
        void Delete(int id);
        List<Product> Getall();
        Product GetById(int id);
        List<Product> GetLastSeven();
        void Insert(ProductViewModel productViewModel);
        void Update(int id, ProductViewModel productViewModel);
    }
}