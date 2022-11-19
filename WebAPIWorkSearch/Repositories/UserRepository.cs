using System.Collections.Generic;
using WebAPIWorkSearch.Modal;
using WebAPIWorkSearch.Data;
using System.Linq;

namespace WebAPIWorkSearch.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WorkSearchContext _dbContext;

        public UserRepository(WorkSearchContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void InsertUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Set<User>().Update(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _dbContext.Set<User>().Remove(user);
            _dbContext.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }


        
    }
}
