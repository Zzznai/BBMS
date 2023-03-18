namespace BloodBankManagementSystem.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.BloodDropImage = new System.Windows.Forms.PictureBox();
            this.UserSignInButton = new BloodBankManagementSystem.ButtonModified();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodDropImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LoginTitleLabel.Location = new System.Drawing.Point(40, 43);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(414, 31);
            this.LoginTitleLabel.TabIndex = 2;
            this.LoginTitleLabel.Text = "Blood Bank Management System";
            this.LoginTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginTitleLabel.Click += new System.EventHandler(this.LoginTitleLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Salmon;
            this.EmailLabel.Location = new System.Drawing.Point(32, 176);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(80, 29);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(108, 174);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(327, 31);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 227);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 29);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(154, 229);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(281, 31);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Red;
            this.ExitLabel.Location = new System.Drawing.Point(473, -1);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 10;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KeyPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KeyPictureBox.Image")));
            this.KeyPictureBox.Location = new System.Drawing.Point(441, 229);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(18, 27);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyPictureBox.TabIndex = 14;
            this.KeyPictureBox.TabStop = false;
            this.KeyPictureBox.Click += new System.EventHandler(this.KeyPictureBox_Click);
            // 
            // BloodDropImage
            // 
            this.BloodDropImage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BloodDropImage.Image = ((System.Drawing.Image)(resources.GetObject("BloodDropImage.Image")));
            this.BloodDropImage.Location = new System.Drawing.Point(222, 88);
            this.BloodDropImage.Name = "BloodDropImage";
            this.BloodDropImage.Size = new System.Drawing.Size(64, 70);
            this.BloodDropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BloodDropImage.TabIndex = 44;
            this.BloodDropImage.TabStop = false;
            this.BloodDropImage.UseWaitCursor = true;
            // 
            // UserSignInButton
            // 
            this.UserSignInButton.BackColor = System.Drawing.Color.Salmon;
            this.UserSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserSignInButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.UserSignInButton.FlatAppearance.BorderSize = 0;
            this.UserSignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSignInButton.ForeColor = System.Drawing.Color.White;
            this.UserSignInButton.Location = new System.Drawing.Point(144, 315);
            this.UserSignInButton.Name = "UserSignInButton";
            this.UserSignInButton.Size = new System.Drawing.Size(202, 47);
            this.UserSignInButton.TabIndex = 13;
            this.UserSignInButton.Text = "Login";
            this.UserSignInButton.UseVisualStyleBackColor = false;
            this.UserSignInButton.Click += new System.EventHandler(this.UserSignInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 420);
            this.Controls.Add(this.BloodDropImage);
            this.Controls.Add(this.KeyPictureBox);
            this.Controls.Add(this.UserSignInButton);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodDropImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ExitLabel;
        private ButtonModified UserSignInButton;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        private System.Windows.Forms.PictureBox BloodDropImage;
    }
}