using BloodBankManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Views
{
    public partial class AdminForm : Form
    {
        UsersService usersService;
        public AdminForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.usersService = new UsersService();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UserGrid.DataSource = usersService.SearchAllUsers(SearchUsersTextBox.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            UserGrid.DataSource = usersService.SearchAllUsers(SearchUsersTextBox.Text);
        }

        private void PointerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagaEmpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UserGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DataGridViewRow selectedRow = UserGrid.SelectedRows[0];
            int userId = (int)selectedRow.Cells["UserID"].Value;
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();

            // Show confirmation message box before deleting user
            DialogResult result = MessageBox.Show($"Do you want to delete the user {firstName} {lastName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    usersService.DeleteUser(userId);
                    MessageBox.Show("User deleted successfully.");
                    this.RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}");
                }
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (UserGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            DataGridViewRow selectedRow = UserGrid.SelectedRows[0];
            int userId = (int)selectedRow.Cells["UserID"].Value;
            EditUserForm editUserForm = new EditUserForm(userId);
            editUserForm.Show();
        }

        private void SearchUsersTextBox_TextChanged(object sender, EventArgs e)
        {
            UserGrid.DataSource = usersService.SearchAllUsers(SearchUsersTextBox.Text);
        }
    }

}
