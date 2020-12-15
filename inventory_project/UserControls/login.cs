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
            Regex nameRegex = new Regex(@"^(?!\s*$).+");
            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            if (nameRegex.IsMatch(nameTextBox.Text) & passwordRegex.IsMatch(passwordTextBox.Text))
            {
                Account account = new Account();
                account.accountName = nameTextBox.Text;
                account.password = Account.getHash(passwordTextBox.Text);
            }
            else
            {

            }

        }
    }
}
