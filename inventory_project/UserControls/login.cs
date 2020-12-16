using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_project.Classes;
using System.Text.RegularExpressions;

namespace inventory_project.UserControls
{
    public partial class login : UserControl
    {
        public login()
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
                    AccountManager.GetUserType(account.accountName);
                }
            }
            else
            {
                MessageBox.Show("A jelszó és a felhasználónév nem lehet üres");
            }

        }
    }
}
