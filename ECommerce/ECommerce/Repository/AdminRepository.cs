using ECommerce.Models;
using ECommerce.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ECommEntity context;
        public AdminRepository()
        {

        }
        public AdminRepository(ECommEntity _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            Admin admin = context.Admins.FirstOrDefault(e => e.Id == id);
            context.Admins.Remove(admin);
            context.SaveChanges();
        }
        public List<Admin> Getall()
        {
            List<Admin> Adminlist = context.Admins.ToList();
            return Adminlist;
        }
        public Admin GetById(int id)
        {
            Admin admin = context.Admins.FirstOrDefault(e => e.Id == id);
            return admin;

        }
        public void Insert(AdminModelView adminModelView)
        {
            Admin admin = new Admin();

            admin.FName = adminModelView.FName;
            admin.Password = adminModelView.Password;
            admin.Email = adminModelView.Email;
            admin.PhoneNumber = adminModelView.PhoneNumber;
            admin.Gender = adminModelView.Gender;
            admin.DateOfBirth = adminModelView.DateOfBirth;


            context.Admins.Add(admin);
            context.SaveChanges();

        }

        public void Update(int id, AdminModelView adminModelView)
        {
            Admin oldAdmin = context.Admins.FirstOrDefault(e => e.Id == id);
            oldAdmin.FName = adminModelView.FName;
            oldAdmin.Password = adminModelView.Password;
            oldAdmin.Email = adminModelView.Email;
            oldAdmin.PhoneNumber = adminModelView.PhoneNumber;
            oldAdmin.Gender = adminModelView.Gender;
            oldAdmin.DateOfBirth = adminModelView.DateOfBirth;

            context.SaveChanges();
        }
    }
}

