using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class Teacher : Person
    {
        public Subject Subject { get; set; }

        public Teacher(int id,
            string lastName,
            string firstName, 
            string middleName,  
            string address, 
            DateTime birthDate, 
            Subject subject,
            string cellPhone) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone)
        {
            Subject = subject;
        }
    }
}
