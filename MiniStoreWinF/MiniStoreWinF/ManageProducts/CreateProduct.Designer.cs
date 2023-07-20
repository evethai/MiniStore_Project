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
            panel1.Location = new Point(16, 14);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 0;
            label1.Text = "Information Of Product";
            // 
            // panelUnit
            // 
            panelUnit.BorderStyle = BorderStyle.FixedSingle;
            panelUnit.Controls.Add(labelInfor);
            panelUnit.Location = new Point(617, 13);
            panelUnit.Margin = new Padding(5, 5, 5, 5);
            panelUnit.Name = "panelUnit";
            panelUnit.Size = new Size(481, 51);
            panelUnit.TabIndex = 1;
            // 
            // labelInfor
            // 
            labelInfor.AutoSize = true;
            labelInfor.Location = new Point(154, 13);
            labelInfor.Margin = new Padding(5, 0, 5, 0);
            labelInfor.Name = "labelInfor";
            labelInfor.Size = new Size(176, 25);
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
            panel3.Location = new Point(16, 74);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 604);
            panel3.TabIndex = 2;
            // 
            // pbNext
            // 
            pbNext.Image = (Image)resources.GetObject("pbNext.Image");
            pbNext.Location = new Point(468, 552);
            pbNext.Margin = new Padding(5, 5, 5, 5);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(103, 45);
            pbNext.SizeMode = PictureBoxSizeMode.Zoom;
            pbNext.TabIndex = 37;
            pbNext.TabStop = false;
            pbNext.Click += pbNext_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(192, 469);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(183, 39);
            button1.TabIndex = 36;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            // 
            // PictureProduct
            // 
            PictureProduct.BackColor = SystemColors.Info;
            PictureProduct.Location = new Point(192, 320);
            PictureProduct.Margin = new Padding(5, 5, 5, 5);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(183, 142);
            PictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProduct.TabIndex = 35;
            PictureProduct.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 320);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 13);
            label6.TabIndex = 34;
            label6.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(27, 268);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 13);
            label12.TabIndex = 33;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(27, 218);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(68, 13);
            label11.TabIndex = 31;
            label11.Text = "Date Import";
            // 
            // dateDateImport
            // 
            dateDateImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDateImport.Location = new Point(192, 212);
            dateDateImport.Margin = new Padding(5, 5, 5, 5);
            dateDateImport.Name = "dateDateImport";
            dateDateImport.Size = new Size(340, 21);
            dateDateImport.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(27, 168);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(25, 13);
            label10.TabIndex = 29;
            label10.Text = "EXP";
            // 
            // dateEXP
            // 
            dateEXP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEXP.Location = new Point(192, 161);
            dateEXP.Margin = new Padding(5, 5, 5, 5);
            dateEXP.Name = "dateEXP";
            dateEXP.Size = new Size(340, 21);
            dateEXP.TabIndex = 28;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Availability", "Sold Out" });
            cbStatus.Location = new Point(192, 263);
            cbStatus.Margin = new Padding(5, 5, 5, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(184, 20);
            cbStatus.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(27, 118);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(31, 13);
            label9.TabIndex = 27;
            label9.Text = "MFG";
            // 
            // dateMFG
            // 
            dateMFG.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateMFG.Location = new Point(192, 111);
            dateMFG.Margin = new Padding(5, 5, 5, 5);
            dateMFG.Name = "dateMFG";
            dateMFG.Size = new Size(340, 21);
            dateMFG.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 19);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // cbTypeProduct
            // 
            cbTypeProduct.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeProduct.FormattingEnabled = true;
            cbTypeProduct.Location = new Point(192, 12);
            cbTypeProduct.Margin = new Padding(5, 5, 5, 5);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(158, 20);
            cbTypeProduct.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 69);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 13);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // txtNameProduct
            // 
            txtNameProduct.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameProduct.Location = new Point(192, 62);
            txtNameProduct.Margin = new Padding(5, 5, 5, 5);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(286, 21);
            txtNameProduct.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 18);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 13);
            label4.TabIndex = 13;
            label4.Text = "ID Supplier";
            // 
            // cbIdSupplier
            // 
            cbIdSupplier.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdSupplier.FormattingEnabled = true;
            cbIdSupplier.Location = new Point(154, 12);
            cbIdSupplier.Margin = new Padding(5, 5, 5, 5);
            cbIdSupplier.Name = "cbIdSupplier";
            cbIdSupplier.Size = new Size(173, 20);
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
            panelInForUnit.Location = new Point(617, 73);
            panelInForUnit.Margin = new Padding(5, 5, 5, 5);
            panelInForUnit.Name = "panelInForUnit";
            panelInForUnit.Size = new Size(481, 244);
            panelInForUnit.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(154, 162);
            textBox3.Margin = new Padding(5, 5, 5, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 21);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(154, 111);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 21);
            textBox2.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(21, 164);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(67, 13);
            label13.TabIndex = 15;
            label13.Text = "Price Export";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 117);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 13);
            label8.TabIndex = 14;
            label8.Text = "Price Import";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(154, 61);
            numericUpDown1.Margin = new Padding(5, 5, 5, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 33);
            numericUpDown1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 64);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 13);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 18);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 11;
            label2.Text = "Name Unit";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(154, 12);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 21);
            textBox1.TabIndex = 10;
            // 
            // btClose
            // 
            btClose.Location = new Point(832, 701);
            btClose.Margin = new Padding(5, 5, 5, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 37);
            btClose.TabIndex = 12;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(972, 700);
            btAddNew.Margin = new Padding(5, 5, 5, 5);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(128, 37);
            btAddNew.TabIndex = 11;
            btAddNew.Text = "Add";
            btAddNew.UseVisualStyleBackColor = true;
            // 
            // panelSupplier
            // 
            panelSupplier.BorderStyle = BorderStyle.FixedSingle;
            panelSupplier.Controls.Add(label14);
            panelSupplier.Location = new Point(617, 324);
            panelSupplier.Margin = new Padding(5, 5, 5, 5);
            panelSupplier.Name = "panelSupplier";
            panelSupplier.Size = new Size(481, 51);
            panelSupplier.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(139, 13);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(211, 25);
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
            panalIdSupplier.Location = new Point(620, 382);
            panalIdSupplier.Margin = new Padding(5, 5, 5, 5);
            panalIdSupplier.Name = "panalIdSupplier";
            panalIdSupplier.Size = new Size(480, 296);
            panalIdSupplier.TabIndex = 14;
            // 
            // btConfirm
            // 
            btConfirm.Location = new Point(198, 245);
            btConfirm.Margin = new Padding(5, 5, 5, 5);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(128, 37);
            btConfirm.TabIndex = 21;
            btConfirm.Text = "Confirm";
            btConfirm.UseVisualStyleBackColor = true;
            btConfirm.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(21, 168);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(32, 13);
            label17.TabIndex = 20;
            label17.Text = "Note";
            label17.Visible = false;
            // 
            // txtNoteSupplier
            // 
            txtNoteSupplier.Location = new Point(154, 162);
            txtNoteSupplier.Margin = new Padding(5, 5, 5, 5);
            txtNoteSupplier.Multiline = true;
            txtNoteSupplier.Name = "txtNoteSupplier";
            txtNoteSupplier.Size = new Size(173, 77);
            txtNoteSupplier.TabIndex = 19;
            txtNoteSupplier.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(21, 126);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 13);
            label16.TabIndex = 18;
            label16.Text = "Address";
            label16.Visible = false;
            // 
            // txtAddressSupplier
            // 
            txtAddressSupplier.Location = new Point(154, 120);
            txtAddressSupplier.Margin = new Padding(5, 5, 5, 5);
            txtAddressSupplier.Name = "txtAddressSupplier";
            txtAddressSupplier.Size = new Size(173, 33);
            txtAddressSupplier.TabIndex = 17;
            txtAddressSupplier.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(21, 86);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(82, 13);
            label15.TabIndex = 16;
            label15.Text = "Name Supplier";
            label15.Visible = false;
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new Point(154, 80);
            txtNameSupplier.Margin = new Padding(5, 5, 5, 5);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(173, 33);
            txtNameSupplier.TabIndex = 15;
            txtNameSupplier.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(336, 11);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(128, 37);
            button2.TabIndex = 14;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 755);
            Controls.Add(panalIdSupplier);
            Controls.Add(panelSupplier);
            Controls.Add(btClose);
            Controls.Add(btAddNew);
            Controls.Add(panelInForUnit);
            Controls.Add(panel3);
            Controls.Add(panelUnit);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1132, 794);
            MinimumSize = new Size(1132, 794);
            Name = "CreateProduct";
            Text = "Create product";
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