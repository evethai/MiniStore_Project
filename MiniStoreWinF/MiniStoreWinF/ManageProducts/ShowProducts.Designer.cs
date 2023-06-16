namespace MiniStoreWinF.ManageProducts

{
    partial class ShowProducts
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
            dgvProduct = new DataGridView();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nxxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource1 = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            txtBackMaPro = new Button();
            txtSearchName = new Button();
            txtName = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            catalogyBindingSource = new BindingSource(components);
            catalogyBindingSource1 = new BindingSource(components);
            txtComboType = new ComboBox();
            txtCheckName = new CheckBox();
            txtCheckType = new CheckBox();
            txtLoadPro = new Button();
            PicShowPro = new PictureBox();
            btArrange = new Button();
            txtArrange = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicShowPro).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, quantityProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, nxxDataGridViewTextBoxColumn, hsdDataGridViewTextBoxColumn, statusPDataGridViewTextBoxColumn });
            dgvProduct.DataSource = productBindingSource1;
            dgvProduct.Location = new Point(29, 48);
            dgvProduct.Margin = new Padding(3, 4, 3, 4);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(578, 290);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.FillWeight = 150F;
            skuDataGridViewTextBoxColumn.HeaderText = "ID Product";
            skuDataGridViewTextBoxColumn.MinimumWidth = 40;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.Width = 110;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = " Type";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Name ";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 10;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityProductDataGridViewTextBoxColumn
            // 
            quantityProductDataGridViewTextBoxColumn.DataPropertyName = "QuantityProduct";
            quantityProductDataGridViewTextBoxColumn.HeaderText = "Quantity ";
            quantityProductDataGridViewTextBoxColumn.MinimumWidth = 10;
            quantityProductDataGridViewTextBoxColumn.Name = "quantityProductDataGridViewTextBoxColumn";
            quantityProductDataGridViewTextBoxColumn.Width = 90;
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "Price";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 10;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            priceProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // nxxDataGridViewTextBoxColumn
            // 
            nxxDataGridViewTextBoxColumn.DataPropertyName = "Nxx";
            nxxDataGridViewTextBoxColumn.HeaderText = "Nxx";
            nxxDataGridViewTextBoxColumn.MinimumWidth = 10;
            nxxDataGridViewTextBoxColumn.Name = "nxxDataGridViewTextBoxColumn";
            nxxDataGridViewTextBoxColumn.Width = 125;
            // 
            // hsdDataGridViewTextBoxColumn
            // 
            hsdDataGridViewTextBoxColumn.DataPropertyName = "Hsd";
            hsdDataGridViewTextBoxColumn.HeaderText = "Hsd";
            hsdDataGridViewTextBoxColumn.MinimumWidth = 10;
            hsdDataGridViewTextBoxColumn.Name = "hsdDataGridViewTextBoxColumn";
            hsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPDataGridViewTextBoxColumn
            // 
            statusPDataGridViewTextBoxColumn.DataPropertyName = "StatusP";
            statusPDataGridViewTextBoxColumn.HeaderText = "StatusP";
            statusPDataGridViewTextBoxColumn.MinimumWidth = 10;
            statusPDataGridViewTextBoxColumn.Name = "statusPDataGridViewTextBoxColumn";
            statusPDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Repository.Models.Product);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // txtBackMaPro
            // 
            txtBackMaPro.Location = new Point(29, 12);
            txtBackMaPro.Name = "txtBackMaPro";
            txtBackMaPro.Size = new Size(94, 29);
            txtBackMaPro.TabIndex = 1;
            txtBackMaPro.Text = "Back";
            txtBackMaPro.UseVisualStyleBackColor = true;
            txtBackMaPro.Click += txtBackMaPro_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(496, 394);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(111, 29);
            txtSearchName.TabIndex = 2;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(326, 352);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 27);
            txtName.TabIndex = 3;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // catalogyBindingSource
            // 
            catalogyBindingSource.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // catalogyBindingSource1
            // 
            catalogyBindingSource1.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // txtComboType
            // 
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(326, 395);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(164, 28);
            txtComboType.TabIndex = 4;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.Location = new Point(194, 355);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 5;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.Location = new Point(194, 399);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 6;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Location = new Point(496, 350);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(111, 29);
            txtLoadPro.TabIndex = 7;
            txtLoadPro.Text = "Load";
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // PicShowPro
            // 
            PicShowPro.Location = new Point(656, 84);
            PicShowPro.Name = "PicShowPro";
            PicShowPro.Size = new Size(225, 221);
            PicShowPro.SizeMode = PictureBoxSizeMode.StretchImage;
            PicShowPro.TabIndex = 8;
            PicShowPro.TabStop = false;
            // 
            // btArrange
            // 
            btArrange.Location = new Point(29, 394);
            btArrange.Name = "btArrange";
            btArrange.Size = new Size(94, 29);
            btArrange.TabIndex = 9;
            btArrange.Text = "Arrange";
            btArrange.UseVisualStyleBackColor = true;
            btArrange.Click += btArrange_Click;
            // 
            // txtArrange
            // 
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "Price Ascending", "Price Decrease " });
            txtArrange.Location = new Point(29, 353);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(151, 28);
            txtArrange.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(656, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 11;
            label1.Text = "Picture";
            // 
            // ShowProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 497);
            Controls.Add(label1);
            Controls.Add(txtArrange);
            Controls.Add(btArrange);
            Controls.Add(PicShowPro);
            Controls.Add(txtLoadPro);
            Controls.Add(txtCheckType);
            Controls.Add(txtCheckName);
            Controls.Add(txtComboType);
            Controls.Add(txtName);
            Controls.Add(txtSearchName);
            Controls.Add(txtBackMaPro);
            Controls.Add(dgvProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowProducts";
            Text = "ShowProducts";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicShowPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private Button txtBackMaPro;
        private BindingSource productBindingSource;
        private Button txtSearchName;
        private TextBox txtName;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource catalogyBindingSource;
        private BindingSource catalogyBindingSource1;
        private ComboBox txtComboType;
        private CheckBox txtCheckName;
        private CheckBox txtCheckType;
        private Button txtLoadPro;
        private BindingSource productBindingSource1;
        private PictureBox PicShowPro;
        private Button btArrange;
        private ComboBox txtArrange;
        private Label label1;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusPDataGridViewTextBoxColumn;
    }
}