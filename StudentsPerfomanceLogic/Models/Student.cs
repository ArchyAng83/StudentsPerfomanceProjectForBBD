using System;
using System.Collections.Generic;

namespace StudentsPerfomanceLogic.Models
{
    public class Student : Person
    {        
        public List<Guardian> Guardians { get; set; }
    }
}