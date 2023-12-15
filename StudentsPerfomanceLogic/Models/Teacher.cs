using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class Teacher : Person
    {
        [DisplayName("Предмет")]
        public Subject Subject { get; }
        [DisplayName("Класс")]
        public SchoolClass SchoolClass { get; }

        public Teacher(int id,
           string lastName,
           string firstName,
           string middleName,
           string address,
           DateTime birthDate,
           string cellPhone,
           Subject subject,
           SchoolClass schoolClass) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone)
        {
            Subject = subject;
            SchoolClass = schoolClass;
        }

        public Teacher(int id,
           string lastName,
           string firstName,
           string middleName,
           string address,
           DateTime birthDate,
           string cellPhone) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone)
        {
            
        }
    }
}
