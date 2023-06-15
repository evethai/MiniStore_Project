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
            dgvRoles.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { idEmpDataGridViewTextBoxColumn, fullNameEmpDataGridViewTextBoxColumn, rolesDataGridViewTextBoxColumn });
            dgvRoles.DataSource = employeeBindingSource;
            dgvRoles.Location = new Point(-1, -1);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowTemplate.Height = 27;
            dgvRoles.Size = new Size(345, 126);
            dgvRoles.TabIndex = 1;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "IdEmp";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            // 
            // fullNameEmpDataGridViewTextBoxColumn
            // 
            fullNameEmpDataGridViewTextBoxColumn.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.HeaderText = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.Name = "fullNameEmpDataGridViewTextBoxColumn";
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // frmDetailSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 123);
            Controls.Add(dgvRoles);
            Name = "frmDetailSetup";
            Text = "frmDetailSetup";
            Load += frmDetailSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRoles;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private BindingSource employeeBindingSource;
    }
}