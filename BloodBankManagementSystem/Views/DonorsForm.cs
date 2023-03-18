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

namespace BloodBankManagementSystem.Views
{
    public partial class DonorsForm : Form
    {
        DonorsService donorsService;
        public DonorsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.donorsService = new DonorsService();
        }

        private void DonorsForm_Load(object sender, EventArgs e)
        {
            DonorsGrid.DataSource = donorsService.GetAllDonors();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DonorsGrid.DataSource = donorsService.GetAllDonors();
        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonorsGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDonorForm addDonor=new AddDonorForm();
            addDonor.ShowDialog();
        }
    }
}
