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
            workSheetBindingSource = new BindingSource(components);
            sheetDetailBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            btRegisterWorksheet = new Button();
            btSheetDetails = new Button();
            btHistory = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pnlManageWorksheet = new Panel();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // sheetDetailBindingSource
            // 
            sheetDetailBindingSource.DataSource = typeof(Repository.Models.SheetDetail);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btRegisterWorksheet, 0, 2);
            tableLayoutPanel2.Controls.Add(btSheetDetails, 0, 1);
            tableLayoutPanel2.Controls.Add(btHistory, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(273, 211);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btRegisterWorksheet
            // 
            btRegisterWorksheet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btRegisterWorksheet.Location = new Point(3, 143);
            btRegisterWorksheet.Name = "btRegisterWorksheet";
            btRegisterWorksheet.Size = new Size(267, 65);
            btRegisterWorksheet.TabIndex = 2;
            btRegisterWorksheet.Text = "Register WorkSheet";
            btRegisterWorksheet.UseVisualStyleBackColor = true;
            btRegisterWorksheet.Click += btRegisterWorksheet_Click;
            // 
            // btSheetDetails
            // 
            btSheetDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSheetDetails.Location = new Point(3, 73);
            btSheetDetails.Name = "btSheetDetails";
            btSheetDetails.Size = new Size(267, 64);
            btSheetDetails.TabIndex = 1;
            btSheetDetails.Text = "Details Worksheet";
            btSheetDetails.UseVisualStyleBackColor = true;
            btSheetDetails.Click += btSheetDetails_Click;
            // 
            // btHistory
            // 
            btHistory.Dock = DockStyle.Fill;
            btHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btHistory.Location = new Point(3, 3);
            btHistory.Name = "btHistory";
            btHistory.Size = new Size(267, 64);
            btHistory.TabIndex = 0;
            btHistory.Text = "History WorkSheet";
            btHistory.UseVisualStyleBackColor = true;
            btHistory.Click += btHistory_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1397, 668);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlManageWorksheet);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(282, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 662);
            panel1.TabIndex = 1;
            // 
            // pnlManageWorksheet
            // 
            pnlManageWorksheet.Dock = DockStyle.Fill;
            pnlManageWorksheet.Location = new Point(0, 0);
            pnlManageWorksheet.Name = "pnlManageWorksheet";
            pnlManageWorksheet.Size = new Size(1112, 662);
            pnlManageWorksheet.TabIndex = 0;
            // 
            // frmManageWorkSheetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 668);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmManageWorkSheetPage";
            Text = "ManageWorkSheetPage";
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource workSheetBindingSource;
        private BindingSource sheetDetailBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btHistory;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel pnlManageWorksheet;
        private Button btRegisterWorksheet;
        private Button btSheetDetails;
    }
}