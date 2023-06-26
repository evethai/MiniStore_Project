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
            panel2.SuspendLayout();
            pMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRevenues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVouchers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1458, 53);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(680, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // pMain
            // 
            pMain.BackColor = SystemColors.Window;
            pMain.Controls.Add(tableLayoutPanel2);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 53);
            pMain.Margin = new Padding(4);
            pMain.Name = "pMain";
            pMain.Padding = new Padding(12, 10, 12, 10);
            pMain.Size = new Size(1458, 726);
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
            tableLayoutPanel2.Location = new Point(12, 10);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1434, 706);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pbRevenues
            // 
            pbRevenues.Dock = DockStyle.Fill;
            pbRevenues.Location = new Point(4, 4);
            pbRevenues.Margin = new Padding(4);
            pbRevenues.Name = "pbRevenues";
            pbRevenues.Size = new Size(709, 345);
            pbRevenues.TabIndex = 0;
            pbRevenues.TabStop = false;
            // 
            // pbMember
            // 
            pbMember.Dock = DockStyle.Fill;
            pbMember.Location = new Point(4, 357);
            pbMember.Margin = new Padding(4);
            pbMember.Name = "pbMember";
            pbMember.Size = new Size(709, 345);
            pbMember.TabIndex = 1;
            pbMember.TabStop = false;
            // 
            // pbProduct
            // 
            pbProduct.Dock = DockStyle.Fill;
            pbProduct.Location = new Point(721, 4);
            pbProduct.Margin = new Padding(4);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(709, 345);
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
            pbVouchers.Location = new Point(721, 358);
            pbVouchers.Margin = new Padding(4, 5, 4, 5);
            pbVouchers.Name = "pbVouchers";
            pbVouchers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            pbVouchers.Series.Add(series1);
            pbVouchers.Size = new Size(709, 343);
            pbVouchers.TabIndex = 3;
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Number of vouchers still available";
            pbVouchers.Titles.Add(title1);
            pbVouchers.Click += pbVouchers_Click;
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 779);
            Controls.Add(pMain);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDashBoard";
            Load += frmDashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRevenues).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVouchers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel pMain;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbRevenues;
        private PictureBox pbMember;
        private PictureBox pbProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart pbVouchers;
    }
}