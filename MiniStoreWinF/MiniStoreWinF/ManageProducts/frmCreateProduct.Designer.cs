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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateProduct));
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 69);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 580);
            panel3.TabIndex = 4;
            // 
            // txtPathPic
            // 
            txtPathPic.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPathPic.Location = new Point(504, 549);
            txtPathPic.Margin = new Padding(5, 4, 5, 4);
            txtPathPic.Name = "txtPathPic";
            txtPathPic.Size = new Size(112, 21);
            txtPathPic.TabIndex = 39;
            txtPathPic.Visible = false;
            // 
            // cbIdSupplier
            // 
            cbIdSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIdSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdSupplier.FormattingEnabled = true;
            cbIdSupplier.Location = new Point(226, 117);
            cbIdSupplier.Margin = new Padding(5, 4, 5, 4);
            cbIdSupplier.Name = "cbIdSupplier";
            cbIdSupplier.Size = new Size(172, 33);
            cbIdSupplier.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 125);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 38;
            label4.Text = "ID Supplier";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(226, 512);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 40);
            button1.TabIndex = 36;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PictureProduct
            // 
            PictureProduct.BackColor = SystemColors.Info;
            PictureProduct.Location = new Point(226, 392);
            PictureProduct.Margin = new Padding(5, 4, 5, 4);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(184, 112);
            PictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProduct.TabIndex = 35;
            PictureProduct.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 392);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 34;
            label6.Text = "Picture";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(52, 344);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 33;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(52, 288);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 31;
            label11.Text = "Date Import";
            // 
            // dateDateImport
            // 
            dateDateImport.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateDateImport.Location = new Point(226, 280);
            dateDateImport.Margin = new Padding(5, 4, 5, 4);
            dateDateImport.Name = "dateDateImport";
            dateDateImport.Size = new Size(303, 33);
            dateDateImport.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(52, 234);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 25);
            label10.TabIndex = 29;
            label10.Text = "EXP";
            // 
            // dateEXP
            // 
            dateEXP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateEXP.Location = new Point(226, 226);
            dateEXP.Margin = new Padding(5, 4, 5, 4);
            dateEXP.Name = "dateEXP";
            dateEXP.Size = new Size(303, 33);
            dateEXP.TabIndex = 28;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Availability", "Sold Out" });
            cbStatus.Location = new Point(226, 336);
            cbStatus.Margin = new Padding(5, 4, 5, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(183, 33);
            cbStatus.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(52, 178);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 27;
            label9.Text = "MFG";
            // 
            // dateMFG
            // 
            dateMFG.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateMFG.Location = new Point(226, 170);
            dateMFG.Margin = new Padding(5, 4, 5, 4);
            dateMFG.Name = "dateMFG";
            dateMFG.Size = new Size(303, 33);
            dateMFG.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 24);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // cbTypeProduct
            // 
            cbTypeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeProduct.FormattingEnabled = true;
            cbTypeProduct.Location = new Point(226, 16);
            cbTypeProduct.Margin = new Padding(5, 4, 5, 4);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(158, 33);
            cbTypeProduct.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 69);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // txtNameProduct
            // 
            txtNameProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameProduct.Location = new Point(226, 61);
            txtNameProduct.Margin = new Padding(5, 4, 5, 4);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(287, 33);
            txtNameProduct.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 57);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 13);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 32);
            label1.TabIndex = 0;
            label1.Text = "Information Of Product";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(636, 653);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // frmCreateProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(652, 692);
            MinimumSize = new Size(652, 692);
            Name = "frmCreateProduct";
            Text = "Create product";
            FormClosed += frmCreateProduct_FormClosed;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}