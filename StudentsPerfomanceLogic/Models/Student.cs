using System;
using System.Collections.Generic;

namespace StudentsPerformanceLogic.Models
{
    public class Student : Person
    {        
        public Guardian[] Guardians { get; set; } 

        public Student(int id,
           string firstName,
           string middleName,
           string lastName,
           string address,
           DateTime birthDate,
           string cellPhone) : base(id, firstName, middleName, lastName, address, birthDate, cellPhone)
        {
            Guardians = new Guardian[2];
        }
    }
}