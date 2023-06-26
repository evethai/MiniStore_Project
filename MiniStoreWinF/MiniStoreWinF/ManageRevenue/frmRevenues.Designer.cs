namespace MiniStoreWinF.ManageRevenue
{
    partial class frmRevenues
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenues));
            panel1 = new Panel();
            panel6 = new Panel();
            dtpRe = new DateTimePicker();
            txtTime = new Label();
            txtYear = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            txtSumRe = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txtReMonth = new Label();
            label2 = new Label();
            panel4 = new Panel();
            txtSumOr = new Label();
            label3 = new Label();
            panel5 = new Panel();
            txtNumOrMonth = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            cRevenues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            txtIncrease = new Label();
            label7 = new Label();
            panel9 = new Panel();
            cProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cRevenues).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 85);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(dtpRe);
            panel6.Controls.Add(txtTime);
            panel6.Controls.Add(txtYear);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1536, 87);
            panel6.TabIndex = 0;
            // 
            // dtpRe
            // 
            dtpRe.CustomFormat = "MM/yyyy";
            dtpRe.Format = DateTimePickerFormat.Custom;
            dtpRe.Location = new Point(4, 22);
            dtpRe.Margin = new Padding(4);
            dtpRe.Name = "dtpRe";
            dtpRe.Size = new Size(264, 29);
            dtpRe.TabIndex = 3;
            dtpRe.ValueChanged += dtpRe_ValueChanged;
            // 
            // txtTime
            // 
            txtTime.Dock = DockStyle.Fill;
            txtTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTime.ForeColor = Color.Blue;
            txtTime.Location = new Point(0, 0);
            txtTime.Margin = new Padding(4, 0, 4, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(1532, 83);
            txtTime.TabIndex = 4;
            txtTime.Text = "label5";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            txtYear.AutoSize = true;
            txtYear.Location = new Point(179, 57);
            txtYear.Margin = new Padding(4, 0, 4, 0);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(14, 21);
            txtYear.TabIndex = 2;
            txtYear.Text = ".";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(286, 624);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtSumRe);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 148);
            panel2.TabIndex = 0;
            // 
            // txtSumRe
            // 
            txtSumRe.Dock = DockStyle.Fill;
            txtSumRe.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSumRe.ForeColor = Color.DarkSlateGray;
            txtSumRe.Location = new Point(0, 21);
            txtSumRe.Margin = new Padding(4, 0, 4, 0);
            txtSumRe.Name = "txtSumRe";
            txtSumRe.Size = new Size(274, 123);
            txtSumRe.TabIndex = 1;
            txtSumRe.Text = "label9";
            txtSumRe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 21);
            label1.TabIndex = 0;
            label1.Text = "Sum Revenues";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtReMonth);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 160);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 148);
            panel3.TabIndex = 0;
            // 
            // txtReMonth
            // 
            txtReMonth.Dock = DockStyle.Fill;
            txtReMonth.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtReMonth.ForeColor = Color.DarkSlateGray;
            txtReMonth.Location = new Point(0, 21);
            txtReMonth.Margin = new Padding(4, 0, 4, 0);
            txtReMonth.Name = "txtReMonth";
            txtReMonth.Size = new Size(274, 123);
            txtReMonth.TabIndex = 1;
            txtReMonth.Text = "label9";
            txtReMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 21);
            label2.TabIndex = 0;
            label2.Text = "Revenues in this month";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txtSumOr);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 316);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 148);
            panel4.TabIndex = 0;
            // 
            // txtSumOr
            // 
            txtSumOr.Dock = DockStyle.Fill;
            txtSumOr.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSumOr.ForeColor = Color.DarkSlateGray;
            txtSumOr.Location = new Point(0, 21);
            txtSumOr.Margin = new Padding(4, 0, 4, 0);
            txtSumOr.Name = "txtSumOr";
            txtSumOr.Size = new Size(274, 123);
            txtSumOr.TabIndex = 1;
            txtSumOr.Text = "label9";
            txtSumOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 21);
            label3.TabIndex = 0;
            label3.Text = "Sum orders";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtNumOrMonth);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 472);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 148);
            panel5.TabIndex = 0;
            // 
            // txtNumOrMonth
            // 
            txtNumOrMonth.Dock = DockStyle.Fill;
            txtNumOrMonth.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumOrMonth.ForeColor = Color.DarkSlateGray;
            txtNumOrMonth.Location = new Point(0, 21);
            txtNumOrMonth.Margin = new Padding(4, 0, 4, 0);
            txtNumOrMonth.Name = "txtNumOrMonth";
            txtNumOrMonth.Size = new Size(274, 123);
            txtNumOrMonth.TabIndex = 1;
            txtNumOrMonth.Text = "label9";
            txtNumOrMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(274, 21);
            label4.TabIndex = 0;
            label4.Text = "Number of orders in Month";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(286, 85);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1250, 624);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(cRevenues);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(4, 4);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(867, 616);
            panel7.TabIndex = 0;
            // 
            // cRevenues
            // 
            cRevenues.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cRevenues.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            cRevenues.ChartAreas.Add(chartArea1);
            cRevenues.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            cRevenues.Legends.Add(legend1);
            cRevenues.Location = new Point(0, 0);
            cRevenues.Margin = new Padding(4);
            cRevenues.Name = "cRevenues";
            cRevenues.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenues";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Number Orders";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValuesPerPoint = 3;
            cRevenues.Series.Add(series1);
            cRevenues.Series.Add(series2);
            cRevenues.Size = new Size(867, 616);
            cRevenues.TabIndex = 0;
            cRevenues.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Controls.Add(panel9, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(879, 4);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(367, 616);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(txtIncrease);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(4, 4);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(359, 300);
            panel8.TabIndex = 0;
            // 
            // txtIncrease
            // 
            txtIncrease.Dock = DockStyle.Fill;
            txtIncrease.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtIncrease.Location = new Point(0, 75);
            txtIncrease.Margin = new Padding(4, 0, 4, 0);
            txtIncrease.Name = "txtIncrease";
            txtIncrease.Size = new Size(355, 221);
            txtIncrease.TabIndex = 1;
            txtIncrease.Text = "1%";
            txtIncrease.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(355, 75);
            label7.TabIndex = 0;
            label7.Text = "Increase the revenue";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(cProduct);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(4, 312);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(359, 300);
            panel9.TabIndex = 0;
            // 
            // cProduct
            // 
            chartArea2.Name = "ChartArea1";
            cProduct.ChartAreas.Add(chartArea2);
            cProduct.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            cProduct.Legends.Add(legend2);
            cProduct.Location = new Point(0, 0);
            cProduct.Margin = new Padding(4);
            cProduct.Name = "cProduct";
            cProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Revenue";
            cProduct.Series.Add(series3);
            cProduct.Size = new Size(355, 296);
            cProduct.TabIndex = 0;
            cProduct.Text = "chart2";
            // 
            // frmRevenues
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 709);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmRevenues";
            Load += frmRevenues_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cRevenues).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart cRevenues;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private Panel panel9;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart cProduct;
        private Label txtSumRe;
        private Label txtReMonth;
        private Label txtSumOr;
        private Label txtNumOrMonth;
        private Label txtIncrease;
        private Label txtYear;
        private DateTimePicker dtpRe;
        private Label txtTime;
    }
}