using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface ICourierRepository
    {
        void Delete(int id);
        List<Courier> Getall();
        Courier GetById(int id);
        void Insert(Courier courier);
        void Update(int id, Courier Newcourier);
    }
}