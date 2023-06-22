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
            DateOmonth = new DataGridViewTextBoxColumn();
            salaryBindingSource = new BindingSource(components);
            dtpTime = new DateTimePicker();
            btFilter = new Button();
            cbName = new ComboBox();
            btSearch = new Button();
            btReset = new Button();
            btExport = new Button();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            txtS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvSalary
            // 
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSalary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { idSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, salaryHourDataGridViewTextBoxColumn, basicSalaryDataGridViewTextBoxColumn, sumSubSalaryDataGridViewTextBoxColumn, sumAdvanceSalaryDataGridViewTextBoxColumn, totalSalaryDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, salaryAfterTaxDataGridViewTextBoxColumn, DateOmonth });
            dgvSalary.DataSource = salaryBindingSource;
            dgvSalary.Location = new Point(20, 271);
            dgvSalary.Margin = new Padding(4);
            dgvSalary.Name = "dgvSalary";
            dgvSalary.RowTemplate.Height = 27;
            dgvSalary.Size = new Size(1252, 347);
            dgvSalary.TabIndex = 0;
            dgvSalary.CellMouseDoubleClick += dgvSalary_CellMouseDoubleClick;
            // 
            // idSalaryDataGridViewTextBoxColumn
            // 
            idSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdSalary";
            idSalaryDataGridViewTextBoxColumn.HeaderText = "Id";
            idSalaryDataGridViewTextBoxColumn.Name = "idSalaryDataGridViewTextBoxColumn";
            idSalaryDataGridViewTextBoxColumn.Width = 53;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 128;
            // 
            // salaryHourDataGridViewTextBoxColumn
            // 
            salaryHourDataGridViewTextBoxColumn.DataPropertyName = "SalaryHour";
            salaryHourDataGridViewTextBoxColumn.HeaderText = "Salary In Hour";
            salaryHourDataGridViewTextBoxColumn.Name = "salaryHourDataGridViewTextBoxColumn";
            salaryHourDataGridViewTextBoxColumn.Width = 105;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            basicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary";
            basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            basicSalaryDataGridViewTextBoxColumn.Width = 124;
            // 
            // sumSubSalaryDataGridViewTextBoxColumn
            // 
            sumSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumSubSalary";
            sumSubSalaryDataGridViewTextBoxColumn.HeaderText = "Allowance";
            sumSubSalaryDataGridViewTextBoxColumn.Name = "sumSubSalaryDataGridViewTextBoxColumn";
            sumSubSalaryDataGridViewTextBoxColumn.Width = 124;
            // 
            // sumAdvanceSalaryDataGridViewTextBoxColumn
            // 
            sumAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumAdvanceSalary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "Advance Salary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Name = "sumAdvanceSalaryDataGridViewTextBoxColumn";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Width = 151;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            totalSalaryDataGridViewTextBoxColumn.HeaderText = "Total Salary";
            totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            totalSalaryDataGridViewTextBoxColumn.Width = 122;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            taxDataGridViewTextBoxColumn.Width = 64;
            // 
            // salaryAfterTaxDataGridViewTextBoxColumn
            // 
            salaryAfterTaxDataGridViewTextBoxColumn.DataPropertyName = "SalaryAfterTax";
            salaryAfterTaxDataGridViewTextBoxColumn.HeaderText = "Salary Final (-Tax)";
            salaryAfterTaxDataGridViewTextBoxColumn.Name = "salaryAfterTaxDataGridViewTextBoxColumn";
            salaryAfterTaxDataGridViewTextBoxColumn.Width = 169;
            // 
            // DateOmonth
            // 
            DateOmonth.DataPropertyName = "DateOmonth";
            DateOmonth.HeaderText = "Date";
            DateOmonth.Name = "DateOmonth";
            DateOmonth.Width = 76;
            // 
            // salaryBindingSource
            // 
            salaryBindingSource.DataSource = typeof(Repository.Models.Salary);
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "MM/yyyy";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(12, 9);
            dtpTime.Margin = new Padding(4);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(277, 33);
            dtpTime.TabIndex = 1;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(319, 9);
            btFilter.Margin = new Padding(4);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(70, 37);
            btFilter.TabIndex = 3;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(12, 62);
            cbName.Margin = new Padding(4);
            cbName.Name = "cbName";
            cbName.Size = new Size(277, 33);
            cbName.TabIndex = 10;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(319, 59);
            btSearch.Margin = new Padding(4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(211, 37);
            btSearch.TabIndex = 9;
            btSearch.Text = "Search by Name";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btReset
            // 
            btReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btReset.Location = new Point(1634, 62);
            btReset.Margin = new Padding(4);
            btReset.Name = "btReset";
            btReset.Size = new Size(117, 35);
            btReset.TabIndex = 11;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btExport
            // 
            btExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExport.Location = new Point(1634, 12);
            btExport.Margin = new Padding(4);
            btExport.Name = "btExport";
            btExport.Size = new Size(117, 35);
            btExport.TabIndex = 12;
            btExport.Text = "Export";
            btExport.UseVisualStyleBackColor = true;
            btExport.Click += btExport_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbName);
            panel2.Controls.Add(btSearch);
            panel2.Controls.Add(btExport);
            panel2.Controls.Add(dtpTime);
            panel2.Controls.Add(btReset);
            panel2.Controls.Add(btFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1764, 229);
            panel2.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1208, 232);
            numericUpDown1.Margin = new Padding(11, 13, 11, 13);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 33);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += nmPaging_ValueChanged;
            // 
            // txtS
            // 
            txtS.Enabled = false;
            txtS.Location = new Point(878, 234);
            txtS.Name = "txtS";
            txtS.Size = new Size(100, 33);
            txtS.TabIndex = 17;
            txtS.Visible = false;
            // 
            // frmSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1764, 884);
            Controls.Add(txtS);
            Controls.Add(numericUpDown1);
            Controls.Add(dgvSalary);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSalaryDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalaryDetail";
            Load += frmSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private TextBox txtS;
    }
}