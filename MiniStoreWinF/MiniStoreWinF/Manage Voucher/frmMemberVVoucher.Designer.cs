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
            btMember = new Button();
            btVoucher = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnMain = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btMember
            // 
            btMember.Image = (Image)resources.GetObject("btMember.Image");
            btMember.ImageAlign = ContentAlignment.MiddleLeft;
            btMember.Location = new Point(5, 4);
            btMember.Margin = new Padding(5, 4, 5, 4);
            btMember.Name = "btMember";
            btMember.Size = new Size(253, 65);
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
            btVoucher.Location = new Point(5, 77);
            btVoucher.Margin = new Padding(5, 4, 5, 4);
            btVoucher.Name = "btVoucher";
            btVoucher.Size = new Size(253, 65);
            btVoucher.TabIndex = 0;
            btVoucher.Text = "Voucher";
            btVoucher.TextAlign = ContentAlignment.MiddleRight;
            btVoucher.UseVisualStyleBackColor = true;
            btVoucher.Click += btVoucher_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(btMember);
            flowLayoutPanel1.Controls.Add(btVoucher);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            flowLayoutPanel1.MaximumSize = new Size(267, 0);
            flowLayoutPanel1.MinimumSize = new Size(267, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(267, 887);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pnMain
            // 
            pnMain.BorderStyle = BorderStyle.Fixed3D;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(267, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1657, 887);
            pnMain.TabIndex = 3;
            // 
            // frmMemberVVoucher
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 887);
            Controls.Add(pnMain);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmMemberVVoucher";
            Text = "frmMemberVVoucher";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btMember;
        private Button btVoucher;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnMain;
    }
}