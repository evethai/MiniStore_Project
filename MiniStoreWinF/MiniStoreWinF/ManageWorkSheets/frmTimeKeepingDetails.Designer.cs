namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmTimeKeepingDetails
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
            panel1 = new Panel();
            dtpkMothTimeKeeping = new DateTimePicker();
            panel2 = new Panel();
            dgvTimekeeping = new DataGridView();
            workSheetBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimekeeping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1365, 509);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpkMothTimeKeeping);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 66);
            panel1.TabIndex = 0;
            // 
            // dtpkMothTimeKeeping
            // 
            dtpkMothTimeKeeping.CustomFormat = "MM/yyyy";
            dtpkMothTimeKeeping.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkMothTimeKeeping.Format = DateTimePickerFormat.Custom;
            dtpkMothTimeKeeping.Location = new Point(570, 9);
            dtpkMothTimeKeeping.Margin = new Padding(5);
            dtpkMothTimeKeeping.Name = "dtpkMothTimeKeeping";
            dtpkMothTimeKeeping.Size = new Size(210, 38);
            dtpkMothTimeKeeping.TabIndex = 0;
            dtpkMothTimeKeeping.ValueChanged += dtpkMothTimeKeeping_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTimekeeping);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 81);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1355, 423);
            panel2.TabIndex = 1;
            // 
            // dgvTimekeeping
            // 
            dgvTimekeeping.BackgroundColor = SystemColors.Control;
            dgvTimekeeping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimekeeping.Dock = DockStyle.Fill;
            dgvTimekeeping.Location = new Point(0, 0);
            dgvTimekeeping.Margin = new Padding(5);
            dgvTimekeeping.Name = "dgvTimekeeping";
            dgvTimekeeping.RowHeadersWidth = 51;
            dgvTimekeeping.RowTemplate.Height = 29;
            dgvTimekeeping.Size = new Size(1355, 423);
            dgvTimekeeping.TabIndex = 0;
            dgvTimekeeping.CellDoubleClick += dgvTimekeeping_CellDoubleClick;
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // frmTimeKeepingDetails
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 509);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmTimeKeepingDetails";
            Text = "frmTimeKeepingDetails";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTimekeeping).EndInit();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DateTimePicker dtpkMothTimeKeeping;
        private Panel panel2;
        private BindingSource workSheetBindingSource;
        private DataGridView dgvTimekeeping;
    }
}