
using StudentsPerfomanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace StudentsPerfomanceLogic.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "StudentsPerformanceForPAS";

        public User GetUserByLoginAndPassword(string login, string password)
        {
            User user;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@login", login);
                p.Add("@password", password);
                user = connection.Query<User>("spUsers_GetUserByLoginAndPassword",p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return user;
        }
    }
}
