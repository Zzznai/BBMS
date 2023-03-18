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
    public partial class AddDonorForm : Form
    {
        BloodStockService bloodStockService;
        public AddDonorForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodStockService = new BloodStockService();
        }

        private void AddDonor_Load(object sender, EventArgs e)
        {
            LastDonationTimePicker.Value = DateTime.Now;
            LastDonationTimePicker.Visible = false;
            LastDonationTimeLabel.Visible = false;
            List<string> bloodGroups = bloodStockService.GetAllBloodGroupsSortedById();
            BloodGroupComboBox.DataSource = bloodGroups;

        }

        private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleCheckBox.Checked) 
            {
                MaleCheckBox.Checked = false; 
            }
        }

        private void HasDonatedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           if(HasDonatedCheckBox.Checked)
           {
                LastDonationTimePicker.Visible = true;
                LastDonationTimeLabel.Visible = true;
           }
           else
           {
                LastDonationTimePicker.Visible = false;
                LastDonationTimeLabel.Visible = false;
           }
        }

        private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleCheckBox.Checked)
            {
                FemaleCheckBox.Checked = false;
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloodGroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
