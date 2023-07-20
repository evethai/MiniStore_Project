namespace MiniStoreWinF.OrdersProducts
{
    partial class frmBill
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
            components = new System.ComponentModel.Container();
            Logo = new Panel();
            label1 = new Label();
            txtPhoneMember = new Label();
            dtgvListProduct = new DataGridView();
            orderBindingSource = new BindingSource(components);
            billOrderBindingSource = new BindingSource(components);
            label5 = new Label();
            txtPayMent = new Label();
            txtDiscount = new Label();
            label8 = new Label();
            txtLoyaltyPoint = new Label();
            label10 = new Label();
            txtTotalBill = new Label();
            label12 = new Label();
            tlopBill = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtIdBill = new Label();
            label17 = new Label();
            txtTimeCheckOut = new Label();
            label14 = new Label();
            label13 = new Label();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billOrderBindingSource).BeginInit();
            tlopBill.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Controls.Add(label1);
            Logo.Dock = DockStyle.Fill;
            Logo.Location = new Point(3, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(473, 93);
            Logo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(169, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "MiniStore";
            // 
            // txtPhoneMember
            // 
            txtPhoneMember.AutoSize = true;
            txtPhoneMember.BackColor = Color.White;
            txtPhoneMember.Location = new Point(109, 58);
            txtPhoneMember.Name = "txtPhoneMember";
            txtPhoneMember.Size = new Size(50, 20);
            txtPhoneMember.TabIndex = 4;
            txtPhoneMember.Text = "Phone";
            // 
            // dtgvListProduct
            // 
            dtgvListProduct.BackgroundColor = Color.White;
            dtgvListProduct.BorderStyle = BorderStyle.None;
            dtgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListProduct.Dock = DockStyle.Fill;
            dtgvListProduct.Location = new Point(0, 0);
            dtgvListProduct.Name = "dtgvListProduct";
            dtgvListProduct.RowHeadersWidth = 51;
            dtgvListProduct.RowTemplate.Height = 29;
            dtgvListProduct.Size = new Size(467, 334);
            dtgvListProduct.TabIndex = 8;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Repository.Models.Order);
            // 
            // billOrderBindingSource
            // 
            billOrderBindingSource.DataSource = typeof(Repository.Models.BillOrder);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 68);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Payment:";
            // 
            // txtPayMent
            // 
            txtPayMent.AutoSize = true;
            txtPayMent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPayMent.Location = new Point(89, 68);
            txtPayMent.Name = "txtPayMent";
            txtPayMent.Size = new Size(43, 20);
            txtPayMent.TabIndex = 10;
            txtPayMent.Text = "price";
            // 
            // txtDiscount
            // 
            txtDiscount.AutoSize = true;
            txtDiscount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscount.Location = new Point(89, 36);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(69, 20);
            txtDiscount.TabIndex = 12;
            txtDiscount.Text = "Discount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 36);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 11;
            label8.Text = "Discount:";
            // 
            // txtLoyaltyPoint
            // 
            txtLoyaltyPoint.AutoSize = true;
            txtLoyaltyPoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoyaltyPoint.Location = new Point(124, 100);
            txtLoyaltyPoint.Name = "txtLoyaltyPoint";
            txtLoyaltyPoint.Size = new Size(44, 20);
            txtLoyaltyPoint.TabIndex = 14;
            txtLoyaltyPoint.Text = "Point";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(10, 100);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 13;
            label10.Text = "Loyalty points:";
            // 
            // txtTotalBill
            // 
            txtTotalBill.AutoSize = true;
            txtTotalBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalBill.Location = new Point(75, 4);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.Size = new Size(63, 20);
            txtTotalBill.TabIndex = 16;
            txtTotalBill.Text = "TotalBill";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 4);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 15;
            label12.Text = "Total:";
            // 
            // tlopBill
            // 
            tlopBill.ColumnCount = 1;
            tlopBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlopBill.Controls.Add(panel1, 0, 2);
            tlopBill.Controls.Add(Logo, 0, 0);
            tlopBill.Controls.Add(tableLayoutPanel1, 0, 1);
            tlopBill.Dock = DockStyle.Fill;
            tlopBill.Location = new Point(0, 0);
            tlopBill.Name = "tlopBill";
            tlopBill.RowCount = 3;
            tlopBill.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlopBill.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlopBill.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlopBill.Size = new Size(479, 663);
            tlopBill.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTotalBill);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPayMent);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtLoyaltyPoint);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 532);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 128);
            panel1.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(473, 424);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvListProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 334);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtIdBill);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(txtTimeCheckOut);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtPhoneMember);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 78);
            panel3.TabIndex = 1;
            // 
            // txtIdBill
            // 
            txtIdBill.AutoSize = true;
            txtIdBill.BackColor = Color.White;
            txtIdBill.Location = new Point(239, 0);
            txtIdBill.Name = "txtIdBill";
            txtIdBill.Size = new Size(24, 20);
            txtIdBill.TabIndex = 8;
            txtIdBill.Text = "ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(168, 0);
            label17.Name = "label17";
            label17.Size = new Size(56, 20);
            label17.TabIndex = 7;
            label17.Text = "ID Bill :";
            // 
            // txtTimeCheckOut
            // 
            txtTimeCheckOut.AutoSize = true;
            txtTimeCheckOut.BackColor = Color.White;
            txtTimeCheckOut.Location = new Point(153, 30);
            txtTimeCheckOut.Name = "txtTimeCheckOut";
            txtTimeCheckOut.Size = new Size(71, 20);
            txtTimeCheckOut.TabIndex = 6;
            txtTimeCheckOut.Text = "Datetime";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 58);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 5;
            label14.Text = "Customer :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 30);
            label13.Name = "label13";
            label13.Size = new Size(120, 20);
            label13.TabIndex = 0;
            label13.Text = "Time Check Out :";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 663);
            Controls.Add(tlopBill);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Logo.ResumeLayout(false);
            Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)billOrderBindingSource).EndInit();
            tlopBill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Logo;
        private Label label1;
        private Label label3;
        private Label txtPhoneMember;
        private Label label4;
        private Label label6;
        private DataGridView dtgvListProduct;
        private BindingSource orderBindingSource;
        private BindingSource billOrderBindingSource;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private Label label5;
        private Label txtPayMent;
        private Label txtDiscount;
        private Label label8;
        private Label txtLoyaltyPoint;
        private Label label10;
        private Label txtTotalBill;
        private Label label12;
        private Label label2;
        private TableLayoutPanel tlopBill;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label label13;
        private Label txtIdBill;
        private Label label17;
        private Label txtTimeCheckOut;
        private Label label14;
    }
}