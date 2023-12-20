using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Helpers
{
    public class SubjectAvgHelper
    {
        [DisplayName("Предмет")]
        public string Name { get; }
        [DisplayName("Средний балл")]
        public double? Avg { get; }

        public SubjectAvgHelper(string name, double? avg)
        {
            Name = name;
            Avg = avg;
        }
    }
}
