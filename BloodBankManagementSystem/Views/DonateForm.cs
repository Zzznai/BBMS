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
    public partial class DonateForm : Form
    {
        DonorsService donorsService;
        public DonateForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.donorsService = new DonorsService();
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {
            DonorsGrid.DataSource = donorsService.GetAllDonorsForDonation();
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
    }
}
