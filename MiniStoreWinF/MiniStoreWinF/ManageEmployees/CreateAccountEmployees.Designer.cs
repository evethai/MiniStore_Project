namespace MiniStoreWinF.ManageEmployees
{
    partial class CreateAccountEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountEmployees));
            panel1 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            txtAddName = new TextBox();
            txtAddPassword = new TextBox();
            panel4 = new Panel();
            rdAdmin = new RadioButton();
            rdEmployees = new RadioButton();
            rdGuard = new RadioButton();
            btAddAccountEmployees = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btAddAccountEmployees);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtAddPassword);
            panel1.Controls.Add(txtAddName);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(132, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 485);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 238);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 8;
            label8.Text = "Role";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(51, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(72, 64);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(51, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 64);
            panel2.TabIndex = 10;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(144, 66);
            txtAddName.Multiline = true;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(262, 34);
            txtAddName.TabIndex = 11;
            // 
            // txtAddPassword
            // 
            txtAddPassword.Location = new Point(144, 151);
            txtAddPassword.Multiline = true;
            txtAddPassword.Name = "txtAddPassword";
            txtAddPassword.Size = new Size(262, 34);
            txtAddPassword.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdGuard);
            panel4.Controls.Add(rdEmployees);
            panel4.Controls.Add(rdAdmin);
            panel4.Location = new Point(146, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 177);
            panel4.TabIndex = 13;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdAdmin.Location = new Point(27, 26);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(85, 27);
            rdAdmin.TabIndex = 0;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "Admin";
            rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdEmployees
            // 
            rdEmployees.AutoSize = true;
            rdEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdEmployees.Location = new Point(27, 83);
            rdEmployees.Name = "rdEmployees";
            rdEmployees.Size = new Size(116, 27);
            rdEmployees.TabIndex = 1;
            rdEmployees.TabStop = true;
            rdEmployees.Text = "Employees";
            rdEmployees.UseVisualStyleBackColor = true;
            // 
            // rdGuard
            // 
            rdGuard.AutoSize = true;
            rdGuard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdGuard.Location = new Point(27, 133);
            rdGuard.Name = "rdGuard";
            rdGuard.Size = new Size(80, 27);
            rdGuard.TabIndex = 2;
            rdGuard.TabStop = true;
            rdGuard.Text = "Guard";
            rdGuard.UseVisualStyleBackColor = true;
            // 
            // btAddAccountEmployees
            // 
            btAddAccountEmployees.BackColor = SystemColors.ActiveCaption;
            btAddAccountEmployees.Location = new Point(520, 413);
            btAddAccountEmployees.Name = "btAddAccountEmployees";
            btAddAccountEmployees.Size = new Size(94, 49);
            btAddAccountEmployees.TabIndex = 14;
            btAddAccountEmployees.Text = "ADD";
            btAddAccountEmployees.UseVisualStyleBackColor = false;
            // 
            // CreateAccountEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(panel1);
            Name = "CreateAccountEmployees";
            Text = "CreateAccountEmployees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private RadioButton rdGuard;
        private RadioButton rdEmployees;
        private RadioButton rdAdmin;
        private TextBox txtAddPassword;
        private TextBox txtAddName;
        private Button btAddAccountEmployees;
    }
}