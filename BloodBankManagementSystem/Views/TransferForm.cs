﻿using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Infragistics.Portable.Graphics.Media;
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
            BloodStockDataGridView.DefaultCellStyle.SelectionBackColor = BloodStockDataGridView.DefaultCellStyle.BackColor;

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
            PatientsGrid.DataSource = patientsService.SearchAllPatients(SearchTextBox.Text);
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
                    if (bloodStock!= null) 
                    {
                        DataGridViewRow selectedRow = PatientsGrid.SelectedRows[0];
                        int patientId = (int)selectedRow.Cells["Id"].Value;

                        Patient patient = this.patientsService.GetPatientById(patientId);
                        string message = $"Do you want to add a blood transfusion of {neededQuantity} L. from {bloodStock.BloodGroup} to {patient.PatientFirstName} {patient.PatientLastName} ?";
                        DialogResult result = MessageBox.Show(message, "Confirm Blood Transfusion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            this.bloodTransfusionService.AddBloodTransfusion(patient, bloodStock, neededQuantity);
                            MessageBox.Show($"Successful blood transfer for Patient: {patient.PatientFirstName} {patient.PatientLastName}, Transfer info: {bloodStock.BloodGroup}, quantity: {neededQuantity}");
                           this.RefreshBloodStock();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool IsFormValid()
        {
            decimal transferVolume;
            if (decimal.TryParse(TransferVolumeTextBox.Text, out transferVolume))
            {
                if (transferVolume >= 0.110m && transferVolume <= 0.550m)
                {
                    TransferVolumeValidation.Text = "";
                }
                else
                {
                    TransferVolumeValidation.Text = "Transfer volume must be between 0.25 and 0.50";
                }
            }
            else
            {
                TransferVolumeValidation.Text = "Invalid input";
            }

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
                BloodGroupComboBox.DataSource = null; // Set the data source to null to clear the ComboBox
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
            BloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetBloodGroupForPatient();
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
            BloodStockDataGridView.CurrentCell = null;
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
    }
}
