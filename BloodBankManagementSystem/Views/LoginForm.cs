using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        UsersService usersService;
        public LoginForm()
        {
            this.usersService = new UsersService();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
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
            System.Environment.Exit(1);
        }

        private void UserSignInButton_Click(object sender, EventArgs e)
        {
            var email = this.EmailTextBox.Text;
            var password = this.PasswordTextBox.Text;

            var isValid = this.usersService.IsUserValid(email, password);

            try
            {
                if (isValid)
                {
                    var isAdmin = this.usersService.IsUserAdmin(email, password);
                    LoggedUser.Name=this.usersService.GetUserNameByEmail(email);

                    if (isAdmin)
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                       
                        this.Hide();
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                    EmailTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't connect to the database. Please contact developer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KeyPictureBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                // If the password is currently hidden, show it.
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                // If the password is currently shown, hide it.
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
