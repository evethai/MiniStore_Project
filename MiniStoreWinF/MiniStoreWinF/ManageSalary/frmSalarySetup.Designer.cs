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
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            gb2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(button1);
            gb1.Controls.Add(txtGuard);
            gb1.Controls.Add(txtEmp);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Dock = DockStyle.Top;
            gb1.Location = new Point(0, 0);
            gb1.Name = "gb1";
            gb1.Size = new Size(374, 149);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Detail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtGuard
            // 
            txtGuard.Enabled = false;
            txtGuard.Location = new Point(188, 64);
            txtGuard.Name = "txtGuard";
            txtGuard.Size = new Size(100, 25);
            txtGuard.TabIndex = 3;
            // 
            // txtEmp
            // 
            txtEmp.Enabled = false;
            txtEmp.Location = new Point(188, 32);
            txtEmp.Name = "txtEmp";
            txtEmp.Size = new Size(100, 25);
            txtEmp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 2;
            label2.Text = "Number Guard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
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
            gb2.Dock = DockStyle.Top;
            gb2.Location = new Point(0, 149);
            gb2.Name = "gb2";
            gb2.Size = new Size(374, 146);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(12, 96);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 2;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // txtSaGuard
            // 
            txtSaGuard.Enabled = false;
            txtSaGuard.Location = new Point(188, 66);
            txtSaGuard.Name = "txtSaGuard";
            txtSaGuard.Size = new Size(100, 25);
            txtSaGuard.TabIndex = 1;
            // 
            // txtSaEmp
            // 
            txtSaEmp.Enabled = false;
            txtSaEmp.Location = new Point(188, 28);
            txtSaEmp.Name = "txtSaEmp";
            txtSaEmp.Size = new Size(100, 25);
            txtSaEmp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(162, 17);
            label4.TabIndex = 0;
            label4.Text = "Basic Salary for Employee ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
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
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 149);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btEditTax
            // 
            btEditTax.Location = new Point(12, 114);
            btEditTax.Name = "btEditTax";
            btEditTax.Size = new Size(75, 23);
            btEditTax.TabIndex = 2;
            btEditTax.Text = "Edit";
            btEditTax.UseVisualStyleBackColor = true;
            btEditTax.Click += btEditTax_Click;
            // 
            // txtTaxGua
            // 
            txtTaxGua.Enabled = false;
            txtTaxGua.Location = new Point(188, 75);
            txtTaxGua.Name = "txtTaxGua";
            txtTaxGua.Size = new Size(100, 25);
            txtTaxGua.TabIndex = 1;
            // 
            // txtTaxEmp
            // 
            txtTaxEmp.Enabled = false;
            txtTaxEmp.Location = new Point(188, 29);
            txtTaxEmp.Name = "txtTaxEmp";
            txtTaxEmp.Size = new Size(100, 25);
            txtTaxEmp.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 78);
            label6.Name = "label6";
            label6.Size = new Size(111, 17);
            label6.TabIndex = 0;
            label6.Text = "Tax for Guard (%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 29);
            label5.Name = "label5";
            label5.Size = new Size(132, 17);
            label5.TabIndex = 0;
            label5.Text = "Tax for Employee (%)";
            // 
            // frmSalarySetup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(groupBox1);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Name = "frmSalarySetup";
            Text = "frmSalarySetup";
            Load += frmSalarySetup_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}