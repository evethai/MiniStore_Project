namespace MiniStoreWinF.ManageEmployees
{
    partial class frmShowSubSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowSubSalary));
            cbListEmployee = new ComboBox();
            btSearch = new Button();
            btAddSub = new Button();
            dgvSubDetail = new DataGridView();
            idDetailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idSubDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkDataGridViewTextBoxColumn = new DataGridViewCheckBoxColumn();
            subDetailBindingSource1 = new BindingSource(components);
            subDetailBindingSource = new BindingSource(components);
            btUpdate = new Button();
            cbCheck = new ComboBox();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbListEmployee
            // 
            cbListEmployee.FormattingEnabled = true;
            cbListEmployee.Location = new Point(5, 21);
            cbListEmployee.Margin = new Padding(5, 4, 5, 4);
            cbListEmployee.Name = "cbListEmployee";
            cbListEmployee.Size = new Size(188, 33);
            cbListEmployee.TabIndex = 0;
            cbListEmployee.SelectedIndexChanged += cbListEmployee_SelectedIndexChanged;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(222, 18);
            btSearch.Margin = new Padding(5, 4, 5, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(118, 38);
            btSearch.TabIndex = 1;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btAddSub
            // 
            btAddSub.Location = new Point(349, 18);
            btAddSub.Margin = new Padding(5, 4, 5, 4);
            btAddSub.Name = "btAddSub";
            btAddSub.Size = new Size(347, 38);
            btAddSub.TabIndex = 2;
            btAddSub.Text = "Add new Sub Salary For Employee";
            btAddSub.UseVisualStyleBackColor = true;
            btAddSub.Click += btAddSub_Click;
            // 
            // dgvSubDetail
            // 
            dgvSubDetail.AutoGenerateColumns = false;
            dgvSubDetail.BackgroundColor = SystemColors.Window;
            dgvSubDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubDetail.Columns.AddRange(new DataGridViewColumn[] { idDetailDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, idSubDataGridViewTextBoxColumn, checkDataGridViewTextBoxColumn });
            dgvSubDetail.DataSource = subDetailBindingSource1;
            dgvSubDetail.Location = new Point(5, 85);
            dgvSubDetail.Margin = new Padding(5, 4, 5, 4);
            dgvSubDetail.Name = "dgvSubDetail";
            dgvSubDetail.ReadOnly = true;
            dgvSubDetail.RowTemplate.Height = 25;
            dgvSubDetail.Size = new Size(1252, 474);
            dgvSubDetail.TabIndex = 3;
            dgvSubDetail.CellClick += dgvSubDetail_CellClick;
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            idDetailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            idDetailDataGridViewTextBoxColumn.HeaderText = "ID";
            idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            idDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "ID Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSubDataGridViewTextBoxColumn
            // 
            idSubDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idSubDataGridViewTextBoxColumn.DataPropertyName = "IdSub";
            idSubDataGridViewTextBoxColumn.HeaderText = "ID Allowance";
            idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            idSubDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkDataGridViewTextBoxColumn
            // 
            checkDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            checkDataGridViewTextBoxColumn.DataPropertyName = "Check";
            checkDataGridViewTextBoxColumn.HeaderText = "Check";
            checkDataGridViewTextBoxColumn.Name = "checkDataGridViewTextBoxColumn";
            checkDataGridViewTextBoxColumn.ReadOnly = true;
            checkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            checkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // subDetailBindingSource1
            // 
            subDetailBindingSource1.DataSource = typeof(Repository.Models.SubDetail);
            // 
            // subDetailBindingSource
            // 
            subDetailBindingSource.DataSource = typeof(Repository.Models.SubDetail);
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(706, 18);
            btUpdate.Margin = new Padding(5, 4, 5, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(118, 38);
            btUpdate.TabIndex = 4;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // cbCheck
            // 
            cbCheck.FormattingEnabled = true;
            cbCheck.Items.AddRange(new object[] { "True", "False" });
            cbCheck.Location = new Point(1048, 21);
            cbCheck.Margin = new Padding(5, 4, 5, 4);
            cbCheck.Name = "cbCheck";
            cbCheck.Size = new Size(188, 33);
            cbCheck.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(847, 18);
            txtId.Margin = new Padding(5, 4, 5, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 33);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // frmShowSubSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 562);
            Controls.Add(txtId);
            Controls.Add(cbCheck);
            Controls.Add(btUpdate);
            Controls.Add(dgvSubDetail);
            Controls.Add(btAddSub);
            Controls.Add(btSearch);
            Controls.Add(cbListEmployee);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "frmShowSubSalary";
            Text = "Allowance";
            Load += frmShowSubSalary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbListEmployee;
        private Button btSearch;
        private Button btAddSub;
        private DataGridView dgvSubDetail;
        private BindingSource subDetailBindingSource;
        private BindingSource subDetailBindingSource1;
        private Button btUpdate;
        private ComboBox cbCheck;
        private TextBox txtId;
        private DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeBeginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn checkDataGridViewTextBoxColumn;
    }
}