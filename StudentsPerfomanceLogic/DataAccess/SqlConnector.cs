
using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using StudentsPerformanceLogic.Helpers;

namespace StudentsPerformanceLogic.DataAccess
{
    //Todo: Add to User Table ?
    public class SqlConnector : IDataConnection
    {       

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
                    AddGuardiansAndMarkToStudents(connection, schoolClass.Students);
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

        public List<Student> GetAllStudents()
        {
            List<Student> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<Student>("spStudents_GetAll").ToList();

                AddGuardiansAndMarkToStudents(connection, output);
            }

            return output;
        }

        private static void AddGuardiansAndMarkToStudents(IDbConnection connection, List<Student> students)
        {
            foreach (Student student in students)
            {
                var p = new DynamicParameters();
                p.Add("studentId", student.Id);
                student.Guardians = connection.Query<Guardian>("spGuardians_GetAllByStudetId", p, commandType: CommandType.StoredProcedure).ToList();

                p = new DynamicParameters();
                p.Add("studentId", student.Id);
                student.Marks = connection.Query<Mark, Subject, Mark>("spMarks_GetAllByStudentId",
                    (mark, subject) => { return new Mark(mark.DateOfIssue, subject, mark.ValueMark); }, p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

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

                AddGuardiansToStudent(connection, newStudent);

                return newStudent;
            }
        }

        private static void AddGuardiansToStudent(IDbConnection connection, Student newStudent)
        {
            try
            {
                foreach (Guardian guardian in newStudent.Guardians)
                {
                    var p = new DynamicParameters();
                    p.Add("@studentId", newStudent.Id);
                    p.Add("@guardianId", guardian.Id);
                    connection.Execute("spStudentsGuardians_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw new ArgumentException("Ошибка добавления");
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

                AddGuardiansToStudent(connection, student);
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

        #region Subjects
        public List<Subject> GetAllSubjects()
        {
            List<Subject> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<Subject>("spSubjects_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public Subject CreateSubject(Subject subject)
        {
            using (IDbConnection connection = new SqlConnection (GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@name", subject.Name);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spSubjects_Insert", p, commandType: CommandType.StoredProcedure);
                subject = new Subject(p.Get<int>("@id"), subject.Name);
            }

            return subject;
        }

        #endregion

        #region Teachers

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> output;

            Teacher map(Teacher teacher, Subject subject, SchoolClass schoolClass)
            {
                return new Teacher(teacher.Id, teacher.LastName, teacher.FirstName, teacher.MiddleName, teacher.Address, teacher.BirthDate, teacher.CellPhone, subject, schoolClass);
            }

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query("spTeachers_GetAll", (Func<Teacher, Subject, SchoolClass, Teacher>)map, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher currentTeacher;

            Teacher map(Teacher teacher, Subject subject, SchoolClass schoolClass)
            {
                return new Teacher(id, teacher.LastName, teacher.FirstName, teacher.MiddleName, teacher.Address, teacher.BirthDate, teacher.CellPhone, subject, schoolClass);
            }

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                currentTeacher = connection.Query("spTeachers_GetById", (Func<Teacher, Subject, SchoolClass, Teacher>)map, new { Id = id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return currentTeacher;
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@lastName", teacher.LastName);
                p.Add("@firstName", teacher.FirstName);
                p.Add("@middleName", teacher.MiddleName);
                p.Add("@address", teacher.Address);
                p.Add("@birthDate", teacher.BirthDate);
                p.Add("@cellPhone", teacher.CellPhone);
                p.Add("@subjectId", teacher.Subject.Id);
                p.Add("@classId", teacher.SchoolClass?.Id);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spTeachers_Insert", p, commandType: CommandType.StoredProcedure);

                teacher = new Teacher(p.Get<int>("@id"), teacher.LastName, teacher.FirstName, teacher.MiddleName, teacher.Address, teacher.BirthDate, teacher.CellPhone, teacher.Subject, teacher.SchoolClass);
            }

            return teacher;
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", teacher.Id);
                p.Add("@lastName", teacher.LastName);
                p.Add("@firstName", teacher.FirstName);
                p.Add("@middleName", teacher.MiddleName);
                p.Add("@address", teacher.Address);
                p.Add("@birthDate", teacher.BirthDate);
                p.Add("@cellPhone", teacher.CellPhone);
                p.Add("@subjectId", teacher.Subject.Id);
                p.Add("@classId", teacher.SchoolClass?.Id);

                connection.Execute("spTeachers_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteTeacher(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                connection.Execute("spTeachers_Delete", new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion


        #region Reports

        public List<SubjectAvgHelper> GetAvgBySubject()
        {
            List<SubjectAvgHelper> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<SubjectAvgHelper>("spMarks_GetAvgBySubject", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<ClassAvgHelper> GetAvgByClass()
        {
            List<ClassAvgHelper> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<ClassAvgHelper>("spMarks_GetAvgByClass", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<SubjectAvgHelper> GetAvgByStudent(int studentId)
        {
            List<SubjectAvgHelper> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<SubjectAvgHelper>("spMarks_GetAvgBySubjectStudent", new { studentId }, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        #endregion

        #region Lesson

        public void AddMarkToStudent(Mark mark, int studentId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@subjectId", mark.Subject.Id);
                p.Add("@studentId", studentId);
                p.Add("@value", mark.ValueMark);

                try
                {
                    connection.Execute("spMarks_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException)
                {
                    throw new ArgumentException("Ошибка");
                }
            }
        }

        public void UpdateMarkToStudent(Mark mark, int studentId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("dateOfIssue", mark.DateOfIssue);
                p.Add("@subjectId", mark.Subject.Id);
                p.Add("@studentId", studentId);
                p.Add("@value", mark.ValueMark);

                connection.Execute("spMarks_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteMarkToStudent(Mark mark, int studentId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("dateOfIssue", mark.DateOfIssue);
                p.Add("@subjectId", mark.Subject.Id);
                p.Add("@studentId", studentId);

                connection.Execute("spMarks_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region User

        private const string db = "StudentsPerformanceForPAS";

        public User GetUserByLoginAndPassword(string login, string password)
        {
            User user;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();

                p.Add("@login", login);
                p.Add("@password", password);
                user = connection.QueryFirstOrDefault<User>("spUsers_GetUserByLoginAndPassword", p, commandType: CommandType.StoredProcedure);
            }

            return user;
        }

        public void CreateUser(User user)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@login", user.Login);
                p.Add("@password", user.Password);
                p.Add("@userId", user.UserId);
                p.Add("@roleId", user.RoleId);

                connection.Execute("spUsers_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUser(User user)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {
                var p = new DynamicParameters();
                p.Add("@login", user.Login);
                p.Add("@userId", user.UserId);
                p.Add("@roleId", user.RoleId);

                connection.Execute("spUsers_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public User GetUser(int id)
        {
            User user;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection(db)))
            {

                user = connection.Query<User>("spUsers_GetUser", new { id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return user;
        }

        #endregion
    }
}
