﻿using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Views
{
    /// <summary>
    /// Form for adding a blood transfusion
    /// </summary>
    public partial class TransferForm : Form
    {
        PatientsService patientsService;
        BloodStockService bloodStockService;
        BloodTransfusionService bloodTransfusionService;

        public TransferForm()
        {
            InitializeComponent();
            this.patientsService = new PatientsService();
            this.bloodStockService = new BloodStockService();
            this.bloodTransfusionService = new BloodTransfusionService();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BloodStockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async void TransferForm_Load(object sender, EventArgs e)
        {
            this.RefreshData();
            this.GetBloodGroupForPatient();
            this.RefreshBloodStock();
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }

        public void RefreshData()
        {
            PatientsGrid.DataSource = patientsService.SearchAllPatientsForTransfer(SearchTextBox.Text);
            this.GetBloodGroupForPatient();
        }

        public void RefreshBloodStock()
        {
            BloodStockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BloodStockDataGridView.MultiSelect = false;
            BloodStockDataGridView.ReadOnly = true;
            BloodStockDataGridView.DataSource = bloodStockService.GetAllBloodStocks();
            BloodStockDataGridView.CurrentCell = null;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (PatientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to transfer blood.");
                return;
            }

            bool isValid = IsFormValid();

            if (isValid)
            {
                try
                {
                    decimal neededQuantity = decimal.Parse(TransferVolumeTextBox.Text);
                    BloodStock bloodStock = bloodStockService.GetBloodStock(BloodGroupComboBox.SelectedItem.ToString());
                    if (bloodStock != null)
                    {
                        DataGridViewRow selectedRow = PatientsGrid.SelectedRows[0];
                        int patientId = (int)selectedRow.Cells["Id"].Value;

                        Patient patient = this.patientsService.GetPatientById(patientId);
                        string message = $"Do you want to add a blood transfusion of {neededQuantity} L. from {bloodStock.BloodGroup} to {patient.PatientFirstName} {patient.PatientLastName} ?";
                        DialogResult result = MessageBox.Show(message, "Confirm Blood Transfusion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.bloodTransfusionService.AddBloodTransfusion(patient, bloodStock, neededQuantity);
                            MessageBox.Show($"Successful blood transfer for Patient: {patient.PatientFirstName} {patient.PatientLastName}, Transfer info: {bloodStock.BloodGroup}, quantity: {neededQuantity}");
                            this.RefreshBloodStock();
                            TransferVolumeTextBox.Clear();
                            TransferVolumeValidation.Text = " ";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool IsFormValid()
        {

            if (TransferVolumeValidation.Text == "")
            {
                return true;
            }

            return false;
        }

        private void GetBloodGroupForPatient()
        {
            if (PatientsGrid.SelectedRows.Count == 0)
            {
                BloodGroupComboBox.DataSource = null;
                return;
            }

            DataGridViewRow selectedRow = PatientsGrid.SelectedRows[0];
            int patientId = (int)selectedRow.Cells["Id"].Value;

            Patient patient = this.patientsService.GetPatientById(patientId);

            List<string> compatibleBloodGroups = BloodCompatibility.GetRecipientsByGroup(patient.BloodGroup);

            this.BloodGroupComboBox.DataSource = compatibleBloodGroups;

        }

        private void PatientsGrid_SelectionChanged(object sender, EventArgs e)
        {
            this.GetBloodGroupForPatient();
        }

        private void TransferVolumeTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal transferVolume;
            if (decimal.TryParse(TransferVolumeTextBox.Text, out transferVolume))
            {
                if (transferVolume >= 0.100m && transferVolume <= 0.750m)
                {
                    TransferVolumeValidation.Text = "";
                }
                else
                {
                    TransferVolumeValidation.Text = "Transfer volume must be between 0.10 and 0.75 L.";
                }
            }
            else
            {
                TransferVolumeValidation.Text = "Invalid Input";
            }

        }

        private void BloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PatientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.GetBloodGroupForPatient();
            }
            else
            {
                BloodGroupComboBox.DataSource = null;
            }
        }

        private void PatientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.GetBloodGroupForPatient();
            }
            else
            {
                BloodGroupComboBox.DataSource = null;
            }
        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            DonorsForm donorsForm = new DonorsForm();
            this.Hide();
            donorsForm.ShowDialog();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DonateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonateForm donateForm = new DonateForm();
            donateForm.Show();
        }

        private void DonationsRecordsLabel_Click(object sender, EventArgs e)
        {
            DonationRecordsForm donationRecordsForm = new DonationRecordsForm();
            this.Hide();
            donationRecordsForm.Show();
        }

        private void ManagePatientsLabel_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            this.Hide();
            patientsForm.Show();
        }

        private void RecordsLabel_Click(object sender, EventArgs e)
        {
            TransferRecordsForm transferRecordsForm = new TransferRecordsForm();
            this.Hide();
            transferRecordsForm.Show();
        }

        private void BloodStockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BloodStockDataGridView.ClearSelection();
            }
        }
        private void BloodStockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BloodStockDataGridView.ClearSelection();
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

        private void TransferVolumeValidation_Click(object sender, EventArgs e)
        {

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
