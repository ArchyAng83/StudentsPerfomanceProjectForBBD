// Ignore Spelling: Perfomance

using StudentsPerfomanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public User GetUserByLoginAndPassword(string login, string password)
        {
            User user = new User();

            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformanceForPAS")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("spUsers_GetUserByLoginAndPassword", connection);

                SqlParameter loginParam = new SqlParameter("@login", login);
                SqlParameter passwordParam = new SqlParameter("@password", password);
                command.Parameters.Add(loginParam);
                command.Parameters.Add(passwordParam);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.UserId = reader.GetInt32(2);
                        user.RoleId = reader.GetInt32(3);
                    }
                }

                return user;
            }
        }
    }
}
