namespace BloodBankManagementSystem.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AdminTitleLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PointerPanel = new System.Windows.Forms.Panel();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.BloodDropImage = new System.Windows.Forms.PictureBox();
            this.ManagaEmpLabel = new System.Windows.Forms.Label();
            this.UserGrid = new BloodBankManagementSystem.MyDataGridView();
            this.RefreshButton = new BloodBankManagementSystem.ButtonModified1();
            this.DeleteButton = new BloodBankManagementSystem.ButtonModified1();
            this.EditButton = new BloodBankManagementSystem.ButtonModified1();
            this.AddButton = new BloodBankManagementSystem.ButtonModified1();
            this.SearchUsersTextBox = new System.Windows.Forms.TextBox();
            this.SearchUsersLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodDropImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Salmon;
            this.HeaderPanel.Controls.Add(this.GreetingsLabel);
            this.HeaderPanel.Controls.Add(this.ExitLabel);
            this.HeaderPanel.Controls.Add(this.AdminTitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(246, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(919, 46);
            this.HeaderPanel.TabIndex = 42;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.White;
            this.GreetingsLabel.Location = new System.Drawing.Point(690, 9);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(199, 29);
            this.GreetingsLabel.TabIndex = 43;
            this.GreetingsLabel.Text = "Welcome, admin!";
            this.GreetingsLabel.Click += new System.EventHandler(this.GreetingsLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(895, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 43;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AdminTitleLabel
            // 
            this.AdminTitleLabel.AutoSize = true;
            this.AdminTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTitleLabel.ForeColor = System.Drawing.Color.White;
            this.AdminTitleLabel.Location = new System.Drawing.Point(3, 9);
            this.AdminTitleLabel.Name = "AdminTitleLabel";
            this.AdminTitleLabel.Size = new System.Drawing.Size(368, 29);
            this.AdminTitleLabel.TabIndex = 1;
            this.AdminTitleLabel.Text = "Blood Bank Management System";
            this.AdminTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Salmon;
            this.MenuPanel.Controls.Add(this.PointerPanel);
            this.MenuPanel.Controls.Add(this.LogOutLabel);
            this.MenuPanel.Controls.Add(this.BloodDropImage);
            this.MenuPanel.Controls.Add(this.ManagaEmpLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(246, 643);
            this.MenuPanel.TabIndex = 41;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // PointerPanel
            // 
            this.PointerPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.PointerPanel.Location = new System.Drawing.Point(5, 102);
            this.PointerPanel.Name = "PointerPanel";
            this.PointerPanel.Size = new System.Drawing.Size(10, 28);
            this.PointerPanel.TabIndex = 54;
            this.PointerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PointerPanel_Paint);
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.Color.White;
            this.LogOutLabel.Location = new System.Drawing.Point(21, 596);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(84, 25);
            this.LogOutLabel.TabIndex = 44;
            this.LogOutLabel.Text = "Log out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // BloodDropImage
            // 
            this.BloodDropImage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BloodDropImage.Image = ((System.Drawing.Image)(resources.GetObject("BloodDropImage.Image")));
            this.BloodDropImage.Location = new System.Drawing.Point(87, 27);
            this.BloodDropImage.Name = "BloodDropImage";
            this.BloodDropImage.Size = new System.Drawing.Size(59, 60);
            this.BloodDropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BloodDropImage.TabIndex = 43;
            this.BloodDropImage.TabStop = false;
            this.BloodDropImage.UseWaitCursor = true;
            this.BloodDropImage.Click += new System.EventHandler(this.BloodDropImage_Click);
            // 
            // ManagaEmpLabel
            // 
            this.ManagaEmpLabel.AutoSize = true;
            this.ManagaEmpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagaEmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagaEmpLabel.ForeColor = System.Drawing.Color.White;
            this.ManagaEmpLabel.Location = new System.Drawing.Point(21, 103);
            this.ManagaEmpLabel.Name = "ManagaEmpLabel";
            this.ManagaEmpLabel.Size = new System.Drawing.Size(200, 25);
            this.ManagaEmpLabel.TabIndex = 43;
            this.ManagaEmpLabel.Text = "Manage employees";
            this.ManagaEmpLabel.Click += new System.EventHandler(this.ManagaEmpLabel_Click);
            // 
            // UserGrid
            // 
            this.UserGrid.AllowUserToAddRows = false;
            this.UserGrid.AllowUserToDeleteRows = false;
            this.UserGrid.AllowUserToOrderColumns = true;
            this.UserGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.UserGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.UserGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.UserGrid.EnableHeadersVisualStyles = false;
            this.UserGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserGrid.Location = new System.Drawing.Point(297, 129);
            this.UserGrid.MultiSelect = false;
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ReadOnly = true;
            this.UserGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.UserGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.UserGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.UserGrid.RowTemplate.Height = 30;
            this.UserGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGrid.Size = new System.Drawing.Size(820, 415);
            this.UserGrid.TabIndex = 56;
            this.UserGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellContentClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Salmon;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(839, 574);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 47);
            this.RefreshButton.TabIndex = 55;
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
            this.DeleteButton.Location = new System.Drawing.Point(702, 574);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 47);
            this.DeleteButton.TabIndex = 53;
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
            this.EditButton.Location = new System.Drawing.Point(565, 574);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 47);
            this.EditButton.TabIndex = 52;
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
            this.AddButton.Location = new System.Drawing.Point(428, 574);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 47);
            this.AddButton.TabIndex = 51;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // SearchUsersTextBox
            // 
            this.SearchUsersTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUsersTextBox.Location = new System.Drawing.Point(650, 77);
            this.SearchUsersTextBox.Name = "SearchUsersTextBox";
            this.SearchUsersTextBox.Size = new System.Drawing.Size(315, 31);
            this.SearchUsersTextBox.TabIndex = 57;
            this.SearchUsersTextBox.TextChanged += new System.EventHandler(this.SearchUsersTextBox_TextChanged);
            // 
            // SearchUsersLabel
            // 
            this.SearchUsersLabel.AutoSize = true;
            this.SearchUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUsersLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchUsersLabel.Location = new System.Drawing.Point(495, 78);
            this.SearchUsersLabel.Name = "SearchUsersLabel";
            this.SearchUsersLabel.Size = new System.Drawing.Size(145, 25);
            this.SearchUsersLabel.TabIndex = 65;
            this.SearchUsersLabel.Text = "Search users:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 643);
            this.Controls.Add(this.SearchUsersTextBox);
            this.Controls.Add(this.SearchUsersLabel);
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MenuPanel);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodDropImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AdminTitleLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Label ManagaEmpLabel;
        private System.Windows.Forms.PictureBox BloodDropImage;
        private System.Windows.Forms.Label LogOutLabel;
        private ButtonModified1 AddButton;
        private ButtonModified1 EditButton;
        private ButtonModified1 DeleteButton;
        private System.Windows.Forms.Panel PointerPanel;
        private ButtonModified1 RefreshButton;
        private MyDataGridView UserGrid;
        private System.Windows.Forms.TextBox SearchUsersTextBox;
        private System.Windows.Forms.Label SearchUsersLabel;
    }
}