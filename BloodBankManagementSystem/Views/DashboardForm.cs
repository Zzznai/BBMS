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
        DonorsService donorsService = new DonorsService();
        PatientsService patientsService = new PatientsService();
        BloodStockService bloodStockService;
        public DashboardForm()
        {
            this.usersService = new UsersService();
            this.donorsService = new DonorsService();
            this.patientsService=new PatientsService();
            this.bloodStockService = new BloodStockService();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WelcomeLabel.Text = $"Welcome, {LoggedUser.Name}";
            donorsNumber.Text = $"{donorsService.GetDonorsCount()}";
            patientsNumber.Text = $"{patientsService.GetPatientsCount()}";
            SetBloodGroupCount("O+", lblOpositiveCount);
            SetBloodGroupCount("O-", lblOnegativeCount);
            SetBloodGroupCount("A+", lblApositiveCount);
            SetBloodGroupCount("A-", lblAnegativeCount);
            SetBloodGroupCount("B+", lblBpositiveCount);
            SetBloodGroupCount("B-", lblBnegativeCount);
            SetBloodGroupCount("AB+", lblABpositiveCount);
            SetBloodGroupCount("AB-", lblABnegativeCount);

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

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        

        private void ManageDonorsLabel_Click(object sender, EventArgs e)
        {
            DonorsForm donorsForm = new DonorsForm();
            this.Hide();
            donorsForm.ShowDialog();
        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
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
    }
}
