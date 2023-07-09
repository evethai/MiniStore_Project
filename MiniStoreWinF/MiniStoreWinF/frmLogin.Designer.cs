﻿namespace MiniStoreWinF
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel2 = new Panel();
            lblname = new Label();
            txtUserName = new TextBox();
            lblpass = new Label();
            btnLogin = new Button();
            ptbSeePasswords = new PictureBox();
            ptbNoSeePasswords = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            txtPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSeePasswords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoSeePasswords).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblname);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(lblpass);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(ptbSeePasswords);
            panel2.Controls.Add(ptbNoSeePasswords);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(12, 247);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 183);
            panel2.TabIndex = 1;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(109, 38);
            lblname.Name = "lblname";
            lblname.Size = new Size(67, 17);
            lblname.TabIndex = 14;
            lblname.Text = "Username";
            lblname.Click += lblname_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(109, 35);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 25);
            txtUserName.TabIndex = 16;
            txtUserName.Enter += txtUserName_Enter_1;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(109, 102);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(64, 17);
            lblpass.TabIndex = 15;
            lblpass.Text = "Password";
            lblpass.Click += lblpass_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(166, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 40);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btLogin_Click;
            // 
            // ptbSeePasswords
            // 
            ptbSeePasswords.Image = (Image)resources.GetObject("ptbSeePasswords.Image");
            ptbSeePasswords.Location = new Point(329, 99);
            ptbSeePasswords.Name = "ptbSeePasswords";
            ptbSeePasswords.Size = new Size(32, 32);
            ptbSeePasswords.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbSeePasswords.TabIndex = 12;
            ptbSeePasswords.TabStop = false;
            ptbSeePasswords.Click += ptbSeePasswords_Click;
            // 
            // ptbNoSeePasswords
            // 
            ptbNoSeePasswords.Image = (Image)resources.GetObject("ptbNoSeePasswords.Image");
            ptbNoSeePasswords.Location = new Point(329, 99);
            ptbNoSeePasswords.Name = "ptbNoSeePasswords";
            ptbNoSeePasswords.Size = new Size(32, 32);
            ptbNoSeePasswords.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbNoSeePasswords.TabIndex = 11;
            ptbNoSeePasswords.TabStop = false;
            ptbNoSeePasswords.Visible = false;
            ptbNoSeePasswords.Click += ptbNoSeePasswords_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(29, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(74, 62);
            panel3.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(29, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 62);
            panel1.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(101, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(222, 25);
            txtPassword.TabIndex = 17;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(69, 58);
            button1.Name = "button1";
            button1.Size = new Size(304, 183);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(441, 43);
            label1.TabIndex = 3;
            label1.Text = "MiniStore Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(441, 442);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(457, 481);
            MinimumSize = new Size(457, 481);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSeePasswords).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoSeePasswords).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtPassword;
        private Button button1;
        private Panel panel3;
        private Panel panel1;
        private PictureBox ptbNoSeePasswords;
        private PictureBox ptbSeePasswords;
        private Label label1;
        private Button btnLogin;
        private Label lblpass;
        private Label lblname;
        private TextBox txtUserName;
    }
}