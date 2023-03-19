﻿using System;
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
            DonorsGrid.DataSource = donorsService.SearchAllDonors(SearchDonorsTextBox.Text);
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

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonorsGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditDonorForm editDonorForm = new EditDonorForm();
            editDonorForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDonorForm addDonorForm=new AddDonorForm();
            addDonorForm.ShowDialog();
        }

        public void RefreshData()
        {
             DonorsGrid.DataSource = donorsService.SearchAllDonors(SearchDonorsTextBox.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
              if (DonorsGrid.SelectedRows.Count == 0)
              {
                    MessageBox.Show("Please select a donor to delete.");
                    return;
              }

              DataGridViewRow selectedRow = DonorsGrid.SelectedRows[0];
              int Id= (int)selectedRow.Cells["Id"].Value;
              string firstName = selectedRow.Cells["FirstName"].Value.ToString();
              string lastName = selectedRow.Cells["LastName"].Value.ToString();

              DialogResult result = MessageBox.Show($"Do you want to delete the donor {firstName} {lastName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (result == DialogResult.Yes)
              {
                  try
                  {
                      donorsService.DeleteUser(Id);
                      MessageBox.Show("Donor deleted successfully.");
                      this.RefreshData();
                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show($"Error deleting donor: {ex.Message}");
                  }
              }
            
        }

        private void DashBoardLabell_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
        }

        private void SearchDonorsTextBox_TextChanged_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DonateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonateForm donateForm = new DonateForm();
            donateForm.Show();
        }

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            this.RefreshData();
        }
    }
}
