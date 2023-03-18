﻿namespace BloodBankManagementSystem.Views
{
    partial class AddDonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDonorForm));
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.HasDonatedCheckBox = new System.Windows.Forms.CheckBox();
            this.LastDonationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.LastDonationTimeLabel = new System.Windows.Forms.Label();
            this.DonorContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.DonorAdressTextBox = new System.Windows.Forms.TextBox();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameValidation = new System.Windows.Forms.Label();
            this.DonorLastNameValidation = new System.Windows.Forms.Label();
            this.AddButton = new BloodBankManagementSystem.ButtonModified();
            this.GenderValidation = new System.Windows.Forms.Label();
            this.AgeValidation = new System.Windows.Forms.Label();
            this.BloodGroupValidation = new System.Windows.Forms.Label();
            this.DonationDateValidation = new System.Windows.Forms.Label();
            this.ContactNumberValidation = new System.Windows.Forms.Label();
            this.AddressValidation = new System.Windows.Forms.Label();
            this.DonorFirstNameValidation = new System.Windows.Forms.Label();
            this.DonorGenderValidation = new System.Windows.Forms.Label();
            this.BirthDateValidation = new System.Windows.Forms.Label();
            this.DonorBloodGroupValidation = new System.Windows.Forms.Label();
            this.DonorDonationTimeValidation = new System.Windows.Forms.Label();
            this.DonorNumberValidation = new System.Windows.Forms.Label();
            this.DonorAdressValidation = new System.Windows.Forms.Label();
            this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExitLabel.Location = new System.Drawing.Point(468, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 12;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AddUserLabel.Location = new System.Drawing.Point(168, 26);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(143, 31);
            this.AddUserLabel.TabIndex = 13;
            this.AddUserLabel.Text = "Add Donor";
            this.AddUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 91);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.FirstNameLabel.TabIndex = 15;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(147, 93);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.FirstNameTextBox.TabIndex = 22;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastNameLabel.Location = new System.Drawing.Point(15, 152);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(134, 29);
            this.LastNameLabel.TabIndex = 23;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(144, 154);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.Color.Salmon;
            this.GenderLabel.Location = new System.Drawing.Point(13, 216);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(100, 29);
            this.GenderLabel.TabIndex = 25;
            this.GenderLabel.Text = "Gender:";
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.FemaleCheckBox.Location = new System.Drawing.Point(119, 218);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(102, 29);
            this.FemaleCheckBox.TabIndex = 26;
            this.FemaleCheckBox.Text = "Female";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            this.FemaleCheckBox.CheckedChanged += new System.EventHandler(this.FemaleCheckBox_CheckedChanged);
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.MaleCheckBox.Location = new System.Drawing.Point(233, 218);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(78, 29);
            this.MaleCheckBox.TabIndex = 27;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            this.MaleCheckBox.CheckedChanged += new System.EventHandler(this.MaleCheckBox_CheckedChanged);
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BloodGroupLabel.Location = new System.Drawing.Point(13, 340);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(156, 29);
            this.BloodGroupLabel.TabIndex = 28;
            this.BloodGroupLabel.Text = "Blood Group:";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdateLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BirthdateLabel.Location = new System.Drawing.Point(13, 277);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(115, 29);
            this.BirthdateLabel.TabIndex = 30;
            this.BirthdateLabel.Text = "Birthdate:";
            // 
            // HasDonatedCheckBox
            // 
            this.HasDonatedCheckBox.AutoSize = true;
            this.HasDonatedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.HasDonatedCheckBox.ForeColor = System.Drawing.Color.Salmon;
            this.HasDonatedCheckBox.Location = new System.Drawing.Point(18, 400);
            this.HasDonatedCheckBox.Name = "HasDonatedCheckBox";
            this.HasDonatedCheckBox.Size = new System.Drawing.Size(425, 29);
            this.HasDonatedCheckBox.TabIndex = 32;
            this.HasDonatedCheckBox.Text = "Has the donor previously donated blood?";
            this.HasDonatedCheckBox.UseVisualStyleBackColor = true;
            this.HasDonatedCheckBox.CheckedChanged += new System.EventHandler(this.HasDonatedCheckBox_CheckedChanged);
            // 
            // LastDonationTimePicker
            // 
            this.LastDonationTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.LastDonationTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LastDonationTimePicker.Location = new System.Drawing.Point(226, 459);
            this.LastDonationTimePicker.Name = "LastDonationTimePicker";
            this.LastDonationTimePicker.Size = new System.Drawing.Size(216, 31);
            this.LastDonationTimePicker.TabIndex = 33;
            this.LastDonationTimePicker.ValueChanged += new System.EventHandler(this.LastDonationTimePicker_ValueChanged);
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ContactNumberLabel.Location = new System.Drawing.Point(13, 525);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(193, 29);
            this.ContactNumberLabel.TabIndex = 34;
            this.ContactNumberLabel.Text = "Contact Number:";
            // 
            // LastDonationTimeLabel
            // 
            this.LastDonationTimeLabel.AutoSize = true;
            this.LastDonationTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastDonationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDonationTimeLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastDonationTimeLabel.Location = new System.Drawing.Point(12, 459);
            this.LastDonationTimeLabel.Name = "LastDonationTimeLabel";
            this.LastDonationTimeLabel.Size = new System.Drawing.Size(221, 29);
            this.LastDonationTimeLabel.TabIndex = 35;
            this.LastDonationTimeLabel.Text = "Last Donation Date:";
            // 
            // DonorContactNumberTextBox
            // 
            this.DonorContactNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorContactNumberTextBox.Location = new System.Drawing.Point(203, 527);
            this.DonorContactNumberTextBox.Name = "DonorContactNumberTextBox";
            this.DonorContactNumberTextBox.Size = new System.Drawing.Size(259, 31);
            this.DonorContactNumberTextBox.TabIndex = 36;
            this.DonorContactNumberTextBox.TextChanged += new System.EventHandler(this.ContactNumberTextBox_TextChanged);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AdressLabel.Location = new System.Drawing.Point(13, 591);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(108, 29);
            this.AdressLabel.TabIndex = 37;
            this.AdressLabel.Text = "Address:";
            // 
            // DonorAdressTextBox
            // 
            this.DonorAdressTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAdressTextBox.Location = new System.Drawing.Point(119, 593);
            this.DonorAdressTextBox.Name = "DonorAdressTextBox";
            this.DonorAdressTextBox.Size = new System.Drawing.Size(343, 31);
            this.DonorAdressTextBox.TabIndex = 38;
            this.DonorAdressTextBox.TextChanged += new System.EventHandler(this.AdressTextBox_TextChanged);
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Location = new System.Drawing.Point(163, 342);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(128, 30);
            this.BloodGroupComboBox.TabIndex = 39;
            // 
            // FirstNameValidation
            // 
            this.FirstNameValidation.AutoSize = true;
            this.FirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidation.Location = new System.Drawing.Point(144, 75);
            this.FirstNameValidation.Name = "FirstNameValidation";
            this.FirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.FirstNameValidation.TabIndex = 41;
            this.FirstNameValidation.Text = " ";
            this.FirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorLastNameValidation
            // 
            this.DonorLastNameValidation.AutoSize = true;
            this.DonorLastNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorLastNameValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorLastNameValidation.Location = new System.Drawing.Point(144, 136);
            this.DonorLastNameValidation.Name = "DonorLastNameValidation";
            this.DonorLastNameValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorLastNameValidation.TabIndex = 42;
            this.DonorLastNameValidation.Text = " ";
            this.DonorLastNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorLastNameValidation.Click += new System.EventHandler(this.DonorLastNameValidation_Click);
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
            this.AddButton.Location = new System.Drawing.Point(174, 670);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 39);
            this.AddButton.TabIndex = 40;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GenderValidation
            // 
            this.GenderValidation.AutoSize = true;
            this.GenderValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderValidation.ForeColor = System.Drawing.Color.Red;
            this.GenderValidation.Location = new System.Drawing.Point(111, 200);
            this.GenderValidation.Name = "GenderValidation";
            this.GenderValidation.Size = new System.Drawing.Size(10, 16);
            this.GenderValidation.TabIndex = 43;
            this.GenderValidation.Text = " ";
            this.GenderValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgeValidation
            // 
            this.AgeValidation.AutoSize = true;
            this.AgeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeValidation.ForeColor = System.Drawing.Color.Red;
            this.AgeValidation.Location = new System.Drawing.Point(125, 258);
            this.AgeValidation.Name = "AgeValidation";
            this.AgeValidation.Size = new System.Drawing.Size(10, 16);
            this.AgeValidation.TabIndex = 44;
            this.AgeValidation.Text = " ";
            this.AgeValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BloodGroupValidation
            // 
            this.BloodGroupValidation.AutoSize = true;
            this.BloodGroupValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupValidation.ForeColor = System.Drawing.Color.Red;
            this.BloodGroupValidation.Location = new System.Drawing.Point(160, 324);
            this.BloodGroupValidation.Name = "BloodGroupValidation";
            this.BloodGroupValidation.Size = new System.Drawing.Size(10, 16);
            this.BloodGroupValidation.TabIndex = 45;
            this.BloodGroupValidation.Text = " ";
            this.BloodGroupValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonationDateValidation
            // 
            this.DonationDateValidation.AutoSize = true;
            this.DonationDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationDateValidation.ForeColor = System.Drawing.Color.Red;
            this.DonationDateValidation.Location = new System.Drawing.Point(223, 443);
            this.DonationDateValidation.Name = "DonationDateValidation";
            this.DonationDateValidation.Size = new System.Drawing.Size(10, 16);
            this.DonationDateValidation.TabIndex = 46;
            this.DonationDateValidation.Text = " ";
            this.DonationDateValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContactNumberValidation
            // 
            this.ContactNumberValidation.AutoSize = true;
            this.ContactNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.ContactNumberValidation.Location = new System.Drawing.Point(200, 509);
            this.ContactNumberValidation.Name = "ContactNumberValidation";
            this.ContactNumberValidation.Size = new System.Drawing.Size(10, 16);
            this.ContactNumberValidation.TabIndex = 47;
            this.ContactNumberValidation.Text = " ";
            this.ContactNumberValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddressValidation
            // 
            this.AddressValidation.AutoSize = true;
            this.AddressValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressValidation.ForeColor = System.Drawing.Color.Red;
            this.AddressValidation.Location = new System.Drawing.Point(116, 575);
            this.AddressValidation.Name = "AddressValidation";
            this.AddressValidation.Size = new System.Drawing.Size(10, 16);
            this.AddressValidation.TabIndex = 48;
            this.AddressValidation.Text = " ";
            this.AddressValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonorFirstNameValidation
            // 
            this.DonorFirstNameValidation.AutoSize = true;
            this.DonorFirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorFirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorFirstNameValidation.Location = new System.Drawing.Point(144, 74);
            this.DonorFirstNameValidation.Name = "DonorFirstNameValidation";
            this.DonorFirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorFirstNameValidation.TabIndex = 49;
            this.DonorFirstNameValidation.Text = " ";
            this.DonorFirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorFirstNameValidation.Click += new System.EventHandler(this.DonorFirstNameValidation_Click);
            // 
            // DonorGenderValidation
            // 
            this.DonorGenderValidation.AutoSize = true;
            this.DonorGenderValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorGenderValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorGenderValidation.Location = new System.Drawing.Point(317, 226);
            this.DonorGenderValidation.Name = "DonorGenderValidation";
            this.DonorGenderValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorGenderValidation.TabIndex = 50;
            this.DonorGenderValidation.Text = " ";
            this.DonorGenderValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorGenderValidation.Click += new System.EventHandler(this.DonorGenderValidation_Click);
            // 
            // BirthDateValidation
            // 
            this.BirthDateValidation.AutoSize = true;
            this.BirthDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateValidation.ForeColor = System.Drawing.Color.Red;
            this.BirthDateValidation.Location = new System.Drawing.Point(125, 258);
            this.BirthDateValidation.Name = "BirthDateValidation";
            this.BirthDateValidation.Size = new System.Drawing.Size(10, 16);
            this.BirthDateValidation.TabIndex = 51;
            this.BirthDateValidation.Text = " ";
            this.BirthDateValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BirthDateValidation.Click += new System.EventHandler(this.DonorAgeValidation_Click);
            // 
            // DonorBloodGroupValidation
            // 
            this.DonorBloodGroupValidation.AutoSize = true;
            this.DonorBloodGroupValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorBloodGroupValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorBloodGroupValidation.Location = new System.Drawing.Point(159, 324);
            this.DonorBloodGroupValidation.Name = "DonorBloodGroupValidation";
            this.DonorBloodGroupValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorBloodGroupValidation.TabIndex = 52;
            this.DonorBloodGroupValidation.Text = " ";
            this.DonorBloodGroupValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorBloodGroupValidation.Click += new System.EventHandler(this.DonorBloodGroupValidation_Click);
            // 
            // DonorDonationTimeValidation
            // 
            this.DonorDonationTimeValidation.AutoSize = true;
            this.DonorDonationTimeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorDonationTimeValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorDonationTimeValidation.Location = new System.Drawing.Point(223, 443);
            this.DonorDonationTimeValidation.Name = "DonorDonationTimeValidation";
            this.DonorDonationTimeValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorDonationTimeValidation.TabIndex = 53;
            this.DonorDonationTimeValidation.Text = " ";
            this.DonorDonationTimeValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorDonationTimeValidation.Click += new System.EventHandler(this.DonorDonationTimeValidation_Click);
            // 
            // DonorNumberValidation
            // 
            this.DonorNumberValidation.AutoSize = true;
            this.DonorNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorNumberValidation.Location = new System.Drawing.Point(200, 509);
            this.DonorNumberValidation.Name = "DonorNumberValidation";
            this.DonorNumberValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorNumberValidation.TabIndex = 54;
            this.DonorNumberValidation.Text = " ";
            this.DonorNumberValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorNumberValidation.Click += new System.EventHandler(this.DonorNumberValidation_Click);
            // 
            // DonorAdressValidation
            // 
            this.DonorAdressValidation.AutoSize = true;
            this.DonorAdressValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAdressValidation.ForeColor = System.Drawing.Color.Red;
            this.DonorAdressValidation.Location = new System.Drawing.Point(116, 574);
            this.DonorAdressValidation.Name = "DonorAdressValidation";
            this.DonorAdressValidation.Size = new System.Drawing.Size(10, 16);
            this.DonorAdressValidation.TabIndex = 55;
            this.DonorAdressValidation.Text = " ";
            this.DonorAdressValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DonorAdressValidation.Click += new System.EventHandler(this.DonorAdressValidation_Click);
            // 
            // BirthdateTimePicker
            // 
            this.BirthdateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.BirthdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BirthdateTimePicker.Location = new System.Drawing.Point(128, 277);
            this.BirthdateTimePicker.Name = "BirthdateTimePicker";
            this.BirthdateTimePicker.Size = new System.Drawing.Size(216, 31);
            this.BirthdateTimePicker.TabIndex = 56;
            this.BirthdateTimePicker.ValueChanged += new System.EventHandler(this.BirthdateTimePicker_ValueChanged);
            // 
            // AddDonorForm
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
            this.Controls.Add(this.DonorBloodGroupValidation);
            this.Controls.Add(this.DonorGenderValidation);
            this.Controls.Add(this.DonorFirstNameValidation);
            this.Controls.Add(this.AddressValidation);
            this.Controls.Add(this.ContactNumberValidation);
            this.Controls.Add(this.DonationDateValidation);
            this.Controls.Add(this.BloodGroupValidation);
            this.Controls.Add(this.AgeValidation);
            this.Controls.Add(this.GenderValidation);
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
            this.Name = "AddDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDonor";
            this.Load += new System.EventHandler(this.AddDonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.CheckBox HasDonatedCheckBox;
        private System.Windows.Forms.DateTimePicker LastDonationTimePicker;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.Label LastDonationTimeLabel;
        private System.Windows.Forms.TextBox DonorContactNumberTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox DonorAdressTextBox;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private ButtonModified AddButton;
        private System.Windows.Forms.Label FirstNameValidation;
        private System.Windows.Forms.Label DonorLastNameValidation;
        private System.Windows.Forms.Label GenderValidation;
        private System.Windows.Forms.Label AgeValidation;
        private System.Windows.Forms.Label BloodGroupValidation;
        private System.Windows.Forms.Label DonationDateValidation;
        private System.Windows.Forms.Label ContactNumberValidation;
        private System.Windows.Forms.Label AddressValidation;
        private System.Windows.Forms.Label DonorFirstNameValidation;
        private System.Windows.Forms.Label DonorGenderValidation;
        private System.Windows.Forms.Label BirthDateValidation;
        private System.Windows.Forms.Label DonorBloodGroupValidation;
        private System.Windows.Forms.Label DonorDonationTimeValidation;
        private System.Windows.Forms.Label DonorNumberValidation;
        private System.Windows.Forms.Label DonorAdressValidation;
        private System.Windows.Forms.DateTimePicker BirthdateTimePicker;
    }
}