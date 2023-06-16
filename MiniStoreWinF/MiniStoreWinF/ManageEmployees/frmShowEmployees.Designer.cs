namespace MiniStoreWinF.ManageEmployees
{
    partial class frmShowEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowEmployees));
            employeeBindingSource = new BindingSource(components);
            gbEmployeeInformation = new GroupBox();
            btChange = new Button();
            label9 = new Label();
            cbGender = new ComboBox();
            Status = new Label();
            cBStatus = new ComboBox();
            lb = new Label();
            txtCccd = new TextBox();
            checkBox1 = new CheckBox();
            label10 = new Label();
            cbRole = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btImport = new Button();
            pBEmp = new PictureBox();
            txtDoB = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            dgvEmployee = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            PhoneEmp = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            employeeBindingSource2 = new BindingSource(components);
            employeeBindingSource1 = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtUrl = new TextBox();
            btUpdate = new Button();
            txtSearch = new TextBox();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            btSearch = new Button();
            pictureBox1 = new PictureBox();
            btAddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            gbEmployeeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbEmployeeInformation
            // 
            gbEmployeeInformation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbEmployeeInformation.AutoSize = true;
            gbEmployeeInformation.BackColor = Color.Transparent;
            gbEmployeeInformation.Controls.Add(btChange);
            gbEmployeeInformation.Controls.Add(label9);
            gbEmployeeInformation.Controls.Add(cbGender);
            gbEmployeeInformation.Controls.Add(Status);
            gbEmployeeInformation.Controls.Add(cBStatus);
            gbEmployeeInformation.Controls.Add(lb);
            gbEmployeeInformation.Controls.Add(txtCccd);
            gbEmployeeInformation.Controls.Add(checkBox1);
            gbEmployeeInformation.Controls.Add(label10);
            gbEmployeeInformation.Controls.Add(cbRole);
            gbEmployeeInformation.Controls.Add(label8);
            gbEmployeeInformation.Controls.Add(label7);
            gbEmployeeInformation.Controls.Add(label6);
            gbEmployeeInformation.Controls.Add(label5);
            gbEmployeeInformation.Controls.Add(label4);
            gbEmployeeInformation.Controls.Add(label3);
            gbEmployeeInformation.Controls.Add(label2);
            gbEmployeeInformation.Controls.Add(btImport);
            gbEmployeeInformation.Controls.Add(pBEmp);
            gbEmployeeInformation.Controls.Add(txtDoB);
            gbEmployeeInformation.Controls.Add(txtPassword);
            gbEmployeeInformation.Controls.Add(txtUsername);
            gbEmployeeInformation.Controls.Add(txtAddress);
            gbEmployeeInformation.Controls.Add(txtPhone);
            gbEmployeeInformation.Controls.Add(txtName);
            gbEmployeeInformation.Controls.Add(txtId);
            gbEmployeeInformation.Location = new Point(11, 66);
            gbEmployeeInformation.Name = "gbEmployeeInformation";
            gbEmployeeInformation.Size = new Size(944, 225);
            gbEmployeeInformation.TabIndex = 3;
            gbEmployeeInformation.TabStop = false;
            gbEmployeeInformation.Text = "Employee information";
            // 
            // btChange
            // 
            btChange.Location = new Point(587, 149);
            btChange.Name = "btChange";
            btChange.Size = new Size(94, 29);
            btChange.TabIndex = 33;
            btChange.Text = "Change";
            btChange.UseVisualStyleBackColor = true;
            btChange.Click += btChange_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 34);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 32;
            label9.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Man", "Woman" });
            cbGender.Location = new Point(343, 26);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(143, 28);
            cbGender.TabIndex = 31;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(512, 119);
            Status.Name = "Status";
            Status.Size = new Size(49, 20);
            Status.TabIndex = 29;
            Status.Text = "Status";
            // 
            // cBStatus
            // 
            cBStatus.FormattingEnabled = true;
            cBStatus.Items.AddRange(new object[] { "Active", "Disable" });
            cBStatus.Location = new Point(567, 115);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(143, 28);
            cBStatus.TabIndex = 28;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(539, 77);
            lb.Name = "lb";
            lb.Size = new Size(22, 20);
            lb.TabIndex = 27;
            lb.Text = "CI";
            // 
            // txtCccd
            // 
            txtCccd.Location = new Point(567, 73);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(143, 27);
            txtCccd.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(468, 125);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 25);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(519, 32);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 18;
            label10.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Employee", "Admin", "Guard" });
            cbRole.Location = new Point(567, 29);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(143, 28);
            cbRole.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 123);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "Phone";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 178);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 82);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 13;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 126);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 175);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 73);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 29);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // btImport
            // 
            btImport.Image = (Image)resources.GetObject("btImport.Image");
            btImport.Location = new Point(766, 149);
            btImport.Name = "btImport";
            btImport.Size = new Size(58, 50);
            btImport.TabIndex = 8;
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click;
            // 
            // pBEmp
            // 
            pBEmp.Image = (Image)resources.GetObject("pBEmp.Image");
            pBEmp.Location = new Point(742, 26);
            pBEmp.Name = "pBEmp";
            pBEmp.Size = new Size(118, 117);
            pBEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pBEmp.TabIndex = 7;
            pBEmp.TabStop = false;
            // 
            // txtDoB
            // 
            txtDoB.Location = new Point(343, 172);
            txtDoB.Name = "txtDoB";
            txtDoB.Size = new Size(143, 27);
            txtDoB.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(343, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(143, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(343, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(143, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(78, 172);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(143, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(78, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(143, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(143, 27);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 54);
            label1.TabIndex = 4;
            label1.Text = "Manage Employee";
            // 
            // dgvEmployee
            // 
            dgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmployee.ColumnHeadersHeight = 29;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, PhoneEmp, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvEmployee.DataSource = employeeBindingSource2;
            dgvEmployee.Location = new Point(10, 373);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(682, 200);
            dgvEmployee.TabIndex = 5;
            dgvEmployee.CellDoubleClick += dgvEmployee_CellDoubleClick;
            dgvEmployee.CellFormatting += dgvEmployee_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FullNameEmp";
            dataGridViewTextBoxColumn1.HeaderText = "FullNameEmp";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // PhoneEmp
            // 
            PhoneEmp.DataPropertyName = "PhoneEmp";
            PhoneEmp.HeaderText = "PhoneEmp";
            PhoneEmp.MinimumWidth = 6;
            PhoneEmp.Name = "PhoneEmp";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Sex";
            dataGridViewTextBoxColumn2.HeaderText = "Sex";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Cccd";
            dataGridViewTextBoxColumn3.HeaderText = "Cccd";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DoB";
            dataGridViewTextBoxColumn4.HeaderText = "DoB";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeeBindingSource2
            // 
            employeeBindingSource2.DataSource = typeof(Repository.Models.Employee);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(1557, 9);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(61, 27);
            txtUrl.TabIndex = 19;
            txtUrl.Visible = false;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(110, 292);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 20;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(210, 292);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 28);
            txtSearch.TabIndex = 21;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Location = new Point(21, 330);
            rd1.Name = "rd1";
            rd1.Size = new Size(71, 24);
            rd1.TabIndex = 22;
            rd1.TabStop = true;
            rd1.Text = "Active";
            rd1.UseVisualStyleBackColor = true;
            rd1.CheckedChanged += rd1_CheckedChanged;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(98, 330);
            rd2.Name = "rd2";
            rd2.Size = new Size(80, 24);
            rd2.TabIndex = 23;
            rd2.TabStop = true;
            rd2.Text = "Disable";
            rd2.UseVisualStyleBackColor = true;
            rd2.CheckedChanged += rd2_CheckedChanged;
            // 
            // btSearch
            // 
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.Location = new Point(384, 297);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(92, 24);
            btSearch.TabIndex = 25;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btAddEmployee
            // 
            btAddEmployee.Location = new Point(12, 291);
            btAddEmployee.Name = "btAddEmployee";
            btAddEmployee.Size = new Size(94, 29);
            btAddEmployee.TabIndex = 27;
            btAddEmployee.Text = "Create";
            btAddEmployee.UseVisualStyleBackColor = true;
            btAddEmployee.Click += btAddEmployee_Click_1;
            // 
            // frmShowEmployees
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(967, 614);
            Controls.Add(btAddEmployee);
            Controls.Add(pictureBox1);
            Controls.Add(btSearch);
            Controls.Add(rd2);
            Controls.Add(rd1);
            Controls.Add(txtSearch);
            Controls.Add(btUpdate);
            Controls.Add(txtUrl);
            Controls.Add(dgvEmployee);
            Controls.Add(label1);
            Controls.Add(gbEmployeeInformation);
            Name = "frmShowEmployees";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Show Employees";
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            gbEmployeeInformation.ResumeLayout(false);
            gbEmployeeInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource employeeBindingSource;
        private GroupBox gbEmployeeInformation;
        private Label label1;
        private DataGridView dgvEmployee;
        private BindingSource employeeBindingSource1;
        private TextBox txtId;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtName;
        private Button btImport;
        private PictureBox pBEmp;
        private TextBox txtDoB;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private ComboBox cbRole;
        private TextBox txtUrl;
        private CheckBox checkBox1;
        private Button btUpdate;
        private TextBox txtSearch;
        private RadioButton rd1;
        private RadioButton rd2;
        private Button btSearch;
        private Label lb;
        private TextBox txtCccd;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cccdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateJoinDataGridViewTextBoxColumn;
        private Label Status;
        private ComboBox cBStatus;
        private Label label9;
        private ComboBox cbGender;
        private BindingSource employeeBindingSource2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn PhoneEmp;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PictureBox pictureBox1;
        private Button btAddEmployee;
        private Button btChange;
    }
}