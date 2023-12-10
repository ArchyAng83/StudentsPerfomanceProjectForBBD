
using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace StudentsPerformanceLogic.DataAccess
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
                user = connection.QueryFirstOrDefault<User>("spUsers_GetUserByLoginAndPassword",p, commandType: CommandType.StoredProcedure);
            }

            return user;
        }

        #region SchoolClass
        public void CreateClass(SchoolClass schoolClass)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@name", schoolClass.Name);
                schoolClass = connection.QueryFirstOrDefault<SchoolClass>("spSchoolClasses_Insert", new { schoolClass.Id, schoolClass.Name });//Todo: change?
            }
        }

        public List<SchoolClass> GetAllClasses()
        {
            List<SchoolClass> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<SchoolClass>("spSchoolClasses_GatAll").ToList();
            }

            return output;
        }
        #endregion

        public List<Guardian> GetAllGuardians()
        {
            List<Guardian> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection (db)))
            {
                output = connection.Query<Guardian>("spGuardians_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public Guardian AddGuardian(Guardian guardian)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@lastName", guardian.LastName);
                p.Add("@firstName", guardian.FirstName);
                p.Add("@middleName", guardian.MiddleName);
                p.Add("@address", guardian.Address);
                p.Add("@birthDate", guardian.BirthDate);
                p.Add("@cellPhone", guardian.CellPhone);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spGuardians_Insert", p, commandType: CommandType.StoredProcedure);
                guardian = new Guardian(p.Get<int>("@id"), guardian.LastName, guardian.FirstName, guardian.MiddleName, guardian.Address, guardian.BirthDate, guardian.CellPhone);
            }

            return guardian;
        }

        public void UpdateGuardian(Guardian guardian)
        {

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@id", guardian.Id);
                p.Add("@lastName", guardian.LastName);
                p.Add("@firstName", guardian.FirstName);
                p.Add("@middleName", guardian.MiddleName);
                p.Add("@address", guardian.Address);
                p.Add("@birthDate", guardian.BirthDate);
                p.Add("@cellPhone", guardian.CellPhone);

                connection.Execute("spGuardians_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteGuardian(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                connection.Execute("spGuardians_Delete", new { id });
            }
        } 
    }
}
