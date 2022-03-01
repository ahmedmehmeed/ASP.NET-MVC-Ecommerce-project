using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CustomerRepository
    {
        private readonly ECommerceEntity Db;

        public CustomerRepository()
        {

        }

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




        public void Insert(Customer customer)
        {

         
            Db.Customers.Add(customer);
            Db.SaveChanges();
        }

        public void Update(int id, Customer Newcustomer)
        {
            Customer customer = Db.Customers.FirstOrDefault(e => e.Id == id);
            customer.FName = Newcustomer.FName;
            customer.LName = Newcustomer.LName;
            customer.Email = Newcustomer.Email;
            customer.PhoneNumber = Newcustomer.PhoneNumber;
            customer.DOB = Newcustomer.DOB;

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
