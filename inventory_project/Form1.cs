using inventory_project.UserControls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void LoginWindow()
        {
            login lg = new login();
            lg.Dock = DockStyle.Fill;
            this.Controls.Add(lg);
        }
    }
}
