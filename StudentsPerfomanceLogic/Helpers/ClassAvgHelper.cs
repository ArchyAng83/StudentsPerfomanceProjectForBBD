using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Helpers
{
    public class ClassAvgHelper
    {
        [DisplayName("Класс")]
        public string Name { get; }
        [DisplayName("Средний балл")]
        public double? Avg { get; }

        public ClassAvgHelper(string name, double? avg)
        {
            Name = name;
            Avg = avg;
        }
    }
}
