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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            flpContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            btMenu = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            btManage = new Button();
            panel2 = new Panel();
            btSalary = new Button();
            panel5 = new Panel();
            btSub = new Button();
            Pn_body = new Panel();
            SibarTimer = new System.Windows.Forms.Timer(components);
            flpContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flpContainer
            // 
            flpContainer.Controls.Add(panel1);
            flpContainer.Controls.Add(panel4);
            flpContainer.Controls.Add(panel3);
            flpContainer.Controls.Add(panel2);
            flpContainer.Controls.Add(panel5);
            flpContainer.Dock = DockStyle.Left;
            flpContainer.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flpContainer.Location = new Point(0, 0);
            flpContainer.Margin = new Padding(5, 4, 5, 4);
            flpContainer.MaximumSize = new Size(260, 898);
            flpContainer.MinimumSize = new Size(112, 898);
            flpContainer.Name = "flpContainer";
            flpContainer.Size = new Size(260, 898);
            flpContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 34);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // btMenu
            // 
            btMenu.BackgroundImage = (Image)resources.GetObject("btMenu.BackgroundImage");
            btMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btMenu.Location = new Point(5, 22);
            btMenu.Margin = new Padding(5, 4, 5, 4);
            btMenu.Name = "btMenu";
            btMenu.Size = new Size(74, 46);
            btMenu.TabIndex = 0;
            btMenu.UseVisualStyleBackColor = true;
            btMenu.Click += btMenu_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 137);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(314, 0);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(btManage);
            panel3.Location = new Point(5, 145);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 65);
            panel3.TabIndex = 2;
            // 
            // btManage
            // 
            btManage.Dock = DockStyle.Fill;
            btManage.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btManage.Image = Properties.Resources.setup;
            btManage.ImageAlign = ContentAlignment.MiddleLeft;
            btManage.Location = new Point(0, 0);
            btManage.Margin = new Padding(5, 4, 5, 4);
            btManage.Name = "btManage";
            btManage.Size = new Size(253, 65);
            btManage.TabIndex = 0;
            btManage.Text = "Manager Records";
            btManage.TextAlign = ContentAlignment.MiddleRight;
            btManage.UseVisualStyleBackColor = true;
            btManage.Click += btManage_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btSalary);
            panel2.Location = new Point(5, 218);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 65);
            panel2.TabIndex = 1;
            // 
            // btSalary
            // 
            btSalary.Dock = DockStyle.Fill;
            btSalary.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btSalary.Image = Properties.Resources.salary;
            btSalary.ImageAlign = ContentAlignment.MiddleLeft;
            btSalary.Location = new Point(0, 0);
            btSalary.Margin = new Padding(5, 4, 5, 4);
            btSalary.Name = "btSalary";
            btSalary.Size = new Size(253, 65);
            btSalary.TabIndex = 0;
            btSalary.Text = "Salary";
            btSalary.TextAlign = ContentAlignment.MiddleRight;
            btSalary.UseVisualStyleBackColor = true;
            btSalary.Click += btSalary_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btSub);
            panel5.Location = new Point(5, 291);
            panel5.Margin = new Padding(5, 4, 5, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 65);
            panel5.TabIndex = 4;
            // 
            // btSub
            // 
            btSub.Dock = DockStyle.Fill;
            btSub.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btSub.Image = Properties.Resources.sub;
            btSub.ImageAlign = ContentAlignment.MiddleLeft;
            btSub.Location = new Point(0, 0);
            btSub.Margin = new Padding(5, 4, 5, 4);
            btSub.Name = "btSub";
            btSub.Size = new Size(253, 65);
            btSub.TabIndex = 0;
            btSub.Text = "Allowance&Advanced";
            btSub.TextAlign = ContentAlignment.MiddleRight;
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // Pn_body
            // 
            Pn_body.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_body.Dock = DockStyle.Fill;
            Pn_body.Location = new Point(260, 0);
            Pn_body.Margin = new Padding(5, 4, 5, 4);
            Pn_body.Name = "Pn_body";
            Pn_body.Size = new Size(1503, 884);
            Pn_body.TabIndex = 2;
            // 
            // SibarTimer
            // 
            SibarTimer.Interval = 10;
            SibarTimer.Tick += SibarTimer_Tick;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1763, 884);
            Controls.Add(Pn_body);
            Controls.Add(flpContainer);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmSalary";
            Text = "frmSalary";
            Load += frmSalary_Load;
            flpContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpContainer;
        private Panel panel1;
        private Panel panel2;
        private Button btSub;
        private Panel panel3;
        private Button btSalary;
        private Panel panel4;
        private Button btManage;
        private Panel panel5;
        private Panel Pn_body;
        private Label label1;
        private Button btMenu;
        private System.Windows.Forms.Timer SibarTimer;
    }
}