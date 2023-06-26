namespace MiniStoreWinF.DashBoard
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            flowPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            ORDER = new Panel();
            panel9 = new Panel();
            label1 = new Label();
            REVENUE = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            PRODUCT = new Panel();
            panel11 = new Panel();
            label6 = new Label();
            EMPLOYEE = new Panel();
            panel12 = new Panel();
            label2 = new Label();
            SHEET = new Panel();
            panel13 = new Panel();
            label3 = new Label();
            SALARY = new Panel();
            panel17 = new Panel();
            label7 = new Label();
            VOUCHER = new Panel();
            panel18 = new Panel();
            label8 = new Label();
            AUTHORIZATION = new Panel();
            label9 = new Label();
            panel8 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            panel4 = new Panel();
            txtUser = new Label();
            pbSetting = new PictureBox();
            pUser = new Panel();
            btCheckIn = new Button();
            pnlPicture = new Panel();
            panel3 = new Panel();
            bntLogout = new Button();
            panel5 = new Panel();
            txtClock = new Label();
            panel6 = new Panel();
            panel14 = new Panel();
            label5 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            pnMain = new Panel();
            flowPanel.SuspendLayout();
            ORDER.SuspendLayout();
            REVENUE.SuspendLayout();
            PRODUCT.SuspendLayout();
            EMPLOYEE.SuspendLayout();
            SHEET.SuspendLayout();
            SALARY.SuspendLayout();
            VOUCHER.SuspendLayout();
            AUTHORIZATION.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSetting).BeginInit();
            pUser.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.Controls.Add(panel2);
            flowPanel.Controls.Add(ORDER);
            flowPanel.Controls.Add(REVENUE);
            flowPanel.Controls.Add(PRODUCT);
            flowPanel.Controls.Add(EMPLOYEE);
            flowPanel.Controls.Add(SHEET);
            flowPanel.Controls.Add(SALARY);
            flowPanel.Controls.Add(VOUCHER);
            flowPanel.Controls.Add(AUTHORIZATION);
            flowPanel.Dock = DockStyle.Left;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4);
            flowPanel.MaximumSize = new Size(172, 0);
            flowPanel.MinimumSize = new Size(172, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(172, 1025);
            flowPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.icons8_home;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 46);
            panel2.TabIndex = 2;
            panel2.Click += frmMainScreen_Load;
            // 
            // ORDER
            // 
            ORDER.BorderStyle = BorderStyle.Fixed3D;
            ORDER.Controls.Add(panel9);
            ORDER.Controls.Add(label1);
            ORDER.Location = new Point(4, 58);
            ORDER.Margin = new Padding(4);
            ORDER.Name = "ORDER";
            ORDER.Size = new Size(161, 105);
            ORDER.TabIndex = 2;
            ORDER.Click += ORDER_Click;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Custom_Icon_Design_Flatastic_5_Order_history_512;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(157, 80);
            panel9.TabIndex = 1;
            panel9.Click += ORDER_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            label1.TextAlign = ContentAlignment.BottomCenter;
            label1.Click += ORDER_Click;
            // 
            // REVENUE
            // 
            REVENUE.BorderStyle = BorderStyle.Fixed3D;
            REVENUE.Controls.Add(label4);
            REVENUE.Controls.Add(panel7);
            REVENUE.Location = new Point(4, 171);
            REVENUE.Margin = new Padding(4);
            REVENUE.Name = "REVENUE";
            REVENUE.Size = new Size(161, 105);
            REVENUE.TabIndex = 2;
            REVENUE.Click += REVENUE_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(0, 80);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 0;
            label4.Text = "Revenue";
            label4.TextAlign = ContentAlignment.BottomCenter;
            label4.Click += REVENUE_Click;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.icons8_revenue_64__1_;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(157, 101);
            panel7.TabIndex = 2;
            panel7.Click += REVENUE_Click;
            // 
            // PRODUCT
            // 
            PRODUCT.BorderStyle = BorderStyle.Fixed3D;
            PRODUCT.Controls.Add(panel11);
            PRODUCT.Controls.Add(label6);
            PRODUCT.Location = new Point(4, 284);
            PRODUCT.Margin = new Padding(4);
            PRODUCT.Name = "PRODUCT";
            PRODUCT.Size = new Size(161, 105);
            PRODUCT.TabIndex = 2;
            PRODUCT.Click += PRODUCT_Click;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.icons8_product_100;
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(157, 80);
            panel11.TabIndex = 1;
            panel11.Click += PRODUCT_Click;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Bottom;
            label6.Location = new Point(0, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(157, 21);
            label6.TabIndex = 0;
            label6.Text = "Product";
            label6.TextAlign = ContentAlignment.BottomCenter;
            label6.Click += PRODUCT_Click;
            // 
            // EMPLOYEE
            // 
            EMPLOYEE.BorderStyle = BorderStyle.Fixed3D;
            EMPLOYEE.Controls.Add(panel12);
            EMPLOYEE.Controls.Add(label2);
            EMPLOYEE.Location = new Point(4, 397);
            EMPLOYEE.Margin = new Padding(4);
            EMPLOYEE.Name = "EMPLOYEE";
            EMPLOYEE.Size = new Size(161, 105);
            EMPLOYEE.TabIndex = 2;
            EMPLOYEE.Click += EMPLOYEE_Click;
            // 
            // panel12
            // 
            panel12.BackgroundImage = Properties.Resources.Hopstarter_Sleek_Xp_Basic_Preppy_256;
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(157, 80);
            panel12.TabIndex = 1;
            panel12.Click += EMPLOYEE_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 0;
            label2.Text = "Employee";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.Click += EMPLOYEE_Click;
            // 
            // SHEET
            // 
            SHEET.BorderStyle = BorderStyle.Fixed3D;
            SHEET.Controls.Add(panel13);
            SHEET.Controls.Add(label3);
            SHEET.Location = new Point(4, 510);
            SHEET.Margin = new Padding(4);
            SHEET.Name = "SHEET";
            SHEET.Size = new Size(161, 105);
            SHEET.TabIndex = 2;
            SHEET.Click += SHEET_Click;
            // 
            // panel13
            // 
            panel13.BackgroundImage = Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Calendar_256;
            panel13.BackgroundImageLayout = ImageLayout.Zoom;
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(157, 80);
            panel13.TabIndex = 1;
            panel13.Click += SHEET_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(0, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 0;
            label3.Text = "Timekeeping";
            label3.TextAlign = ContentAlignment.BottomCenter;
            label3.Click += SHEET_Click;
            // 
            // SALARY
            // 
            SALARY.BorderStyle = BorderStyle.Fixed3D;
            SALARY.Controls.Add(panel17);
            SALARY.Controls.Add(label7);
            SALARY.Location = new Point(4, 623);
            SALARY.Margin = new Padding(4);
            SALARY.Name = "SALARY";
            SALARY.Size = new Size(161, 105);
            SALARY.TabIndex = 3;
            SALARY.Click += SALARY_Click;
            // 
            // panel17
            // 
            panel17.BackgroundImage = Properties.Resources.icons8_revenue_64;
            panel17.BackgroundImageLayout = ImageLayout.Zoom;
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 0);
            panel17.Margin = new Padding(4);
            panel17.Name = "panel17";
            panel17.Size = new Size(157, 80);
            panel17.TabIndex = 1;
            panel17.Click += SALARY_Click;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Bottom;
            label7.Location = new Point(0, 80);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 21);
            label7.TabIndex = 0;
            label7.Text = "Salary";
            label7.TextAlign = ContentAlignment.BottomCenter;
            label7.Click += SALARY_Click;
            // 
            // VOUCHER
            // 
            VOUCHER.BorderStyle = BorderStyle.Fixed3D;
            VOUCHER.Controls.Add(panel18);
            VOUCHER.Controls.Add(label8);
            VOUCHER.Location = new Point(4, 736);
            VOUCHER.Margin = new Padding(4);
            VOUCHER.Name = "VOUCHER";
            VOUCHER.Size = new Size(161, 105);
            VOUCHER.TabIndex = 3;
            VOUCHER.Click += VOUCHER_Click;
            // 
            // panel18
            // 
            panel18.BackgroundImage = Properties.Resources.icons8_voucher_64;
            panel18.BackgroundImageLayout = ImageLayout.Zoom;
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(0, 0);
            panel18.Margin = new Padding(4);
            panel18.Name = "panel18";
            panel18.Size = new Size(157, 80);
            panel18.TabIndex = 1;
            panel18.Click += VOUCHER_Click;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Bottom;
            label8.Location = new Point(0, 80);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 21);
            label8.TabIndex = 0;
            label8.Text = "Voucher";
            label8.TextAlign = ContentAlignment.BottomCenter;
            label8.Click += VOUCHER_Click;
            // 
            // AUTHORIZATION
            // 
            AUTHORIZATION.BorderStyle = BorderStyle.Fixed3D;
            AUTHORIZATION.Controls.Add(label9);
            AUTHORIZATION.Controls.Add(panel8);
            AUTHORIZATION.Location = new Point(4, 849);
            AUTHORIZATION.Margin = new Padding(4);
            AUTHORIZATION.Name = "AUTHORIZATION";
            AUTHORIZATION.Size = new Size(161, 105);
            AUTHORIZATION.TabIndex = 3;
            AUTHORIZATION.Click += AUTHORIZATION_Click;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Bottom;
            label9.Location = new Point(0, 80);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(157, 21);
            label9.TabIndex = 1;
            label9.Text = "Admin";
            label9.TextAlign = ContentAlignment.BottomCenter;
            label9.Click += AUTHORIZATION_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.icons8_admin_50;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(157, 101);
            panel8.TabIndex = 0;
            panel8.Click += AUTHORIZATION_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(172, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.MaximumSize = new Size(0, 70);
            tableLayoutPanel1.MinimumSize = new Size(0, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1466, 49);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(733, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pbSetting);
            panel1.Controls.Add(pUser);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(737, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 41);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(553, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(64, 41);
            panel4.TabIndex = 6;
            panel4.Click += pbSetting_Click;
            // 
            // txtUser
            // 
            txtUser.Dock = DockStyle.Fill;
            txtUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(336, 0);
            txtUser.Margin = new Padding(4, 0, 4, 0);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(281, 41);
            txtUser.TabIndex = 4;
            txtUser.Text = "name";
            txtUser.TextAlign = ContentAlignment.MiddleLeft;
            txtUser.DoubleClick += pnlPicture_DoubleClick;
            // 
            // pbSetting
            // 
            pbSetting.Image = (Image)resources.GetObject("pbSetting.Image");
            pbSetting.Location = new Point(534, 0);
            pbSetting.Name = "pbSetting";
            pbSetting.Size = new Size(53, 44);
            pbSetting.SizeMode = PictureBoxSizeMode.Zoom;
            pbSetting.TabIndex = 0;
            pbSetting.TabStop = false;
            pbSetting.Click += pbSetting_Click;
            // 
            // pUser
            // 
            pUser.BackgroundImageLayout = ImageLayout.Zoom;
            pUser.Controls.Add(btCheckIn);
            pUser.Controls.Add(pnlPicture);
            pUser.Dock = DockStyle.Left;
            pUser.Location = new Point(176, 0);
            pUser.Margin = new Padding(4);
            pUser.Name = "pUser";
            pUser.Size = new Size(160, 41);
            pUser.TabIndex = 3;
            // 
            // btCheckIn
            // 
            btCheckIn.BackColor = SystemColors.ActiveBorder;
            btCheckIn.Dock = DockStyle.Fill;
            btCheckIn.Enabled = false;
            btCheckIn.Location = new Point(0, 0);
            btCheckIn.Name = "btCheckIn";
            btCheckIn.Size = new Size(121, 41);
            btCheckIn.TabIndex = 4;
            btCheckIn.Text = "Attendance";
            btCheckIn.TextAlign = ContentAlignment.MiddleLeft;
            btCheckIn.UseVisualStyleBackColor = false;
            btCheckIn.Click += btCheckIn_Click;
            // 
            // pnlPicture
            // 
            pnlPicture.BackgroundImage = Properties.Resources.icons8_user_16;
            pnlPicture.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPicture.Dock = DockStyle.Right;
            pnlPicture.Location = new Point(121, 0);
            pnlPicture.Margin = new Padding(4);
            pnlPicture.Name = "pnlPicture";
            pnlPicture.Size = new Size(39, 41);
            pnlPicture.TabIndex = 3;
            pnlPicture.DoubleClick += pnlPicture_DoubleClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(bntLogout);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(617, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(108, 41);
            panel3.TabIndex = 4;
            // 
            // bntLogout
            // 
            bntLogout.BackColor = Color.Tomato;
            bntLogout.Dock = DockStyle.Fill;
            bntLogout.ForeColor = SystemColors.ButtonHighlight;
            bntLogout.Location = new Point(0, 0);
            bntLogout.Margin = new Padding(4);
            bntLogout.Name = "bntLogout";
            bntLogout.Size = new Size(108, 41);
            bntLogout.TabIndex = 0;
            bntLogout.Text = "Logout";
            bntLogout.UseVisualStyleBackColor = false;
            bntLogout.Click += bntLogout_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtClock);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 41);
            panel5.TabIndex = 5;
            // 
            // txtClock
            // 
            txtClock.Dock = DockStyle.Fill;
            txtClock.Location = new Point(0, 0);
            txtClock.Margin = new Padding(4, 0, 4, 0);
            txtClock.Name = "txtClock";
            txtClock.Size = new Size(176, 41);
            txtClock.TabIndex = 4;
            txtClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel14);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(4, 398);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(162, 106);
            panel6.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackgroundImage = Properties.Resources.icons8_revenue_64;
            panel14.BackgroundImageLayout = ImageLayout.Zoom;
            panel14.Location = new Point(98, 17);
            panel14.Margin = new Padding(4);
            panel14.Name = "panel14";
            panel14.Size = new Size(257, 124);
            panel14.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(0, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 21);
            label5.TabIndex = 0;
            label5.Text = "Salary";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // pnMain
            // 
            pnMain.BorderStyle = BorderStyle.Fixed3D;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(172, 49);
            pnMain.Margin = new Padding(4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1466, 976);
            pnMain.TabIndex = 3;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1638, 1025);
            Controls.Add(pnMain);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowPanel);
            Controls.Add(panel6);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmMainScreen_Load;
            flowPanel.ResumeLayout(false);
            ORDER.ResumeLayout(false);
            REVENUE.ResumeLayout(false);
            PRODUCT.ResumeLayout(false);
            EMPLOYEE.ResumeLayout(false);
            SHEET.ResumeLayout(false);
            SALARY.ResumeLayout(false);
            VOUCHER.ResumeLayout(false);
            AUTHORIZATION.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSetting).EndInit();
            pUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Panel panel2;
        private Panel ORDER;
        private Panel panel7;
        private Panel panel9;
        private Label label1;
        private Panel EMPLOYEE;
        private Label label2;
        private Panel SHEET;
        private Label label3;
        private Panel REVENUE;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Panel PRODUCT;
        private Label label6;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel SALARY;
        private Panel panel17;
        private Label label7;
        private Panel VOUCHER;
        private Panel panel18;
        private Label label8;
        private Panel pUser;
        private Label txtUser;
        private Panel pnlPicture;
        private Label txtClock;
        private System.Windows.Forms.Timer timer;
        private Panel AUTHORIZATION;
        private Label label9;
        private Panel panel8;
        private Panel panel3;
        private Button bntLogout;
        private Panel panel5;
        private Panel pnMain;
        private Button btCheckIn;
        private PictureBox pbSetting;
        private Panel panel4;
    }
}