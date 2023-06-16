namespace MiniStoreWinF.ManageProducts
{
    partial class UpdateStatusTypeProduct
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
            groupBox2 = new GroupBox();
            DgvTypeProduct = new DataGridView();
            idCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catalogyBindingSource = new BindingSource(components);
            txtUpdateStatusTyPro = new ComboBox();
            label11 = new Label();
            btUpdateTypeProduct = new Button();
            label2 = new Label();
            txtTypeProductCategory = new TextBox();
            label1 = new Label();
            txtIDTypeProduct = new TextBox();
            btLoadUpSta = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvTypeProduct);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(24, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 155);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Category List";
            // 
            // DgvTypeProduct
            // 
            DgvTypeProduct.AutoGenerateColumns = false;
            DgvTypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTypeProduct.Columns.AddRange(new DataGridViewColumn[] { idCaDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn, statusCDataGridViewTextBoxColumn });
            DgvTypeProduct.DataSource = catalogyBindingSource;
            DgvTypeProduct.Location = new Point(0, 28);
            DgvTypeProduct.Name = "DgvTypeProduct";
            DgvTypeProduct.RowHeadersWidth = 51;
            DgvTypeProduct.RowTemplate.Height = 29;
            DgvTypeProduct.Size = new Size(393, 127);
            DgvTypeProduct.TabIndex = 0;
            DgvTypeProduct.CellClick += DgvTypeProduct_CellClick;
            // 
            // idCaDataGridViewTextBoxColumn
            // 
            idCaDataGridViewTextBoxColumn.DataPropertyName = "IdCa";
            idCaDataGridViewTextBoxColumn.HeaderText = "IdCa";
            idCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCaDataGridViewTextBoxColumn.Name = "idCaDataGridViewTextBoxColumn";
            idCaDataGridViewTextBoxColumn.Width = 90;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // statusCDataGridViewTextBoxColumn
            // 
            statusCDataGridViewTextBoxColumn.DataPropertyName = "StatusC";
            statusCDataGridViewTextBoxColumn.HeaderText = "StatusC";
            statusCDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusCDataGridViewTextBoxColumn.Name = "statusCDataGridViewTextBoxColumn";
            statusCDataGridViewTextBoxColumn.Width = 110;
            // 
            // catalogyBindingSource
            // 
            catalogyBindingSource.DataSource = typeof(Repository.Models.Catalogy);
            // 
            // txtUpdateStatusTyPro
            // 
            txtUpdateStatusTyPro.FormattingEnabled = true;
            txtUpdateStatusTyPro.Items.AddRange(new object[] { "SoldOut", "Availability" });
            txtUpdateStatusTyPro.Location = new Point(155, 259);
            txtUpdateStatusTyPro.Name = "txtUpdateStatusTyPro";
            txtUpdateStatusTyPro.Size = new Size(151, 28);
            txtUpdateStatusTyPro.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(24, 264);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 23;
            label11.Text = "Status";
            // 
            // btUpdateTypeProduct
            // 
            btUpdateTypeProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdateTypeProduct.ForeColor = SystemColors.ActiveCaptionText;
            btUpdateTypeProduct.Location = new Point(323, 295);
            btUpdateTypeProduct.Name = "btUpdateTypeProduct";
            btUpdateTypeProduct.Size = new Size(94, 31);
            btUpdateTypeProduct.TabIndex = 24;
            btUpdateTypeProduct.Text = "Update";
            btUpdateTypeProduct.UseVisualStyleBackColor = true;
            btUpdateTypeProduct.Click += btUpdateTypeProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 228);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 25;
            label2.Text = "Type Product";
            // 
            // txtTypeProductCategory
            // 
            txtTypeProductCategory.Location = new Point(155, 224);
            txtTypeProductCategory.Name = "txtTypeProductCategory";
            txtTypeProductCategory.Size = new Size(262, 27);
            txtTypeProductCategory.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 196);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 27;
            label1.Text = "Id Type";
            // 
            // txtIDTypeProduct
            // 
            txtIDTypeProduct.Location = new Point(155, 186);
            txtIDTypeProduct.Name = "txtIDTypeProduct";
            txtIDTypeProduct.Size = new Size(262, 27);
            txtIDTypeProduct.TabIndex = 28;
            // 
            // btLoadUpSta
            // 
            btLoadUpSta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btLoadUpSta.ForeColor = SystemColors.ActiveCaptionText;
            btLoadUpSta.Location = new Point(223, 295);
            btLoadUpSta.Name = "btLoadUpSta";
            btLoadUpSta.Size = new Size(94, 31);
            btLoadUpSta.TabIndex = 29;
            btLoadUpSta.Text = "Load";
            btLoadUpSta.UseVisualStyleBackColor = true;
            btLoadUpSta.Click += btLoadUpSta_Click;
            // 
            // UpdateStatusTypeProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(578, 338);
            Controls.Add(btLoadUpSta);
            Controls.Add(txtIDTypeProduct);
            Controls.Add(label1);
            Controls.Add(txtTypeProductCategory);
            Controls.Add(label2);
            Controls.Add(btUpdateTypeProduct);
            Controls.Add(label11);
            Controls.Add(txtUpdateStatusTyPro);
            Controls.Add(groupBox2);
            Name = "UpdateStatusTypeProduct";
            Text = "UpdateStatusTypeProduct";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTypeProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogyBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView DgvTypeProduct;
        private BindingSource catalogyBindingSource;
        private DataGridViewTextBoxColumn idCaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusCDataGridViewTextBoxColumn;
        private ComboBox txtUpdateStatusTyPro;
        private Label label11;
        private Button btUpdateTypeProduct;
        private Label label2;
        private TextBox txtTypeProductCategory;
        private Label label1;
        private TextBox txtIDTypeProduct;
        private Button btLoadUpSta;
    }
}