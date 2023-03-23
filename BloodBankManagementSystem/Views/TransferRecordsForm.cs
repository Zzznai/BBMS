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
    /// <summary>
    /// Form for displaying blood transfusion transfer records.
    /// </summary>
    public partial class TransferRecordsForm : Form
    {
        private BloodTransfusionService bloodTransfusion;

        public TransferRecordsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodTransfusion = new BloodTransfusionService();
        }

        public void RefreshData()
        {
            this.TransfusionGrid.DataSource = this.bloodTransfusion.SearchAllTransfusions(SearchPatientsTextBox.Text);
        }

        private void SearchPatientsTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        
        private async void TransferRecordsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }

        
        private void DashBoardLabell_Click(object sender, EventArgs e)
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

        
        private void RecordsLabel_Click(object sender, EventArgs e)
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

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            this.Hide();
            transferForm.Show();
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
        
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}

