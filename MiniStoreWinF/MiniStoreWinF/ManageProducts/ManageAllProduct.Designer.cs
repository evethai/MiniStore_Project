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
            catalogyBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).BeginInit();
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
            groupBox1.Location = new Point(28, 3);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(678, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Of Type Products";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(300, 109);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 32);
            button1.TabIndex = 17;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btCreateTypeProduct
            // 
            btCreateTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateTypeProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateTypeProduct.Location = new Point(186, 109);
            btCreateTypeProduct.Margin = new Padding(4, 4, 4, 4);
            btCreateTypeProduct.Name = "btCreateTypeProduct";
            btCreateTypeProduct.Size = new Size(105, 32);
            btCreateTypeProduct.TabIndex = 4;
            btCreateTypeProduct.Text = "Create";
            btCreateTypeProduct.UseVisualStyleBackColor = true;
            btCreateTypeProduct.Click += btCreateTypeProduct_Click;
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(186, 74);
            txtTypeProductCategory.Margin = new Padding(4, 4, 4, 4);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(237, 23);
            txtTypeProductCategory.TabIndex = 3;
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.BackColor = SystemColors.ControlLight;
            txtIDTypeProduct.Location = new Point(186, 35);
            txtIDTypeProduct.Margin = new Padding(4, 4, 4, 4);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.ReadOnly = true;
            txtIDTypeProduct.Size = new Size(237, 23);
            txtIDTypeProduct.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Type Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Id Type";
            // 
            // NumberQuantityProduct
            // 
            NumberQuantityProduct.Location = new Point(374, 130);
            NumberQuantityProduct.Margin = new Padding(4, 4, 4, 4);
            NumberQuantityProduct.Name = "NumberQuantityProduct";
            NumberQuantityProduct.Size = new Size(91, 29);
            NumberQuantityProduct.TabIndex = 18;
            NumberQuantityProduct.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvTypeProduct);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(730, 3);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(481, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Category List";
            // 
            // DgvTypeProduct
            // 
            DgvTypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTypeProduct.Location = new Point(0, 27);
            DgvTypeProduct.Margin = new Padding(4, 4, 4, 4);
            DgvTypeProduct.Name = "DgvTypeProduct";
            DgvTypeProduct.RowHeadersWidth = 51;
            DgvTypeProduct.RowTemplate.Height = 29;
            DgvTypeProduct.Size = new Size(481, 127);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // catalogyBindingSource
            // 
            catalogyBindingSource.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // txtPathPictureProduct
            // 
            txtPathPictureProduct.Location = new Point(19, 305);
            txtPathPictureProduct.Margin = new Padding(4, 4, 4, 4);
            txtPathPictureProduct.Name = "txtPathPictureProduct";
            txtPathPictureProduct.Size = new Size(234, 29);
            txtPathPictureProduct.TabIndex = 22;
            txtPathPictureProduct.Visible = false;
            // 
            // txtStatusProduct
            // 
            txtStatusProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStatusProduct.FormattingEnabled = true;
            txtStatusProduct.Items.AddRange(new object[] { "Sold Out", "Availability" });
            txtStatusProduct.Location = new Point(374, 277);
            txtStatusProduct.Margin = new Padding(4, 4, 4, 4);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(170, 29);
            txtStatusProduct.TabIndex = 21;
            // 
            // txtTypeProductList
            // 
            txtTypeProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTypeProductList.FormattingEnabled = true;
            txtTypeProductList.Location = new Point(374, 239);
            txtTypeProductList.Margin = new Padding(4, 4, 4, 4);
            txtTypeProductList.Name = "txtTypeProductList";
            txtTypeProductList.Size = new Size(170, 29);
            txtTypeProductList.TabIndex = 20;
            // 
            // dateTimeHSDProduct
            // 
            dateTimeHSDProduct.Location = new Point(374, 202);
            dateTimeHSDProduct.Margin = new Padding(4, 4, 4, 4);
            dateTimeHSDProduct.Name = "dateTimeHSDProduct";
            dateTimeHSDProduct.Size = new Size(286, 29);
            dateTimeHSDProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(374, 91);
            txtPriceProduct.Margin = new Padding(4, 4, 4, 4);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(237, 29);
            txtPriceProduct.TabIndex = 18;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(374, 57);
            txtNameProduct.Margin = new Padding(4, 4, 4, 4);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(237, 29);
            txtNameProduct.TabIndex = 18;
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.ControlLight;
            txtIDProduct.Location = new Point(374, 22);
            txtIDProduct.Margin = new Padding(4, 4, 4, 4);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.ReadOnly = true;
            txtIDProduct.Size = new Size(237, 29);
            txtIDProduct.TabIndex = 17;
            // 
            // dateTimeNXSProduct
            // 
            dateTimeNXSProduct.Location = new Point(374, 164);
            dateTimeNXSProduct.Margin = new Padding(4, 4, 4, 4);
            dateTimeNXSProduct.Name = "dateTimeNXSProduct";
            dateTimeNXSProduct.Size = new Size(286, 29);
            dateTimeNXSProduct.TabIndex = 16;
            // 
            // btDeteleProduct
            // 
            btDeteleProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDeteleProduct.ForeColor = SystemColors.ActiveCaptionText;
            btDeteleProduct.Location = new Point(507, 318);
            btDeteleProduct.Margin = new Padding(4, 4, 4, 4);
            btDeteleProduct.Name = "btDeteleProduct";
            btDeteleProduct.Size = new Size(105, 32);
            btDeteleProduct.TabIndex = 14;
            btDeteleProduct.Text = "Detele";
            btDeteleProduct.UseVisualStyleBackColor = true;
            btDeteleProduct.Click += btDeteleProduct_Click;
            // 
            // btUpdateProduct
            // 
            btUpdateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btUpdateProduct.Location = new Point(383, 318);
            btUpdateProduct.Margin = new Padding(4, 4, 4, 4);
            btUpdateProduct.Name = "btUpdateProduct";
            btUpdateProduct.Size = new Size(105, 32);
            btUpdateProduct.TabIndex = 13;
            btUpdateProduct.Text = "Update";
            btUpdateProduct.UseVisualStyleBackColor = true;
            btUpdateProduct.Click += btUpdateProduct_Click;
            // 
            // btCreateProduct
            // 
            btCreateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateProduct.Location = new Point(261, 318);
            btCreateProduct.Margin = new Padding(4, 4, 4, 4);
            btCreateProduct.Name = "btCreateProduct";
            btCreateProduct.Size = new Size(105, 32);
            btCreateProduct.TabIndex = 12;
            btCreateProduct.Text = "Create";
            btCreateProduct.UseVisualStyleBackColor = true;
            btCreateProduct.Click += btCreateProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(260, 279);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 11;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(261, 242);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 10;
            label9.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(260, 127);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(261, 204);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 9;
            label8.Text = "HSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(261, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 8;
            label7.Text = "NXS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(261, 94);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(85, 255);
            btImportPictureProduct.Margin = new Padding(4, 4, 4, 4);
            btImportPictureProduct.Name = "btImportPictureProduct";
            btImportPictureProduct.Size = new Size(105, 32);
            btImportPictureProduct.TabIndex = 5;
            btImportPictureProduct.Text = "Import";
            btImportPictureProduct.UseVisualStyleBackColor = true;
            btImportPictureProduct.Click += btImportPictureProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 57);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(261, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Id Product";
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = SystemColors.ButtonHighlight;
            pictureProduct.Image = Properties.Resources.icons8_fast_moving_consumer_goods_50;
            pictureProduct.Location = new Point(17, 27);
            pictureProduct.Margin = new Padding(4, 4, 4, 4);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(237, 203);
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
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(730, 162);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(609, 365);
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
            DgvListProduct.Location = new Point(3, 99);
            DgvListProduct.Margin = new Padding(4, 4, 4, 4);
            DgvListProduct.Name = "DgvListProduct";
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(607, 206);
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
            txtArrange.Location = new Point(0, 62);
            txtArrange.Margin = new Padding(4, 4, 4, 4);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(143, 29);
            txtArrange.TabIndex = 11;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.Location = new Point(181, 66);
            txtCheckType.Margin = new Padding(4, 4, 4, 4);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(119, 25);
            txtCheckType.TabIndex = 7;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(498, 62);
            txtSearchName.Margin = new Padding(4, 4, 4, 4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(113, 31);
            txtSearchName.TabIndex = 8;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // txtComboType
            // 
            txtComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(337, 60);
            txtComboType.Margin = new Padding(4, 4, 4, 4);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(143, 29);
            txtComboType.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(337, 25);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 29);
            txtName.TabIndex = 12;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.Location = new Point(181, 27);
            txtCheckName.Margin = new Padding(4, 4, 4, 4);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(129, 25);
            txtCheckName.TabIndex = 6;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.Location = new Point(861, 479);
            txtLoadPro.Margin = new Padding(4, 4, 4, 4);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(125, 32);
            txtLoadPro.TabIndex = 14;
            txtLoadPro.Text = "Load";
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // btEditStatusProduct
            // 
            btEditStatusProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btEditStatusProduct.ForeColor = SystemColors.ActiveCaptionText;
            btEditStatusProduct.Location = new Point(730, 479);
            btEditStatusProduct.Margin = new Padding(4, 4, 4, 4);
            btEditStatusProduct.Name = "btEditStatusProduct";
            btEditStatusProduct.Size = new Size(125, 32);
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
            label11.Location = new Point(1349, 88);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
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
            groupBox5.Location = new Point(28, 162);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(678, 365);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Information Of Product";
            // 
            // ManageAllProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1378, 714);
            Controls.Add(groupBox5);
            Controls.Add(label11);
            Controls.Add(btEditStatusProduct);
            Controls.Add(txtLoadPro);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageAllProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).EndInit();
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
        private BindingSource catalogyBindingSource;
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
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label11;
        private NumericUpDown NumberQuantityProduct;
        private GroupBox groupBox5;
    }
}