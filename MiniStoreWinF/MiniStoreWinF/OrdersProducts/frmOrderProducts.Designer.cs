﻿namespace MiniStoreWinF.OrdersProducts
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
            dgvShowListProducts.Location = new Point(7, 85);
            dgvShowListProducts.Name = "dgvShowListProducts";
            dgvShowListProducts.RowHeadersWidth = 51;
            dgvShowListProducts.RowTemplate.Height = 29;
            dgvShowListProducts.Size = new Size(655, 513);
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
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 82);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 8;
            label3.Text = "Name :";
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(229, 22);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 42);
            btSearch.TabIndex = 4;
            btSearch.Text = "Search";
            btSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(76, 30);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(137, 27);
            txtSearchName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Type :";
            // 
            // cbTypeProducts
            // 
            cbTypeProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTypeProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbTypeProducts.Location = new Point(70, 29);
            cbTypeProducts.Name = "cbTypeProducts";
            cbTypeProducts.Size = new Size(171, 28);
            cbTypeProducts.TabIndex = 11;
            cbTypeProducts.SelectedIndexChanged += cbTypeProducts_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvShowListProducts);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 604);
            panel2.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(cbTypeProducts);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(346, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(316, 82);
            panel8.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(listViewOrders);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1110, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 589);
            panel1.TabIndex = 1;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { clmSKU, clmName, clmQuantity, clmPrice, clmTotal });
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(3, 3);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(499, 593);
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
            panel5.Controls.Add(txtScanVoucher);
            panel5.Controls.Add(btUsingVoucher);
            panel5.Controls.Add(btCheckMember);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(btShowBill);
            panel5.Controls.Add(cbPointUsing);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtTotalAllOrders);
            panel5.Location = new Point(664, 368);
            panel5.Name = "panel5";
            panel5.Size = new Size(445, 261);
            panel5.TabIndex = 16;
            // 
            // txtScanVoucher
            // 
            txtScanVoucher.Location = new Point(93, 18);
            txtScanVoucher.Name = "txtScanVoucher";
            txtScanVoucher.Size = new Size(187, 27);
            txtScanVoucher.TabIndex = 20;
            // 
            // btUsingVoucher
            // 
            btUsingVoucher.Location = new Point(285, 15);
            btUsingVoucher.Name = "btUsingVoucher";
            btUsingVoucher.Size = new Size(94, 29);
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
            btCheckMember.Location = new Point(152, 164);
            btCheckMember.Name = "btCheckMember";
            btCheckMember.Size = new Size(98, 69);
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
            label8.Location = new Point(35, 70);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 18;
            label8.Text = "Point :";
            // 
            // btShowBill
            // 
            btShowBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btShowBill.Image = (Image)resources.GetObject("btShowBill.Image");
            btShowBill.ImageAlign = ContentAlignment.TopCenter;
            btShowBill.Location = new Point(21, 164);
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
            cbPointUsing.Location = new Point(93, 70);
            cbPointUsing.Name = "cbPointUsing";
            cbPointUsing.Size = new Size(187, 28);
            cbPointUsing.TabIndex = 17;
            cbPointUsing.SelectedIndexChanged += cbPointUsing_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 115);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 15;
            label7.Text = "Total :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 13;
            label6.Text = "Vourcher:";
            // 
            // txtTotalAllOrders
            // 
            txtTotalAllOrders.Location = new Point(93, 112);
            txtTotalAllOrders.Name = "txtTotalAllOrders";
            txtTotalAllOrders.ReadOnly = true;
            txtTotalAllOrders.Size = new Size(187, 27);
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
            panel6.Location = new Point(664, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 334);
            panel6.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(32, 142);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 12;
            label9.Text = "Picture:";
            // 
            // panel10
            // 
            panel10.Controls.Add(pcPictureOrders);
            panel10.Location = new Point(104, 144);
            panel10.Name = "panel10";
            panel10.Size = new Size(207, 176);
            panel10.TabIndex = 11;
            // 
            // pcPictureOrders
            // 
            pcPictureOrders.BorderStyle = BorderStyle.Fixed3D;
            pcPictureOrders.Dock = DockStyle.Fill;
            pcPictureOrders.Location = new Point(0, 0);
            pcPictureOrders.Name = "pcPictureOrders";
            pcPictureOrders.Size = new Size(207, 176);
            pcPictureOrders.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureOrders.TabIndex = 0;
            pcPictureOrders.TabStop = false;
            // 
            // btAddOrders
            // 
            btAddOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAddOrders.Image = (Image)resources.GetObject("btAddOrders.Image");
            btAddOrders.Location = new Point(343, 283);
            btAddOrders.Name = "btAddOrders";
            btAddOrders.Size = new Size(99, 37);
            btAddOrders.TabIndex = 8;
            btAddOrders.UseVisualStyleBackColor = true;
            btAddOrders.Click += btAddOrders_Click;
            // 
            // txtNameOrder
            // 
            txtNameOrder.Location = new Point(104, 7);
            txtNameOrder.Name = "txtNameOrder";
            txtNameOrder.ReadOnly = true;
            txtNameOrder.Size = new Size(207, 27);
            txtNameOrder.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 10);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtQuantityOrder
            // 
            txtQuantityOrder.Location = new Point(104, 52);
            txtQuantityOrder.Name = "txtQuantityOrder";
            txtQuantityOrder.Size = new Size(207, 27);
            txtQuantityOrder.TabIndex = 10;
            txtQuantityOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPriceOrder
            // 
            txtPriceOrder.Location = new Point(104, 95);
            txtPriceOrder.Name = "txtPriceOrder";
            txtPriceOrder.ReadOnly = true;
            txtPriceOrder.Size = new Size(207, 27);
            txtPriceOrder.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 102);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 54);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { txtEmployee, Information });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1612, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtEmployee
            // 
            txtEmployee.AutoSize = false;
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(200, 27);
            txtEmployee.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // Information
            // 
            Information.DropDownItems.AddRange(new ToolStripItem[] { checkOutToolStripMenuItem });
            Information.Name = "Information";
            Information.Size = new Size(49, 27);
            Information.Text = "Info";
            // 
            // checkOutToolStripMenuItem
            // 
            checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            checkOutToolStripMenuItem.Size = new Size(161, 26);
            checkOutToolStripMenuItem.Text = "Check-Out";
            checkOutToolStripMenuItem.Click += checkOutToolStripMenuItem_Click;
            // 
            // OrderProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 620);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}