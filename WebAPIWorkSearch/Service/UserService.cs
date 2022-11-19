using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIWorkSearch.Modal;
using WebAPIWorkSearch.Repositories;
using WebAPIWorkSearch.View;

namespace WebAPIWorkSearch.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;            
        }

        public void InsertUser(UserView userView)
        {
            User user = new();
            user.Name = userView.Name;
            user.Email = userView.Email;
            user.Password = userView.Password;
            _userRepository.InsertUser(user);
        }

        public void UpdateUser(int id, UserView userView)
        {
            var user = _userRepository.GetUserById(id);
            user.Name = userView.Name;
            user.Email = userView.Email;
            user.Password = userView.Password;
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            _userRepository.DeleteUser(user);
        }

        public UserView GetUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            UserView userView = new UserView();
            userView.Name = user.Name;
            userView.Email = user.Email;
            userView.Password = user.Password;
            return userView;
        }

        public List<UserView> GetAll()
        {
            var users = _userRepository.GetAll().Select(user => new UserView()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            }).ToList();

            return users;
        }
    }
}
