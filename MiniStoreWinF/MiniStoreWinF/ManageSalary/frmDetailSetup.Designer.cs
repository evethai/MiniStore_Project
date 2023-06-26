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
            dgvRoles = new DataGridView();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvRoles
            // 
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRoles.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { idEmpDataGridViewTextBoxColumn, fullNameEmpDataGridViewTextBoxColumn, rolesDataGridViewTextBoxColumn });
            dgvRoles.DataSource = employeeBindingSource;
            dgvRoles.Location = new Point(-2, -1);
            dgvRoles.Margin = new Padding(5, 4, 5, 4);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowTemplate.Height = 27;
            dgvRoles.Size = new Size(542, 185);
            dgvRoles.TabIndex = 1;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 140;
            // 
            // fullNameEmpDataGridViewTextBoxColumn
            // 
            fullNameEmpDataGridViewTextBoxColumn.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.HeaderText = "Full Name";
            fullNameEmpDataGridViewTextBoxColumn.Name = "fullNameEmpDataGridViewTextBoxColumn";
            fullNameEmpDataGridViewTextBoxColumn.Width = 122;
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            rolesDataGridViewTextBoxColumn.Width = 81;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // frmDetailSetup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 172);
            Controls.Add(dgvRoles);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(449, 211);
            MinimumSize = new Size(449, 211);
            Name = "frmDetailSetup";
            Load += frmDetailSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRoles;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
    }
}