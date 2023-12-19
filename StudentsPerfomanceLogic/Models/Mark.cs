using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class Mark
    {
        //public DateTime DateOfIssue { get; set; }        
        //public Subject Subject { get; set; }
        //public Student Student { get; set; }
        //public int Value { get; set; }

        //public Mark(DateTime dateOfIssue, Subject subject, Student student, int value)
        //{
        //    DateOfIssue = dateOfIssue;            
        //    Subject = subject;
        //    Student = student;
        //    Value = value;
        //}

        [DisplayName("Дата выставления")]
        public DateTime DateOfIssue { get; }
        [DisplayName("Предмет")]
        public Subject Subject { get; }
        [DisplayName("Оценка")]
        public int ValueMark { get; }

        public Mark(DateTime dateOfIssue, Subject subject, int valueMark)
        {
            DateOfIssue = dateOfIssue;
            Subject = subject;
            ValueMark = valueMark;
        }

        public Mark(DateTime dateOfIssue, int valueMark)
        {
            DateOfIssue = dateOfIssue;
            ValueMark = valueMark;
        }
    }
}
