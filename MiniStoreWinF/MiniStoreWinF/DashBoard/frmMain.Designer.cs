namespace MiniStoreWinF.DashBoard
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuAdmin = new ToolStripMenuItem();
            mnuAdminDB = new ToolStripMenuItem();
            mnuAdminLogout = new ToolStripMenuItem();
            sTOREToolStripMenuItem = new ToolStripMenuItem();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            dISPLAYToolStripMenuItem = new ToolStripMenuItem();
            qUITToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            txtAccountLogin = new ToolStripTextBox();
            pMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAdmin, sTOREToolStripMenuItem, hELPToolStripMenuItem, dISPLAYToolStripMenuItem, qUITToolStripMenuItem, eXITToolStripMenuItem, txtAccountLogin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(1680, 47);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { mnuAdminDB, mnuAdminLogout });
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(113, 36);
            mnuAdmin.Text = "ADMIN";
            // 
            // mnuAdminDB
            // 
            mnuAdminDB.Name = "mnuAdminDB";
            mnuAdminDB.Size = new Size(287, 36);
            mnuAdminDB.Text = "DASHBOARD";
            mnuAdminDB.Click += mnuAdminDB_Click;
            // 
            // mnuAdminLogout
            // 
            mnuAdminLogout.Name = "mnuAdminLogout";
            mnuAdminLogout.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuAdminLogout.Size = new Size(287, 36);
            mnuAdminLogout.Text = "LOGOUT";
            // 
            // sTOREToolStripMenuItem
            // 
            sTOREToolStripMenuItem.Name = "sTOREToolStripMenuItem";
            sTOREToolStripMenuItem.Size = new Size(101, 36);
            sTOREToolStripMenuItem.Text = "STORE";
            sTOREToolStripMenuItem.Click += sTOREToolStripMenuItem_Click;
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(86, 36);
            hELPToolStripMenuItem.Text = "HELP";
            // 
            // dISPLAYToolStripMenuItem
            // 
            dISPLAYToolStripMenuItem.Name = "dISPLAYToolStripMenuItem";
            dISPLAYToolStripMenuItem.Size = new Size(125, 36);
            dISPLAYToolStripMenuItem.Text = "DISPLAY";
            // 
            // qUITToolStripMenuItem
            // 
            qUITToolStripMenuItem.Name = "qUITToolStripMenuItem";
            qUITToolStripMenuItem.Size = new Size(85, 39);
            qUITToolStripMenuItem.Text = "QUIT";
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(79, 36);
            eXITToolStripMenuItem.Text = "EXIT";
            // 
            // txtAccountLogin
            // 
            txtAccountLogin.BackColor = Color.Gainsboro;
            txtAccountLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccountLogin.Name = "txtAccountLogin";
            txtAccountLogin.Size = new Size(300, 39);
            // 
            // pMain
            // 
            pMain.Dock = DockStyle.Fill;
            pMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pMain.Location = new Point(0, 47);
            pMain.Margin = new Padding(5);
            pMain.Name = "pMain";
            pMain.Size = new Size(1680, 661);
            pMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1680, 708);
            Controls.Add(pMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAdmin;
        private ToolStripMenuItem mnuAdminDB;
        private ToolStripMenuItem mnuAdminLogout;
        private Panel pMain;
        private ToolStripMenuItem sTOREToolStripMenuItem;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem dISPLAYToolStripMenuItem;
        private ToolStripMenuItem qUITToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripTextBox txtAccountLogin;
    }
}