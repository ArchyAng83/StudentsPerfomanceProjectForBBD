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
        private readonly User user;

        public User GetUserByLoginAndPassword(string login, string password)
        {
            string sqlExpresion = "spUsers_GetLoginAndPassword";
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpresion, connection);

                SqlParameter loginParam = new SqlParameter("@login", login);
                SqlParameter passwordParam = new SqlParameter("@password", password);
                command.Parameters.Add(loginParam);
                command.Parameters.Add(passwordParam);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.RoleId = reader.GetInt32(3);
                    }
                }

                return user;
            }
        }
    }
}
