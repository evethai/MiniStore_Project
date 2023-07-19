namespace MiniStoreWinF.ManageEmployees
{
    partial class frmCreateEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateEmployees));
            panel1 = new Panel();
            label14 = new Label();
            txtSub = new TextBox();
            pbImport = new PictureBox();
            btImport = new Button();
            pbEmployee = new PictureBox();
            cbGender = new ComboBox();
            dtDoB = new DateTimePicker();
            txtAddAddress = new TextBox();
            txtAddPhone = new TextBox();
            txtAddCCCD = new TextBox();
            txtAddName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtImport = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            pnAccount = new Panel();
            label9 = new Label();
            cbIdType = new ComboBox();
            cbShowPassword = new CheckBox();
            pbInvalid = new PictureBox();
            pbValid = new PictureBox();
            cbRole = new ComboBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            txtUsername = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            pnAccount2 = new Panel();
            pnAccount1 = new Label();
            btAddNew = new Button();
            btClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).BeginInit();
            panel2.SuspendLayout();
            pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInvalid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbValid).BeginInit();
            pnAccount2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtSub);
            panel1.Controls.Add(pbImport);
            panel1.Controls.Add(btImport);
            panel1.Controls.Add(pbEmployee);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(dtDoB);
            panel1.Controls.Add(txtAddAddress);
            panel1.Controls.Add(txtAddPhone);
            panel1.Controls.Add(txtAddCCCD);
            panel1.Controls.Add(txtAddName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 46);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 431);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(-2, 269);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(86, 22);
            label14.TabIndex = 21;
            label14.Text = "Allowance";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSub
            // 
            txtSub.Location = new Point(77, 269);
            txtSub.Margin = new Padding(2);
            txtSub.Multiline = true;
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(140, 21);
            txtSub.TabIndex = 20;
            txtSub.KeyPress += txtSub_KeyPress;
            // 
            // pbImport
            // 
            pbImport.Image = (Image)resources.GetObject("pbImport.Image");
            pbImport.Location = new Point(212, 364);
            pbImport.Margin = new Padding(2);
            pbImport.Name = "pbImport";
            pbImport.Size = new Size(46, 38);
            pbImport.SizeMode = PictureBoxSizeMode.Zoom;
            pbImport.TabIndex = 19;
            pbImport.TabStop = false;
            pbImport.Click += btImport_Click;
            // 
            // btImport
            // 
            btImport.Location = new Point(77, 307);
            btImport.Margin = new Padding(2);
            btImport.Name = "btImport";
            btImport.Size = new Size(8, 23);
            btImport.TabIndex = 18;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Visible = false;
            btImport.Click += btImport_Click;
            // 
            // pbEmployee
            // 
            pbEmployee.BorderStyle = BorderStyle.Fixed3D;
            pbEmployee.Location = new Point(90, 306);
            pbEmployee.Margin = new Padding(2);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(118, 96);
            pbEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmployee.TabIndex = 17;
            pbEmployee.TabStop = false;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Man", "Woman" });
            cbGender.Location = new Point(77, 58);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(94, 23);
            cbGender.TabIndex = 16;
            // 
            // dtDoB
            // 
            dtDoB.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtDoB.Format = DateTimePickerFormat.Custom;
            dtDoB.Location = new Point(77, 152);
            dtDoB.Margin = new Padding(2);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(202, 21);
            dtDoB.TabIndex = 13;
            // 
            // txtAddAddress
            // 
            txtAddAddress.Location = new Point(77, 229);
            txtAddAddress.Margin = new Padding(2);
            txtAddAddress.Multiline = true;
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(202, 21);
            txtAddAddress.TabIndex = 11;
            // 
            // txtAddPhone
            // 
            txtAddPhone.Location = new Point(77, 186);
            txtAddPhone.Margin = new Padding(2);
            txtAddPhone.Multiline = true;
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(142, 21);
            txtAddPhone.TabIndex = 10;
            txtAddPhone.KeyPress += txtAddPhone_KeyPress;
            // 
            // txtAddCCCD
            // 
            txtAddCCCD.Location = new Point(77, 105);
            txtAddCCCD.Margin = new Padding(2);
            txtAddCCCD.Multiline = true;
            txtAddCCCD.Name = "txtAddCCCD";
            txtAddCCCD.Size = new Size(202, 21);
            txtAddCCCD.TabIndex = 9;
            txtAddCCCD.KeyPress += txtAddCCCD_KeyPress;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(77, 22);
            txtAddName.Margin = new Padding(2);
            txtAddName.Multiline = true;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(202, 21);
            txtAddName.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(31, 23);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 18);
            label8.TabIndex = 7;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 304);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 24);
            label7.TabIndex = 6;
            label7.Text = "Picture";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 228);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 22);
            label6.TabIndex = 5;
            label6.Text = "Address";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 189);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 3;
            label4.Text = "DoB";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 3;
            label3.Text = "CCCD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImport
            // 
            txtImport.Location = new Point(354, 266);
            txtImport.Margin = new Padding(2);
            txtImport.Name = "txtImport";
            txtImport.Size = new Size(101, 23);
            txtImport.TabIndex = 19;
            txtImport.Visible = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 10);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 33);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            // 
            // pnAccount
            // 
            pnAccount.BorderStyle = BorderStyle.FixedSingle;
            pnAccount.Controls.Add(label9);
            pnAccount.Controls.Add(cbIdType);
            pnAccount.Controls.Add(cbShowPassword);
            pnAccount.Controls.Add(pbInvalid);
            pnAccount.Controls.Add(pbValid);
            pnAccount.Controls.Add(cbRole);
            pnAccount.Controls.Add(txtPassword);
            pnAccount.Controls.Add(txtConfirm);
            pnAccount.Controls.Add(txtUsername);
            pnAccount.Controls.Add(label13);
            pnAccount.Controls.Add(label12);
            pnAccount.Controls.Add(label11);
            pnAccount.Controls.Add(label10);
            pnAccount.Location = new Point(354, 46);
            pnAccount.Margin = new Padding(2);
            pnAccount.Name = "pnAccount";
            pnAccount.Size = new Size(372, 208);
            pnAccount.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(103, 158);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 13);
            label9.TabIndex = 13;
            label9.Text = "Id type";
            label9.Visible = false;
            // 
            // cbIdType
            // 
            cbIdType.FormattingEnabled = true;
            cbIdType.Items.AddRange(new object[] { "SE" });
            cbIdType.Location = new Point(149, 151);
            cbIdType.Margin = new Padding(2);
            cbIdType.Name = "cbIdType";
            cbIdType.Size = new Size(133, 23);
            cbIdType.TabIndex = 12;
            cbIdType.Visible = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(286, 62);
            cbShowPassword.Margin = new Padding(2);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(15, 14);
            cbShowPassword.TabIndex = 11;
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // pbInvalid
            // 
            pbInvalid.Image = (Image)resources.GetObject("pbInvalid.Image");
            pbInvalid.Location = new Point(286, 88);
            pbInvalid.Margin = new Padding(2);
            pbInvalid.Name = "pbInvalid";
            pbInvalid.Size = new Size(25, 21);
            pbInvalid.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvalid.TabIndex = 10;
            pbInvalid.TabStop = false;
            pbInvalid.Visible = false;
            // 
            // pbValid
            // 
            pbValid.Image = (Image)resources.GetObject("pbValid.Image");
            pbValid.Location = new Point(286, 88);
            pbValid.Margin = new Padding(2);
            pbValid.Name = "pbValid";
            pbValid.Size = new Size(25, 21);
            pbValid.SizeMode = PictureBoxSizeMode.Zoom;
            pbValid.TabIndex = 9;
            pbValid.TabStop = false;
            pbValid.Visible = false;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(149, 120);
            cbRole.Margin = new Padding(2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(133, 23);
            cbRole.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 57);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(149, 88);
            txtConfirm.Margin = new Padding(2);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(133, 23);
            txtConfirm.TabIndex = 6;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(149, 21);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(133, 23);
            txtUsername.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(90, 124);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(30, 13);
            label13.TabIndex = 3;
            label13.Text = "Role";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(78, 88);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 13);
            label12.TabIndex = 2;
            label12.Text = "Confirm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(71, 54);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 13);
            label11.TabIndex = 1;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(71, 24);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 13);
            label10.TabIndex = 0;
            label10.Text = "Username";
            // 
            // pnAccount2
            // 
            pnAccount2.BorderStyle = BorderStyle.Fixed3D;
            pnAccount2.Controls.Add(pnAccount1);
            pnAccount2.Location = new Point(354, 10);
            pnAccount2.Margin = new Padding(2);
            pnAccount2.Name = "pnAccount2";
            pnAccount2.Size = new Size(373, 33);
            pnAccount2.TabIndex = 3;
            // 
            // pnAccount1
            // 
            pnAccount1.AutoSize = true;
            pnAccount1.Location = new Point(134, 9);
            pnAccount1.Margin = new Padding(2, 0, 2, 0);
            pnAccount1.Name = "pnAccount1";
            pnAccount1.Size = new Size(118, 15);
            pnAccount1.TabIndex = 0;
            pnAccount1.Text = "Account Information";
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(651, 426);
            btAddNew.Margin = new Padding(2);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(75, 23);
            btAddNew.TabIndex = 9;
            btAddNew.Text = "Add";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(651, 454);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 10;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // frmCreateEmployees
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(736, 486);
            Controls.Add(txtImport);
            Controls.Add(btClose);
            Controls.Add(btAddNew);
            Controls.Add(pnAccount2);
            Controls.Add(pnAccount);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmCreateEmployees";
            Text = "CreateEmployees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnAccount.ResumeLayout(false);
            pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInvalid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbValid).EndInit();
            pnAccount2.ResumeLayout(false);
            pnAccount2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private DateTimePicker dtDoB;
        private TextBox txtAddAddress;
        private TextBox txtAddPhone;
        private TextBox txtAddCCCD;
        private TextBox txtAddName;
        private Label label1;
        private Panel pnAccount;
        private Panel pnAccount2;
        private Label pnAccount1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cbRole;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtUsername;
        private Button btAddNew;
        private ComboBox cbGender;
        private Button btImport;
        private PictureBox pbEmployee;
        private Button btClose;
        private TextBox txtImport;
        private PictureBox pbValid;
        private PictureBox pbInvalid;
        private CheckBox cbShowPassword;
        private PictureBox pbImport;
        private Label label9;
        private ComboBox cbIdType;
        private Label label14;
        private TextBox txtSub;
    }
}