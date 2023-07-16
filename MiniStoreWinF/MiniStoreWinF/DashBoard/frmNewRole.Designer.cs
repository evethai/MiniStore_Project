namespace MiniStoreWinF.DashBoard
{
    partial class frmNewRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRole));
            pRole = new Panel();
            groupBox1 = new GroupBox();
            buOk = new Button();
            txtRole = new TextBox();
            pRole.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pRole
            // 
            pRole.BorderStyle = BorderStyle.Fixed3D;
            pRole.Controls.Add(groupBox1);
            pRole.Location = new Point(12, 12);
            pRole.Name = "pRole";
            pRole.Size = new Size(320, 108);
            pRole.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buOk);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Name's Role";
            // 
            // buOk
            // 
            buOk.Location = new Point(133, 63);
            buOk.Name = "buOk";
            buOk.Size = new Size(75, 29);
            buOk.TabIndex = 0;
            buOk.Text = "OK";
            buOk.UseVisualStyleBackColor = true;
            buOk.Click += buOk_Click;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(47, 28);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(246, 25);
            txtRole.TabIndex = 1;
            // 
            // frmNewRole
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 131);
            Controls.Add(pRole);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(364, 170);
            MinimumSize = new Size(364, 170);
            Name = "frmNewRole";
            Text = "Add new role";
            pRole.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pRole;
        private GroupBox groupBox1;
        private Button buOk;
        private TextBox txtRole;
    }
}