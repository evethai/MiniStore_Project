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
            pMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAdmin, sTOREToolStripMenuItem, hELPToolStripMenuItem, dISPLAYToolStripMenuItem, qUITToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1036, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { mnuAdminDB, mnuAdminLogout });
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(90, 29);
            mnuAdmin.Text = "ADMIN";
            // 
            // mnuAdminDB
            // 
            mnuAdminDB.Name = "mnuAdminDB";
            mnuAdminDB.Size = new Size(232, 30);
            mnuAdminDB.Text = "DASHBOARD";
            mnuAdminDB.Click += mnuAdminDB_Click;
            // 
            // mnuAdminLogout
            // 
            mnuAdminLogout.Name = "mnuAdminLogout";
            mnuAdminLogout.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuAdminLogout.Size = new Size(232, 30);
            mnuAdminLogout.Text = "LOGOUT";
            // 
            // sTOREToolStripMenuItem
            // 
            sTOREToolStripMenuItem.Name = "sTOREToolStripMenuItem";
            sTOREToolStripMenuItem.Size = new Size(81, 29);
            sTOREToolStripMenuItem.Text = "STORE";
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(71, 29);
            hELPToolStripMenuItem.Text = "HELP";
            // 
            // dISPLAYToolStripMenuItem
            // 
            dISPLAYToolStripMenuItem.Name = "dISPLAYToolStripMenuItem";
            dISPLAYToolStripMenuItem.Size = new Size(101, 29);
            dISPLAYToolStripMenuItem.Text = "DISPLAY";
            // 
            // qUITToolStripMenuItem
            // 
            qUITToolStripMenuItem.Name = "qUITToolStripMenuItem";
            qUITToolStripMenuItem.Size = new Size(69, 29);
            qUITToolStripMenuItem.Text = "QUIT";
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(63, 29);
            eXITToolStripMenuItem.Text = "EXIT";
            // 
            // pMain
            // 
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 33);
            pMain.Name = "pMain";
            pMain.Size = new Size(1036, 531);
            pMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 564);
            Controls.Add(pMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmMain";
            Text = "frmMain";
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
    }
}