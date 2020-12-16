using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.Classes
{
    class AccountManager
    {
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();

        public static Boolean CheckUser(string accountName, string password, inventoryDatabaseEntities context)
        {
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
        public static String GetUserType(String accountName, inventoryDatabaseEntities context)
        {
            var currentAccountStatus = from stat in context.users
                                       where stat.username == accountName
                                       select stat.adminstatus;
            return currentAccountStatus.ToString();
        }
        public static string getHash(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            return hash.ToString();
        }
    }
}
