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
    public partial class PatientsForm : Form
    {
        PatientsService patientsService;
        public PatientsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.patientsService = new PatientsService();
        }

        public void RefreshData()
        {
            PatientsGrid.DataSource = patientsService.SearchAllPatients(SearchPatientsTextBox.Text);
        }

        private async void PatientsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();

        }

        private void SearchPatientsTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PatientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a donor to edit.");
                return;
            }

            DataGridViewRow selectedRow = PatientsGrid.SelectedRows[0];
            int patientId = (int)selectedRow.Cells["Id"].Value;
            EditPatientForm editPatientForm = new EditPatientForm(patientId);
            editPatientForm.ShowDialog();
        }

        private void DashBoardLabell_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void DonateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonateForm donateForm = new DonateForm();
            donateForm.Show();
        }

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            DonorsForm donorsForm = new DonorsForm();
            this.Hide();
            donorsForm.ShowDialog();
        }

        private void ManagePatientsLabel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DonationsRecordsLabel_Click(object sender, EventArgs e)
        {
            DonationRecordsForm donationRecordsForm = new DonationRecordsForm();
            this.Hide();
            donationRecordsForm.Show();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            this.Hide();
            transferForm.Show();
        }

        private void RecordsLabel_Click(object sender, EventArgs e)
        {
            TransferRecordsForm transferRecordsForm = new TransferRecordsForm();
            this.Hide();
            transferRecordsForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PatientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.");
                return;
            }
            DataGridViewRow selectedRow = PatientsGrid.SelectedRows[0];
            int patientId = (int)selectedRow.Cells["Id"].Value;
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();


            // Show confirmation message box before deleting user
            DialogResult result = MessageBox.Show($"Do you want to delete the patient {firstName} {lastName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    patientsService.DeletePatient(patientId);
                    MessageBox.Show("Patient deleted successfully.");
                    this.RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient: {ex.Message}");
                }
            }
        }
    }
}
