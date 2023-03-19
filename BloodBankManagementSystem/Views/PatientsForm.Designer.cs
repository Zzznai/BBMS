namespace BloodBankManagementSystem.Views
{
    partial class PatientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PatientsGrid = new BloodBankManagementSystem.MyDataGridView();
            this.RefreshButton = new BloodBankManagementSystem.ButtonModified1();
            this.DeleteButton = new BloodBankManagementSystem.ButtonModified1();
            this.EditButton = new BloodBankManagementSystem.ButtonModified1();
            this.AddButton = new BloodBankManagementSystem.ButtonModified1();
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
            this.SearchPatientsTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatientsLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.MenuPanel.SuspendLayout();
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
            this.HeaderLabel.Location = new System.Drawing.Point(514, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(414, 31);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Blood Bank Management System";
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.AllowUserToAddRows = false;
            this.PatientsGrid.AllowUserToDeleteRows = false;
            this.PatientsGrid.AllowUserToOrderColumns = true;
            this.PatientsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.PatientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientsGrid.EnableHeadersVisualStyles = false;
            this.PatientsGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PatientsGrid.Location = new System.Drawing.Point(250, 49);
            this.PatientsGrid.MultiSelect = false;
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.ReadOnly = true;
            this.PatientsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PatientsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientsGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PatientsGrid.RowTemplate.Height = 30;
            this.PatientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsGrid.Size = new System.Drawing.Size(964, 460);
            this.PatientsGrid.TabIndex = 63;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Salmon;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(877, 628);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(132, 47);
            this.RefreshButton.TabIndex = 67;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Salmon;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(728, 628);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(143, 47);
            this.DeleteButton.TabIndex = 66;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Salmon;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(579, 628);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(143, 47);
            this.EditButton.TabIndex = 65;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Salmon;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(430, 628);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 47);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.MenuPanel.TabIndex = 68;
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
            this.PointerPanel.Location = new System.Drawing.Point(12, 202);
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
            this.LogOutLabel.Location = new System.Drawing.Point(28, 601);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(84, 25);
            this.LogOutLabel.TabIndex = 47;
            this.LogOutLabel.Text = "Log out";
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.Location = new System.Drawing.Point(0, 0);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(100, 23);
            this.DashboardLabel.TabIndex = 61;
            // 
            // SearchPatientsTextBox
            // 
            this.SearchPatientsTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPatientsTextBox.Location = new System.Drawing.Point(646, 574);
            this.SearchPatientsTextBox.Name = "SearchPatientsTextBox";
            this.SearchPatientsTextBox.Size = new System.Drawing.Size(327, 31);
            this.SearchPatientsTextBox.TabIndex = 69;
            this.SearchPatientsTextBox.TextChanged += new System.EventHandler(this.SearchPatientsTextBox_TextChanged);
            // 
            // SearchPatientsLabel
            // 
            this.SearchPatientsLabel.AutoSize = true;
            this.SearchPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPatientsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchPatientsLabel.Location = new System.Drawing.Point(472, 575);
            this.SearchPatientsLabel.Name = "SearchPatientsLabel";
            this.SearchPatientsLabel.Size = new System.Drawing.Size(168, 25);
            this.SearchPatientsLabel.TabIndex = 70;
            this.SearchPatientsLabel.Text = "Search patients:";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 705);
            this.Controls.Add(this.SearchPatientsTextBox);
            this.Controls.Add(this.SearchPatientsLabel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private MyDataGridView PatientsGrid;
        private ButtonModified1 RefreshButton;
        private ButtonModified1 DeleteButton;
        private ButtonModified1 EditButton;
        private ButtonModified1 AddButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label DashBoardLabell;
        private System.Windows.Forms.Label DonationsRecordsLabel;
        private System.Windows.Forms.Panel PointerPanel;
        private System.Windows.Forms.Label RecordsLabel;
        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label ManagePatientsLabel;
        private System.Windows.Forms.Label DonateLabel;
        private System.Windows.Forms.Label ManageDonorsLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.TextBox SearchPatientsTextBox;
        private System.Windows.Forms.Label SearchPatientsLabel;
    }
}