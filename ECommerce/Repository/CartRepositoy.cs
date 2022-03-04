using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CartRepositoy : ICartRepositoy
    {

        ECommerceEntity Db;

        public CartRepositoy(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int id)
        {
            Cart cart = Db.Carts.FirstOrDefault(e => e.Id == id);
            Db.Carts.Remove(cart);
            Db.SaveChanges();
        }

        public List<Cart> Getall()
        {
            List<Cart> carts = Db.Carts.ToList();
            return carts;
        }

        public Cart GetById(int id)
        {
            Cart cart = Db.Carts.FirstOrDefault(e => e.Id == id);
            return cart;

        }

        public void Insert(Cart cart)
        {


            Db.Carts.Add(cart);
            Db.SaveChanges();

        }


    }
}
