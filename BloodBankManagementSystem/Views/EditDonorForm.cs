using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Infragistics.Portable.Graphics.Media;
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
        private int id;
        private BloodStockService bloodStockService;
        private DonorsService donorsService;

        public EditDonorForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.id = id;
            this.donorsService = new DonorsService();
            this.bloodStockService = new BloodStockService();
        }

        private async void EditDonorForm_Load(object sender, EventArgs e)
        {
            List<string> bloodGroups = bloodStockService.GetAllBloodGroupsSortedById();
            BloodGroupComboBox.DataSource = bloodGroups;
            Donor donor = donorsService.GetDonorById(id);

            if (donor == null)
            {
                MessageBox.Show("This donor doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.FirstNameTextBox.Text = donor.DonorFirstName;
            this.LastNameTextBox.Text = donor.DonorLastName;
            this.FemaleCheckBox.Checked = donor.DonorGender.Equals(GlobalConstants.Female);
            this.MaleCheckBox.Checked = donor.DonorGender.Equals(GlobalConstants.Male);
            this.BirthdateTimePicker.Value = donor.DonorBirthDate.Value;
            this.BloodGroupComboBox.SelectedItem = donor.BloodGroup;
            this.DonorContactNumberTextBox.Text = donor.ContactNumber;
            this.DonorAdressTextBox.Text = donor.Address;
            this.HasDonatedCheckBox.Checked = donor.LastDonationDate != null;
            this.HasDonatedCheckBox.Enabled = donor.LastDonationDate == null;
            this.LastDonationTimePicker.Enabled = donor.LastDonationDate == null;
            this.LastDonationTimePicker.Value = this.HasDonatedCheckBox.Checked ? donor.LastDonationDate.Value : DateTime.Now;
            this.LastDonationTimePicker.Visible = this.HasDonatedCheckBox.Checked ? true : false;
            this.LastDonationTimeLabel.Visible = this.HasDonatedCheckBox.Checked ? true : false;
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            bool isValid = IsFormDataValid();
            Donor donor = this.donorsService.GetDonorById(id);

            if (isValid)
            {
                donor.DonorFirstName = FirstNameTextBox.Text;
                donor.DonorLastName = LastNameTextBox.Text;
                donor.DonorAge = this.GetDonorAge();
                if (FemaleCheckBox.Checked)
                {
                    donor.DonorGender = GlobalConstants.Female;
                }
                else
                if (MaleCheckBox.Checked)
                {
                    donor.DonorGender = GlobalConstants.Male;
                }
                donor.DonorBirthDate = BirthdateTimePicker.Value;
                if (HasDonatedCheckBox.Checked)
                {
                    donor.LastDonationDate = LastDonationTimePicker.Value;
                    if (!donor.BloodGroup.Equals(BloodGroupComboBox.SelectedItem.ToString()))
                    {
                        MessageBox.Show("You can't change the blood group if the donor has donated previously", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BloodGroupComboBox.SelectedItem = donor.BloodGroup;
                        return;
                    }
                }
                donor.BloodGroup = BloodGroupComboBox.SelectedItem.ToString();
                donor.ContactNumber = DonorContactNumberTextBox.Text;
                donor.Address = DonorAdressTextBox.Text;
                donorsService.EditDonor(donor);

                DonorsForm donorsForm = (DonorsForm)Application.OpenForms["DonorsForm"];
                donorsForm.RefreshData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsFormDataValid()
        {
            bool isValid = false;
            if ((FemaleCheckBox.Checked || MaleCheckBox.Checked) && DonorFirstNameValidation.Text == "" && DonorLastNameValidation.Text == "" && BirthDateValidation.Text == "" && (DonorDonationTimeValidation.Text == " " || DonorDonationTimeValidation.Text == "") && ContactNumberValidation.Text == "" && DonorAdressValidation.Text == "")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        private async void ExitLabel_Click(object sender, EventArgs e)
        {
            for (double opacity = 1; opacity >= 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
            this.Close();
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
