namespace BloodBankManagementSystem.Views
{
    partial class TransferForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
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
            this.TransferVolumeValidation = new System.Windows.Forms.Label();
            this.TransferVolumeTextBox = new System.Windows.Forms.TextBox();
            this.TransferVolumeLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatientsLabel = new System.Windows.Forms.Label();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.TransferButton = new BloodBankManagementSystem.ButtonModified();
            this.PatientsGrid = new BloodBankManagementSystem.MyDataGridView();
            this.BloodStockDataGridView = new BloodBankManagementSystem.MyDataGridView();
            this.HeaderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDataGridView)).BeginInit();
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
            this.HeaderPanel.TabIndex = 29;
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
            this.MenuPanel.TabIndex = 44;
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
            this.DonationsRecordsLabel.Click += new System.EventHandler(this.DonationsRecordsLabel_Click);
            // 
            // PointerPanel
            // 
            this.PointerPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.PointerPanel.Location = new System.Drawing.Point(12, 244);
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
            this.RecordsLabel.Click += new System.EventHandler(this.RecordsLabel_Click);
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
            this.TransferLabel.Click += new System.EventHandler(this.TransferLabel_Click);
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
            this.ManagePatientsLabel.Click += new System.EventHandler(this.ManagePatientsLabel_Click);
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
            this.LogOutLabel.Location = new System.Drawing.Point(28, 591);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(84, 25);
            this.LogOutLabel.TabIndex = 47;
            this.LogOutLabel.Text = "Log out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
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
            // TransferVolumeValidation
            // 
            this.TransferVolumeValidation.AutoSize = true;
            this.TransferVolumeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TransferVolumeValidation.ForeColor = System.Drawing.Color.Red;
            this.TransferVolumeValidation.Location = new System.Drawing.Point(912, 475);
            this.TransferVolumeValidation.Name = "TransferVolumeValidation";
            this.TransferVolumeValidation.Size = new System.Drawing.Size(10, 16);
            this.TransferVolumeValidation.TabIndex = 76;
            this.TransferVolumeValidation.Text = " ";
            this.TransferVolumeValidation.Click += new System.EventHandler(this.TransferVolumeValidation_Click);
            // 
            // TransferVolumeTextBox
            // 
            this.TransferVolumeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferVolumeTextBox.Location = new System.Drawing.Point(944, 441);
            this.TransferVolumeTextBox.Name = "TransferVolumeTextBox";
            this.TransferVolumeTextBox.Size = new System.Drawing.Size(225, 31);
            this.TransferVolumeTextBox.TabIndex = 74;
            this.TransferVolumeTextBox.TextChanged += new System.EventHandler(this.TransferVolumeTextBox_TextChanged);
            // 
            // TransferVolumeLabel
            // 
            this.TransferVolumeLabel.AutoSize = true;
            this.TransferVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferVolumeLabel.ForeColor = System.Drawing.Color.Salmon;
            this.TransferVolumeLabel.Location = new System.Drawing.Point(939, 409);
            this.TransferVolumeLabel.Name = "TransferVolumeLabel";
            this.TransferVolumeLabel.Size = new System.Drawing.Size(232, 29);
            this.TransferVolumeLabel.TabIndex = 73;
            this.TransferVolumeLabel.Text = "Transfer Volume (L):";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(450, 88);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(444, 31);
            this.SearchTextBox.TabIndex = 72;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchPatientsLabel
            // 
            this.SearchPatientsLabel.AutoSize = true;
            this.SearchPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPatientsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchPatientsLabel.Location = new System.Drawing.Point(287, 89);
            this.SearchPatientsLabel.Name = "SearchPatientsLabel";
            this.SearchPatientsLabel.Size = new System.Drawing.Size(168, 25);
            this.SearchPatientsLabel.TabIndex = 71;
            this.SearchPatientsLabel.Text = "Search patients:";
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Location = new System.Drawing.Point(944, 539);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(225, 30);
            this.BloodGroupComboBox.TabIndex = 78;
            this.BloodGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.BloodGroupComboBox_SelectedIndexChanged);
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BloodGroupLabel.Location = new System.Drawing.Point(939, 496);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(156, 29);
            this.BloodGroupLabel.TabIndex = 77;
            this.BloodGroupLabel.Text = "Blood Group:";
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.Salmon;
            this.TransferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.TransferButton.FlatAppearance.BorderSize = 0;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferButton.ForeColor = System.Drawing.Color.White;
            this.TransferButton.Location = new System.Drawing.Point(944, 616);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(225, 42);
            this.TransferButton.TabIndex = 75;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
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
            this.PatientsGrid.Location = new System.Drawing.Point(292, 150);
            this.PatientsGrid.MultiSelect = false;
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.ReadOnly = true;
            this.PatientsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PatientsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientsGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PatientsGrid.RowTemplate.Height = 30;
            this.PatientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsGrid.Size = new System.Drawing.Size(602, 508);
            this.PatientsGrid.TabIndex = 70;
            this.PatientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsGrid_CellContentClick);
            this.PatientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsGrid_CellClick);
            // 
            // BloodStockDataGridView
            // 
            this.BloodStockDataGridView.AllowUserToAddRows = false;
            this.BloodStockDataGridView.AllowUserToDeleteRows = false;
            this.BloodStockDataGridView.AllowUserToOrderColumns = true;
            this.BloodStockDataGridView.AllowUserToResizeColumns = false;
            this.BloodStockDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.BloodStockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BloodStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BloodStockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BloodStockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BloodStockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BloodStockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BloodStockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BloodStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BloodStockDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodStockDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.BloodStockDataGridView.EnableHeadersVisualStyles = false;
            this.BloodStockDataGridView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BloodStockDataGridView.Location = new System.Drawing.Point(944, 88);
            this.BloodStockDataGridView.MultiSelect = false;
            this.BloodStockDataGridView.Name = "BloodStockDataGridView";
            this.BloodStockDataGridView.ReadOnly = true;
            this.BloodStockDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.BloodStockDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.BloodStockDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BloodStockDataGridView.RowTemplate.Height = 30;
            this.BloodStockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodStockDataGridView.Size = new System.Drawing.Size(227, 279);
            this.BloodStockDataGridView.TabIndex = 79;
            this.BloodStockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BloodStockDataGridView_CellContentClick);
            this.BloodStockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BloodStockDataGridView_CellClick);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 705);
            this.Controls.Add(this.BloodStockDataGridView);
            this.Controls.Add(this.BloodGroupComboBox);
            this.Controls.Add(this.BloodGroupLabel);
            this.Controls.Add(this.TransferVolumeValidation);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferVolumeTextBox);
            this.Controls.Add(this.TransferVolumeLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchPatientsLabel);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDataGridView)).EndInit();
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
        private System.Windows.Forms.Label TransferVolumeValidation;
        private ButtonModified TransferButton;
        private System.Windows.Forms.TextBox TransferVolumeTextBox;
        private System.Windows.Forms.Label TransferVolumeLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchPatientsLabel;
        private MyDataGridView PatientsGrid;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.Label BloodGroupLabel;
        private MyDataGridView BloodStockDataGridView;
    }
}