namespace MiniStoreWinF.ManageProducts
{
    partial class ManageToUpDe
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
            txtDeletePro = new Button();
            txtUpdatePro = new Button();
            pictureBoxPro = new PictureBox();
            txtTextPic = new TextBox();
            txtPictureProUD = new Button();
            txtUpDePriceProducts = new TextBox();
            txtUpDeQuantityProducts = new TextBox();
            txtUpDeNameProducts = new TextBox();
            txtUpDeSKUProducts = new TextBox();
            txtSatusUD = new ComboBox();
            txtUDTypeProducts = new ComboBox();
            txtUpDeHSDProducts = new DateTimePicker();
            txtUpDeNXXProducts = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtClose = new Button();
            DGVPro = new DataGridView();
            Sku = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtDeletePro
            // 
            txtDeletePro.Location = new Point(772, 310);
            txtDeletePro.Name = "txtDeletePro";
            txtDeletePro.Size = new Size(107, 40);
            txtDeletePro.TabIndex = 59;
            txtDeletePro.Text = "Detele";
            txtDeletePro.UseVisualStyleBackColor = true;
            txtDeletePro.Click += txtDeletePro_Click;
            // 
            // txtUpdatePro
            // 
            txtUpdatePro.Location = new Point(650, 310);
            txtUpdatePro.Name = "txtUpdatePro";
            txtUpdatePro.Size = new Size(107, 40);
            txtUpdatePro.TabIndex = 58;
            txtUpdatePro.Text = "Update";
            txtUpdatePro.UseVisualStyleBackColor = true;
            txtUpdatePro.Click += txtUpdatePro_Click;
            // 
            // pictureBoxPro
            // 
            pictureBoxPro.Location = new Point(660, 82);
            pictureBoxPro.Name = "pictureBoxPro";
            pictureBoxPro.Size = new Size(210, 193);
            pictureBoxPro.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPro.TabIndex = 57;
            pictureBoxPro.TabStop = false;
            // 
            // txtTextPic
            // 
            txtTextPic.Location = new Point(660, 45);
            txtTextPic.Multiline = true;
            txtTextPic.Name = "txtTextPic";
            txtTextPic.Size = new Size(210, 27);
            txtTextPic.TabIndex = 56;
            txtTextPic.Visible = false;
            // 
            // txtPictureProUD
            // 
            txtPictureProUD.Location = new Point(557, 45);
            txtPictureProUD.Name = "txtPictureProUD";
            txtPictureProUD.Size = new Size(91, 27);
            txtPictureProUD.TabIndex = 55;
            txtPictureProUD.Text = "Picture";
            txtPictureProUD.UseVisualStyleBackColor = true;
            txtPictureProUD.Click += txtPictureProUD_Click_1;
            // 
            // txtUpDePriceProducts
            // 
            txtUpDePriceProducts.Location = new Point(341, 158);
            txtUpDePriceProducts.Multiline = true;
            txtUpDePriceProducts.Name = "txtUpDePriceProducts";
            txtUpDePriceProducts.Size = new Size(199, 27);
            txtUpDePriceProducts.TabIndex = 54;
            // 
            // txtUpDeQuantityProducts
            // 
            txtUpDeQuantityProducts.Location = new Point(341, 115);
            txtUpDeQuantityProducts.Multiline = true;
            txtUpDeQuantityProducts.Name = "txtUpDeQuantityProducts";
            txtUpDeQuantityProducts.Size = new Size(199, 27);
            txtUpDeQuantityProducts.TabIndex = 53;
            // 
            // txtUpDeNameProducts
            // 
            txtUpDeNameProducts.Location = new Point(341, 81);
            txtUpDeNameProducts.Multiline = true;
            txtUpDeNameProducts.Name = "txtUpDeNameProducts";
            txtUpDeNameProducts.Size = new Size(199, 27);
            txtUpDeNameProducts.TabIndex = 52;
            // 
            // txtUpDeSKUProducts
            // 
            txtUpDeSKUProducts.Location = new Point(341, 44);
            txtUpDeSKUProducts.Multiline = true;
            txtUpDeSKUProducts.Name = "txtUpDeSKUProducts";
            txtUpDeSKUProducts.ReadOnly = true;
            txtUpDeSKUProducts.Size = new Size(199, 27);
            txtUpDeSKUProducts.TabIndex = 51;
            // 
            // txtSatusUD
            // 
            txtSatusUD.FormattingEnabled = true;
            txtSatusUD.Items.AddRange(new object[] { "SoldOut", "Availability" });
            txtSatusUD.Location = new Point(341, 271);
            txtSatusUD.Name = "txtSatusUD";
            txtSatusUD.Size = new Size(139, 28);
            txtSatusUD.TabIndex = 50;
            // 
            // txtUDTypeProducts
            // 
            txtUDTypeProducts.FormattingEnabled = true;
            txtUDTypeProducts.Location = new Point(341, 309);
            txtUDTypeProducts.Name = "txtUDTypeProducts";
            txtUDTypeProducts.Size = new Size(139, 28);
            txtUDTypeProducts.TabIndex = 49;
            // 
            // txtUpDeHSDProducts
            // 
            txtUpDeHSDProducts.Location = new Point(341, 231);
            txtUpDeHSDProducts.Name = "txtUpDeHSDProducts";
            txtUpDeHSDProducts.Size = new Size(254, 27);
            txtUpDeHSDProducts.TabIndex = 48;
            // 
            // txtUpDeNXXProducts
            // 
            txtUpDeNXXProducts.Location = new Point(341, 193);
            txtUpDeNXXProducts.Name = "txtUpDeNXXProducts";
            txtUpDeNXXProducts.Size = new Size(254, 27);
            txtUpDeNXXProducts.TabIndex = 47;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(224, 260);
            label8.Name = "label8";
            label8.Size = new Size(115, 48);
            label8.TabIndex = 46;
            label8.Text = "Status";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(224, 222);
            label7.Name = "label7";
            label7.Size = new Size(115, 48);
            label7.TabIndex = 45;
            label7.Text = "HSD";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(224, 184);
            label6.Name = "label6";
            label6.Size = new Size(115, 48);
            label6.TabIndex = 44;
            label6.Text = "NXS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(224, 146);
            label5.Name = "label5";
            label5.Size = new Size(115, 48);
            label5.TabIndex = 43;
            label5.Text = "Price";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 108);
            label4.Name = "label4";
            label4.Size = new Size(115, 48);
            label4.TabIndex = 42;
            label4.Text = "Quantity";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 70);
            label3.Name = "label3";
            label3.Size = new Size(115, 48);
            label3.TabIndex = 41;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(224, 298);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 40;
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 32);
            label1.Name = "label1";
            label1.Size = new Size(115, 48);
            label1.TabIndex = 39;
            label1.Text = "SKU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClose
            // 
            txtClose.Location = new Point(784, 445);
            txtClose.Name = "txtClose";
            txtClose.Size = new Size(86, 28);
            txtClose.TabIndex = 60;
            txtClose.Text = "Close";
            txtClose.UseVisualStyleBackColor = true;
            txtClose.Click += txtClose_Click;
            // 
            // DGVPro
            // 
            DGVPro.AutoGenerateColumns = false;
            DGVPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPro.Columns.AddRange(new DataGridViewColumn[] { Sku, nameProductDataGridViewTextBoxColumn });
            DGVPro.DataSource = productBindingSource;
            DGVPro.Location = new Point(12, 44);
            DGVPro.Name = "DGVPro";
            DGVPro.RowHeadersWidth = 51;
            DGVPro.RowTemplate.Height = 29;
            DGVPro.Size = new Size(206, 212);
            DGVPro.TabIndex = 61;
            DGVPro.CellClick += DGVPro_CellClick;
            // 
            // Sku
            // 
            Sku.DataPropertyName = "Sku";
            Sku.HeaderText = "Sku";
            Sku.MinimumWidth = 6;
            Sku.Name = "Sku";
            Sku.Width = 70;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Repository.Models.Product);
            // 
            // ManageToUpDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 485);
            Controls.Add(DGVPro);
            Controls.Add(txtClose);
            Controls.Add(txtDeletePro);
            Controls.Add(txtUpdatePro);
            Controls.Add(pictureBoxPro);
            Controls.Add(txtTextPic);
            Controls.Add(txtPictureProUD);
            Controls.Add(txtUpDePriceProducts);
            Controls.Add(txtUpDeQuantityProducts);
            Controls.Add(txtUpDeNameProducts);
            Controls.Add(txtUpDeSKUProducts);
            Controls.Add(txtSatusUD);
            Controls.Add(txtUDTypeProducts);
            Controls.Add(txtUpDeHSDProducts);
            Controls.Add(txtUpDeNXXProducts);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageToUpDe";
            Text = "ManageToUpDe";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPro).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPro).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtDeletePro;
        private Button txtUpdatePro;
        private PictureBox pictureBoxPro;
        private TextBox txtTextPic;
        private Button txtPictureProUD;
        private TextBox txtUpDePriceProducts;
        private TextBox txtUpDeQuantityProducts;
        private TextBox txtUpDeNameProducts;
        private TextBox txtUpDeSKUProducts;
        private ComboBox txtSatusUD;
        private ComboBox txtUDTypeProducts;
        private DateTimePicker txtUpDeHSDProducts;
        private DateTimePicker txtUpDeNXXProducts;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtClose;
        private DataGridView DGVPro;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Sku;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
    }
}