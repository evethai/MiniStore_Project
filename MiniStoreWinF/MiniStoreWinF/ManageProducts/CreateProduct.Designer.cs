namespace MiniStoreWinF.ManageProducts
{
    partial class CreateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProduct));
            panel1 = new Panel();
            label1 = new Label();
            panelUnit = new Panel();
            labelInfor = new Label();
            panel3 = new Panel();
            pbNext = new PictureBox();
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
            label4 = new Label();
            cbIdSupplier = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panelInForUnit = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label13 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btClose = new Button();
            btAddNew = new Button();
            panelSupplier = new Panel();
            label14 = new Label();
            panalIdSupplier = new Panel();
            btConfirm = new Button();
            label17 = new Label();
            txtNoteSupplier = new TextBox();
            label16 = new Label();
            txtAddressSupplier = new TextBox();
            label15 = new Label();
            txtNameSupplier = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            panelUnit.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            panelInForUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelSupplier.SuspendLayout();
            panalIdSupplier.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 10);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Information Of Product";
            // 
            // panelUnit
            // 
            panelUnit.BorderStyle = BorderStyle.FixedSingle;
            panelUnit.Controls.Add(labelInfor);
            panelUnit.Location = new Point(449, 11);
            panelUnit.Name = "panelUnit";
            panelUnit.Size = new Size(351, 41);
            panelUnit.TabIndex = 1;
            // 
            // labelInfor
            // 
            labelInfor.AutoSize = true;
            labelInfor.Location = new Point(112, 11);
            labelInfor.Name = "labelInfor";
            labelInfor.Size = new Size(138, 20);
            labelInfor.TabIndex = 0;
            labelInfor.Text = "Information Of Unit";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pbNext);
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
            panel3.Location = new Point(12, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 484);
            panel3.TabIndex = 2;
            // 
            // pbNext
            // 
            pbNext.Image = (Image)resources.GetObject("pbNext.Image");
            pbNext.Location = new Point(341, 442);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(74, 37);
            pbNext.SizeMode = PictureBoxSizeMode.Zoom;
            pbNext.TabIndex = 37;
            pbNext.TabStop = false;
            pbNext.Click += pbNext_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(140, 375);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 36;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            // 
            // PictureProduct
            // 
            PictureProduct.BackColor = SystemColors.Info;
            PictureProduct.Location = new Point(140, 256);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(134, 113);
            PictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProduct.TabIndex = 35;
            PictureProduct.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 256);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 34;
            label6.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(19, 214);
            label12.Name = "label12";
            label12.Size = new Size(43, 17);
            label12.TabIndex = 33;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(19, 174);
            label11.Name = "label11";
            label11.Size = new Size(78, 17);
            label11.TabIndex = 31;
            label11.Text = "Date Import";
            // 
            // dateDateImport
            // 
            dateDateImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDateImport.Location = new Point(140, 169);
            dateDateImport.Name = "dateDateImport";
            dateDateImport.Size = new Size(249, 25);
            dateDateImport.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 134);
            label10.Name = "label10";
            label10.Size = new Size(30, 17);
            label10.TabIndex = 29;
            label10.Text = "EXP";
            // 
            // dateEXP
            // 
            dateEXP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEXP.Location = new Point(140, 128);
            dateEXP.Name = "dateEXP";
            dateEXP.Size = new Size(249, 25);
            dateEXP.TabIndex = 28;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Availability", "Sold Out" });
            cbStatus.Location = new Point(140, 211);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(134, 25);
            cbStatus.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 94);
            label9.Name = "label9";
            label9.Size = new Size(35, 17);
            label9.TabIndex = 27;
            label9.Text = "MFG";
            // 
            // dateMFG
            // 
            dateMFG.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateMFG.Location = new Point(140, 88);
            dateMFG.Name = "dateMFG";
            dateMFG.Size = new Size(249, 25);
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
            cbTypeProduct.Location = new Point(140, 9);
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
            txtNameProduct.Location = new Point(140, 49);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(210, 25);
            txtNameProduct.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 13;
            label4.Text = "ID Supplier";
            // 
            // cbIdSupplier
            // 
            cbIdSupplier.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdSupplier.FormattingEnabled = true;
            cbIdSupplier.Location = new Point(112, 10);
            cbIdSupplier.Name = "cbIdSupplier";
            cbIdSupplier.Size = new Size(126, 25);
            cbIdSupplier.TabIndex = 12;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // panelInForUnit
            // 
            panelInForUnit.BorderStyle = BorderStyle.FixedSingle;
            panelInForUnit.Controls.Add(textBox3);
            panelInForUnit.Controls.Add(textBox2);
            panelInForUnit.Controls.Add(label13);
            panelInForUnit.Controls.Add(label8);
            panelInForUnit.Controls.Add(numericUpDown1);
            panelInForUnit.Controls.Add(label7);
            panelInForUnit.Controls.Add(label2);
            panelInForUnit.Controls.Add(textBox1);
            panelInForUnit.Location = new Point(449, 58);
            panelInForUnit.Name = "panelInForUnit";
            panelInForUnit.Size = new Size(351, 195);
            panelInForUnit.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(112, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 25);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(112, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 25);
            textBox2.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(15, 132);
            label13.Name = "label13";
            label13.Size = new Size(78, 17);
            label13.TabIndex = 15;
            label13.Text = "Price Export";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 93);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 14;
            label8.Text = "Price Import";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(112, 48);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 27);
            numericUpDown1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 52);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 11;
            label2.Text = "Name Unit";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(112, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 25);
            textBox1.TabIndex = 10;
            // 
            // btClose
            // 
            btClose.Location = new Point(606, 561);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 12;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(706, 560);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(94, 29);
            btAddNew.TabIndex = 11;
            btAddNew.Text = "Add";
            btAddNew.UseVisualStyleBackColor = true;
            // 
            // panelSupplier
            // 
            panelSupplier.BorderStyle = BorderStyle.FixedSingle;
            panelSupplier.Controls.Add(label14);
            panelSupplier.Location = new Point(449, 259);
            panelSupplier.Name = "panelSupplier";
            panelSupplier.Size = new Size(351, 41);
            panelSupplier.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(102, 11);
            label14.Name = "label14";
            label14.Size = new Size(166, 20);
            label14.TabIndex = 0;
            label14.Text = "Information Of Supplier";
            // 
            // panalIdSupplier
            // 
            panalIdSupplier.BorderStyle = BorderStyle.FixedSingle;
            panalIdSupplier.Controls.Add(btConfirm);
            panalIdSupplier.Controls.Add(label17);
            panalIdSupplier.Controls.Add(txtNoteSupplier);
            panalIdSupplier.Controls.Add(label16);
            panalIdSupplier.Controls.Add(txtAddressSupplier);
            panalIdSupplier.Controls.Add(label15);
            panalIdSupplier.Controls.Add(txtNameSupplier);
            panalIdSupplier.Controls.Add(button2);
            panalIdSupplier.Controls.Add(cbIdSupplier);
            panalIdSupplier.Controls.Add(label4);
            panalIdSupplier.Location = new Point(450, 306);
            panalIdSupplier.Name = "panalIdSupplier";
            panalIdSupplier.Size = new Size(350, 237);
            panalIdSupplier.TabIndex = 14;
            // 
            // btConfirm
            // 
            btConfirm.Location = new Point(144, 197);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(94, 29);
            btConfirm.TabIndex = 21;
            btConfirm.Text = "Confirm";
            btConfirm.UseVisualStyleBackColor = true;
            btConfirm.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(15, 134);
            label17.Name = "label17";
            label17.Size = new Size(37, 17);
            label17.TabIndex = 20;
            label17.Text = "Note";
            label17.Visible = false;
            // 
            // txtNoteSupplier
            // 
            txtNoteSupplier.Location = new Point(112, 129);
            txtNoteSupplier.Multiline = true;
            txtNoteSupplier.Name = "txtNoteSupplier";
            txtNoteSupplier.Size = new Size(126, 62);
            txtNoteSupplier.TabIndex = 19;
            txtNoteSupplier.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(15, 101);
            label16.Name = "label16";
            label16.Size = new Size(56, 17);
            label16.TabIndex = 18;
            label16.Text = "Address";
            label16.Visible = false;
            // 
            // txtAddressSupplier
            // 
            txtAddressSupplier.Location = new Point(112, 96);
            txtAddressSupplier.Name = "txtAddressSupplier";
            txtAddressSupplier.Size = new Size(126, 27);
            txtAddressSupplier.TabIndex = 17;
            txtAddressSupplier.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(15, 68);
            label15.Name = "label15";
            label15.Size = new Size(95, 17);
            label15.TabIndex = 16;
            label15.Text = "Name Supplier";
            label15.Visible = false;
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new Point(112, 63);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(126, 27);
            txtNameSupplier.TabIndex = 15;
            txtNameSupplier.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(244, 8);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(812, 604);
            Controls.Add(panalIdSupplier);
            Controls.Add(panelSupplier);
            Controls.Add(btClose);
            Controls.Add(btAddNew);
            Controls.Add(panelInForUnit);
            Controls.Add(panel3);
            Controls.Add(panelUnit);
            Controls.Add(panel1);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelUnit.ResumeLayout(false);
            panelUnit.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).EndInit();
            panelInForUnit.ResumeLayout(false);
            panelInForUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelSupplier.ResumeLayout(false);
            panelSupplier.PerformLayout();
            panalIdSupplier.ResumeLayout(false);
            panalIdSupplier.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelUnit;
        private Label labelInfor;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private ComboBox cbTypeProduct;
        private ComboBox cbIdSupplier;
        private Label label5;
        private TextBox txtNameProduct;
        private Label label12;
        private Label label11;
        private DateTimePicker dateDateImport;
        private Label label10;
        private DateTimePicker dateEXP;
        private ComboBox cbStatus;
        private Label label9;
        private DateTimePicker dateMFG;
        private Label label6;
        private PictureBox PictureProduct;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private PictureBox pbNext;
        private Panel panelInForUnit;
        private Button btClose;
        private Button btAddNew;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label13;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Panel panelSupplier;
        private Label label14;
        private Panel panalIdSupplier;
        private Button btConfirm;
        private Label label17;
        private TextBox txtNoteSupplier;
        private Label label16;
        private TextBox txtAddressSupplier;
        private Label label15;
        private TextBox txtNameSupplier;
        private Button button2;
    }
}