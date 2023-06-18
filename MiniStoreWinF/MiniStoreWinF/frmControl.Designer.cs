namespace MiniStoreWinF
{
    partial class frmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            mnStrControl = new MenuStrip();
            mnAdmin = new ToolStripMenuItem();
            mnOrders = new ToolStripMenuItem();
            mnMember = new ToolStripMenuItem();
            mnInterface = new ToolStripMenuItem();
            mnAccount = new ToolStripMenuItem();
            mnStrControl.SuspendLayout();
            SuspendLayout();
            // 
            // mnStrControl
            // 
            mnStrControl.ImageScalingSize = new Size(20, 20);
            mnStrControl.Items.AddRange(new ToolStripItem[] { mnAdmin, mnOrders, mnMember, mnInterface, mnAccount });
            mnStrControl.Location = new Point(0, 0);
            mnStrControl.Name = "mnStrControl";
            mnStrControl.Size = new Size(1009, 28);
            mnStrControl.TabIndex = 0;
            mnStrControl.Text = "menuStrip1";
            // 
            // mnAdmin
            // 
            mnAdmin.Image = (Image)resources.GetObject("mnAdmin.Image");
            mnAdmin.Name = "mnAdmin";
            mnAdmin.Size = new Size(87, 24);
            mnAdmin.Text = "Admin";
            // 
            // mnOrders
            // 
            mnOrders.Image = (Image)resources.GetObject("mnOrders.Image");
            mnOrders.Name = "mnOrders";
            mnOrders.Size = new Size(87, 24);
            mnOrders.Text = "Orders";
            // 
            // mnMember
            // 
            mnMember.Image = (Image)resources.GetObject("mnMember.Image");
            mnMember.Name = "mnMember";
            mnMember.Size = new Size(99, 24);
            mnMember.Text = "Member";
            // 
            // mnInterface
            // 
            mnInterface.Image = (Image)resources.GetObject("mnInterface.Image");
            mnInterface.Name = "mnInterface";
            mnInterface.Size = new Size(101, 24);
            mnInterface.Text = "Interface";
            // 
            // mnAccount
            // 
            mnAccount.Image = (Image)resources.GetObject("mnAccount.Image");
            mnAccount.Name = "mnAccount";
            mnAccount.Size = new Size(94, 24);
            mnAccount.Text = "Acount ";
            // 
            // frmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 710);
            Controls.Add(mnStrControl);
            MainMenuStrip = mnStrControl;
            Name = "frmControl";
            Text = "frmControl";
            mnStrControl.ResumeLayout(false);
            mnStrControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStrControl;
        private ToolStripMenuItem mnAdmin;
        private ToolStripMenuItem mnOrders;
        private ToolStripMenuItem mnMember;
        private ToolStripMenuItem mnInterface;
        private ToolStripMenuItem mnAccount;
    }
}