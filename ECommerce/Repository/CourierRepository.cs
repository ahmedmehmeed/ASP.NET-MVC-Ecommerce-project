using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CourierRepository : ICourierRepository
    {
        ECommerceEntity Db;

        public CourierRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }




        public void Delete(int id)
        {
            Courier courier = Db.couriers.FirstOrDefault(e => e.Id == id);
            Db.couriers.Remove(courier);
            Db.SaveChanges();
        }

        public List<Courier> Getall()
        {
            List<Courier> courierlist = Db.couriers.ToList();
            return courierlist;
        }

        public Courier GetById(int id)
        {
            Courier courier = Db.couriers.FirstOrDefault(e => e.Id == id);
            return courier;

        }




        public void Insert(Courier courier)
        {


            Db.couriers.Add(courier);
            Db.SaveChanges();

        }

        public void Update(int id, Courier Newcourier)
        {
            Courier courier = Db.couriers.FirstOrDefault(e => e.Id == id);
            courier.FName = Newcourier.FName;
            courier.LName = Newcourier.LName;

            courier.PhoneNumber = Newcourier.PhoneNumber;

            Db.SaveChanges();

        }
    }
}
