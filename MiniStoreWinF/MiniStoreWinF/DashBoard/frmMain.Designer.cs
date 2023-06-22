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
            menuStrip = new MenuStrip();
            mnuAdmin = new ToolStripMenuItem();
            mnuStore = new ToolStripMenuItem();
            mnuCheck = new ToolStripMenuItem();
            btCheckIn = new ToolStripMenuItem();
            btCheckOut = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuDis = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            txtUser = new ToolStripMenuItem();
            pMain = new Panel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuAdmin, mnuStore, mnuCheck, mnuHelp, mnuDis, mnuLogout, txtUser });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1307, 42);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.ShortcutKeys = Keys.F1;
            mnuAdmin.Size = new Size(113, 36);
            mnuAdmin.Text = "ADMIN";
            mnuAdmin.Click += mnuAdmin_Click;
            // 
            // mnuStore
            // 
            mnuStore.Name = "mnuStore";
            mnuStore.ShortcutKeys = Keys.F2;
            mnuStore.Size = new Size(101, 36);
            mnuStore.Text = "STORE";
            mnuStore.Click += mnuStore_Click;
            // 
            // mnuCheck
            // 
            mnuCheck.DropDownItems.AddRange(new ToolStripItem[] { btCheckIn, btCheckOut });
            mnuCheck.Name = "mnuCheck";
            mnuCheck.ShortcutKeys = Keys.F3;
            mnuCheck.Size = new Size(105, 36);
            mnuCheck.Text = "CHECK";
            // 
            // btCheckIn
            // 
            btCheckIn.Name = "btCheckIn";
            btCheckIn.Size = new Size(220, 36);
            btCheckIn.Text = "Check-In";
            btCheckIn.Click += btCheckIn_Click;
            // 
            // btCheckOut
            // 
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(220, 36);
            btCheckOut.Text = "Check-Out";
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.ShortcutKeys = Keys.F4;
            mnuHelp.Size = new Size(86, 36);
            mnuHelp.Text = "HELP";
            // 
            // mnuDis
            // 
            mnuDis.Name = "mnuDis";
            mnuDis.ShortcutKeys = Keys.F5;
            mnuDis.Size = new Size(125, 36);
            mnuDis.Text = "DISPLAY";
            mnuDis.Click += mnuDis_Click;
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuLogout.Size = new Size(123, 36);
            mnuLogout.Text = "LOGOUT";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // txtUser
            // 
            txtUser.ForeColor = Color.Blue;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(35, 36);
            txtUser.Text = ".";
            // 
            // pMain
            // 
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 42);
            pMain.Margin = new Padding(4);
            pMain.Name = "pMain";
            pMain.Size = new Size(1307, 651);
            pMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1307, 693);
            Controls.Add(pMain);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuAdmin;
        private ToolStripMenuItem mnuAdminDB;
        private ToolStripMenuItem mnuAdminLogout;
        private Panel pMain;
        private ToolStripMenuItem mnuStore;
        private ToolStripMenuItem mnuCheck;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuDis;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem txtUser;
        private ToolStripMenuItem btCheckIn;
        private ToolStripMenuItem btCheckOut;
    }
}