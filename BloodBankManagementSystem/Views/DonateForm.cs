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
        DonorsService donorsService;
        DonationService donationService;
        public DonateForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.donorsService = new DonorsService();
            this.donationService = new DonationService();
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            DonorsGrid.DataSource = donorsService.SearchAllDonorsForDonation(SearchTextBox.Text);
        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void DonationsRecordsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show($"Donor: {donor.DonorFirstName} {donor.DonorLastName} successfully donated {quantity}l blood");
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
    }
}
