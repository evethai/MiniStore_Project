namespace MiniStoreWinF.ManageSalary
{
    partial class frmSalaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryDetail));
            dgvSalary = new DataGridView();
            idSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryHourDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basicSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumSubSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumAdvanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryAfterTaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryBindingSource = new BindingSource(components);
            dtpTime = new DateTimePicker();
            btFilter = new Button();
            cbName = new ComboBox();
            btSearch = new Button();
            btReset = new Button();
            btExport = new Button();
            nmPaging = new NumericUpDown();
            txtSave = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).BeginInit();
            SuspendLayout();
            // 
            // dgvSalary
            // 
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { idSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, salaryHourDataGridViewTextBoxColumn, basicSalaryDataGridViewTextBoxColumn, sumSubSalaryDataGridViewTextBoxColumn, sumAdvanceSalaryDataGridViewTextBoxColumn, totalSalaryDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, salaryAfterTaxDataGridViewTextBoxColumn });
            dgvSalary.DataSource = salaryBindingSource;
            dgvSalary.Location = new Point(24, 161);
            dgvSalary.Name = "dgvSalary";
            dgvSalary.RowTemplate.Height = 27;
            dgvSalary.Size = new Size(945, 195);
            dgvSalary.TabIndex = 0;
            dgvSalary.CellDoubleClick += dgvSalary_CellDoubleClick;
            // 
            // idSalaryDataGridViewTextBoxColumn
            // 
            idSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdSalary";
            idSalaryDataGridViewTextBoxColumn.HeaderText = "IdSalary";
            idSalaryDataGridViewTextBoxColumn.Name = "idSalaryDataGridViewTextBoxColumn";
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "IdEmp";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            // 
            // salaryHourDataGridViewTextBoxColumn
            // 
            salaryHourDataGridViewTextBoxColumn.DataPropertyName = "SalaryHour";
            salaryHourDataGridViewTextBoxColumn.HeaderText = "SalaryHour";
            salaryHourDataGridViewTextBoxColumn.Name = "salaryHourDataGridViewTextBoxColumn";
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            // 
            // sumSubSalaryDataGridViewTextBoxColumn
            // 
            sumSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumSubSalary";
            sumSubSalaryDataGridViewTextBoxColumn.HeaderText = "SumSubSalary";
            sumSubSalaryDataGridViewTextBoxColumn.Name = "sumSubSalaryDataGridViewTextBoxColumn";
            // 
            // sumAdvanceSalaryDataGridViewTextBoxColumn
            // 
            sumAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumAdvanceSalary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "SumAdvanceSalary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Name = "sumAdvanceSalaryDataGridViewTextBoxColumn";
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            totalSalaryDataGridViewTextBoxColumn.HeaderText = "TotalSalary";
            totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // salaryAfterTaxDataGridViewTextBoxColumn
            // 
            salaryAfterTaxDataGridViewTextBoxColumn.DataPropertyName = "SalaryAfterTax";
            salaryAfterTaxDataGridViewTextBoxColumn.HeaderText = "SalaryAfterTax";
            salaryAfterTaxDataGridViewTextBoxColumn.Name = "salaryAfterTaxDataGridViewTextBoxColumn";
            // 
            // salaryBindingSource
            // 
            salaryBindingSource.DataSource = typeof(Repository.Models.Salary);
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "MM/yyyy";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(24, 12);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(200, 25);
            dtpTime.TabIndex = 1;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(239, 12);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(45, 25);
            btFilter.TabIndex = 3;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(293, 13);
            cbName.Name = "cbName";
            cbName.Size = new Size(121, 25);
            cbName.TabIndex = 10;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(420, 14);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(134, 25);
            btSearch.TabIndex = 9;
            btSearch.Text = "Search by Name";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(894, 12);
            btReset.Name = "btReset";
            btReset.Size = new Size(75, 23);
            btReset.TabIndex = 11;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btExport
            // 
            btExport.Location = new Point(894, 41);
            btExport.Name = "btExport";
            btExport.Size = new Size(75, 23);
            btExport.TabIndex = 12;
            btExport.Text = "Export";
            btExport.UseVisualStyleBackColor = true;
            btExport.Click += btExport_Click;
            // 
            // nmPaging
            // 
            nmPaging.Location = new Point(849, 130);
            nmPaging.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmPaging.Name = "nmPaging";
            nmPaging.Size = new Size(120, 25);
            nmPaging.TabIndex = 13;
            nmPaging.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmPaging.ValueChanged += nmPaging_ValueChanged;
            // 
            // txtSave
            // 
            txtSave.AutoSize = true;
            txtSave.Location = new Point(800, 138);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(0, 17);
            txtSave.TabIndex = 14;
            txtSave.Visible = false;
            // 
            // frmSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 368);
            Controls.Add(txtSave);
            Controls.Add(nmPaging);
            Controls.Add(btExport);
            Controls.Add(btReset);
            Controls.Add(cbName);
            Controls.Add(btSearch);
            Controls.Add(btFilter);
            Controls.Add(dtpTime);
            Controls.Add(dgvSalary);
            Name = "frmSalaryDetail";
            Text = "frmSalaryDetail";
            Load += frmSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSalary;
        private DateTimePicker dtpTime;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryHourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumAdvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryAfterTaxDataGridViewTextBoxColumn;
        private BindingSource salaryBindingSource;
        private Button btFilter;
        private ComboBox cbName;
        private Button btSearch;
        private Button btReset;
        private Button btExport;
        private NumericUpDown nmPaging;
        private Label txtSave;
    }
}