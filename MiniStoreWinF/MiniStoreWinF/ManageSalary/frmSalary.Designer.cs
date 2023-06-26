namespace MiniStoreWinF.ManageSalary
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            AUTHORIZATION = new Button();
            btSalary = new Button();
            btSub = new Button();
            flplow = new FlowLayoutPanel();
            panel1 = new Panel();
            pMain = new Panel();
            flplow.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AUTHORIZATION
            // 
            AUTHORIZATION.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AUTHORIZATION.ImageAlign = ContentAlignment.MiddleLeft;
            AUTHORIZATION.Location = new Point(5, 4);
            AUTHORIZATION.Margin = new Padding(5, 4, 5, 4);
            AUTHORIZATION.Name = "AUTHORIZATION";
            AUTHORIZATION.Size = new Size(253, 65);
            AUTHORIZATION.TabIndex = 0;
            AUTHORIZATION.Text = "Manager Records";
            AUTHORIZATION.UseVisualStyleBackColor = true;
            AUTHORIZATION.Click += btManage_Click;
            // 
            // btSalary
            // 
            btSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSalary.ImageAlign = ContentAlignment.MiddleLeft;
            btSalary.Location = new Point(5, 77);
            btSalary.Margin = new Padding(5, 4, 5, 4);
            btSalary.Name = "btSalary";
            btSalary.Size = new Size(253, 65);
            btSalary.TabIndex = 0;
            btSalary.Text = "Salary";
            btSalary.UseVisualStyleBackColor = true;
            btSalary.Click += btSalary_Click;
            // 
            // btSub
            // 
            btSub.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSub.ImageAlign = ContentAlignment.MiddleLeft;
            btSub.Location = new Point(5, 150);
            btSub.Margin = new Padding(5, 4, 5, 4);
            btSub.Name = "btSub";
            btSub.Size = new Size(253, 65);
            btSub.TabIndex = 0;
            btSub.Text = "Allowance&Advanced";
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // flplow
            // 
            flplow.BorderStyle = BorderStyle.Fixed3D;
            flplow.Controls.Add(AUTHORIZATION);
            flplow.Controls.Add(btSalary);
            flplow.Controls.Add(btSub);
            flplow.Dock = DockStyle.Left;
            flplow.Location = new Point(0, 0);
            flplow.Name = "flplow";
            flplow.Size = new Size(264, 884);
            flplow.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(pMain);
            panel1.Controls.Add(flplow);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1763, 884);
            panel1.TabIndex = 4;
            // 
            // pMain
            // 
            pMain.BorderStyle = BorderStyle.Fixed3D;
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(264, 0);
            pMain.Name = "pMain";
            pMain.Size = new Size(1499, 884);
            pMain.TabIndex = 4;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1763, 884);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmSalary";
            Text = "frmSalary";
            Load += frmSalary_Load;
            flplow.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btSub;
        private Button btSalary;
        private Button AUTHORIZATION;
        private FlowLayoutPanel flplow;
        private Panel panel1;
        private Panel pMain;
    }
}