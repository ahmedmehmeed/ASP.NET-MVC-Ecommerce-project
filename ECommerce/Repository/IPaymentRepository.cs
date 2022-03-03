using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IPaymentRepository
    {
        void Delete(int id);
        List<Payment> Getall();
        Payment GetById(int id);
        void Insert(Payment payment);
        void Update(int id, Payment Newpayment);
    }
}