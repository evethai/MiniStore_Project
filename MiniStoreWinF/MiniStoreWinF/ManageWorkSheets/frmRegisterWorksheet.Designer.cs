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
            numericUpDown1 = new NumericUpDown();
            chbNotification = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnTuesday = new Button();
            btMonday = new Button();
            btWednesday = new Button();
            btnThursday = new Button();
            btnFriday = new Button();
            btnSaturday = new Button();
            btnSunday = new Button();
            btnMonthBack = new Button();
            btnNextMonth = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnlMatrix = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(1026, 627);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 56);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpkDate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(294, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 56);
            panel3.TabIndex = 1;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(241, 14);
            dtpkDate.Margin = new Padding(3, 4, 3, 4);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(290, 27);
            dtpkDate.TabIndex = 5;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(chbNotification);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 56);
            panel2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(170, 14);
            numericUpDown1.Margin = new Padding(3, 5, 3, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(104, 27);
            numericUpDown1.TabIndex = 8;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnTuesday, 0, 0);
            tableLayoutPanel2.Controls.Add(btMonday, 0, 0);
            tableLayoutPanel2.Controls.Add(btWednesday, 3, 0);
            tableLayoutPanel2.Controls.Add(btnThursday, 4, 0);
            tableLayoutPanel2.Controls.Add(btnFriday, 5, 0);
            tableLayoutPanel2.Controls.Add(btnSaturday, 6, 0);
            tableLayoutPanel2.Controls.Add(btnSunday, 7, 0);
            tableLayoutPanel2.Controls.Add(btnMonthBack, 0, 0);
            tableLayoutPanel2.Controls.Add(btnNextMonth, 8, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 65);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1020, 88);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTuesday
            // 
            btnTuesday.Dock = DockStyle.Fill;
            btnTuesday.Location = new Point(258, 4);
            btnTuesday.Margin = new Padding(3, 4, 3, 4);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(96, 80);
            btnTuesday.TabIndex = 13;
            btnTuesday.Text = "Tuesday";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btMonday
            // 
            btMonday.Dock = DockStyle.Fill;
            btMonday.Location = new Point(156, 4);
            btMonday.Margin = new Padding(3, 4, 3, 4);
            btMonday.Name = "btMonday";
            btMonday.Size = new Size(96, 80);
            btMonday.TabIndex = 12;
            btMonday.Text = "Monday";
            btMonday.UseVisualStyleBackColor = true;
            // 
            // btWednesday
            // 
            btWednesday.Dock = DockStyle.Fill;
            btWednesday.Location = new Point(360, 4);
            btWednesday.Margin = new Padding(3, 4, 3, 4);
            btWednesday.Name = "btWednesday";
            btWednesday.Size = new Size(96, 80);
            btWednesday.TabIndex = 16;
            btWednesday.Text = "Wednesday ";
            btWednesday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            btnThursday.Dock = DockStyle.Fill;
            btnThursday.Location = new Point(462, 4);
            btnThursday.Margin = new Padding(3, 4, 3, 4);
            btnThursday.Name = "btnThursday";
            btnThursday.Size = new Size(96, 80);
            btnThursday.TabIndex = 17;
            btnThursday.Text = "Thursday ";
            btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Dock = DockStyle.Fill;
            btnFriday.Location = new Point(564, 4);
            btnFriday.Margin = new Padding(3, 4, 3, 4);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(96, 80);
            btnFriday.TabIndex = 18;
            btnFriday.Text = "Friday";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            btnSaturday.Dock = DockStyle.Fill;
            btnSaturday.Location = new Point(666, 4);
            btnSaturday.Margin = new Padding(3, 4, 3, 4);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(96, 80);
            btnSaturday.TabIndex = 19;
            btnSaturday.Text = "Saturday";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnSunday
            // 
            btnSunday.Dock = DockStyle.Fill;
            btnSunday.Location = new Point(768, 4);
            btnSunday.Margin = new Padding(3, 4, 3, 4);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(96, 80);
            btnSunday.TabIndex = 20;
            btnSunday.Text = "Sunday";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnMonthBack
            // 
            btnMonthBack.Dock = DockStyle.Fill;
            btnMonthBack.Location = new Point(3, 4);
            btnMonthBack.Margin = new Padding(3, 4, 3, 4);
            btnMonthBack.Name = "btnMonthBack";
            btnMonthBack.Size = new Size(147, 80);
            btnMonthBack.TabIndex = 11;
            btnMonthBack.Text = "Last month";
            btnMonthBack.UseVisualStyleBackColor = true;
            btnMonthBack.Click += btnMonthBack_Click_1;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Dock = DockStyle.Fill;
            btnNextMonth.Location = new Point(870, 4);
            btnNextMonth.Margin = new Padding(3, 4, 3, 4);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(147, 80);
            btnNextMonth.TabIndex = 10;
            btnNextMonth.Text = "Next month";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click_1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(pnlMatrix, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 159);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1020, 465);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Dock = DockStyle.Fill;
            pnlMatrix.Location = new Point(156, 3);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(708, 459);
            pnlMatrix.TabIndex = 0;
            // 
            // frmRegisterWorksheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 627);
            Controls.Add(tableLayoutPanel1);
            Name = "frmRegisterWorksheet";
            Text = "frmRegisterWorksheet";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private CheckBox chbNotification;
        private DateTimePicker dtpkDate;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnNextMonth;
        private Button btnMonthBack;
        private Button btMonday;
        private Button btnTuesday;
        private Button btWednesday;
        private Button btnThursday;
        private Button btnFriday;
        private Button btnSaturday;
        private Button btnSunday;
        private Panel pnlMatrix;
    }
}