namespace MiniStoreWinF.Manage_Voucher
{
    partial class frmShowVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowVoucher));
            voucherBindingSource3 = new BindingSource(components);
            voucherBindingSource2 = new BindingSource(components);
            voucherBindingSource1 = new BindingSource(components);
            voucherBindingSource = new BindingSource(components);
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            txtSearch = new TextBox();
            btSearch = new Button();
            button1 = new Button();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnVoucher = new Panel();
            lbName = new Label();
            lbPrice = new Label();
            lbDate = new Label();
            pbVoucher = new PictureBox();
            pnShow = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            btUpdate = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtID = new TextBox();
            label1 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            txtPrice = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtName = new TextBox();
            label2 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            numCondition = new NumericUpDown();
            label3 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            label5 = new Label();
            txtQuantity = new TextBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            txtUsed = new TextBox();
            label7 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            txtLeft = new TextBox();
            label6 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            dpkEXP = new DateTimePicker();
            label8 = new Label();
            rdInUse = new RadioButton();
            rdExpired = new RadioButton();
            dgvVoucher = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoucher).BeginInit();
            pnShow.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // voucherBindingSource3
            // 
            voucherBindingSource3.DataSource = typeof(Repository.Models.Voucher);
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(343, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 715);
            panel1.TabIndex = 26;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Size = new Size(1014, 715);
            tableLayoutPanel4.TabIndex = 37;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1008, 137);
            panel4.TabIndex = 38;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(1008, 100);
            panel5.TabIndex = 36;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(btSearch);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(309, 100);
            panel6.TabIndex = 31;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(136, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(147, 25);
            txtSearch.TabIndex = 29;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Left;
            btSearch.ForeColor = SystemColors.ActiveCaptionText;
            btSearch.Image = (Image)resources.GetObject("btSearch.Image");
            btSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btSearch.Location = new Point(19, 33);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 25);
            btSearch.TabIndex = 30;
            btSearch.Text = "Search";
            btSearch.TextAlign = ContentAlignment.MiddleRight;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(875, 33);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 27;
            button1.Text = "New Voucher";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(1008, 37);
            label10.TabIndex = 35;
            label10.Text = "Voucher of MiniStore";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnVoucher, 0, 0);
            tableLayoutPanel1.Controls.Add(pnShow, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.18868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.81132F));
            tableLayoutPanel1.Size = new Size(1008, 566);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // pnVoucher
            // 
            pnVoucher.Controls.Add(lbName);
            pnVoucher.Controls.Add(lbPrice);
            pnVoucher.Controls.Add(lbDate);
            pnVoucher.Controls.Add(pbVoucher);
            pnVoucher.Dock = DockStyle.Fill;
            pnVoucher.Location = new Point(3, 3);
            pnVoucher.Name = "pnVoucher";
            pnVoucher.Size = new Size(1002, 278);
            pnVoucher.TabIndex = 34;
            pnVoucher.Click += pnVoucher_Click;
            pnVoucher.DoubleClick += pnVoucher_Click;
            pnVoucher.MouseClick += pnVoucher_MouseClick;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Right;
            lbName.BackColor = Color.Azure;
            lbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.DarkSlateGray;
            lbName.Location = new Point(430, 155);
            lbName.Name = "lbName";
            lbName.Size = new Size(186, 34);
            lbName.TabIndex = 22;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Right;
            lbPrice.BackColor = Color.FromArgb(0, 192, 192);
            lbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.ForeColor = Color.DarkSlateGray;
            lbPrice.Location = new Point(782, 132);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(174, 57);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Right;
            lbDate.BackColor = Color.Azure;
            lbDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDate.ForeColor = Color.DarkSlateGray;
            lbDate.Location = new Point(477, 196);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(87, 27);
            lbDate.TabIndex = 21;
            lbDate.Text = "Date";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbVoucher
            // 
            pbVoucher.Dock = DockStyle.Fill;
            pbVoucher.Image = (Image)resources.GetObject("pbVoucher.Image");
            pbVoucher.Location = new Point(0, 0);
            pbVoucher.Name = "pbVoucher";
            pbVoucher.Size = new Size(1002, 278);
            pbVoucher.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoucher.TabIndex = 19;
            pbVoucher.TabStop = false;
            pbVoucher.Click += pbVoucher_Click;
            // 
            // pnShow
            // 
            pnShow.BorderStyle = BorderStyle.Fixed3D;
            pnShow.Controls.Add(tableLayoutPanel7);
            pnShow.Dock = DockStyle.Fill;
            pnShow.Location = new Point(3, 287);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(1002, 276);
            pnShow.TabIndex = 28;
            pnShow.Click += pnShow_Click;
            pnShow.Paint += pnShow_Paint;
            pnShow.MouseClick += pnShow_MouseClick;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(btUpdate, 1, 4);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel12, 1, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel13, 1, 3);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel7.Size = new Size(998, 272);
            tableLayoutPanel7.TabIndex = 10;
            // 
            // btUpdate
            // 
            btUpdate.Anchor = AnchorStyles.Right;
            btUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btUpdate.Image = (Image)resources.GetObject("btUpdate.Image");
            btUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btUpdate.Location = new Point(892, 225);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(103, 37);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.TextAlign = ContentAlignment.MiddleRight;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(txtID, 1, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(493, 48);
            tableLayoutPanel5.TabIndex = 23;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Right;
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(297, 9);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 29);
            txtID.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "ID Voucher";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(txtPrice, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 57);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(493, 48);
            tableLayoutPanel6.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(199, 13);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Right;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(297, 9);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 29);
            txtPrice.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(txtName, 1, 0);
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 111);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(493, 48);
            tableLayoutPanel8.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(297, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 29);
            txtName.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 13);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(numCondition, 1, 0);
            tableLayoutPanel9.Controls.Add(label3, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 165);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(493, 48);
            tableLayoutPanel9.TabIndex = 26;
            // 
            // numCondition
            // 
            numCondition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            numCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCondition.Location = new Point(297, 3);
            numCondition.Name = "numCondition";
            numCondition.Size = new Size(193, 29);
            numCondition.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 13);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 15;
            label3.Text = "Condition";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(txtQuantity, 1, 0);
            tableLayoutPanel10.Controls.Add(label5, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(502, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(493, 48);
            tableLayoutPanel10.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(173, 13);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Right;
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(297, 9);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 29);
            txtQuantity.TabIndex = 10;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(txtUsed, 1, 0);
            tableLayoutPanel11.Controls.Add(label7, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(502, 57);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(493, 48);
            tableLayoutPanel11.TabIndex = 28;
            // 
            // txtUsed
            // 
            txtUsed.Anchor = AnchorStyles.Right;
            txtUsed.Enabled = false;
            txtUsed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsed.Location = new Point(297, 9);
            txtUsed.Name = "txtUsed";
            txtUsed.Size = new Size(193, 29);
            txtUsed.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(198, 13);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 16;
            label7.Text = "Used";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(txtLeft, 1, 0);
            tableLayoutPanel12.Controls.Add(label6, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(502, 111);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(493, 48);
            tableLayoutPanel12.TabIndex = 29;
            // 
            // txtLeft
            // 
            txtLeft.Anchor = AnchorStyles.Right;
            txtLeft.Enabled = false;
            txtLeft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLeft.Location = new Point(297, 9);
            txtLeft.Name = "txtLeft";
            txtLeft.Size = new Size(193, 29);
            txtLeft.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(207, 13);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 20;
            label6.Text = "Left";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(dpkEXP, 1, 0);
            tableLayoutPanel13.Controls.Add(label8, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(502, 165);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(493, 48);
            tableLayoutPanel13.TabIndex = 30;
            // 
            // dpkEXP
            // 
            dpkEXP.Anchor = AnchorStyles.Right;
            dpkEXP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkEXP.Location = new Point(297, 9);
            dpkEXP.Name = "dpkEXP";
            dpkEXP.Size = new Size(193, 29);
            dpkEXP.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(171, 13);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 21;
            label8.Text = "EXP Date";
            // 
            // rdInUse
            // 
            rdInUse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdInUse.AutoSize = true;
            rdInUse.Location = new Point(6, 100);
            rdInUse.Name = "rdInUse";
            rdInUse.Size = new Size(62, 21);
            rdInUse.TabIndex = 32;
            rdInUse.TabStop = true;
            rdInUse.Text = "In Use";
            rdInUse.UseVisualStyleBackColor = true;
            rdInUse.CheckedChanged += rdInUse_CheckedChanged;
            // 
            // rdExpired
            // 
            rdExpired.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdExpired.AutoSize = true;
            rdExpired.Location = new Point(74, 100);
            rdExpired.Name = "rdExpired";
            rdExpired.Size = new Size(70, 21);
            rdExpired.TabIndex = 31;
            rdExpired.TabStop = true;
            rdExpired.Text = "Expired";
            rdExpired.UseVisualStyleBackColor = true;
            rdExpired.CheckedChanged += rdExpired_CheckedChanged;
            // 
            // dgvVoucher
            // 
            dgvVoucher.AutoGenerateColumns = false;
            dgvVoucher.BackgroundColor = Color.White;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvVoucher.DataSource = voucherBindingSource3;
            dgvVoucher.Dock = DockStyle.Fill;
            dgvVoucher.Location = new Point(3, 146);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(328, 566);
            dgvVoucher.TabIndex = 26;
            dgvVoucher.CellDoubleClick += dgvVoucher_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 715);
            panel2.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvVoucher, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Size = new Size(334, 715);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.Controls.Add(rdInUse);
            panel3.Controls.Add(rdExpired);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 137);
            panel3.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1360, 721);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // frmShowVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1360, 721);
            Controls.Add(tableLayoutPanel2);
            Name = "frmShowVoucher";
            Text = "Voucher";
            Load += frmShowVoucher_Load;
            DoubleClick += frmShowVoucher_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnVoucher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVoucher).EndInit();
            pnShow.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource voucherBindingSource;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private BindingSource voucherBindingSource1;
        private BindingSource voucherBindingSource2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource voucherBindingSource3;
        private Panel panel1;
        private Label label10;
        private Panel pnVoucher;
        public Label lbName;
        public Label lbPrice;
        public Label lbDate;
        private PictureBox pbVoucher;
        private RadioButton rdInUse;
        private Panel pnShow;
        private Button btUpdate;
        private RadioButton rdExpired;
        private Button btSearch;
        private TextBox txtSearch;
        private Button button1;
        private DataGridView dgvVoucher;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private TextBox txtQuantity;
        private TextBox txtLeft;
        private DateTimePicker dpkEXP;
        private Label label7;
        private TextBox txtUsed;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPrice;
        private NumericUpDown numCondition;
        private Label label6;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
    }
}