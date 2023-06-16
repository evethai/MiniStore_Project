namespace MiniStoreWinF.ManageProducts
{
    partial class UpdateRemoveProduct
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
            DgvUpDe = new DataGridView();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nxxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewImageColumn();
            statusPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            txtBackLai = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvUpDe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DgvUpDe
            // 
            DgvUpDe.AutoGenerateColumns = false;
            DgvUpDe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUpDe.Columns.AddRange(new DataGridViewColumn[] { skuDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, quantityProductDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, nxxDataGridViewTextBoxColumn, hsdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, statusPDataGridViewTextBoxColumn });
            DgvUpDe.DataSource = productBindingSource;
            DgvUpDe.Location = new Point(97, 70);
            DgvUpDe.Name = "DgvUpDe";
            DgvUpDe.RowHeadersWidth = 51;
            DgvUpDe.RowTemplate.Height = 29;
            DgvUpDe.Size = new Size(607, 271);
            DgvUpDe.TabIndex = 0;
            DgvUpDe.CellDoubleClick += DgvUpDe_CellDoubleClick;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            productTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityProductDataGridViewTextBoxColumn
            // 
            quantityProductDataGridViewTextBoxColumn.DataPropertyName = "QuantityProduct";
            quantityProductDataGridViewTextBoxColumn.HeaderText = "QuantityProduct";
            quantityProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityProductDataGridViewTextBoxColumn.Name = "quantityProductDataGridViewTextBoxColumn";
            quantityProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            priceProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // nxxDataGridViewTextBoxColumn
            // 
            nxxDataGridViewTextBoxColumn.DataPropertyName = "Nxx";
            nxxDataGridViewTextBoxColumn.HeaderText = "Nxx";
            nxxDataGridViewTextBoxColumn.MinimumWidth = 6;
            nxxDataGridViewTextBoxColumn.Name = "nxxDataGridViewTextBoxColumn";
            nxxDataGridViewTextBoxColumn.Width = 125;
            // 
            // hsdDataGridViewTextBoxColumn
            // 
            hsdDataGridViewTextBoxColumn.DataPropertyName = "Hsd";
            hsdDataGridViewTextBoxColumn.HeaderText = "Hsd";
            hsdDataGridViewTextBoxColumn.MinimumWidth = 6;
            hsdDataGridViewTextBoxColumn.Name = "hsdDataGridViewTextBoxColumn";
            hsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PictureProduct";
            dataGridViewTextBoxColumn1.HeaderText = "PictureProduct";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusPDataGridViewTextBoxColumn
            // 
            statusPDataGridViewTextBoxColumn.DataPropertyName = "StatusP";
            statusPDataGridViewTextBoxColumn.HeaderText = "StatusP";
            statusPDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusPDataGridViewTextBoxColumn.Name = "statusPDataGridViewTextBoxColumn";
            statusPDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // txtBackLai
            // 
            txtBackLai.Location = new Point(12, 12);
            txtBackLai.Name = "txtBackLai";
            txtBackLai.Size = new Size(95, 40);
            txtBackLai.TabIndex = 1;
            txtBackLai.Text = "Back";
            txtBackLai.UseVisualStyleBackColor = true;
            txtBackLai.Click += txtBackLai_Click;
            // 
            // button1
            // 
            button1.Location = new Point(609, 358);
            button1.Name = "button1";
            button1.Size = new Size(95, 40);
            button1.TabIndex = 39;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateRemoveProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 478);
            Controls.Add(button1);
            Controls.Add(txtBackLai);
            Controls.Add(DgvUpDe);
            Name = "UpdateRemoveProduct";
            Text = "UpdateRemoveProduct";
            ((System.ComponentModel.ISupportInitialize)DgvUpDe).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvUpDe;
        private Button txtBackLai;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nxxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hsdDataGridViewTextBoxColumn;
        private DataGridViewImageColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusPDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button button1;
    }
}