using Ecommerce.View_Models;

namespace Ecommerce.Repository
{
    public interface ICheckOutRepository
    {
        CheckOutViewModel GetByUserName(string user);
        void Insert(CheckOutViewModel checkOut);
    }
}