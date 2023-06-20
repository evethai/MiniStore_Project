namespace MiniStoreWinF.ManageEmployees
{
    partial class frmShowEmployee
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
            employeeBindingSource = new BindingSource(components);
            btAddEmployee = new Button();
            groupBox1 = new GroupBox();
            dtDoB = new DateTimePicker();
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            dgvEmployee = new DataGridView();
            fullNameEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cccdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateJoinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource1 = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtUrl = new TextBox();
            btUpdate = new Button();
            txtSearch = new TextBox();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            btSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // btAddEmployee
            // 
            btAddEmployee.Location = new Point(12, 361);
            btAddEmployee.Margin = new Padding(4, 4, 4, 4);
            btAddEmployee.Name = "btAddEmployee";
            btAddEmployee.Size = new Size(118, 36);
            btAddEmployee.TabIndex = 1;
            btAddEmployee.Text = "Add new";
            btAddEmployee.UseVisualStyleBackColor = true;
            btAddEmployee.Click += btAddEmployee_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtDoB);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(Status);
            groupBox1.Controls.Add(cBStatus);
            groupBox1.Controls.Add(lb);
            groupBox1.Controls.Add(txtCccd);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbRole);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btImport);
            groupBox1.Controls.Add(pBEmp);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(14, 82);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1122, 260);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee information";
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(428, 216);
            dtDoB.Margin = new Padding(4, 4, 4, 4);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(268, 31);
            dtDoB.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 43);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 32;
            label9.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Man", "Woman" });
            cbGender.Location = new Point(428, 32);
            cbGender.Margin = new Padding(4, 4, 4, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(178, 33);
            cbGender.TabIndex = 31;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(640, 148);
            Status.Margin = new Padding(4, 0, 4, 0);
            Status.Name = "Status";
            Status.Size = new Size(60, 25);
            Status.TabIndex = 29;
            Status.Text = "Status";
            // 
            // cBStatus
            // 
            cBStatus.FormattingEnabled = true;
            cBStatus.Items.AddRange(new object[] { "Active", "Disable" });
            cBStatus.Location = new Point(708, 144);
            cBStatus.Margin = new Padding(4, 4, 4, 4);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(178, 33);
            cBStatus.TabIndex = 28;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(674, 96);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(28, 25);
            lb.TabIndex = 27;
            lb.Text = "CI";
            // 
            // txtCccd
            // 
            txtCccd.Location = new Point(708, 91);
            txtCccd.Margin = new Padding(4, 4, 4, 4);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(178, 31);
            txtCccd.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(585, 156);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 31);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(648, 40);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 18;
            label10.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Employee", "Admin", "Guard" });
            cbRole.Location = new Point(708, 36);
            cbRole.Margin = new Padding(4, 4, 4, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(178, 33);
            cbRole.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 154);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 15;
            label8.Text = "Phone";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 223);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 102);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 13;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 11;
            label4.Text = "Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 10;
            label3.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // btImport
            // 
            btImport.Location = new Point(960, 223);
            btImport.Margin = new Padding(4, 4, 4, 4);
            btImport.Name = "btImport";
            btImport.Size = new Size(118, 36);
            btImport.TabIndex = 8;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click_1;
            // 
            // pBEmp
            // 
            pBEmp.Location = new Point(928, 32);
            pBEmp.Margin = new Padding(4, 4, 4, 4);
            pBEmp.Name = "pBEmp";
            pBEmp.Size = new Size(192, 184);
            pBEmp.SizeMode = PictureBoxSizeMode.Zoom;
            pBEmp.TabIndex = 7;
            pBEmp.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(428, 157);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(178, 31);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(428, 102);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(178, 31);
            txtUsername.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(98, 215);
            txtAddress.Margin = new Padding(4, 4, 4, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(178, 31);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(98, 154);
            txtPhone.Margin = new Padding(4, 4, 4, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(178, 31);
            txtPhone.TabIndex = 2;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 87);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 31);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(98, 32);
            txtId.Margin = new Padding(4, 4, 4, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(178, 31);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 68);
            label1.TabIndex = 4;
            label1.Text = "Manage Employee";
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { fullNameEmpDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, cccdDataGridViewTextBoxColumn, doBDataGridViewTextBoxColumn, addressEmpDataGridViewTextBoxColumn, phoneEmpDataGridViewTextBoxColumn, dateJoinDataGridViewTextBoxColumn });
            dgvEmployee.DataSource = employeeBindingSource1;
            dgvEmployee.Location = new Point(15, 446);
            dgvEmployee.Margin = new Padding(4, 4, 4, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(1120, 235);
            dgvEmployee.TabIndex = 5;
            dgvEmployee.CellDoubleClick += dgvEmployee_CellDoubleClick;
            dgvEmployee.CellFormatting += dgvEmployee_CellFormatting;
            // 
            // fullNameEmpDataGridViewTextBoxColumn
            // 
            fullNameEmpDataGridViewTextBoxColumn.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.HeaderText = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameEmpDataGridViewTextBoxColumn.Name = "fullNameEmpDataGridViewTextBoxColumn";
            fullNameEmpDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // cccdDataGridViewTextBoxColumn
            // 
            cccdDataGridViewTextBoxColumn.DataPropertyName = "Cccd";
            cccdDataGridViewTextBoxColumn.HeaderText = "Cccd";
            cccdDataGridViewTextBoxColumn.MinimumWidth = 6;
            cccdDataGridViewTextBoxColumn.Name = "cccdDataGridViewTextBoxColumn";
            cccdDataGridViewTextBoxColumn.Width = 125;
            // 
            // doBDataGridViewTextBoxColumn
            // 
            doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            doBDataGridViewTextBoxColumn.MinimumWidth = 6;
            doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            doBDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressEmpDataGridViewTextBoxColumn
            // 
            addressEmpDataGridViewTextBoxColumn.DataPropertyName = "AddressEmp";
            addressEmpDataGridViewTextBoxColumn.HeaderText = "AddressEmp";
            addressEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressEmpDataGridViewTextBoxColumn.Name = "addressEmpDataGridViewTextBoxColumn";
            addressEmpDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneEmpDataGridViewTextBoxColumn
            // 
            phoneEmpDataGridViewTextBoxColumn.DataPropertyName = "PhoneEmp";
            phoneEmpDataGridViewTextBoxColumn.HeaderText = "PhoneEmp";
            phoneEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneEmpDataGridViewTextBoxColumn.Name = "phoneEmpDataGridViewTextBoxColumn";
            phoneEmpDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateJoinDataGridViewTextBoxColumn
            // 
            dateJoinDataGridViewTextBoxColumn.DataPropertyName = "DateJoin";
            dateJoinDataGridViewTextBoxColumn.HeaderText = "DateJoin";
            dateJoinDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateJoinDataGridViewTextBoxColumn.Name = "dateJoinDataGridViewTextBoxColumn";
            dateJoinDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource1
            // 
            employeeBindingSource1.DataSource = typeof(Repository.Models.Employee);
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
            txtUrl.Location = new Point(848, 15);
            txtUrl.Margin = new Padding(4, 4, 4, 4);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(296, 31);
            txtUrl.TabIndex = 19;
            txtUrl.Visible = false;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(138, 361);
            btUpdate.Margin = new Padding(4, 4, 4, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(118, 36);
            btUpdate.TabIndex = 20;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(262, 361);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(209, 31);
            txtSearch.TabIndex = 21;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Location = new Point(26, 412);
            rd1.Margin = new Padding(4, 4, 4, 4);
            rd1.Name = "rd1";
            rd1.Size = new Size(81, 29);
            rd1.TabIndex = 22;
            rd1.TabStop = true;
            rd1.Text = "Active";
            rd1.UseVisualStyleBackColor = true;
            rd1.CheckedChanged += rd1_CheckedChanged;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(122, 412);
            rd2.Margin = new Padding(4, 4, 4, 4);
            rd2.Name = "rd2";
            rd2.Size = new Size(91, 29);
            rd2.TabIndex = 23;
            rd2.TabStop = true;
            rd2.Text = "Disable";
            rd2.UseVisualStyleBackColor = true;
            rd2.CheckedChanged += rd2_CheckedChanged;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(480, 360);
            btSearch.Margin = new Padding(4, 4, 4, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(118, 36);
            btSearch.TabIndex = 25;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // frmShowEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 760);
            Controls.Add(btSearch);
            Controls.Add(rd2);
            Controls.Add(rd1);
            Controls.Add(txtSearch);
            Controls.Add(btUpdate);
            Controls.Add(txtUrl);
            Controls.Add(dgvEmployee);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btAddEmployee);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmShowEmployee";
            Text = "ShowEmployees";
            Load += ShowEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource employeeBindingSource;
        private Button btAddEmployee;
        private GroupBox groupBox1;
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
        private DateTimePicker dtDoB;
    }
}