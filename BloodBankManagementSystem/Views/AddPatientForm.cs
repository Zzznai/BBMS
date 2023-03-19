using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
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
    public partial class AddPatientForm : Form
    {
        BloodStockService bloodStockService;
        public AddPatientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodStockService = new BloodStockService();
        }

        private void PFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PFirstNameTextBox.Text.Length < 2)
            {
                PFirstNameValidation.Text = "Please enter a valid first name (at least 2 characters)";
            }
            else
            {
                PFirstNameValidation.Text = "";
            }
        }

        private void PLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PLastNameTextBox.Text.Length < 2)
            {
                PLastNameValidation.Text = "Please enter a valid first name (at least 2 characters)";
            }
            else
            {
                PLastNameValidation.Text = "";
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

        private void PBirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = PBirthdateTimePicker.Value;

            if (birthdate > DateTime.Now.AddHours(1))
            {
                PBirthdateValidation.Text = "Invalid date";
                return;
            }
            else
            {
                PBirthdateValidation.Text = "";
            }
            int age = this.GetDonorAge();
           
        }
        private int GetDonorAge()
        {
            DateTime birthdate = PBirthdateTimePicker.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (birthdate.Month > today.Month || (birthdate.Month == today.Month && birthdate.Day > today.Day))
            {
                age--;
            }

            return age;
        }

        private void BloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            List<string> bloodGroups = bloodStockService.GetAllBloodGroupsSortedById();
            BloodGroupComboBox.DataSource = bloodGroups;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^\+?[0-9]{1,3}[\s.-]?[0-9]{1,10}[\s.-]?[0-9]{1,10}$").Success;
        }

        private void PContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(PContactNumberTextBox.Text))
            {
                ContactNumberValidation.Text = "Please enter a valid phone number";
            }
            else
            {
                ContactNumberValidation.Text = "";
            }
        }

        private void PAdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PAdressTextBox.Text.Length < 5)
            {
                PAdressValidation.Text = "Please enter a valid address (at least 5 characters)";
            }
            else
            {
                PAdressValidation.Text = "";
            }
        }
    }
}
