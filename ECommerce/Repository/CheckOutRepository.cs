using Ecommerce.Models;
using Ecommerce.View_Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class CheckOutRepository : ICheckOutRepository
    {
        private readonly ECommerceEntity Db;


        public CheckOutRepository()
        {

        }

        public CheckOutRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }



        public CheckOutViewModel GetByUserName(string user)
        {
            CheckOutViewModel checkOut = Db.checkOuts.FirstOrDefault(e => e.UserName == user);
            return checkOut;

        }




        public void Insert(CheckOutViewModel checkOut)
        {


            Db.checkOuts.Add(checkOut);
            Db.SaveChanges();

        }

    }
}
