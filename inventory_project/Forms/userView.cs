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
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();
        public userView()
        {
            InitializeComponent();
        }


        private void setData()
        {
            context.users.Load();
            var users = from u in context.users
                        select u;
            userDataGridView.DataSource = users.ToList();
        }
    }
}
