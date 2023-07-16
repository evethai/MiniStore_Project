namespace MiniStoreWinF.ManageProducts
{
    partial class UpdateStatusProduct
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
            groupBox4 = new GroupBox();
            DgvListProduct = new DataGridView();
            productBindingSource = new BindingSource(components);
            label = new Label();
            label4 = new Label();
            label10 = new Label();
            txtIDProduct = new TextBox();
            txtNameProduct = new TextBox();
            txtStatusProduct = new ComboBox();
            btUpdateProduct = new Button();
            txtLoadPro = new Button();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(DgvListProduct);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(43, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(498, 190);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "List Product";
            // 
            // DgvListProduct
            // 
            DgvListProduct.AutoGenerateColumns = false;
            DgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListProduct.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn });
            DgvListProduct.DataSource = productBindingSource;
            DgvListProduct.Location = new Point(0, 20);
            DgvListProduct.Name = "DgvListProduct";
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(498, 169);
            DgvListProduct.TabIndex = 0;
            DgvListProduct.CellClick += DgvListProduct_CellClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(43, 220);
            label.Name = "label";
            label.Size = new Size(95, 25);
            label.TabIndex = 15;
            label.Text = "Id Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 255);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 16;
            label4.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(43, 293);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 17;
            label10.Text = "Status";
            // 
            // txtIDProduct
            // 
            txtIDProduct.Location = new Point(161, 218);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(151, 27);
            txtIDProduct.TabIndex = 18;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(161, 255);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(254, 27);
            txtNameProduct.TabIndex = 19;
            // 
            // txtStatusProduct
            // 
            txtStatusProduct.FormattingEnabled = true;
            txtStatusProduct.Items.AddRange(new object[] { "Sold Out", "Availability" });
            txtStatusProduct.Location = new Point(161, 293);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(151, 28);
            txtStatusProduct.TabIndex = 22;
            // 
            // btUpdateProduct
            // 
            btUpdateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btUpdateProduct.Location = new Point(420, 330);
            btUpdateProduct.Name = "btUpdateProduct";
            btUpdateProduct.Size = new Size(94, 31);
            btUpdateProduct.TabIndex = 23;
            btUpdateProduct.Text = "Update";
            btUpdateProduct.UseVisualStyleBackColor = true;
            btUpdateProduct.Click += btUpdateProduct_Click;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.Location = new Point(303, 330);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(111, 31);
            txtLoadPro.TabIndex = 24;
            txtLoadPro.Text = "Load";
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.Width = 90;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 350;
            // 
            // UpdateStatusProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(606, 364);
            Controls.Add(txtLoadPro);
            Controls.Add(btUpdateProduct);
            Controls.Add(txtStatusProduct);
            Controls.Add(txtNameProduct);
            Controls.Add(txtIDProduct);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label);
            Controls.Add(groupBox4);
            Name = "UpdateStatusProduct";
            Text = "UpdateStatusProduct";
            Load += UpdateStatusProduct_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private DataGridView DgvListProduct;
        private BindingSource productBindingSource;
        private Label label;
        private Label label4;
        private Label label10;
        private TextBox txtIDProduct;
        private TextBox txtNameProduct;
        private ComboBox txtStatusProduct;
        private Button btUpdateProduct;
        private Button txtLoadPro;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
    }
}