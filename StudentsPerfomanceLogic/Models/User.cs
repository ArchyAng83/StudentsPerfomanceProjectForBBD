﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceLogic.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }        
        public int userId { get; set; }
        public int RoleId { get; set; }
    }
}
