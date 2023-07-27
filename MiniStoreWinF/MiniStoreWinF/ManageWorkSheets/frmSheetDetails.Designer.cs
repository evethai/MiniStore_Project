namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmSheetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSheetDetails));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btReset = new Button();
            label2 = new Label();
            label1 = new Label();
            chbWorkNight = new CheckBox();
            cbRoles = new ComboBox();
            btCreate = new Button();
            label6 = new Label();
            txtStartDetails = new TextBox();
            label7 = new Label();
            txtEndDetails = new TextBox();
            label8 = new Label();
            txtCoefficientsSalaryDetails = new NumericUpDown();
            label9 = new Label();
            btUpdateDetailsWorkSheet = new Button();
            txtSheetDetail = new TextBox();
            panel2 = new Panel();
            dgvDetailWorksheet = new DataGridView();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coefficientsSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shiftStartTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shiftEndTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CheckNight = new DataGridViewTextBoxColumn();
            sheetDetailBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(994, 507);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btReset);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chbWorkNight);
            panel1.Controls.Add(cbRoles);
            panel1.Controls.Add(btCreate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtStartDetails);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtEndDetails);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCoefficientsSalaryDetails);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btUpdateDetailsWorkSheet);
            panel1.Controls.Add(txtSheetDetail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 503);
            panel1.TabIndex = 0;
            // 
            // btReset
            // 
            btReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btReset.Image = (Image)resources.GetObject("btReset.Image");
            btReset.ImageAlign = ContentAlignment.TopCenter;
            btReset.Location = new Point(202, 399);
            btReset.Name = "btReset";
            btReset.Size = new Size(82, 53);
            btReset.TabIndex = 61;
            btReset.Text = "Reset";
            btReset.TextAlign = ContentAlignment.BottomCenter;
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 244);
            label2.Name = "label2";
            label2.Size = new Size(99, 40);
            label2.TabIndex = 60;
            label2.Text = "Time Working";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 185);
            label1.Name = "label1";
            label1.Size = new Size(99, 40);
            label1.TabIndex = 59;
            label1.Text = "Role";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbWorkNight
            // 
            chbWorkNight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbWorkNight.Image = (Image)resources.GetObject("chbWorkNight.Image");
            chbWorkNight.ImageAlign = ContentAlignment.TopCenter;
            chbWorkNight.Location = new Point(112, 244);
            chbWorkNight.Margin = new Padding(3, 2, 3, 2);
            chbWorkNight.Name = "chbWorkNight";
            chbWorkNight.Size = new Size(95, 52);
            chbWorkNight.TabIndex = 58;
            chbWorkNight.Text = "Night";
            chbWorkNight.TextAlign = ContentAlignment.BottomCenter;
            chbWorkNight.UseVisualStyleBackColor = true;
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(113, 193);
            cbRoles.Margin = new Padding(3, 2, 3, 2);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(172, 25);
            cbRoles.TabIndex = 57;
            // 
            // btCreate
            // 
            btCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCreate.Image = (Image)resources.GetObject("btCreate.Image");
            btCreate.ImageAlign = ContentAlignment.TopCenter;
            btCreate.Location = new Point(9, 399);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(82, 53);
            btCreate.TabIndex = 55;
            btCreate.Text = "Create";
            btCreate.TextAlign = ContentAlignment.BottomCenter;
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 20);
            label6.Name = "label6";
            label6.Size = new Size(99, 40);
            label6.TabIndex = 46;
            label6.Text = "Sheet";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStartDetails
            // 
            txtStartDetails.Location = new Point(113, 88);
            txtStartDetails.Name = "txtStartDetails";
            txtStartDetails.Size = new Size(172, 25);
            txtStartDetails.TabIndex = 50;
            txtStartDetails.TextChanged += txtStartDetails_TextChanged;
            txtStartDetails.KeyPress += txtStartDetails_KeyPress;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 79);
            label7.Name = "label7";
            label7.Size = new Size(99, 40);
            label7.TabIndex = 47;
            label7.Text = "Time Start";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEndDetails
            // 
            txtEndDetails.Location = new Point(113, 147);
            txtEndDetails.Name = "txtEndDetails";
            txtEndDetails.Size = new Size(172, 25);
            txtEndDetails.TabIndex = 51;
            txtEndDetails.TextChanged += txtEndDetails_TextChanged;
            txtEndDetails.KeyPress += txtStartDetails_KeyPress;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 139);
            label8.Name = "label8";
            label8.Size = new Size(99, 40);
            label8.TabIndex = 48;
            label8.Text = "Time End";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCoefficientsSalaryDetails
            // 
            txtCoefficientsSalaryDetails.DecimalPlaces = 1;
            txtCoefficientsSalaryDetails.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            txtCoefficientsSalaryDetails.Location = new Point(113, 313);
            txtCoefficientsSalaryDetails.Margin = new Padding(3, 5, 3, 5);
            txtCoefficientsSalaryDetails.Name = "txtCoefficientsSalaryDetails";
            txtCoefficientsSalaryDetails.Size = new Size(110, 25);
            txtCoefficientsSalaryDetails.TabIndex = 56;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 304);
            label9.Name = "label9";
            label9.Size = new Size(99, 40);
            label9.TabIndex = 54;
            label9.Text = "Coefficients salary";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btUpdateDetailsWorkSheet
            // 
            btUpdateDetailsWorkSheet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateDetailsWorkSheet.Image = (Image)resources.GetObject("btUpdateDetailsWorkSheet.Image");
            btUpdateDetailsWorkSheet.ImageAlign = ContentAlignment.TopCenter;
            btUpdateDetailsWorkSheet.Location = new Point(105, 399);
            btUpdateDetailsWorkSheet.Name = "btUpdateDetailsWorkSheet";
            btUpdateDetailsWorkSheet.Size = new Size(82, 53);
            btUpdateDetailsWorkSheet.TabIndex = 53;
            btUpdateDetailsWorkSheet.Text = "Update";
            btUpdateDetailsWorkSheet.TextAlign = ContentAlignment.BottomCenter;
            btUpdateDetailsWorkSheet.UseVisualStyleBackColor = true;
            btUpdateDetailsWorkSheet.Click += btUpdateDetailsWorkSheet_Click;
            // 
            // txtSheetDetail
            // 
            txtSheetDetail.Location = new Point(140, 29);
            txtSheetDetail.Name = "txtSheetDetail";
            txtSheetDetail.ReadOnly = true;
            txtSheetDetail.Size = new Size(111, 25);
            txtSheetDetail.TabIndex = 49;
            txtSheetDetail.KeyPress += txtSheetDetail_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDetailWorksheet);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(301, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 503);
            panel2.TabIndex = 1;
            // 
            // dgvDetailWorksheet
            // 
            dgvDetailWorksheet.AutoGenerateColumns = false;
            dgvDetailWorksheet.BackgroundColor = SystemColors.Control;
            dgvDetailWorksheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailWorksheet.Columns.AddRange(new DataGridViewColumn[] { sheetDataGridViewTextBoxColumn, coefficientsSalaryDataGridViewTextBoxColumn, shiftStartTimeDataGridViewTextBoxColumn, shiftEndTimeDataGridViewTextBoxColumn, CheckNight });
            dgvDetailWorksheet.DataSource = sheetDetailBindingSource;
            dgvDetailWorksheet.Dock = DockStyle.Fill;
            dgvDetailWorksheet.GridColor = SystemColors.ActiveBorder;
            dgvDetailWorksheet.Location = new Point(0, 0);
            dgvDetailWorksheet.Name = "dgvDetailWorksheet";
            dgvDetailWorksheet.ReadOnly = true;
            dgvDetailWorksheet.RowHeadersWidth = 51;
            dgvDetailWorksheet.RowTemplate.Height = 29;
            dgvDetailWorksheet.Size = new Size(690, 503);
            dgvDetailWorksheet.TabIndex = 43;
            dgvDetailWorksheet.CellFormatting += dgvDetailWorksheet_CellFormatting;
            dgvDetailWorksheet.CellMouseDoubleClick += dgvDetailWorksheet_CellMouseDoubleClick;
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
            // coefficientsSalaryDataGridViewTextBoxColumn
            // 
            coefficientsSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coefficientsSalaryDataGridViewTextBoxColumn.DataPropertyName = "CoefficientsSalary";
            coefficientsSalaryDataGridViewTextBoxColumn.HeaderText = "Coefficients";
            coefficientsSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            coefficientsSalaryDataGridViewTextBoxColumn.Name = "coefficientsSalaryDataGridViewTextBoxColumn";
            coefficientsSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftStartTimeDataGridViewTextBoxColumn
            // 
            shiftStartTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shiftStartTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftStartTime";
            shiftStartTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            shiftStartTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            shiftStartTimeDataGridViewTextBoxColumn.Name = "shiftStartTimeDataGridViewTextBoxColumn";
            shiftStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftEndTimeDataGridViewTextBoxColumn
            // 
            shiftEndTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shiftEndTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftEndTime";
            shiftEndTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            shiftEndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            shiftEndTimeDataGridViewTextBoxColumn.Name = "shiftEndTimeDataGridViewTextBoxColumn";
            shiftEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CheckNight
            // 
            CheckNight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CheckNight.DataPropertyName = "CheckNight";
            CheckNight.HeaderText = "Night";
            CheckNight.MinimumWidth = 6;
            CheckNight.Name = "CheckNight";
            CheckNight.ReadOnly = true;
            // 
            // sheetDetailBindingSource
            // 
            sheetDetailBindingSource.DataSource = typeof(Repository.Models.SheetDetail);
            // 
            // frmSheetDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 507);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSheetDetails";
            Text = "Sheet Details";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCoefficientsSalaryDetails).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label6;
        private TextBox txtStartDetails;
        private Label label7;
        private TextBox txtEndDetails;
        private Label label8;
        private NumericUpDown txtCoefficientsSalaryDetails;
        private Label label9;
        private Button btUpdateDetailsWorkSheet;
        private TextBox txtSheetDetail;
        private Panel panel2;
        private DataGridView dgvDetailWorksheet;
        private BindingSource sheetDetailBindingSource;
        private Label label2;
        private Label label1;
        private CheckBox chbWorkNight;
        private ComboBox cbRoles;
        private Button btReset;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coefficientsSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftStartTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftEndTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CheckNight;
        private Button btCreate;
    }
}