namespace MiniStoreWinF.ManageSalary
{
    partial class frmDetailSetup
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailSetup));
            dgvEmp = new DataGridView();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvGuard = new DataGridView();
            idEmpDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fullNameEmpDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuard).BeginInit();
            SuspendLayout();
            // 
            // dgvEmp
            // 
            dgvEmp.AutoGenerateColumns = false;
            dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmp.BackgroundColor = SystemColors.Window;
            dgvEmp.BorderStyle = BorderStyle.Fixed3D;
            dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmp.Columns.AddRange(new DataGridViewColumn[] { idEmpDataGridViewTextBoxColumn, fullNameEmpDataGridViewTextBoxColumn });
            dgvEmp.DataSource = employeeBindingSource;
            dgvEmp.Dock = DockStyle.Fill;
            dgvEmp.Location = new Point(5, 4);
            dgvEmp.Margin = new Padding(5, 4, 5, 4);
            dgvEmp.Name = "dgvEmp";
            dgvEmp.ReadOnly = true;
            dgvEmp.RowTemplate.Height = 27;
            dgvEmp.Size = new Size(413, 466);
            dgvEmp.TabIndex = 1;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameEmpDataGridViewTextBoxColumn
            // 
            fullNameEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameEmpDataGridViewTextBoxColumn.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.HeaderText = "Full Name";
            fullNameEmpDataGridViewTextBoxColumn.Name = "fullNameEmpDataGridViewTextBoxColumn";
            fullNameEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvEmp, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvGuard, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(846, 474);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvGuard
            // 
            dgvGuard.AutoGenerateColumns = false;
            dgvGuard.BackgroundColor = SystemColors.Window;
            dgvGuard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuard.Columns.AddRange(new DataGridViewColumn[] { idEmpDataGridViewTextBoxColumn1, fullNameEmpDataGridViewTextBoxColumn1 });
            dgvGuard.DataSource = employeeBindingSource;
            dgvGuard.Dock = DockStyle.Fill;
            dgvGuard.Location = new Point(426, 3);
            dgvGuard.Name = "dgvGuard";
            dgvGuard.ReadOnly = true;
            dgvGuard.RowTemplate.Height = 27;
            dgvGuard.Size = new Size(417, 468);
            dgvGuard.TabIndex = 2;
            // 
            // idEmpDataGridViewTextBoxColumn1
            // 
            idEmpDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn1.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn1.HeaderText = "Id Guard";
            idEmpDataGridViewTextBoxColumn1.Name = "idEmpDataGridViewTextBoxColumn1";
            idEmpDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fullNameEmpDataGridViewTextBoxColumn1
            // 
            fullNameEmpDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameEmpDataGridViewTextBoxColumn1.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn1.HeaderText = "Full Name";
            fullNameEmpDataGridViewTextBoxColumn1.Name = "fullNameEmpDataGridViewTextBoxColumn1";
            fullNameEmpDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmDetailSetup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 474);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(862, 513);
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(862, 513);
            MinimizeBox = false;
            Name = "frmDetailSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDetailSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmp;
        private BindingSource employeeBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn2;
        private DataGridView dgvGuard;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn1;
    }
}