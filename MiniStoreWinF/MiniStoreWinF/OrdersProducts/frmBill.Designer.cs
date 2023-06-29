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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbTimeCheckOut = new Label();
            label4 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            billOrderBindingSource = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            label5 = new Label();
            pbPrice = new Label();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityOrdersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Controls.Add(label1);
            Logo.Dock = DockStyle.Top;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(479, 82);
            Logo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(187, 641);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(158, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "MiniStore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(411, 20);
            label2.TabIndex = 2;
            label2.Text = "-------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 146);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Time check out: ";
            // 
            // lbTimeCheckOut
            // 
            lbTimeCheckOut.AutoSize = true;
            lbTimeCheckOut.Location = new Point(158, 146);
            lbTimeCheckOut.Name = "lbTimeCheckOut";
            lbTimeCheckOut.Size = new Size(50, 20);
            lbTimeCheckOut.TabIndex = 4;
            lbTimeCheckOut.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 196);
            label4.Name = "label4";
            label4.Size = new Size(411, 20);
            label4.TabIndex = 5;
            label4.Text = "-------------------------------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 502);
            label6.Name = "label6";
            label6.Size = new Size(411, 20);
            label6.TabIndex = 7;
            label6.Text = "-------------------------------------------------------------------";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameProductDataGridViewTextBoxColumn, quantityOrdersDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(433, 280);
            dataGridView1.TabIndex = 8;
            // 
            // billOrderBindingSource
            // 
            billOrderBindingSource.DataSource = typeof(Repository.Models.BillOrder);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Repository.Models.Order);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(294, 539);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // pbPrice
            // 
            pbPrice.AutoSize = true;
            pbPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            pbPrice.Location = new Point(359, 539);
            pbPrice.Name = "pbPrice";
            pbPrice.Size = new Size(54, 25);
            pbPrice.TabIndex = 10;
            pbPrice.Text = "price";
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Name";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            // 
            // quantityOrdersDataGridViewTextBoxColumn
            // 
            quantityOrdersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityOrdersDataGridViewTextBoxColumn.DataPropertyName = "QuantityOrders";
            quantityOrdersDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityOrdersDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityOrdersDataGridViewTextBoxColumn.Name = "quantityOrdersDataGridViewTextBoxColumn";
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "Price";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 682);
            Controls.Add(pbPrice);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lbTimeCheckOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Logo);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Load += frmBill_Load;
            Logo.ResumeLayout(false);
            Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)billOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Logo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbTimeCheckOut;
        private Label label4;
        private Label label6;
        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private BindingSource billOrderBindingSource;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityOrdersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private Label label5;
        private Label pbPrice;
    }
}