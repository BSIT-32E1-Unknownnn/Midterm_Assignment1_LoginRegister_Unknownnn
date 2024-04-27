//IUserRepository
using Domain; // Assuming the User class is defined in the Domain namespace

namespace Repository
{
    public interface IUserRepository
    {
        User Create(User user);

        User GetById(int id);

        User GetByUsername(string username);

        IEnumerable<User> GetAll();
    }
}
