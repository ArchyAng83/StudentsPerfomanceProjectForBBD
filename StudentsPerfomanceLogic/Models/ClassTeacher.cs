using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class ClassTeacher : Teacher
    {
        public ClassTeacher(int id,
           string lastName,
           string firstName,
           string middleName,
           string address,
           DateTime birthDate,
           string cellPhone,
           Subject subject,
           SchoolClass schoolClass) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone, subject, schoolClass)
        {

        }
    }
}
