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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 356);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlJobSheet);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 356);
            panel2.TabIndex = 0;
            // 
            // pnlJobSheet
            // 
            pnlJobSheet.Controls.Add(panel5);
            pnlJobSheet.Controls.Add(dtgvListWorkDate);
            pnlJobSheet.Dock = DockStyle.Fill;
            pnlJobSheet.Location = new Point(0, 0);
            pnlJobSheet.Margin = new Padding(3, 2, 3, 2);
            pnlJobSheet.Name = "pnlJobSheet";
            pnlJobSheet.Size = new Size(752, 356);
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
            panel5.Location = new Point(0, 239);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(752, 117);
            panel5.TabIndex = 7;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.Image = (Image)resources.GetObject("btUpdate.Image");
            btUpdate.ImageAlign = ContentAlignment.TopCenter;
            btUpdate.Location = new Point(646, 48);
            btUpdate.Margin = new Padding(3, 2, 3, 2);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(82, 50);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "Update";
            btUpdate.TextAlign = ContentAlignment.BottomCenter;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtIdWsheet
            // 
            txtIdWsheet.Location = new Point(120, 14);
            txtIdWsheet.Margin = new Padding(3, 2, 3, 2);
            txtIdWsheet.Name = "txtIdWsheet";
            txtIdWsheet.ReadOnly = true;
            txtIdWsheet.Size = new Size(110, 23);
            txtIdWsheet.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 16);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 7;
            label7.Text = "Id WorkSheet";
            // 
            // btRemove
            // 
            btRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRemove.Image = (Image)resources.GetObject("btRemove.Image");
            btRemove.Location = new Point(545, 48);
            btRemove.Margin = new Padding(3, 2, 3, 2);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(82, 50);
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
            btCreate.Location = new Point(450, 48);
            btCreate.Margin = new Padding(3, 2, 3, 2);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(82, 50);
            btCreate.TabIndex = 4;
            btCreate.Text = "Create";
            btCreate.TextAlign = ContentAlignment.BottomCenter;
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // cbSheetWork
            // 
            cbSheetWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSheetWork.FormattingEnabled = true;
            cbSheetWork.Location = new Point(631, 16);
            cbSheetWork.Margin = new Padding(3, 2, 3, 2);
            cbSheetWork.Name = "cbSheetWork";
            cbSheetWork.Size = new Size(98, 23);
            cbSheetWork.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(573, 19);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 2;
            label5.Text = "Sheet";
            // 
            // cbFullNameEmp
            // 
            cbFullNameEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFullNameEmp.FormattingEnabled = true;
            cbFullNameEmp.Location = new Point(376, 16);
            cbFullNameEmp.Margin = new Padding(3, 2, 3, 2);
            cbFullNameEmp.Name = "cbFullNameEmp";
            cbFullNameEmp.Size = new Size(181, 23);
            cbFullNameEmp.TabIndex = 1;
            cbFullNameEmp.SelectedIndexChanged += cbFullNameEmp_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(263, 19);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
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
            dtgvListWorkDate.Margin = new Padding(3, 2, 3, 2);
            dtgvListWorkDate.Name = "dtgvListWorkDate";
            dtgvListWorkDate.ReadOnly = true;
            dtgvListWorkDate.RowHeadersWidth = 51;
            dtgvListWorkDate.Size = new Size(752, 239);
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
            IdWorkSheet.ReadOnly = true;
            // 
            // IdEmp
            // 
            IdEmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdEmp.DataPropertyName = "IdEmp";
            IdEmp.HeaderText = "Id Emp";
            IdEmp.MinimumWidth = 6;
            IdEmp.Name = "IdEmp";
            IdEmp.ReadOnly = true;
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
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // frmTableWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 356);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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