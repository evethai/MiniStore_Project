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
            txtScanVoucher = new TextBox();
            btUsingVoucher = new Button();
            btCheckMember = new Button();
            lblPoint = new Label();
            btShowBill = new Button();
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
            listViewOrders = new ListView();
            clmSKU = new ColumnHeader();
            clmName = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmTotal = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)dgvShowListProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            pnlAll.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvShowListProducts
            // 
            dgvShowListProducts.AutoGenerateColumns = false;
            dgvShowListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowListProducts.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, mfgDataGridViewTextBoxColumn, expDataGridViewTextBoxColumn });
            dgvShowListProducts.DataSource = productBindingSource;
            dgvShowListProducts.Dock = DockStyle.Fill;
            dgvShowListProducts.Location = new Point(3, 94);
            dgvShowListProducts.Name = "dgvShowListProducts";
            dgvShowListProducts.RowHeadersWidth = 51;
            dgvShowListProducts.RowTemplate.Height = 29;
            dgvShowListProducts.Size = new Size(635, 514);
            dgvShowListProducts.TabIndex = 2;
            dgvShowListProducts.CellContentClick += dgvShowListProducts_CellDoubleClick;
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
            pnlAll.Size = new Size(1619, 617);
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
            tableLayoutPanel1.Controls.Add(listViewOrders, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1619, 617);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvShowListProducts, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(641, 611);
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
            panel1.Size = new Size(635, 85);
            panel1.TabIndex = 19;
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(264, 12);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 42);
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
            cbTypeProducts.Location = new Point(457, 17);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(137, 28);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(26, 19);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(232, 27);
            txtSearchName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(387, 20);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 20);
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
            tableLayoutPanel3.Location = new Point(650, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(479, 611);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtScanVoucher);
            panel5.Controls.Add(btUsingVoucher);
            panel5.Controls.Add(btCheckMember);
            panel5.Controls.Add(lblPoint);
            panel5.Controls.Add(btShowBill);
            panel5.Controls.Add(cbPointUsing);
            panel5.Controls.Add(lblTotal);
            panel5.Controls.Add(lblVoucher);
            panel5.Controls.Add(txtTotalAllOrders);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 369);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 239);
            panel5.TabIndex = 16;
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(113, 18);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(187, 27);
            txtScanVoucher.TabIndex = 20;
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Location = new Point(329, 18);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(99, 37);
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
            btCheckMember.Location = new Point(330, 61);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(98, 69);
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
            lblPoint.Location = new Point(12, 82);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(52, 20);
            lblPoint.TabIndex = 18;
            lblPoint.Text = "Point :";
            // 
            // btShowBill
            // 
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(330, 143);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(98, 69);
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
            cbPointUsing.Location = new Point(113, 82);
            cbPointUsing.Name = "cbPointUsing";
            cbPointUsing.Size = new Size(187, 28);
            cbPointUsing.TabIndex = 17;
            cbPointUsing.SelectedIndexChanged += cbPointUsing_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(12, 146);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total :";
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoucher.Location = new Point(12, 18);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(77, 20);
            lblVoucher.TabIndex = 13;
            lblVoucher.Text = "Vourcher:";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(113, 143);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(187, 27);
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
            panel6.Size = new Size(473, 360);
            panel6.TabIndex = 17;
            // 
            // pcPictureOrders
            // 
            pcPictureOrders.BorderStyle = BorderStyle.Fixed3D;
            pcPictureOrders.Location = new Point(93, 140);
            pcPictureOrders.Name = "pcPictureOrders";
            pcPictureOrders.Size = new Size(207, 176);
            pcPictureOrders.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureOrders.TabIndex = 0;
            pcPictureOrders.TabStop = false;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPicture.Location = new Point(12, 140);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(61, 20);
            lblPicture.TabIndex = 12;
            lblPicture.Text = "Picture:";
            // 
            // btAddOrders
            // 
            btAddOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAddOrders.Image = (Image)resources.GetObject("btAddOrders.Image");
            btAddOrders.Location = new Point(329, 281);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(99, 37);
            btAddOrders.TabIndex = 8;
            btAddOrders.UseVisualStyleBackColor = true;
            btAddOrders.Click += btAddOrders_Click;
            // 
            // txtNameOrder
            // 
            txtNameOrder.Location = new Point(93, 9);
            txtNameOrder.Name = "txtNameOrder";
            txtNameOrder.ReadOnly = true;
            txtNameOrder.Size = new Size(207, 27);
            txtNameOrder.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtQuantityOrder
            // 
            txtQuantityOrder.Location = new Point(93, 50);
            txtQuantityOrder.Name = "txtQuantityOrder";
            txtQuantityOrder.Size = new Size(207, 27);
            txtQuantityOrder.TabIndex = 10;
            txtQuantityOrder.TextAlign = HorizontalAlignment.Center;
            txtQuantityOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPriceOrder
            // 
            txtPriceOrder.Location = new Point(93, 93);
            txtPriceOrder.Name = "txtPriceOrder";
            txtPriceOrder.ReadOnly = true;
            txtPriceOrder.Size = new Size(207, 27);
            txtPriceOrder.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(12, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(12, 52);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // listViewOrders
            // 
            listViewOrders.AutoArrange = false;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { clmSKU, clmName, clmQuantity, clmPrice, clmTotal });
            listViewOrders.Dock = DockStyle.Fill;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(1135, 3);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(481, 611);
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
            clmName.Width = 100;
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Quantity";
            clmQuantity.Width = 100;
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
            // OrderProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 617);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantityOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvShowListProducts;
        private Panel pnlAll;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblName;
        private Button btAddOrders;
        private ListView listViewOrders;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmPrice;
        private ColumnHeader clmName;
        private ColumnHeader clmTotal;
        private TextBox txtNameOrder;
        private NumericUpDown txtQuantityOrder;
        private TextBox txtPriceOrder;
        private Panel panel6;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private Label lblPicture;
        private PictureBox pcPictureOrders;
        private ColumnHeader clmSKU;
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
        private Button btShowBill;
        private ComboBox cbPointUsing;
        private Label lblTotal;
        private Label lblVoucher;
        private TextBox txtTotalAllOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}