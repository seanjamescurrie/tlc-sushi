using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;
using TLC.Data.Services;
using TLC.Data.Services.Interfaces;
using TLC.Blazor.Services.Interfaces;
using TLC.Blazor.Services;
using TLC.Core.Models;

namespace TLC.Blazor.Services
{
    public class UserService : IUserService
    {
        private readonly IUserServiceDb svc;

        public UserService(IUserServiceDb svc)
        {
            this.svc = svc;
        }

        public User AddUser(string name, string email, string password, Role role)
        {
            return svc.AddUser(name, email, password, role);
        }

        public User Authenticate(string email, string password)
        {
            return svc.Authenticate(email, password);
        }

        public bool DeleteUser(int id)
        {
            return svc.DeleteUser(id);
        }

        public User GetUser(int id)
        {
            return svc.GetUser(id);
        }

        public User GetUserByEmail(string email)
        {
            return svc.GetUserByEmail(email);
        }

        public IList<User> GetUsers()
        {
            return svc.GetUsers();
        }

        public bool IsEmailAvailable(string email, int userId)
        {
            return svc.IsEmailAvailable(email, userId);
        }

        public User UpdateUser(User user)
        {
            return svc.UpdateUser(user);
        }

     
    }
}