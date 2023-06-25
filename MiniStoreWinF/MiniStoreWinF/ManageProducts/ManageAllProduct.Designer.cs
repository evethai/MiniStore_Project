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
            NumberQuantityProduct = new NumericUpDown();
            groupBox2 = new GroupBox();
            DgvTypeProduct = new DataGridView();
            idCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catalogyBindingSource3 = new BindingSource(components);
            txtPathPictureProduct = new TextBox();
            txtStatusProduct = new ComboBox();
            txtTypeProductList = new ComboBox();
            dateTimeHSDProduct = new DateTimePicker();
            txtPriceProduct = new TextBox();
            txtNameProduct = new TextBox();
            txtIDProduct = new TextBox();
            dateTimeNXSProduct = new DateTimePicker();
            btDeteleProduct = new Button();
            btUpdateProduct = new Button();
            btCreateProduct = new Button();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
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
            productBindingSource = new BindingSource(components);
            txtArrange = new ComboBox();
            txtCheckType = new CheckBox();
            txtSearchName = new Button();
            txtComboType = new ComboBox();
            txtName = new TextBox();
            txtCheckName = new CheckBox();
            txtLoadPro = new Button();
            btEditStatusProduct = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label11 = new Label();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox5.SuspendLayout();
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
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(25, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Of Type Products";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(266, 103);
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
            btCreateTypeProduct.Location = new Point(166, 103);
            btCreateTypeProduct.Name = "btCreateTypeProduct";
            btCreateTypeProduct.Size = new Size(94, 31);
            btCreateTypeProduct.TabIndex = 4;
            btCreateTypeProduct.Text = "Create";
            btCreateTypeProduct.UseVisualStyleBackColor = true;
            btCreateTypeProduct.Click += btCreateTypeProduct_Click;
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(166, 70);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(211, 27);
            txtTypeProductCategory.TabIndex = 3;
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.BackColor = SystemColors.ControlLight;
            txtIDTypeProduct.Location = new Point(166, 33);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.ReadOnly = true;
            txtIDTypeProduct.Size = new Size(211, 27);
            txtIDTypeProduct.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 74);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Type Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Id Type";
            // 
            // NumberQuantityProduct
            // 
            NumberQuantityProduct.Location = new Point(333, 123);
            NumberQuantityProduct.Name = "NumberQuantityProduct";
            NumberQuantityProduct.Size = new Size(81, 27);
            NumberQuantityProduct.TabIndex = 18;
            NumberQuantityProduct.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvTypeProduct);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(649, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 147);
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
            DgvTypeProduct.Size = new Size(427, 121);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // idCaDataGridViewTextBoxColumn
            // 
            idCaDataGridViewTextBoxColumn.DataPropertyName = "IdCa";
            idCaDataGridViewTextBoxColumn.HeaderText = "IdCa";
            idCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCaDataGridViewTextBoxColumn.Name = "idCaDataGridViewTextBoxColumn";
            idCaDataGridViewTextBoxColumn.Width = 135;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 400;
            // 
            // catalogyBindingSource3
            // 
            catalogyBindingSource3.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // txtPathPictureProduct
            // 
            txtPathPictureProduct.Location = new Point(17, 291);
            txtPathPictureProduct.Name = "txtPathPictureProduct";
            txtPathPictureProduct.Size = new Size(209, 27);
            txtPathPictureProduct.TabIndex = 22;
            txtPathPictureProduct.Visible = false;
            // 
            // txtStatusProduct
            // 
            txtStatusProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStatusProduct.FormattingEnabled = true;
            txtStatusProduct.Items.AddRange(new object[] { "Sold Out", "Availability" });
            txtStatusProduct.Location = new Point(333, 263);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(151, 28);
            txtStatusProduct.TabIndex = 21;
            // 
            // txtTypeProductList
            // 
            txtTypeProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTypeProductList.FormattingEnabled = true;
            txtTypeProductList.Location = new Point(333, 228);
            txtTypeProductList.Name = "txtTypeProductList";
            txtTypeProductList.Size = new Size(151, 28);
            txtTypeProductList.TabIndex = 20;
            // 
            // dateTimeHSDProduct
            // 
            dateTimeHSDProduct.Location = new Point(333, 192);
            dateTimeHSDProduct.Name = "dateTimeHSDProduct";
            dateTimeHSDProduct.Size = new Size(254, 27);
            dateTimeHSDProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(333, 87);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(211, 27);
            txtPriceProduct.TabIndex = 18;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(333, 54);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(211, 27);
            txtNameProduct.TabIndex = 18;
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.ControlLight;
            txtIDProduct.Location = new Point(333, 21);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.ReadOnly = true;
            txtIDProduct.Size = new Size(211, 27);
            txtIDProduct.TabIndex = 17;
            // 
            // dateTimeNXSProduct
            // 
            dateTimeNXSProduct.Location = new Point(333, 156);
            dateTimeNXSProduct.Name = "dateTimeNXSProduct";
            dateTimeNXSProduct.Size = new Size(254, 27);
            dateTimeNXSProduct.TabIndex = 16;
            // 
            // btDeteleProduct
            // 
            btDeteleProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDeteleProduct.ForeColor = SystemColors.ActiveCaptionText;
            btDeteleProduct.Location = new Point(450, 302);
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
            btUpdateProduct.Location = new Point(341, 302);
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
            btCreateProduct.Location = new Point(232, 302);
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
            label10.Location = new Point(231, 266);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 11;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(232, 231);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 10;
            label9.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(231, 121);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(232, 194);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 9;
            label8.Text = "HSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(232, 158);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 8;
            label7.Text = "NXS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(232, 89);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(76, 242);
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
            label4.Location = new Point(232, 54);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 23);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 1;
            label3.Text = "Id Product";
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = SystemColors.ButtonHighlight;
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
            groupBox4.Controls.Add(txtArrange);
            groupBox4.Controls.Add(txtCheckType);
            groupBox4.Controls.Add(txtSearchName);
            groupBox4.Controls.Add(txtComboType);
            groupBox4.Controls.Add(txtName);
            groupBox4.Controls.Add(txtCheckName);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(649, 155);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(542, 348);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "List Product";
            // 
            // DgvListProduct
            // 
            DgvListProduct.AutoGenerateColumns = false;
            DgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListProduct.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn1, nameProductDataGridViewTextBoxColumn, quantityProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn });
            DgvListProduct.DataSource = productBindingSource;
            DgvListProduct.Location = new Point(2, 95);
            DgvListProduct.Name = "DgvListProduct";
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(540, 196);
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // txtArrange
            // 
            txtArrange.DisplayMember = "ALL";
            txtArrange.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "ALL", "Price Ascending", "Price Decrease " });
            txtArrange.Location = new Point(0, 59);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(127, 28);
            txtArrange.TabIndex = 11;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.Location = new Point(161, 62);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 7;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(442, 59);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(100, 29);
            txtSearchName.TabIndex = 8;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // txtComboType
            // 
            txtComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(299, 58);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(128, 28);
            txtComboType.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(299, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 27);
            txtName.TabIndex = 12;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.Location = new Point(161, 26);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 6;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.Location = new Point(766, 457);
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
            btEditStatusProduct.Location = new Point(649, 457);
            btEditStatusProduct.Name = "btEditStatusProduct";
            btEditStatusProduct.Size = new Size(111, 31);
            btEditStatusProduct.TabIndex = 16;
            btEditStatusProduct.Text = "Edit";
            btEditStatusProduct.UseVisualStyleBackColor = true;
            btEditStatusProduct.Click += btEditStatusProduct_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1199, 84);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 17;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btImportPictureProduct);
            groupBox5.Controls.Add(pictureProduct);
            groupBox5.Controls.Add(NumberQuantityProduct);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtPathPictureProduct);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txtStatusProduct);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(txtTypeProductList);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(dateTimeHSDProduct);
            groupBox5.Controls.Add(btCreateProduct);
            groupBox5.Controls.Add(btUpdateProduct);
            groupBox5.Controls.Add(txtPriceProduct);
            groupBox5.Controls.Add(btDeteleProduct);
            groupBox5.Controls.Add(dateTimeNXSProduct);
            groupBox5.Controls.Add(txtNameProduct);
            groupBox5.Controls.Add(txtIDProduct);
            groupBox5.Location = new Point(25, 155);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(602, 348);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Information Of Product";
            // 
            // ManageAllProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1225, 519);
            Controls.Add(groupBox5);
            Controls.Add(label11);
            Controls.Add(btEditStatusProduct);
            Controls.Add(txtLoadPro);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManageAllProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView DgvTypeProduct;
        private GroupBox groupBox4;
        private DataGridView DgvListProduct;
        private PictureBox pictureProduct;
        private BindingSource productBindingSource;
        private Button btCreateTypeProduct;
        private TextBox txtTypeProductCategory;
        private TextBox txtIDTypeProduct;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
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
        private BindingSource catalogyBindingSource3;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label11;
        private DataGridViewTextBoxColumn idCaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private NumericUpDown NumberQuantityProduct;
        private GroupBox groupBox5;
    }
}