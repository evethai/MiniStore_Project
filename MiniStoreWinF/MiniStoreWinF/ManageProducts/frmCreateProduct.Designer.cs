namespace MiniStoreWinF.ManageProducts
{
    partial class frmCreateProduct
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
            panel3 = new Panel();
            txtPathPic = new TextBox();
            cbIdSupplier = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            PictureProduct = new PictureBox();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            dateDateImport = new DateTimePicker();
            label10 = new Label();
            dateEXP = new DateTimePicker();
            cbStatus = new ComboBox();
            label9 = new Label();
            dateMFG = new DateTimePicker();
            label3 = new Label();
            cbTypeProduct = new ComboBox();
            label5 = new Label();
            txtNameProduct = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPathPic);
            panel3.Controls.Add(cbIdSupplier);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(PictureProduct);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(dateDateImport);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dateEXP);
            panel3.Controls.Add(cbStatus);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dateMFG);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbTypeProduct);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtNameProduct);
            panel3.Location = new Point(22, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 449);
            panel3.TabIndex = 4;
            // 
            // txtPathPic
            // 
            txtPathPic.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPathPic.Location = new Point(241, 303);
            txtPathPic.Name = "txtPathPic";
            txtPathPic.Size = new Size(83, 25);
            txtPathPic.TabIndex = 39;
            txtPathPic.Visible = false;
            // 
            // cbIdSupplier
            // 
            cbIdSupplier.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdSupplier.FormattingEnabled = true;
            cbIdSupplier.Location = new Point(101, 89);
            cbIdSupplier.Name = "cbIdSupplier";
            cbIdSupplier.Size = new Size(126, 25);
            cbIdSupplier.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 97);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 38;
            label4.Text = "ID Supplier";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(101, 399);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 36;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PictureProduct
            // 
            PictureProduct.BackColor = SystemColors.Info;
            PictureProduct.Location = new Point(101, 303);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(134, 90);
            PictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProduct.TabIndex = 35;
            PictureProduct.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 303);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 34;
            label6.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(19, 261);
            label12.Name = "label12";
            label12.Size = new Size(43, 17);
            label12.TabIndex = 33;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(19, 221);
            label11.Name = "label11";
            label11.Size = new Size(78, 17);
            label11.TabIndex = 31;
            label11.Text = "Date Import";
            // 
            // dateDateImport
            // 
            dateDateImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDateImport.Location = new Point(101, 216);
            dateDateImport.Name = "dateDateImport";
            dateDateImport.Size = new Size(221, 25);
            dateDateImport.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 181);
            label10.Name = "label10";
            label10.Size = new Size(30, 17);
            label10.TabIndex = 29;
            label10.Text = "EXP";
            // 
            // dateEXP
            // 
            dateEXP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEXP.Location = new Point(101, 175);
            dateEXP.Name = "dateEXP";
            dateEXP.Size = new Size(221, 25);
            dateEXP.TabIndex = 28;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Availability", "Sold Out" });
            cbStatus.Location = new Point(101, 258);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(134, 25);
            cbStatus.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 141);
            label9.Name = "label9";
            label9.Size = new Size(35, 17);
            label9.TabIndex = 27;
            label9.Text = "MFG";
            // 
            // dateMFG
            // 
            dateMFG.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateMFG.Location = new Point(101, 135);
            dateMFG.Name = "dateMFG";
            dateMFG.Size = new Size(221, 25);
            dateMFG.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 15);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // cbTypeProduct
            // 
            cbTypeProduct.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeProduct.FormattingEnabled = true;
            cbTypeProduct.Location = new Point(101, 9);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(116, 25);
            cbTypeProduct.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 55);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // txtNameProduct
            // 
            txtNameProduct.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameProduct.Location = new Point(101, 49);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(210, 25);
            txtNameProduct.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 41);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Information Of Product";
            // 
            // frmCreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 522);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "frmCreateProduct";
            Text = "frmCreateProduct";
            FormClosed += frmCreateProduct_FormClosed;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox pbNext;
        private Button button1;
        private PictureBox PictureProduct;
        private Label label6;
        private Label label12;
        private Label label11;
        private DateTimePicker dateDateImport;
        private Label label10;
        private DateTimePicker dateEXP;
        private ComboBox cbStatus;
        private Label label9;
        private DateTimePicker dateMFG;
        private Label label3;
        private ComboBox cbTypeProduct;
        private Label label5;
        private TextBox txtNameProduct;
        private Panel panel1;
        private Label label1;
        private ComboBox cbIdSupplier;
        private Label label4;
        private TextBox txtPathPic;
    }
}