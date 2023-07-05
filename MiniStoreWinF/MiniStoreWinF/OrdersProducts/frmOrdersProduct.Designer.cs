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
            mfgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            pnlAll = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btSearch = new Button();
            cbTypeProducts = new ComboBox();
            txtSearchName = new TextBox();
            lblType = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            btUsingPoint = new Button();
            txtPointUsing = new TextBox();
            label3 = new Label();
            txtLoyaltyPoint = new TextBox();
            lb = new Label();
            txtScanVoucher = new TextBox();
            btUsingVoucher = new Button();
            btCheckMember = new Button();
            panel2 = new Panel();
            rdCashpayment = new RadioButton();
            rdMomopayment = new RadioButton();
            lblVoucher = new Label();
            panel6 = new Panel();
            cbUnitQuantity = new ComboBox();
            label1 = new Label();
            pcPictureOrders = new PictureBox();
            lblPicture = new Label();
            btAddOrders = new Button();
            txtNameOrder = new TextBox();
            lblName = new Label();
            txtQuantityOrder = new NumericUpDown();
            txtPriceOrder = new TextBox();
            lblPrice = new Label();
            lblQuantity = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            listViewOrders = new ListView();
            clmSKU = new ColumnHeader();
            clmName = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmUnit = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmTotal = new ColumnHeader();
            pnlCashPayment = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            btReturnMoney = new Button();
            txtProvidesCash = new TextBox();
            txtReturnPayment = new TextBox();
            btShowBill = new Button();
            lblCustomerProvidesCash = new Label();
            lblReturnChange = new Label();
            panel3 = new Panel();
            btCancelBill = new Button();
            txtDiscount = new TextBox();
            lblTotal = new Label();
            txtTotalAllOrders = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            pnlAll.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            pnlCashPayment.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowListProducts
            // 
            dgvShowListProducts.AutoGenerateColumns = false;
            dgvShowListProducts.BackgroundColor = SystemColors.Control;
            dgvShowListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowListProducts.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, mfgDataGridViewTextBoxColumn, expDataGridViewTextBoxColumn });
            dgvShowListProducts.DataSource = productBindingSource;
            dgvShowListProducts.Dock = DockStyle.Fill;
            dgvShowListProducts.Location = new Point(4, 159);
            dgvShowListProducts.Margin = new Padding(4);
            dgvShowListProducts.Name = "dgvShowListProducts";
            dgvShowListProducts.RowHeadersWidth = 51;
            dgvShowListProducts.RowTemplate.Height = 29;
            dgvShowListProducts.Size = new Size(625, 873);
            dgvShowListProducts.TabIndex = 2;
            dgvShowListProducts.CellMouseDoubleClick += dgvShowListProducts_CellMouseDoubleClick;
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
            // pnlAll
            // 
            pnlAll.Controls.Add(tableLayoutPanel1);
            pnlAll.Dock = DockStyle.Fill;
            pnlAll.Location = new Point(0, 0);
            pnlAll.Margin = new Padding(4);
            pnlAll.Name = "pnlAll";
            pnlAll.Size = new Size(1924, 1044);
            pnlAll.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1924, 1044);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvShowListProducts, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(633, 1036);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(cbTypeProducts);
            panel1.Controls.Add(txtSearchName);
            panel1.Controls.Add(lblType);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 147);
            panel1.TabIndex = 19;
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(425, 15);
            btSearch.Margin = new Padding(4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(128, 59);
            btSearch.TabIndex = 4;
            btSearch.Text = "Search";
            btSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // cbTypeProducts
            // 
            cbTypeProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTypeProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbTypeProducts.Location = new Point(231, 73);
            cbTypeProducts.Margin = new Padding(4);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(166, 36);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(132, 27);
            txtSearchName.Margin = new Padding(4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(283, 34);
            txtSearchName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(143, 77);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 15);
            lblType.TabIndex = 7;
            lblType.Text = "Type :";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(645, 4);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Size = new Size(633, 1036);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btUsingPoint);
            panel5.Controls.Add(txtPointUsing);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtLoyaltyPoint);
            panel5.Controls.Add(lb);
            panel5.Controls.Add(txtScanVoucher);
            panel5.Controls.Add(btCheckMember);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(lblVoucher);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 677);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(625, 355);
            panel5.TabIndex = 16;
            // 
            // btUsingPoint
            // 
            btUsingPoint.Location = new Point(439, 185);
            btUsingPoint.Margin = new Padding(4);
            btUsingPoint.Name = "btUsingPoint";
            btUsingPoint.Size = new Size(129, 41);
            btUsingPoint.TabIndex = 28;
            btUsingPoint.Text = "Use";
            btUsingPoint.UseVisualStyleBackColor = true;
            btUsingPoint.Click += btUsingPoint_Click;
            // 
            // txtPointUsing
            // 
            txtPointUsing.Location = new Point(187, 182);
            txtPointUsing.Margin = new Padding(4);
            txtPointUsing.Name = "txtPointUsing";
            txtPointUsing.Size = new Size(206, 34);
            txtPointUsing.TabIndex = 27;
            txtPointUsing.KeyPress += txtPointUsing_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 196);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 26;
            label3.Text = "Point Using:";
            // 
            // txtLoyaltyPoint
            // 
            txtLoyaltyPoint.Location = new Point(187, 106);
            txtLoyaltyPoint.Margin = new Padding(4);
            txtLoyaltyPoint.Name = "txtLoyaltyPoint";
            txtLoyaltyPoint.ReadOnly = true;
            txtLoyaltyPoint.Size = new Size(206, 34);
            txtLoyaltyPoint.TabIndex = 23;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb.Location = new Point(26, 106);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(108, 20);
            lb.TabIndex = 22;
            lb.Text = "Loyalty points:";
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(160, 24);
            txtScanVoucher.Margin = new Padding(4);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(256, 34);
            txtScanVoucher.TabIndex = 20;
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Location = new Point(439, 24);
            btUsingVoucher.Margin = new Padding(4);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(138, 38);
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
            btCheckMember.Location = new Point(439, 70);
            btCheckMember.Margin = new Padding(4);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(136, 98);
            btCheckMember.TabIndex = 6;
            btCheckMember.Text = "Member";
            btCheckMember.TextAlign = ContentAlignment.BottomCenter;
            btCheckMember.UseVisualStyleBackColor = true;
            btCheckMember.Click += btCheckMember_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdCashpayment);
            panel2.Controls.Add(rdMomopayment);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 272);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 83);
            panel2.TabIndex = 21;
            // 
            // rdCashpayment
            // 
            rdCashpayment.AutoSize = true;
            rdCashpayment.Location = new Point(370, 21);
            rdCashpayment.Margin = new Padding(4);
            rdCashpayment.Name = "rdCashpayment";
            rdCashpayment.Size = new Size(156, 32);
            rdCashpayment.TabIndex = 1;
            rdCashpayment.TabStop = true;
            rdCashpayment.Text = "Cash payment";
            rdCashpayment.UseVisualStyleBackColor = true;
            rdCashpayment.CheckedChanged += rdCashpayment_CheckedChanged;
            // 
            // rdMomopayment
            // 
            rdMomopayment.AutoSize = true;
            rdMomopayment.Location = new Point(26, 21);
            rdMomopayment.Margin = new Padding(4);
            rdMomopayment.Name = "rdMomopayment";
            rdMomopayment.Size = new Size(174, 32);
            rdMomopayment.TabIndex = 0;
            rdMomopayment.TabStop = true;
            rdMomopayment.Text = "Momo payment";
            rdMomopayment.UseVisualStyleBackColor = true;
            rdMomopayment.CheckedChanged += rdMomopayment_CheckedChanged;
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoucher.Location = new Point(15, 24);
            lblVoucher.Margin = new Padding(4, 0, 4, 0);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(58, 15);
            lblVoucher.TabIndex = 13;
            lblVoucher.Text = "Vourcher:";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(cbUnitQuantity);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pcPictureOrders);
            panel6.Controls.Add(lblPicture);
            panel6.Controls.Add(btAddOrders);
            panel6.Controls.Add(txtNameOrder);
            panel6.Controls.Add(lblName);
            panel6.Controls.Add(txtQuantityOrder);
            panel6.Controls.Add(txtPriceOrder);
            panel6.Controls.Add(lblPrice);
            panel6.Controls.Add(lblQuantity);
            panel6.Location = new Point(4, 4);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(625, 665);
            panel6.TabIndex = 17;
            // 
            // cbUnitQuantity
            // 
            cbUnitQuantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUnitQuantity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnitQuantity.Location = new Point(187, 118);
            cbUnitQuantity.Margin = new Padding(4);
            cbUnitQuantity.Name = "cbUnitQuantity";
            cbUnitQuantity.Size = new Size(166, 36);
            cbUnitQuantity.TabIndex = 14;
            cbUnitQuantity.SelectedIndexChanged += cbUnitQuantity_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 13;
            label1.Text = "Unit:";
            // 
            // pcPictureOrders
            // 
            pcPictureOrders.BorderStyle = BorderStyle.Fixed3D;
            pcPictureOrders.Location = new Point(114, 231);
            pcPictureOrders.Margin = new Padding(4);
            pcPictureOrders.Name = "pcPictureOrders";
            pcPictureOrders.Size = new Size(301, 283);
            pcPictureOrders.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureOrders.TabIndex = 0;
            pcPictureOrders.TabStop = false;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPicture.Location = new Point(15, 231);
            lblPicture.Margin = new Padding(4, 0, 4, 0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(47, 15);
            lblPicture.TabIndex = 12;
            lblPicture.Text = "Picture:";
            // 
            // btAddOrders
            // 
            btAddOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAddOrders.Image = (Image)resources.GetObject("btAddOrders.Image");
            btAddOrders.Location = new Point(279, 546);
            btAddOrders.Margin = new Padding(4);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(138, 50);
            btAddOrders.TabIndex = 8;
            btAddOrders.UseVisualStyleBackColor = true;
            btAddOrders.Click += btAddOrders_Click;
            // 
            // txtNameOrder
            // 
            txtNameOrder.Location = new Point(131, 13);
            txtNameOrder.Margin = new Padding(4);
            txtNameOrder.Name = "txtNameOrder";
            txtNameOrder.ReadOnly = true;
            txtNameOrder.Size = new Size(284, 34);
            txtNameOrder.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(15, 15);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtQuantityOrder
            // 
            txtQuantityOrder.Location = new Point(187, 64);
            txtQuantityOrder.Margin = new Padding(4);
            txtQuantityOrder.Name = "txtQuantityOrder";
            txtQuantityOrder.Size = new Size(168, 34);
            txtQuantityOrder.TabIndex = 10;
            txtQuantityOrder.TextAlign = HorizontalAlignment.Center;
            txtQuantityOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPriceOrder
            // 
            txtPriceOrder.Location = new Point(131, 169);
            txtPriceOrder.Margin = new Padding(4);
            txtPriceOrder.Name = "txtPriceOrder";
            txtPriceOrder.ReadOnly = true;
            txtPriceOrder.Size = new Size(284, 34);
            txtPriceOrder.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(15, 172);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(15, 70);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(listViewOrders, 0, 0);
            tableLayoutPanel4.Controls.Add(pnlCashPayment, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1286, 4);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(634, 1036);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // listViewOrders
            // 
            listViewOrders.AutoArrange = false;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { clmSKU, clmName, clmQuantity, clmUnit, clmPrice, clmTotal });
            listViewOrders.Dock = DockStyle.Fill;
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(4, 4);
            listViewOrders.Margin = new Padding(4);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.RightToLeft = RightToLeft.No;
            listViewOrders.RightToLeftLayout = true;
            listViewOrders.Size = new Size(626, 613);
            listViewOrders.Sorting = SortOrder.Ascending;
            listViewOrders.TabIndex = 9;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.MouseDoubleClick += listViewOrders_MouseDoubleClick;
            // 
            // clmSKU
            // 
            clmSKU.Text = "SKU";
            clmSKU.Width = 100;
            // 
            // clmName
            // 
            clmName.Text = "Name";
            clmName.Width = 150;
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Quantity";
            clmQuantity.Width = 100;
            // 
            // clmUnit
            // 
            clmUnit.Text = "Unit";
            clmUnit.Width = 100;
            // 
            // clmPrice
            // 
            clmPrice.Text = "Price";
            clmPrice.Width = 100;
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            clmTotal.Width = 100;
            // 
            // pnlCashPayment
            // 
            pnlCashPayment.Controls.Add(tableLayoutPanel5);
            pnlCashPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Location = new Point(4, 625);
            pnlCashPayment.Margin = new Padding(4);
            pnlCashPayment.Name = "pnlCashPayment";
            pnlCashPayment.Size = new Size(626, 407);
            pnlCashPayment.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel4, 0, 1);
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel5.Size = new Size(626, 407);
            tableLayoutPanel5.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.Controls.Add(btReturnMoney);
            panel4.Controls.Add(txtProvidesCash);
            panel4.Controls.Add(txtReturnPayment);
            panel4.Controls.Add(btShowBill);
            panel4.Controls.Add(lblCustomerProvidesCash);
            panel4.Controls.Add(lblReturnChange);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 187);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(618, 216);
            panel4.TabIndex = 15;
            // 
            // btReturnMoney
            // 
            btReturnMoney.Location = new Point(447, 55);
            btReturnMoney.Margin = new Padding(4);
            btReturnMoney.Name = "btReturnMoney";
            btReturnMoney.Size = new Size(136, 41);
            btReturnMoney.TabIndex = 29;
            btReturnMoney.Text = "Payment";
            btReturnMoney.UseVisualStyleBackColor = true;
            btReturnMoney.Click += btReturnMoney_Click;
            // 
            // txtProvidesCash
            // 
            txtProvidesCash.Location = new Point(183, 16);
            txtProvidesCash.Margin = new Padding(4);
            txtProvidesCash.Name = "txtProvidesCash";
            txtProvidesCash.Size = new Size(256, 34);
            txtProvidesCash.TabIndex = 25;
            // 
            // txtReturnPayment
            // 
            txtReturnPayment.Location = new Point(183, 58);
            txtReturnPayment.Margin = new Padding(4);
            txtReturnPayment.Name = "txtReturnPayment";
            txtReturnPayment.ReadOnly = true;
            txtReturnPayment.Size = new Size(256, 34);
            txtReturnPayment.TabIndex = 26;
            // 
            // btShowBill
            // 
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(15, 93);
            btShowBill.Margin = new Padding(4);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(136, 98);
            btShowBill.TabIndex = 11;
            btShowBill.Text = "Bill";
            btShowBill.TextAlign = ContentAlignment.BottomCenter;
            btShowBill.UseVisualStyleBackColor = true;
            btShowBill.Visible = false;

            // 
            // lblCustomerProvidesCash
            // 
            lblCustomerProvidesCash.AutoSize = true;
            lblCustomerProvidesCash.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerProvidesCash.Location = new Point(15, 16);
            lblCustomerProvidesCash.Margin = new Padding(4, 0, 4, 0);
            lblCustomerProvidesCash.Name = "lblCustomerProvidesCash";
            lblCustomerProvidesCash.Size = new Size(106, 20);
            lblCustomerProvidesCash.TabIndex = 23;
            lblCustomerProvidesCash.Text = "Provides cash:";
            // 
            // lblReturnChange
            // 
            lblReturnChange.AutoSize = true;
            lblReturnChange.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturnChange.Location = new Point(15, 56);
            lblReturnChange.Margin = new Padding(4, 0, 4, 0);
            lblReturnChange.Name = "lblReturnChange";
            lblReturnChange.Size = new Size(123, 20);
            lblReturnChange.TabIndex = 24;
            lblReturnChange.Text = "Return Payment:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btCancelBill);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(txtTotalAllOrders);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 175);
            panel3.TabIndex = 30;
            // 
            // btCancelBill
            // 
            btCancelBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelBill.Image = (Image)resources.GetObject("btCancelBill.Image");
            btCancelBill.ImageAlign = ContentAlignment.TopCenter;
            btCancelBill.Location = new Point(457, 48);
            btCancelBill.Margin = new Padding(4);
            btCancelBill.Name = "btCancelBill";
            btCancelBill.Size = new Size(136, 98);
            btCancelBill.TabIndex = 23;
            btCancelBill.Text = "Cancel";
            btCancelBill.TextAlign = ContentAlignment.BottomCenter;
            btCancelBill.UseVisualStyleBackColor = true;
            btCancelBill.Click += btCancelBill_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(183, 104);
            txtDiscount.Margin = new Padding(4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(256, 34);
            txtDiscount.TabIndex = 28;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(63, 53);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total :";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(183, 49);
            txtTotalAllOrders.Margin = new Padding(4);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(256, 34);
            txtTotalAllOrders.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 27;
            label4.Text = "Discount:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btUsingVoucher);
            panel3.Location = new Point(267, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 27);
            panel3.TabIndex = 22;
            // 
            // OrderProducts
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1044);
            Controls.Add(pnlAll);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OrderProducts";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "OrderProducts";
            Load += OrderProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            pnlAll.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            pnlCashPayment.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvShowListProducts;
        private Panel pnlAll;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblName;
        private Button btAddOrders;
        private TextBox txtNameOrder;
        private NumericUpDown txtQuantityOrder;
        private TextBox txtPriceOrder;
        private Panel panel6;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private Label lblPicture;
        private PictureBox pcPictureOrders;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mfgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDataGridViewTextBoxColumn;
        private ComboBox cbTypeProducts;
        private Label lblType;
        private TextBox txtSearchName;
        private Button btSearch;
        private Panel panel1;
        private Panel panel5;
        private TextBox txtScanVoucher;
        private Button btUsingVoucher;
        private Button btCheckMember;
        private Label lblTotal;
        private Label lblVoucher;
        private TextBox txtTotalAllOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private RadioButton rdCashpayment;
        private RadioButton rdMomopayment;
        private TableLayoutPanel tableLayoutPanel4;
        private ListView listViewOrders;
        private ColumnHeader clmSKU;
        private ColumnHeader clmName;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmPrice;
        private ColumnHeader clmTotal;
        private Panel pnlCashPayment;
        private Button btShowBill;
        private ComboBox cbUnitQuantity;
        private Label label1;
        private ColumnHeader clmUnit;
        private Button btCancelBill;
        private TextBox txtReturnPayment;
        private TextBox txtProvidesCash;
        private Label lblReturnChange;
        private Label lblCustomerProvidesCash;
        private TextBox txtLoyaltyPoint;
        private Label lb;
        private TextBox txtPointUsing;
        private Label label3;
        private Button btUsingPoint;
        private TextBox txtDiscount;
        private Label label4;
        private Button btReturnMoney;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel4;
        private Panel panel3;
    }
}