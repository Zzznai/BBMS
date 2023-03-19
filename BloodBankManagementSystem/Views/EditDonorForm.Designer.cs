namespace BloodBankManagementSystem.Views
{
    partial class EditDonorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDonorForm));
            this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateValidation = new System.Windows.Forms.Label();
            this.DonorNumberValidation = new System.Windows.Forms.Label();
            this.DonorAdressValidation = new System.Windows.Forms.Label();
            this.DonorDonationTimeValidation = new System.Windows.Forms.Label();
            this.DonorFirstNameValidation = new System.Windows.Forms.Label();
            this.AddressValidation = new System.Windows.Forms.Label();
            this.ContactNumberValidation = new System.Windows.Forms.Label();
            this.DonationDateValidation = new System.Windows.Forms.Label();
            this.AgeValidation = new System.Windows.Forms.Label();
            this.DonorLastNameValidation = new System.Windows.Forms.Label();
            this.FirstNameValidation = new System.Windows.Forms.Label();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.DonorAdressTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.DonorContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.LastDonationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastDonationTimeLabel = new System.Windows.Forms.Label();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.HasDonatedCheckBox = new System.Windows.Forms.CheckBox();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AddButton = new BloodBankManagementSystem.ButtonModified();
            this.SuspendLayout();
            // 
            // BirthdateTimePicker
            // 
            this.BirthdateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.BirthdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BirthdateTimePicker.Location = new System.Drawing.Point(128, 278);
            this.BirthdateTimePicker.Name = "BirthdateTimePicker";
            this.BirthdateTimePicker.Size = new System.Drawing.Size(216, 31);
            this.BirthdateTimePicker.TabIndex = 88;
            this.BirthdateTimePicker.ValueChanged += new System.EventHandler(this.BirthdateTimePicker_ValueChanged);
            // 
            // BirthDateValidation
            // 
            this.BirthDateValidation.AutoSize = true;
            this.BirthDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateValidation.ForeColor = System.Drawing.Color.Red;
            this.BirthDateValidation.Location = new System.Drawing.Point(125, 259);
            this.BirthDateValidation.Name = "BirthDateValidation";
            this.BirthDateValidation.Size = new System.Drawing.Size(10, 16);
            this.BirthDateValidation.TabIndex = 84;
            this.BirthDateValidation.Text = " ";
            this.BirthDateValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorNumberValidation
            // 
            this.DonorNumberValidation.AutoSize = true;
            this.DonorNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorNumberValidation.Location = new System.Drawing.Point(200, 510);
            this.DonorNumberValidation.Name = "DonorNumberValidation";
            this.DonorNumberValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorNumberValidation.TabIndex = 86;
            this.DonorNumberValidation.Text = " ";
            this.DonorNumberValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorAdressValidation
            // 
            this.DonorAdressValidation.AutoSize = true;
            this.DonorAdressValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAdressValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorAdressValidation.Location = new System.Drawing.Point(116, 575);
            this.DonorAdressValidation.Name = "DonorAdressValidation";
            this.DonorAdressValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorAdressValidation.TabIndex = 87;
            this.DonorAdressValidation.Text = " ";
            this.DonorAdressValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorDonationTimeValidation
            // 
            this.DonorDonationTimeValidation.AutoSize = true;
            this.DonorDonationTimeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorDonationTimeValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorDonationTimeValidation.Location = new System.Drawing.Point(223, 444);
            this.DonorDonationTimeValidation.Name = "DonorDonationTimeValidation";
            this.DonorDonationTimeValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorDonationTimeValidation.TabIndex = 85;
            this.DonorDonationTimeValidation.Text = " ";
            this.DonorDonationTimeValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorFirstNameValidation
            // 
            this.DonorFirstNameValidation.AutoSize = true;
            this.DonorFirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorFirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorFirstNameValidation.Location = new System.Drawing.Point(144, 75);
            this.DonorFirstNameValidation.Name = "DonorFirstNameValidation";
            this.DonorFirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorFirstNameValidation.TabIndex = 83;
            this.DonorFirstNameValidation.Text = " ";
            this.DonorFirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddressValidation
            // 
            this.AddressValidation.AutoSize = true;
            this.AddressValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressValidation.ForeColor = System.Drawing.Color.Red;
            this.AddressValidation.Location = new System.Drawing.Point(116, 576);
            this.AddressValidation.Name = "AddressValidation";
            this.AddressValidation.Size = new System.Drawing.Size(10, 16);
            this.AddressValidation.TabIndex = 82;
            this.AddressValidation.Text = " ";
            this.AddressValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContactNumberValidation
            // 
            this.ContactNumberValidation.AutoSize = true;
            this.ContactNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.ContactNumberValidation.Location = new System.Drawing.Point(200, 510);
            this.ContactNumberValidation.Name = "ContactNumberValidation";
            this.ContactNumberValidation.Size = new System.Drawing.Size(10, 16);
            this.ContactNumberValidation.TabIndex = 81;
            this.ContactNumberValidation.Text = " ";
            this.ContactNumberValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonationDateValidation
            // 
            this.DonationDateValidation.AutoSize = true;
            this.DonationDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationDateValidation.ForeColor = System.Drawing.Color.Red;
            this.DonationDateValidation.Location = new System.Drawing.Point(223, 444);
            this.DonationDateValidation.Name = "DonationDateValidation";
            this.DonationDateValidation.Size = new System.Drawing.Size(10, 16);
            this.DonationDateValidation.TabIndex = 80;
            this.DonationDateValidation.Text = " ";
            this.DonationDateValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgeValidation
            // 
            this.AgeValidation.AutoSize = true;
            this.AgeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeValidation.ForeColor = System.Drawing.Color.Red;
            this.AgeValidation.Location = new System.Drawing.Point(125, 259);
            this.AgeValidation.Name = "AgeValidation";
            this.AgeValidation.Size = new System.Drawing.Size(10, 16);
            this.AgeValidation.TabIndex = 79;
            this.AgeValidation.Text = " ";
            this.AgeValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorLastNameValidation
            // 
            this.DonorLastNameValidation.AutoSize = true;
            this.DonorLastNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorLastNameValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorLastNameValidation.Location = new System.Drawing.Point(144, 137);
            this.DonorLastNameValidation.Name = "DonorLastNameValidation";
            this.DonorLastNameValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorLastNameValidation.TabIndex = 78;
            this.DonorLastNameValidation.Text = " ";
            this.DonorLastNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstNameValidation
            // 
            this.FirstNameValidation.AutoSize = true;
            this.FirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidation.Location = new System.Drawing.Point(144, 76);
            this.FirstNameValidation.Name = "FirstNameValidation";
            this.FirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.FirstNameValidation.TabIndex = 77;
            this.FirstNameValidation.Text = " ";
            this.FirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Location = new System.Drawing.Point(163, 343);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(128, 30);
            this.BloodGroupComboBox.TabIndex = 75;
            this.BloodGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.BloodGroupComboBox_SelectedIndexChanged);
            // 
            // DonorAdressTextBox
            // 
            this.DonorAdressTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAdressTextBox.Location = new System.Drawing.Point(119, 594);
            this.DonorAdressTextBox.Name = "DonorAdressTextBox";
            this.DonorAdressTextBox.Size = new System.Drawing.Size(343, 31);
            this.DonorAdressTextBox.TabIndex = 74;
            this.DonorAdressTextBox.TextChanged += new System.EventHandler(this.DonorAdressTextBox_TextChanged);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AdressLabel.Location = new System.Drawing.Point(13, 592);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(108, 29);
            this.AdressLabel.TabIndex = 73;
            this.AdressLabel.Text = "Address:";
            // 
            // DonorContactNumberTextBox
            // 
            this.DonorContactNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorContactNumberTextBox.Location = new System.Drawing.Point(203, 528);
            this.DonorContactNumberTextBox.Name = "DonorContactNumberTextBox";
            this.DonorContactNumberTextBox.Size = new System.Drawing.Size(259, 31);
            this.DonorContactNumberTextBox.TabIndex = 72;
            this.DonorContactNumberTextBox.TextChanged += new System.EventHandler(this.DonorContactNumberTextBox_TextChanged);
            // 
            // LastDonationTimePicker
            // 
            this.LastDonationTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.LastDonationTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LastDonationTimePicker.Location = new System.Drawing.Point(226, 460);
            this.LastDonationTimePicker.Name = "LastDonationTimePicker";
            this.LastDonationTimePicker.Size = new System.Drawing.Size(216, 31);
            this.LastDonationTimePicker.TabIndex = 69;
            this.LastDonationTimePicker.ValueChanged += new System.EventHandler(this.LastDonationTimePicker_ValueChanged);
            // 
            // LastDonationTimeLabel
            // 
            this.LastDonationTimeLabel.AutoSize = true;
            this.LastDonationTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastDonationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDonationTimeLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastDonationTimeLabel.Location = new System.Drawing.Point(12, 460);
            this.LastDonationTimeLabel.Name = "LastDonationTimeLabel";
            this.LastDonationTimeLabel.Size = new System.Drawing.Size(221, 29);
            this.LastDonationTimeLabel.TabIndex = 71;
            this.LastDonationTimeLabel.Text = "Last Donation Date:";
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ContactNumberLabel.Location = new System.Drawing.Point(13, 526);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(193, 29);
            this.ContactNumberLabel.TabIndex = 70;
            this.ContactNumberLabel.Text = "Contact Number:";
            // 
            // HasDonatedCheckBox
            // 
            this.HasDonatedCheckBox.AutoSize = true;
            this.HasDonatedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.HasDonatedCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.HasDonatedCheckBox.Location = new System.Drawing.Point(18, 401);
            this.HasDonatedCheckBox.Name = "HasDonatedCheckBox";
            this.HasDonatedCheckBox.Size = new System.Drawing.Size(425, 29);
            this.HasDonatedCheckBox.TabIndex = 68;
            this.HasDonatedCheckBox.Text = "Has the donor previously donated blood?";
            this.HasDonatedCheckBox.UseVisualStyleBackColor = true;
            this.HasDonatedCheckBox.CheckedChanged += new System.EventHandler(this.HasDonatedCheckBox_CheckedChanged);
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdateLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BirthdateLabel.Location = new System.Drawing.Point(13, 278);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(115, 29);
            this.BirthdateLabel.TabIndex = 67;
            this.BirthdateLabel.Text = "Birthdate:";
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BloodGroupLabel.Location = new System.Drawing.Point(13, 341);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(156, 29);
            this.BloodGroupLabel.TabIndex = 66;
            this.BloodGroupLabel.Text = "Blood Group:";
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.MaleCheckBox.Location = new System.Drawing.Point(233, 219);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(78, 29);
            this.MaleCheckBox.TabIndex = 65;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            this.MaleCheckBox.CheckedChanged += new System.EventHandler(this.MaleCheckBox_CheckedChanged);
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.FemaleCheckBox.Location = new System.Drawing.Point(119, 219);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(102, 29);
            this.FemaleCheckBox.TabIndex = 64;
            this.FemaleCheckBox.Text = "Female";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            this.FemaleCheckBox.CheckedChanged += new System.EventHandler(this.FemaleCheckBox_CheckedChanged);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.Color.Salmon;
            this.GenderLabel.Location = new System.Drawing.Point(13, 217);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(100, 29);
            this.GenderLabel.TabIndex = 63;
            this.GenderLabel.Text = "Gender:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(144, 155);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.LastNameTextBox.TabIndex = 62;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastNameLabel.Location = new System.Drawing.Point(15, 153);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(134, 29);
            this.LastNameLabel.TabIndex = 61;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(147, 94);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.FirstNameTextBox.TabIndex = 60;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 92);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.FirstNameLabel.TabIndex = 59;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AddUserLabel.Location = new System.Drawing.Point(168, 27);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(142, 31);
            this.AddUserLabel.TabIndex = 58;
            this.AddUserLabel.Text = "Edit Donor";
            this.AddUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExitLabel.Location = new System.Drawing.Point(468, 1);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 57;
            this.ExitLabel.Text = "X";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Salmon;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(174, 671);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 39);
            this.AddButton.TabIndex = 76;
            this.AddButton.Text = "Edit";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // EditDonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 741);
            this.Controls.Add(this.BirthdateTimePicker);
            this.Controls.Add(this.BirthDateValidation);
            this.Controls.Add(this.DonorNumberValidation);
            this.Controls.Add(this.DonorAdressValidation);
            this.Controls.Add(this.DonorDonationTimeValidation);
            this.Controls.Add(this.DonorFirstNameValidation);
            this.Controls.Add(this.AddressValidation);
            this.Controls.Add(this.ContactNumberValidation);
            this.Controls.Add(this.DonationDateValidation);
            this.Controls.Add(this.AgeValidation);
            this.Controls.Add(this.DonorLastNameValidation);
            this.Controls.Add(this.FirstNameValidation);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BloodGroupComboBox);
            this.Controls.Add(this.DonorAdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.DonorContactNumberTextBox);
            this.Controls.Add(this.LastDonationTimePicker);
            this.Controls.Add(this.LastDonationTimeLabel);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.HasDonatedCheckBox);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.BloodGroupLabel);
            this.Controls.Add(this.MaleCheckBox);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.ExitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.EditDonorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdateTimePicker;
        private System.Windows.Forms.Label BirthDateValidation;
        private System.Windows.Forms.Label DonorNumberValidation;
        private System.Windows.Forms.Label DonorAdressValidation;
        private System.Windows.Forms.Label DonorDonationTimeValidation;
        private System.Windows.Forms.Label DonorFirstNameValidation;
        private System.Windows.Forms.Label AddressValidation;
        private System.Windows.Forms.Label ContactNumberValidation;
        private System.Windows.Forms.Label DonationDateValidation;
        private System.Windows.Forms.Label AgeValidation;
        private System.Windows.Forms.Label DonorLastNameValidation;
        private System.Windows.Forms.Label FirstNameValidation;
        private ButtonModified AddButton;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.TextBox DonorAdressTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox DonorContactNumberTextBox;
        private System.Windows.Forms.DateTimePicker LastDonationTimePicker;
        private System.Windows.Forms.Label LastDonationTimeLabel;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.CheckBox HasDonatedCheckBox;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Label ExitLabel;
    }
}