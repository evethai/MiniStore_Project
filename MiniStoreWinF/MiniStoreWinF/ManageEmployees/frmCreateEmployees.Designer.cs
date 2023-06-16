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
            txtImport = new TextBox();
            btImport = new Button();
            pbEmployee = new PictureBox();
            cbGender = new ComboBox();
            btNext = new Button();
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
            panel2 = new Panel();
            label1 = new Label();
            pnAccount = new Panel();
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
            panel1.Controls.Add(txtImport);
            panel1.Controls.Add(btImport);
            panel1.Controls.Add(pbEmployee);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(btNext);
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
            panel1.Location = new Point(23, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 538);
            panel1.TabIndex = 0;
            // 
            // txtImport
            // 
            txtImport.Location = new Point(134, 496);
            txtImport.Name = "txtImport";
            txtImport.Size = new Size(125, 27);
            txtImport.TabIndex = 19;
            txtImport.Visible = false;
            // 
            // btImport
            // 
            btImport.Location = new Point(151, 460);
            btImport.Name = "btImport";
            btImport.Size = new Size(94, 29);
            btImport.TabIndex = 18;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click;
            // 
            // pbEmployee
            // 
            pbEmployee.BorderStyle = BorderStyle.Fixed3D;
            pbEmployee.Location = new Point(129, 335);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(147, 119);
            pbEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmployee.TabIndex = 17;
            pbEmployee.TabStop = false;
            pbEmployee.Click += pbEmployee_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Man", "Woman" });
            cbGender.Location = new Point(83, 73);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(117, 28);
            cbGender.TabIndex = 16;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // btNext
            // 
            btNext.Location = new Point(299, 497);
            btNext.Name = "btNext";
            btNext.Size = new Size(94, 29);
            btNext.TabIndex = 15;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // dtDoB
            // 
            dtDoB.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtDoB.Format = DateTimePickerFormat.Custom;
            dtDoB.Location = new Point(83, 189);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(251, 25);
            dtDoB.TabIndex = 13;
            // 
            // txtAddAddress
            // 
            txtAddAddress.Location = new Point(83, 286);
            txtAddAddress.Multiline = true;
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(251, 25);
            txtAddAddress.TabIndex = 11;
            // 
            // txtAddPhone
            // 
            txtAddPhone.Location = new Point(83, 237);
            txtAddPhone.Multiline = true;
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(251, 25);
            txtAddPhone.TabIndex = 10;
            // 
            // txtAddCCCD
            // 
            txtAddCCCD.Location = new Point(83, 132);
            txtAddCCCD.Multiline = true;
            txtAddCCCD.Name = "txtAddCCCD";
            txtAddCCCD.Size = new Size(251, 25);
            txtAddCCCD.TabIndex = 9;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(83, 25);
            txtAddName.Multiline = true;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(251, 25);
            txtAddName.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 27);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 7;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 335);
            label7.Name = "label7";
            label7.Size = new Size(61, 30);
            label7.TabIndex = 6;
            label7.Text = "Picture";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 286);
            label6.Name = "label6";
            label6.Size = new Size(66, 27);
            label6.TabIndex = 5;
            label6.Text = "Address";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 237);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 189);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 3;
            label4.Text = "DoB";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 134);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 3;
            label3.Text = "CCCD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 40);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 11);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            // 
            // pnAccount
            // 
            pnAccount.BorderStyle = BorderStyle.FixedSingle;
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
            pnAccount.Location = new Point(443, 58);
            pnAccount.Name = "pnAccount";
            pnAccount.Size = new Size(465, 260);
            pnAccount.TabIndex = 2;
            pnAccount.Visible = false;
            // 
            // pbInvalid
            // 
            pbInvalid.Image = (Image)resources.GetObject("pbInvalid.Image");
            pbInvalid.Location = new Point(357, 110);
            pbInvalid.Name = "pbInvalid";
            pbInvalid.Size = new Size(27, 27);
            pbInvalid.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvalid.TabIndex = 11;
            pbInvalid.TabStop = false;
            pbInvalid.Visible = false;
            // 
            // pbValid
            // 
            pbValid.Image = (Image)resources.GetObject("pbValid.Image");
            pbValid.Location = new Point(357, 110);
            pbValid.Name = "pbValid";
            pbValid.Size = new Size(27, 27);
            pbValid.SizeMode = PictureBoxSizeMode.Zoom;
            pbValid.TabIndex = 9;
            pbValid.TabStop = false;
            pbValid.Visible = false;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(186, 150);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(165, 28);
            cbRole.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(165, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(186, 110);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(165, 27);
            txtConfirm.TabIndex = 6;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(186, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(165, 27);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(89, 153);
            label13.Name = "label13";
            label13.Size = new Size(35, 17);
            label13.TabIndex = 3;
            label13.Text = "Role";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(89, 110);
            label12.Name = "label12";
            label12.Size = new Size(58, 17);
            label12.TabIndex = 2;
            label12.Text = "Confirm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(89, 68);
            label11.Name = "label11";
            label11.Size = new Size(66, 17);
            label11.TabIndex = 1;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(89, 30);
            label10.Name = "label10";
            label10.Size = new Size(69, 17);
            label10.TabIndex = 0;
            label10.Text = "Username";
            // 
            // pnAccount2
            // 
            pnAccount2.BorderStyle = BorderStyle.Fixed3D;
            pnAccount2.Controls.Add(pnAccount1);
            pnAccount2.Location = new Point(443, 12);
            pnAccount2.Name = "pnAccount2";
            pnAccount2.Size = new Size(465, 40);
            pnAccount2.TabIndex = 3;
            pnAccount2.Visible = false;
            // 
            // pnAccount1
            // 
            pnAccount1.AutoSize = true;
            pnAccount1.Location = new Point(167, 11);
            pnAccount1.Name = "pnAccount1";
            pnAccount1.Size = new Size(145, 20);
            pnAccount1.TabIndex = 0;
            pnAccount1.Text = "Account Information";
            pnAccount1.Visible = false;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(814, 555);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(94, 29);
            btAddNew.TabIndex = 9;
            btAddNew.Text = "Add";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(714, 556);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 10;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // frmCreateEmployees
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(920, 608);
            Controls.Add(btClose);
            Controls.Add(btAddNew);
            Controls.Add(pnAccount2);
            Controls.Add(pnAccount);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCreateEmployees";
            Text = "CreateEmployees";
            Load += CreateEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btNext;
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
    }
}