using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformance
{
    public interface ISubjectRequest
    {
        void SubjectComplete(Subject subject);
    }
}
