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
            btResetAllHistory = new Button();
            panel2 = new Panel();
            nbrPagination = new NumericUpDown();
            panel3 = new Panel();
            dgvShowWorkSheet = new DataGridView();
            idWorkSheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdEmp = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalWorkingHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultCoefficientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sundayCoefficientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workSheetBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrPagination).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1243, 538);
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
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Size = new Size(1237, 534);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btResetAllHistory);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 65);
            panel1.TabIndex = 0;
            // 
            // btResetAllHistory
            // 
            btResetAllHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btResetAllHistory.Image = (Image)resources.GetObject("btResetAllHistory.Image");
            btResetAllHistory.ImageAlign = ContentAlignment.TopCenter;
            btResetAllHistory.Location = new Point(598, 5);
            btResetAllHistory.Name = "btResetAllHistory";
            btResetAllHistory.Size = new Size(70, 52);
            btResetAllHistory.TabIndex = 43;
            btResetAllHistory.Text = "Show All";
            btResetAllHistory.TextAlign = ContentAlignment.BottomCenter;
            btResetAllHistory.UseVisualStyleBackColor = true;
            btResetAllHistory.Click += btResetAllHistory_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(nbrPagination);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 498);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 34);
            panel2.TabIndex = 1;
            // 
            // nbrPagination
            // 
            nbrPagination.Location = new Point(590, 11);
            nbrPagination.Margin = new Padding(3, 2, 3, 2);
            nbrPagination.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
            nbrPagination.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.Name = "nbrPagination";
            nbrPagination.Size = new Size(91, 23);
            nbrPagination.TabIndex = 43;
            nbrPagination.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nbrPagination.ValueChanged += nbrPagination_ValueChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvShowWorkSheet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 71);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1231, 423);
            panel3.TabIndex = 2;
            // 
            // dgvShowWorkSheet
            // 
            dgvShowWorkSheet.AutoGenerateColumns = false;
            dgvShowWorkSheet.BackgroundColor = SystemColors.Control;
            dgvShowWorkSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowWorkSheet.Columns.AddRange(new DataGridViewColumn[] { idWorkSheetDataGridViewTextBoxColumn, IdEmp, dateDataGridViewTextBoxColumn, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, totalWorkingHoursDataGridViewTextBoxColumn, defaultCoefficientDataGridViewTextBoxColumn, sundayCoefficientDataGridViewTextBoxColumn });
            dgvShowWorkSheet.DataSource = workSheetBindingSource;
            dgvShowWorkSheet.Dock = DockStyle.Fill;
            dgvShowWorkSheet.GridColor = SystemColors.Control;
            dgvShowWorkSheet.Location = new Point(0, 0);
            dgvShowWorkSheet.Name = "dgvShowWorkSheet";
            dgvShowWorkSheet.ReadOnly = true;
            dgvShowWorkSheet.RowHeadersWidth = 51;
            dgvShowWorkSheet.RowTemplate.Height = 29;
            dgvShowWorkSheet.Size = new Size(1231, 423);
            dgvShowWorkSheet.TabIndex = 42;
            dgvShowWorkSheet.CellFormatting += dgvShowWorkSheet_CellFormatting;
            // 
            // idWorkSheetDataGridViewTextBoxColumn
            // 
            idWorkSheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idWorkSheetDataGridViewTextBoxColumn.DataPropertyName = "IdWorkSheet";
            idWorkSheetDataGridViewTextBoxColumn.HeaderText = "Id";
            idWorkSheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            idWorkSheetDataGridViewTextBoxColumn.Name = "idWorkSheetDataGridViewTextBoxColumn";
            idWorkSheetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdEmp
            // 
            IdEmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdEmp.DataPropertyName = "IdEmp";
            IdEmp.HeaderText = "Id Employee";
            IdEmp.MinimumWidth = 6;
            IdEmp.Name = "IdEmp";
            IdEmp.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sheetDataGridViewTextBoxColumn
            // 
            sheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sheetDataGridViewTextBoxColumn.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn.Name = "sheetDataGridViewTextBoxColumn";
            sheetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeCheckInDataGridViewTextBoxColumn
            // 
            timeCheckInDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckInDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckIn";
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "Check In";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            timeCheckInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "Check Out";
            timeCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckOutDataGridViewTextBoxColumn.Name = "timeCheckOutDataGridViewTextBoxColumn";
            timeCheckOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalWorkingHoursDataGridViewTextBoxColumn
            // 
            totalWorkingHoursDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalWorkingHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalWorkingHours";
            totalWorkingHoursDataGridViewTextBoxColumn.HeaderText = "Working Hours";
            totalWorkingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalWorkingHoursDataGridViewTextBoxColumn.Name = "totalWorkingHoursDataGridViewTextBoxColumn";
            totalWorkingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultCoefficientDataGridViewTextBoxColumn
            // 
            defaultCoefficientDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            defaultCoefficientDataGridViewTextBoxColumn.DataPropertyName = "DefaultCoefficient";
            defaultCoefficientDataGridViewTextBoxColumn.HeaderText = "Default Coefficient";
            defaultCoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            defaultCoefficientDataGridViewTextBoxColumn.Name = "defaultCoefficientDataGridViewTextBoxColumn";
            defaultCoefficientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sundayCoefficientDataGridViewTextBoxColumn
            // 
            sundayCoefficientDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sundayCoefficientDataGridViewTextBoxColumn.DataPropertyName = "SundayCoefficient";
            sundayCoefficientDataGridViewTextBoxColumn.HeaderText = "Sunday Coefficient";
            sundayCoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            sundayCoefficientDataGridViewTextBoxColumn.Name = "sundayCoefficientDataGridViewTextBoxColumn";
            sundayCoefficientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // frmHistoryWorksheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 538);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHistoryWorksheet";
            Text = "History Worksheet";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbrPagination).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowWorkSheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvShowWorkSheet;
        private Button btResetAllHistory;
        private NumericUpDown nbrPagination;
        private BindingSource workSheetBindingSource;
        private DataGridViewTextBoxColumn idWorkSheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdEmp;
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