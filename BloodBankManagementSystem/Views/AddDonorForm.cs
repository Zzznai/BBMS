using BloodBankManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (BirthDateValidation.Text == "")
            {
                if (HasDonatedCheckBox.Checked)
                {
                    LastDonationTimePicker.Visible = true;
                    LastDonationTimeLabel.Visible = true;
                }
                else
                {
                    LastDonationTimePicker.Visible = false;
                    LastDonationTimeLabel.Visible = false;
                    DonorDonationTimeValidation.Text = "";
                }
            }
            else
            {
                HasDonatedCheckBox.Checked = false;
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

        private void DonorFirstNameValidation_Click(object sender, EventArgs e)
        {

        }

        private void DonorLastNameValidation_Click(object sender, EventArgs e)
        {

        }

        private void DonorGenderValidation_Click(object sender, EventArgs e)
        {

        }

        private void DonorAgeValidation_Click(object sender, EventArgs e)
        {

        }

        private void DonorBloodGroupValidation_Click(object sender, EventArgs e)
        {

        }

        private void DonorDonationTimeValidation_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^\+?[0-9]{1,3}[\s.-]?[0-9]{1,10}[\s.-]?[0-9]{1,10}$").Success;
        }

        private void DonorNumberValidation_Click(object sender, EventArgs e)
        {
            
        }

        private void DonorAdressValidation_Click(object sender, EventArgs e)
        {
            
        }

        private void ContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(DonorContactNumberTextBox.Text))
            {
                ContactNumberValidation.Text = "Please enter a valid phone number";
            }
            else
            {
                ContactNumberValidation.Text = "";
            }
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DonorAdressTextBox.Text.Length < 5)
            {
                DonorAdressValidation.Text = "Please enter a valid address (at least 5 characters)";
            }
            else
            {
                DonorAdressValidation.Text = "";
            }
        }

        private void LastDonationTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }



        private void BirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = BirthdateTimePicker.Value;
            DateTime today = DateTime.Today;

            if (birthdate > today)
            {
                BirthDateValidation.Text = "Invalid date";
                return;
            }

            int age = today.Year - birthdate.Year;

            if (birthdate.Month > today.Month || (birthdate.Month == today.Month && birthdate.Day > today.Day))
            {
                age--;
            }

            if (age < 18 || age > 65)
            {
                BirthDateValidation.Text = "Age must be between 18 and 65 to donate blood";
            }
            else
            {
                BirthDateValidation.Text = "";
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length < 2)
            {
                DonorLastNameValidation.Text = "Please enter a valid first name (at least 2 characters)";
            }
            else
            {
                DonorLastNameValidation.Text = "";
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length < 2)
            {
                DonorFirstNameValidation.Text = "Please enter a valid first name (at least 2 characters)";
            }
            else
            {
                DonorFirstNameValidation.Text = "";
            }
        }
    }
}
