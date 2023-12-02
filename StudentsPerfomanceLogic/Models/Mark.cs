using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class Mark
    {
        public DateTime DateOfIssue { get; set; }
        public int Value { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; }

        public Mark(DateTime dateOfIssue, int value, Subject subject, Student student)
        {
            DateOfIssue = dateOfIssue;
            Value = value;
            Subject = subject;
            Student = student;
        }
    }
}
