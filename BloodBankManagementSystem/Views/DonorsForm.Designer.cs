namespace BloodBankManagementSystem.Views
{
    partial class DonorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorsForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DashBoardLabell = new System.Windows.Forms.Label();
            this.DonationsRecordsLabel = new System.Windows.Forms.Label();
            this.PointerPanel = new System.Windows.Forms.Panel();
            this.RecordsLabel = new System.Windows.Forms.Label();
            this.TransferLabel = new System.Windows.Forms.Label();
            this.ManagePatientsLabel = new System.Windows.Forms.Label();
            this.DonateLabel = new System.Windows.Forms.Label();
            this.ManageDonorsLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.SearchDonorsTextBox = new System.Windows.Forms.TextBox();
            this.SearchDonorsLabel = new System.Windows.Forms.Label();
            this.DonorsGrid = new BloodBankManagementSystem.MyDataGridView();
            this.RefreshButton = new BloodBankManagementSystem.ButtonModified1();
            this.DeleteButton = new BloodBankManagementSystem.ButtonModified1();
            this.EditButton = new BloodBankManagementSystem.ButtonModified1();
            this.AddButton = new BloodBankManagementSystem.ButtonModified1();
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
            this.HeaderPanel.TabIndex = 27;
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
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(514, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(414, 31);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Blood Bank Management System";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Silver;
            this.MenuPanel.Controls.Add(this.DashBoardLabell);
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
            this.MenuPanel.Size = new System.Drawing.Size(250, 656);
            this.MenuPanel.TabIndex = 42;
            // 
            // DashBoardLabell
            // 
            this.DashBoardLabell.AutoSize = true;
            this.DashBoardLabell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoardLabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardLabell.ForeColor = System.Drawing.Color.White;
            this.DashBoardLabell.Location = new System.Drawing.Point(28, 42);
            this.DashBoardLabell.Name = "DashBoardLabell";
            this.DashBoardLabell.Size = new System.Drawing.Size(117, 25);
            this.DashBoardLabell.TabIndex = 68;
            this.DashBoardLabell.Text = "Dashboard";
            this.DashBoardLabell.Click += new System.EventHandler(this.DashBoardLabell_Click);
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
            this.PointerPanel.Location = new System.Drawing.Point(12, 81);
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
            this.DonateLabel.Click += new System.EventHandler(this.DonateLabel_Click);
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
            this.ManageDonorsLabel.Click += new System.EventHandler(this.ManageDonorsLabel_Click);
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.Color.White;
            this.LogOutLabel.Location = new System.Drawing.Point(28, 601);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(84, 25);
            this.LogOutLabel.TabIndex = 47;
            this.LogOutLabel.Text = "Log out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.Location = new System.Drawing.Point(0, 0);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(100, 23);
            this.DashboardLabel.TabIndex = 61;
            // 
            // SearchDonorsTextBox
            // 
            this.SearchDonorsTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDonorsTextBox.Location = new System.Drawing.Point(631, 562);
            this.SearchDonorsTextBox.Name = "SearchDonorsTextBox";
            this.SearchDonorsTextBox.Size = new System.Drawing.Size(327, 31);
            this.SearchDonorsTextBox.TabIndex = 66;
            this.SearchDonorsTextBox.TextChanged += new System.EventHandler(this.SearchDonorsTextBox_TextChanged_1);
            // 
            // SearchDonorsLabel
            // 
            this.SearchDonorsLabel.AutoSize = true;
            this.SearchDonorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDonorsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchDonorsLabel.Location = new System.Drawing.Point(480, 563);
            this.SearchDonorsLabel.Name = "SearchDonorsLabel";
            this.SearchDonorsLabel.Size = new System.Drawing.Size(145, 25);
            this.SearchDonorsLabel.TabIndex = 67;
            this.SearchDonorsLabel.Text = "Search users:";
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
            this.DonorsGrid.Location = new System.Drawing.Point(250, 49);
            this.DonorsGrid.MultiSelect = false;
            this.DonorsGrid.Name = "DonorsGrid";
            this.DonorsGrid.ReadOnly = true;
            this.DonorsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DonorsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DonorsGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DonorsGrid.RowTemplate.Height = 30;
            this.DonorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DonorsGrid.Size = new System.Drawing.Size(962, 460);
            this.DonorsGrid.TabIndex = 62;
            this.DonorsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonorsGrid_CellContentClick_1);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Salmon;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(873, 628);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(132, 47);
            this.RefreshButton.TabIndex = 61;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Salmon;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(724, 628);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(143, 47);
            this.DeleteButton.TabIndex = 60;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Salmon;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(575, 628);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(143, 47);
            this.EditButton.TabIndex = 59;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Salmon;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(426, 628);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 47);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DonorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 705);
            this.Controls.Add(this.SearchDonorsTextBox);
            this.Controls.Add(this.SearchDonorsLabel);
            this.Controls.Add(this.DonorsGrid);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorsForm";
            this.Load += new System.EventHandler(this.DonorsForm_Load);
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
        private System.Windows.Forms.Panel PointerPanel;
        private System.Windows.Forms.Label RecordsLabel;
        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label ManagePatientsLabel;
        private System.Windows.Forms.Label DonateLabel;
        private System.Windows.Forms.Label ManageDonorsLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label DashboardLabel;
        private ButtonModified1 RefreshButton;
        private ButtonModified1 DeleteButton;
        private ButtonModified1 EditButton;
        private ButtonModified1 AddButton;
        private MyDataGridView DonorsGrid;
        private System.Windows.Forms.Label DonationsRecordsLabel;
        private System.Windows.Forms.TextBox SearchDonorsTextBox;
        private System.Windows.Forms.Label SearchDonorsLabel;
        private System.Windows.Forms.Label DashBoardLabell;
    }
}