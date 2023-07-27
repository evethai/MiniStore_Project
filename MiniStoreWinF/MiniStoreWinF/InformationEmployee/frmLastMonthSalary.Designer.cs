namespace MiniStoreWinF.InformationEmployee
{
    partial class frmLastMonthSalary
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
            lbName = new Label();
            pnSalary = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            btSearch = new Button();
            gbSalary = new GroupBox();
            txtBasicHours = new TextBox();
            panel3 = new Panel();
            txtTotal = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSalaryHours = new TextBox();
            label8 = new Label();
            txtTax = new TextBox();
            label9 = new Label();
            label12 = new Label();
            txtSumSubSalary = new TextBox();
            txtBeforeTax = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtSumAdvanceSalary = new TextBox();
            dtpMonth = new DateTimePicker();
            lbNameE = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dtpSalry = new DateTimePicker();
            txtSalary = new TextBox();
            lbTottal = new Label();
            workSheetBindingSource = new BindingSource(components);
            salaryBindingSource = new BindingSource(components);
            pnSalary.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            gbSalary.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(16, 13);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(650, 46);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // pnSalary
            // 
            pnSalary.Controls.Add(panel1);
            pnSalary.Controls.Add(textBox1);
            pnSalary.Controls.Add(label1);
            pnSalary.Controls.Add(dtpSalry);
            pnSalary.Controls.Add(txtSalary);
            pnSalary.Controls.Add(lbTottal);
            pnSalary.Controls.Add(lbName);
            pnSalary.Dock = DockStyle.Fill;
            pnSalary.Location = new Point(0, 0);
            pnSalary.Margin = new Padding(4);
            pnSalary.Name = "pnSalary";
            pnSalary.Size = new Size(653, 560);
            pnSalary.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 560);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btSearch);
            panel2.Controls.Add(gbSalary);
            panel2.Controls.Add(dtpMonth);
            panel2.Controls.Add(lbNameE);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 560);
            panel2.TabIndex = 7;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(610, 73);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 37);
            btSearch.TabIndex = 22;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // gbSalary
            // 
            gbSalary.Controls.Add(txtBasicHours);
            gbSalary.Controls.Add(panel3);
            gbSalary.Controls.Add(label5);
            gbSalary.Controls.Add(txtSalaryHours);
            gbSalary.Controls.Add(label8);
            gbSalary.Controls.Add(txtTax);
            gbSalary.Controls.Add(label9);
            gbSalary.Controls.Add(label12);
            gbSalary.Controls.Add(txtSumSubSalary);
            gbSalary.Controls.Add(txtBeforeTax);
            gbSalary.Controls.Add(label10);
            gbSalary.Controls.Add(label11);
            gbSalary.Controls.Add(txtSumAdvanceSalary);
            gbSalary.Location = new Point(101, 116);
            gbSalary.Name = "gbSalary";
            gbSalary.Size = new Size(625, 439);
            gbSalary.TabIndex = 20;
            gbSalary.TabStop = false;
            gbSalary.Text = "Employee's Salary (VNĐ)";
            // 
            // txtBasicHours
            // 
            txtBasicHours.Location = new Point(189, 101);
            txtBasicHours.Name = "txtBasicHours";
            txtBasicHours.ReadOnly = true;
            txtBasicHours.Size = new Size(125, 34);
            txtBasicHours.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(35, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(486, 47);
            panel3.TabIndex = 19;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(124, 7);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(352, 34);
            txtTotal.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(0, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 2;
            label6.Text = "Total Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 31);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 5;
            label5.Text = "Salary Hours";
            // 
            // txtSalaryHours
            // 
            txtSalaryHours.Location = new Point(189, 37);
            txtSalaryHours.Name = "txtSalaryHours";
            txtSalaryHours.ReadOnly = true;
            txtSalaryHours.Size = new Size(125, 34);
            txtSalaryHours.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 101);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 7;
            label8.Text = "Basic Salary";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(461, 101);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 34);
            txtTax.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 174);
            label9.Name = "label9";
            label9.Size = new Size(109, 28);
            label9.TabIndex = 9;
            label9.Text = " Sub Salary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(406, 107);
            label12.Name = "label12";
            label12.Size = new Size(39, 28);
            label12.TabIndex = 15;
            label12.Text = "Tax";
            // 
            // txtSumSubSalary
            // 
            txtSumSubSalary.Location = new Point(189, 174);
            txtSumSubSalary.Name = "txtSumSubSalary";
            txtSumSubSalary.ReadOnly = true;
            txtSumSubSalary.Size = new Size(125, 34);
            txtSumSubSalary.TabIndex = 10;
            // 
            // txtBeforeTax
            // 
            txtBeforeTax.Location = new Point(461, 37);
            txtBeforeTax.Name = "txtBeforeTax";
            txtBeforeTax.ReadOnly = true;
            txtBeforeTax.Size = new Size(125, 34);
            txtBeforeTax.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 246);
            label10.Name = "label10";
            label10.Size = new Size(145, 28);
            label10.TabIndex = 11;
            label10.Text = "Advance Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(345, 37);
            label11.Name = "label11";
            label11.Size = new Size(100, 28);
            label11.TabIndex = 13;
            label11.Text = "Before Tax";
            // 
            // txtSumAdvanceSalary
            // 
            txtSumAdvanceSalary.Location = new Point(189, 243);
            txtSumAdvanceSalary.Name = "txtSumAdvanceSalary";
            txtSumAdvanceSalary.ReadOnly = true;
            txtSumAdvanceSalary.Size = new Size(125, 34);
            txtSumAdvanceSalary.TabIndex = 12;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yy";
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(384, 25);
            dtpMonth.Margin = new Padding(4);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(342, 34);
            dtpMonth.TabIndex = 4;
            // 
            // lbNameE
            // 
            lbNameE.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbNameE.Location = new Point(16, 9);
            lbNameE.Margin = new Padding(4, 0, 4, 0);
            lbNameE.Name = "lbNameE";
            lbNameE.Size = new Size(366, 101);
            lbNameE.TabIndex = 0;
            lbNameE.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 5;
            label2.Text = "Salary Hours";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/yy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(892, 85);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 34);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 389);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(231, 34);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 393);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 2;
            label3.Text = "Total Salary";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(650, 46);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 85);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 5;
            label1.Text = "Salary Hours";
            // 
            // dtpSalry
            // 
            dtpSalry.CustomFormat = "MM/yy";
            dtpSalry.Format = DateTimePickerFormat.Custom;
            dtpSalry.Location = new Point(892, 85);
            dtpSalry.Margin = new Padding(4);
            dtpSalry.Name = "dtpSalry";
            dtpSalry.Size = new Size(342, 34);
            dtpSalry.TabIndex = 4;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(140, 389);
            txtSalary.Margin = new Padding(4);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(231, 34);
            txtSalary.TabIndex = 3;
            // 
            // lbTottal
            // 
            lbTottal.AutoSize = true;
            lbTottal.Location = new Point(13, 393);
            lbTottal.Margin = new Padding(4, 0, 4, 0);
            lbTottal.Name = "lbTottal";
            lbTottal.Size = new Size(112, 28);
            lbTottal.TabIndex = 2;
            lbTottal.Text = "Total Salary";
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // salaryBindingSource
            // 
            salaryBindingSource.DataSource = typeof(Repository.Models.Salary);
            // 
            // frmLastMonthSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 560);
            Controls.Add(pnSalary);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLastMonthSalary";
            Text = "Last Month Salary and Worksheet";
            Load += frmLastMonthSalary_Load;
            pnSalary.ResumeLayout(false);
            pnSalary.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            gbSalary.ResumeLayout(false);
            gbSalary.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private Panel pnSalary;
        private BindingSource salaryBindingSource;
        private TextBox txtSalary;
        private Label lbTottal;
        private DateTimePicker dtpSalry;
        private DataGridViewTextBoxColumn salaryAfterTaxDataGridViewTextBoxColumn;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtBeforeTax;
        private Label label11;
        private TextBox txtSumAdvanceSalary;
        private Label label10;
        private TextBox txtSumSubSalary;
        private Label label9;
        private TextBox txtBasicHours;
        private Label label8;
        private TextBox txtSalaryHours;
        private Label label5;
        private DateTimePicker dtpMonth;
        private TextBox txtTotal;
        private Label label6;
        private Label lbNameE;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtTax;
        private Label label12;
        private GroupBox gbSalary;
        private Panel panel3;
        private Button btSearch;
        private BindingSource workSheetBindingSource;
    }
}