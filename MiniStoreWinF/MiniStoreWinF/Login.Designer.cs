namespace MiniStoreWinF
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(248, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 181);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(btLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(143, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 249);
            panel2.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(144, 31);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(222, 44);
            txtUserName.TabIndex = 6;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 122);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 44);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btLogin
            // 
            btLogin.BackColor = SystemColors.ActiveCaption;
            btLogin.Location = new Point(349, 185);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 44);
            btLogin.TabIndex = 4;
            btLogin.Text = "LOGIN";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(39, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(72, 64);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(39, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(72, 64);
            panel3.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 526);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassword;
        private Button btLogin;
        private Panel panel4;
        private Panel panel3;
        private TextBox txtUserName;
    }
}