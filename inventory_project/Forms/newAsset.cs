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
    public partial class newAsset : Form
    {
        public newAsset()
        {
            InitializeComponent();
        }
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void Common_Validating(object sender, CancelEventArgs e)
        {

        }
        private void validate(TextBox txt, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = false;
                txt.BackColor = Color.LimeGreen;
            }
            else
            {
                e.Cancel = true;
                txt.BackColor = Color.Fuchsia;
                MessageBox.Show("Kérem töltse ki a mezőt");
            }
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex priceRegex = new Regex(@"^[0 - 9] $");
            if (priceRegex.IsMatch(priceTextBox.Text))
            {
                if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                {
                    e.Cancel = false;
                    priceTextBox.BackColor = Color.LimeGreen;
                }
                else
                {
                    priceTextBox.BackColor = Color.White;
                }
            }
            else
            {
                e.Cancel = true;
                priceTextBox.BackColor = Color.Fuchsia;
                MessageBox.Show("Az ár mezőbe kérem csak számokat írjon!");
            }
        }

        private void assetNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            validate(assetNameTextbox, e);
        }

        private void modelTextBox_Validating(object sender, CancelEventArgs e)
        {
            validate(modelTextBox, e);
        }

        private void categoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            validate(modelTextBox, e);
        }

        private void serialTextBox_Validating(object sender, CancelEventArgs e)
        {
            validate(serialTextBox, e);
        }
    }
}
