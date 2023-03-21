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

namespace BloodBankManagementSystem.Views
{
    public partial class DonateForm : Form
    {
        BloodStockService bloodStockService;
        DonorsService donorsService;
        DonationService donationService;
        public DonateForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodStockService = new BloodStockService();
            this.donorsService = new DonorsService();
            this.donationService = new DonationService();
        }

        private async void DonateForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }
        public void RefreshData()
        {
            DonorsGrid.DataSource = donorsService.SearchAllDonorsForDonation(SearchTextBox.Text);
        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void DonationsRecordsLabel_Click(object sender, EventArgs e)
        {
            DonationRecordsForm donationRecordsForm = new DonationRecordsForm();
            this.Hide();
            donationRecordsForm.Show();
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

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            DonorsForm donorsForm = new DonorsForm();
            this.Hide();
            donorsForm.ShowDialog();
        }

        private void DonateLabel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DonorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DonationVolumeTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                try
                {
                    
                    if (DonorsGrid.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Please select a donor to donate blood.");
                        return;
                    }

                    DataGridViewRow selectedRow = DonorsGrid.SelectedRows[0];
                    int donorId = (int)selectedRow.Cells["Id"].Value;

                    Donor donor = this.donorsService.GetDonorById(donorId);
                    decimal quantity = decimal.Parse(this.DonationVolumeTextBox.Text);

                    DialogResult result = MessageBox.Show($"Are you sure you want to donate {quantity}L of blood from {donor.DonorFirstName} {donor.DonorFirstName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        if (donor != null)
                        {
                            this.donationService.AddDonation(donor, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Donor not found.");
                        }

                        this.DonationVolumeTextBox.Clear();
                        this.RefreshData();

                        this.bloodStockService.AddBlood(donor.BloodGroup, quantity);

                        MessageBox.Show($"Donor: {donor.DonorFirstName} {donor.DonorLastName} successfully donated {quantity}l blood");
                    }
                    else
                    {
                        return;
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
            decimal donationVolume;
            if (decimal.TryParse(DonationVolumeTextBox.Text, out donationVolume))
            {
                if (donationVolume >= 0.25m && donationVolume <= 0.50m)
                {
                    DonationVolumeValidation.Text = "";
                }
                else
                {
                    DonationVolumeValidation.Text = "Donation volume must be between 0.25 and 0.50";
                }
            }
            else
            {
                DonationVolumeValidation.Text = "Invalid input";
            }

            if (DonationVolumeValidation.Text == "")
            {
                return true;
            }

            return false;
        }

        private void ManagePatientsLabel_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            this.Hide();
            patientsForm.Show();
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
    }
}
