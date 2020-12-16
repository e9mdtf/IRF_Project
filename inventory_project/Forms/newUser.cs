using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project.Forms
{
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
        private void okBtn_Click(object sender, EventArgs e)
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
        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            validate(usernameTextBox, e);
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            validate(passwordTextBox, e);
        }

        private void passwordTextBox2_Validating(object sender, CancelEventArgs e)
        {
            validate(passwordTextBox2, e);
            if (passwordTextBox2.Text != passwordTextBox.Text)
            {
                e.Cancel = true;
                passwordTextBox2.BackColor = Color.Fuchsia;
                MessageBox.Show("A két jelszónak meg kell egyeznie");
            }
        }
    }
}
