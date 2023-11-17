using StudentsPerformance.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformance.Logic.DataAccess
{
    public class SqlConnector
    {
        public static UserModel GetUserLogin(RoleModel role, string login, string password)
        {
            var user = new UserModel();
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("spUsers_GetLoginAndPassword", connection);

                SqlParameter loginParam = new SqlParameter("@login", login);
                SqlParameter passwordParam = new SqlParameter("@password", password);
                command.Parameters.Add(loginParam);
                command.Parameters.Add(passwordParam);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role.Id = reader.GetInt32(3);
                        user.Id = reader.GetInt32(0);
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);                        
                    }

                    return user;
                }
            }
        }
    }
}
