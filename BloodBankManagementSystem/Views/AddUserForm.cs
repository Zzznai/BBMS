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

        private async void AddUserForm_Load(object sender, EventArgs e)
        {
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }

        private async void ExitLabel_Click(object sender, EventArgs e)
        {
            for (double opacity = 1; opacity >= 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            bool isValid = IsFormDataValid();
            if (isValid == true)
            {
                if (usersService.IsEmailUsed(EmailTextBox.Text))
                {
                    MessageBox.Show("A user with this email already exists. Please use a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextBox.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to add the user {FirstNameTextBox.Text} {LastNameTextBox.Text}?",
                                                  "Confirm Add User",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        AdminForm adminForm = (AdminForm)Application.OpenForms["AdminForm"];
                        usersService.AddUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
                        adminForm.RefreshData();
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {                
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsFormDataValid()
        {
            bool isValid = false;
            if (FirstNameValidation.Text == "" && LastNameValidation.Text == "" && EmailValidation.Text == "" && PasswordValidation.Text == "")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
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
