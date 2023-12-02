using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.Models
{
    public class ClassTeacher : Teacher
    {
        public SchoolClass Class { get; set; }
    }
}
