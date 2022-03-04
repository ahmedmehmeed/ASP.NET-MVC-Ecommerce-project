using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IProductInfoRepository
    {
        void Delete(int id);
        List<ProductInfo> Getall();
        ProductInfo GetById(int id);
        void Insert(ProductInfo productInfo);
        void Update(int id, ProductInfo NewproductInfo);
    }
}