﻿using System;
using System.Collections.Generic;

namespace StudentsPerformanceLogic.Models
{
    public class Student : Person
    {        
        public List<Guardian> Guardians { get; set; }
        public List<Mark> Marks { get; set; }

        public Student(int id,
           string lastName,
           string firstName,
           string middleName,
           string address,
           DateTime birthDate,
           string cellPhone) : base(id, lastName, firstName, middleName, address, birthDate, cellPhone)
        {
            Guardians = new List<Guardian>();
            Marks = new List<Mark>();
        }

        public Student(int id,
           string lastName,
           string firstName,
           string middleName) : base(id, lastName, firstName, middleName) { }
    }
}