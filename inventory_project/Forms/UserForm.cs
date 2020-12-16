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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace inventory_project
{

    public partial class UserForm : Form
    {
        inventoryDatabaseEntities1 context = new inventoryDatabaseEntities1();
        List<asset> assets;
        List<user> users;
        String currentUser;
        dynamic adatForras;
        private int remainingTime = 900;
        Excel.Application excelApp;
        Excel.Workbook excelWorkbook;
        Excel.Worksheet excelWorkSheet;
        public UserForm(String user)
        {
            InitializeComponent();
            currentUser = user;
            getData();
            remainingTimer.Start();
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
            adatForras = userAsset.ToList();
            dataGridView1.DataSource = userAsset.ToList();
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

        private void remainingTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = "Hátralévő idő:" + remainingTime / 60 + "perc" + remainingTime % 60 + "másodperc";
            if (remainingTime == 0)
            {
                remainingTimer.Stop();
                remainingTime = 900;
                Form1 form = new Form1();
                Account account = new Account();
                account.accountName = String.Empty;
                account.password = String.Empty;
                form.Show();
                this.Close();
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
        private void CreateExcel()
        {
            string[] headers = new string[] {
                "Eszköz neve",
                "Model",
                "Kategória",
                "Gyári szám"
            };
            for (int i = 0; i < headers.Length; i++)
            {
                excelWorkSheet.Cells[1, i + 1] = headers[i];
            }
            object[,] values = new object[adatForras.Count, headers.Length];
            int counter = 0;
            foreach (var e in adatForras)
            {
                values[counter, 0] = e.assetname;
                values[counter, 1] = e.model;
                values[counter, 2] = e.category;
                values[counter, 3] = e.price;
                values[counter, 4] = e.purchasedate;
                values[counter, 5] = e.serialnumber;
                values[counter, 6] = e.username;
                counter++;
            }
            excelWorkSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
            int lastRowID = excelWorkSheet.UsedRange.Rows.Count;
            int lastColID = excelWorkSheet.UsedRange.Columns.Count;
            Excel.Range headerRange = excelWorkSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            Excel.Range tableRange = excelWorkSheet.get_Range(GetCell(1, 1), GetCell(1 + values.GetLength(0), values.GetLength(1)));
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.Font.Bold = true;
            headerRange.Font.Italic = true;
            tableRange.BorderAround2(Excel.XlLineStyle.xlDouble, Excel.XlBorderWeight.xlMedium);
        }

        private string GetCell(int x, int y) //Órai függvény felhasználása
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;
            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
