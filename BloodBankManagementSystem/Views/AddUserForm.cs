using System;
using BloodBankManagementSystem.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagementSystem.Models;
using BloodBankManagementSystem.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BloodBankManagementSystem.Views
{
    public partial class AddUserForm : Form
    {
        UsersService usersService;

        public AddUserForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.usersService = new UsersService();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool isValid;
            if (FirstNameValidation.Text == "" && LastNameValidation.Text == "" && EmailValidation.Text == "" && PasswordValidation.Text == "")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            if (isValid == true)
            {
                if (usersService.IsEmailUsed(EmailTextBox.Text))
                {
                    MessageBox.Show("A user with this email already exists. Please use a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextBox.Clear();
                }
                else
                {
                    AdminForm adminForm = (AdminForm)Application.OpenForms["AdminForm"];
                    usersService.AddUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
                    adminForm.RefreshData();
                    this.Close();
                }
            }
            else
            {                
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Helper method to validate email address
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length < 2)
            {
                FirstNameValidation.Text= "Please enter a valid first name (at least 2 characters)";
            }
            else
            {
                FirstNameValidation.Text= "";
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length < 2)
            {
                LastNameValidation.Text = "Please enter a valid last name (at least 2 characters)";
            }
            else
            {
                LastNameValidation.Text = "";
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(EmailTextBox.Text))
            {
                EmailValidation.Text = "Please enter a valid email address";
            }
            else
            {
                EmailValidation.Text = "";
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length < 7)
            {
                PasswordValidation.Text = "Please enter a valid password (at least 7 characters)";
            }
            else
            {
                PasswordValidation.Text = "";
            }

        }
    }
}
