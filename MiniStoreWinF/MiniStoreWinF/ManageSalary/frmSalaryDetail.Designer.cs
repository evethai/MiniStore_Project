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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            btReset = new Button();
            btExport = new Button();
            panel2 = new Panel();
            cbOrderby = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            txtS = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel1 = new Panel();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSalary
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSalary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalary.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { idSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, salaryHourDataGridViewTextBoxColumn, basicSalaryDataGridViewTextBoxColumn, sumSubSalaryDataGridViewTextBoxColumn, sumAdvanceSalaryDataGridViewTextBoxColumn, totalSalaryDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, salaryAfterTaxDataGridViewTextBoxColumn, DateOmonth });
            dgvSalary.DataSource = salaryBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(0, 0, 24, 0);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvSalary.DefaultCellStyle = dataGridViewCellStyle10;
            dgvSalary.Dock = DockStyle.Fill;
            dgvSalary.Location = new Point(0, 0);
            dgvSalary.Margin = new Padding(4);
            dgvSalary.Name = "dgvSalary";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Padding = new Padding(0, 0, 0, 50);
            dgvSalary.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvSalary.RowTemplate.Height = 27;
            dgvSalary.Size = new Size(1229, 395);
            dgvSalary.TabIndex = 0;
            dgvSalary.CellMouseDoubleClick += dgvSalary_CellMouseDoubleClick;
            dgvSalary.CellMouseEnter += dgvSalary_CellMouseEnter;
            // 
            // idSalaryDataGridViewTextBoxColumn
            // 
            idSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdSalary";
            idSalaryDataGridViewTextBoxColumn.HeaderText = "Id";
            idSalaryDataGridViewTextBoxColumn.Name = "idSalaryDataGridViewTextBoxColumn";
            idSalaryDataGridViewTextBoxColumn.Width = 77;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idEmpDataGridViewTextBoxColumn.Width = 152;
            // 
            // salaryHourDataGridViewTextBoxColumn
            // 
            salaryHourDataGridViewTextBoxColumn.DataPropertyName = "SalaryHour";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            salaryHourDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            salaryHourDataGridViewTextBoxColumn.HeaderText = "Salary In Hour";
            salaryHourDataGridViewTextBoxColumn.Name = "salaryHourDataGridViewTextBoxColumn";
            salaryHourDataGridViewTextBoxColumn.Width = 129;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            basicSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            basicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary";
            basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            basicSalaryDataGridViewTextBoxColumn.Width = 148;
            // 
            // sumSubSalaryDataGridViewTextBoxColumn
            // 
            sumSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumSubSalary";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            sumSubSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            sumSubSalaryDataGridViewTextBoxColumn.HeaderText = "Allowance";
            sumSubSalaryDataGridViewTextBoxColumn.Name = "sumSubSalaryDataGridViewTextBoxColumn";
            sumSubSalaryDataGridViewTextBoxColumn.Width = 148;
            // 
            // sumAdvanceSalaryDataGridViewTextBoxColumn
            // 
            sumAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "SumAdvanceSalary";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            sumAdvanceSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            sumAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "Advance Salary";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Name = "sumAdvanceSalaryDataGridViewTextBoxColumn";
            sumAdvanceSalaryDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            totalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            totalSalaryDataGridViewTextBoxColumn.HeaderText = "Total Salary";
            totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            totalSalaryDataGridViewTextBoxColumn.Width = 146;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            taxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            taxDataGridViewTextBoxColumn.Width = 88;
            // 
            // salaryAfterTaxDataGridViewTextBoxColumn
            // 
            salaryAfterTaxDataGridViewTextBoxColumn.DataPropertyName = "SalaryAfterTax";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            salaryAfterTaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            salaryAfterTaxDataGridViewTextBoxColumn.HeaderText = "Salary Final (-Tax)";
            salaryAfterTaxDataGridViewTextBoxColumn.Name = "salaryAfterTaxDataGridViewTextBoxColumn";
            salaryAfterTaxDataGridViewTextBoxColumn.Width = 193;
            // 
            // DateOmonth
            // 
            DateOmonth.DataPropertyName = "DateOmonth";
            DateOmonth.HeaderText = "Date";
            DateOmonth.Name = "DateOmonth";
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
            dtpTime.Size = new Size(178, 33);
            dtpTime.TabIndex = 1;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(624, 8);
            btFilter.Margin = new Padding(4);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(71, 34);
            btFilter.TabIndex = 3;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Items.AddRange(new object[] { "ALL" });
            cbName.Location = new Point(198, 9);
            cbName.Margin = new Padding(4);
            cbName.Name = "cbName";
            cbName.Size = new Size(277, 33);
            cbName.TabIndex = 10;
            cbName.Text = "ALL";
            // 
            // btReset
            // 
            btReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btReset.Location = new Point(970, 12);
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
            btExport.Location = new Point(1095, 12);
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
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cbOrderby);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(cbName);
            panel2.Controls.Add(txtS);
            panel2.Controls.Add(btExport);
            panel2.Controls.Add(dtpTime);
            panel2.Controls.Add(btReset);
            panel2.Controls.Add(btFilter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1229, 96);
            panel2.TabIndex = 16;
            // 
            // cbOrderby
            // 
            cbOrderby.FormattingEnabled = true;
            cbOrderby.Items.AddRange(new object[] { "Descending", "Ascending" });
            cbOrderby.Location = new Point(482, 8);
            cbOrderby.Name = "cbOrderby";
            cbOrderby.Size = new Size(121, 33);
            cbOrderby.TabIndex = 18;
            cbOrderby.Text = "Descending";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(891, 15);
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
            txtS.Location = new Point(528, 375);
            txtS.Name = "txtS";
            txtS.Size = new Size(100, 33);
            txtS.TabIndex = 17;
            txtS.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1235, 501);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dgvSalary);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(1229, 395);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 343);
            panel1.MaximumSize = new Size(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 52);
            panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(0, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(1229, 52);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "label1";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1235, 501);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmSalaryDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalaryDetail";
            Load += frmSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSalary;
        private DateTimePicker dtpTime;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private BindingSource salaryBindingSource;
        private Button btFilter;
        private ComboBox cbName;
        private Button btReset;
        private Button btExport;
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private TextBox txtS;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
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
        private ComboBox cbOrderby;
        private Panel panel1;
        private Label lblTotal;
    }
}