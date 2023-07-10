namespace MiniStoreWinF.Manage_Voucher
{
    partial class frmMemberVVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberVVoucher));
            panel1 = new Panel();
            btMember = new Button();
            btVoucher = new Button();
            pnMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btMember);
            panel1.Controls.Add(btVoucher);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 709);
            panel1.TabIndex = 0;
            // 
            // btMember
            // 
            btMember.Image = (Image)resources.GetObject("btMember.Image");
            btMember.ImageAlign = ContentAlignment.MiddleLeft;
            btMember.Location = new Point(3, 102);
            btMember.Name = "btMember";
            btMember.Size = new Size(148, 73);
            btMember.TabIndex = 1;
            btMember.Text = "Member";
            btMember.TextAlign = ContentAlignment.MiddleRight;
            btMember.UseVisualStyleBackColor = true;
            btMember.Click += btMember_Click;
            // 
            // btVoucher
            // 
            btVoucher.Image = (Image)resources.GetObject("btVoucher.Image");
            btVoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btVoucher.Location = new Point(3, 12);
            btVoucher.Name = "btVoucher";
            btVoucher.Size = new Size(148, 73);
            btVoucher.TabIndex = 0;
            btVoucher.Text = "Voucher";
            btVoucher.TextAlign = ContentAlignment.MiddleRight;
            btVoucher.UseVisualStyleBackColor = true;
            btVoucher.Click += btVoucher_Click;
            // 
            // pnMain
            // 
            pnMain.BorderStyle = BorderStyle.Fixed3D;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(157, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1539, 709);
            pnMain.TabIndex = 1;
            // 
            // frmMemberVVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1696, 709);
            Controls.Add(pnMain);
            Controls.Add(panel1);
            Name = "frmMemberVVoucher";
            Text = "frmMemberVVoucher";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btMember;
        private Button btVoucher;
        private Panel pnMain;
    }
}