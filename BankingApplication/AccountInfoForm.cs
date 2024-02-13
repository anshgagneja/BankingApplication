using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class AccountInfoForm : Form
    {
        private string username;
        private Label lblUsername;
        private Label lblBalance;
        private Label lblLastAccess;
        private ListBox listBoxTransactions;
        private Button btnChangePassword;
        private Button btnTransfer;
        private decimal balance = 1000.00m; // Starting balance for demo purposes

        public AccountInfoForm(string username)
        {
            InitializeComponent();
            this.username = username;
            lblUsername.Text = "Username: " + username;
            lblBalance.Text = "Balance: $" + balance.ToString();
            lblLastAccess.Text = "Last Access: " + DateTime.Now.ToString();
            // Populate last 5 transactions (dummy data for demonstration)
            listBoxTransactions.Items.Add("Transaction 1: $50.00");
            listBoxTransactions.Items.Add("Transaction 2: $100.00");
            listBoxTransactions.Items.Add("Transaction 3: -$20.00");
            listBoxTransactions.Items.Add("Transaction 4: $30.00");
            listBoxTransactions.Items.Add("Transaction 5: -$10.00");
        }



        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLastAccess = new System.Windows.Forms.Label();
            this.listBoxTransactions = new System.Windows.Forms.ListBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(17, 86);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.AutoSize = true;
            this.lblLastAccess.Location = new System.Drawing.Point(17, 124);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(96, 20);
            this.lblLastAccess.TabIndex = 2;
            this.lblLastAccess.Text = "Last Access";
            // 
            // listBoxTransactions
            // 
            this.listBoxTransactions.FormattingEnabled = true;
            this.listBoxTransactions.ItemHeight = 20;
            this.listBoxTransactions.Location = new System.Drawing.Point(21, 176);
            this.listBoxTransactions.Name = "listBoxTransactions";
            this.listBoxTransactions.Size = new System.Drawing.Size(148, 84);
            this.listBoxTransactions.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(21, 288);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(151, 38);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click_1);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(209, 288);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(127, 37);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click_1);
            // 
            // AccountInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(432, 366);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.listBoxTransactions);
            this.Controls.Add(this.lblLastAccess);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUsername);
            this.Name = "AccountInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            MoneyTransferForm moneyTransferForm = new MoneyTransferForm(username, balance);
            moneyTransferForm.ShowDialog();
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            // Open Change Password form
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(username);
            changePasswordForm.ShowDialog();
        }
    }
}
