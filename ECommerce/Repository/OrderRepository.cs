using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class OrderRepository : IOrderRepository
    {
        ECommerceEntity Db;


        public OrderRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int id)
        {
            Order order = Db.Orders.FirstOrDefault(e => e.Id == id);
            Db.Orders.Remove(order);
            Db.SaveChanges();
        }

        public List<Order> Getall()
        {
            List<Order> orderlist = Db.Orders.ToList();
            return orderlist;
        }

        public Order GetById(int id)
        {
            Order order = Db.Orders.FirstOrDefault(e => e.Id == id);
            return order;

        }




        public void Insert(Order order)
        {


            Db.Orders.Add(order);
            Db.SaveChanges();

        }

        public void Update(int id, Order Neworder)
        {
            Order order = Db.Orders.FirstOrDefault(e => e.Id == id);
            order.Date = Neworder.Date;
           
            order.CustomerId = Neworder.CustomerId;

            Db.SaveChanges();

        }





    }
}

