﻿namespace MiniStoreWinF.ManageWorkSheet
{
    partial class ManageWorkSheetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWorkSheetPage));
            tabManageWorkSheet = new TabControl();
            tabUpdateWorkSheet = new TabPage();
            panel3 = new Panel();
            btNextList = new Button();
            btBackList = new Button();
            dgvShowWorkSheet = new DataGridView();
            idWorkSheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workSheetBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btLoadDayWorkSheet = new Button();
            dateEnd = new DateTimePicker();
            button1 = new Button();
            dateStart = new DateTimePicker();
            btSearch = new Button();
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
            label9 = new Label();
            btUpdateDetailsWorkSheet = new Button();
            txtCoefficientsSalaryDetails = new TextBox();
            txtDescriptionsDetails = new TextBox();
            txtEndDetails = new TextBox();
            txtStartDetails = new TextBox();
            txtSheetDetail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabManageWorkSheet.SuspendLayout();
            tabUpdateWorkSheet.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabDetailWorkSheet.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabManageWorkSheet
            // 
            tabManageWorkSheet.Controls.Add(tabUpdateWorkSheet);
            tabManageWorkSheet.Controls.Add(tabDetailWorkSheet);
            tabManageWorkSheet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabManageWorkSheet.Location = new Point(12, 57);
            tabManageWorkSheet.Multiline = true;
            tabManageWorkSheet.Name = "tabManageWorkSheet";
            tabManageWorkSheet.RightToLeft = RightToLeft.No;
            tabManageWorkSheet.SelectedIndex = 0;
            tabManageWorkSheet.Size = new Size(1380, 564);
            tabManageWorkSheet.TabIndex = 0;
            // 
            // tabUpdateWorkSheet
            // 
            tabUpdateWorkSheet.Controls.Add(panel3);
            tabUpdateWorkSheet.Controls.Add(panel2);
            tabUpdateWorkSheet.Controls.Add(panel1);
            tabUpdateWorkSheet.Location = new Point(4, 32);
            tabUpdateWorkSheet.Name = "tabUpdateWorkSheet";
            tabUpdateWorkSheet.Padding = new Padding(3);
            tabUpdateWorkSheet.Size = new Size(1372, 528);
            tabUpdateWorkSheet.TabIndex = 1;
            tabUpdateWorkSheet.Text = "History WorkSheet";
            tabUpdateWorkSheet.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btNextList);
            panel3.Controls.Add(btBackList);
            panel3.Controls.Add(dgvShowWorkSheet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(411, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(958, 431);
            panel3.TabIndex = 18;
            // 
            // btNextList
            // 
            btNextList.Image = (Image)resources.GetObject("btNextList.Image");
            btNextList.Location = new Point(492, 388);
            btNextList.Name = "btNextList";
            btNextList.Size = new Size(127, 29);
            btNextList.TabIndex = 14;
            btNextList.UseVisualStyleBackColor = true;
            btNextList.Click += btNextList_Click;
            // 
            // btBackList
            // 
            btBackList.Image = (Image)resources.GetObject("btBackList.Image");
            btBackList.Location = new Point(333, 388);
            btBackList.Name = "btBackList";
            btBackList.Size = new Size(127, 29);
            btBackList.TabIndex = 13;
            btBackList.UseVisualStyleBackColor = true;
            btBackList.Click += btBackList_Click;
            // 
            // dgvShowWorkSheet
            // 
            dgvShowWorkSheet.AutoGenerateColumns = false;
            dgvShowWorkSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowWorkSheet.Columns.AddRange(new DataGridViewColumn[] { idWorkSheetDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn });
            dgvShowWorkSheet.DataSource = workSheetBindingSource;
            dgvShowWorkSheet.Dock = DockStyle.Top;
            dgvShowWorkSheet.Location = new Point(0, 0);
            dgvShowWorkSheet.Name = "dgvShowWorkSheet";
            dgvShowWorkSheet.RowHeadersWidth = 51;
            dgvShowWorkSheet.RowTemplate.Height = 29;
            dgvShowWorkSheet.Size = new Size(958, 369);
            dgvShowWorkSheet.TabIndex = 12;
            dgvShowWorkSheet.CellMouseDoubleClick += dgvShowWorkSheet_CellMouseDoubleClick_1;
            // 
            // idWorkSheetDataGridViewTextBoxColumn
            // 
            idWorkSheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idWorkSheetDataGridViewTextBoxColumn.DataPropertyName = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.HeaderText = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            idWorkSheetDataGridViewTextBoxColumn.Name = "idWorkSheetDataGridViewTextBoxColumn";
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "IdEmp";
            idEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // sheetDataGridViewTextBoxColumn
            // 
            sheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sheetDataGridViewTextBoxColumn.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn.Name = "sheetDataGridViewTextBoxColumn";
            // 
            // timeCheckInDataGridViewTextBoxColumn
            // 
            timeCheckInDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckInDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckIn";
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "TimeCheckIn";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckOutDataGridViewTextBoxColumn.Name = "timeCheckOutDataGridViewTextBoxColumn";
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // panel2
            // 
            panel2.Controls.Add(btLoadDayWorkSheet);
            panel2.Controls.Add(dateEnd);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateStart);
            panel2.Controls.Add(btSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(411, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 91);
            panel2.TabIndex = 17;
            // 
            // btLoadDayWorkSheet
            // 
            btLoadDayWorkSheet.Location = new Point(366, 21);
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
            dateEnd.Value = new DateTime(2023, 5, 9, 14, 47, 0, 0);
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
            dateStart.Value = new DateTime(2023, 5, 9, 14, 47, 0, 0);
            // 
            // btSearch
            // 
            btSearch.Location = new Point(16, 12);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(118, 30);
            btSearch.TabIndex = 3;
            btSearch.Text = "From date :";
            btSearch.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(btUpdateWorkSheet);
            panel1.Controls.Add(txtDateWorkSheet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 522);
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
            btReset.Location = new Point(39, 378);
            btReset.Name = "btReset";
            btReset.Size = new Size(169, 41);
            btReset.TabIndex = 15;
            btReset.Text = "Show All History";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // txtIdEmployees
            // 
            txtIdEmployees.Location = new Point(187, 74);
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
            cbSheet.Size = new Size(198, 31);
            cbSheet.TabIndex = 13;
            // 
            // btUpdateWorkSheet
            // 
            btUpdateWorkSheet.Location = new Point(291, 378);
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
            label2.Location = new Point(28, 68);
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
            tabDetailWorkSheet.Size = new Size(1372, 528);
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
            panel5.Size = new Size(982, 522);
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
            dgvDetailWorksheet.Size = new Size(982, 522);
            dgvDetailWorksheet.TabIndex = 1;
            dgvDetailWorksheet.CellMouseDoubleClick += dgvDetailWorksheet_CellMouseDoubleClick_1;
            // 
            // sheetDataGridViewTextBoxColumn1
            // 
            sheetDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sheetDataGridViewTextBoxColumn1.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn1.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn1.Name = "sheetDataGridViewTextBoxColumn1";
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
            coefficientsSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coefficientsSalaryDataGridViewTextBoxColumn.DataPropertyName = "CoefficientsSalary";
            coefficientsSalaryDataGridViewTextBoxColumn.HeaderText = "Coefficients Salary";
            coefficientsSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            coefficientsSalaryDataGridViewTextBoxColumn.Name = "coefficientsSalaryDataGridViewTextBoxColumn";
            // 
            // sheetDetailBindingSource
            // 
            sheetDetailBindingSource.DataSource = typeof(Repository.Models.SheetDetail);
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btUpdateDetailsWorkSheet);
            panel4.Controls.Add(txtCoefficientsSalaryDetails);
            panel4.Controls.Add(txtDescriptionsDetails);
            panel4.Controls.Add(txtEndDetails);
            panel4.Controls.Add(txtStartDetails);
            panel4.Controls.Add(txtSheetDetail);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(985, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 522);
            panel4.TabIndex = 20;
            // 
            // label9
            // 
            label9.Location = new Point(26, 284);
            label9.Name = "label9";
            label9.Size = new Size(113, 47);
            label9.TabIndex = 30;
            label9.Text = "Coefficients salary";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btUpdateDetailsWorkSheet
            // 
            btUpdateDetailsWorkSheet.Location = new Point(265, 400);
            btUpdateDetailsWorkSheet.Name = "btUpdateDetailsWorkSheet";
            btUpdateDetailsWorkSheet.Size = new Size(94, 41);
            btUpdateDetailsWorkSheet.TabIndex = 29;
            btUpdateDetailsWorkSheet.Text = "Update";
            btUpdateDetailsWorkSheet.UseVisualStyleBackColor = true;
            btUpdateDetailsWorkSheet.Click += btUpdateDetailsWorkSheet_Click_1;
            // 
            // txtCoefficientsSalaryDetails
            // 
            txtCoefficientsSalaryDetails.Location = new Point(163, 300);
            txtCoefficientsSalaryDetails.Name = "txtCoefficientsSalaryDetails";
            txtCoefficientsSalaryDetails.Size = new Size(196, 30);
            txtCoefficientsSalaryDetails.TabIndex = 28;
            // 
            // txtDescriptionsDetails
            // 
            txtDescriptionsDetails.Location = new Point(163, 212);
            txtDescriptionsDetails.Multiline = true;
            txtDescriptionsDetails.Name = "txtDescriptionsDetails";
            txtDescriptionsDetails.Size = new Size(196, 62);
            txtDescriptionsDetails.TabIndex = 27;
            // 
            // txtEndDetails
            // 
            txtEndDetails.Location = new Point(163, 156);
            txtEndDetails.Name = "txtEndDetails";
            txtEndDetails.ReadOnly = true;
            txtEndDetails.Size = new Size(196, 30);
            txtEndDetails.TabIndex = 26;
            // 
            // txtStartDetails
            // 
            txtStartDetails.Location = new Point(163, 100);
            txtStartDetails.Name = "txtStartDetails";
            txtStartDetails.ReadOnly = true;
            txtStartDetails.Size = new Size(196, 30);
            txtStartDetails.TabIndex = 25;
            // 
            // txtSheetDetail
            // 
            txtSheetDetail.Location = new Point(163, 44);
            txtSheetDetail.Name = "txtSheetDetail";
            txtSheetDetail.ReadOnly = true;
            txtSheetDetail.Size = new Size(196, 30);
            txtSheetDetail.TabIndex = 24;
            // 
            // label8
            // 
            label8.Location = new Point(30, 160);
            label8.Name = "label8";
            label8.Size = new Size(113, 47);
            label8.TabIndex = 23;
            label8.Text = "Time End";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(30, 98);
            label7.Name = "label7";
            label7.Size = new Size(113, 47);
            label7.TabIndex = 22;
            label7.Text = "Time Start";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(30, 36);
            label6.Name = "label6";
            label6.Size = new Size(113, 47);
            label6.TabIndex = 21;
            label6.Text = "Sheet";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(30, 222);
            label5.Name = "label5";
            label5.Size = new Size(113, 47);
            label5.TabIndex = 20;
            label5.Text = "Descriptions";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageWorkSheetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 619);
            Controls.Add(tabManageWorkSheet);
            Name = "ManageWorkSheetPage";
            Text = "ManageWorkSheetPage";
            tabManageWorkSheet.ResumeLayout(false);
            tabUpdateWorkSheet.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabDetailWorkSheet.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabManageWorkSheet;
        private TabPage tabUpdateWorkSheet;
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
        private TextBox txtCoefficientsSalaryDetails;
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
        private DataGridViewTextBoxColumn idWorkSheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckOutDataGridViewTextBoxColumn;
        private BindingSource workSheetBindingSource;
        private Button btNextList;
        private Button btBackList;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn shiftStartTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftEndTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coefficientsSalaryDataGridViewTextBoxColumn;
        private BindingSource sheetDetailBindingSource;
        private TextBox txtTimeCheckOut;
        private Label label12;
        private TextBox txtTimeCheckIn;
        private Label label11;
    }
}