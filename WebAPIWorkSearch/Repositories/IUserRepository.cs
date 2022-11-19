using System.Collections.Generic;
using WebAPIWorkSearch.Modal;

namespace WebAPIWorkSearch.Repositories
{
    public interface IUserRepository
    {
        public void InsertUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUserById(int id);

        public List<User> GetAll();
    }
}
