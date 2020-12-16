using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace inventory_project.Classes
{
    class Account
    {
        public String accountName { get; set; }
        public String password { get; set; }
        public Boolean adminStatus { get; set; }
    }
}
