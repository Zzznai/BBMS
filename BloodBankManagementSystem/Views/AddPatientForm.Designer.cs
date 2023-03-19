namespace BloodBankManagementSystem.Views
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.AddPatientLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.PFirstNameValidation = new System.Windows.Forms.Label();
            this.FirstNameValidation = new System.Windows.Forms.Label();
            this.PFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PFirstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPatientLabel
            // 
            this.AddPatientLabel.AutoSize = true;
            this.AddPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AddPatientLabel.Location = new System.Drawing.Point(167, 28);
            this.AddPatientLabel.Name = "AddPatientLabel";
            this.AddPatientLabel.Size = new System.Drawing.Size(154, 31);
            this.AddPatientLabel.TabIndex = 15;
            this.AddPatientLabel.Text = "Add Patient";
            this.AddPatientLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExitLabel.Location = new System.Drawing.Point(467, 2);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 14;
            this.ExitLabel.Text = "X";
            // 
            // PFirstNameValidation
            // 
            this.PFirstNameValidation.AutoSize = true;
            this.PFirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.PFirstNameValidation.Location = new System.Drawing.Point(144, 79);
            this.PFirstNameValidation.Name = "PFirstNameValidation";
            this.PFirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.PFirstNameValidation.TabIndex = 53;
            this.PFirstNameValidation.Text = " ";
            this.PFirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstNameValidation
            // 
            this.FirstNameValidation.AutoSize = true;
            this.FirstNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidation.Location = new System.Drawing.Point(144, 80);
            this.FirstNameValidation.Name = "FirstNameValidation";
            this.FirstNameValidation.Size = new System.Drawing.Size(10, 16);
            this.FirstNameValidation.TabIndex = 52;
            this.FirstNameValidation.Text = " ";
            this.FirstNameValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PFirstNameTextBox
            // 
            this.PFirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFirstNameTextBox.Location = new System.Drawing.Point(147, 98);
            this.PFirstNameTextBox.Name = "PFirstNameTextBox";
            this.PFirstNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.PFirstNameTextBox.TabIndex = 51;
            this.PFirstNameTextBox.TextChanged += new System.EventHandler(this.PFirstNameTextBox_TextChanged);
            // 
            // PFirstNameLabel
            // 
            this.PFirstNameLabel.AutoSize = true;
            this.PFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFirstNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PFirstNameLabel.Location = new System.Drawing.Point(12, 96);
            this.PFirstNameLabel.Name = "PFirstNameLabel";
            this.PFirstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.PFirstNameLabel.TabIndex = 50;
            this.PFirstNameLabel.Text = "First Name:";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 741);
            this.Controls.Add(this.PFirstNameValidation);
            this.Controls.Add(this.FirstNameValidation);
            this.Controls.Add(this.PFirstNameTextBox);
            this.Controls.Add(this.PFirstNameLabel);
            this.Controls.Add(this.AddPatientLabel);
            this.Controls.Add(this.ExitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPatientLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label PFirstNameValidation;
        private System.Windows.Forms.Label FirstNameValidation;
        private System.Windows.Forms.TextBox PFirstNameTextBox;
        private System.Windows.Forms.Label PFirstNameLabel;
    }
}