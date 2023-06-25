namespace MiniStoreWinF.ManageSalary
{
    partial class frmSalarySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalarySetup));
            gb1 = new GroupBox();
            button1 = new Button();
            txtGuard = new TextBox();
            txtEmp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            employeeBindingSource = new BindingSource(components);
            gb2 = new GroupBox();
            btEdit = new Button();
            txtSaGuard = new TextBox();
            txtSaEmp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btEditTax = new Button();
            txtTaxGua = new TextBox();
            txtTaxEmp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            gb2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ButtonHighlight;
            gb1.Controls.Add(button1);
            gb1.Controls.Add(txtGuard);
            gb1.Controls.Add(txtEmp);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Dock = DockStyle.Fill;
            gb1.Location = new Point(0, 0);
            gb1.Margin = new Padding(5, 4, 5, 4);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(5, 4, 5, 4);
            gb1.Size = new Size(1053, 191);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(19, 128);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 34);
            button1.TabIndex = 4;
            button1.Text = "Detail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtGuard
            // 
            txtGuard.Enabled = false;
            txtGuard.Location = new Point(295, 94);
            txtGuard.Margin = new Padding(5, 4, 5, 4);
            txtGuard.Name = "txtGuard";
            txtGuard.Size = new Size(155, 33);
            txtGuard.TabIndex = 3;
            // 
            // txtEmp
            // 
            txtEmp.Enabled = false;
            txtEmp.Location = new Point(295, 47);
            txtEmp.Margin = new Padding(5, 4, 5, 4);
            txtEmp.Name = "txtEmp";
            txtEmp.Size = new Size(155, 33);
            txtEmp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 94);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "Number Guard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 1;
            label1.Text = "Number Employees";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // gb2
            // 
            gb2.Controls.Add(btEdit);
            gb2.Controls.Add(txtSaGuard);
            gb2.Controls.Add(txtSaEmp);
            gb2.Controls.Add(label4);
            gb2.Controls.Add(label3);
            gb2.Dock = DockStyle.Fill;
            gb2.Location = new Point(0, 0);
            gb2.Margin = new Padding(5, 4, 5, 4);
            gb2.Name = "gb2";
            gb2.Padding = new Padding(5, 4, 5, 4);
            gb2.Size = new Size(1053, 191);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(19, 141);
            btEdit.Margin = new Padding(5, 4, 5, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(118, 34);
            btEdit.TabIndex = 2;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // txtSaGuard
            // 
            txtSaGuard.Enabled = false;
            txtSaGuard.Location = new Point(295, 97);
            txtSaGuard.Margin = new Padding(5, 4, 5, 4);
            txtSaGuard.Name = "txtSaGuard";
            txtSaGuard.Size = new Size(155, 33);
            txtSaGuard.TabIndex = 1;
            // 
            // txtSaEmp
            // 
            txtSaEmp.Enabled = false;
            txtSaEmp.Location = new Point(295, 41);
            txtSaEmp.Margin = new Padding(5, 4, 5, 4);
            txtSaEmp.Name = "txtSaEmp";
            txtSaEmp.Size = new Size(155, 33);
            txtSaEmp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 53);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 0;
            label4.Text = "Basic Salary for Employee ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 109);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 0;
            label3.Text = "Basic Salary for Guard";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btEditTax);
            groupBox1.Controls.Add(txtTaxGua);
            groupBox1.Controls.Add(txtTaxEmp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1053, 191);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btEditTax
            // 
            btEditTax.Location = new Point(19, 168);
            btEditTax.Margin = new Padding(5, 4, 5, 4);
            btEditTax.Name = "btEditTax";
            btEditTax.Size = new Size(118, 34);
            btEditTax.TabIndex = 2;
            btEditTax.Text = "Edit";
            btEditTax.UseVisualStyleBackColor = true;
            btEditTax.Click += btEditTax_Click;
            // 
            // txtTaxGua
            // 
            txtTaxGua.Enabled = false;
            txtTaxGua.Location = new Point(295, 110);
            txtTaxGua.Margin = new Padding(5, 4, 5, 4);
            txtTaxGua.Name = "txtTaxGua";
            txtTaxGua.Size = new Size(155, 33);
            txtTaxGua.TabIndex = 1;
            // 
            // txtTaxEmp
            // 
            txtTaxEmp.Enabled = false;
            txtTaxEmp.Location = new Point(295, 42);
            txtTaxEmp.Margin = new Padding(5, 4, 5, 4);
            txtTaxEmp.Name = "txtTaxEmp";
            txtTaxEmp.Size = new Size(155, 33);
            txtTaxEmp.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 115);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 0;
            label6.Text = "Tax for Guard ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 42);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 0;
            label5.Text = "Tax for Employee ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1084, 662);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(gb1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(3, 3, 20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 195);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(gb2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 225);
            panel2.Margin = new Padding(3, 3, 20, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 195);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 445);
            panel3.Margin = new Padding(3, 3, 20, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 195);
            panel3.TabIndex = 4;
            // 
            // frmSalarySetup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1084, 662);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmSalarySetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalarySetup";
            Load += frmSalarySetup_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private BindingSource employeeBindingSource;
        private Label label2;
        private Label label1;
        private TextBox txtGuard;
        private TextBox txtEmp;
        private Button button1;
        private GroupBox gb2;
        private Label label4;
        private Label label3;
        private TextBox txtSaGuard;
        private TextBox txtSaEmp;
        private Button btEdit;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private TextBox txtTaxGua;
        private TextBox txtTaxEmp;
        private Button btEditTax;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}