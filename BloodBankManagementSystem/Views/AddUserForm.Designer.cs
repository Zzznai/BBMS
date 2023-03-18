namespace BloodBankManagementSystem.Views
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameValidation = new System.Windows.Forms.Label();
            this.LastNameValidation = new System.Windows.Forms.Label();
            this.EmailValidation = new System.Windows.Forms.Label();
            this.PasswordValidation = new System.Windows.Forms.Label();
            this.AddButton = new BloodBankManagementSystem.ButtonModified();
            this.SuspendLayout();
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExitLabel.Location = new System.Drawing.Point(474, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 11;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AddUserLabel.Location = new System.Drawing.Point(176, 29);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(127, 31);
            this.AddUserLabel.TabIndex = 12;
            this.AddUserLabel.Text = "Add User";
            this.AddUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Salmon;
            this.EmailLabel.Location = new System.Drawing.Point(22, 233);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(80, 29);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.FirstNameLabel.Location = new System.Drawing.Point(22, 99);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastNameLabel.Location = new System.Drawing.Point(22, 164);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(134, 29);
            this.LastNameLabel.TabIndex = 15;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PasswordLabel.Location = new System.Drawing.Point(22, 301);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 29);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(97, 235);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(360, 31);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(143, 301);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(314, 31);
            this.PasswordTextBox.TabIndex = 19;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(152, 166);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(305, 31);
            this.LastNameTextBox.TabIndex = 20;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(152, 101);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(305, 31);
            this.FirstNameTextBox.TabIndex = 21;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameValidation
            // 
            this.FirstNameValidation.AutoSize = true;
            this.FirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidation.Location = new System.Drawing.Point(149, 82);
            this.FirstNameValidation.Name = "FirstNameValidation";
            this.FirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.FirstNameValidation.TabIndex = 22;
            this.FirstNameValidation.Text = " ";
            this.FirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastNameValidation
            // 
            this.LastNameValidation.AutoSize = true;
            this.LastNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValidation.ForeColor = System.Drawing.Color.Red;
            this.LastNameValidation.Location = new System.Drawing.Point(149, 148);
            this.LastNameValidation.Name = "LastNameValidation";
            this.LastNameValidation.Size = new System.Drawing.Size(10, 16);
            this.LastNameValidation.TabIndex = 23;
            this.LastNameValidation.Text = " ";
            this.LastNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailValidation
            // 
            this.EmailValidation.AutoSize = true;
            this.EmailValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValidation.ForeColor = System.Drawing.Color.Red;
            this.EmailValidation.Location = new System.Drawing.Point(94, 216);
            this.EmailValidation.Name = "EmailValidation";
            this.EmailValidation.Size = new System.Drawing.Size(10, 16);
            this.EmailValidation.TabIndex = 24;
            this.EmailValidation.Text = " ";
            this.EmailValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordValidation
            // 
            this.PasswordValidation.AutoSize = true;
            this.PasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.PasswordValidation.Location = new System.Drawing.Point(140, 285);
            this.PasswordValidation.Name = "PasswordValidation";
            this.PasswordValidation.Size = new System.Drawing.Size(10, 16);
            this.PasswordValidation.TabIndex = 25;
            this.PasswordValidation.Text = " ";
            this.PasswordValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.AddButton.Location = new System.Drawing.Point(143, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(202, 47);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 479);
            this.Controls.Add(this.PasswordValidation);
            this.Controls.Add(this.EmailValidation);
            this.Controls.Add(this.LastNameValidation);
            this.Controls.Add(this.FirstNameValidation);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.ExitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private ButtonModified AddButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameValidation;
        private System.Windows.Forms.Label LastNameValidation;
        private System.Windows.Forms.Label EmailValidation;
        private System.Windows.Forms.Label PasswordValidation;
    }
}