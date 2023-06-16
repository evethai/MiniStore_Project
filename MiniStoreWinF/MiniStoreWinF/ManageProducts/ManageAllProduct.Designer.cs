namespace MiniStoreWinF.ManageProducts
{
    partial class ManageAllProduct
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            btCreateTypeProduct = new Button();
            txtTypeProductCategory = new TextBox();
            txtIDTypeProduct = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            DgvTypeProduct = new DataGridView();
            idCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catalogyBindingSource = new BindingSource(components);
            catalogyBindingSource1 = new BindingSource(components);
            groupBox3 = new GroupBox();
            txtPathPictureProduct = new TextBox();
            txtStatusProduct = new ComboBox();
            txtTypeProductList = new ComboBox();
            dateTimeHSDProduct = new DateTimePicker();
            txtPriceProduct = new TextBox();
            txtNameProduct = new TextBox();
            txtIDProduct = new TextBox();
            dateTimeNXSProduct = new DateTimePicker();
            NumberQuantityProduct = new NumericUpDown();
            btDeteleProduct = new Button();
            btUpdateProduct = new Button();
            btCreateProduct = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btImportPictureProduct = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureProduct = new PictureBox();
            groupBox4 = new GroupBox();
            DgvListProduct = new DataGridView();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nxxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            catalogyBindingSource2 = new BindingSource(components);
            txtCheckName = new CheckBox();
            txtCheckType = new CheckBox();
            txtSearchName = new Button();
            txtArrange = new ComboBox();
            txtName = new TextBox();
            txtComboType = new ComboBox();
            txtLoadPro = new Button();
            btEditStatusProduct = new Button();
            catalogyBindingSource3 = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btCreateTypeProduct);
            groupBox1.Controls.Add(txtTypeProductCategory);
            groupBox1.Controls.Add(txtIDTypeProduct);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Of Type Products";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(266, 128);
            button1.Name = "button1";
            button1.Size = new Size(111, 31);
            button1.TabIndex = 17;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btCreateTypeProduct
            // 
            btCreateTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateTypeProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateTypeProduct.Location = new Point(166, 128);
            btCreateTypeProduct.Name = "btCreateTypeProduct";
            btCreateTypeProduct.Size = new Size(94, 31);
            btCreateTypeProduct.TabIndex = 4;
            btCreateTypeProduct.Text = "Create";
            btCreateTypeProduct.UseVisualStyleBackColor = true;
            btCreateTypeProduct.Click += btCreateTypeProduct_Click;
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(166, 95);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(211, 27);
            txtTypeProductCategory.TabIndex = 3;
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.Location = new Point(166, 52);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.Size = new Size(211, 27);
            txtIDTypeProduct.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 99);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Type Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Id Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvTypeProduct);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(649, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 155);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Category List";
            // 
            // DgvTypeProduct
            // 
            DgvTypeProduct.AutoGenerateColumns = false;
            DgvTypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTypeProduct.Columns.AddRange(new DataGridViewColumn[] { idCaDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn });
            DgvTypeProduct.DataSource = catalogyBindingSource3;
            DgvTypeProduct.Location = new Point(0, 26);
            DgvTypeProduct.Name = "DgvTypeProduct";
            DgvTypeProduct.RowHeadersWidth = 51;
            DgvTypeProduct.RowTemplate.Height = 29;
            DgvTypeProduct.Size = new Size(285, 127);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // idCaDataGridViewTextBoxColumn
            // 
            idCaDataGridViewTextBoxColumn.DataPropertyName = "IdCa";
            idCaDataGridViewTextBoxColumn.HeaderText = "IdCa";
            idCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCaDataGridViewTextBoxColumn.Name = "idCaDataGridViewTextBoxColumn";
            idCaDataGridViewTextBoxColumn.Width = 90;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // catalogyBindingSource
            // 
            catalogyBindingSource.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // catalogyBindingSource1
            // 
            catalogyBindingSource1.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPathPictureProduct);
            groupBox3.Controls.Add(txtStatusProduct);
            groupBox3.Controls.Add(txtTypeProductList);
            groupBox3.Controls.Add(dateTimeHSDProduct);
            groupBox3.Controls.Add(txtPriceProduct);
            groupBox3.Controls.Add(txtNameProduct);
            groupBox3.Controls.Add(txtIDProduct);
            groupBox3.Controls.Add(dateTimeNXSProduct);
            groupBox3.Controls.Add(NumberQuantityProduct);
            groupBox3.Controls.Add(btDeteleProduct);
            groupBox3.Controls.Add(btUpdateProduct);
            groupBox3.Controls.Add(btCreateProduct);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btImportPictureProduct);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(pictureProduct);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(25, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(592, 348);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information Of Product";
            // 
            // txtPathPictureProduct
            // 
            txtPathPictureProduct.Location = new Point(15, 267);
            txtPathPictureProduct.Name = "txtPathPictureProduct";
            txtPathPictureProduct.Size = new Size(209, 27);
            txtPathPictureProduct.TabIndex = 22;
            txtPathPictureProduct.Visible = false;
            // 
            // txtStatusProduct
            // 
            txtStatusProduct.FormattingEnabled = true;
            txtStatusProduct.Items.AddRange(new object[] { "Sold Out", "Availability" });
            txtStatusProduct.Location = new Point(332, 263);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(151, 28);
            txtStatusProduct.TabIndex = 21;
            // 
            // txtTypeProductList
            // 
            txtTypeProductList.FormattingEnabled = true;
            txtTypeProductList.Location = new Point(332, 228);
            txtTypeProductList.Name = "txtTypeProductList";
            txtTypeProductList.Size = new Size(151, 28);
            txtTypeProductList.TabIndex = 20;
            // 
            // dateTimeHSDProduct
            // 
            dateTimeHSDProduct.Location = new Point(332, 192);
            dateTimeHSDProduct.Name = "dateTimeHSDProduct";
            dateTimeHSDProduct.Size = new Size(254, 27);
            dateTimeHSDProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(332, 122);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(211, 27);
            txtPriceProduct.TabIndex = 18;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(332, 54);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(211, 27);
            txtNameProduct.TabIndex = 18;
            // 
            // txtIDProduct
            // 
            txtIDProduct.Location = new Point(332, 21);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(211, 27);
            txtIDProduct.TabIndex = 17;
            // 
            // dateTimeNXSProduct
            // 
            dateTimeNXSProduct.Location = new Point(332, 156);
            dateTimeNXSProduct.Name = "dateTimeNXSProduct";
            dateTimeNXSProduct.Size = new Size(254, 27);
            dateTimeNXSProduct.TabIndex = 16;
            // 
            // NumberQuantityProduct
            // 
            NumberQuantityProduct.Location = new Point(332, 87);
            NumberQuantityProduct.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumberQuantityProduct.Name = "NumberQuantityProduct";
            NumberQuantityProduct.Size = new Size(75, 27);
            NumberQuantityProduct.TabIndex = 15;
            NumberQuantityProduct.TextAlign = HorizontalAlignment.Right;
            // 
            // btDeteleProduct
            // 
            btDeteleProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDeteleProduct.ForeColor = SystemColors.ActiveCaptionText;
            btDeteleProduct.Location = new Point(449, 302);
            btDeteleProduct.Name = "btDeteleProduct";
            btDeteleProduct.Size = new Size(94, 31);
            btDeteleProduct.TabIndex = 14;
            btDeteleProduct.Text = "Detele";
            btDeteleProduct.UseVisualStyleBackColor = true;
            btDeteleProduct.Click += btDeteleProduct_Click;
            // 
            // btUpdateProduct
            // 
            btUpdateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btUpdateProduct.Location = new Point(340, 302);
            btUpdateProduct.Name = "btUpdateProduct";
            btUpdateProduct.Size = new Size(94, 31);
            btUpdateProduct.TabIndex = 13;
            btUpdateProduct.Text = "Update";
            btUpdateProduct.UseVisualStyleBackColor = true;
            btUpdateProduct.Click += btUpdateProduct_Click;
            // 
            // btCreateProduct
            // 
            btCreateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateProduct.Location = new Point(231, 302);
            btCreateProduct.Name = "btCreateProduct";
            btCreateProduct.Size = new Size(94, 31);
            btCreateProduct.TabIndex = 12;
            btCreateProduct.Text = "Create";
            btCreateProduct.UseVisualStyleBackColor = true;
            btCreateProduct.Click += btCreateProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(230, 266);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 11;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(231, 231);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 10;
            label9.Text = "Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(231, 194);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 9;
            label8.Text = "HSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(231, 158);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 8;
            label7.Text = "NXS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(231, 124);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(231, 89);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(72, 225);
            btImportPictureProduct.Name = "btImportPictureProduct";
            btImportPictureProduct.Size = new Size(94, 31);
            btImportPictureProduct.TabIndex = 5;
            btImportPictureProduct.Text = "Import";
            btImportPictureProduct.UseVisualStyleBackColor = true;
            btImportPictureProduct.Click += btImportPictureProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(231, 54);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(231, 23);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 1;
            label3.Text = "Id Product";
            // 
            // pictureProduct
            // 
            pictureProduct.Location = new Point(15, 26);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(210, 193);
            pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProduct.TabIndex = 0;
            pictureProduct.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(DgvListProduct);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(633, 273);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(506, 205);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "List Product";
            // 
            // DgvListProduct
            // 
            DgvListProduct.AutoGenerateColumns = false;
            DgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListProduct.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn1, nameProductDataGridViewTextBoxColumn, quantityProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, nxxDataGridViewTextBoxColumn, hsdDataGridViewTextBoxColumn, statusPDataGridViewTextBoxColumn });
            DgvListProduct.DataSource = productBindingSource;
            DgvListProduct.Location = new Point(0, 26);
            DgvListProduct.Name = "DgvListProduct";
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(506, 176);
            DgvListProduct.TabIndex = 0;
            DgvListProduct.CellClick += DgvListProduct_CellClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Id Product";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.Width = 110;
            // 
            // productTypeDataGridViewTextBoxColumn1
            // 
            productTypeDataGridViewTextBoxColumn1.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn1.HeaderText = "Type";
            productTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn1.Name = "productTypeDataGridViewTextBoxColumn1";
            productTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Name Product";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityProductDataGridViewTextBoxColumn
            // 
            quantityProductDataGridViewTextBoxColumn.DataPropertyName = "QuantityProduct";
            quantityProductDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityProductDataGridViewTextBoxColumn.Name = "quantityProductDataGridViewTextBoxColumn";
            quantityProductDataGridViewTextBoxColumn.Width = 110;
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "Price";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            priceProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // nxxDataGridViewTextBoxColumn
            // 
            nxxDataGridViewTextBoxColumn.DataPropertyName = "Nxx";
            nxxDataGridViewTextBoxColumn.HeaderText = "NXS";
            nxxDataGridViewTextBoxColumn.MinimumWidth = 6;
            nxxDataGridViewTextBoxColumn.Name = "nxxDataGridViewTextBoxColumn";
            nxxDataGridViewTextBoxColumn.Width = 125;
            // 
            // hsdDataGridViewTextBoxColumn
            // 
            hsdDataGridViewTextBoxColumn.DataPropertyName = "Hsd";
            hsdDataGridViewTextBoxColumn.HeaderText = "HSD";
            hsdDataGridViewTextBoxColumn.MinimumWidth = 6;
            hsdDataGridViewTextBoxColumn.Name = "hsdDataGridViewTextBoxColumn";
            hsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPDataGridViewTextBoxColumn
            // 
            statusPDataGridViewTextBoxColumn.DataPropertyName = "StatusP";
            statusPDataGridViewTextBoxColumn.HeaderText = "Status";
            statusPDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusPDataGridViewTextBoxColumn.Name = "statusPDataGridViewTextBoxColumn";
            statusPDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // catalogyBindingSource2
            // 
            catalogyBindingSource2.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.Location = new Point(766, 221);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 6;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.Location = new Point(766, 244);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 7;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(1032, 244);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(111, 29);
            txtSearchName.TabIndex = 8;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // txtArrange
            // 
            txtArrange.DisplayMember = "ALL";
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "ALL", "Price Ascending", "Price Decrease " });
            txtArrange.Location = new Point(633, 239);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(127, 28);
            txtArrange.TabIndex = 11;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(898, 211);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 27);
            txtName.TabIndex = 12;
            // 
            // txtComboType
            // 
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(898, 244);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(128, 28);
            txtComboType.TabIndex = 13;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.Location = new Point(750, 486);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(111, 31);
            txtLoadPro.TabIndex = 14;
            txtLoadPro.Text = "Load";
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // btEditStatusProduct
            // 
            btEditStatusProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btEditStatusProduct.ForeColor = SystemColors.ActiveCaptionText;
            btEditStatusProduct.Location = new Point(633, 486);
            btEditStatusProduct.Name = "btEditStatusProduct";
            btEditStatusProduct.Size = new Size(111, 31);
            btEditStatusProduct.TabIndex = 16;
            btEditStatusProduct.Text = "Edit";
            btEditStatusProduct.UseVisualStyleBackColor = true;
            btEditStatusProduct.Click += btEditStatusProduct_Click;
            // 
            // catalogyBindingSource3
            // 
            catalogyBindingSource3.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // ManageAllProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1151, 535);
            Controls.Add(btEditStatusProduct);
            Controls.Add(txtLoadPro);
            Controls.Add(txtComboType);
            Controls.Add(txtName);
            Controls.Add(txtArrange);
            Controls.Add(txtSearchName);
            Controls.Add(txtCheckType);
            Controls.Add(txtCheckName);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManageAllProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView DgvTypeProduct;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView DgvListProduct;
        private BindingSource catalogyBindingSource;
        private PictureBox pictureProduct;
        private BindingSource productBindingSource;
        private Button btCreateTypeProduct;
        private TextBox txtTypeProductCategory;
        private TextBox txtIDTypeProduct;
        private Label label2;
        private Label label1;
        private BindingSource catalogyBindingSource1;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusPDataGridViewTextBoxColumn;
        private BindingSource catalogyBindingSource2;
        private Button btImportPictureProduct;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btDeteleProduct;
        private Button btUpdateProduct;
        private Button btCreateProduct;
        private Label label10;
        private Label label9;
        private ComboBox txtStatusProduct;
        private ComboBox txtTypeProductList;
        private DateTimePicker dateTimeHSDProduct;
        private TextBox txtPriceProduct;
        private TextBox txtNameProduct;
        private TextBox txtIDProduct;
        private DateTimePicker dateTimeNXSProduct;
        private NumericUpDown NumberQuantityProduct;
        private TextBox txtPathPictureProduct;
        private CheckBox txtCheckName;
        private CheckBox txtCheckType;
        private Button txtSearchName;
        private ComboBox txtArrange;
        private TextBox txtName;
        private ComboBox txtComboType;
        private Button txtLoadPro;
        private Button btEditStatusProduct;
        private Button button1;
        private DataGridViewTextBoxColumn idCaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private BindingSource catalogyBindingSource3;
    }
}