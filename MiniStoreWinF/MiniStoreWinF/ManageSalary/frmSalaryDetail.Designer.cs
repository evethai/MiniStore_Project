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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryDetail));
            dgvSalary = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idEmp = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            finalSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateImonthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOmonthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
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
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, idEmp, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, finalSalaryDataGridViewTextBoxColumn, dateImonthDataGridViewTextBoxColumn, dateOmonthDataGridViewTextBoxColumn });
            dgvSalary.DataSource = salaryBindingSource;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new Padding(0, 0, 24, 0);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvSalary.DefaultCellStyle = dataGridViewCellStyle12;
            dgvSalary.Dock = DockStyle.Fill;
            dgvSalary.Location = new Point(0, 0);
            dgvSalary.Margin = new Padding(4);
            dgvSalary.Name = "dgvSalary";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Padding = new Padding(0, 0, 0, 50);
            dgvSalary.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvSalary.RowTemplate.Height = 27;
            dgvSalary.Size = new Size(1238, 395);
            dgvSalary.TabIndex = 0;
            dgvSalary.CellFormatting += dgvSalary_CellFormatting;
            dgvSalary.CellMouseDoubleClick += dgvSalary_CellMouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSalary";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // idEmp
            // 
            idEmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmp.DataPropertyName = "IdEmp";
            idEmp.HeaderText = "Employee";
            idEmp.Name = "idEmp";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "SalaryByHour";
            dataGridViewCellStyle3.Format = "#,###,###";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn3.HeaderText = "Salary by hour";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "SubSalary";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn4.HeaderText = "Sub salary";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "BasicSalary";
            dataGridViewCellStyle5.Format = "#,###,###";
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn5.HeaderText = "Basic salary";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DataPropertyName = "SalaryBeforTax";
            dataGridViewCellStyle6.Format = "#,###,###";
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn6.HeaderText = "Salary befor tax";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Tax";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn7.HeaderText = "Personal income tax";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "AdvSalary";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn8.HeaderText = "Advance salary";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // finalSalaryDataGridViewTextBoxColumn
            // 
            finalSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            finalSalaryDataGridViewTextBoxColumn.DataPropertyName = "FinalSalary";
            dataGridViewCellStyle9.Format = "#,###,###";
            finalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            finalSalaryDataGridViewTextBoxColumn.HeaderText = "Final salary";
            finalSalaryDataGridViewTextBoxColumn.Name = "finalSalaryDataGridViewTextBoxColumn";
            // 
            // dateImonthDataGridViewTextBoxColumn
            // 
            dateImonthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateImonthDataGridViewTextBoxColumn.DataPropertyName = "DateImonth";
            dataGridViewCellStyle10.Format = "D";
            dataGridViewCellStyle10.NullValue = null;
            dateImonthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            dateImonthDataGridViewTextBoxColumn.HeaderText = "Date in month";
            dateImonthDataGridViewTextBoxColumn.Name = "dateImonthDataGridViewTextBoxColumn";
            // 
            // dateOmonthDataGridViewTextBoxColumn
            // 
            dateOmonthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateOmonthDataGridViewTextBoxColumn.DataPropertyName = "DateOmonth";
            dataGridViewCellStyle11.Format = "D";
            dataGridViewCellStyle11.NullValue = null;
            dateOmonthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            dateOmonthDataGridViewTextBoxColumn.HeaderText = "Date out month";
            dateOmonthDataGridViewTextBoxColumn.Name = "dateOmonthDataGridViewTextBoxColumn";
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
            btReset.Location = new Point(979, 12);
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
            btExport.Location = new Point(1104, 12);
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
            panel2.Size = new Size(1238, 96);
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
            numericUpDown1.Location = new Point(900, 15);
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
            tableLayoutPanel1.Size = new Size(1244, 501);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dgvSalary);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(1238, 395);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 343);
            panel1.MaximumSize = new Size(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 52);
            panel1.TabIndex = 1;
            // 
            // frmSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1244, 501);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSalary;
        private DateTimePicker dtpTime;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private Button btFilter;
        private ComboBox cbName;
        private Button btReset;
        private Button btExport;
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private TextBox txtS;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private DataGridViewTextBoxColumn salaryHourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumAdvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryAfterTaxDataGridViewTextBoxColumn;
        private ComboBox cbOrderby;
        private Panel panel1;
        private DataGridViewTextBoxColumn idSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryByHourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryBeforTaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn advSalaryDataGridViewTextBoxColumn;
        private BindingSource salaryBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idEmp;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn finalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateImonthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOmonthDataGridViewTextBoxColumn;
    }
}