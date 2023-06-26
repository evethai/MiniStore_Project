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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowEmployee));
            employeeBindingSource = new BindingSource(components);
            btAddEmployee = new Button();
            employeeBindingSource1 = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtUrl = new TextBox();
            btUpdate = new Button();
            txtSearch = new TextBox();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            btSearch = new Button();
            pnButton = new Panel();
            pbSearch = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvEmployee = new DataGridView();
            fullNameEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cccdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateJoinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tbMain = new TableLayoutPanel();
            pnInfor = new Panel();
            pbImport = new PictureBox();
            txtRole = new TextBox();
            dtDoB = new DateTimePicker();
            label9 = new Label();
            cbGender = new ComboBox();
            Status = new Label();
            cBStatus = new ComboBox();
            lb = new Label();
            txtCccd = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btImport = new Button();
            pBEmp = new PictureBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btShow = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            tbMain.SuspendLayout();
            pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBEmp).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 416);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 55;
            label1.Text = "Update";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // btAddEmployee
            // 
            btAddEmployee.Location = new Point(4, 94);
            btAddEmployee.Margin = new Padding(4, 5, 4, 5);
            btAddEmployee.Name = "btAddEmployee";
            btAddEmployee.Size = new Size(264, 72);
            btAddEmployee.TabIndex = 1;
            btAddEmployee.Text = "Create Employee";
            btAddEmployee.UseVisualStyleBackColor = true;
            btAddEmployee.Click += btAddEmployee_Click;
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
            txtUrl.Location = new Point(932, 17);
            txtUrl.Margin = new Padding(4, 5, 4, 5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(326, 34);
            txtUrl.TabIndex = 19;
            txtUrl.Visible = false;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(960, 50);
            btUpdate.Margin = new Padding(4, 5, 4, 5);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(10, 10);
            btUpdate.TabIndex = 20;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Visible = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 8);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(229, 34);
            txtSearch.TabIndex = 21;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Location = new Point(310, 10);
            rd1.Margin = new Padding(4, 5, 4, 5);
            rd1.Name = "rd1";
            rd1.Size = new Size(87, 32);
            rd1.TabIndex = 22;
            rd1.TabStop = true;
            rd1.Text = "Active";
            rd1.UseVisualStyleBackColor = true;
            rd1.CheckedChanged += rd1_CheckedChanged;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(397, 10);
            rd2.Margin = new Padding(4, 5, 4, 5);
            rd2.Name = "rd2";
            rd2.Size = new Size(97, 32);
            rd2.TabIndex = 23;
            rd2.TabStop = true;
            rd2.Text = "Disable";
            rd2.UseVisualStyleBackColor = true;
            rd2.CheckedChanged += rd2_CheckedChanged;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(896, 49);
            btSearch.Margin = new Padding(4, 5, 4, 5);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(16, 14);
            btSearch.TabIndex = 25;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Visible = false;
            btSearch.Click += btSearch_Click;
            // 
            // pnButton
            // 
            pnButton.BorderStyle = BorderStyle.Fixed3D;
            pnButton.Controls.Add(pbSearch);
            pnButton.Controls.Add(rd1);
            pnButton.Controls.Add(rd2);
            pnButton.Controls.Add(txtSearch);
            pnButton.Dock = DockStyle.Fill;
            pnButton.Location = new Point(3, 4);
            pnButton.Margin = new Padding(3, 4, 3, 4);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(1338, 61);
            pnButton.TabIndex = 27;
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(249, 4);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(54, 50);
            pbSearch.TabIndex = 27;
            pbSearch.TabStop = false;
            pbSearch.Click += btSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btUpdate_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { fullNameEmpDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, cccdDataGridViewTextBoxColumn, doBDataGridViewTextBoxColumn, addressEmpDataGridViewTextBoxColumn, phoneEmpDataGridViewTextBoxColumn, dateJoinDataGridViewTextBoxColumn });
            dgvEmployee.DataSource = employeeBindingSource1;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(4, 74);
            dgvEmployee.Margin = new Padding(4, 5, 4, 5);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(1336, 383);
            dgvEmployee.TabIndex = 6;
            dgvEmployee.CellDoubleClick += dgvEmployee_CellDoubleClick;
            dgvEmployee.CellFormatting += dgvEmployee_CellFormatting;
            // 
            // fullNameEmpDataGridViewTextBoxColumn
            // 
            fullNameEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameEmpDataGridViewTextBoxColumn.DataPropertyName = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.HeaderText = "FullNameEmp";
            fullNameEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameEmpDataGridViewTextBoxColumn.Name = "fullNameEmpDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // cccdDataGridViewTextBoxColumn
            // 
            cccdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cccdDataGridViewTextBoxColumn.DataPropertyName = "Cccd";
            cccdDataGridViewTextBoxColumn.HeaderText = "Cccd";
            cccdDataGridViewTextBoxColumn.MinimumWidth = 6;
            cccdDataGridViewTextBoxColumn.Name = "cccdDataGridViewTextBoxColumn";
            // 
            // doBDataGridViewTextBoxColumn
            // 
            doBDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            doBDataGridViewTextBoxColumn.MinimumWidth = 6;
            doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            // 
            // addressEmpDataGridViewTextBoxColumn
            // 
            addressEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressEmpDataGridViewTextBoxColumn.DataPropertyName = "AddressEmp";
            addressEmpDataGridViewTextBoxColumn.HeaderText = "AddressEmp";
            addressEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressEmpDataGridViewTextBoxColumn.Name = "addressEmpDataGridViewTextBoxColumn";
            // 
            // phoneEmpDataGridViewTextBoxColumn
            // 
            phoneEmpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneEmpDataGridViewTextBoxColumn.DataPropertyName = "PhoneEmp";
            phoneEmpDataGridViewTextBoxColumn.HeaderText = "PhoneEmp";
            phoneEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneEmpDataGridViewTextBoxColumn.Name = "phoneEmpDataGridViewTextBoxColumn";
            // 
            // dateJoinDataGridViewTextBoxColumn
            // 
            dateJoinDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateJoinDataGridViewTextBoxColumn.DataPropertyName = "DateJoin";
            dateJoinDataGridViewTextBoxColumn.HeaderText = "DateJoin";
            dateJoinDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateJoinDataGridViewTextBoxColumn.Name = "dateJoinDataGridViewTextBoxColumn";
            // 
            // tbMain
            // 
            tbMain.ColumnCount = 1;
            tbMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbMain.Controls.Add(pnInfor, 0, 0);
            tbMain.Controls.Add(tableLayoutPanel2, 0, 1);
            tbMain.Location = new Point(283, 0);
            tbMain.Margin = new Padding(3, 4, 3, 4);
            tbMain.Name = "tbMain";
            tbMain.RowCount = 2;
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbMain.Size = new Size(1350, 939);
            tbMain.TabIndex = 54;
            tbMain.Visible = false;
            // 
            // pnInfor
            // 
            pnInfor.BorderStyle = BorderStyle.Fixed3D;
            pnInfor.Controls.Add(label1);
            pnInfor.Controls.Add(pbImport);
            pnInfor.Controls.Add(pictureBox1);
            pnInfor.Controls.Add(btSearch);
            pnInfor.Controls.Add(txtRole);
            pnInfor.Controls.Add(dtDoB);
            pnInfor.Controls.Add(btUpdate);
            pnInfor.Controls.Add(label9);
            pnInfor.Controls.Add(cbGender);
            pnInfor.Controls.Add(Status);
            pnInfor.Controls.Add(cBStatus);
            pnInfor.Controls.Add(lb);
            pnInfor.Controls.Add(txtCccd);
            pnInfor.Controls.Add(label10);
            pnInfor.Controls.Add(label8);
            pnInfor.Controls.Add(label7);
            pnInfor.Controls.Add(label4);
            pnInfor.Controls.Add(label3);
            pnInfor.Controls.Add(label2);
            pnInfor.Controls.Add(btImport);
            pnInfor.Controls.Add(pBEmp);
            pnInfor.Controls.Add(txtAddress);
            pnInfor.Controls.Add(txtPhone);
            pnInfor.Controls.Add(txtName);
            pnInfor.Controls.Add(txtId);
            pnInfor.Dock = DockStyle.Fill;
            pnInfor.Location = new Point(3, 4);
            pnInfor.Margin = new Padding(3, 4, 3, 4);
            pnInfor.Name = "pnInfor";
            pnInfor.Size = new Size(1344, 461);
            pnInfor.TabIndex = 27;
            // 
            // pbImport
            // 
            pbImport.BackColor = Color.Transparent;
            pbImport.Image = (Image)resources.GetObject("pbImport.Image");
            pbImport.Location = new Point(809, 290);
            pbImport.Name = "pbImport";
            pbImport.Size = new Size(94, 50);
            pbImport.SizeMode = PictureBoxSizeMode.Zoom;
            pbImport.TabIndex = 54;
            pbImport.TabStop = false;
            pbImport.Click += btImport_Click_1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(462, 293);
            txtRole.Margin = new Padding(3, 4, 3, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(195, 34);
            txtRole.TabIndex = 53;
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(462, 353);
            dtDoB.Margin = new Padding(4, 5, 4, 5);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(279, 34);
            dtDoB.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 95);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 52;
            label9.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Man", "Woman" });
            cbGender.Location = new Point(462, 82);
            cbGender.Margin = new Padding(4, 5, 4, 5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(195, 36);
            cbGender.TabIndex = 51;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(387, 212);
            Status.Margin = new Padding(4, 0, 4, 0);
            Status.Name = "Status";
            Status.Size = new Size(65, 28);
            Status.TabIndex = 50;
            Status.Text = "Status";
            // 
            // cBStatus
            // 
            cBStatus.FormattingEnabled = true;
            cBStatus.Items.AddRange(new object[] { "Active", "Disable" });
            cBStatus.Location = new Point(462, 208);
            cBStatus.Margin = new Padding(4, 5, 4, 5);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(195, 36);
            cBStatus.TabIndex = 49;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(424, 155);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(29, 28);
            lb.TabIndex = 48;
            lb.Text = "CI";
            // 
            // txtCccd
            // 
            txtCccd.Location = new Point(462, 148);
            txtCccd.Margin = new Padding(4, 5, 4, 5);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(195, 34);
            txtCccd.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(400, 296);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 28);
            label10.TabIndex = 45;
            label10.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 222);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 28);
            label8.TabIndex = 44;
            label8.Text = "Phone";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 299);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 43;
            label7.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 359);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 42;
            label4.Text = "Birth";
            // 
            // label3
            // 
            label3.Location = new Point(28, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 41;
            label3.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 28);
            label2.TabIndex = 40;
            label2.Text = "Id";
            // 
            // btImport
            // 
            btImport.Location = new Point(941, 49);
            btImport.Margin = new Padding(4, 5, 4, 5);
            btImport.Name = "btImport";
            btImport.Size = new Size(10, 12);
            btImport.TabIndex = 39;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Visible = false;
            // 
            // pBEmp
            // 
            pBEmp.Image = (Image)resources.GetObject("pBEmp.Image");
            pBEmp.Location = new Point(754, 76);
            pBEmp.Margin = new Padding(4, 5, 4, 5);
            pBEmp.Name = "pBEmp";
            pBEmp.Size = new Size(212, 206);
            pBEmp.SizeMode = PictureBoxSizeMode.Zoom;
            pBEmp.TabIndex = 38;
            pBEmp.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(138, 290);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 34);
            txtAddress.TabIndex = 37;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(138, 222);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 34);
            txtPhone.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 147);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 34);
            txtName.TabIndex = 35;
            // 
            // txtId
            // 
            txtId.Location = new Point(138, 87);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(195, 34);
            txtId.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvEmployee, 0, 1);
            tableLayoutPanel2.Controls.Add(pnButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 473);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(1344, 462);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(btShow);
            panel1.Controls.Add(btAddEmployee);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 837);
            panel1.TabIndex = 55;
            // 
            // btShow
            // 
            btShow.Location = new Point(4, 12);
            btShow.Name = "btShow";
            btShow.Size = new Size(264, 72);
            btShow.TabIndex = 2;
            btShow.Text = "Show Employee";
            btShow.UseVisualStyleBackColor = true;
            btShow.Click += btShow_Click;
            // 
            // frmShowEmployee
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1547, 837);
            Controls.Add(panel1);
            Controls.Add(tbMain);
            Controls.Add(txtUrl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowEmployee";
            Text = "ShowEmployees";
            Load += ShowEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            pnButton.ResumeLayout(false);
            pnButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            tbMain.ResumeLayout(false);
            pnInfor.ResumeLayout(false);
            pnInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBEmp).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource employeeBindingSource;
        private Button btAddEmployee;
        private BindingSource employeeBindingSource1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtUrl;
        private Button btUpdate;
        private TextBox txtSearch;
        private RadioButton rd1;
        private RadioButton rd2;
        private Button btSearch;
        private Panel pnButton;
        private DataGridView dgvEmployee;
        private TableLayoutPanel tbMain;
        private Panel pnInfor;
        private TextBox txtRole;
        private DateTimePicker dtDoB;
        private Label label9;
        private ComboBox cbGender;
        private Label Status;
        private ComboBox cBStatus;
        private Label lb;
        private TextBox txtCccd;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btImport;
        private PictureBox pBEmp;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtId;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn fullNameEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cccdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateJoinDataGridViewTextBoxColumn;
        private Panel panel1;
        private Button btShow;
        private PictureBox pictureBox1;
        private PictureBox pbImport;
        private PictureBox pbSearch;
    }
}