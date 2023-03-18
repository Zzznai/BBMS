namespace BloodBankManagementSystem.Views
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EditUserLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.EditButton = new BloodBankManagementSystem.ButtonModified();
            this.FirstNameValidation = new System.Windows.Forms.Label();
            this.LastNameValidation = new System.Windows.Forms.Label();
            this.EmailValidation = new System.Windows.Forms.Label();
            this.PasswordValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(150, 100);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(305, 31);
            this.FirstNameTextBox.TabIndex = 32;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(150, 165);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(305, 31);
            this.LastNameTextBox.TabIndex = 31;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(141, 300);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(314, 31);
            this.PasswordTextBox.TabIndex = 30;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(95, 234);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(360, 31);
            this.EmailTextBox.TabIndex = 29;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PasswordLabel.Location = new System.Drawing.Point(20, 300);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 29);
            this.PasswordLabel.TabIndex = 27;
            this.PasswordLabel.Text = "Password:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LastNameLabel.Location = new System.Drawing.Point(20, 163);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(134, 29);
            this.LastNameLabel.TabIndex = 26;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.FirstNameLabel.Location = new System.Drawing.Point(20, 98);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.FirstNameLabel.TabIndex = 25;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Salmon;
            this.EmailLabel.Location = new System.Drawing.Point(20, 232);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(80, 29);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "Email:";
            // 
            // EditUserLabel
            // 
            this.EditUserLabel.AutoSize = true;
            this.EditUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserLabel.ForeColor = System.Drawing.Color.Salmon;
            this.EditUserLabel.Location = new System.Drawing.Point(180, 24);
            this.EditUserLabel.Name = "EditUserLabel";
            this.EditUserLabel.Size = new System.Drawing.Size(126, 31);
            this.EditUserLabel.TabIndex = 23;
            this.EditUserLabel.Text = "Edit User";
            this.EditUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExitLabel.Location = new System.Drawing.Point(472, -1);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 22;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Salmon;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(141, 383);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(202, 47);
            this.EditButton.TabIndex = 28;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FirstNameValidation
            // 
            this.FirstNameValidation.AutoSize = true;
            this.FirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidation.Location = new System.Drawing.Point(147, 81);
            this.FirstNameValidation.Name = "FirstNameValidation";
            this.FirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.FirstNameValidation.TabIndex = 33;
            this.FirstNameValidation.Text = " ";
            this.FirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastNameValidation
            // 
            this.LastNameValidation.AutoSize = true;
            this.LastNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValidation.ForeColor = System.Drawing.Color.Red;
            this.LastNameValidation.Location = new System.Drawing.Point(147, 147);
            this.LastNameValidation.Name = "LastNameValidation";
            this.LastNameValidation.Size = new System.Drawing.Size(10, 16);
            this.LastNameValidation.TabIndex = 34;
            this.LastNameValidation.Text = " ";
            this.LastNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailValidation
            // 
            this.EmailValidation.AutoSize = true;
            this.EmailValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValidation.ForeColor = System.Drawing.Color.Red;
            this.EmailValidation.Location = new System.Drawing.Point(92, 215);
            this.EmailValidation.Name = "EmailValidation";
            this.EmailValidation.Size = new System.Drawing.Size(10, 16);
            this.EmailValidation.TabIndex = 35;
            this.EmailValidation.Text = " ";
            this.EmailValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordValidation
            // 
            this.PasswordValidation.AutoSize = true;
            this.PasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.PasswordValidation.Location = new System.Drawing.Point(138, 284);
            this.PasswordValidation.Name = "PasswordValidation";
            this.PasswordValidation.Size = new System.Drawing.Size(10, 16);
            this.PasswordValidation.TabIndex = 36;
            this.PasswordValidation.Text = " ";
            this.PasswordValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditUserForm
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
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EditUserLabel);
            this.Controls.Add(this.ExitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private ButtonModified EditButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label EditUserLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label FirstNameValidation;
        private System.Windows.Forms.Label LastNameValidation;
        private System.Windows.Forms.Label EmailValidation;
        private System.Windows.Forms.Label PasswordValidation;
    }
}