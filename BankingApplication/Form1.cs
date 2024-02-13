using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usrtxt.Text;
            string password = passtxt.Text;

            // Validate username and password (dummy validation)
            if (username == "anshgagneja" && password == "220911456")
            {
                // Open Account Information form
                AccountInfoForm accountInfoForm = new AccountInfoForm(username);
                accountInfoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
