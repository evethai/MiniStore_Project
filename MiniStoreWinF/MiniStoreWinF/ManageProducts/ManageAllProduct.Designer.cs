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
            NumberQuantityProduct = new NumericUpDown();
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
            productBindingSource = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label11 = new Label();
            groupBox5 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            btEditStatusProduct = new Button();
            txtArrange = new ComboBox();
            txtLoadPro = new Button();
            DgvListProduct = new DataGridView();
            txtComboType = new ComboBox();
            txtCheckType = new CheckBox();
            txtCheckName = new CheckBox();
            txtName = new TextBox();
            txtSearchName = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            DgvTypeProduct = new DataGridView();
            txtTypeProductCategory = new TextBox();
            btCreateTypeProduct = new Button();
            label1 = new Label();
            label2 = new Label();
            txtIDTypeProduct = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // NumberQuantityProduct
            // 
            NumberQuantityProduct.Location = new Point(157, 155);
            NumberQuantityProduct.Name = "NumberQuantityProduct";
            NumberQuantityProduct.Size = new Size(80, 27);
            NumberQuantityProduct.TabIndex = 18;
            NumberQuantityProduct.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPathPictureProduct
            // 
            txtPathPictureProduct.Location = new Point(72, 217);
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
            txtStatusProduct.Location = new Point(598, 114);
            txtStatusProduct.Name = "txtStatusProduct";
            txtStatusProduct.Size = new Size(130, 28);
            txtStatusProduct.TabIndex = 21;
            // 
            // txtTypeProductList
            // 
            txtTypeProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTypeProductList.FormattingEnabled = true;
            txtTypeProductList.Location = new Point(598, 154);
            txtTypeProductList.Name = "txtTypeProductList";
            txtTypeProductList.Size = new Size(130, 28);
            txtTypeProductList.TabIndex = 20;
            // 
            // dateTimeHSDProduct
            // 
            dateTimeHSDProduct.Location = new Point(598, 74);
            dateTimeHSDProduct.Name = "dateTimeHSDProduct";
            dateTimeHSDProduct.Size = new Size(269, 27);
            dateTimeHSDProduct.TabIndex = 19;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(157, 115);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(203, 27);
            txtPriceProduct.TabIndex = 18;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(157, 75);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(203, 27);
            txtNameProduct.TabIndex = 18;
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.Window;
            txtIDProduct.Location = new Point(157, 35);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(203, 27);
            txtIDProduct.TabIndex = 17;
            // 
            // dateTimeNXSProduct
            // 
            dateTimeNXSProduct.Location = new Point(598, 34);
            dateTimeNXSProduct.Name = "dateTimeNXSProduct";
            dateTimeNXSProduct.Size = new Size(269, 27);
            dateTimeNXSProduct.TabIndex = 16;
            // 
            // btDeteleProduct
            // 
            btDeteleProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDeteleProduct.ForeColor = SystemColors.ActiveCaptionText;
            btDeteleProduct.Location = new Point(384, 217);
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
            btUpdateProduct.Location = new Point(266, 217);
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
            btCreateProduct.Location = new Point(157, 217);
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
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(510, 114);
            label10.Name = "label10";
            label10.Size = new Size(65, 28);
            label10.TabIndex = 11;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(510, 154);
            label9.Name = "label9";
            label9.Size = new Size(53, 28);
            label9.TabIndex = 10;
            label9.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 155);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(510, 74);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 9;
            label8.Text = "HSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(510, 34);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 8;
            label7.Text = "NXS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 115);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(135, 180);
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
            label4.Location = new Point(29, 75);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 35);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Id Product";
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = SystemColors.ButtonHighlight;
            pictureProduct.Location = new Point(103, 28);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(152, 146);
            pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProduct.TabIndex = 0;
            pictureProduct.TabStop = false;
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
            groupBox5.Controls.Add(NumberQuantityProduct);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(txtTypeProductList);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txtStatusProduct);
            groupBox5.Controls.Add(btDeteleProduct);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(btUpdateProduct);
            groupBox5.Controls.Add(btCreateProduct);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(dateTimeHSDProduct);
            groupBox5.Controls.Add(txtPriceProduct);
            groupBox5.Controls.Add(dateTimeNXSProduct);
            groupBox5.Controls.Add(txtNameProduct);
            groupBox5.Controls.Add(txtIDProduct);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1012, 268);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Information Of Product";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.5859871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.4140129F));
            tableLayoutPanel1.Size = new Size(1375, 628);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.3813F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.6187F));
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 283);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1369, 342);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btEditStatusProduct);
            groupBox3.Controls.Add(txtArrange);
            groupBox3.Controls.Add(txtLoadPro);
            groupBox3.Controls.Add(DgvListProduct);
            groupBox3.Controls.Add(txtComboType);
            groupBox3.Controls.Add(txtCheckType);
            groupBox3.Controls.Add(txtCheckName);
            groupBox3.Controls.Add(txtName);
            groupBox3.Controls.Add(txtSearchName);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(848, 336);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "List Product";
            // 
            // btEditStatusProduct
            // 
            btEditStatusProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btEditStatusProduct.ForeColor = SystemColors.ActiveCaptionText;
            btEditStatusProduct.Location = new Point(434, 29);
            btEditStatusProduct.Name = "btEditStatusProduct";
            btEditStatusProduct.Size = new Size(111, 31);
            btEditStatusProduct.TabIndex = 16;
            btEditStatusProduct.Text = "Edit";
            btEditStatusProduct.UseVisualStyleBackColor = true;
            btEditStatusProduct.Click += btEditStatusProduct_Click;
            // 
            // txtArrange
            // 
            txtArrange.DisplayMember = "ALL";
            txtArrange.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "ALL", "Price Ascending", "Price Decrease " });
            txtArrange.Location = new Point(309, 65);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(100, 28);
            txtArrange.TabIndex = 11;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtLoadPro
            // 
            txtLoadPro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoadPro.Location = new Point(434, 65);
            txtLoadPro.Name = "txtLoadPro";
            txtLoadPro.Size = new Size(111, 31);
            txtLoadPro.TabIndex = 14;
            txtLoadPro.Text = "Load";
            txtLoadPro.UseVisualStyleBackColor = true;
            txtLoadPro.Click += txtLoadPro_Click;
            // 
            // DgvListProduct
            // 
            DgvListProduct.AutoGenerateColumns = false;
            DgvListProduct.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListProduct.DataSource = productBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvListProduct.DefaultCellStyle = dataGridViewCellStyle2;
            DgvListProduct.Dock = DockStyle.Bottom;
            DgvListProduct.Location = new Point(3, 113);
            DgvListProduct.Name = "DgvListProduct";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvListProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvListProduct.RowHeadersWidth = 51;
            DgvListProduct.RowTemplate.Height = 29;
            DgvListProduct.Size = new Size(842, 220);
            DgvListProduct.TabIndex = 0;
            DgvListProduct.CellClick += DgvListProduct_CellClick;
            // 
            // txtComboType
            // 
            txtComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(163, 65);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(128, 28);
            txtComboType.TabIndex = 13;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.Location = new Point(25, 69);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 7;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.Location = new Point(25, 33);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 6;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 27);
            txtName.TabIndex = 12;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchName.Location = new Point(309, 30);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(100, 29);
            txtSearchName.TabIndex = 8;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = true;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(DgvTypeProduct);
            groupBox2.Controls.Add(txtTypeProductCategory);
            groupBox2.Controls.Add(btCreateTypeProduct);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtIDTypeProduct);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(857, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 336);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Category List";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(363, 67);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 17;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DgvTypeProduct
            // 
            DgvTypeProduct.AutoGenerateColumns = false;
            DgvTypeProduct.BackgroundColor = SystemColors.Window;
            DgvTypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTypeProduct.DataSource = catalogyBindingSource3;
            DgvTypeProduct.Dock = DockStyle.Bottom;
            DgvTypeProduct.Location = new Point(3, 113);
            DgvTypeProduct.Name = "DgvTypeProduct";
            DgvTypeProduct.RowHeadersWidth = 51;
            DgvTypeProduct.RowTemplate.Height = 29;
            DgvTypeProduct.Size = new Size(503, 220);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(128, 66);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(211, 27);
            txtTypeProductCategory.TabIndex = 3;
            // 
            // btCreateTypeProduct
            // 
            btCreateTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateTypeProduct.ForeColor = SystemColors.ActiveCaptionText;
            btCreateTypeProduct.Location = new Point(362, 27);
            btCreateTypeProduct.Name = "btCreateTypeProduct";
            btCreateTypeProduct.Size = new Size(96, 32);
            btCreateTypeProduct.TabIndex = 4;
            btCreateTypeProduct.Text = "Create";
            btCreateTypeProduct.UseVisualStyleBackColor = true;
            btCreateTypeProduct.Click += btCreateTypeProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Id Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Type Product";
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.BackColor = SystemColors.Window;
            txtIDTypeProduct.Location = new Point(128, 29);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.ReadOnly = true;
            txtIDTypeProduct.Size = new Size(211, 27);
            txtIDTypeProduct.TabIndex = 2;
            txtIDTypeProduct.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 351F));
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox6, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1369, 274);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btImportPictureProduct);
            groupBox6.Controls.Add(pictureProduct);
            groupBox6.Controls.Add(txtPathPictureProduct);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(1021, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(345, 268);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Picture Of Product";
            // 
            // ManageAllProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1375, 628);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label11);
            Name = "ManageAllProduct";
            ((System.ComponentModel.ISupportInitialize)NumberQuantityProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListProduct).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureProduct;
        private BindingSource productBindingSource;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox3;
        private Button btEditStatusProduct;
        private DataGridView DgvListProduct;
        private ComboBox txtComboType;
        private Button txtLoadPro;
        private CheckBox txtCheckName;
        private TextBox txtName;
        private Button txtSearchName;
        private ComboBox txtArrange;
        private CheckBox txtCheckType;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridView DgvTypeProduct;
        private Button btCreateTypeProduct;
        private TextBox txtTypeProductCategory;
        private Label label1;
        private TextBox txtIDTypeProduct;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox6;
    }
}