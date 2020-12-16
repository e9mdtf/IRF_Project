using inventory_project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project
{

    public partial class UserForm : Form
    {
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();
        List<asset> assets;
        List<user> users;
        String currentUser;
        public UserForm(String user)
        {
            InitializeComponent();
            currentUser = user;
            getData();
        }

        private void getData()
        {
            assets = context.assets.ToList();
            users = context.users.ToList();
            var userAsset = from x in users
                            where x.username == currentUser && x.assetFk == x.asset.assetID
                            select new
                            {
                                x.asset.assetname,
                                x.asset.model,
                                x.asset.category,
                                x.asset.serialnumber
                            };
            dataGridView1.DataSource = userAsset.ToList();
        }
    }
}
