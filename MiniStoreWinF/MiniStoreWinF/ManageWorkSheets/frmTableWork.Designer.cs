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
            panel3 = new Panel();
            btNextday = new Button();
            btLastday = new Button();
            dtpkDate = new DateTimePicker();
            workSheetBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlJobSheet.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListWorkDate).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 492);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlJobSheet);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 492);
            panel2.TabIndex = 0;
            // 
            // pnlJobSheet
            // 
            pnlJobSheet.Controls.Add(panel5);
            pnlJobSheet.Controls.Add(dtgvListWorkDate);
            pnlJobSheet.Dock = DockStyle.Fill;
            pnlJobSheet.Location = new Point(0, 35);
            pnlJobSheet.Name = "pnlJobSheet";
            pnlJobSheet.Size = new Size(906, 457);
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
            panel5.Location = new Point(0, 325);
            panel5.Name = "panel5";
            panel5.Size = new Size(906, 132);
            panel5.TabIndex = 7;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(800, 71);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "Update";
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
            label7.Location = new Point(22, 18);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 7;
            label7.Text = "Id WorkSheet";
            // 
            // btRemove
            // 
            btRemove.Location = new Point(685, 71);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 29);
            btRemove.TabIndex = 6;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click_1;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(569, 71);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 4;
            btCreate.Text = "Create";
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
            label5.Location = new Point(655, 22);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
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
            label6.Location = new Point(296, 22);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 0;
            label6.Text = "Name Employee";
            // 
            // dtgvListWorkDate
            // 
            dtgvListWorkDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListWorkDate.Dock = DockStyle.Top;
            dtgvListWorkDate.Location = new Point(0, 0);
            dtgvListWorkDate.Name = "dtgvListWorkDate";
            dtgvListWorkDate.RowHeadersWidth = 51;
            dtgvListWorkDate.Size = new Size(906, 325);
            dtgvListWorkDate.TabIndex = 0;
            dtgvListWorkDate.CellMouseDoubleClick += dtgvListWorkDate_CellMouseDoubleClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btNextday);
            panel3.Controls.Add(btLastday);
            panel3.Controls.Add(dtpkDate);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(906, 35);
            panel3.TabIndex = 2;
            // 
            // btNextday
            // 
            btNextday.Location = new Point(762, 1);
            btNextday.Name = "btNextday";
            btNextday.Size = new Size(94, 29);
            btNextday.TabIndex = 3;
            btNextday.Text = "Next day";
            btNextday.UseVisualStyleBackColor = true;
            btNextday.Click += btNextday_Click;
            // 
            // btLastday
            // 
            btLastday.Location = new Point(39, 3);
            btLastday.Name = "btLastday";
            btLastday.Size = new Size(94, 29);
            btLastday.TabIndex = 2;
            btLastday.Text = "Last day";
            btLastday.UseVisualStyleBackColor = true;
            btLastday.Click += btLastday_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.CalendarTrailingForeColor = Color.Gray;
            dtpkDate.CustomFormat = "";
            dtpkDate.Location = new Point(322, 3);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(269, 27);
            dtpkDate.TabIndex = 1;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // frmTableWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 492);
            Controls.Add(panel1);
            Name = "frmTableWork";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTableWork";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlJobSheet.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListWorkDate).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpkDate;
        private Panel panel2;
        private Panel panel3;
        private Button btNextday;
        private Button btLastday;
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
    }
}