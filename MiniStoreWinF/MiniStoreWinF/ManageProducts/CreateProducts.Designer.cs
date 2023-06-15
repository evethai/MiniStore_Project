namespace MiniStoreWinF.ManageProducts
{
    partial class CreateProducts
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
            panel1 = new Panel();
            label8 = new Label();
            txtAddNameProducts = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtAddPriceProducts = new TextBox();
            txtAddSKUProducts = new TextBox();
            txtAddQuantityProducts = new TextBox();
            txtAddTypeProducts = new TextBox();
            pictureBox1 = new PictureBox();
            btAddProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btAddProducts);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtAddTypeProducts);
            panel1.Controls.Add(txtAddQuantityProducts);
            panel1.Controls.Add(txtAddSKUProducts);
            panel1.Controls.Add(txtAddPriceProducts);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAddNameProducts);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(26, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 520);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 119);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 8;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddNameProducts
            // 
            txtAddNameProducts.Location = new Point(141, 126);
            txtAddNameProducts.Multiline = true;
            txtAddNameProducts.Name = "txtAddNameProducts";
            txtAddNameProducts.Size = new Size(262, 34);
            txtAddNameProducts.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 10;
            label1.Text = "SKU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 203);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 11;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 287);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 371);
            label4.Name = "label4";
            label4.Size = new Size(111, 38);
            label4.TabIndex = 13;
            label4.Text = "Type";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(459, 42);
            label6.Name = "label6";
            label6.Size = new Size(111, 38);
            label6.TabIndex = 15;
            label6.Text = "Price";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddPriceProducts
            // 
            txtAddPriceProducts.Location = new Point(141, 210);
            txtAddPriceProducts.Multiline = true;
            txtAddPriceProducts.Name = "txtAddPriceProducts";
            txtAddPriceProducts.Size = new Size(262, 34);
            txtAddPriceProducts.TabIndex = 16;
            // 
            // txtAddSKUProducts
            // 
            txtAddSKUProducts.Location = new Point(141, 42);
            txtAddSKUProducts.Multiline = true;
            txtAddSKUProducts.Name = "txtAddSKUProducts";
            txtAddSKUProducts.Size = new Size(262, 34);
            txtAddSKUProducts.TabIndex = 17;
            // 
            // txtAddQuantityProducts
            // 
            txtAddQuantityProducts.Location = new Point(141, 287);
            txtAddQuantityProducts.Multiline = true;
            txtAddQuantityProducts.Name = "txtAddQuantityProducts";
            txtAddQuantityProducts.Size = new Size(262, 34);
            txtAddQuantityProducts.TabIndex = 18;
            // 
            // txtAddTypeProducts
            // 
            txtAddTypeProducts.Location = new Point(141, 378);
            txtAddTypeProducts.Multiline = true;
            txtAddTypeProducts.Name = "txtAddTypeProducts";
            txtAddTypeProducts.Size = new Size(262, 34);
            txtAddTypeProducts.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(554, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 224);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btAddProducts
            // 
            btAddProducts.BackColor = SystemColors.ActiveCaption;
            btAddProducts.Location = new Point(740, 412);
            btAddProducts.Name = "btAddProducts";
            btAddProducts.Size = new Size(94, 49);
            btAddProducts.TabIndex = 21;
            btAddProducts.Text = "ADD";
            btAddProducts.UseVisualStyleBackColor = false;
            // 
            // CreateProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(panel1);
            Name = "CreateProducts";
            Text = "CreateProducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private TextBox txtAddNameProducts;
        private PictureBox pictureBox1;
        private TextBox txtAddTypeProducts;
        private TextBox txtAddQuantityProducts;
        private TextBox txtAddSKUProducts;
        private TextBox txtAddPriceProducts;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAddProducts;
    }
}