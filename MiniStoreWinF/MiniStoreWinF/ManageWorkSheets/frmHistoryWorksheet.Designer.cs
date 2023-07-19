namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmHistoryWorksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryWorksheet));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            nbrPagination = new NumericUpDown();
            panel3 = new Panel();
            dgvShowWorkSheet = new DataGridView();
            idWorkSheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalWorkingHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultCoefficientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sundayCoefficientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workSheetBindingSource = new BindingSource(components);
            panel4 = new Panel();
            btReset = new Button();
            label3 = new Label();
            nbrSunday = new NumericUpDown();
            label2 = new Label();
            chbStatus = new CheckBox();
            txtHours = new TextBox();
            label1 = new Label();
            txtTimeCheckOut = new TextBox();
            label5 = new Label();
            txtTimeCheckIn = new TextBox();
            label6 = new Label();
            txtIDWorksheet = new TextBox();
            btResetAllHistory = new Button();
            txtIdEmp = new TextBox();
            cbSheet = new ComboBox();
            label7 = new Label();
            btUpdate = new Button();
            txtDateWork = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrPagination).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrSunday).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1421, 718);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(429, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Size = new Size(989, 712);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 86);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(nbrPagination);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 664);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 45);
            panel2.TabIndex = 1;
            // 
            // nbrPagination
            // 
            nbrPagination.Location = new Point(335, 5);
            nbrPagination.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
            nbrPagination.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.Name = "nbrPagination";
            nbrPagination.Size = new Size(104, 27);
            nbrPagination.TabIndex = 43;
            nbrPagination.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.ValueChanged += nbrPagination_ValueChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvShowWorkSheet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 563);
            panel3.TabIndex = 2;
            // 
            // dgvShowWorkSheet
            // 
            dgvShowWorkSheet.AutoGenerateColumns = false;
            dgvShowWorkSheet.BackgroundColor = SystemColors.Control;
            dgvShowWorkSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowWorkSheet.Columns.AddRange(new DataGridViewColumn[] { idWorkSheetDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, totalWorkingHoursDataGridViewTextBoxColumn, defaultCoefficientDataGridViewTextBoxColumn, sundayCoefficientDataGridViewTextBoxColumn });
            dgvShowWorkSheet.DataSource = workSheetBindingSource;
            dgvShowWorkSheet.Dock = DockStyle.Fill;
            dgvShowWorkSheet.GridColor = SystemColors.Control;
            dgvShowWorkSheet.Location = new Point(0, 0);
            dgvShowWorkSheet.Margin = new Padding(3, 4, 3, 4);
            dgvShowWorkSheet.Name = "dgvShowWorkSheet";
            dgvShowWorkSheet.RowHeadersWidth = 51;
            dgvShowWorkSheet.RowTemplate.Height = 29;
            dgvShowWorkSheet.Size = new Size(983, 563);
            dgvShowWorkSheet.TabIndex = 42;
            dgvShowWorkSheet.CellFormatting += dgvShowWorkSheet_CellFormatting;
            dgvShowWorkSheet.CellMouseDoubleClick += dgvShowWorkSheet_CellMouseDoubleClick;
            // 
            // idWorkSheetDataGridViewTextBoxColumn
            // 
            idWorkSheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idWorkSheetDataGridViewTextBoxColumn.DataPropertyName = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.HeaderText = "Id";
            idWorkSheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            idWorkSheetDataGridViewTextBoxColumn.Name = "idWorkSheetDataGridViewTextBoxColumn";
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
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
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "Check In";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "Check Out";
            timeCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckOutDataGridViewTextBoxColumn.Name = "timeCheckOutDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // totalWorkingHoursDataGridViewTextBoxColumn
            // 
            totalWorkingHoursDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalWorkingHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalWorkingHours";
            totalWorkingHoursDataGridViewTextBoxColumn.HeaderText = "Working Hours";
            totalWorkingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalWorkingHoursDataGridViewTextBoxColumn.Name = "totalWorkingHoursDataGridViewTextBoxColumn";
            // 
            // defaultCoefficientDataGridViewTextBoxColumn
            // 
            defaultCoefficientDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            defaultCoefficientDataGridViewTextBoxColumn.DataPropertyName = "DefaultCoefficient";
            defaultCoefficientDataGridViewTextBoxColumn.HeaderText = "Default Coefficient";
            defaultCoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            defaultCoefficientDataGridViewTextBoxColumn.Name = "defaultCoefficientDataGridViewTextBoxColumn";
            // 
            // sundayCoefficientDataGridViewTextBoxColumn
            // 
            sundayCoefficientDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sundayCoefficientDataGridViewTextBoxColumn.DataPropertyName = "SundayCoefficient";
            sundayCoefficientDataGridViewTextBoxColumn.HeaderText = "Sunday Coefficient";
            sundayCoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            sundayCoefficientDataGridViewTextBoxColumn.Name = "sundayCoefficientDataGridViewTextBoxColumn";
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // panel4
            // 
            panel4.Controls.Add(btReset);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(nbrSunday);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(chbStatus);
            panel4.Controls.Add(txtHours);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtTimeCheckOut);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtTimeCheckIn);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtIDWorksheet);
            panel4.Controls.Add(btResetAllHistory);
            panel4.Controls.Add(txtIdEmp);
            panel4.Controls.Add(cbSheet);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btUpdate);
            panel4.Controls.Add(txtDateWork);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 712);
            panel4.TabIndex = 1;
            // 
            // btReset
            // 
            btReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btReset.Image = Properties.Resources.icons8_load_50___Copy;
            btReset.Location = new Point(138, 577);
            btReset.Margin = new Padding(3, 4, 3, 4);
            btReset.Name = "btReset";
            btReset.Size = new Size(80, 69);
            btReset.TabIndex = 54;
            btReset.Text = "Reset";
            btReset.TextAlign = ContentAlignment.BottomCenter;
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 521);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 53;
            label3.Text = "Sunday Coefficient";
            // 
            // nbrSunday
            // 
            nbrSunday.DecimalPlaces = 1;
            nbrSunday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nbrSunday.Location = new Point(166, 521);
            nbrSunday.Name = "nbrSunday";
            nbrSunday.Size = new Size(91, 27);
            nbrSunday.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 471);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 51;
            label2.Text = "Status";
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(166, 467);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(79, 24);
            chbStatus.TabIndex = 50;
            chbStatus.Text = "Present";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(124, 421);
            txtHours.Margin = new Padding(3, 4, 3, 4);
            txtHours.Name = "txtHours";
            txtHours.ReadOnly = true;
            txtHours.Size = new Size(198, 27);
            txtHours.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 421);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 49;
            label1.Text = "Hours";
            // 
            // txtTimeCheckOut
            // 
            txtTimeCheckOut.Location = new Point(124, 360);
            txtTimeCheckOut.Margin = new Padding(3, 4, 3, 4);
            txtTimeCheckOut.Name = "txtTimeCheckOut";
            txtTimeCheckOut.ReadOnly = true;
            txtTimeCheckOut.Size = new Size(198, 27);
            txtTimeCheckOut.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(2, 365);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 47;
            label5.Text = "Time Check-Out";
            // 
            // txtTimeCheckIn
            // 
            txtTimeCheckIn.Location = new Point(124, 305);
            txtTimeCheckIn.Margin = new Padding(3, 4, 3, 4);
            txtTimeCheckIn.Name = "txtTimeCheckIn";
            txtTimeCheckIn.ReadOnly = true;
            txtTimeCheckIn.Size = new Size(198, 27);
            txtTimeCheckIn.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(2, 310);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 45;
            label6.Text = "Time Check-In";
            // 
            // txtIDWorksheet
            // 
            txtIDWorksheet.Location = new Point(124, 79);
            txtIDWorksheet.Margin = new Padding(3, 4, 3, 4);
            txtIDWorksheet.Name = "txtIDWorksheet";
            txtIDWorksheet.ReadOnly = true;
            txtIDWorksheet.Size = new Size(198, 27);
            txtIDWorksheet.TabIndex = 34;
            // 
            // btResetAllHistory
            // 
            btResetAllHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btResetAllHistory.Image = (Image)resources.GetObject("btResetAllHistory.Image");
            btResetAllHistory.ImageAlign = ContentAlignment.TopCenter;
            btResetAllHistory.Location = new Point(32, 577);
            btResetAllHistory.Margin = new Padding(3, 4, 3, 4);
            btResetAllHistory.Name = "btResetAllHistory";
            btResetAllHistory.Size = new Size(80, 69);
            btResetAllHistory.TabIndex = 43;
            btResetAllHistory.Text = "Show All";
            btResetAllHistory.TextAlign = ContentAlignment.BottomCenter;
            btResetAllHistory.UseVisualStyleBackColor = true;
            btResetAllHistory.Click += btResetAllHistory_Click;
            // 
            // txtIdEmp
            // 
            txtIdEmp.Location = new Point(124, 134);
            txtIdEmp.Margin = new Padding(3, 4, 3, 4);
            txtIdEmp.Name = "txtIdEmp";
            txtIdEmp.ReadOnly = true;
            txtIdEmp.Size = new Size(198, 27);
            txtIdEmp.TabIndex = 42;
            // 
            // cbSheet
            // 
            cbSheet.FormattingEnabled = true;
            cbSheet.Location = new Point(166, 251);
            cbSheet.Margin = new Padding(3, 4, 3, 4);
            cbSheet.Name = "cbSheet";
            cbSheet.Size = new Size(91, 28);
            cbSheet.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(2, 141);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 37;
            label7.Text = "ID Employees";
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.Image = (Image)resources.GetObject("btUpdate.Image");
            btUpdate.Location = new Point(242, 577);
            btUpdate.Margin = new Padding(3, 4, 3, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(80, 69);
            btUpdate.TabIndex = 40;
            btUpdate.Text = "Update";
            btUpdate.TextAlign = ContentAlignment.BottomCenter;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtDateWork
            // 
            txtDateWork.Location = new Point(124, 190);
            txtDateWork.Margin = new Padding(3, 4, 3, 4);
            txtDateWork.Name = "txtDateWork";
            txtDateWork.ReadOnly = true;
            txtDateWork.Size = new Size(198, 27);
            txtDateWork.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(27, 251);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 39;
            label8.Text = "Sheet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(32, 190);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 38;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(2, 82);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 36;
            label10.Text = "ID WorkSheet";
            // 
            // frmHistoryWorksheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 718);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHistoryWorksheet";
            Text = "History Worksheet";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbrPagination).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrSunday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvShowWorkSheet;
        private Panel panel4;
        private TextBox txtTimeCheckOut;
        private Label label5;
        private TextBox txtTimeCheckIn;
        private Label label6;
        private TextBox txtIDWorksheet;
        private Button btResetAllHistory;
        private TextBox txtIdEmp;
        private ComboBox cbSheet;
        private Label label7;
        private Button btUpdate;
        private TextBox txtDateWork;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown nbrPagination;
        private BindingSource workSheetBindingSource;
        private Label label3;
        private NumericUpDown nbrSunday;
        private Label label2;
        private CheckBox chbStatus;
        private TextBox txtHours;
        private Label label1;
        private Button btReset;
        private DataGridViewTextBoxColumn idWorkSheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalWorkingHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultCoefficientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sundayCoefficientDataGridViewTextBoxColumn;
    }
}