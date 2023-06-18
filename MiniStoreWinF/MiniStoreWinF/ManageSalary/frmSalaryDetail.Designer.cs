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
            salaryBindingSource = new BindingSource(components);
            dtpTime = new DateTimePicker();
            btFilter = new Button();
            cbName = new ComboBox();
            btSearch = new Button();
            btReset = new Button();
            btExport = new Button();
            nmPaging = new NumericUpDown();
            txtSave = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            idSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryHourDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basicSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumSubSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumAdvanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryAfterTaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DateOmonth = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSalary
            // 
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { idSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, salaryHourDataGridViewTextBoxColumn, basicSalaryDataGridViewTextBoxColumn, sumSubSalaryDataGridViewTextBoxColumn, sumAdvanceSalaryDataGridViewTextBoxColumn, totalSalaryDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, salaryAfterTaxDataGridViewTextBoxColumn, DateOmonth });
            dgvSalary.DataSource = salaryBindingSource;
            dgvSalary.Dock = DockStyle.Top;
            dgvSalary.Location = new Point(0, 0);
            dgvSalary.Name = "dgvSalary";
            dgvSalary.RowTemplate.Height = 27;
            dgvSalary.Size = new Size(1231, 195);
            dgvSalary.TabIndex = 0;
            dgvSalary.CellContentClick += dgvSalary_CellContentClick;
            dgvSalary.CellDoubleClick += dgvSalary_CellDoubleClick;
            // 
            // salaryBindingSource
            // 
            salaryBindingSource.DataSource = typeof(Repository.Models.Salary);
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "MM/yyyy";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(3, 3);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(200, 25);
            dtpTime.TabIndex = 1;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(209, 6);
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
            cbName.Location = new Point(0, 34);
            cbName.Name = "cbName";
            cbName.Size = new Size(203, 25);
            cbName.TabIndex = 10;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(209, 34);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(134, 25);
            btSearch.TabIndex = 9;
            btSearch.Text = "Search by Name";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btReset
            // 
            btReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btReset.Location = new Point(1144, 61);
            btReset.Name = "btReset";
            btReset.Size = new Size(75, 23);
            btReset.TabIndex = 11;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btExport
            // 
            btExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExport.Location = new Point(1144, 8);
            btExport.Name = "btExport";
            btExport.Size = new Size(75, 23);
            btExport.TabIndex = 12;
            btExport.Text = "Export";
            btExport.UseVisualStyleBackColor = true;
            btExport.Click += btExport_Click;
            // 
            // nmPaging
            // 
            nmPaging.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nmPaging.Location = new Point(1176, 124);
            nmPaging.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmPaging.Name = "nmPaging";
            nmPaging.Size = new Size(43, 25);
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
            // panel1
            // 
            panel1.Controls.Add(dtpTime);
            panel1.Controls.Add(nmPaging);
            panel1.Controls.Add(cbName);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(btExport);
            panel1.Controls.Add(btFilter);
            panel1.Controls.Add(btReset);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 155);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSalary);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 388);
            panel2.TabIndex = 16;
            // 
            // idSalaryDataGridViewTextBoxColumn
            // 
            idSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdSalary";
            idSalaryDataGridViewTextBoxColumn.HeaderText = "Id";
            idSalaryDataGridViewTextBoxColumn.Name = "idSalaryDataGridViewTextBoxColumn";
            idSalaryDataGridViewTextBoxColumn.Width = 55;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 149;
            // 
            // salaryHourDataGridViewTextBoxColumn
            // 
            salaryHourDataGridViewTextBoxColumn.DataPropertyName = "SalaryHour";
            salaryHourDataGridViewTextBoxColumn.HeaderText = "Salary In Hour";
            salaryHourDataGridViewTextBoxColumn.Name = "salaryHourDataGridViewTextBoxColumn";
            salaryHourDataGridViewTextBoxColumn.Width = 162;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            basicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary";
            basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            basicSalaryDataGridViewTextBoxColumn.Width = 138;
            // 
            // sumSubSalaryDataGridViewTextBoxColumn
            // 
            sumSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumSubSalary";
            sumSubSalaryDataGridViewTextBoxColumn.HeaderText = "Allowance";
            sumSubSalaryDataGridViewTextBoxColumn.Name = "sumSubSalaryDataGridViewTextBoxColumn";
            sumSubSalaryDataGridViewTextBoxColumn.Width = 126;
            // 
            // sumAdvanceSalaryDataGridViewTextBoxColumn
            // 
            sumAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumAdvanceSalary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "Advance Salary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Name = "sumAdvanceSalaryDataGridViewTextBoxColumn";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Width = 172;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            totalSalaryDataGridViewTextBoxColumn.HeaderText = "Total Salary";
            totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            totalSalaryDataGridViewTextBoxColumn.Width = 136;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            taxDataGridViewTextBoxColumn.Width = 65;
            // 
            // salaryAfterTaxDataGridViewTextBoxColumn
            // 
            salaryAfterTaxDataGridViewTextBoxColumn.DataPropertyName = "SalaryAfterTax";
            salaryAfterTaxDataGridViewTextBoxColumn.HeaderText = "Salary Final (-Tax)";
            salaryAfterTaxDataGridViewTextBoxColumn.Name = "salaryAfterTaxDataGridViewTextBoxColumn";
            salaryAfterTaxDataGridViewTextBoxColumn.Width = 188;
            // 
            // DateOmonth
            // 
            DateOmonth.DataPropertyName = "DateOmonth";
            DateOmonth.HeaderText = "Date";
            DateOmonth.Name = "DateOmonth";
            DateOmonth.Width = 79;
            // 
            // frmSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1231, 543);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtSave);
            Name = "frmSalaryDetail";
            Text = "frmSalaryDetail";
            Load += frmSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSalary;
        private DateTimePicker dtpTime;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private BindingSource salaryBindingSource;
        private Button btFilter;
        private ComboBox cbName;
        private Button btSearch;
        private Button btReset;
        private Button btExport;
        private NumericUpDown nmPaging;
        private Label txtSave;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn idSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryHourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumAdvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryAfterTaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DateOmonth;
    }
}