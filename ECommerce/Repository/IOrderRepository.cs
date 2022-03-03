using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IOrderRepository
    {
        void Delete(int id);
        List<Order> Getall();
        Order GetById(int id);
        void Insert(Order order);
        void Update(int id, Order Neworder);
    }
}