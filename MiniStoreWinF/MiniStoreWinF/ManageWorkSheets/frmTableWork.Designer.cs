namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmTableWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableWork));
            panel1 = new Panel();
            panel2 = new Panel();
            pnlJobSheet = new Panel();
            panel5 = new Panel();
            btUpdate = new Button();
            txtIdWsheet = new TextBox();
            label7 = new Label();
            btRemove = new Button();
            btCreate = new Button();
            cbSheetWork = new ComboBox();
            label5 = new Label();
            cbFullNameEmp = new ComboBox();
            label6 = new Label();
            dtgvListWorkDate = new DataGridView();
            IdWorkSheet = new DataGridViewTextBoxColumn();
            IdEmp = new DataGridViewTextBoxColumn();
            sheetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workSheetBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlJobSheet.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListWorkDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 474);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlJobSheet);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 474);
            panel2.TabIndex = 0;
            // 
            // pnlJobSheet
            // 
            pnlJobSheet.Controls.Add(panel5);
            pnlJobSheet.Controls.Add(dtgvListWorkDate);
            pnlJobSheet.Dock = DockStyle.Fill;
            pnlJobSheet.Location = new Point(0, 0);
            pnlJobSheet.Name = "pnlJobSheet";
            pnlJobSheet.Size = new Size(860, 474);
            pnlJobSheet.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btUpdate);
            panel5.Controls.Add(txtIdWsheet);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(btRemove);
            panel5.Controls.Add(btCreate);
            panel5.Controls.Add(cbSheetWork);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(cbFullNameEmp);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 319);
            panel5.Name = "panel5";
            panel5.Size = new Size(860, 155);
            panel5.TabIndex = 7;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.Image = (Image)resources.GetObject("btUpdate.Image");
            btUpdate.ImageAlign = ContentAlignment.TopCenter;
            btUpdate.Location = new Point(738, 64);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 67);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "Update";
            btUpdate.TextAlign = ContentAlignment.BottomCenter;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtIdWsheet
            // 
            txtIdWsheet.Location = new Point(137, 18);
            txtIdWsheet.Name = "txtIdWsheet";
            txtIdWsheet.ReadOnly = true;
            txtIdWsheet.Size = new Size(125, 27);
            txtIdWsheet.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 22);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 7;
            label7.Text = "Id WorkSheet";
            // 
            // btRemove
            // 
            btRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRemove.Image = (Image)resources.GetObject("btRemove.Image");
            btRemove.Location = new Point(623, 64);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 67);
            btRemove.TabIndex = 6;
            btRemove.Text = "Remove";
            btRemove.TextAlign = ContentAlignment.BottomCenter;
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click_1;
            // 
            // btCreate
            // 
            btCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCreate.Image = (Image)resources.GetObject("btCreate.Image");
            btCreate.ImageAlign = ContentAlignment.TopCenter;
            btCreate.Location = new Point(514, 64);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 67);
            btCreate.TabIndex = 4;
            btCreate.Text = "Create";
            btCreate.TextAlign = ContentAlignment.BottomCenter;
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // cbSheetWork
            // 
            cbSheetWork.FormattingEnabled = true;
            cbSheetWork.Location = new Point(721, 22);
            cbSheetWork.Name = "cbSheetWork";
            cbSheetWork.Size = new Size(111, 28);
            cbSheetWork.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(655, 25);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 2;
            label5.Text = "Sheet";
            // 
            // cbFullNameEmp
            // 
            cbFullNameEmp.FormattingEnabled = true;
            cbFullNameEmp.Location = new Point(430, 22);
            cbFullNameEmp.Name = "cbFullNameEmp";
            cbFullNameEmp.Size = new Size(206, 28);
            cbFullNameEmp.TabIndex = 1;
            cbFullNameEmp.SelectedIndexChanged += cbFullNameEmp_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(301, 25);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 0;
            label6.Text = "Name Employee";
            // 
            // dtgvListWorkDate
            // 
            dtgvListWorkDate.AutoGenerateColumns = false;
            dtgvListWorkDate.BackgroundColor = SystemColors.Control;
            dtgvListWorkDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListWorkDate.Columns.AddRange(new DataGridViewColumn[] { IdWorkSheet, IdEmp, sheetDataGridViewTextBoxColumn });
            dtgvListWorkDate.DataSource = workSheetBindingSource;
            dtgvListWorkDate.Dock = DockStyle.Top;
            dtgvListWorkDate.Location = new Point(0, 0);
            dtgvListWorkDate.Name = "dtgvListWorkDate";
            dtgvListWorkDate.RowHeadersWidth = 51;
            dtgvListWorkDate.Size = new Size(860, 319);
            dtgvListWorkDate.TabIndex = 0;
            dtgvListWorkDate.CellFormatting += dtgvListWorkDate_CellFormatting;
            dtgvListWorkDate.CellMouseDoubleClick += dtgvListWorkDate_CellMouseDoubleClick;
            // 
            // IdWorkSheet
            // 
            IdWorkSheet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdWorkSheet.DataPropertyName = "IdWorkSheet";
            IdWorkSheet.HeaderText = "ID Sheet";
            IdWorkSheet.MinimumWidth = 6;
            IdWorkSheet.Name = "IdWorkSheet";
            // 
            // IdEmp
            // 
            IdEmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdEmp.DataPropertyName = "IdEmp";
            IdEmp.HeaderText = "Id Emp";
            IdEmp.MinimumWidth = 6;
            IdEmp.Name = "IdEmp";
            // 
            // sheetDataGridViewTextBoxColumn
            // 
            sheetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sheetDataGridViewTextBoxColumn.DataPropertyName = "Sheet";
            sheetDataGridViewTextBoxColumn.HeaderText = "Sheet";
            sheetDataGridViewTextBoxColumn.MinimumWidth = 6;
            sheetDataGridViewTextBoxColumn.Name = "sheetDataGridViewTextBoxColumn";
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // frmTableWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 474);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTableWork";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Worksheet";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlJobSheet.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListWorkDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlJobSheet;
        private BindingSource workSheetBindingSource;
        private DataGridView dtgvListWorkDate;
        private Panel panel5;
        private TextBox txtIdWsheet;
        private Label label7;
        private Button btRemove;
        private Button btCreate;
        private ComboBox cbSheetWork;
        private Label label5;
        private ComboBox cbFullNameEmp;
        private Label label6;
        private Button btUpdate;
        private DataGridViewTextBoxColumn IdWorkSheet;
        private DataGridViewTextBoxColumn IdEmp;
        private DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
    }
}