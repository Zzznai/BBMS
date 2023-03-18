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
    }
}
