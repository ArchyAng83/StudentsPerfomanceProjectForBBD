using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.DataAccess
{
    public interface IDataConnection
    {
        bool ValidateEnter(string login, string password);
    }
}
