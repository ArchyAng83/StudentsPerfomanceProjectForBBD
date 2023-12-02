using System;

namespace StudentsPerformanceLogic.Models
{
    public class Guardian : Person
    {
        public Guardian(int id,
           string firstName,
           string middleName,
           string lastName,
           string address,
           DateTime birthDate,
           string cellPhone) : base(id, firstName, middleName, lastName, address, birthDate, cellPhone) { }
    }
}