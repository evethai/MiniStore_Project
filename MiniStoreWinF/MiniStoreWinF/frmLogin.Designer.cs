namespace MiniStoreWinF
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
            ptbSeePasswords = new PictureBox();
            ptbNoSeePasswords = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSeePasswords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoSeePasswords).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(ptbSeePasswords);
            panel2.Controls.Add(ptbNoSeePasswords);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(btLogin);
            panel2.Location = new Point(105, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 183);
            panel2.TabIndex = 1;
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
            panel1.Location = new Point(29, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 62);
            panel1.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(101, 36);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(222, 27);
            txtUserName.TabIndex = 6;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(101, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(222, 27);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btLogin
            // 
            btLogin.BackColor = SystemColors.Control;
            btLogin.Image = (Image)resources.GetObject("btLogin.Image");
            btLogin.Location = new Point(320, 132);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(88, 44);
            btLogin.TabIndex = 4;
            btLogin.TextAlign = ContentAlignment.MiddleLeft;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(146, 31);
            button1.Name = "button1";
            button1.Size = new Size(304, 183);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(558, 442);
            Controls.Add(button1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSeePasswords).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoSeePasswords).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtPassword;
        private Button btLogin;
        private TextBox txtUserName;
        private Button button1;
        private Panel panel3;
        private Panel panel1;
        private PictureBox ptbNoSeePasswords;
        private PictureBox ptbSeePasswords;
    }
}