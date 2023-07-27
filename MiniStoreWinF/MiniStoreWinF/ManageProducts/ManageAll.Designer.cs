namespace MiniStoreWinF.ManageProducts
{
    partial class ManageAll
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
            P = new Button();
            U = new Button();
            S = new Button();
            flowPanel = new FlowLayoutPanel();
            pnMain = new Panel();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // P
            // 
            P.Location = new Point(4, 4);
            P.Margin = new Padding(4, 4, 4, 4);
            P.Name = "P";
            P.Size = new Size(309, 77);
            P.TabIndex = 0;
            P.Text = "Product";
            P.UseVisualStyleBackColor = true;
            P.Click += P_Click;
            // 
            // U
            // 
            U.Location = new Point(4, 89);
            U.Margin = new Padding(4, 4, 4, 4);
            U.Name = "U";
            U.Size = new Size(309, 77);
            U.TabIndex = 0;
            U.Text = "Unit";
            U.UseVisualStyleBackColor = true;
            U.Click += U_Click;
            // 
            // S
            // 
            S.Location = new Point(4, 174);
            S.Margin = new Padding(4, 4, 4, 4);
            S.Name = "S";
            S.Size = new Size(309, 77);
            S.TabIndex = 0;
            S.Text = "Supplier";
            S.UseVisualStyleBackColor = true;
            S.Click += S_Click;
            // 
            // flowPanel
            // 
            flowPanel.Controls.Add(P);
            flowPanel.Controls.Add(U);
            flowPanel.Controls.Add(S);
            flowPanel.Dock = DockStyle.Left;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4, 4, 4, 4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(326, 955);
            flowPanel.TabIndex = 1;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(326, 0);
            pnMain.Margin = new Padding(4, 4, 4, 4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1560, 955);
            pnMain.TabIndex = 2;
            // 
            // ManageAll
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1886, 955);
            Controls.Add(pnMain);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ManageAll";
            Text = "ManageAll";
            flowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TableLayoutPanel pnProduct;
        private Button U;
        private Button P;
        private Button AUTHORIZATION;
        private FlowLayoutPanel flowPanel;
        private Button S;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnMain;
        private Panel panel2;
    }
}