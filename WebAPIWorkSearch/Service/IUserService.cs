using System.Collections.Generic;
using WebAPIWorkSearch.View;

namespace WebAPIWorkSearch.Service
{
    public interface IUserService
    {
        public void InsertUser(UserView userView);
        public void UpdateUser(int id, UserView userView);
        public void DeleteUser(int id);
        public UserView GetUser(int id);
        public List<UserView> GetAll();
    }
}
