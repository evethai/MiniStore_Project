﻿namespace MiniStoreWinF.ManageSalary
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
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSalary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalary.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, idEmp, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, finalSalaryDataGridViewTextBoxColumn, dateImonthDataGridViewTextBoxColumn, dateOmonthDataGridViewTextBoxColumn });
            dgvSalary.DataSource = salaryBindingSource;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = SystemColors.Window;
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle25.Padding = new Padding(0, 0, 24, 0);
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.False;
            dgvSalary.DefaultCellStyle = dataGridViewCellStyle25;
            dgvSalary.Dock = DockStyle.Fill;
            dgvSalary.Location = new Point(0, 0);
            dgvSalary.Margin = new Padding(4);
            dgvSalary.Name = "dgvSalary";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Padding = new Padding(0, 0, 0, 50);
            dgvSalary.RowsDefaultCellStyle = dataGridViewCellStyle26;
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
            dataGridViewCellStyle16.Format = "#,###,###";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn3.HeaderText = "Salary by hour";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "SubSalary";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn4.HeaderText = "Sub salary";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "BasicSalary";
            dataGridViewCellStyle18.Format = "#,###,###";
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn5.HeaderText = "Basic salary";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DataPropertyName = "SalaryBeforTax";
            dataGridViewCellStyle19.Format = "#,###,###";
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn6.HeaderText = "Salary befor tax";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Tax";
            dataGridViewCellStyle20.NullValue = null;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn7.HeaderText = "Personal income tax";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "AdvSalary";
            dataGridViewCellStyle21.NullValue = null;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn8.HeaderText = "Advance salary";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // finalSalaryDataGridViewTextBoxColumn
            // 
            finalSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            finalSalaryDataGridViewTextBoxColumn.DataPropertyName = "FinalSalary";
            dataGridViewCellStyle22.Format = "#,###,###";
            finalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            finalSalaryDataGridViewTextBoxColumn.HeaderText = "Final salary";
            finalSalaryDataGridViewTextBoxColumn.Name = "finalSalaryDataGridViewTextBoxColumn";
            // 
            // dateImonthDataGridViewTextBoxColumn
            // 
            dateImonthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateImonthDataGridViewTextBoxColumn.DataPropertyName = "DateImonth";
            dataGridViewCellStyle23.Format = "D";
            dataGridViewCellStyle23.NullValue = null;
            dateImonthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            dateImonthDataGridViewTextBoxColumn.HeaderText = "Date in month";
            dateImonthDataGridViewTextBoxColumn.Name = "dateImonthDataGridViewTextBoxColumn";
            // 
            // dateOmonthDataGridViewTextBoxColumn
            // 
            dateOmonthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateOmonthDataGridViewTextBoxColumn.DataPropertyName = "DateOmonth";
            dataGridViewCellStyle24.Format = "D";
            dataGridViewCellStyle24.NullValue = null;
            dateOmonthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
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
            btReset.Location = new Point(1099, 10);
            btReset.Margin = new Padding(4);
            btReset.Name = "btReset";
            btReset.Size = new Size(117, 35);
            btReset.TabIndex = 11;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cbOrderby);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(cbName);
            panel2.Controls.Add(txtS);
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
            numericUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Location = new Point(15, 50);
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
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 343);
            panel1.MaximumSize = new Size(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 52);
            panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Location = new Point(0, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(1238, 52);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Salary to be paid this month for employees";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.ResumeLayout(false);
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
        private Label lblTotal;
    }
}