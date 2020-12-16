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

        public static Boolean CheckUser(string accountName, string password, List<user> us)
        {
            var user = from u in us
                       where u.username == accountName && u.userpass == password
                       select u;
            List<user> usersFound = user.ToList();
            if (usersFound.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static String GetUserType(String accountName, List<user> us)
        {
            var currentAccountStatus = from stat in us
                                       where stat.username == accountName
                                       select stat.adminstatus;
            return currentAccountStatus.ToString();
        }
        public static string getHash(string password)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
