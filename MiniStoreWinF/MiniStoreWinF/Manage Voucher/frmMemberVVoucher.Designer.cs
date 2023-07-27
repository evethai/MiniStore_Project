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
            M = new Button();
            V = new Button();
            flowPanel = new FlowLayoutPanel();
            pnMain = new Panel();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // M
            // 
            M.Image = (Image)resources.GetObject("M.Image");
            M.ImageAlign = ContentAlignment.MiddleLeft;
            M.Location = new Point(5, 4);
            M.Margin = new Padding(5, 4, 5, 4);
            M.Name = "M";
            M.Size = new Size(253, 65);
            M.TabIndex = 1;
            M.Text = "Member";
            M.TextAlign = ContentAlignment.MiddleRight;
            M.UseVisualStyleBackColor = true;
            M.Click += btMember_Click;
            // 
            // V
            // 
            V.Image = (Image)resources.GetObject("V.Image");
            V.ImageAlign = ContentAlignment.MiddleLeft;
            V.Location = new Point(5, 77);
            V.Margin = new Padding(5, 4, 5, 4);
            V.Name = "V";
            V.Size = new Size(253, 65);
            V.TabIndex = 0;
            V.Text = "Voucher";
            V.TextAlign = ContentAlignment.MiddleRight;
            V.UseVisualStyleBackColor = true;
            V.Click += btVoucher_Click;
            // 
            // flowPanel
            // 
            flowPanel.BorderStyle = BorderStyle.Fixed3D;
            flowPanel.Controls.Add(M);
            flowPanel.Controls.Add(V);
            flowPanel.Dock = DockStyle.Left;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(5, 4, 5, 4);
            flowPanel.MaximumSize = new Size(267, 0);
            flowPanel.MinimumSize = new Size(267, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(267, 887);
            flowPanel.TabIndex = 2;
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
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmMemberVVoucher";
            Text = "frmMemberVVoucher";
            flowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button M;
        private Button V;
        private FlowLayoutPanel flowPanel;
        private Panel pnMain;
    }
}