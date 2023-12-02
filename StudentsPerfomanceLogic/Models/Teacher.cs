﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.Models
{
    public class Teacher : Person
    {
        public Subject Subject { get; set; }

        public Teacher(int id, 
            string firstName, 
            string middleName, 
            string lastName, 
            string address, 
            DateTime birthDate, 
            Subject subject,
            string cellPhone) : base(id, firstName, middleName, lastName, address, birthDate, cellPhone)
        {
            Subject = subject;
        }
    }
}
