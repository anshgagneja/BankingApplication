using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class ChangePasswordForm : Form
    {
        private TextBox txtNewPassword;
        private Label label1;
        private Button btnSave;
        private string username;

        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void InitializeComponent()
        {
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(132, 48);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(280, 26);
            this.txtNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // ChangePasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 302);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPassword);
            this.Name = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            // Save new password (dummy action for demonstration)
            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
