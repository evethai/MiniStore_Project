namespace MiniStoreWinF.OrdersProducts
{
    partial class OrderProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProducts));
            dgvShowListProducts = new DataGridView();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mfgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            panel4 = new Panel();
            label3 = new Label();
            btSearch = new Button();
            txtSearchName = new TextBox();
            label1 = new Label();
            cbTypeProducts = new ComboBox();
            panel2 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            listViewOrders = new ListView();
            clmSKU = new ColumnHeader();
            clmName = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmTotal = new ColumnHeader();
            panel5 = new Panel();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            btMoMo = new RadioButton();
            txtScanVoucher = new TextBox();
            btUsingVoucher = new Button();
            btCheckMember = new Button();
            label8 = new Label();
            btShowBill = new Button();
            cbPointUsing = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtTotalAllOrders = new TextBox();
            panel6 = new Panel();
            label9 = new Label();
            panel10 = new Panel();
            pcPictureOrders = new PictureBox();
            btAddOrders = new Button();
            txtNameOrder = new TextBox();
            label2 = new Label();
            txtQuantityOrder = new NumericUpDown();
            txtPriceOrder = new TextBox();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            txtEmployee = new ToolStripTextBox();
            Information = new ToolStripMenuItem();
            checkOutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowListProducts
            // 
            dgvShowListProducts.AutoGenerateColumns = false;
            dgvShowListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowListProducts.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, mfgDataGridViewTextBoxColumn, expDataGridViewTextBoxColumn });
            dgvShowListProducts.DataSource = productBindingSource;
            dgvShowListProducts.Location = new Point(0, 0);
            dgvShowListProducts.Margin = new Padding(4, 4, 4, 4);
            dgvShowListProducts.Name = "dgvShowListProducts";
            dgvShowListProducts.RowHeadersWidth = 51;
            dgvShowListProducts.RowTemplate.Height = 29;
            dgvShowListProducts.Size = new Size(751, 568);
            dgvShowListProducts.TabIndex = 2;
            dgvShowListProducts.CellDoubleClick += dgvShowListProducts_CellDoubleClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Name";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "Price";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            // 
            // mfgDataGridViewTextBoxColumn
            // 
            mfgDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mfgDataGridViewTextBoxColumn.DataPropertyName = "Mfg";
            mfgDataGridViewTextBoxColumn.HeaderText = "MFG";
            mfgDataGridViewTextBoxColumn.MinimumWidth = 6;
            mfgDataGridViewTextBoxColumn.Name = "mfgDataGridViewTextBoxColumn";
            // 
            // expDataGridViewTextBoxColumn
            // 
            expDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expDataGridViewTextBoxColumn.DataPropertyName = "Exp";
            expDataGridViewTextBoxColumn.HeaderText = "EXP";
            expDataGridViewTextBoxColumn.MinimumWidth = 6;
            expDataGridViewTextBoxColumn.Name = "expDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btSearch);
            panel4.Controls.Add(txtSearchName);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 86);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Name :";
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(257, 23);
            btSearch.Margin = new Padding(4, 4, 4, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(105, 44);
            btSearch.TabIndex = 4;
            btSearch.Text = "Search";
            btSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(85, 32);
            txtSearchName.Margin = new Padding(4, 4, 4, 4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(153, 29);
            txtSearchName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "Type :";
            // 
            // cbTypeProducts
            // 
            cbTypeProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTypeProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbTypeProducts.Location = new Point(78, 31);
            cbTypeProducts.Margin = new Padding(4, 4, 4, 4);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(192, 29);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvShowListProducts);
            panel2.Location = new Point(0, 86);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 581);
            panel2.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(cbTypeProducts);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(390, 0);
            panel8.Margin = new Padding(4, 4, 4, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(363, 86);
            panel8.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(listViewOrders);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1255, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 692);
            panel1.TabIndex = 1;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { clmSKU, clmName, clmQuantity, clmPrice, clmTotal });
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(4, 4);
            listViewOrders.Margin = new Padding(4, 4, 4, 4);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(561, 644);
            listViewOrders.TabIndex = 9;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.MouseDoubleClick += listViewOrders_MouseDoubleClick;
            // 
            // clmSKU
            // 
            clmSKU.Text = "SKU";
            // 
            // clmName
            // 
            clmName.Text = "Name";
            clmName.Width = 110;
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Quantity";
            clmQuantity.Width = 110;
            // 
            // clmPrice
            // 
            clmPrice.Text = "Price";
            clmPrice.Width = 110;
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            clmTotal.Width = 110;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(txtScanVoucher);
            panel5.Controls.Add(btUsingVoucher);
            panel5.Controls.Add(btCheckMember);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(btShowBill);
            panel5.Controls.Add(cbPointUsing);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtTotalAllOrders);
            panel5.Location = new Point(751, 353);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 294);
            panel5.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(btMoMo);
            groupBox1.Location = new Point(12, 156);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(195, 110);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 30);
            radioButton1.Margin = new Padding(4, 4, 4, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btMoMo
            // 
            btMoMo.AutoSize = true;
            btMoMo.Location = new Point(41, 65);
            btMoMo.Margin = new Padding(4, 4, 4, 4);
            btMoMo.Name = "btMoMo";
            btMoMo.Size = new Size(74, 25);
            btMoMo.TabIndex = 22;
            btMoMo.TabStop = true;
            btMoMo.Text = "MoMo";
            btMoMo.UseVisualStyleBackColor = true;
            btMoMo.CheckedChanged += btMoMo_CheckedChanged;
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(104, 19);
            txtScanVoucher.Margin = new Padding(4, 4, 4, 4);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(210, 29);
            txtScanVoucher.TabIndex = 20;
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Location = new Point(320, 16);
            btUsingVoucher.Margin = new Padding(4, 4, 4, 4);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(105, 31);
            btUsingVoucher.TabIndex = 19;
            btUsingVoucher.Text = "Use";
            btUsingVoucher.UseVisualStyleBackColor = true;
            btUsingVoucher.Click += btUsingVoucher_Click;
            // 
            // btCheckMember
            // 
            btCheckMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCheckMember.Image = (Image)resources.GetObject("btCheckMember.Image");
            btCheckMember.ImageAlign = ContentAlignment.TopCenter;
            btCheckMember.Location = new Point(368, 177);
            btCheckMember.Margin = new Padding(4, 4, 4, 4);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(111, 73);
            btCheckMember.TabIndex = 6;
            btCheckMember.Text = "Member";
            btCheckMember.TextAlign = ContentAlignment.BottomCenter;
            btCheckMember.UseVisualStyleBackColor = true;
            btCheckMember.Click += btCheckMember_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 74);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 18;
            label8.Text = "Point :";
            // 
            // btShowBill
            // 
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(239, 177);
            btShowBill.Margin = new Padding(4, 4, 4, 4);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(111, 73);
            btShowBill.TabIndex = 11;
            btShowBill.Text = "Bill";
            btShowBill.TextAlign = ContentAlignment.BottomCenter;
            btShowBill.UseVisualStyleBackColor = true;
            btShowBill.Click += btShowBill_Click;
            // 
            // cbPointUsing
            // 
            cbPointUsing.Enabled = false;
            cbPointUsing.FormattingEnabled = true;
            cbPointUsing.Location = new Point(104, 74);
            cbPointUsing.Margin = new Padding(4, 4, 4, 4);
            cbPointUsing.Name = "cbPointUsing";
            cbPointUsing.Size = new Size(210, 29);
            cbPointUsing.TabIndex = 17;
            cbPointUsing.SelectedIndexChanged += cbPointUsing_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 121);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 15;
            label7.Text = "Total :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Vourcher:";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(104, 117);
            txtTotalAllOrders.Margin = new Padding(4, 4, 4, 4);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(210, 29);
            txtTotalAllOrders.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.Controls.Add(label9);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(btAddOrders);
            panel6.Controls.Add(txtNameOrder);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txtQuantityOrder);
            panel6.Controls.Add(txtPriceOrder);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(751, 0);
            panel6.Margin = new Padding(4, 4, 4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(500, 347);
            panel6.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(36, 149);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 12;
            label9.Text = "Picture:";
            // 
            // panel10
            // 
            panel10.Controls.Add(pcPictureOrders);
            panel10.Location = new Point(117, 151);
            panel10.Margin = new Padding(4, 4, 4, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(233, 185);
            panel10.TabIndex = 11;
            // 
            // pcPictureOrders
            // 
            pcPictureOrders.BorderStyle = BorderStyle.Fixed3D;
            pcPictureOrders.Dock = DockStyle.Fill;
            pcPictureOrders.Location = new Point(0, 0);
            pcPictureOrders.Margin = new Padding(4, 4, 4, 4);
            pcPictureOrders.Name = "pcPictureOrders";
            pcPictureOrders.Size = new Size(233, 185);
            pcPictureOrders.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureOrders.TabIndex = 0;
            pcPictureOrders.TabStop = false;
            // 
            // btAddOrders
            // 
            btAddOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAddOrders.Image = (Image)resources.GetObject("btAddOrders.Image");
            btAddOrders.Location = new Point(386, 298);
            btAddOrders.Margin = new Padding(4, 4, 4, 4);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(112, 38);
            btAddOrders.TabIndex = 8;
            btAddOrders.UseVisualStyleBackColor = true;
            btAddOrders.Click += btAddOrders_Click;
            // 
            // txtNameOrder
            // 
            txtNameOrder.Location = new Point(117, 7);
            txtNameOrder.Margin = new Padding(4, 4, 4, 4);
            txtNameOrder.Name = "txtNameOrder";
            txtNameOrder.ReadOnly = true;
            txtNameOrder.Size = new Size(233, 29);
            txtNameOrder.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtQuantityOrder
            // 
            txtQuantityOrder.Location = new Point(117, 54);
            txtQuantityOrder.Margin = new Padding(4, 4, 4, 4);
            txtQuantityOrder.Name = "txtQuantityOrder";
            txtQuantityOrder.Size = new Size(233, 29);
            txtQuantityOrder.TabIndex = 10;
            txtQuantityOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPriceOrder
            // 
            txtPriceOrder.Location = new Point(117, 100);
            txtPriceOrder.Margin = new Padding(4, 4, 4, 4);
            txtPriceOrder.Name = "txtPriceOrder";
            txtPriceOrder.ReadOnly = true;
            txtPriceOrder.Size = new Size(233, 29);
            txtPriceOrder.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { txtEmployee, Information });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1819, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // txtEmployee
            // 
            txtEmployee.AutoSize = false;
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(224, 25);
            txtEmployee.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // Information
            // 
            Information.DropDownItems.AddRange(new ToolStripItem[] { checkOutToolStripMenuItem });
            Information.Name = "Information";
            Information.Size = new Size(42, 28);
            Information.Text = "Info";
            // 
            // checkOutToolStripMenuItem
            // 
            checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            checkOutToolStripMenuItem.Size = new Size(136, 22);
            checkOutToolStripMenuItem.Text = "Check-Out";
            checkOutToolStripMenuItem.Click += checkOutToolStripMenuItem_Click;
            // 
            // OrderProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 692);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "OrderProducts";
            Text = "OrderProducts";
            Load += OrderProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvShowListProducts;
        private Panel panel4;
        private Label label3;
        private Button btSearch;
        private TextBox txtSearchName;
        private Label label1;
        private ComboBox cbTypeProducts;
        private Panel panel2;
        private Panel panel1;
        private Button btCheckMember;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btAddOrders;
        private ListView listViewOrders;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmPrice;
        private ColumnHeader clmName;
        private ColumnHeader clmTotal;
        private Button btShowBill;
        private Panel panel5;
        private Label label7;
        private Label label6;
        private TextBox txtTotalAllOrders;
        private MenuStrip menuStrip1;
        private TextBox txtNameOrder;
        private NumericUpDown txtQuantityOrder;
        private TextBox txtPriceOrder;
        private Panel panel6;
        private Label label8;
        private ComboBox cbPointUsing;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private Panel panel8;
        private Label label9;
        private Panel panel10;
        private PictureBox pcPictureOrders;
        private ToolStripTextBox txtEmployee;
        private ToolStripMenuItem Information;
        private ToolStripMenuItem checkOutToolStripMenuItem;
        private ColumnHeader clmSKU;
        private Button btUsingVoucher;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mfgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDataGridViewTextBoxColumn;
        private TextBox txtScanVoucher;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton btMoMo;
    }
}