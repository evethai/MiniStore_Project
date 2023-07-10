namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmRegisterWorksheet
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            dtpkDate = new DateTimePicker();
            panel2 = new Panel();
            nmbrNotification = new NumericUpDown();
            chbNotification = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnTuesday = new Button();
            btMonday = new Button();
            btWednesday = new Button();
            btnThursday = new Button();
            btnFriday = new Button();
            btnSaturday = new Button();
            btnSunday = new Button();
            btnNextMonth = new Button();
            btnMonthBack = new Button();
            pnlMatrix = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmbrNotification).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1114, 627);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 56);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpkDate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(294, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 56);
            panel3.TabIndex = 1;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(240, 14);
            dtpkDate.Margin = new Padding(3, 4, 3, 4);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(290, 27);
            dtpkDate.TabIndex = 5;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmbrNotification);
            panel2.Controls.Add(chbNotification);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 56);
            panel2.TabIndex = 0;
            // 
            // nmbrNotification
            // 
            nmbrNotification.Location = new Point(170, 14);
            nmbrNotification.Margin = new Padding(3, 5, 3, 5);
            nmbrNotification.Name = "nmbrNotification";
            nmbrNotification.Size = new Size(104, 27);
            nmbrNotification.TabIndex = 8;
            // 
            // chbNotification
            // 
            chbNotification.AutoSize = true;
            chbNotification.Location = new Point(29, 14);
            chbNotification.Margin = new Padding(3, 4, 3, 4);
            chbNotification.Name = "chbNotification";
            chbNotification.Size = new Size(110, 24);
            chbNotification.TabIndex = 7;
            chbNotification.Text = "Notification";
            chbNotification.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel3.Controls.Add(btnNextMonth, 2, 0);
            tableLayoutPanel3.Controls.Add(btnMonthBack, 0, 0);
            tableLayoutPanel3.Controls.Add(pnlMatrix, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 65);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Size = new Size(1108, 559);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Controls.Add(btnTuesday, 0, 0);
            tableLayoutPanel2.Controls.Add(btMonday, 0, 0);
            tableLayoutPanel2.Controls.Add(btWednesday, 2, 0);
            tableLayoutPanel2.Controls.Add(btnThursday, 3, 0);
            tableLayoutPanel2.Controls.Add(btnFriday, 4, 0);
            tableLayoutPanel2.Controls.Add(btnSaturday, 5, 0);
            tableLayoutPanel2.Controls.Add(btnSunday, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(113, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(880, 77);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTuesday
            // 
            btnTuesday.Dock = DockStyle.Fill;
            btnTuesday.Location = new Point(128, 4);
            btnTuesday.Margin = new Padding(3, 4, 3, 4);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(119, 69);
            btnTuesday.TabIndex = 13;
            btnTuesday.Text = "Tuesday";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btMonday
            // 
            btMonday.AutoSize = true;
            btMonday.Dock = DockStyle.Fill;
            btMonday.Location = new Point(3, 4);
            btMonday.Margin = new Padding(3, 4, 3, 4);
            btMonday.Name = "btMonday";
            btMonday.Size = new Size(119, 69);
            btMonday.TabIndex = 12;
            btMonday.Text = "Monday";
            btMonday.UseVisualStyleBackColor = true;
            // 
            // btWednesday
            // 
            btWednesday.Dock = DockStyle.Fill;
            btWednesday.Location = new Point(253, 4);
            btWednesday.Margin = new Padding(3, 4, 3, 4);
            btWednesday.Name = "btWednesday";
            btWednesday.Size = new Size(119, 69);
            btWednesday.TabIndex = 16;
            btWednesday.Text = "Wednesday ";
            btWednesday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            btnThursday.Dock = DockStyle.Fill;
            btnThursday.Location = new Point(378, 4);
            btnThursday.Margin = new Padding(3, 4, 3, 4);
            btnThursday.Name = "btnThursday";
            btnThursday.Size = new Size(119, 69);
            btnThursday.TabIndex = 17;
            btnThursday.Text = "Thursday ";
            btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Dock = DockStyle.Fill;
            btnFriday.Location = new Point(503, 4);
            btnFriday.Margin = new Padding(3, 4, 3, 4);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(119, 69);
            btnFriday.TabIndex = 18;
            btnFriday.Text = "Friday";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            btnSaturday.Dock = DockStyle.Fill;
            btnSaturday.Location = new Point(628, 4);
            btnSaturday.Margin = new Padding(3, 4, 3, 4);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(119, 69);
            btnSaturday.TabIndex = 19;
            btnSaturday.Text = "Saturday";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnSunday
            // 
            btnSunday.Dock = DockStyle.Fill;
            btnSunday.Location = new Point(753, 4);
            btnSunday.Margin = new Padding(3, 4, 3, 4);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(124, 69);
            btnSunday.TabIndex = 20;
            btnSunday.Text = "Sunday";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Dock = DockStyle.Fill;
            btnNextMonth.Location = new Point(999, 4);
            btnNextMonth.Margin = new Padding(3, 4, 3, 4);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(106, 75);
            btnNextMonth.TabIndex = 10;
            btnNextMonth.Text = "Next month";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click_1;
            // 
            // btnMonthBack
            // 
            btnMonthBack.Dock = DockStyle.Fill;
            btnMonthBack.Location = new Point(3, 4);
            btnMonthBack.Margin = new Padding(3, 4, 3, 4);
            btnMonthBack.Name = "btnMonthBack";
            btnMonthBack.Size = new Size(104, 75);
            btnMonthBack.TabIndex = 11;
            btnMonthBack.Text = "Last month";
            btnMonthBack.UseVisualStyleBackColor = true;
            btnMonthBack.Click += btnMonthBack_Click_1;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Dock = DockStyle.Fill;
            pnlMatrix.Location = new Point(113, 86);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(880, 470);
            pnlMatrix.TabIndex = 12;
            // 
            // frmRegisterWorksheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 627);
            Controls.Add(tableLayoutPanel1);
            Name = "frmRegisterWorksheet";
            Text = "frmRegisterWorksheet";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmbrNotification).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private NumericUpDown nmbrNotification;
        private CheckBox chbNotification;
        private DateTimePicker dtpkDate;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnNextMonth;
        private Button btnMonthBack;
        private Button btMonday;
        private Button btnTuesday;
        private Button btWednesday;
        private Button btnThursday;
        private Button btnFriday;
        private Button btnSaturday;
        private Button btnSunday;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel pnlMatrix;
    }
}