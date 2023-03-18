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

namespace BloodBankManagementSystem.Views
{
    public partial class EditUserForm : Form
    {
        private int id;
        private UsersService usersService;
        
        public EditUserForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.id = id;
            this.usersService = new UsersService();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (usersService.IsEmailUsedByAnotherUser(id, EmailTextBox.Text))
            {
                MessageBox.Show("A user with this email already exists. Please use a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Clear();
            }
            else
            {
                AdminForm adminForm = (AdminForm)Application.OpenForms["AdminForm"];
                usersService.EditUser(id, FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
                adminForm.RefreshData();
                this.Close();
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            Users user = this.usersService.GetUserById(id);

            if (user == null)
            {
                MessageBox.Show("This user doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.FirstNameTextBox.Text = user.FirstName;
            this.LastNameTextBox.Text = user.LastName;
            this.EmailTextBox.Text = user.Email;
            this.PasswordTextBox.Text = user.Password;            
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
