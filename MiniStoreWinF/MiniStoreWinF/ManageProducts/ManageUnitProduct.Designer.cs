namespace MiniStoreWinF.ManageProducts
{
    partial class ManageUnitProduct
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceImportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceExportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            btExport = new Button();
            txtImportUnit = new Button();
            txtPathToImport = new TextBox();
            txtSelectFile = new Button();
            label8 = new Label();
            label7 = new Label();
            btSort = new Button();
            txtPriceFilter2 = new TextBox();
            txtPriceFilter1 = new TextBox();
            label12 = new Label();
            txtArrange = new ComboBox();
            btLoad = new Button();
            btClear = new Button();
            btUpdate = new Button();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            numericQuantity = new NumericUpDown();
            label6 = new Label();
            txtNameUnit = new TextBox();
            txtIDUnit = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            cbSku = new ComboBox();
            txtPriceExport = new TextBox();
            txtPriceImport = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.0430145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.95699F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 287F));
            tableLayoutPanel1.Size = new Size(1216, 474);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1210, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of Unit Product";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idUnitDataGridViewTextBoxColumn, skuDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn, quantityUnitDataGridViewTextBoxColumn, priceImportDataGridViewTextBoxColumn, priceExportDataGridViewTextBoxColumn });
            dataGridView1.DataSource = unitBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1204, 256);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idUnitDataGridViewTextBoxColumn
            // 
            idUnitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idUnitDataGridViewTextBoxColumn.DataPropertyName = "IdUnit";
            idUnitDataGridViewTextBoxColumn.HeaderText = "Id Unit";
            idUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            idUnitDataGridViewTextBoxColumn.Name = "idUnitDataGridViewTextBoxColumn";
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "Unit Name";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // quantityUnitDataGridViewTextBoxColumn
            // 
            quantityUnitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityUnit";
            quantityUnitDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityUnitDataGridViewTextBoxColumn.Name = "quantityUnitDataGridViewTextBoxColumn";
            // 
            // priceImportDataGridViewTextBoxColumn
            // 
            priceImportDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceImportDataGridViewTextBoxColumn.DataPropertyName = "PriceImport";
            dataGridViewCellStyle1.Format = "#,###";
            dataGridViewCellStyle1.NullValue = "0";
            priceImportDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            priceImportDataGridViewTextBoxColumn.HeaderText = "Price Import";
            priceImportDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceImportDataGridViewTextBoxColumn.Name = "priceImportDataGridViewTextBoxColumn";
            // 
            // priceExportDataGridViewTextBoxColumn
            // 
            priceExportDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceExportDataGridViewTextBoxColumn.DataPropertyName = "PriceExport";
            dataGridViewCellStyle2.Format = "#,###";
            dataGridViewCellStyle2.NullValue = "0";
            priceExportDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            priceExportDataGridViewTextBoxColumn.HeaderText = "Price Export";
            priceExportDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceExportDataGridViewTextBoxColumn.Name = "priceExportDataGridViewTextBoxColumn";
            // 
            // unitBindingSource
            // 
            unitBindingSource.DataSource = typeof(Repository.Models.Unit);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btExport);
            groupBox2.Controls.Add(txtImportUnit);
            groupBox2.Controls.Add(txtPathToImport);
            groupBox2.Controls.Add(txtSelectFile);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btSort);
            groupBox2.Controls.Add(txtPriceFilter2);
            groupBox2.Controls.Add(txtPriceFilter1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtArrange);
            groupBox2.Controls.Add(btLoad);
            groupBox2.Controls.Add(btClear);
            groupBox2.Controls.Add(btUpdate);
            groupBox2.Controls.Add(button1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1210, 46);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operation";
            // 
            // btExport
            // 
            btExport.BackColor = SystemColors.ButtonShadow;
            btExport.ForeColor = SystemColors.ActiveCaptionText;
            btExport.Location = new Point(857, 19);
            btExport.Name = "btExport";
            btExport.Size = new Size(96, 64);
            btExport.TabIndex = 43;
            btExport.Text = "Export Form";
            btExport.UseVisualStyleBackColor = false;
            btExport.Click += btExport_Click;
            // 
            // txtImportUnit
            // 
            txtImportUnit.BackColor = SystemColors.ButtonShadow;
            txtImportUnit.ForeColor = SystemColors.ActiveCaptionText;
            txtImportUnit.Location = new Point(1061, 51);
            txtImportUnit.Name = "txtImportUnit";
            txtImportUnit.Size = new Size(96, 32);
            txtImportUnit.TabIndex = 42;
            txtImportUnit.Text = "Import";
            txtImportUnit.UseVisualStyleBackColor = false;
            txtImportUnit.Click += txtImportUnit_Click;
            // 
            // txtPathToImport
            // 
            txtPathToImport.Location = new Point(961, 19);
            txtPathToImport.Name = "txtPathToImport";
            txtPathToImport.Size = new Size(196, 27);
            txtPathToImport.TabIndex = 41;
            // 
            // txtSelectFile
            // 
            txtSelectFile.BackColor = SystemColors.ButtonShadow;
            txtSelectFile.ForeColor = SystemColors.ActiveCaptionText;
            txtSelectFile.Location = new Point(959, 51);
            txtSelectFile.Name = "txtSelectFile";
            txtSelectFile.Size = new Size(96, 32);
            txtSelectFile.TabIndex = 40;
            txtSelectFile.Text = "Select File";
            txtSelectFile.UseVisualStyleBackColor = false;
            txtSelectFile.Click += txtSelectFile_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(595, 58);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 37;
            label8.Text = "Price Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(493, 58);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 36;
            label7.Text = "Price Min";
            // 
            // btSort
            // 
            btSort.BackColor = SystemColors.ButtonShadow;
            btSort.ForeColor = SystemColors.ActiveCaptionText;
            btSort.Location = new Point(671, 21);
            btSort.Name = "btSort";
            btSort.Size = new Size(96, 62);
            btSort.TabIndex = 35;
            btSort.Text = "Sort ";
            btSort.UseVisualStyleBackColor = false;
            btSort.Click += btSort_Click;
            // 
            // txtPriceFilter2
            // 
            txtPriceFilter2.Location = new Point(595, 21);
            txtPriceFilter2.Name = "txtPriceFilter2";
            txtPriceFilter2.Size = new Size(70, 27);
            txtPriceFilter2.TabIndex = 34;
            txtPriceFilter2.Leave += txtPriceFilter2_Leave;
            // 
            // txtPriceFilter1
            // 
            txtPriceFilter1.Location = new Point(493, 21);
            txtPriceFilter1.Name = "txtPriceFilter1";
            txtPriceFilter1.Size = new Size(70, 27);
            txtPriceFilter1.TabIndex = 33;
            txtPriceFilter1.Leave += txtPriceFilter1_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(560, 24);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 32;
            label12.Text = "---->";
            // 
            // txtArrange
            // 
            txtArrange.DisplayMember = "ALL";
            txtArrange.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArrange.FormattingEnabled = true;
            txtArrange.Items.AddRange(new object[] { "ALL", "Price Ascending", "Price Decrease " });
            txtArrange.Location = new Point(39, 53);
            txtArrange.Name = "txtArrange";
            txtArrange.Size = new Size(147, 28);
            txtArrange.TabIndex = 31;
            txtArrange.SelectedIndexChanged += txtArrange_SelectedIndexChanged;
            // 
            // btLoad
            // 
            btLoad.BackColor = SystemColors.ButtonShadow;
            btLoad.ForeColor = SystemColors.ActiveCaptionText;
            btLoad.Location = new Point(294, 50);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(96, 32);
            btLoad.TabIndex = 30;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = false;
            btLoad.Click += btLoad_Click;
            // 
            // btClear
            // 
            btClear.BackColor = SystemColors.ButtonShadow;
            btClear.ForeColor = SystemColors.ActiveCaptionText;
            btClear.Location = new Point(294, 19);
            btClear.Name = "btClear";
            btClear.Size = new Size(96, 32);
            btClear.TabIndex = 29;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = SystemColors.ButtonShadow;
            btUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btUpdate.Location = new Point(192, 50);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(96, 32);
            btUpdate.TabIndex = 28;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(192, 19);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 27;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1210, 128);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericQuantity);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtNameUnit);
            groupBox3.Controls.Add(txtIDUnit);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(599, 122);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information Of Unit";
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(178, 76);
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(150, 27);
            numericQuantity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 75);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 10;
            label6.Text = "Quantity";
            // 
            // txtNameUnit
            // 
            txtNameUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameUnit.Location = new Point(178, 125);
            txtNameUnit.Name = "txtNameUnit";
            txtNameUnit.Size = new Size(209, 27);
            txtNameUnit.TabIndex = 4;
            // 
            // txtIDUnit
            // 
            txtIDUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDUnit.Location = new Point(178, 30);
            txtIDUnit.Name = "txtIDUnit";
            txtIDUnit.Size = new Size(209, 27);
            txtIDUnit.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 125);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Unit Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Unit";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbSku);
            groupBox4.Controls.Add(txtPriceExport);
            groupBox4.Controls.Add(txtPriceImport);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(608, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(599, 122);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // cbSku
            // 
            cbSku.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSku.FormattingEnabled = true;
            cbSku.Location = new Point(209, 29);
            cbSku.Name = "cbSku";
            cbSku.Size = new Size(202, 28);
            cbSku.TabIndex = 5;
            // 
            // txtPriceExport
            // 
            txtPriceExport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceExport.Location = new Point(209, 131);
            txtPriceExport.Name = "txtPriceExport";
            txtPriceExport.Size = new Size(202, 27);
            txtPriceExport.TabIndex = 14;
            txtPriceExport.Leave += txtPriceExport_Leave;
            // 
            // txtPriceImport
            // 
            txtPriceImport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceImport.Location = new Point(209, 81);
            txtPriceImport.Name = "txtPriceImport";
            txtPriceImport.Size = new Size(202, 27);
            txtPriceImport.TabIndex = 13;
            txtPriceImport.Leave += txtPriceImport_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 131);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 12;
            label4.Text = "Price Export";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 1;
            label2.Text = "SKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 81);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 11;
            label5.Text = "Price Import";
            // 
            // ManageUnitProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 474);
            Controls.Add(tableLayoutPanel1);
            Name = "ManageUnitProduct";
            Text = "ManageUnitProduct";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceImportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceExportDataGridViewTextBoxColumn;
        private BindingSource unitBindingSource;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private ComboBox cbSku;
        private TextBox txtNameUnit;
        private TextBox txtIDUnit;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private TextBox txtPriceExport;
        private TextBox txtPriceImport;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericQuantity;
        private Button btLoad;
        private Button btClear;
        private Button btUpdate;
        private Button button1;
        private ComboBox txtArrange;
        private TextBox txtPriceFilter2;
        private TextBox txtPriceFilter1;
        private Label label12;
        private Button btSort;
        private Label label8;
        private Label label7;
        private Button btExport;
        private Button txtImportUnit;
        private TextBox txtPathToImport;
        private Button txtSelectFile;
    }
}