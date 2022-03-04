using Ecommerce.Models;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CustomerRepository
    {
         ECommerceEntity Db;


        public CustomerRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }

        public List<Customer> Getall()
        {
            List<Customer> customerlist = Db.Customers.ToList();
            return customerlist;
        }

        public Customer GetById(int id)
        {
            Customer customer = Db.Customers.FirstOrDefault(e => e.Id == id);
            return customer;

        }




        public void Insert(RegisterViewModel customerViewModel)
        { 
            
        }

        public void Update(int id, Customer Newcustomer)
        {
            Customer customer = Db.Customers.FirstOrDefault(e => e.Id == id);
            customer.FName = Newcustomer.FName;
            customer.LName = Newcustomer.LName;
  
                      Db.SaveChanges();

        }
        public void Delete(int id)
        {
            Customer customer = Db.Customers.FirstOrDefault(e => e.Id == id);
            Db.Customers.Remove(customer);
            Db.SaveChanges();
        }
 

    }
}
