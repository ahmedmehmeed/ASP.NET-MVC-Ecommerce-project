using Ecommerce.Models;
using Ecommerce.View_Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class AdminRepository
    {
        ECommerceEntity Db;
       
        public AdminRepository(ECommerceEntity _Db)
        {
            Db = _Db;
        }
        public void Delete(int id)
        {
            Admin admin=Db.Admins.FirstOrDefault(e=>e.Id==id);
            Db.Admins.Remove(admin);
            Db.SaveChanges();
        }
        public List<Admin> Getall()
        {
            List<Admin> Adminlist = Db.Admins.ToList();
            return Adminlist;
        }
        public Admin GetById(int id)
        {
            Admin admin = Db.Admins.FirstOrDefault(e => e.Id == id);
            return admin;

        }
        public void Insert(Admin admin)
        {

            Db.Admins.Add(admin);

            Db.SaveChanges();

        }

        public void Update(int id,Admin admin)
        {
            Admin oldAdmin = Db.Admins.FirstOrDefault(e => e.Id == id);
            oldAdmin.Image = admin.Image;
            Db.SaveChanges();
   
        }
    }

}
    

