using ECommerce.Models;
using ECommerce.ModelViews;
using System.Collections.Generic;

namespace ECommerce.Repository
{
    public interface ICustomerRepository
    {
        void Delete(int id);
        List<Customer> Getall();
        Customer GetById(int id);
        void Insert(CustomerModelView customerModelView);
        void Update(int id, CustomerModelView customerModelView);
    }
}