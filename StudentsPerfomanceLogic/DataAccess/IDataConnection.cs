﻿using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.DataAccess
{
    public interface IDataConnection
    {
        User GetUserByLoginAndPassword(string login, string password);
        SchoolClass CreateClass(SchoolClass schoolClass);
        List<SchoolClass> GetAllClasses();
        List<Guardian> GetAllGuardians();
        Guardian AddGuardian(Guardian guardian);
        void UpdateGuardian(Guardian guardian);
        void DeleteGuardian(int id);
        List<Student> GetAllStudents();
        Student AddStudent(Student student, int classId);
        void UpdateStudent(Student student, int classId);
        void DeleteStudent(int id);
        List<Subject> GetAllSubjects();
        Subject CreateSubject(Subject subject);
        List<Teacher> GetAllTeachers();
        Teacher AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        int GetStudentsCount();
        Teacher GetTeacher(int id);
        void AddMarkToStudent(Mark mark, int studentId);
        void UpdateMarkToStudent(Mark mark, int studentId);
        void DeleteMarkToStudent(Mark mark, int studentId);
    }
}
