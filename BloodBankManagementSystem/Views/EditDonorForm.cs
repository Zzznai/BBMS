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
    public partial class EditDonorForm : Form
    {
        public EditDonorForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void EditDonorForm_Load(object sender, EventArgs e)
        {

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

        private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleCheckBox.Checked)
            {
                MaleCheckBox.Checked = false;
            }
        }

        private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleCheckBox.Checked)
            {
                FemaleCheckBox.Checked = false;
            }
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
            int age = this.GetDonorAge();

            if (age < 18 || age > 65)
            {
                BirthDateValidation.Text = "Age must be between 18 and 65 to donate blood";
            }
            else
            {
                BirthDateValidation.Text = "";
            }
        }
        private int GetDonorAge()
        {
            DateTime birthdate = BirthdateTimePicker.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (birthdate.Month > today.Month || (birthdate.Month == today.Month && birthdate.Day > today.Day))
            {
                age--;
            }

            return age;
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

        private void LastDonationTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = BirthdateTimePicker.Value;
            DateTime lastDonationDate = LastDonationTimePicker.Value;

            // Check if the donor is at least 18 years old on the date of last donation
            int ageAtDonation = lastDonationDate.Year - birthdate.Year;
            if (birthdate.Month > lastDonationDate.Month || (birthdate.Month == lastDonationDate.Month && birthdate.Day > lastDonationDate.Day))
            {
                ageAtDonation--;
            }
            if (HasDonatedCheckBox.Checked == true)
            {
                DateTime minValidDonationTime = DateTime.Now.AddHours(1);

                if (lastDonationDate > minValidDonationTime)
                {
                    DonorDonationTimeValidation.Text = "The last donation date cannot be in the future";
                }
                else
                if ((ageAtDonation < 18 || ageAtDonation > 65))
                {
                    DonorDonationTimeValidation.Text = "The donor didnt meet the age requirements for donation at that time";
                }
                else
                {
                    DonorDonationTimeValidation.Text = "";
                }
            }
        }

        private void DonorAdressTextBox_TextChanged(object sender, EventArgs e)
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

        private void DonorContactNumberTextBox_TextChanged(object sender, EventArgs e)
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
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^\+?[0-9]{1,3}[\s.-]?[0-9]{1,10}[\s.-]?[0-9]{1,10}$").Success;
        }

        private void BloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
