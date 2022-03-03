using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class ProductInfoRepository : IProductInfoRepository
    {
        private readonly ECommerceEntity Db;

        public ProductInfoRepository()
        {

        }

        public ProductInfoRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int id)
        {
            ProductInfo productInfo = Db.ProductInfos.FirstOrDefault(e => e.Prod_ID == id);
            Db.ProductInfos.Remove(productInfo);
            Db.SaveChanges();
        }

        public List<ProductInfo> Getall()
        {
            List<ProductInfo> ProductInfolist = Db.ProductInfos.ToList();
            return ProductInfolist;
        }

        public ProductInfo GetById(int id)
        {
            ProductInfo productInfo = Db.ProductInfos.FirstOrDefault(e => e.Prod_ID == id);
            return productInfo;

        }




        public void Insert(ProductInfo productInfo)
        {

            Db.ProductInfos.Add(productInfo);
            Db.SaveChanges();

        }

        public void Update(int id, ProductInfo NewproductInfo)
        {
            ProductInfo productInfo = Db.ProductInfos.FirstOrDefault(e => e.Prod_ID == id);
            productInfo.Image = NewproductInfo.Image;
            productInfo.Color = NewproductInfo.Color;
            productInfo.Size = NewproductInfo.Size;

            Db.SaveChanges();

        }
    }
}
