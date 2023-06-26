namespace MiniStoreWinF.InformationEmployee
{
    partial class frmInformationEmp
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
            pcPictureEmp = new PictureBox();
            txtFullName = new TextBox();
            panel1 = new Panel();
            pnlShowResetPassword = new Panel();
            chbConfirmSuccess = new CheckBox();
            cbCheckExactly = new CheckBox();
            btChangePassword = new Button();
            txtNewPassword = new TextBox();
            label5 = new Label();
            txtCurrentPassword = new TextBox();
            label3 = new Label();
            txtConfirmNewPassword = new TextBox();
            label2 = new Label();
            btResetPassword = new Button();
            label1 = new Label();
            txtPassworkShow = new TextBox();
            lblUserName = new Label();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            lblPhone = new Label();
            txtIdEmp = new TextBox();
            lbl_IdEmp = new Label();
            txtAddress = new TextBox();
            txtBoD = new TextBox();
            txtCCCD = new TextBox();
            txtSex = new TextBox();
            label4 = new Label();
            lbl_DoB = new Label();
            lblCCCD = new Label();
            lbl_Sex = new Label();
            lblFullName = new Label();
            ((System.ComponentModel.ISupportInitialize)pcPictureEmp).BeginInit();
            panel1.SuspendLayout();
            pnlShowResetPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pcPictureEmp
            // 
            pcPictureEmp.Location = new Point(301, 12);
            pcPictureEmp.Name = "pcPictureEmp";
            pcPictureEmp.Size = new Size(235, 184);
            pcPictureEmp.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureEmp.TabIndex = 0;
            pcPictureEmp.TabStop = false;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(134, 253);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(187, 27);
            txtFullName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlShowResetPassword);
            panel1.Controls.Add(btResetPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassworkShow);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtIdEmp);
            panel1.Controls.Add(lbl_IdEmp);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtBoD);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(txtSex);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbl_DoB);
            panel1.Controls.Add(lblCCCD);
            panel1.Controls.Add(lbl_Sex);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(pcPictureEmp);
            panel1.Controls.Add(txtFullName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 617);
            panel1.TabIndex = 6;
            // 
            // pnlShowResetPassword
            // 
            pnlShowResetPassword.Controls.Add(chbConfirmSuccess);
            pnlShowResetPassword.Controls.Add(cbCheckExactly);
            pnlShowResetPassword.Controls.Add(btChangePassword);
            pnlShowResetPassword.Controls.Add(txtNewPassword);
            pnlShowResetPassword.Controls.Add(label5);
            pnlShowResetPassword.Controls.Add(txtCurrentPassword);
            pnlShowResetPassword.Controls.Add(label3);
            pnlShowResetPassword.Controls.Add(txtConfirmNewPassword);
            pnlShowResetPassword.Controls.Add(label2);
            pnlShowResetPassword.Enabled = false;
            pnlShowResetPassword.Location = new Point(417, 349);
            pnlShowResetPassword.Name = "pnlShowResetPassword";
            pnlShowResetPassword.Size = new Size(396, 210);
            pnlShowResetPassword.TabIndex = 26;
            pnlShowResetPassword.Visible = false;
            // 
            // chbConfirmSuccess
            // 
            chbConfirmSuccess.AutoSize = true;
            chbConfirmSuccess.Enabled = false;
            chbConfirmSuccess.Location = new Point(339, 127);
            chbConfirmSuccess.Name = "chbConfirmSuccess";
            chbConfirmSuccess.Size = new Size(18, 17);
            chbConfirmSuccess.TabIndex = 32;
            chbConfirmSuccess.UseVisualStyleBackColor = true;
            // 
            // cbCheckExactly
            // 
            cbCheckExactly.AutoSize = true;
            cbCheckExactly.Enabled = false;
            cbCheckExactly.Location = new Point(339, 15);
            cbCheckExactly.Name = "cbCheckExactly";
            cbCheckExactly.Size = new Size(18, 17);
            cbCheckExactly.TabIndex = 31;
            cbCheckExactly.UseVisualStyleBackColor = true;
            // 
            // btChangePassword
            // 
            btChangePassword.Location = new Point(252, 159);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(126, 39);
            btChangePassword.TabIndex = 30;
            btChangePassword.Text = "Change";
            btChangePassword.UseVisualStyleBackColor = true;
            btChangePassword.Click += btChangePassword_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(143, 66);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(187, 27);
            txtNewPassword.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 66);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 28;
            label5.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(143, 12);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(187, 27);
            txtCurrentPassword.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 26;
            label3.Text = "Current Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(143, 120);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(187, 27);
            txtConfirmNewPassword.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 24;
            label2.Text = "Confirm";
            // 
            // btResetPassword
            // 
            btResetPassword.Location = new Point(669, 304);
            btResetPassword.Name = "btResetPassword";
            btResetPassword.Size = new Size(126, 39);
            btResetPassword.TabIndex = 23;
            btResetPassword.Text = "Reset Password";
            btResetPassword.UseVisualStyleBackColor = true;
            btResetPassword.Click += btResetPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 311);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 21;
            label1.Text = "Password";
            // 
            // txtPassworkShow
            // 
            txtPassworkShow.Location = new Point(463, 304);
            txtPassworkShow.Name = "txtPassworkShow";
            txtPassworkShow.PasswordChar = '*';
            txtPassworkShow.ReadOnly = true;
            txtPassworkShow.Size = new Size(187, 27);
            txtPassworkShow.TabIndex = 22;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(375, 260);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(82, 20);
            lblUserName.TabIndex = 18;
            lblUserName.Text = "User Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(134, 508);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(224, 27);
            txtPhone.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(463, 253);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(187, 27);
            txtUsername.TabIndex = 20;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(36, 508);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 17;
            lblPhone.Text = "Phone";
            // 
            // txtIdEmp
            // 
            txtIdEmp.Location = new Point(134, 202);
            txtIdEmp.Name = "txtIdEmp";
            txtIdEmp.ReadOnly = true;
            txtIdEmp.Size = new Size(106, 27);
            txtIdEmp.TabIndex = 16;
            // 
            // lbl_IdEmp
            // 
            lbl_IdEmp.AutoSize = true;
            lbl_IdEmp.Location = new Point(36, 202);
            lbl_IdEmp.Name = "lbl_IdEmp";
            lbl_IdEmp.Size = new Size(58, 20);
            lbl_IdEmp.TabIndex = 15;
            lbl_IdEmp.Text = "ID Emp";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(134, 457);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(277, 27);
            txtAddress.TabIndex = 14;
            // 
            // txtBoD
            // 
            txtBoD.Location = new Point(134, 406);
            txtBoD.Name = "txtBoD";
            txtBoD.ReadOnly = true;
            txtBoD.Size = new Size(141, 27);
            txtBoD.TabIndex = 13;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(134, 355);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(187, 27);
            txtCCCD.TabIndex = 12;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(134, 304);
            txtSex.Name = "txtSex";
            txtSex.ReadOnly = true;
            txtSex.Size = new Size(106, 27);
            txtSex.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 457);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // lbl_DoB
            // 
            lbl_DoB.AutoSize = true;
            lbl_DoB.Location = new Point(36, 406);
            lbl_DoB.Name = "lbl_DoB";
            lbl_DoB.Size = new Size(64, 20);
            lbl_DoB.TabIndex = 9;
            lbl_DoB.Text = "Birthday";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(36, 355);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(47, 20);
            lblCCCD.TabIndex = 8;
            lblCCCD.Text = "CCCD";
            // 
            // lbl_Sex
            // 
            lbl_Sex.AutoSize = true;
            lbl_Sex.Location = new Point(36, 304);
            lbl_Sex.Name = "lbl_Sex";
            lbl_Sex.Size = new Size(32, 20);
            lbl_Sex.TabIndex = 7;
            lbl_Sex.Text = "Sex";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(36, 253);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Full Name";
            // 
            // frmInformationEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 617);
            Controls.Add(panel1);
            Name = "frmInformationEmp";
            Text = "frmInformationEmp";
            Load += frmInformationEmp_Load;
            ((System.ComponentModel.ISupportInitialize)pcPictureEmp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlShowResetPassword.ResumeLayout(false);
            pnlShowResetPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcPictureEmp;
        private TextBox txtFullName;
        private Panel panel1;
        private TextBox txtAddress;
        private TextBox txtBoD;
        private TextBox txtCCCD;
        private TextBox txtSex;
        private Label label4;
        private Label lbl_DoB;
        private Label lblCCCD;
        private Label lbl_Sex;
        private Label lblFullName;
        private TextBox txtIdEmp;
        private Label lbl_IdEmp;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private Label lblUserName;
        private Label lblPhone;
        private Label label1;
        private TextBox txtPassworkShow;
        private Button btResetPassword;
        private Panel pnlShowResetPassword;
        private TextBox txtConfirmNewPassword;
        private Label label2;
        private Button btChangePassword;
        private TextBox txtNewPassword;
        private Label label5;
        private TextBox txtCurrentPassword;
        private Label label3;
        private CheckBox cbCheckExactly;
        private CheckBox chbConfirmSuccess;
    }
}