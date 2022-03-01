using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class PaymentRepository
    {
        private readonly ECommerceEntity Db;

        public PaymentRepository()
        {

        }

        public PaymentRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int id)
        {
            Payment payment = Db.payments.FirstOrDefault(e => e.Id == id);
            Db.payments.Remove(payment);
            Db.SaveChanges();
        }

        public List<Payment> Getall()
        {
            List<Payment> Paymentlist = Db.payments.ToList();
            return Paymentlist;
        }

        public Payment GetById(int id)
        {
            Payment payment = Db.payments.FirstOrDefault(e => e.Id == id);
            return payment;

        }




        public void Insert(Payment payment)
        {

          
            Db.payments.Add(payment);
            Db.SaveChanges();

        }

        public void Update(int id, Payment Newpayment)
        {
            Payment payment = Db.payments.FirstOrDefault(e => e.Id == id);
            payment.PaymentDate = Newpayment.PaymentDate;
            payment.PaymentAmount = Newpayment.PaymentAmount;
            payment.CustomerId = Newpayment.CustomerId;
       
            Db.SaveChanges();

        }
    }
}
