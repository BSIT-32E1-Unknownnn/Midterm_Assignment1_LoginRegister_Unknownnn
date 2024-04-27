//Repository
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class repositories : IUserRepository
    {
        private readonly List<Domain.User> _users = new List<Domain.User>();
        private int _nextId = 1;

        public Domain.User Create(Domain.User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            return user;
        }

        public Domain.User GetById(int id)
        {
            return _users.FirstOrDefault(t => t.Id == id);
        }

        public Domain.User GetByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public IEnumerable<Domain.User> GetAll()
        {
            return _users.ToList();
        }
    }
}
