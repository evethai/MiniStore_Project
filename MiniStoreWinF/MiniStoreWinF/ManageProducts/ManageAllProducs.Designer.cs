namespace MiniStoreWinF.ManageProducts
{
    partial class ManageAllProducs
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            cbTypeProduct = new ComboBox();
            cbIdSupplier = new ComboBox();
            label2 = new Label();
            txtNameProduct = new TextBox();
            label1 = new Label();
            txtIDProduct = new TextBox();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            dateDateImport = new DateTimePicker();
            label10 = new Label();
            dateEXP = new DateTimePicker();
            cbStatus = new ComboBox();
            label9 = new Label();
            dateMFG = new DateTimePicker();
            groupBox2 = new GroupBox();
            txtPathPicture = new TextBox();
            btImportPictureProduct = new Button();
            PictureProduct = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            mfgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            btImportProduct = new Button();
            txtExpProduct = new Button();
            btUpdate = new Button();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            button1 = new Button();
            groupBox6 = new GroupBox();
            txtArrange = new ComboBox();
            txtCheckName = new CheckBox();
            txtCheckType = new CheckBox();
            txtName = new TextBox();
            txtComboType = new ComboBox();
            btSearch = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 315F));
            tableLayoutPanel1.Size = new Size(1395, 645);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7652969F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.7170639F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4456444F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1389, 215);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cbTypeProduct);
            groupBox3.Controls.Add(cbIdSupplier);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtNameProduct);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtIDProduct);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(463, 209);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information Of Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 180);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 7;
            label4.Text = "ID Supplier";
            // 
            // cbTypeProduct
            // 
            cbTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeProduct.FormattingEnabled = true;
            cbTypeProduct.Location = new Point(132, 92);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(116, 33);
            cbTypeProduct.TabIndex = 4;
            // 
            // cbIdSupplier
            // 
            cbIdSupplier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdSupplier.FormattingEnabled = true;
            cbIdSupplier.Location = new Point(132, 172);
            cbIdSupplier.Name = "cbIdSupplier";
            cbIdSupplier.Size = new Size(116, 33);
            cbIdSupplier.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 140);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtNameProduct
            // 
            txtNameProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameProduct.Location = new Point(132, 132);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(191, 31);
            txtNameProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "ID Product";
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = SystemColors.ScrollBar;
            txtIDProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDProduct.Location = new Point(132, 54);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.ReadOnly = true;
            txtIDProduct.Size = new Size(191, 31);
            txtIDProduct.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(dateDateImport);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(dateEXP);
            groupBox5.Controls.Add(cbStatus);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(dateMFG);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(472, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(504, 209);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Date Import/MFG/EXP";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(24, 175);
            label12.Name = "label12";
            label12.Size = new Size(60, 25);
            label12.TabIndex = 25;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(24, 135);
            label11.Name = "label11";
            label11.Size = new Size(109, 25);
            label11.TabIndex = 23;
            label11.Text = "Date Import";
            // 
            // dateDateImport
            // 
            dateDateImport.Enabled = false;
            dateDateImport.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDateImport.Location = new Point(145, 130);
            dateDateImport.Name = "dateDateImport";
            dateDateImport.Size = new Size(228, 31);
            dateDateImport.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 95);
            label10.Name = "label10";
            label10.Size = new Size(42, 25);
            label10.TabIndex = 21;
            label10.Text = "EXP";
            // 
            // dateEXP
            // 
            dateEXP.Enabled = false;
            dateEXP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEXP.Location = new Point(145, 89);
            dateEXP.Name = "dateEXP";
            dateEXP.Size = new Size(228, 31);
            dateEXP.TabIndex = 20;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Availability", "Sold Out" });
            cbStatus.Location = new Point(145, 172);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(134, 33);
            cbStatus.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(24, 55);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 19;
            label9.Text = "MFG";
            // 
            // dateMFG
            // 
            dateMFG.Enabled = false;
            dateMFG.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateMFG.Location = new Point(145, 49);
            dateMFG.Name = "dateMFG";
            dateMFG.Size = new Size(228, 31);
            dateMFG.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPathPicture);
            groupBox2.Controls.Add(btImportPictureProduct);
            groupBox2.Controls.Add(PictureProduct);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(982, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 209);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Picture Product";
            // 
            // txtPathPicture
            // 
            txtPathPicture.Location = new Point(137, 246);
            txtPathPicture.Name = "txtPathPicture";
            txtPathPicture.Size = new Size(125, 27);
            txtPathPicture.TabIndex = 1;
            txtPathPicture.Visible = false;
            // 
            // btImportPictureProduct
            // 
            btImportPictureProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btImportPictureProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportPictureProduct.Location = new Point(106, 199);
            btImportPictureProduct.Name = "btImportPictureProduct";
            btImportPictureProduct.Size = new Size(94, 31);
            btImportPictureProduct.TabIndex = 6;
            btImportPictureProduct.Text = "Import";
            btImportPictureProduct.UseVisualStyleBackColor = true;
            btImportPictureProduct.Click += btImportPictureProduct_Click;
            // 
            // PictureProduct
            // 
            PictureProduct.BackColor = SystemColors.Info;
            PictureProduct.Location = new Point(51, 49);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(194, 144);
            PictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProduct.TabIndex = 0;
            PictureProduct.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1389, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of Product";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, mfgDataGridViewTextBoxColumn, expDataGridViewTextBoxColumn, dataGridViewTextBoxColumn11 });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1383, 283);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "ProductType";
            dataGridViewTextBoxColumn1.HeaderText = "Type";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NameProduct";
            dataGridViewTextBoxColumn2.HeaderText = "Name Product";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "IdSupplier";
            dataGridViewTextBoxColumn3.HeaderText = "Id Supplier";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // mfgDataGridViewTextBoxColumn
            // 
            mfgDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mfgDataGridViewTextBoxColumn.DataPropertyName = "Mfg";
            mfgDataGridViewTextBoxColumn.HeaderText = "Mfg";
            mfgDataGridViewTextBoxColumn.MinimumWidth = 6;
            mfgDataGridViewTextBoxColumn.Name = "mfgDataGridViewTextBoxColumn";
            // 
            // expDataGridViewTextBoxColumn
            // 
            expDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expDataGridViewTextBoxColumn.DataPropertyName = "Exp";
            expDataGridViewTextBoxColumn.HeaderText = "Exp";
            expDataGridViewTextBoxColumn.MinimumWidth = 6;
            expDataGridViewTextBoxColumn.Name = "expDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn11.DataPropertyName = "DateImport";
            dataGridViewTextBoxColumn11.HeaderText = "DateImport";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox6, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 224);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1389, 103);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btImportProduct);
            groupBox4.Controls.Add(txtExpProduct);
            groupBox4.Controls.Add(btUpdate);
            groupBox4.Controls.Add(rd1);
            groupBox4.Controls.Add(rd2);
            groupBox4.Controls.Add(button1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(688, 97);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Operation";
            // 
            // btImportProduct
            // 
            btImportProduct.BackColor = SystemColors.ButtonShadow;
            btImportProduct.ForeColor = SystemColors.ActiveCaptionText;
            btImportProduct.Location = new Point(383, 22);
            btImportProduct.Name = "btImportProduct";
            btImportProduct.Size = new Size(96, 67);
            btImportProduct.TabIndex = 29;
            btImportProduct.Text = "Import Products";
            btImportProduct.UseVisualStyleBackColor = false;
            btImportProduct.Click += btImportProduct_Click;
            // 
            // txtExpProduct
            // 
            txtExpProduct.BackColor = SystemColors.ButtonShadow;
            txtExpProduct.ForeColor = SystemColors.ActiveCaptionText;
            txtExpProduct.Location = new Point(266, 22);
            txtExpProduct.Name = "txtExpProduct";
            txtExpProduct.Size = new Size(96, 67);
            txtExpProduct.TabIndex = 28;
            txtExpProduct.Text = "Expired Products";
            txtExpProduct.UseVisualStyleBackColor = false;
            txtExpProduct.Click += txtExpProduct_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = SystemColors.ButtonShadow;
            btUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btUpdate.Location = new Point(152, 57);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(96, 32);
            btUpdate.TabIndex = 25;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Checked = true;
            rd1.Location = new Point(36, 30);
            rd1.Margin = new Padding(4, 5, 4, 5);
            rd1.Name = "rd1";
            rd1.Size = new Size(104, 24);
            rd1.TabIndex = 23;
            rd1.TabStop = true;
            rd1.Text = "Availability";
            rd1.UseVisualStyleBackColor = true;
            rd1.CheckedChanged += rd1_CheckedChanged;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(36, 65);
            rd2.Margin = new Padding(4, 5, 4, 5);
            rd2.Name = "rd2";
            rd2.Size = new Size(88, 24);
            rd2.TabIndex = 24;
            rd2.Text = "Sold Out";
            rd2.UseVisualStyleBackColor = true;
            rd2.CheckedChanged += rd2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(152, 22);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 26;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtArrange);
            groupBox6.Controls.Add(txtCheckName);
            groupBox6.Controls.Add(txtCheckType);
            groupBox6.Controls.Add(txtName);
            groupBox6.Controls.Add(txtComboType);
            groupBox6.Controls.Add(btSearch);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(697, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(689, 97);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Filter Products";
            // 
            // txtArrange
            // 
            txtArrange.DisplayMember = "ALL";
            txtArrange.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "ALL", "Name Ascending", "Name Decrease" });
            txtArrange.Location = new Point(262, 61);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(124, 28);
            txtArrange.TabIndex = 35;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // txtCheckName
            // 
            txtCheckName.AutoSize = true;
            txtCheckName.ForeColor = SystemColors.ActiveCaptionText;
            txtCheckName.Location = new Point(31, 29);
            txtCheckName.Name = "txtCheckName";
            txtCheckName.Size = new Size(126, 24);
            txtCheckName.TabIndex = 30;
            txtCheckName.Text = "Name Product";
            txtCheckName.UseVisualStyleBackColor = true;
            // 
            // txtCheckType
            // 
            txtCheckType.AutoSize = true;
            txtCheckType.ForeColor = SystemColors.ActiveCaptionText;
            txtCheckType.Location = new Point(31, 66);
            txtCheckType.Name = "txtCheckType";
            txtCheckType.Size = new Size(117, 24);
            txtCheckType.TabIndex = 31;
            txtCheckType.Text = "Type Product";
            txtCheckType.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(79, 27);
            txtName.TabIndex = 32;
            // 
            // txtComboType
            // 
            txtComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComboType.FormattingEnabled = true;
            txtComboType.Location = new Point(163, 61);
            txtComboType.Name = "txtComboType";
            txtComboType.Size = new Size(79, 28);
            txtComboType.TabIndex = 33;
            // 
            // btSearch
            // 
            btSearch.BackColor = SystemColors.ButtonShadow;
            btSearch.ForeColor = SystemColors.ActiveCaptionText;
            btSearch.Location = new Point(262, 26);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(124, 32);
            btSearch.TabIndex = 34;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // ManageAllProducs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 645);
            Controls.Add(tableLayoutPanel1);
            Name = "ManageAllProducs";
            Text = "ManageAllProducs";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceToOrdersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateImportDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private PictureBox PictureProduct;
        private Button btClearPic;
        private TextBox txtPathPicture;
        private Button btImportPictureProduct;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label label3;
        private ComboBox cbTypeProduct;
        private Label label2;
        private TextBox txtNameProduct;
        private Label label1;
        private TextBox txtIDProduct;
        private Label label4;
        private ComboBox cbIdSupplier;
        private Label label11;
        private DateTimePicker dateDateImport;
        private Label label10;
        private DateTimePicker dateEXP;
        private Label label9;
        private DateTimePicker dateMFG;
        private Label label12;
        private ComboBox cbStatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private RadioButton rd2;
        private RadioButton rd1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btUpdate;
        private Button button4;
        private CheckBox txtCheckType;
        private CheckBox txtCheckName;
        private TextBox txtName;
        private ComboBox txtComboType;
        private Button btSearch;
        private ComboBox txtArrange;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn mfgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Button txtExpProduct;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Button btImportProduct;
    }
}