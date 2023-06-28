namespace MiniStoreWinF.ManageWorkSheet
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
            btLoad = new Button();
            dateEnd = new DateTimePicker();
            bttodate = new Button();
            dateStart = new DateTimePicker();
            btformdate = new Button();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            btBackList = new Button();
            btNextList = new Button();
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
            label2 = new Label();
            btUpdateWorkSheet = new Button();
            txtDateWorkSheet = new TextBox();
            label4 = new Label();
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
            panel9 = new Panel();
            txtCoefficientsSalaryDetails = new NumericUpDown();
            txtStartDetails = new TextBox();
            btCreate = new Button();
            label5 = new Label();
            label9 = new Label();
            label6 = new Label();
            btUpdateDetailsWorkSheet = new Button();
            label7 = new Label();
            txtDescriptionsDetails = new TextBox();
            label8 = new Label();
            txtEndDetails = new TextBox();
            txtSheetDetail = new TextBox();
            tbMamageWorksheet = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            pnlMatricDate = new Panel();
            panel8 = new Panel();
            btnNextMonth = new Button();
            btnMonthBack = new Button();
            btnSunday = new Button();
            btnFriday = new Button();
            btWednesday = new Button();
            btnSaturday = new Button();
            btnThursday = new Button();
            btnTuesday = new Button();
            btMonday = new Button();
            panel10 = new Panel();
            numericUpDown1 = new NumericUpDown();
            chbNotification = new CheckBox();
            btDateNow = new Button();
            dtpkDate = new DateTimePicker();
            tabManageWorkSheet.SuspendLayout();
            tabWorkSheetHistory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            panel1.SuspendLayout();
            tabDetailWorkSheet.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).BeginInit();
            tbMamageWorksheet.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            tabManageWorkSheet.Size = new Size(1397, 668);
            tabManageWorkSheet.TabIndex = 0;
            // 
            // tabWorkSheetHistory
            // 
            tabWorkSheetHistory.Controls.Add(tableLayoutPanel1);
            tabWorkSheetHistory.Location = new Point(4, 32);
            tabWorkSheetHistory.Name = "tabWorkSheetHistory";
            tabWorkSheetHistory.Padding = new Padding(3);
            tabWorkSheetHistory.Size = new Size(1389, 632);
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
            tableLayoutPanel1.Size = new Size(1383, 626);
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
            tableLayoutPanel2.Size = new Size(963, 620);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btLoad);
            panel2.Controls.Add(dateEnd);
            panel2.Controls.Add(bttodate);
            panel2.Controls.Add(dateStart);
            panel2.Controls.Add(btformdate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 118);
            panel2.TabIndex = 17;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(716, 27);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(94, 29);
            btLoad.TabIndex = 7;
            btLoad.Text = "LOAD";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(504, 27);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(187, 30);
            dateEnd.TabIndex = 6;
            dateEnd.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // bttodate
            // 
            bttodate.Location = new Point(364, 27);
            bttodate.Name = "bttodate";
            bttodate.Size = new Size(118, 30);
            bttodate.TabIndex = 5;
            bttodate.Text = "To date :";
            bttodate.UseVisualStyleBackColor = true;
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(146, 27);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(187, 30);
            dateStart.TabIndex = 4;
            dateStart.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // btformdate
            // 
            btformdate.Location = new Point(22, 27);
            btformdate.Name = "btformdate";
            btformdate.Size = new Size(118, 30);
            btformdate.TabIndex = 3;
            btformdate.Text = "From date :";
            btformdate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(957, 490);
            panel3.TabIndex = 18;
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
            tableLayoutPanel3.Size = new Size(957, 490);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Controls.Add(btBackList);
            panel6.Controls.Add(btNextList);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 419);
            panel6.Name = "panel6";
            panel6.Size = new Size(951, 68);
            panel6.TabIndex = 15;
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
            dgvShowWorkSheet.Size = new Size(951, 410);
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
            panel1.Size = new Size(408, 620);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 80);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 7;
            label2.Text = "ID Employees";
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
            tabDetailWorkSheet.Size = new Size(1389, 632);
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
            panel5.Size = new Size(923, 626);
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
            dgvDetailWorksheet.Size = new Size(923, 626);
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
            panel4.Controls.Add(panel9);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(926, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 626);
            panel4.TabIndex = 20;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtCoefficientsSalaryDetails);
            panel9.Controls.Add(txtStartDetails);
            panel9.Controls.Add(btCreate);
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(btUpdateDetailsWorkSheet);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(txtDescriptionsDetails);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(txtEndDetails);
            panel9.Controls.Add(txtSheetDetail);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(460, 626);
            panel9.TabIndex = 33;
            // 
            // txtCoefficientsSalaryDetails
            // 
            txtCoefficientsSalaryDetails.DecimalPlaces = 1;
            txtCoefficientsSalaryDetails.Location = new Point(176, 284);
            txtCoefficientsSalaryDetails.Name = "txtCoefficientsSalaryDetails";
            txtCoefficientsSalaryDetails.Size = new Size(156, 30);
            txtCoefficientsSalaryDetails.TabIndex = 32;
            // 
            // txtStartDetails
            // 
            txtStartDetails.Location = new Point(164, 90);
            txtStartDetails.Name = "txtStartDetails";
            txtStartDetails.Size = new Size(196, 30);
            txtStartDetails.TabIndex = 25;
            txtStartDetails.Leave += txtStartDetails_Leave;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(152, 390);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 41);
            btCreate.TabIndex = 31;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // label5
            // 
            label5.Location = new Point(31, 212);
            label5.Name = "label5";
            label5.Size = new Size(113, 47);
            label5.TabIndex = 20;
            label5.Text = "Descriptions";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(27, 274);
            label9.Name = "label9";
            label9.Size = new Size(113, 47);
            label9.TabIndex = 30;
            label9.Text = "Coefficients salary";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(31, 26);
            label6.Name = "label6";
            label6.Size = new Size(113, 47);
            label6.TabIndex = 21;
            label6.Text = "Sheet";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btUpdateDetailsWorkSheet
            // 
            btUpdateDetailsWorkSheet.Location = new Point(266, 390);
            btUpdateDetailsWorkSheet.Name = "btUpdateDetailsWorkSheet";
            btUpdateDetailsWorkSheet.Size = new Size(94, 41);
            btUpdateDetailsWorkSheet.TabIndex = 29;
            btUpdateDetailsWorkSheet.Text = "Update";
            btUpdateDetailsWorkSheet.UseVisualStyleBackColor = true;
            btUpdateDetailsWorkSheet.Click += btUpdateDetailsWorkSheet_Click_1;
            // 
            // label7
            // 
            label7.Location = new Point(31, 88);
            label7.Name = "label7";
            label7.Size = new Size(113, 47);
            label7.TabIndex = 22;
            label7.Text = "Time Start";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescriptionsDetails
            // 
            txtDescriptionsDetails.Location = new Point(164, 202);
            txtDescriptionsDetails.Multiline = true;
            txtDescriptionsDetails.Name = "txtDescriptionsDetails";
            txtDescriptionsDetails.Size = new Size(196, 62);
            txtDescriptionsDetails.TabIndex = 27;
            // 
            // label8
            // 
            label8.Location = new Point(31, 150);
            label8.Name = "label8";
            label8.Size = new Size(113, 47);
            label8.TabIndex = 23;
            label8.Text = "Time End";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEndDetails
            // 
            txtEndDetails.Location = new Point(164, 146);
            txtEndDetails.Name = "txtEndDetails";
            txtEndDetails.Size = new Size(196, 30);
            txtEndDetails.TabIndex = 26;
            txtEndDetails.Leave += txtEndDetails_Leave;
            // 
            // txtSheetDetail
            // 
            txtSheetDetail.Location = new Point(164, 34);
            txtSheetDetail.Name = "txtSheetDetail";
            txtSheetDetail.Size = new Size(196, 30);
            txtSheetDetail.TabIndex = 24;
            txtSheetDetail.KeyPress += txtSheetDetail_KeyPress;
            // 
            // tbMamageWorksheet
            // 
            tbMamageWorksheet.Controls.Add(tableLayoutPanel4);
            tbMamageWorksheet.Location = new Point(4, 32);
            tbMamageWorksheet.Name = "tbMamageWorksheet";
            tbMamageWorksheet.Padding = new Padding(3);
            tbMamageWorksheet.Size = new Size(1389, 632);
            tbMamageWorksheet.TabIndex = 3;
            tbMamageWorksheet.Text = "Manage Worksheet";
            tbMamageWorksheet.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel7, 0, 1);
            tableLayoutPanel4.Controls.Add(panel10, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5947952F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.4052048F));
            tableLayoutPanel4.Size = new Size(1383, 626);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(pnlMatricDate);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 69);
            panel7.Name = "panel7";
            panel7.Size = new Size(1377, 554);
            panel7.TabIndex = 0;
            // 
            // pnlMatricDate
            // 
            pnlMatricDate.Location = new Point(190, 83);
            pnlMatricDate.Name = "pnlMatricDate";
            pnlMatricDate.Size = new Size(948, 468);
            pnlMatricDate.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnNextMonth);
            panel8.Controls.Add(btnMonthBack);
            panel8.Controls.Add(btnSunday);
            panel8.Controls.Add(btnFriday);
            panel8.Controls.Add(btWednesday);
            panel8.Controls.Add(btnSaturday);
            panel8.Controls.Add(btnThursday);
            panel8.Controls.Add(btnTuesday);
            panel8.Controls.Add(btMonday);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1377, 77);
            panel8.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Location = new Point(1165, 20);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(135, 42);
            btnNextMonth.TabIndex = 8;
            btnNextMonth.Text = "Next month";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // btnMonthBack
            // 
            btnMonthBack.Location = new Point(34, 20);
            btnMonthBack.Name = "btnMonthBack";
            btnMonthBack.Size = new Size(135, 42);
            btnMonthBack.TabIndex = 7;
            btnMonthBack.Text = "Last month";
            btnMonthBack.UseVisualStyleBackColor = true;
            btnMonthBack.Click += btnMonthBack_Click;
            // 
            // btnSunday
            // 
            btnSunday.Location = new Point(998, 6);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(129, 71);
            btnSunday.TabIndex = 6;
            btnSunday.Text = "Sunday";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Location = new Point(730, 6);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(129, 71);
            btnFriday.TabIndex = 5;
            btnFriday.Text = "Friday";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btWednesday
            // 
            btWednesday.Location = new Point(460, 6);
            btWednesday.Name = "btWednesday";
            btWednesday.Size = new Size(129, 71);
            btWednesday.TabIndex = 4;
            btWednesday.Text = "Wednesday ";
            btWednesday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            btnSaturday.Location = new Point(863, 6);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(129, 71);
            btnSaturday.TabIndex = 3;
            btnSaturday.Text = "Saturday";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            btnThursday.Location = new Point(595, 6);
            btnThursday.Name = "btnThursday";
            btnThursday.Size = new Size(129, 71);
            btnThursday.TabIndex = 2;
            btnThursday.Text = "Thursday ";
            btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            btnTuesday.Location = new Point(325, 6);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(129, 71);
            btnTuesday.TabIndex = 1;
            btnTuesday.Text = "Tuesday";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btMonday
            // 
            btMonday.Location = new Point(190, 6);
            btMonday.Name = "btMonday";
            btMonday.Size = new Size(129, 71);
            btMonday.TabIndex = 0;
            btMonday.Text = "Monday";
            btMonday.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(numericUpDown1);
            panel10.Controls.Add(chbNotification);
            panel10.Controls.Add(btDateNow);
            panel10.Controls.Add(dtpkDate);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1377, 60);
            panel10.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(169, 10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 30);
            numericUpDown1.TabIndex = 3;
            // 
            // chbNotification
            // 
            chbNotification.AutoSize = true;
            chbNotification.Location = new Point(41, 10);
            chbNotification.Name = "chbNotification";
            chbNotification.Size = new Size(128, 27);
            chbNotification.TabIndex = 2;
            chbNotification.Text = "Notification";
            chbNotification.UseVisualStyleBackColor = true;
            // 
            // btDateNow
            // 
            btDateNow.Location = new Point(863, 10);
            btDateNow.Name = "btDateNow";
            btDateNow.Size = new Size(110, 36);
            btDateNow.TabIndex = 1;
            btDateNow.Text = "Date Now";
            btDateNow.UseVisualStyleBackColor = true;
            btDateNow.Click += btDateNow_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(536, 11);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(290, 30);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // frmManageWorkSheetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 668);
            Controls.Add(tabManageWorkSheet);
            Name = "frmManageWorkSheetPage";
            Text = "ManageWorkSheetPage";
            tabManageWorkSheet.ResumeLayout(false);
            tabWorkSheetHistory.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabDetailWorkSheet.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).EndInit();
            tbMamageWorksheet.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btformdate;
        private DateTimePicker dateEnd;
        private Button bttodate;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private TabPage tbMamageWorksheet;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel7;
        private Panel pnlMatricDate;
        private Panel panel8;
        private Panel panel10;
        private DateTimePicker dtpkDate;
        private Button btDateNow;
        private Button btnSunday;
        private Button btnFriday;
        private Button btWednesday;
        private Button btnSaturday;
        private Button btnThursday;
        private Button btnTuesday;
        private Button btMonday;
        private Button btnNextMonth;
        private Button btnMonthBack;
        private NumericUpDown numericUpDown1;
        private CheckBox chbNotification;
        private Button btLoad;
        private NumericUpDown txtCoefficientsSalaryDetails;
        private Panel panel9;
    }
}