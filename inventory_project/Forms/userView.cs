﻿using inventory_project.Classes;
using inventory_project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project
{
    public partial class userView : Form
    {
        inventoryDatabaseEntities1 context = new inventoryDatabaseEntities1();
        public userView()
        {
            InitializeComponent();
            setData();
        }


        private void setData()
        {
            context.users.Load();
            var users = from u in context.users
                        select u;
            userDataGridView.DataSource = users.ToList();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            var filteredUsers = from i in context.users
                                where i.username.Contains(filterTextBox.Text)
                                select i;
            userDataGridView.DataSource = filteredUsers.ToList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            newUser form = new newUser();
            if (form.ShowDialog() == DialogResult.OK)
            {
                user felhasznalo = new user();
                felhasznalo.username = form.usernameTextBox.Text;
                felhasznalo.userpass = AccountManager.getHash(form.usernameTextBox.Text);
                felhasznalo.adminstatus = form.adminCheckBox.Checked;
                context.users.Add(felhasznalo);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("A felhasználó hozzá lett adva az adatbázishoz");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A felhasználó nem lett hozzáadva az adatbázishoz");
            }
        }
    }
}
