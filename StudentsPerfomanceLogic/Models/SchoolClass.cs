using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public class SchoolClass
    {
        public int Id { get; }
        public string Name { get; }
        public List<Student> Students { get; set; }

        public SchoolClass(int id, string name)
        {
            Id = id;
            Name = name;
            Students = new List<Student>();
        }

        //public SchoolClass() { }
    }
}
