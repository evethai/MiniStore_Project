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
            txtStatusPro = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtHSD = new DateTimePicker();
            txtNXX = new DateTimePicker();
            txtPic = new TextBox();
            txtPicturePro = new Button();
            txtAddTypeProducts = new ComboBox();
            btAddProducts = new Button();
            pictureBox1 = new PictureBox();
            txtAddQuantityProducts = new TextBox();
            txtAddSKUProducts = new TextBox();
            txtAddPriceProducts = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAddNameProducts = new TextBox();
            label8 = new Label();
            txtBackM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtStatusPro
            // 
            txtStatusPro.FormattingEnabled = true;
            txtStatusPro.Items.AddRange(new object[] { "SoldOut", "Availability" });
            txtStatusPro.Location = new Point(145, 468);
            txtStatusPro.Name = "txtStatusPro";
            txtStatusPro.Size = new Size(135, 28);
            txtStatusPro.TabIndex = 30;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 461);
            label7.Name = "label7";
            label7.Size = new Size(111, 38);
            label7.TabIndex = 29;
            label7.Text = "Status";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 351);
            label6.Name = "label6";
            label6.Size = new Size(111, 38);
            label6.TabIndex = 28;
            label6.Text = "HSD";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(111, 38);
            label5.TabIndex = 27;
            label5.Text = "NXX";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHSD
            // 
            txtHSD.Location = new Point(145, 356);
            txtHSD.Name = "txtHSD";
            txtHSD.Size = new Size(250, 27);
            txtHSD.TabIndex = 26;
            // 
            // txtNXX
            // 
            txtNXX.Location = new Point(145, 301);
            txtNXX.Name = "txtNXX";
            txtNXX.Size = new Size(250, 27);
            txtNXX.TabIndex = 25;
            // 
            // txtPic
            // 
            txtPic.Location = new Point(605, 56);
            txtPic.Name = "txtPic";
            txtPic.Size = new Size(280, 27);
            txtPic.TabIndex = 24;
            // 
            // txtPicturePro
            // 
            txtPicturePro.Location = new Point(477, 52);
            txtPicturePro.Name = "txtPicturePro";
            txtPicturePro.Size = new Size(108, 34);
            txtPicturePro.TabIndex = 23;
            txtPicturePro.Text = "Picture";
            txtPicturePro.UseVisualStyleBackColor = true;
            txtPicturePro.Click += txtPicturePro_Click;
            // 
            // txtAddTypeProducts
            // 
            txtAddTypeProducts.FormattingEnabled = true;
            txtAddTypeProducts.Location = new Point(145, 405);
            txtAddTypeProducts.Name = "txtAddTypeProducts";
            txtAddTypeProducts.Size = new Size(135, 28);
            txtAddTypeProducts.TabIndex = 22;
            // 
            // btAddProducts
            // 
            btAddProducts.BackColor = SystemColors.ActiveCaption;
            btAddProducts.Location = new Point(791, 450);
            btAddProducts.Name = "btAddProducts";
            btAddProducts.Size = new Size(94, 49);
            btAddProducts.TabIndex = 21;
            btAddProducts.Text = "ADD";
            btAddProducts.UseVisualStyleBackColor = false;
            btAddProducts.Click += btAddProducts_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(605, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtAddQuantityProducts
            // 
            txtAddQuantityProducts.Location = new Point(145, 186);
            txtAddQuantityProducts.Multiline = true;
            txtAddQuantityProducts.Name = "txtAddQuantityProducts";
            txtAddQuantityProducts.Size = new Size(262, 34);
            txtAddQuantityProducts.TabIndex = 18;
            // 
            // txtAddSKUProducts
            // 
            txtAddSKUProducts.Location = new Point(145, 79);
            txtAddSKUProducts.Multiline = true;
            txtAddSKUProducts.Name = "txtAddSKUProducts";
            txtAddSKUProducts.Size = new Size(262, 34);
            txtAddSKUProducts.TabIndex = 17;
            // 
            // txtAddPriceProducts
            // 
            txtAddPriceProducts.Location = new Point(145, 238);
            txtAddPriceProducts.Multiline = true;
            txtAddPriceProducts.Name = "txtAddPriceProducts";
            txtAddPriceProducts.Size = new Size(262, 34);
            txtAddPriceProducts.TabIndex = 16;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 405);
            label4.Name = "label4";
            label4.Size = new Size(111, 38);
            label4.TabIndex = 13;
            label4.Text = "Type";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 238);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 11;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 10;
            label1.Text = "SKU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddNameProducts
            // 
            txtAddNameProducts.Location = new Point(145, 132);
            txtAddNameProducts.Multiline = true;
            txtAddNameProducts.Name = "txtAddNameProducts";
            txtAddNameProducts.Size = new Size(262, 34);
            txtAddNameProducts.TabIndex = 9;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 132);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 8;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBackM
            // 
            txtBackM.Location = new Point(26, 12);
            txtBackM.Name = "txtBackM";
            txtBackM.Size = new Size(94, 38);
            txtBackM.TabIndex = 1;
            txtBackM.Text = "Back";
            txtBackM.UseVisualStyleBackColor = true;
            txtBackM.Click += txtBackM_Click;
            // 
            // CreateProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(txtStatusPro);
            Controls.Add(txtBackM);
            Controls.Add(txtAddTypeProducts);
            Controls.Add(txtHSD);
            Controls.Add(label7);
            Controls.Add(txtNXX);
            Controls.Add(label6);
            Controls.Add(txtAddSKUProducts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(txtAddNameProducts);
            Controls.Add(txtPic);
            Controls.Add(btAddProducts);
            Controls.Add(txtPicturePro);
            Controls.Add(pictureBox1);
            Controls.Add(txtAddPriceProducts);
            Controls.Add(txtAddQuantityProducts);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CreateProducts";
            Text = "CreateProducts";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private TextBox txtAddNameProducts;
        private PictureBox pictureBox1;
        private TextBox txtAddQuantityProducts;
        private TextBox txtAddSKUProducts;
        private TextBox txtAddPriceProducts;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAddProducts;
        private Button txtBackM;
        private ComboBox txtAddTypeProducts;
        private Button txtPicturePro;
        private TextBox txtPic;
        private DateTimePicker txtNXX;
        private DateTimePicker txtHSD;
        private ComboBox txtStatusPro;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}