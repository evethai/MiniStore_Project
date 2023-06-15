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
            btManage = new Button();
            panel3 = new Panel();
            btSalary = new Button();
            panel5 = new Panel();
            btAdvance = new Button();
            panel2 = new Panel();
            btSub = new Button();
            panel6 = new Panel();
            label2 = new Label();
            txtName = new Label();
            Pn_body = new Panel();
            SibarTimer = new System.Windows.Forms.Timer(components);
            flpContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flpContainer
            // 
            flpContainer.Controls.Add(panel1);
            flpContainer.Controls.Add(panel4);
            flpContainer.Controls.Add(panel3);
            flpContainer.Controls.Add(panel5);
            flpContainer.Controls.Add(panel2);
            flpContainer.Dock = DockStyle.Left;
            flpContainer.Location = new Point(0, 0);
            flpContainer.MaximumSize = new Size(205, 611);
            flpContainer.MinimumSize = new Size(71, 611);
            flpContainer.Name = "flpContainer";
            flpContainer.Size = new Size(71, 611);
            flpContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btMenu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // btMenu
            // 
            btMenu.BackgroundImage = (Image)resources.GetObject("btMenu.BackgroundImage");
            btMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btMenu.Location = new Point(3, 9);
            btMenu.Name = "btMenu";
            btMenu.Size = new Size(58, 44);
            btMenu.TabIndex = 0;
            btMenu.UseVisualStyleBackColor = true;
            btMenu.Click += btMenu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btManage);
            panel4.Location = new Point(3, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 44);
            panel4.TabIndex = 3;
            // 
            // btManage
            // 
            btManage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btManage.Image = Properties.Resources.setup;
            btManage.ImageAlign = ContentAlignment.MiddleLeft;
            btManage.Location = new Point(3, 4);
            btManage.Name = "btManage";
            btManage.Size = new Size(195, 37);
            btManage.TabIndex = 0;
            btManage.Text = "Manager Records";
            btManage.TextAlign = ContentAlignment.MiddleRight;
            btManage.UseVisualStyleBackColor = true;
            btManage.Click += btManage_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btSalary);
            panel3.Location = new Point(3, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 44);
            panel3.TabIndex = 2;
            // 
            // btSalary
            // 
            btSalary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSalary.Image = Properties.Resources.salary;
            btSalary.ImageAlign = ContentAlignment.MiddleLeft;
            btSalary.Location = new Point(2, 3);
            btSalary.Name = "btSalary";
            btSalary.Size = new Size(195, 37);
            btSalary.TabIndex = 0;
            btSalary.Text = "Salary";
            btSalary.TextAlign = ContentAlignment.MiddleRight;
            btSalary.UseVisualStyleBackColor = true;
            btSalary.Click += btSalary_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btAdvance);
            panel5.Location = new Point(3, 174);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 44);
            panel5.TabIndex = 4;
            // 
            // btAdvance
            // 
            btAdvance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAdvance.Image = Properties.Resources.adv;
            btAdvance.ImageAlign = ContentAlignment.MiddleLeft;
            btAdvance.Location = new Point(3, 3);
            btAdvance.Name = "btAdvance";
            btAdvance.Size = new Size(195, 37);
            btAdvance.TabIndex = 0;
            btAdvance.Text = "Salary Advance";
            btAdvance.TextAlign = ContentAlignment.MiddleRight;
            btAdvance.UseVisualStyleBackColor = true;
            btAdvance.Click += btAdvance_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btSub);
            panel2.Location = new Point(3, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 44);
            panel2.TabIndex = 1;
            // 
            // btSub
            // 
            btSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSub.Image = Properties.Resources.sub;
            btSub.ImageAlign = ContentAlignment.MiddleLeft;
            btSub.Location = new Point(3, 0);
            btSub.Name = "btSub";
            btSub.Size = new Size(195, 37);
            btSub.TabIndex = 0;
            btSub.Text = "SubSalary";
            btSub.TextAlign = ContentAlignment.MiddleRight;
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txtName);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(71, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1118, 68);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(491, 21);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Vina Store";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(980, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(0, 17);
            txtName.TabIndex = 0;
            // 
            // Pn_body
            // 
            Pn_body.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_body.Dock = DockStyle.Fill;
            Pn_body.Location = new Point(71, 68);
            Pn_body.Name = "Pn_body";
            Pn_body.Size = new Size(1118, 543);
            Pn_body.TabIndex = 2;
            // 
            // SibarTimer
            // 
            SibarTimer.Interval = 10;
            SibarTimer.Tick += SibarTimer_Tick;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 611);
            Controls.Add(Pn_body);
            Controls.Add(panel6);
            Controls.Add(flpContainer);
            Name = "frmSalary";
            Text = "frmSalary";
            Load += frmSalary_Load;
            flpContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Button btAdvance;
        private Panel panel6;
        private Panel Pn_body;
        private Label label1;
        private Button btMenu;
        private System.Windows.Forms.Timer SibarTimer;
        private Label txtName;
        private Label label2;
    }
}