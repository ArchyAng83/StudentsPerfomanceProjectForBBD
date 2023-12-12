
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

        #region SchoolClasses
        public SchoolClass CreateClass(SchoolClass schoolClass)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@name", schoolClass.Name);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);
                connection.Execute("spSchoolClasses_Insert", p, commandType: CommandType.StoredProcedure);
                schoolClass = new SchoolClass(p.Get<int>("@id"), schoolClass.Name);
            }

            return schoolClass;
        }

        public List<SchoolClass> GetAllClasses()
        {
            List<SchoolClass> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<SchoolClass>("spSchoolClasses_GatAll").ToList();

                foreach (SchoolClass schoolClass in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@classId", schoolClass.Id);
                    schoolClass.Students = connection.Query<Student>("spStudents_GetAllByClass", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach(Student student in schoolClass.Students)
                    {
                        p = new DynamicParameters();
                        p.Add("studentId", student.Id);
                        student.Guardians = connection.Query<Guardian>("spGuardians_GetAllByStudetId", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
            }

            return output;
        }
        #endregion

        #region Guardians
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
                connection.Execute("spGuardians_Delete", new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Students

        //public List<Student> GetAllStudents()
        //{
        //    List<Student> output;

        //    using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
        //    {
        //        output = connection.Query<Student>("spStudents_GetAll").ToList();
        //    }

        //    return output;
        //}

        public Student AddStudent(Student student, int classId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@lastName", student.LastName);
                p.Add("@firstName", student.FirstName);
                p.Add("@middleName", student.MiddleName);
                p.Add("@address", student.Address);
                p.Add("@birthDate", student.BirthDate);
                p.Add("@cellPhone", student.CellPhone);
                p.Add("@classId", classId);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);
                connection.Execute("spStudents_Insert", p, commandType: CommandType.StoredProcedure);

                Student newStudent = new Student(p.Get<int>("@id"), student.LastName, student.FirstName, student.MiddleName, student.Address, student.BirthDate, student.CellPhone);
                newStudent.Guardians = student.Guardians;

                foreach (Guardian guardian in newStudent.Guardians)
                {
                    p = new DynamicParameters();
                    p.Add("@studentId", newStudent.Id);
                    p.Add("@guardianId", guardian.Id);
                    connection.Execute("spStudentsGuardians_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return newStudent;
            }
        }

        public void UpdateStudent(Student student, int classId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", student.Id);
                p.Add("@lastName", student.LastName);
                p.Add("@firstName", student.FirstName);
                p.Add("@middleName", student.MiddleName);
                p.Add("@address", student.Address);
                p.Add("@birhDate", student.BirthDate);
                p.Add("@cellPhone", student.CellPhone);
                p.Add("@classId", classId);

                connection.Execute("spStudents_Update", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@studentId", student.Id);
                connection.Execute("spStudentsGuardians_Delete", p, commandType: CommandType.StoredProcedure);

                foreach (Guardian guardian in student.Guardians)
                {
                    p = new DynamicParameters();
                    p.Add("@studentId", student.Id);
                    p.Add("@guardianId", guardian.Id);
                    connection.Execute("spStudentsGuardians_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void DeleteStudent(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                connection.Execute("spStudents_Delete", new { id }, commandType: CommandType.StoredProcedure);
            }
        }


        #endregion
    }
}
