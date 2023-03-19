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
    public partial class TransferRecordsForm : Form
    {
        private BloodTransfusionService bloodTransfusion;
        public TransferRecordsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodTransfusion = new BloodTransfusionService();
        }

        private void SearchPatientsTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void TransferRecordsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            this.TransfusionGrid.DataSource = this.bloodTransfusion.SearchAllTransfusions(SearchPatientsTextBox.Text);
        }
    }
}
