using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class ClassTeacher : Teacher
    {
        public SchoolClass SchoolClass { get; set; }

        public ClassTeacher(int id,
           string lastName,
           string firstName,
           string middleName,
           string address,
           DateTime birthDate,
           Subject subject,
           SchoolClass schoolClass,
           string cellPhone) : base(id, lastName, firstName, middleName, address, birthDate, subject, cellPhone)
        {
            SchoolClass = schoolClass;
        }
    }
}
