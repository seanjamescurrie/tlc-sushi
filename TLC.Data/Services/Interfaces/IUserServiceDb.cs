using System;
using System.Collections.Generic;

using TLC.Core.Models;

namespace TLC.Data.Services.Interfaces
{
    // This interface describes the operations that a UserService class should implement
    public interface IUserServiceDb
    {
        // Initialise the repository - only to be used during development 
        void Initialise();

        // ---------------- User Management --------------
        IList<User> GetUsers();
        User GetUser(int id);
        User GetUserByEmail(string email);
        bool IsEmailAvailable(string email, int userId);
        User AddUser(string name, string email, string password, Role role);
        User UpdateUser(User user);
        bool DeleteUser(int id);
        User Authenticate(string email, string password);
       
    }
    
}
