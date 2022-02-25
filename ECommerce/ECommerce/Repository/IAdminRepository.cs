using ECommerce.Models;
using ECommerce.ModelViews;
using System.Collections.Generic;

namespace ECommerce.Repository
{
    public interface IAdminRepository
    {
        void Delete(int id);
        List<Admin> Getall();
        Admin GetById(int id);
        void Insert(AdminModelView adminModelView);
        void Update(int id, AdminModelView adminModelView);
    }
}