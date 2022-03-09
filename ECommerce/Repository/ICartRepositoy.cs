using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface ICartRepositoy
    {
        void Delete(int id);
        List<Cart> Getall();
        Cart GetById(int id);
        void Insert(Cart cart);

    }
}