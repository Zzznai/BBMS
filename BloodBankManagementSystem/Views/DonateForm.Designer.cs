namespace BloodBankManagementSystem.Views
{
    partial class DonateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonateForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DonationsRecordsLabel = new System.Windows.Forms.Label();
            this.PointerPanel = new System.Windows.Forms.Panel();
            this.RecordsLabel = new System.Windows.Forms.Label();
            this.TransferLabel = new System.Windows.Forms.Label();
            this.ManagePatientsLabel = new System.Windows.Forms.Label();
            this.DonateLabel = new System.Windows.Forms.Label();
            this.ManageDonorsLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.DonationVolumeLabel = new System.Windows.Forms.Label();
            this.DonationVolumeTextBox = new System.Windows.Forms.TextBox();
            this.SearchDonorsLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new BloodBankManagementSystem.ButtonModified();
            this.DonorsGrid = new BloodBankManagementSystem.MyDataGridView();
            this.HeaderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HeaderPanel.Controls.Add(this.ExitLabel);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1212, 49);
            this.HeaderPanel.TabIndex = 28;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(1188, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 44;
            this.ExitLabel.Text = "X";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(527, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(414, 31);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Blood Bank Management System";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Silver;
            this.MenuPanel.Controls.Add(this.DonationsRecordsLabel);
            this.MenuPanel.Controls.Add(this.PointerPanel);
            this.MenuPanel.Controls.Add(this.RecordsLabel);
            this.MenuPanel.Controls.Add(this.TransferLabel);
            this.MenuPanel.Controls.Add(this.ManagePatientsLabel);
            this.MenuPanel.Controls.Add(this.DonateLabel);
            this.MenuPanel.Controls.Add(this.ManageDonorsLabel);
            this.MenuPanel.Controls.Add(this.LogOutLabel);
            this.MenuPanel.Controls.Add(this.DashboardLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 49);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 639);
            this.MenuPanel.TabIndex = 43;
            // 
            // DonationsRecordsLabel
            // 
            this.DonationsRecordsLabel.AutoSize = true;
            this.DonationsRecordsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonationsRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationsRecordsLabel.ForeColor = System.Drawing.Color.White;
            this.DonationsRecordsLabel.Location = new System.Drawing.Point(28, 161);
            this.DonationsRecordsLabel.Name = "DonationsRecordsLabel";
            this.DonationsRecordsLabel.Size = new System.Drawing.Size(176, 25);
            this.DonationsRecordsLabel.TabIndex = 60;
            this.DonationsRecordsLabel.Text = "Donation records";
            // 
            // PointerPanel
            // 
            this.PointerPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.PointerPanel.Location = new System.Drawing.Point(12, 122);
            this.PointerPanel.Name = "PointerPanel";
            this.PointerPanel.Size = new System.Drawing.Size(10, 25);
            this.PointerPanel.TabIndex = 59;
            // 
            // RecordsLabel
            // 
            this.RecordsLabel.AutoSize = true;
            this.RecordsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsLabel.ForeColor = System.Drawing.Color.White;
            this.RecordsLabel.Location = new System.Drawing.Point(28, 288);
            this.RecordsLabel.Name = "RecordsLabel";
            this.RecordsLabel.Size = new System.Drawing.Size(203, 25);
            this.RecordsLabel.TabIndex = 58;
            this.RecordsLabel.Text = "Transfusion records";
            // 
            // TransferLabel
            // 
            this.TransferLabel.AutoSize = true;
            this.TransferLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferLabel.ForeColor = System.Drawing.Color.White;
            this.TransferLabel.Location = new System.Drawing.Point(28, 244);
            this.TransferLabel.Name = "TransferLabel";
            this.TransferLabel.Size = new System.Drawing.Size(92, 25);
            this.TransferLabel.TabIndex = 57;
            this.TransferLabel.Text = "Transfer";
            // 
            // ManagePatientsLabel
            // 
            this.ManagePatientsLabel.AutoSize = true;
            this.ManagePatientsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagePatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePatientsLabel.ForeColor = System.Drawing.Color.White;
            this.ManagePatientsLabel.Location = new System.Drawing.Point(28, 202);
            this.ManagePatientsLabel.Name = "ManagePatientsLabel";
            this.ManagePatientsLabel.Size = new System.Drawing.Size(172, 25);
            this.ManagePatientsLabel.TabIndex = 48;
            this.ManagePatientsLabel.Text = "Manage patients";
            // 
            // DonateLabel
            // 
            this.DonateLabel.AutoSize = true;
            this.DonateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLabel.ForeColor = System.Drawing.Color.White;
            this.DonateLabel.Location = new System.Drawing.Point(28, 122);
            this.DonateLabel.Name = "DonateLabel";
            this.DonateLabel.Size = new System.Drawing.Size(81, 25);
            this.DonateLabel.TabIndex = 56;
            this.DonateLabel.Text = "Donate";
            // 
            // ManageDonorsLabel
            // 
            this.ManageDonorsLabel.AutoSize = true;
            this.ManageDonorsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageDonorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDonorsLabel.ForeColor = System.Drawing.Color.White;
            this.ManageDonorsLabel.Location = new System.Drawing.Point(28, 81);
            this.ManageDonorsLabel.Name = "ManageDonorsLabel";
            this.ManageDonorsLabel.Size = new System.Drawing.Size(162, 25);
            this.ManageDonorsLabel.TabIndex = 48;
            this.ManageDonorsLabel.Text = "Manage donors";
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.Color.White;
            this.LogOutLabel.Location = new System.Drawing.Point(28, 591);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(84, 25);
            this.LogOutLabel.TabIndex = 47;
            this.LogOutLabel.Text = "Log out";
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(28, 45);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(117, 25);
            this.DashboardLabel.TabIndex = 47;
            this.DashboardLabel.Text = "Dashboard";
            this.DashboardLabel.Click += new System.EventHandler(this.DashboardLabel_Click);
            // 
            // DonationVolumeLabel
            // 
            this.DonationVolumeLabel.AutoSize = true;
            this.DonationVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationVolumeLabel.ForeColor = System.Drawing.Color.Salmon;
            this.DonationVolumeLabel.Location = new System.Drawing.Point(948, 289);
            this.DonationVolumeLabel.Name = "DonationVolumeLabel";
            this.DonationVolumeLabel.Size = new System.Drawing.Size(238, 29);
            this.DonationVolumeLabel.TabIndex = 66;
            this.DonationVolumeLabel.Text = "Donation Volume (L):";
            // 
            // DonationVolumeTextBox
            // 
            this.DonationVolumeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationVolumeTextBox.Location = new System.Drawing.Point(953, 321);
            this.DonationVolumeTextBox.Name = "DonationVolumeTextBox";
            this.DonationVolumeTextBox.Size = new System.Drawing.Size(225, 31);
            this.DonationVolumeTextBox.TabIndex = 67;
            // 
            // SearchDonorsLabel
            // 
            this.SearchDonorsLabel.AutoSize = true;
            this.SearchDonorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDonorsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchDonorsLabel.Location = new System.Drawing.Point(288, 89);
            this.SearchDonorsLabel.Name = "SearchDonorsLabel";
            this.SearchDonorsLabel.Size = new System.Drawing.Size(158, 25);
            this.SearchDonorsLabel.TabIndex = 64;
            this.SearchDonorsLabel.Text = "Search donors:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(441, 88);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(454, 31);
            this.LastNameTextBox.TabIndex = 65;
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
            this.EditButton.Location = new System.Drawing.Point(953, 428);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(225, 42);
            this.EditButton.TabIndex = 68;
            this.EditButton.Text = "Donate";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DonorsGrid
            // 
            this.DonorsGrid.AllowUserToAddRows = false;
            this.DonorsGrid.AllowUserToDeleteRows = false;
            this.DonorsGrid.AllowUserToOrderColumns = true;
            this.DonorsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DonorsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DonorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DonorsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.DonorsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DonorsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DonorsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DonorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorsGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DonorsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DonorsGrid.EnableHeadersVisualStyles = false;
            this.DonorsGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DonorsGrid.Location = new System.Drawing.Point(293, 150);
            this.DonorsGrid.MultiSelect = false;
            this.DonorsGrid.Name = "DonorsGrid";
            this.DonorsGrid.ReadOnly = true;
            this.DonorsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DonorsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DonorsGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DonorsGrid.RowTemplate.Height = 30;
            this.DonorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DonorsGrid.Size = new System.Drawing.Size(602, 504);
            this.DonorsGrid.TabIndex = 63;
            // 
            // DonateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 688);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DonationVolumeTextBox);
            this.Controls.Add(this.DonationVolumeLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.SearchDonorsLabel);
            this.Controls.Add(this.DonorsGrid);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonateForm";
            this.Text = "DonateForm";
            this.Load += new System.EventHandler(this.DonateForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label DonationsRecordsLabel;
        private System.Windows.Forms.Panel PointerPanel;
        private System.Windows.Forms.Label RecordsLabel;
        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label ManagePatientsLabel;
        private System.Windows.Forms.Label DonateLabel;
        private System.Windows.Forms.Label ManageDonorsLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label DashboardLabel;
        private MyDataGridView DonorsGrid;
        private System.Windows.Forms.Label DonationVolumeLabel;
        private System.Windows.Forms.TextBox DonationVolumeTextBox;
        private ButtonModified EditButton;
        private System.Windows.Forms.Label SearchDonorsLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
    }
}