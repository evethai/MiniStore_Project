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
            pcPictureEmp = new PictureBox();
            txtFullName = new TextBox();
            panel1.SuspendLayout();
            pnlShowResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureEmp).BeginInit();
            SuspendLayout();
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
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 617);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
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
            pnlShowResetPassword.Location = new Point(730, 174);
            pnlShowResetPassword.Name = "pnlShowResetPassword";
            pnlShowResetPassword.Size = new Size(540, 370);
            pnlShowResetPassword.TabIndex = 26;
            pnlShowResetPassword.Visible = false;
            // 
            // chbConfirmSuccess
            // 
            chbConfirmSuccess.AutoSize = true;
            chbConfirmSuccess.Enabled = false;
            chbConfirmSuccess.Location = new Point(417, 205);
            chbConfirmSuccess.Name = "chbConfirmSuccess";
            chbConfirmSuccess.Size = new Size(18, 17);
            chbConfirmSuccess.TabIndex = 32;
            chbConfirmSuccess.UseVisualStyleBackColor = true;
            // 
            // cbCheckExactly
            // 
            cbCheckExactly.AutoSize = true;
            cbCheckExactly.Enabled = false;
            cbCheckExactly.Location = new Point(417, 58);
            cbCheckExactly.Name = "cbCheckExactly";
            cbCheckExactly.Size = new Size(18, 17);
            cbCheckExactly.TabIndex = 31;
            cbCheckExactly.UseVisualStyleBackColor = true;
            // 
            // btChangePassword
            // 
            btChangePassword.Location = new Point(279, 251);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(126, 39);
            btChangePassword.TabIndex = 30;
            btChangePassword.Text = "Change";
            btChangePassword.UseVisualStyleBackColor = true;
            btChangePassword.Click += btChangePassword_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(221, 113);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(187, 38);
            txtNewPassword.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 120);
            label5.Name = "label5";
            label5.Size = new Size(162, 31);
            label5.TabIndex = 28;
            label5.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(221, 37);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(187, 38);
            txtCurrentPassword.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(192, 31);
            label3.TabIndex = 26;
            label3.Text = "Current Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(221, 184);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(187, 38);
            txtConfirmNewPassword.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 191);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 24;
            label2.Text = "Confirm";
            // 
            // btResetPassword
            // 
            btResetPassword.Location = new Point(1144, 90);
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
            label1.Location = new Point(804, 90);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 21;
            label1.Text = "Password";
            // 
            // txtPassworkShow
            // 
            txtPassworkShow.Location = new Point(951, 90);
            txtPassworkShow.Name = "txtPassworkShow";
            txtPassworkShow.PasswordChar = '*';
            txtPassworkShow.ReadOnly = true;
            txtPassworkShow.Size = new Size(187, 38);
            txtPassworkShow.TabIndex = 22;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(796, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(127, 31);
            lblUserName.TabIndex = 18;
            lblUserName.Text = "User Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(420, 503);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(224, 38);
            txtPhone.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(951, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(187, 38);
            txtUsername.TabIndex = 20;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(316, 506);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 31);
            lblPhone.TabIndex = 17;
            lblPhone.Text = "Phone";
            // 
            // txtIdEmp
            // 
            txtIdEmp.Location = new Point(420, 23);
            txtIdEmp.Name = "txtIdEmp";
            txtIdEmp.ReadOnly = true;
            txtIdEmp.Size = new Size(106, 38);
            txtIdEmp.TabIndex = 16;
            // 
            // lbl_IdEmp
            // 
            lbl_IdEmp.AutoSize = true;
            lbl_IdEmp.Location = new Point(316, 23);
            lbl_IdEmp.Name = "lbl_IdEmp";
            lbl_IdEmp.Size = new Size(88, 31);
            lbl_IdEmp.TabIndex = 15;
            lbl_IdEmp.Text = "ID Emp";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(420, 409);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(277, 38);
            txtAddress.TabIndex = 14;
            // 
            // txtBoD
            // 
            txtBoD.Location = new Point(420, 330);
            txtBoD.Name = "txtBoD";
            txtBoD.ReadOnly = true;
            txtBoD.Size = new Size(141, 38);
            txtBoD.TabIndex = 13;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(420, 247);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(187, 38);
            txtCCCD.TabIndex = 12;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(420, 174);
            txtSex.Name = "txtSex";
            txtSex.ReadOnly = true;
            txtSex.Size = new Size(106, 38);
            txtSex.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 409);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // lbl_DoB
            // 
            lbl_DoB.AutoSize = true;
            lbl_DoB.Location = new Point(303, 330);
            lbl_DoB.Name = "lbl_DoB";
            lbl_DoB.Size = new Size(99, 31);
            lbl_DoB.TabIndex = 9;
            lbl_DoB.Text = "Birthday";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(332, 247);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(70, 31);
            lblCCCD.TabIndex = 8;
            lblCCCD.Text = "CCCD";
            // 
            // lbl_Sex
            // 
            lbl_Sex.AutoSize = true;
            lbl_Sex.Location = new Point(313, 174);
            lbl_Sex.Name = "lbl_Sex";
            lbl_Sex.Size = new Size(89, 31);
            lbl_Sex.TabIndex = 7;
            lbl_Sex.Text = "Gender";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(285, 100);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(117, 31);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Full Name";
            // 
            // pcPictureEmp
            // 
            pcPictureEmp.Location = new Point(49, 23);
            pcPictureEmp.Name = "pcPictureEmp";
            pcPictureEmp.Size = new Size(202, 165);
            pcPictureEmp.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureEmp.TabIndex = 0;
            pcPictureEmp.TabStop = false;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(420, 97);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(187, 38);
            txtFullName.TabIndex = 1;
            // 
            // frmInformationEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1411, 617);
            Controls.Add(panel1);
            Name = "frmInformationEmp";
            Text = "frmInformationEmp";
            Load += frmInformationEmp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlShowResetPassword.ResumeLayout(false);
            pnlShowResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureEmp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlShowResetPassword;
        private CheckBox chbConfirmSuccess;
        private CheckBox cbCheckExactly;
        private Button btChangePassword;
        private TextBox txtNewPassword;
        private Label label5;
        private TextBox txtCurrentPassword;
        private Label label3;
        private TextBox txtConfirmNewPassword;
        private Label label2;
        private Button btResetPassword;
        private Label label1;
        private TextBox txtPassworkShow;
        private Label lblUserName;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private Label lblPhone;
        private TextBox txtIdEmp;
        private Label lbl_IdEmp;
        private TextBox txtAddress;
        private TextBox txtBoD;
        private TextBox txtCCCD;
        private TextBox txtSex;
        private Label label4;
        private Label lbl_DoB;
        private Label lblCCCD;
        private Label lbl_Sex;
        private Label lblFullName;
        private PictureBox pcPictureEmp;
        private TextBox txtFullName;
    }
}