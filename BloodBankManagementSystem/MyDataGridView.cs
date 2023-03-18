using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
           

            // Set the basic properties
            this.BorderStyle = BorderStyle.None;
            this.BackgroundColor = Color.FromArgb(255, 245, 245, 245);
            this.GridColor = Color.FromArgb(255, 240, 240, 240);
            this.DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 245, 245);
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 216, 216, 216);
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.ReadOnly = true;

            // Set the font and row height
            this.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RowTemplate.Height = 30;

            // Set the column headers style
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 238, 238, 238);
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            this.ColumnHeadersHeight = 40;

            // Set the cell borders
            this.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            // Set the row background colors
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.RowsDefaultCellStyle.BackColor = Color.White;

            // Set the auto sizing mode
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeColumns = true;
            this.AllowUserToResizeRows = false;

            // Add a padding to the cells
            Padding padding = new Padding(10, 0, 10, 0);
            this.RowTemplate.DefaultCellStyle.Padding = padding;

            
        }
    }
}