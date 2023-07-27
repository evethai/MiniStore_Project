namespace MiniStoreWinF.InformationEmployee
{
    partial class frmLastMonthWorksheet
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
            panel1 = new Panel();
            btSearchSheet = new Button();
            dtpWorksheet = new DateTimePicker();
            gbWorksheet = new GroupBox();
            dgvWorksheet = new DataGridView();
            workSheetBindingSource = new BindingSource(components);
            label1 = new Label();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            gbWorksheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btSearchSheet);
            panel1.Controls.Add(dtpWorksheet);
            panel1.Controls.Add(gbWorksheet);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 563);
            panel1.TabIndex = 29;
            // 
            // btSearchSheet
            // 
            btSearchSheet.Location = new Point(693, 96);
            btSearchSheet.Name = "btSearchSheet";
            btSearchSheet.Size = new Size(94, 37);
            btSearchSheet.TabIndex = 35;
            btSearchSheet.Text = "Search";
            btSearchSheet.UseVisualStyleBackColor = true;
            btSearchSheet.Click += btSearchSheet_Click;
            // 
            // dtpWorksheet
            // 
            dtpWorksheet.CustomFormat = "MM/yy";
            dtpWorksheet.Format = DateTimePickerFormat.Custom;
            dtpWorksheet.Location = new Point(474, 55);
            dtpWorksheet.Margin = new Padding(4);
            dtpWorksheet.Name = "dtpWorksheet";
            dtpWorksheet.Size = new Size(342, 34);
            dtpWorksheet.TabIndex = 34;
            // 
            // gbWorksheet
            // 
            gbWorksheet.Controls.Add(dgvWorksheet);
            gbWorksheet.Location = new Point(34, 139);
            gbWorksheet.Name = "gbWorksheet";
            gbWorksheet.Size = new Size(815, 370);
            gbWorksheet.TabIndex = 33;
            gbWorksheet.TabStop = false;
            gbWorksheet.Text = "groupBox1";
            // 
            // dgvWorksheet
            // 
            dgvWorksheet.AutoGenerateColumns = false;
            dgvWorksheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorksheet.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, Status, sheetDataGridViewTextBoxColumn, timeCheckInDataGridViewTextBoxColumn, timeCheckOutDataGridViewTextBoxColumn });
            dgvWorksheet.DataSource = workSheetBindingSource;
            dgvWorksheet.Dock = DockStyle.Fill;
            dgvWorksheet.Location = new Point(3, 30);
            dgvWorksheet.Name = "dgvWorksheet";
            dgvWorksheet.RowHeadersWidth = 51;
            dgvWorksheet.RowTemplate.Height = 29;
            dgvWorksheet.Size = new Size(809, 337);
            dgvWorksheet.TabIndex = 21;
            dgvWorksheet.CellFormatting += dgvWorksheet_CellFormatting;
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 80);
            label1.TabIndex = 32;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
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
            timeCheckInDataGridViewTextBoxColumn.HeaderText = "Check in";
            timeCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckInDataGridViewTextBoxColumn.Name = "timeCheckInDataGridViewTextBoxColumn";
            // 
            // timeCheckOutDataGridViewTextBoxColumn
            // 
            timeCheckOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeCheckOutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckOut";
            timeCheckOutDataGridViewTextBoxColumn.HeaderText = "Check out";
            timeCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeCheckOutDataGridViewTextBoxColumn.Name = "timeCheckOutDataGridViewTextBoxColumn";
            // 
            // frmLastMonthWorksheet
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(721, 563);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmLastMonthWorksheet";
            Text = "frmLastMonthWorksheet";
            Load += frmLastMonthWorksheet_Load;
            panel1.ResumeLayout(false);
            gbWorksheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private BindingSource workSheetBindingSource;
        private Label label1;
        private Button btSearchSheet;
        private DateTimePicker dtpWorksheet;
        private GroupBox gbWorksheet;
        private DataGridView dgvWorksheet;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeCheckOutDataGridViewTextBoxColumn;
    }
}