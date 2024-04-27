//IUserService
using Domain;

namespace Service
{
    public interface IUserService
    {
        User Create(User user);
        User GetById(int id);
        User GetByUsername(string username);
        IEnumerable<User> GetAll();
    }
}