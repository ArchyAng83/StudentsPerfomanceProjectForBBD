using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.DataAccess
{
    public interface IDataConnection
    {
        User GetUserByLoginAndPassword(string login, string password);
    }
}
