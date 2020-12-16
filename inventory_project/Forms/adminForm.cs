using inventory_project.Classes;
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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace inventory_project
{
    public partial class adminForm : Form
    {
        Excel.Application excelApp;
        Excel.Workbook excelWorkbook;
        Excel.Worksheet excelWorkSheet;
        inventoryDatabaseEntities context = new inventoryDatabaseEntities();
        private int remainingTime = 900;
        List<IQueryable> exportData;
        public adminForm(String user)
        {
            InitializeComponent();
            setData();
        }
        public void setData()
        {
            context.assets.Load();
            var eszkozok = from s in context.users
                           select new
                           {
                               s.asset.assetname,
                               s.asset.model,
                               s.asset.category,
                               s.asset.price,
                               s.asset.purchasedate,
                               s.asset.serialnumber,
                               s.username
                           };
            adminDataGridView.DataSource = eszkozok.ToList();
            timer1.Start();
        }
        private void newAssetBtn_Click(object sender, EventArgs e)
        {
            newAsset form = new newAsset();
            if (form.ShowDialog() == DialogResult.OK)
            {
                asset assets = new asset();
                assets.assetname = form.assetNameTextbox.Text;
                assets.model = form.modelTextBox.Text;
                assets.category = form.categoryTextBox.Text;
                try
                {
                    assets.purchasedate = form.dateTimePicker1.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                assets.price = Int32.Parse(form.priceTextBox.Text);
                assets.serialnumber = form.serialTextBox.Text;
                context.assets.Add(assets);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    manufacturer manufacturer = new manufacturer();
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
                    manufacturer.manufacturerName = sor[6];
                    manufacturer.manufacturerWebsite = sor[7];
                    manufacturer.manufacturerEmail = sor[8];
                    context.assets.Add(asset);
                    context.manufacturers.Add(manufacturer);
                }
            }
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setData();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Account account = new Account();
            account.accountName = String.Empty;
            account.password = String.Empty;
            f.Show();
            this.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateExcel()
        {
            try
            {
                excelApp = new Excel.Application();
                excelWorkbook = excelApp.Workbooks.Add(Missing.Value);
                excelWorkSheet = excelWorkbook.ActiveSheet;
                CreateTable();
                excelApp.Visible = true;
                excelApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                excelWorkbook.Close(false, Type.Missing, Type.Missing);
                excelApp.Quit();
                excelWorkbook = null;
                excelApp = null;
            }
        }
        private void CreateTable()
        {
            string[] headers = new string[](
                "Eszköz neve",
                "Model",
                "Kategória",
                "Beszerzési ár",
                "Beszerzési idő",
                "Gyári szám",
                "Felhasználónév"
                );
            for (int i = 0; i < headers.Length; i++)
            {
                excelWorkSheet.Cells[1, i + 1] = headers[i];
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            timeLabel.Text = "Hátralévő idő:" + remainingTime / 60 + "perc" + remainingTime % 60 + "másodperc";
            if (remainingTime == 0)
            {
                timer1.Stop();
                remainingTime = 900;
                Form1 form = new Form1();
                Account account = new Account();
                account.accountName = String.Empty;
                account.password = String.Empty;
                form.Show();
                this.Close();
            }
        }
    }
} 

    

