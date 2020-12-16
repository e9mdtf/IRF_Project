using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project
{
    public partial class adminForm : Form
    {
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();
        public adminForm()
        {
            InitializeComponent();
        }
        public void setData()
        {
            context.assets.Load();
            var eszkozok = from s in context.assets
                           select s;
            adminDataGridView.DataSource = eszkozok.ToList();
        }
        private void newAssetBtn_Click(object sender, EventArgs e)
        {
            newAsset form = new newAsset();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //adatbázisba beilleszt
                MessageBox.Show("Az eszköz hozzáadása az adatbázishoz sikeres volt");
            }
            else
            {
                MessageBox.Show("Az új eszköz nem lett hozzáadva az adatbázishoz");
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog importOlvaso = new OpenFileDialog();
            importOlvaso.InitialDirectory = Application.StartupPath;
            importOlvaso.Filter = "Comma Seperated Values (*.csv)|*.csv";
            importOlvaso.DefaultExt = "csv";
            importOlvaso.AddExtension = true;
            if (importOlvaso.ShowDialog() != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(importOlvaso.FileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    asset asset = new asset();
                    asset.assetname = sor[0];
                    asset.model = sor[1];
                    asset.category = sor[2];
                    try
                    {
                        asset.purchasedate = DateTime.Parse(sor[3]);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    asset.price = Int32.Parse(sor[4]);
                    asset.serialnumber = sor[5];
                }
            }
        }
    }
}
