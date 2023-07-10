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
            cbSort = new ComboBox();
            label2 = new Label();
            btSearch = new Button();
            cbTypeProducts = new ComboBox();
            txtSearchName = new TextBox();
            lblType = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel9 = new Panel();
            txtPointUsing = new TextBox();
            label3 = new Label();
            panel8 = new Panel();
            txtLoyaltyPoint = new TextBox();
            lb = new Label();
            panel7 = new Panel();
            txtScanVoucher = new TextBox();
            lblVoucher = new Label();
            btUsingPoint = new Button();
            btCheckMember = new Button();
            panel2 = new Panel();
            rdCashpayment = new RadioButton();
            rdMomopayment = new RadioButton();
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
            btUsingVoucher = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel10 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel12 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            pnlAll.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            pnlCashPayment.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel12.SuspendLayout();
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
            panel1.Controls.Add(cbSort);
            panel1.Controls.Add(label2);
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
            // cbSort
            // 
            cbSort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSort.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbSort.Location = new Point(317, 84);
            cbSort.Margin = new Padding(4);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(202, 29);
            cbSort.TabIndex = 13;
            cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(234, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Sort  EXP:";
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(437, 15);
            btSearch.Margin = new Padding(4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(82, 48);
            btSearch.TabIndex = 4;
            btSearch.TextAlign = ContentAlignment.MiddleRight;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // cbTypeProducts
            // 
            cbTypeProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTypeProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbTypeProducts.Location = new Point(81, 84);
            cbTypeProducts.Margin = new Padding(4);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(135, 29);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(146, 19);
            txtSearchName.Margin = new Padding(4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(283, 29);
            txtSearchName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(24, 94);
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
            panel5.Controls.Add(tableLayoutPanel6);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 677);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(625, 355);
            panel5.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(panel9, 0, 2);
            tableLayoutPanel6.Controls.Add(panel8, 0, 1);
            tableLayoutPanel6.Controls.Add(panel7, 0, 0);
            tableLayoutPanel6.Controls.Add(btUsingPoint, 1, 2);
            tableLayoutPanel6.Controls.Add(btCheckMember, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(625, 272);
            tableLayoutPanel6.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPointUsing);
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 183);
            panel9.Name = "panel9";
            panel9.Size = new Size(431, 86);
            panel9.TabIndex = 29;
            // 
            // txtPointUsing
            // 
            txtPointUsing.Enabled = false;
            txtPointUsing.Location = new Point(141, 32);
            txtPointUsing.Margin = new Padding(4);
            txtPointUsing.Name = "txtPointUsing";
            txtPointUsing.Size = new Size(206, 29);
            txtPointUsing.TabIndex = 27;
            txtPointUsing.KeyPress += txtPointUsing_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 46);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 26;
            label3.Text = "Point Using:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtLoyaltyPoint);
            panel8.Controls.Add(lb);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 93);
            panel8.Name = "panel8";
            panel8.Size = new Size(431, 84);
            panel8.TabIndex = 29;
            // 
            // txtLoyaltyPoint
            // 
            txtLoyaltyPoint.Location = new Point(141, 31);
            txtLoyaltyPoint.Margin = new Padding(4);
            txtLoyaltyPoint.Name = "txtLoyaltyPoint";
            txtLoyaltyPoint.ReadOnly = true;
            txtLoyaltyPoint.Size = new Size(206, 29);
            txtLoyaltyPoint.TabIndex = 23;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb.Location = new Point(28, 45);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(84, 15);
            lb.TabIndex = 22;
            lb.Text = "Loyalty points:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtScanVoucher);
            panel7.Controls.Add(lblVoucher);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(431, 84);
            panel7.TabIndex = 29;
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(141, 33);
            txtScanVoucher.Margin = new Padding(4);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(206, 29);
            txtScanVoucher.TabIndex = 20;
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoucher.Location = new Point(28, 47);
            lblVoucher.Margin = new Padding(4, 0, 4, 0);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(58, 15);
            lblVoucher.TabIndex = 13;
            lblVoucher.Text = "Vourcher:";
            // 
            // btUsingPoint
            // 
            btUsingPoint.Anchor = AnchorStyles.Right;
            btUsingPoint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUsingPoint.Image = (Image)resources.GetObject("btUsingPoint.Image");
            btUsingPoint.ImageAlign = ContentAlignment.TopCenter;
            btUsingPoint.Location = new Point(507, 192);
            btUsingPoint.Margin = new Padding(4);
            btUsingPoint.Name = "btUsingPoint";
            btUsingPoint.Size = new Size(114, 67);
            btUsingPoint.TabIndex = 28;
            btUsingPoint.Text = "Use point";
            btUsingPoint.TextAlign = ContentAlignment.BottomCenter;
            btUsingPoint.UseVisualStyleBackColor = true;
            btUsingPoint.Click += btUsingPoint_Click;
            // 
            // btCheckMember
            // 
            btCheckMember.Anchor = AnchorStyles.Right;
            btCheckMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCheckMember.Image = (Image)resources.GetObject("btCheckMember.Image");
            btCheckMember.ImageAlign = ContentAlignment.TopCenter;
            btCheckMember.Location = new Point(507, 101);
            btCheckMember.Margin = new Padding(4);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(114, 67);
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
            rdCashpayment.Size = new Size(127, 25);
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
            rdMomopayment.Size = new Size(139, 25);
            rdMomopayment.TabIndex = 0;
            rdMomopayment.TabStop = true;
            rdMomopayment.Text = "Momo payment";
            rdMomopayment.UseVisualStyleBackColor = true;
            rdMomopayment.CheckedChanged += rdMomopayment_CheckedChanged;
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
            cbUnitQuantity.Size = new Size(166, 29);
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
            label1.Size = new Size(32, 15);
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
            btAddOrders.Location = new Point(423, 450);
            btAddOrders.Margin = new Padding(4);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(114, 64);
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
            txtNameOrder.Size = new Size(284, 29);
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
            txtQuantityOrder.Size = new Size(168, 29);
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
            txtPriceOrder.Size = new Size(284, 29);
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
            panel4.Controls.Add(tableLayoutPanel8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 187);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(618, 216);
            panel4.TabIndex = 15;
            // 
            // btReturnMoney
            // 
            btReturnMoney.Anchor = AnchorStyles.Right;
            btReturnMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btReturnMoney.Image = (Image)resources.GetObject("btReturnMoney.Image");
            btReturnMoney.ImageAlign = ContentAlignment.TopCenter;
            btReturnMoney.Location = new Point(491, 20);
            btReturnMoney.Margin = new Padding(4);
            btReturnMoney.Name = "btReturnMoney";
            btReturnMoney.Size = new Size(123, 67);
            btReturnMoney.TabIndex = 29;
            btReturnMoney.Text = "Return change";
            btReturnMoney.TextAlign = ContentAlignment.BottomCenter;
            btReturnMoney.UseVisualStyleBackColor = true;
            btReturnMoney.Click += btReturnMoney_Click;
            // 
            // txtProvidesCash
            // 
            txtProvidesCash.Location = new Point(150, 26);
            txtProvidesCash.Margin = new Padding(4);
            txtProvidesCash.Name = "txtProvidesCash";
            txtProvidesCash.Size = new Size(238, 29);
            txtProvidesCash.TabIndex = 25;
            // 
            // txtReturnPayment
            // 
            txtReturnPayment.Location = new Point(150, 67);
            txtReturnPayment.Margin = new Padding(4);
            txtReturnPayment.Name = "txtReturnPayment";
            txtReturnPayment.ReadOnly = true;
            txtReturnPayment.Size = new Size(238, 29);
            txtReturnPayment.TabIndex = 26;
            // 
            // btShowBill
            // 
            btShowBill.Anchor = AnchorStyles.Right;
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(491, 128);
            btShowBill.Margin = new Padding(4);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(123, 67);
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
            lblCustomerProvidesCash.Location = new Point(25, 40);
            lblCustomerProvidesCash.Margin = new Padding(4, 0, 4, 0);
            lblCustomerProvidesCash.Name = "lblCustomerProvidesCash";
            lblCustomerProvidesCash.Size = new Size(82, 15);
            lblCustomerProvidesCash.TabIndex = 23;
            lblCustomerProvidesCash.Text = "Provides cash:";
            // 
            // lblReturnChange
            // 
            lblReturnChange.AutoSize = true;
            lblReturnChange.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturnChange.Location = new Point(12, 81);
            lblReturnChange.Margin = new Padding(4, 0, 4, 0);
            lblReturnChange.Name = "lblReturnChange";
            lblReturnChange.Size = new Size(95, 15);
            lblReturnChange.TabIndex = 24;
            lblReturnChange.Text = "Return Payment:";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 175);
            panel3.TabIndex = 22;
            // 
            // btCancelBill
            // 
            btCancelBill.Anchor = AnchorStyles.Right;
            btCancelBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelBill.Image = (Image)resources.GetObject("btCancelBill.Image");
            btCancelBill.ImageAlign = ContentAlignment.TopCenter;
            btCancelBill.Location = new Point(491, 97);
            btCancelBill.Margin = new Padding(4);
            btCancelBill.Name = "btCancelBill";
            btCancelBill.Size = new Size(123, 67);
            btCancelBill.TabIndex = 23;
            btCancelBill.Text = "Cancel";
            btCancelBill.TextAlign = ContentAlignment.BottomCenter;
            btCancelBill.UseVisualStyleBackColor = true;
            btCancelBill.Click += btCancelBill_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(150, 22);
            txtDiscount.Margin = new Padding(4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(238, 29);
            txtDiscount.TabIndex = 28;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(68, 41);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total :";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(150, 27);
            txtTotalAllOrders.Margin = new Padding(4);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(238, 29);
            txtTotalAllOrders.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 27;
            label4.Text = "Discount:";
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Anchor = AnchorStyles.Right;
            btUsingVoucher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUsingVoucher.Image = (Image)resources.GetObject("btUsingVoucher.Image");
            btUsingVoucher.ImageAlign = ContentAlignment.TopCenter;
            btUsingVoucher.Location = new Point(491, 10);
            btUsingVoucher.Margin = new Padding(4);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(123, 67);
            btUsingVoucher.TabIndex = 19;
            btUsingVoucher.Text = "Use voucher";
            btUsingVoucher.TextAlign = ContentAlignment.BottomCenter;
            btUsingVoucher.UseVisualStyleBackColor = true;
            btUsingVoucher.Click += btUsingVoucher_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(btCancelBill, 1, 1);
            tableLayoutPanel7.Controls.Add(panel11, 0, 1);
            tableLayoutPanel7.Controls.Add(btUsingVoucher, 1, 0);
            tableLayoutPanel7.Controls.Add(panel10, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(618, 175);
            tableLayoutPanel7.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtTotalAllOrders);
            panel10.Controls.Add(lblTotal);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(426, 81);
            panel10.TabIndex = 29;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtDiscount);
            panel11.Controls.Add(label4);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 90);
            panel11.Name = "panel11";
            panel11.Size = new Size(426, 82);
            panel11.TabIndex = 30;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.Controls.Add(panel12, 0, 0);
            tableLayoutPanel8.Controls.Add(btShowBill, 1, 1);
            tableLayoutPanel8.Controls.Add(btReturnMoney, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(618, 216);
            tableLayoutPanel8.TabIndex = 15;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtReturnPayment);
            panel12.Controls.Add(txtProvidesCash);
            panel12.Controls.Add(lblReturnChange);
            panel12.Controls.Add(lblCustomerProvidesCash);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(426, 102);
            panel12.TabIndex = 30;
            // 
            // OrderProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1044);
            Controls.Add(pnlAll);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OrderProducts";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Order Products";
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
            tableLayoutPanel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
            panel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private ComboBox cbSort;
        private Label label2;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel8;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel11;
        private Panel panel10;
        private Panel panel12;
    }
}