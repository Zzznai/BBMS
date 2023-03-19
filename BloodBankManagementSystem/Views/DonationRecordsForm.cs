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
    public partial class DonationRecordsForm : Form
    {
        private DonationService donationService;
        public DonationRecordsForm()
        {
            InitializeComponent();
            this.donationService = new DonationService();
        }

        private void DonationRecordsForm_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void RefreshData()
        {
            this.DonationGrid.DataSource = this.donationService.GetAllDonations();
        }
    }
}
