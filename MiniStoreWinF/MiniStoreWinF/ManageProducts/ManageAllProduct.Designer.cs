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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAllProduct));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            DgvTypeProduct = new DataGridView();
            idCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catalogyBindingSource1 = new BindingSource(components);
            button1 = new Button();
            txtIDTypeProduct = new TextBox();
            label1 = new Label();
            btCreateTypeProduct = new Button();
            label2 = new Label();
            txtTypeProductCategory = new TextBox();
            NumberQuantityProduct = new NumericUpDown();
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
            txtPriceFilter2 = new TextBox();
            txtPriceFilter1 = new TextBox();
            btPrictProduct = new Button();
            label12 = new Label();
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
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            button3 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DgvTypeProduct);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtIDTypeProduct);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btCreateTypeProduct);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTypeProductCategory);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Type Products";
            // 
            // DgvTypeProduct
            // 
            DgvTypeProduct.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvTypeProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvTypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTypeProduct.Columns.AddRange(new DataGridViewColumn[] { idCaDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn });
            DgvTypeProduct.DataSource = catalogyBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvTypeProduct.DefaultCellStyle = dataGridViewCellStyle2;
            DgvTypeProduct.Location = new Point(0, 98);
            DgvTypeProduct.Name = "DgvTypeProduct";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvTypeProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvTypeProduct.RowHeadersWidth = 51;
            DgvTypeProduct.RowTemplate.Height = 29;
            DgvTypeProduct.Size = new Size(502, 210);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // idCaDataGridViewTextBoxColumn
            // 
            idCaDataGridViewTextBoxColumn.DataPropertyName = "IdCa";
            idCaDataGridViewTextBoxColumn.HeaderText = "IdCa";
            idCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCaDataGridViewTextBoxColumn.Name = "idCaDataGridViewTextBoxColumn";
            idCaDataGridViewTextBoxColumn.Width = 235;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 530;
            // 
            // catalogyBindingSource1
            // 
            catalogyBindingSource1.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(380, 61);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 17;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.BackColor = SystemColors.Window;
            txtIDTypeProduct.Location = new Point(143, 29);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.Size = new Size(211, 27);
            txtIDTypeProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Id Type";
            // 
            // btCreateTypeProduct
            // 
            btCreateTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateTypeProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateTypeProduct.Location = new Point(380, 25);
            btCreateTypeProduct.Name = "btCreateTypeProduct";
            btCreateTypeProduct.Size = new Size(100, 31);
            btCreateTypeProduct.TabIndex = 4;
            btCreateTypeProduct.Text = "Create";
            btCreateTypeProduct.UseVisualStyleBackColor = true;
            btCreateTypeProduct.Click += btCreateTypeProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(8, 70);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Type Product";
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(143, 66);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(211, 27);
            txtTypeProductCategory.TabIndex = 3;
            // 
            // NumberQuantityProduct
            // 
            NumberQuantityProduct.Location = new Point(386, 89);
            NumberQuantityProduct.Name = "NumberQuantityProduct";
            NumberQuantityProduct.Size = new Size(89, 27);
            NumberQuantityProduct.TabIndex = 18;
            NumberQuantityProduct.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPathPictureProduct
            // 
            txtPathPictureProduct.Location = new Point(727, 119);
            txtPathPictureProduct.Name = "txtPathPictureProduct";
            txtPathPictureProduct.Size = new Size(98, 27);
            txtPathPictureProduct.TabIndex = 22;
            txtPathPictureProduct.Visible = false;
            // 
            // txtStatusProduct
            // 
            txtStatusProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStatusProduct.FormattingEnabled = true;
            txtStatusProduct.Items.AddRange(new object[] { "Sold Out", "Availability" });
            txtStatusProduct.Location = new Point(383, 143);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(124, 28);
            txtStatusProduct.TabIndex = 21;
            // 
            // txtTypeProductList
            // 
            txtTypeProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTypeProductList.FormattingEnabled = true;
            txtTypeProductList.Location = new Point(111, 143);
            txtTypeProductList.Name = "txtTypeProductList";
            txtTypeProductList.Size = new Size(114, 28);
            txtTypeProductList.TabIndex = 20;
            // 
            // dateTimeHSDProduct
            // 
            dateTimeHSDProduct.Location = new Point(569, 86);
            dateTimeHSDProduct.Name = "dateTimeHSDProduct";
            dateTimeHSDProduct.Size = new Size(256, 27);
            dateTimeHSDProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(383, 47);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(124, 27);
            txtPriceProduct.TabIndex = 18;
            txtPriceProduct.Leave += txtPriceProduct_Leave;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(111, 93);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(180, 27);
            txtNameProduct.TabIndex = 18;
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.Window;
            txtIDProduct.Location = new Point(111, 48);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(100, 27);
            txtIDProduct.TabIndex = 17;
            // 
            // dateTimeNXSProduct
            // 
            dateTimeNXSProduct.Location = new Point(569, 43);
            dateTimeNXSProduct.Name = "dateTimeNXSProduct";
            dateTimeNXSProduct.Size = new Size(256, 27);
            dateTimeNXSProduct.TabIndex = 16;
            // 
            // btDeteleProduct
            // 
            btDeteleProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDeteleProduct.ForeColor = SystemColors.ActiveCaptionText;
            btDeteleProduct.Image = (Image)resources.GetObject("btDeteleProduct.Image");
            btDeteleProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btDeteleProduct.Location = new Point(285, 206);
            btDeteleProduct.Name = "btDeteleProduct";
            btDeteleProduct.Size = new Size(80, 32);
            btDeteleProduct.TabIndex = 14;
            btDeteleProduct.Text = "Detele";
            btDeteleProduct.TextAlign = ContentAlignment.MiddleRight;
            btDeteleProduct.UseVisualStyleBackColor = true;
            btDeteleProduct.Click += btDeteleProduct_Click;
            // 
            // btUpdateProduct
            // 
            btUpdateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btUpdateProduct.Image = (Image)resources.GetObject("btUpdateProduct.Image");
            btUpdateProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btUpdateProduct.Location = new Point(149, 206);
            btUpdateProduct.Name = "btUpdateProduct";
            btUpdateProduct.Size = new Size(80, 32);
            btUpdateProduct.TabIndex = 13;
            btUpdateProduct.Text = "Update";
            btUpdateProduct.TextAlign = ContentAlignment.MiddleRight;
            btUpdateProduct.UseVisualStyleBackColor = true;
            btUpdateProduct.Click += btUpdateProduct_Click;
            // 
            // btCreateProduct
            // 
            btCreateProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateProduct.Image = (Image)resources.GetObject("btCreateProduct.Image");
            btCreateProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btCreateProduct.Location = new Point(21, 206);
            btCreateProduct.Name = "btCreateProduct";
            btCreateProduct.Size = new Size(80, 32);
            btCreateProduct.TabIndex = 12;
            btCreateProduct.Text = "Create";
            btCreateProduct.TextAlign = ContentAlignment.MiddleRight;
            btCreateProduct.UseVisualStyleBackColor = true;
            btCreateProduct.Click += btCreateProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 0, 192);
            label10.Location = new Point(300, 141);
            label10.Name = "label10";
            label10.Size = new Size(65, 28);
            label10.TabIndex = 11;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(10, 143);
            label9.Name = "label9";
            label9.Size = new Size(53, 28);
            label9.TabIndex = 10;
            label9.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(300, 94);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(517, 91);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 9;
            label8.Text = "HSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(517, 44);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 8;
            label7.Text = "NXS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(299, 49);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(831, 206);
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
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(10, 92);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(10, 50);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Id Product";
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = SystemColors.ButtonHighlight;
            pictureProduct.Image = (Image)resources.GetObject("pictureProduct.Image");
            pictureProduct.Location = new Point(831, 43);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(194, 157);
            pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProduct.TabIndex = 0;
            pictureProduct.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtPriceFilter2);
            groupBox4.Controls.Add(txtPriceFilter1);
            groupBox4.Controls.Add(btPrictProduct);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(DgvListProduct);
            groupBox4.Controls.Add(txtArrange);
            groupBox4.Controls.Add(txtCheckType);
            groupBox4.Controls.Add(txtSearchName);
            groupBox4.Controls.Add(txtComboType);
            groupBox4.Controls.Add(txtName);
            groupBox4.Controls.Add(txtCheckName);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(515, 330);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "List Product";
            // 
            // txtPriceFilter2
            // 
            txtPriceFilter2.Location = new Point(435, 37);
            txtPriceFilter2.Name = "txtPriceFilter2";
            txtPriceFilter2.Size = new Size(70, 27);
            txtPriceFilter2.TabIndex = 24;
            // 
            // txtPriceFilter1
            // 
            txtPriceFilter1.Location = new Point(350, 37);
            txtPriceFilter1.Name = "txtPriceFilter1";
            txtPriceFilter1.Size = new Size(70, 27);
            txtPriceFilter1.TabIndex = 24;
            // 
            // btPrictProduct
            // 
            btPrictProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btPrictProduct.ForeColor = SystemColors.ActiveCaptionText;
            btPrictProduct.Location = new Point(277, 18);
            btPrictProduct.Name = "btPrictProduct";
            btPrictProduct.Size = new Size(67, 60);
            btPrictProduct.TabIndex = 24;
            btPrictProduct.Text = "Price";
            btPrictProduct.UseVisualStyleBackColor = true;
            btPrictProduct.Click += btPrictProduct_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(408, 40);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 14;
            label12.Text = "---->";
            // 
            // DgvListProduct
            // 
            DgvListProduct.AutoGenerateColumns = false;
            DgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListProduct.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn1, nameProductDataGridViewTextBoxColumn, quantityProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn });
            DgvListProduct.DataSource = productBindingSource;
            DgvListProduct.Location = new Point(0, 98);
            DgvListProduct.Name = "DgvListProduct";
            DgvListProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(507, 210);
            DgvListProduct.TabIndex = 0;
            DgvListProduct.CellClick += DgvListProduct_CellClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Id Product";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.Width = 130;
            // 
            // productTypeDataGridViewTextBoxColumn1
            // 
            productTypeDataGridViewTextBoxColumn1.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn1.HeaderText = "Type";
            productTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn1.Name = "productTypeDataGridViewTextBoxColumn1";
            productTypeDataGridViewTextBoxColumn1.Width = 156;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Name Product";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 250;
            // 
            // quantityProductDataGridViewTextBoxColumn
            // 
            quantityProductDataGridViewTextBoxColumn.DataPropertyName = "QuantityProduct";
            quantityProductDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityProductDataGridViewTextBoxColumn.Name = "quantityProductDataGridViewTextBoxColumn";
            quantityProductDataGridViewTextBoxColumn.Width = 172;
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            dataGridViewCellStyle4.Format = "#,###";
            dataGridViewCellStyle4.NullValue = "0";
            priceProductDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            priceProductDataGridViewTextBoxColumn.HeaderText = "Price";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            priceProductDataGridViewTextBoxColumn.Width = 158;
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
            txtArrange.Location = new Point(192, 58);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(79, 28);
            txtArrange.TabIndex = 11;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.ForeColor = Color.FromArgb(0, 0, 192);
            txtCheckType.Location = new Point(12, 64);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 7;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(192, 18);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(79, 21);
            txtSearchName.TabIndex = 8;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // txtComboType
            // 
            txtComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(107, 57);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(79, 28);
            txtComboType.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(79, 27);
            txtName.TabIndex = 12;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.ForeColor = Color.FromArgb(0, 0, 192);
            txtCheckName.Location = new Point(12, 27);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 6;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.ForeColor = SystemColors.ActiveCaptionText;
            txtLoadPro.Image = (Image)resources.GetObject("txtLoadPro.Image");
            txtLoadPro.ImageAlign = ContentAlignment.MiddleLeft;
            txtLoadPro.Location = new Point(541, 206);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(80, 32);
            txtLoadPro.TabIndex = 14;
            txtLoadPro.Text = "Load";
            txtLoadPro.TextAlign = ContentAlignment.MiddleRight;
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // btEditStatusProduct
            // 
            btEditStatusProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btEditStatusProduct.ForeColor = SystemColors.ActiveCaptionText;
            btEditStatusProduct.Image = (Image)resources.GetObject("btEditStatusProduct.Image");
            btEditStatusProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btEditStatusProduct.Location = new Point(405, 206);
            btEditStatusProduct.Name = "btEditStatusProduct";
            btEditStatusProduct.Size = new Size(80, 32);
            btEditStatusProduct.TabIndex = 16;
            btEditStatusProduct.Text = "Edit";
            btEditStatusProduct.TextAlign = ContentAlignment.MiddleRight;
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
            label11.Location = new Point(1051, 108);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 17;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(931, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 23;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6809349F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3190651F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(2, 323);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1028, 336);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 330);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(524, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 330);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1037, 260);
            panel3.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(txtLoadPro);
            groupBox2.Controls.Add(txtPriceProduct);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtNameProduct);
            groupBox2.Controls.Add(btDeteleProduct);
            groupBox2.Controls.Add(dateTimeNXSProduct);
            groupBox2.Controls.Add(btUpdateProduct);
            groupBox2.Controls.Add(txtIDProduct);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btCreateProduct);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btEditStatusProduct);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btImportPictureProduct);
            groupBox2.Controls.Add(dateTimeHSDProduct);
            groupBox2.Controls.Add(txtPathPictureProduct);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(pictureProduct);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(NumberQuantityProduct);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTypeProductList);
            groupBox2.Controls.Add(txtStatusProduct);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1037, 260);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information Of Product";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(669, 206);
            button3.Name = "button3";
            button3.Size = new Size(80, 32);
            button3.TabIndex = 24;
            button3.Text = "Export";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1043, 266);
            tableLayoutPanel2.TabIndex = 27;
            // 
            // ManageAllProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1091, 721);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.Control;
            Name = "ManageAllProduct";
            Load += ManageAllProduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DgvTypeProduct;
        private GroupBox groupBox4;
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label11;
        private NumericUpDown NumberQuantityProduct;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private BindingSource catalogyBindingSource1;
        private DataGridViewTextBoxColumn idCaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private TextBox txtPriceFilter2;
        private TextBox txtPriceFilter1;
        private Button btPrictProduct;
        private Label label12;
        private Button button3;
        protected DataGridView DgvListProduct;
    }
}