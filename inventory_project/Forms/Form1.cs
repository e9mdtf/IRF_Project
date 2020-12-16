using inventory_project.Classes;
using inventory_project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project
{
    

    public partial class Form1 : Form
    {
        inventoryDatabaseEntities entities = new inventoryDatabaseEntities();
        public Form1()
        {
            InitializeComponent();
      }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Regex notBlankRegex = new Regex(@"^(?!\s*$).+");
            if (notBlankRegex.IsMatch(nameTextBox.Text) & notBlankRegex.IsMatch(passwordTextBox.Text))
            {
                Account account = new Account();
                account.accountName = nameTextBox.Text;
                account.password = Account.getHash(passwordTextBox.Text);
                bool userExists = AccountManager.CheckUser(account.accountName, account.password);
                if (userExists == true)
                {
                    string userType = AccountManager.GetUserType(account.accountName);
                    if (userType == "1")
                    {
                        adminForm f = new adminForm();
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        UserForm f = new UserForm();
                        f.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A megadott jelszó vagy felhasználónév nem megfelelő!");
                }
            }
            else
            {
                MessageBox.Show("A jelszó és a felhasználónév nem lehet üres");
            }

        }
    }
    }
}
