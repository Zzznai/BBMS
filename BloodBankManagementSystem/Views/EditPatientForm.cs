using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Views
{
    /// <summary>
    /// Form for editing a patient
    /// </summary>
    public partial class EditPatientForm : Form
    {
        private int id;
        private BloodStockService bloodStockService;
        private PatientsService patientsService;
        public EditPatientForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.bloodStockService = new BloodStockService();
            this.patientsService = new PatientsService();
            this.id = id;
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

        private void AditButton_Click(object sender, EventArgs e)
        {
            bool isValid = IsFormDataValid();
            Patient patient = this.patientsService.GetPatientById(id);
            if (isValid)
            {
                patient.PatientFirstName = PFirstNameTextBox.Text;
                patient.PatientLastName = PLastNameTextBox.Text;
                if (FemaleCheckBox.Checked)
                {
                    patient.PatientGender = GlobalConstants.Female;
                }
                else
                if (MaleCheckBox.Checked)
                {
                    patient.PatientGender = GlobalConstants.Male;
                }
                patient.PatientAge = this.GetDonorAge();
                patient.PatientBirthDate = PBirthdateTimePicker.Value;
                if (!patient.BloodGroup.Equals(BloodGroupComboBox.SelectedItem.ToString()))
                {
                    MessageBox.Show("The change of the blood group will result in Inconstancy in the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                patient.BloodGroup = BloodGroupComboBox.SelectedItem.ToString();
                patient.ContactNumber = PContactNumberTextBox.Text;
                patient.Address = PAdressTextBox.Text;

                DialogResult result = MessageBox.Show($"Are you sure you want to edit the patient {patient.PatientFirstName} {patient.PatientLastName}?",
                                                  "Confirm Edit Patient",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    patientsService.EditPatient(patient);
                    PatientsForm patientsForm = (PatientsForm)Application.OpenForms["PatientsForm"];
                    patientsForm.RefreshData();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void EditPatientForm_Load(object sender, EventArgs e)
        {
            List<string> bloodGroups = bloodStockService.GetAllBloodGroupsSortedById();
            BloodGroupComboBox.DataSource = bloodGroups;
            Patient patient = patientsService.GetPatientById(id);

            if (patient == null)
            {
                MessageBox.Show("This patient doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.PFirstNameTextBox.Text = patient.PatientFirstName;
            this.PLastNameTextBox.Text = patient.PatientLastName;
            this.FemaleCheckBox.Checked = patient.PatientGender.Equals(GlobalConstants.Female);
            this.MaleCheckBox.Checked = patient.PatientGender.Equals(GlobalConstants.Male);
            this.PBirthdateTimePicker.Value = patient.PatientBirthDate.Value;
            this.BloodGroupComboBox.SelectedItem = patient.BloodGroup;
            this.PContactNumberTextBox.Text = patient.ContactNumber;
            this.PAdressTextBox.Text = patient.Address;
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
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

            if (birthdate > DateTime.Now.AddHours(1) || birthdate.Year < 1900)
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
        private bool IsFormDataValid()
        {
            bool isValid = false;
            if ((FemaleCheckBox.Checked || MaleCheckBox.Checked) && PFirstNameValidation.Text == "" && PLastNameValidation.Text == "" && PBirthdateValidation.Text == "" && ContactNumberValidation.Text == "" && PAdressValidation.Text == "")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
