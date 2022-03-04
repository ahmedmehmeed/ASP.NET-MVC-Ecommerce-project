using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class OrderedProductRepository
    {
        ECommerceEntity Db;

      
        public OrderedProductRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int orderid, int productid)
        {
            OrderedProduct orderedProduct = Db.OrderedProducts.FirstOrDefault(e => e.OrderId == orderid&&e.ProductId==productid);
            Db.OrderedProducts.Remove(orderedProduct);
            Db.SaveChanges();
        }

        public List<OrderedProduct> Getall()
        {
            List<OrderedProduct> orderedProducts = Db.OrderedProducts.ToList();
            return orderedProducts;
        }

        public OrderedProduct GetById(int orderid, int productid)
        {
            OrderedProduct orderedProduct = Db.OrderedProducts.FirstOrDefault(e => e.OrderId == orderid && e.ProductId == productid);
            return orderedProduct;

        }




        public void Insert(OrderedProduct orderedProduct)
        {


            Db.OrderedProducts.Add(orderedProduct);
            Db.SaveChanges();

        }

        public void Update(int orderid, int productid, OrderedProduct NeworderedProduct)
        {
            OrderedProduct orderedProduct = Db.OrderedProducts.FirstOrDefault(e => e.OrderId == orderid && e.ProductId == productid);
            orderedProduct.Quantity = NeworderedProduct.Quantity;

            Db.SaveChanges();

        }


    }
}
