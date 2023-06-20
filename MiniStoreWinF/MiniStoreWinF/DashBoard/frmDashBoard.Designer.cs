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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            panel2 = new Panel();
            label1 = new Label();
            pMain = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pbRevenues = new PictureBox();
            pbMember = new PictureBox();
            pbProduct = new PictureBox();
            pbVouchers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            label3 = new Label();
            btSalary = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            pMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRevenues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVouchers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            btSalary.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 51);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(605, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // pMain
            // 
            pMain.Anchor = AnchorStyles.None;
            pMain.BackColor = SystemColors.Window;
            pMain.Controls.Add(tableLayoutPanel2);
            pMain.Location = new Point(0, 189);
            pMain.Margin = new Padding(3, 4, 3, 4);
            pMain.Name = "pMain";
            pMain.Padding = new Padding(10);
            pMain.Size = new Size(1296, 581);
            pMain.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pbRevenues, 0, 0);
            tableLayoutPanel2.Controls.Add(pbMember, 0, 1);
            tableLayoutPanel2.Controls.Add(pbProduct, 1, 0);
            tableLayoutPanel2.Controls.Add(pbVouchers, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 10);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1276, 561);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pbRevenues
            // 
            pbRevenues.Dock = DockStyle.Fill;
            pbRevenues.Location = new Point(3, 4);
            pbRevenues.Margin = new Padding(3, 4, 3, 4);
            pbRevenues.Name = "pbRevenues";
            pbRevenues.Size = new Size(632, 272);
            pbRevenues.TabIndex = 0;
            pbRevenues.TabStop = false;
            // 
            // pbMember
            // 
            pbMember.Dock = DockStyle.Fill;
            pbMember.Location = new Point(3, 283);
            pbMember.Name = "pbMember";
            pbMember.Size = new Size(632, 275);
            pbMember.TabIndex = 1;
            pbMember.TabStop = false;
            // 
            // pbProduct
            // 
            pbProduct.Dock = DockStyle.Fill;
            pbProduct.Location = new Point(641, 3);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(632, 274);
            pbProduct.TabIndex = 2;
            pbProduct.TabStop = false;
            // 
            // pbVouchers
            // 
            chartArea1.Name = "ChartArea1";
            pbVouchers.ChartAreas.Add(chartArea1);
            pbVouchers.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            pbVouchers.Legends.Add(legend1);
            pbVouchers.Location = new Point(641, 283);
            pbVouchers.Name = "pbVouchers";
            pbVouchers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            pbVouchers.Series.Add(series1);
            pbVouchers.Size = new Size(632, 275);
            pbVouchers.TabIndex = 3;
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Number of vouchers still available";
            pbVouchers.Titles.Add(title1);
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
            tableLayoutPanel1.Controls.Add(btSalary, 3, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 51);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1296, 110);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(259, 0);
            panel9.Margin = new Padding(0, 0, 10, 10);
            panel9.Name = "panel9";
            panel9.Size = new Size(249, 100);
            panel9.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 46);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 0;
            label3.Text = "Revenue Management";
            // 
            // btSalary
            // 
            btSalary.BackColor = Color.Transparent;
            btSalary.BackgroundImage = (Image)resources.GetObject("btSalary.BackgroundImage");
            btSalary.BackgroundImageLayout = ImageLayout.Stretch;
            btSalary.Controls.Add(label9);
            btSalary.Dock = DockStyle.Fill;
            btSalary.Location = new Point(1036, 0);
            btSalary.Margin = new Padding(0, 0, 10, 10);
            btSalary.Name = "btSalary";
            btSalary.Size = new Size(250, 100);
            btSalary.TabIndex = 3;
            btSalary.Click += btSalary_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 46);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 0;
            label9.Text = "Salary Management";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(777, 0);
            panel5.Margin = new Padding(0, 0, 10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 100);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 46);
            label7.Name = "label7";
            label7.Size = new Size(172, 20);
            label7.TabIndex = 0;
            label7.Text = "WorkSheet Management";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(518, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 100);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 46);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 0;
            label5.Text = "Product Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0, 0, 11, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 98);
            panel3.TabIndex = 0;
            panel3.Click += panel3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(46, 46);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee Management";
            label2.Click += label2_Click;
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 742);
            Controls.Add(pMain);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashBoard";
            Text = "frmDashBoard";
            Load += frmDashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRevenues).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVouchers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            btSalary.ResumeLayout(false);
            btSalary.PerformLayout();
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
        private Panel pMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Panel btSalary;
        private Label label9;
        private Panel panel9;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbRevenues;
        private PictureBox pbMember;
        private PictureBox pbProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart pbVouchers;
    }
}