using ECommerce.Models;
using ECommerce.ModelViews;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ECommEntity context;

        public CustomerRepository()
        {

        }

        public CustomerRepository(ECommEntity _context)
        {
            context = _context;
        }




        public void Delete(int id)
        {
            Customer customer = context.Customers.FirstOrDefault(e => e.Id == id);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public List<Customer> Getall()
        {
            List<Customer> customerlist = context.Customers.ToList();
            return customerlist;
        }

        public Customer GetById(int id)
        {
            Customer customer = context.Customers.FirstOrDefault(e => e.Id == id);
            return customer;

        }




        public void Insert(CustomerModelView customerModelView)
        {
            Customer customer = new Customer();

            customer.Name = customerModelView.Name;
            customer.Password = customerModelView.Password;
            customer.Email = customerModelView.Email;
            customer.PhoneNumber = customerModelView.PhoneNumber;
            customer.Gender = customerModelView.Gender;
            customer.DateOfBirth = customerModelView.DateOfBirth;


            context.Customers.Add(customer);
            context.SaveChanges();

        }

        public void Update(int id, CustomerModelView customerModelView)
        {
            Customer customer = context.Customers.FirstOrDefault(e => e.Id == id);
            customer.Name = customerModelView.Name;
            customer.Password = customerModelView.Password;
            customer.Email = customerModelView.Email;
            customer.PhoneNumber = customerModelView.PhoneNumber;
            customer.Gender = customerModelView.Gender;
            customer.DateOfBirth = customerModelView.DateOfBirth;

            context.SaveChanges();

        }





    }
}
