using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class MoneyTransferForm : Form
    {
        private string username;
        private Label label1;
        private Label label2;
        private TextBox txtBeneficiary;
        private TextBox txtAmount;
        private Button btnTransfer;
        private decimal balance;

        public MoneyTransferForm(string username, decimal balance)
        {
            InitializeComponent();
            this.username = username;
            this.balance = balance;
        }



        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeneficiary = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benificiary name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBeneficiary
            // 
            this.txtBeneficiary.Location = new System.Drawing.Point(174, 21);
            this.txtBeneficiary.Name = "txtBeneficiary";
            this.txtBeneficiary.Size = new System.Drawing.Size(253, 26);
            this.txtBeneficiary.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(174, 55);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(253, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(174, 109);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(118, 41);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click_1);
            // 
            // MoneyTransferForm
            // 
            this.ClientSize = new System.Drawing.Size(575, 382);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBeneficiary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MoneyTransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            string beneficiary = txtBeneficiary.Text;
            decimal amount;

            // Validate amount
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if balance is sufficient
            if (amount > balance)
            {
                MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform transfer
            balance -= amount;
            MessageBox.Show($"Amount transferred: ${amount}\nCurrent balance: ${balance}", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
