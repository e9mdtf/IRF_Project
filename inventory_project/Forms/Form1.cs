﻿using inventory_project.Classes;
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
        inventoryDatabaseEntities1 entities = new inventoryDatabaseEntities1();
        List<user> users;
        public Form1()
        {
            InitializeComponent();
            users = entities.users.ToList();
      }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Regex notBlankRegex = new Regex(@"^(?!\s*$).+");
            if (notBlankRegex.IsMatch(nameTextBox.Text) & notBlankRegex.IsMatch(passwordTextBox.Text))
            {
                Account account = new Account();
                account.accountName = nameTextBox.Text;
                account.password = AccountManager.getHash(passwordTextBox.Text);
                bool userExists = AccountManager.CheckUser(account.accountName, account.password, users);
                if (userExists == true)
                {
                    bool userType = AccountManager.GetUserType(account.accountName, users);
                    if (userType == true)
                    {
                        adminForm f = new adminForm(account.accountName);
                        this.Hide();
                        f.Show();
                        f.Activate();                     
                    }
                    else
                    {
                        UserForm f = new UserForm(account.accountName);
                        this.Hide();
                        f.Show();
                        f.Activate();
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

