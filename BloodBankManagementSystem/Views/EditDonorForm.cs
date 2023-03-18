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
    }
}
