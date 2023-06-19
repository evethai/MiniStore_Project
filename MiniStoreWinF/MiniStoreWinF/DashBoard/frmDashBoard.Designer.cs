namespace MiniStoreWinF.DashBoard
{
    partial class frmDashBoard
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
            panel2 = new Panel();
            panel10 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pbProduct = new PictureBox();
            panel7 = new Panel();
            pbRevenus = new PictureBox();
            panel8 = new Panel();
            pbMember = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRevenus).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMember).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 51);
            panel2.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(1043, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(70, 51);
            panel10.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 31);
            label4.Name = "label4";
            label4.Size = new Size(15, 17);
            label4.TabIndex = 0;
            label4.Text = "0";
            label4.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(513, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pbProduct);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1113, 676);
            panel1.TabIndex = 2;
            // 
            // pbProduct
            // 
            pbProduct.Dock = DockStyle.Top;
            pbProduct.Location = new Point(546, 110);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(557, 277);
            pbProduct.TabIndex = 2;
            pbProduct.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbRevenus);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(10, 110);
            panel7.Name = "panel7";
            panel7.Size = new Size(536, 556);
            panel7.TabIndex = 1;
            // 
            // pbRevenus
            // 
            pbRevenus.Dock = DockStyle.Fill;
            pbRevenus.Location = new Point(0, 277);
            pbRevenus.Name = "pbRevenus";
            pbRevenus.Size = new Size(536, 279);
            pbRevenus.TabIndex = 1;
            pbRevenus.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(pbMember);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(536, 277);
            panel8.TabIndex = 0;
            // 
            // pbMember
            // 
            pbMember.Dock = DockStyle.Fill;
            pbMember.Location = new Point(0, 0);
            pbMember.Name = "pbMember";
            pbMember.Size = new Size(536, 277);
            pbMember.TabIndex = 0;
            pbMember.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel9, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 3, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1093, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(192, 255, 255);
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(218, 0);
            panel9.Margin = new Padding(0, 0, 10, 10);
            panel9.Name = "panel9";
            panel9.Size = new Size(208, 90);
            panel9.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 12);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 0;
            label3.Text = "Revenue Management";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 255, 255);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(872, 0);
            panel6.Margin = new Padding(0, 0, 10, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 90);
            panel6.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(124, 17);
            label9.TabIndex = 0;
            label9.Text = "Salary Management";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 255);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(654, 0);
            panel5.Margin = new Padding(0, 0, 10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 90);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 12);
            label7.Name = "label7";
            label7.Size = new Size(151, 17);
            label7.TabIndex = 0;
            label7.Text = "WorkSheet Management";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 255);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(436, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 90);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(134, 17);
            label5.TabIndex = 0;
            label5.Text = "Product Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 90);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 0;
            label2.Text = "Employee Management";
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 727);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmDashBoard";
            Text = "frmDashBoard";
            Load += frmDashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRevenus).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMember).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Panel panel6;
        private Label label9;
        private PictureBox pbProduct;
        private Panel panel7;
        private PictureBox pbRevenus;
        private Panel panel8;
        private PictureBox pbMember;
        private Panel panel9;
        private Label label3;
        private Label label2;
        private Panel panel10;
        private Label label4;
    }
}