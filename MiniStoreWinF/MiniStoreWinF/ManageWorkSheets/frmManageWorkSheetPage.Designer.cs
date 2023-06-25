﻿namespace MiniStoreWinF.ManageWorkSheet
{
    partial class frmManageWorkSheetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWorkSheetPage));
            tabManageWorkSheet = new TabControl();
            tabWorkSheetHistory = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            btBackList = new Button();
            btNextList = new Button();
            btLoadDayWorkSheet = new Button();
            dateEnd = new DateTimePicker();
            button1 = new Button();
            dateStart = new DateTimePicker();
            btSearch = new Button();
            panel3 = new Panel();
            dgvShowWorkSheet = new DataGridView();
            idWorkSheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workSheetBindingSource = new BindingSource(components);
            panel1 = new Panel();
            txtTimeCheckOut = new TextBox();
            label12 = new Label();
            txtTimeCheckIn = new TextBox();
            label11 = new Label();
            txtIdWorkSheet = new TextBox();
            btReset = new Button();
            txtIdEmployees = new TextBox();
            cbSheet = new ComboBox();
            btUpdateWorkSheet = new Button();
            txtDateWorkSheet = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            tabDetailWorkSheet = new TabPage();
            panel5 = new Panel();
            dgvDetailWorksheet = new DataGridView();
            sheetDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            shiftStartTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shiftEndTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coefficientsSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDetailBindingSource = new BindingSource(components);
            panel4 = new Panel();
            txtCoefficientsSalaryDetails = new NumericUpDown();
            btCreate = new Button();
            label9 = new Label();
            btUpdateDetailsWorkSheet = new Button();
            txtDescriptionsDetails = new TextBox();
            txtEndDetails = new TextBox();
            txtStartDetails = new TextBox();
            txtSheetDetail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbMamageWorksheet = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            comboBox1 = new ComboBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            tabManageWorkSheet.SuspendLayout();
            tabWorkSheetHistory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            panel1.SuspendLayout();
            tabDetailWorkSheet.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tabManageWorkSheet
            // 
            tabManageWorkSheet.Controls.Add(tabWorkSheetHistory);
            tabManageWorkSheet.Controls.Add(tabDetailWorkSheet);
            tabManageWorkSheet.Controls.Add(tbMamageWorksheet);
            tabManageWorkSheet.Dock = DockStyle.Fill;
            tabManageWorkSheet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabManageWorkSheet.Location = new Point(0, 0);
            tabManageWorkSheet.Multiline = true;
            tabManageWorkSheet.Name = "tabManageWorkSheet";
            tabManageWorkSheet.RightToLeft = RightToLeft.No;
            tabManageWorkSheet.SelectedIndex = 0;
            tabManageWorkSheet.Size = new Size(1397, 580);
            tabManageWorkSheet.TabIndex = 0;
            // 
            // tabWorkSheetHistory
            // 
            tabWorkSheetHistory.Controls.Add(tableLayoutPanel1);
            tabWorkSheetHistory.Location = new Point(4, 32);
            tabWorkSheetHistory.Name = "tabWorkSheetHistory";
            tabWorkSheetHistory.Padding = new Padding(3);
            tabWorkSheetHistory.Size = new Size(1389, 544);
            tabWorkSheetHistory.TabIndex = 1;
            tabWorkSheetHistory.Text = "History WorkSheet";
            tabWorkSheetHistory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1383, 538);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(417, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(963, 532);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btLoadDayWorkSheet);
            panel2.Controls.Add(dateEnd);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateStart);
            panel2.Controls.Add(btSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 100);
            panel2.TabIndex = 17;
            // 
            // btBackList
            // 
            btBackList.Image = (Image)resources.GetObject("btBackList.Image");
            btBackList.Location = new Point(355, 14);
            btBackList.Name = "btBackList";
            btBackList.Size = new Size(96, 29);
            btBackList.TabIndex = 13;
            btBackList.UseVisualStyleBackColor = true;
            btBackList.Click += btBackList_Click;
            // 
            // btNextList
            // 
            btNextList.Image = (Image)resources.GetObject("btNextList.Image");
            btNextList.Location = new Point(478, 14);
            btNextList.Name = "btNextList";
            btNextList.Size = new Size(96, 29);
            btNextList.TabIndex = 14;
            btNextList.UseVisualStyleBackColor = true;
            btNextList.Click += btNextList_Click;
            // 
            // btLoadDayWorkSheet
            // 
            btLoadDayWorkSheet.Location = new Point(342, 18);
            btLoadDayWorkSheet.Name = "btLoadDayWorkSheet";
            btLoadDayWorkSheet.Size = new Size(94, 41);
            btLoadDayWorkSheet.TabIndex = 11;
            btLoadDayWorkSheet.Text = "Load";
            btLoadDayWorkSheet.UseVisualStyleBackColor = true;
            btLoadDayWorkSheet.Click += btLoadDayWorkSheet_Click;
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(140, 48);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(187, 30);
            dateEnd.TabIndex = 6;
            dateEnd.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(16, 48);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 5;
            button1.Text = "To date :";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(140, 12);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(187, 30);
            dateStart.TabIndex = 4;
            dateStart.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // btSearch
            // 
            btSearch.Location = new Point(16, 10);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(118, 30);
            btSearch.TabIndex = 3;
            btSearch.Text = "From date :";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(957, 420);
            panel3.TabIndex = 18;
            // 
            // dgvShowWorkSheet
            // 
            dgvShowWorkSheet.AutoGenerateColumns = false;
            dgvShowWorkSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowWorkSheet.Columns.AddRange(new DataGridViewColumn[] { idWorkSheetDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn });
            dgvShowWorkSheet.DataSource = workSheetBindingSource;
            dgvShowWorkSheet.Dock = DockStyle.Fill;
            dgvShowWorkSheet.Location = new Point(3, 3);
            dgvShowWorkSheet.Name = "dgvShowWorkSheet";
            dgvShowWorkSheet.RowHeadersWidth = 51;
            dgvShowWorkSheet.RowTemplate.Height = 29;
            dgvShowWorkSheet.Size = new Size(951, 351);
            dgvShowWorkSheet.TabIndex = 12;
            dgvShowWorkSheet.CellMouseDoubleClick += dgvShowWorkSheet_CellMouseDoubleClick_1;
            // 
            // idWorkSheetDataGridViewTextBoxColumn
            // 
            idWorkSheetDataGridViewTextBoxColumn.DataPropertyName = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.HeaderText = "Work Sheet ID";
            idWorkSheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            idWorkSheetDataGridViewTextBoxColumn.Name = "idWorkSheetDataGridViewTextBoxColumn";
            idWorkSheetDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Emp";
            idEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 130;
            // 
            // sheetDataGridViewTextBoxColumn
            // 
            sheetDataGridViewTextBoxColumn.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn.Name = "sheetDataGridViewTextBoxColumn";
            sheetDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeCheckInDataGridViewTextBoxColumn
            // 
            timeCheckInDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckInDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckIn";
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "Time Check-In";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "Time Check-Out";
            timeCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckOutDataGridViewTextBoxColumn.Name = "timeCheckOutDataGridViewTextBoxColumn";
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimeCheckOut);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtTimeCheckIn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtIdWorkSheet);
            panel1.Controls.Add(btReset);
            panel1.Controls.Add(txtIdEmployees);
            panel1.Controls.Add(cbSheet);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btUpdateWorkSheet);
            panel1.Controls.Add(txtDateWorkSheet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 532);
            panel1.TabIndex = 16;
            // 
            // txtTimeCheckOut
            // 
            txtTimeCheckOut.Location = new Point(187, 299);
            txtTimeCheckOut.Name = "txtTimeCheckOut";
            txtTimeCheckOut.ReadOnly = true;
            txtTimeCheckOut.Size = new Size(198, 30);
            txtTimeCheckOut.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 304);
            label12.Name = "label12";
            label12.Size = new Size(139, 23);
            label12.TabIndex = 19;
            label12.Text = "Time Check-Out";
            // 
            // txtTimeCheckIn
            // 
            txtTimeCheckIn.Location = new Point(187, 243);
            txtTimeCheckIn.Name = "txtTimeCheckIn";
            txtTimeCheckIn.ReadOnly = true;
            txtTimeCheckIn.Size = new Size(198, 30);
            txtTimeCheckIn.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 249);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 17;
            label11.Text = "Time Check-In";
            // 
            // txtIdWorkSheet
            // 
            txtIdWorkSheet.Location = new Point(187, 18);
            txtIdWorkSheet.Name = "txtIdWorkSheet";
            txtIdWorkSheet.ReadOnly = true;
            txtIdWorkSheet.Size = new Size(198, 30);
            txtIdWorkSheet.TabIndex = 2;
            // 
            // btReset
            // 
            btReset.Location = new Point(216, 404);
            btReset.Name = "btReset";
            btReset.Size = new Size(169, 41);
            btReset.TabIndex = 15;
            btReset.Text = "Show All History";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // txtIdEmployees
            // 
            txtIdEmployees.Location = new Point(187, 73);
            txtIdEmployees.Name = "txtIdEmployees";
            txtIdEmployees.ReadOnly = true;
            txtIdEmployees.Size = new Size(198, 30);
            txtIdEmployees.TabIndex = 14;
            // 
            // cbSheet
            // 
            cbSheet.FormattingEnabled = true;
            cbSheet.Location = new Point(187, 186);
            cbSheet.Name = "cbSheet";
            cbSheet.Size = new Size(91, 31);
            cbSheet.TabIndex = 13;
            // 
            // btUpdateWorkSheet
            // 
            btUpdateWorkSheet.Location = new Point(291, 341);
            btUpdateWorkSheet.Name = "btUpdateWorkSheet";
            btUpdateWorkSheet.Size = new Size(94, 41);
            btUpdateWorkSheet.TabIndex = 10;
            btUpdateWorkSheet.Text = "Update";
            btUpdateWorkSheet.UseVisualStyleBackColor = true;
            btUpdateWorkSheet.Click += btUpdateWorkSheet_Click;
            // 
            // txtDateWorkSheet
            // 
            txtDateWorkSheet.Location = new Point(187, 130);
            txtDateWorkSheet.Name = "txtDateWorkSheet";
            txtDateWorkSheet.ReadOnly = true;
            txtDateWorkSheet.Size = new Size(198, 30);
            txtDateWorkSheet.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 193);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 9;
            label4.Text = "Sheet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 80);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 7;
            label2.Text = "ID Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 123);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 6;
            label1.Text = "ID WorkSheet";
            // 
            // tabDetailWorkSheet
            // 
            tabDetailWorkSheet.Controls.Add(panel5);
            tabDetailWorkSheet.Controls.Add(panel4);
            tabDetailWorkSheet.Location = new Point(4, 32);
            tabDetailWorkSheet.Name = "tabDetailWorkSheet";
            tabDetailWorkSheet.Padding = new Padding(3);
            tabDetailWorkSheet.Size = new Size(1389, 544);
            tabDetailWorkSheet.TabIndex = 2;
            tabDetailWorkSheet.Text = "Worksheet Defaut";
            tabDetailWorkSheet.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvDetailWorksheet);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(923, 538);
            panel5.TabIndex = 21;
            // 
            // dgvDetailWorksheet
            // 
            dgvDetailWorksheet.AutoGenerateColumns = false;
            dgvDetailWorksheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailWorksheet.Columns.AddRange(new DataGridViewColumn[] { sheetDataGridViewTextBoxColumn1, shiftStartTimeDataGridViewTextBoxColumn, shiftEndTimeDataGridViewTextBoxColumn, descriptionSDataGridViewTextBoxColumn, coefficientsSalaryDataGridViewTextBoxColumn });
            dgvDetailWorksheet.DataSource = sheetDetailBindingSource;
            dgvDetailWorksheet.Dock = DockStyle.Fill;
            dgvDetailWorksheet.Location = new Point(0, 0);
            dgvDetailWorksheet.Name = "dgvDetailWorksheet";
            dgvDetailWorksheet.RowHeadersWidth = 51;
            dgvDetailWorksheet.RowTemplate.Height = 29;
            dgvDetailWorksheet.Size = new Size(923, 538);
            dgvDetailWorksheet.TabIndex = 1;
            dgvDetailWorksheet.CellMouseDoubleClick += dgvDetailWorksheet_CellMouseDoubleClick_1;
            // 
            // sheetDataGridViewTextBoxColumn1
            // 
            sheetDataGridViewTextBoxColumn1.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn1.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn1.Name = "sheetDataGridViewTextBoxColumn1";
            sheetDataGridViewTextBoxColumn1.Width = 125;
            // 
            // shiftStartTimeDataGridViewTextBoxColumn
            // 
            shiftStartTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shiftStartTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftStartTime";
            shiftStartTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            shiftStartTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            shiftStartTimeDataGridViewTextBoxColumn.Name = "shiftStartTimeDataGridViewTextBoxColumn";
            // 
            // shiftEndTimeDataGridViewTextBoxColumn
            // 
            shiftEndTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shiftEndTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftEndTime";
            shiftEndTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            shiftEndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            shiftEndTimeDataGridViewTextBoxColumn.Name = "shiftEndTimeDataGridViewTextBoxColumn";
            // 
            // descriptionSDataGridViewTextBoxColumn
            // 
            descriptionSDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionSDataGridViewTextBoxColumn.DataPropertyName = "DescriptionS";
            descriptionSDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionSDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionSDataGridViewTextBoxColumn.Name = "descriptionSDataGridViewTextBoxColumn";
            // 
            // coefficientsSalaryDataGridViewTextBoxColumn
            // 
            coefficientsSalaryDataGridViewTextBoxColumn.DataPropertyName = "CoefficientsSalary";
            coefficientsSalaryDataGridViewTextBoxColumn.HeaderText = "Coefficients Salary";
            coefficientsSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            coefficientsSalaryDataGridViewTextBoxColumn.Name = "coefficientsSalaryDataGridViewTextBoxColumn";
            coefficientsSalaryDataGridViewTextBoxColumn.Width = 120;
            // 
            // sheetDetailBindingSource
            // 
            sheetDetailBindingSource.DataSource = typeof(Repository.Models.SheetDetail);
            // 
            // panel4
            // 
            panel4.Controls.Add(txtCoefficientsSalaryDetails);
            panel4.Controls.Add(btCreate);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btUpdateDetailsWorkSheet);
            panel4.Controls.Add(txtDescriptionsDetails);
            panel4.Controls.Add(txtEndDetails);
            panel4.Controls.Add(txtStartDetails);
            panel4.Controls.Add(txtSheetDetail);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(926, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 538);
            panel4.TabIndex = 20;
            // 
            // txtCoefficientsSalaryDetails
            // 
            txtCoefficientsSalaryDetails.DecimalPlaces = 1;
            txtCoefficientsSalaryDetails.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            txtCoefficientsSalaryDetails.Location = new Point(172, 295);
            txtCoefficientsSalaryDetails.Name = "txtCoefficientsSalaryDetails";
            txtCoefficientsSalaryDetails.Size = new Size(196, 30);
            txtCoefficientsSalaryDetails.TabIndex = 32;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(160, 394);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 41);
            btCreate.TabIndex = 31;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // label9
            // 
            label9.Location = new Point(35, 278);
            label9.Name = "label9";
            label9.Size = new Size(113, 47);
            label9.TabIndex = 30;
            label9.Text = "Coefficients salary";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btUpdateDetailsWorkSheet
            // 
            btUpdateDetailsWorkSheet.Location = new Point(274, 394);
            btUpdateDetailsWorkSheet.Name = "btUpdateDetailsWorkSheet";
            btUpdateDetailsWorkSheet.Size = new Size(94, 41);
            btUpdateDetailsWorkSheet.TabIndex = 29;
            btUpdateDetailsWorkSheet.Text = "Update";
            btUpdateDetailsWorkSheet.UseVisualStyleBackColor = true;
            btUpdateDetailsWorkSheet.Click += btUpdateDetailsWorkSheet_Click_1;
            // 
            // txtDescriptionsDetails
            // 
            txtDescriptionsDetails.Location = new Point(172, 206);
            txtDescriptionsDetails.Multiline = true;
            txtDescriptionsDetails.Name = "txtDescriptionsDetails";
            txtDescriptionsDetails.Size = new Size(196, 62);
            txtDescriptionsDetails.TabIndex = 27;
            // 
            // txtEndDetails
            // 
            txtEndDetails.Location = new Point(172, 150);
            txtEndDetails.Name = "txtEndDetails";
            txtEndDetails.Size = new Size(196, 30);
            txtEndDetails.TabIndex = 26;
            txtEndDetails.Leave += txtEndDetails_Leave;
            // 
            // txtStartDetails
            // 
            txtStartDetails.Location = new Point(172, 94);
            txtStartDetails.Name = "txtStartDetails";
            txtStartDetails.Size = new Size(196, 30);
            txtStartDetails.TabIndex = 25;
            txtStartDetails.Leave += txtStartDetails_Leave;
            // 
            // txtSheetDetail
            // 
            txtSheetDetail.Location = new Point(172, 38);
            txtSheetDetail.Name = "txtSheetDetail";
            txtSheetDetail.Size = new Size(196, 30);
            txtSheetDetail.TabIndex = 24;
            txtSheetDetail.KeyPress += txtSheetDetail_KeyPress;
            // 
            // label8
            // 
            label8.Location = new Point(39, 154);
            label8.Name = "label8";
            label8.Size = new Size(113, 47);
            label8.TabIndex = 23;
            label8.Text = "Time End";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(39, 92);
            label7.Name = "label7";
            label7.Size = new Size(113, 47);
            label7.TabIndex = 22;
            label7.Text = "Time Start";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(39, 30);
            label6.Name = "label6";
            label6.Size = new Size(113, 47);
            label6.TabIndex = 21;
            label6.Text = "Sheet";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(39, 216);
            label5.Name = "label5";
            label5.Size = new Size(113, 47);
            label5.TabIndex = 20;
            label5.Text = "Descriptions";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbMamageWorksheet
            // 
            tbMamageWorksheet.Location = new Point(4, 32);
            tbMamageWorksheet.Name = "tbMamageWorksheet";
            tbMamageWorksheet.Padding = new Padding(3);
            tbMamageWorksheet.Size = new Size(1389, 544);
            tbMamageWorksheet.TabIndex = 3;
            tbMamageWorksheet.Text = "Manage Worksheet";
            tbMamageWorksheet.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel6, 0, 1);
            tableLayoutPanel3.Controls.Add(dgvShowWorkSheet, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(957, 420);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Controls.Add(btBackList);
            panel6.Controls.Add(btNextList);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 360);
            panel6.Name = "panel6";
            panel6.Size = new Size(951, 57);
            panel6.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(606, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 31);
            comboBox1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 5);
            label10.Name = "label10";
            label10.Size = new Size(55, 23);
            label10.TabIndex = 14;
            label10.Text = "Sheet";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(606, 48);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(198, 30);
            textBox1.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(532, 48);
            label13.Name = "label13";
            label13.Size = new Size(67, 23);
            label13.TabIndex = 16;
            label13.Text = "Name :";
            // 
            // frmManageWorkSheetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 580);
            Controls.Add(tabManageWorkSheet);
            Name = "frmManageWorkSheetPage";
            Text = "ManageWorkSheetPage";
            tabManageWorkSheet.ResumeLayout(false);
            tabWorkSheetHistory.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabDetailWorkSheet.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabManageWorkSheet;
        private TabPage tabWorkSheetHistory;
        private Button btUpdateWorkSheet;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDateWorkSheet;
        private TextBox txtIdWorkSheet;
        private ComboBox cbSheet;
        private TextBox txtIdEmployees;
        private Button btReset;
        private TabPage tabDetailWorkSheet;
        private Label label10;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btSearch;
        private Button btLoadDayWorkSheet;
        private DateTimePicker dateEnd;
        private Button button1;
        private DateTimePicker dateStart;
        private DataGridView dgvShowWorkSheet;
        private Panel panel4;
        private Label label9;
        private Button btUpdateDetailsWorkSheet;
        private TextBox txtDescriptionsDetails;
        private TextBox txtEndDetails;
        private TextBox txtStartDetails;
        private TextBox txtSheetDetail;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private DataGridView dgvDetailWorksheet;
        private BindingSource workSheetBindingSource;
        private Button btNextList;
        private Button btBackList;
        private BindingSource sheetDetailBindingSource;
        private TextBox txtTimeCheckOut;
        private Label label12;
        private TextBox txtTimeCheckIn;
        private Label label11;
        private Button btCreate;
        private NumericUpDown txtCoefficientsSalaryDetails;
        private DataGridViewTextBoxColumn idWorkSheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn shiftStartTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftEndTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coefficientsSalaryDataGridViewTextBoxColumn;
        private TabPage tbMamageWorksheet;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label13;
    }
}