using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using StudentsPerformanceLogic.DataAccess;

namespace StudentsPerformanceLogic
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static string GetConnection(string connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        }

        public static void InitializeConnection(DataType database)
        {
            if (database == DataType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }
    }
}
