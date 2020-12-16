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

        public AccountManager()
        {
            LoadUsers();
        }
        public static Boolean CheckUser(string accountName, string password)
        {
            var user = from us in users
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
        public static String GetUserType(String accountName)
        {
            
            var users = 
            var currentAccountStatus = from stat in 
                                       where stat.username == accountName
                                       select stat.adminstatus;
            return currentAccountStatus.ToString();
        }
        public user LoadUsers()
        {
            context.users.Load();
            var users = context.users.Local;
            return users;
        }
    }
}
