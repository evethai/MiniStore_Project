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
            panel2 = new Panel();
            rdCashpayment = new RadioButton();
            rdMomopayment = new RadioButton();
            txtScanVoucher = new TextBox();
            btUsingVoucher = new Button();
            btCheckMember = new Button();
            lblPoint = new Label();
            cbPointUsing = new ComboBox();
            lblTotal = new Label();
            lblVoucher = new Label();
            txtTotalAllOrders = new TextBox();
            panel6 = new Panel();
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
            clmPrice = new ColumnHeader();
            clmTotal = new ColumnHeader();
            pnlCashPayment = new Panel();
            txtReturnPayment = new TextBox();
            txtProvidesCash = new TextBox();
            txtTotalBillPayment = new TextBox();
            lblReturnChange = new Label();
            btShowBill = new Button();
            lblCustomerProvidesCash = new Label();
            lblTotalBillAmount = new Label();
            panel3 = new Panel();
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
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowListProducts
            // 
            dgvShowListProducts.AutoGenerateColumns = false;
            dgvShowListProducts.BackgroundColor = SystemColors.Control;
            dgvShowListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowListProducts.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, mfgDataGridViewTextBoxColumn, expDataGridViewTextBoxColumn });
            dgvShowListProducts.DataSource = productBindingSource;
            dgvShowListProducts.Dock = DockStyle.Fill;
            dgvShowListProducts.Location = new Point(3, 79);
            dgvShowListProducts.Name = "dgvShowListProducts";
            dgvShowListProducts.RowHeadersWidth = 51;
            dgvShowListProducts.RowTemplate.Height = 29;
            dgvShowListProducts.Size = new Size(465, 427);
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
            // pnlAll
            // 
            pnlAll.Controls.Add(tableLayoutPanel1);
            pnlAll.Dock = DockStyle.Fill;
            pnlAll.Location = new Point(0, 0);
            pnlAll.Name = "pnlAll";
            pnlAll.Size = new Size(1194, 515);
            pnlAll.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1194, 515);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvShowListProducts, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(471, 509);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(cbTypeProducts);
            panel1.Controls.Add(txtSearchName);
            panel1.Controls.Add(lblType);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 70);
            panel1.TabIndex = 19;
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(270, 9);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(81, 36);
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
            cbTypeProducts.Location = new Point(147, 44);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(107, 25);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(84, 16);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(182, 25);
            txtSearchName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(91, 47);
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
            tableLayoutPanel3.Location = new Point(480, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(352, 509);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(txtScanVoucher);
            panel5.Controls.Add(btCheckMember);
            panel5.Controls.Add(lblPoint);
            panel5.Controls.Add(cbPointUsing);
            panel5.Controls.Add(lblTotal);
            panel5.Controls.Add(lblVoucher);
            panel5.Controls.Add(txtTotalAllOrders);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 308);
            panel5.Name = "panel5";
            panel5.Size = new Size(346, 198);
            panel5.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdCashpayment);
            panel2.Controls.Add(rdMomopayment);
            panel2.Location = new Point(109, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 67);
            panel2.TabIndex = 21;
            // 
            // rdCashpayment
            // 
            rdCashpayment.AutoSize = true;
            rdCashpayment.Location = new Point(12, 37);
            rdCashpayment.Name = "rdCashpayment";
            rdCashpayment.Size = new Size(108, 21);
            rdCashpayment.TabIndex = 1;
            rdCashpayment.TabStop = true;
            rdCashpayment.Text = "Cash payment";
            rdCashpayment.UseVisualStyleBackColor = true;
            rdCashpayment.CheckedChanged += rdCashpayment_CheckedChanged;
            // 
            // rdMomopayment
            // 
            rdMomopayment.AutoSize = true;
            rdMomopayment.Location = new Point(12, 12);
            rdMomopayment.Name = "rdMomopayment";
            rdMomopayment.Size = new Size(119, 21);
            rdMomopayment.TabIndex = 0;
            rdMomopayment.TabStop = true;
            rdMomopayment.Text = "Momo payment";
            rdMomopayment.UseVisualStyleBackColor = true;
            rdMomopayment.CheckedChanged += rdMomopayment_CheckedChanged;
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(88, 14);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(164, 25);
            txtScanVoucher.TabIndex = 20;
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Dock = DockStyle.Fill;
            btUsingVoucher.Location = new Point(0, 0);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(76, 27);
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
            btCheckMember.Location = new Point(18, 121);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(87, 60);
            btCheckMember.TabIndex = 6;
            btCheckMember.Text = "Member";
            btCheckMember.TextAlign = ContentAlignment.BottomCenter;
            btCheckMember.UseVisualStyleBackColor = true;
            btCheckMember.Click += btCheckMember_Click;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.Location = new Point(18, 42);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(41, 15);
            lblPoint.TabIndex = 18;
            lblPoint.Text = "Point :";
            // 
            // cbPointUsing
            // 
            cbPointUsing.Enabled = false;
            cbPointUsing.FormattingEnabled = true;
            cbPointUsing.Location = new Point(88, 42);
            cbPointUsing.Name = "cbPointUsing";
            cbPointUsing.Size = new Size(164, 25);
            cbPointUsing.TabIndex = 17;
            cbPointUsing.SelectedIndexChanged += cbPointUsing_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(19, 74);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total :";
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoucher.Location = new Point(10, 14);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(58, 15);
            lblVoucher.TabIndex = 13;
            lblVoucher.Text = "Vourcher:";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(88, 71);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(164, 25);
            txtTotalAllOrders.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(pcPictureOrders);
            panel6.Controls.Add(lblPicture);
            panel6.Controls.Add(btAddOrders);
            panel6.Controls.Add(txtNameOrder);
            panel6.Controls.Add(lblName);
            panel6.Controls.Add(txtQuantityOrder);
            panel6.Controls.Add(txtPriceOrder);
            panel6.Controls.Add(lblPrice);
            panel6.Controls.Add(lblQuantity);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(346, 299);
            panel6.TabIndex = 17;
            // 
            // pcPictureOrders
            // 
            pcPictureOrders.BorderStyle = BorderStyle.Fixed3D;
            pcPictureOrders.Location = new Point(73, 113);
            pcPictureOrders.Name = "pcPictureOrders";
            pcPictureOrders.Size = new Size(182, 150);
            pcPictureOrders.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureOrders.TabIndex = 0;
            pcPictureOrders.TabStop = false;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPicture.Location = new Point(10, 113);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(47, 15);
            lblPicture.TabIndex = 12;
            lblPicture.Text = "Picture:";
            // 
            // btAddOrders
            // 
            btAddOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAddOrders.Image = (Image)resources.GetObject("btAddOrders.Image");
            btAddOrders.Location = new Point(164, 268);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(88, 31);
            btAddOrders.TabIndex = 8;
            btAddOrders.UseVisualStyleBackColor = true;
            btAddOrders.Click += btAddOrders_Click;
            // 
            // txtNameOrder
            // 
            txtNameOrder.Location = new Point(73, 8);
            txtNameOrder.Name = "txtNameOrder";
            txtNameOrder.ReadOnly = true;
            txtNameOrder.Size = new Size(182, 25);
            txtNameOrder.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(10, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtQuantityOrder
            // 
            txtQuantityOrder.Location = new Point(73, 41);
            txtQuantityOrder.Name = "txtQuantityOrder";
            txtQuantityOrder.Size = new Size(181, 25);
            txtQuantityOrder.TabIndex = 10;
            txtQuantityOrder.TextAlign = HorizontalAlignment.Center;
            txtQuantityOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPriceOrder
            // 
            txtPriceOrder.Location = new Point(73, 76);
            txtPriceOrder.Name = "txtPriceOrder";
            txtPriceOrder.ReadOnly = true;
            txtPriceOrder.Size = new Size(182, 25);
            txtPriceOrder.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(10, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(10, 42);
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
            tableLayoutPanel4.Location = new Point(838, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(353, 509);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // listViewOrders
            // 
            listViewOrders.AutoArrange = false;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { clmSKU, clmName, clmQuantity, clmPrice, clmTotal });
            listViewOrders.Dock = DockStyle.Fill;
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(3, 3);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.RightToLeft = RightToLeft.No;
            listViewOrders.RightToLeftLayout = true;
            listViewOrders.Size = new Size(347, 299);
            listViewOrders.Sorting = SortOrder.Ascending;
            listViewOrders.TabIndex = 9;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.MouseDoubleClick += listViewOrders_MouseDoubleClick;
            // 
            // clmSKU
            // 
            clmSKU.Text = "SKU";
            clmSKU.Width = 150;
            // 
            // clmName
            // 
            clmName.Text = "Name";
            clmName.TextAlign = HorizontalAlignment.Center;
            clmName.Width = 150;
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Quantity";
            clmQuantity.Width = 100;
            // 
            // clmPrice
            // 
            clmPrice.Text = "Price";
            clmPrice.Width = 150;
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            clmTotal.Width = 150;
            // 
            // pnlCashPayment
            // 
            pnlCashPayment.Controls.Add(txtReturnPayment);
            pnlCashPayment.Controls.Add(txtProvidesCash);
            pnlCashPayment.Controls.Add(txtTotalBillPayment);
            pnlCashPayment.Controls.Add(lblReturnChange);
            pnlCashPayment.Controls.Add(btShowBill);
            pnlCashPayment.Controls.Add(lblCustomerProvidesCash);
            pnlCashPayment.Controls.Add(lblTotalBillAmount);
            pnlCashPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Location = new Point(3, 308);
            pnlCashPayment.Name = "pnlCashPayment";
            pnlCashPayment.Size = new Size(347, 198);
            pnlCashPayment.TabIndex = 10;
            // 
            // txtReturnPayment
            // 
            txtReturnPayment.Location = new Point(138, 100);
            txtReturnPayment.Name = "txtReturnPayment";
            txtReturnPayment.ReadOnly = true;
            txtReturnPayment.Size = new Size(164, 25);
            txtReturnPayment.TabIndex = 22;
            // 
            // txtProvidesCash
            // 
            txtProvidesCash.Location = new Point(138, 56);
            txtProvidesCash.Name = "txtProvidesCash";
            txtProvidesCash.ReadOnly = true;
            txtProvidesCash.Size = new Size(164, 25);
            txtProvidesCash.TabIndex = 21;
            // 
            // txtTotalBillPayment
            // 
            txtTotalBillPayment.Location = new Point(138, 12);
            txtTotalBillPayment.Name = "txtTotalBillPayment";
            txtTotalBillPayment.ReadOnly = true;
            txtTotalBillPayment.Size = new Size(164, 25);
            txtTotalBillPayment.TabIndex = 18;
            // 
            // lblReturnChange
            // 
            lblReturnChange.AutoSize = true;
            lblReturnChange.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturnChange.Location = new Point(21, 103);
            lblReturnChange.Name = "lblReturnChange";
            lblReturnChange.Size = new Size(95, 15);
            lblReturnChange.TabIndex = 17;
            lblReturnChange.Text = "Return Payment:";
            // 
            // btShowBill
            // 
            btShowBill.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(214, 127);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(87, 60);
            btShowBill.TabIndex = 11;
            btShowBill.Text = "Bill";
            btShowBill.TextAlign = ContentAlignment.BottomCenter;
            btShowBill.UseVisualStyleBackColor = true;
            btShowBill.Visible = false;
            btShowBill.Click += btShowBill_Click;
            // 
            // lblCustomerProvidesCash
            // 
            lblCustomerProvidesCash.AutoSize = true;
            lblCustomerProvidesCash.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerProvidesCash.Location = new Point(21, 59);
            lblCustomerProvidesCash.Name = "lblCustomerProvidesCash";
            lblCustomerProvidesCash.Size = new Size(82, 15);
            lblCustomerProvidesCash.TabIndex = 16;
            lblCustomerProvidesCash.Text = "Provides cash:";
            // 
            // lblTotalBillAmount
            // 
            lblTotalBillAmount.AutoSize = true;
            lblTotalBillAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBillAmount.Location = new Point(21, 14);
            lblTotalBillAmount.Name = "lblTotalBillAmount";
            lblTotalBillAmount.Size = new Size(100, 15);
            lblTotalBillAmount.TabIndex = 14;
            lblTotalBillAmount.Text = "Total bill amount:";
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
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 515);
            Controls.Add(pnlAll);
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
            pnlCashPayment.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Label lblPoint;
        private ComboBox cbPointUsing;
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
        private TextBox txtReturnPayment;
        private TextBox txtProvidesCash;
        private TextBox txtTotalBillPayment;
        private Label lblReturnChange;
        private Button btShowBill;
        private Label lblCustomerProvidesCash;
        private Label lblTotalBillAmount;
        private Panel panel3;
    }
}