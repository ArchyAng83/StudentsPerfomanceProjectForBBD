using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }        
        public int UserId { get; }
        public int RoleId { get; }

        public User(string login, string password, int userId, int roleId)
        {
            Login = login;
            Password = password;
            UserId = userId;
            RoleId = roleId;
        }
    }
}
