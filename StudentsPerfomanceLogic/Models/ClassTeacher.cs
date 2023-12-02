using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.Models
{
    public class ClassTeacher : Teacher
    {
        public SchoolClass SchoolClass { get; set; }

        public ClassTeacher(int id,
           string firstName,
           string middleName,
           string lastName,
           string address,
           DateTime birthDate,
           Subject subject,
           SchoolClass schoolClass,
           string cellPhone) : base(id, firstName, middleName, lastName, address, birthDate, subject, cellPhone)
        {
            SchoolClass = schoolClass;
        }
    }
}
