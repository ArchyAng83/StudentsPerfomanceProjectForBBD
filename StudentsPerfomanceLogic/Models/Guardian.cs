using System;

namespace StudentsPerformanceLogic.Models
{
    public class Guardian : Person
    {
        public Guardian(int id,
            string lastName,
           string firstName,
           string middleName,           
           string address,
           DateTime birthDate,
           string cellPhone) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone) { }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}