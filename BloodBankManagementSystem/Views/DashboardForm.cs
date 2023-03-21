using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagementSystem.Models;
using BloodBankManagementSystem.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BloodBankManagementSystem.Views
{
    public partial class DashboardForm : Form
    {
        UsersService usersService;
        DonorsService donorsService;
        PatientsService patientsService;
        BloodStockService bloodStockService;
        BloodTransfusionService bloodTransfusion;
        DonationService donationService;

        public DashboardForm()
        {
            this.usersService = new UsersService();
            this.donorsService = new DonorsService();
            this.patientsService = new PatientsService();
            this.bloodStockService = new BloodStockService();
            this.bloodTransfusion = new BloodTransfusionService();
            this.donationService = new DonationService();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WelcomeLabel.Text = $"Welcome, {LoggedUser.Name}";
            donorsNumber.Text = $"{donorsService.GetDonorsCount()}";
            patientsNumber.Text = $"{patientsService.GetPatientsCount()}";
            transfusionsNuumber.Text = $"{bloodTransfusion.GetBloodTransfusionsCount()}";
            donationNumber.Text = $"{donationService.GetAllDonationsCount()}";
            SetBloodGroupCount("O+", lblOpositiveCount);
            SetBloodGroupCount("O-", lblOnegativeCount);
            SetBloodGroupCount("A+", lblApositiveCount);
            SetBloodGroupCount("A-", lblAnegativeCount);
            SetBloodGroupCount("B+", lblBpositiveCount);
            SetBloodGroupCount("B-", lblBnegativeCount);
            SetBloodGroupCount("AB+", lblABpositiveCount);
            SetBloodGroupCount("AB-", lblABnegativeCount);
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }

        }

        private void SetBloodGroupCount(string bloodGroup, Label label)
        {
            decimal count = bloodStockService.GetQuantityByBloodGroup(bloodGroup);
            label.Text = $"{count}";
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblABnegative_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorsForm donorsForm = new DonorsForm();
            donorsForm.ShowDialog();
        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void DonateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonateForm donateForm = new DonateForm();
            donateForm.Show();
        }

        private void ManagePatientsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
        }

        private void lblOpositiveCount_Click(object sender, EventArgs e)
        {

        }

        private void lblABpositiveCount_Click(object sender, EventArgs e)
        {

        }

        private void donorsNumber_Click(object sender, EventArgs e)
        {

        }

        private void RecordsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferRecordsForm transferRecordsForm = new TransferRecordsForm();
            transferRecordsForm.Show();
        }

        private void DonationsRecordsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationRecordsForm donationRecordsForm = new DonationRecordsForm();
            donationRecordsForm.Show();
        }

        private void transfusionsNuumber_Click(object sender, EventArgs e)
        {

        }
    }
}
