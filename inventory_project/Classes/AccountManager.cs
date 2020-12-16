using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.Classes
{
    class AccountManager
    {
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();
        
        public Boolean CheckUser(string accountName, string password)
        {
            context.users.Load();
            var users = context.users.Local;
            var user = from us in context.users
                       where us.username == accountName && us.userpass == password
                       select us;
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String GetUserType(String accountName)
        {
            context.users.Load();
            var users = context.users.Local;
            var currentAccountStatus = from stat in context.users
                                       where stat.username == accountName
                                       select stat.adminstatus;
            return currentAccountStatus.ToString();
        }
    }
}
