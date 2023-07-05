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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btLoad = new Button();
            dtpkEnd = new DateTimePicker();
            button4 = new Button();
            dtpkStart = new DateTimePicker();
            button5 = new Button();
            panel2 = new Panel();
            nbrPagination = new NumericUpDown();
            panel3 = new Panel();
            dgvShowWorkSheet = new DataGridView();
            workSheetBindingSource = new BindingSource(components);
            panel4 = new Panel();
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
            idWorkSheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalWorkingHours = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrPagination).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            panel4.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1136, 596);
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
            tableLayoutPanel2.Location = new Point(343, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Size = new Size(790, 590);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btLoad);
            panel1.Controls.Add(dtpkEnd);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dtpkStart);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 70);
            panel1.TabIndex = 0;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(652, 26);
            btLoad.Margin = new Padding(3, 4, 3, 4);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(94, 29);
            btLoad.TabIndex = 43;
            btLoad.Text = "LOAD";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // dtpkEnd
            // 
            dtpkEnd.Format = DateTimePickerFormat.Short;
            dtpkEnd.Location = new Point(459, 26);
            dtpkEnd.Margin = new Padding(3, 4, 3, 4);
            dtpkEnd.Name = "dtpkEnd";
            dtpkEnd.Size = new Size(187, 27);
            dtpkEnd.TabIndex = 42;
            dtpkEnd.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // button4
            // 
            button4.Location = new Point(335, 23);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(118, 31);
            button4.TabIndex = 41;
            button4.Text = "To date :";
            button4.UseVisualStyleBackColor = true;
            // 
            // dtpkStart
            // 
            dtpkStart.Format = DateTimePickerFormat.Short;
            dtpkStart.Location = new Point(123, 26);
            dtpkStart.Margin = new Padding(3, 4, 3, 4);
            dtpkStart.Name = "dtpkStart";
            dtpkStart.Size = new Size(187, 27);
            dtpkStart.TabIndex = 40;
            dtpkStart.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // button5
            // 
            button5.Location = new Point(3, 22);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(118, 31);
            button5.TabIndex = 39;
            button5.Text = "From date :";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(nbrPagination);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 551);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 36);
            panel2.TabIndex = 1;
            // 
            // nbrPagination
            // 
            nbrPagination.Location = new Point(314, 5);
            nbrPagination.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
            nbrPagination.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.Name = "nbrPagination";
            nbrPagination.Size = new Size(163, 27);
            nbrPagination.TabIndex = 43;
            nbrPagination.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.ValueChanged += nbrPagination_ValueChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvShowWorkSheet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 466);
            panel3.TabIndex = 2;
            // 
            // dgvShowWorkSheet
            // 
            dgvShowWorkSheet.AutoGenerateColumns = false;
            dgvShowWorkSheet.BackgroundColor = SystemColors.Control;
            dgvShowWorkSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowWorkSheet.Columns.AddRange(new DataGridViewColumn[] { idWorkSheetDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, TotalWorkingHours });
            dgvShowWorkSheet.DataSource = workSheetBindingSource;
            dgvShowWorkSheet.Dock = DockStyle.Fill;
            dgvShowWorkSheet.GridColor = SystemColors.Control;
            dgvShowWorkSheet.Location = new Point(0, 0);
            dgvShowWorkSheet.Margin = new Padding(3, 4, 3, 4);
            dgvShowWorkSheet.Name = "dgvShowWorkSheet";
            dgvShowWorkSheet.RowHeadersWidth = 51;
            dgvShowWorkSheet.RowTemplate.Height = 29;
            dgvShowWorkSheet.Size = new Size(784, 466);
            dgvShowWorkSheet.TabIndex = 42;
            dgvShowWorkSheet.CellMouseDoubleClick += dgvShowWorkSheet_CellMouseDoubleClick;
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // panel4
            // 
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
            panel4.Size = new Size(334, 590);
            panel4.TabIndex = 1;
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
            label5.Location = new Point(2, 365);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
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
            label6.Location = new Point(2, 310);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
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
            btResetAllHistory.Location = new Point(153, 493);
            btResetAllHistory.Margin = new Padding(3, 4, 3, 4);
            btResetAllHistory.Name = "btResetAllHistory";
            btResetAllHistory.Size = new Size(169, 41);
            btResetAllHistory.TabIndex = 43;
            btResetAllHistory.Text = "Show All History";
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
            label7.Location = new Point(2, 141);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 37;
            label7.Text = "ID Employees";
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(228, 444);
            btUpdate.Margin = new Padding(3, 4, 3, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 41);
            btUpdate.TabIndex = 40;
            btUpdate.Text = "Update";
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
            label8.Location = new Point(2, 254);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 39;
            label8.Text = "Sheet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 185);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 38;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 82);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 36;
            label10.Text = "ID WorkSheet";
            // 
            // idWorkSheetDataGridViewTextBoxColumn
            // 
            idWorkSheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idWorkSheetDataGridViewTextBoxColumn.DataPropertyName = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.HeaderText = "ID";
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
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "Time Check In";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "Time Check Out";
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
            // TotalWorkingHours
            // 
            TotalWorkingHours.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalWorkingHours.DataPropertyName = "TotalWorkingHours";
            TotalWorkingHours.HeaderText = "Working Hours";
            TotalWorkingHours.MinimumWidth = 6;
            TotalWorkingHours.Name = "TotalWorkingHours";
            // 
            // frmHistoryWorksheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 596);
            Controls.Add(tableLayoutPanel1);
            Name = "frmHistoryWorksheet";
            Text = "frmHistoryWorksheet";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbrPagination).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btLoad;
        private DateTimePicker dtpkEnd;
        private Button button4;
        private DateTimePicker dtpkStart;
        private Button button5;
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
        private BindingSource workSheetBindingSource;
        private NumericUpDown nbrPagination;
        private DataGridViewTextBoxColumn idWorkSheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalWorkingHours;
    }
}