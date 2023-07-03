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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnVoucher = new Panel();
            lbName = new Label();
            lbPrice = new Label();
            lbDate = new Label();
            pbVoucher = new PictureBox();
            pnShow = new Panel();
            label3 = new Label();
            numCondition = new NumericUpDown();
            dpkEXP = new DateTimePicker();
            btUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            rdInUse = new RadioButton();
            rdExpired = new RadioButton();
            btSearch = new Button();
            txtSearch = new TextBox();
            button1 = new Button();
            dgvVoucher = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoucher).BeginInit();
            pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            SuspendLayout();
            // 
            // voucherBindingSource3
            // 
            voucherBindingSource3.DataSource = typeof(Repository.Models.Voucher);
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(rdInUse);
            panel1.Controls.Add(rdExpired);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgvVoucher);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 690);
            panel1.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnVoucher, 0, 0);
            tableLayoutPanel1.Controls.Add(pnShow, 0, 1);
            tableLayoutPanel1.Location = new Point(239, 96);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.18868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.81132F));
            tableLayoutPanel1.Size = new Size(847, 530);
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
            pnVoucher.Size = new Size(841, 260);
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
            lbName.Location = new Point(188, 148);
            lbName.Name = "lbName";
            lbName.Size = new Size(213, 40);
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
            lbPrice.Location = new Point(590, 121);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(199, 67);
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
            lbDate.Location = new Point(241, 197);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(99, 32);
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
            pbVoucher.Size = new Size(841, 260);
            pbVoucher.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoucher.TabIndex = 19;
            pbVoucher.TabStop = false;
            pbVoucher.Click += pbVoucher_Click;
            // 
            // pnShow
            // 
            pnShow.BorderStyle = BorderStyle.Fixed3D;
            pnShow.Controls.Add(label3);
            pnShow.Controls.Add(numCondition);
            pnShow.Controls.Add(dpkEXP);
            pnShow.Controls.Add(btUpdate);
            pnShow.Controls.Add(txtQuantity);
            pnShow.Controls.Add(txtPrice);
            pnShow.Controls.Add(txtName);
            pnShow.Controls.Add(txtID);
            pnShow.Controls.Add(label6);
            pnShow.Controls.Add(label5);
            pnShow.Controls.Add(label4);
            pnShow.Controls.Add(label2);
            pnShow.Controls.Add(label1);
            pnShow.Dock = DockStyle.Fill;
            pnShow.Location = new Point(3, 269);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(841, 258);
            pnShow.TabIndex = 28;
            pnShow.Click += pnShow_Click;
            pnShow.Paint += pnShow_Paint;
            pnShow.MouseClick += pnShow_MouseClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(467, 135);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 15;
            label3.Text = "Condition";
            // 
            // numCondition
            // 
            numCondition.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCondition.Location = new Point(588, 133);
            numCondition.Name = "numCondition";
            numCondition.Size = new Size(149, 34);
            numCondition.TabIndex = 14;
            // 
            // dpkEXP
            // 
            dpkEXP.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dpkEXP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkEXP.Location = new Point(588, 79);
            dpkEXP.Name = "dpkEXP";
            dpkEXP.Size = new Size(227, 34);
            dpkEXP.TabIndex = 13;
            // 
            // btUpdate
            // 
            btUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btUpdate.Location = new Point(716, 208);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(118, 43);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(588, 18);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 34);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(189, 132);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 34);
            txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(186, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 34);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(189, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(149, 34);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(464, 82);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 5;
            label6.Text = "EXP Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(467, 24);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 135);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 76);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Voucher";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(708, 37);
            label10.Name = "label10";
            label10.Size = new Size(360, 46);
            label10.TabIndex = 35;
            label10.Text = "Voucher of MiniStore";
            // 
            // rdInUse
            // 
            rdInUse.Anchor = AnchorStyles.Left;
            rdInUse.AutoSize = true;
            rdInUse.Location = new Point(30, 19);
            rdInUse.Name = "rdInUse";
            rdInUse.Size = new Size(70, 24);
            rdInUse.TabIndex = 32;
            rdInUse.TabStop = true;
            rdInUse.Text = "In Use";
            rdInUse.UseVisualStyleBackColor = true;
            rdInUse.CheckedChanged += rdInUse_CheckedChanged;
            // 
            // rdExpired
            // 
            rdExpired.Anchor = AnchorStyles.Left;
            rdExpired.AutoSize = true;
            rdExpired.Location = new Point(116, 19);
            rdExpired.Name = "rdExpired";
            rdExpired.Size = new Size(80, 24);
            rdExpired.TabIndex = 31;
            rdExpired.TabStop = true;
            rdExpired.Text = "Expired";
            rdExpired.UseVisualStyleBackColor = true;
            rdExpired.CheckedChanged += rdExpired_CheckedChanged;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Left;
            btSearch.Location = new Point(408, 53);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(136, 29);
            btSearch.TabIndex = 30;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(258, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(136, 27);
            txtSearch.TabIndex = 29;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(550, 56);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 27;
            button1.Text = "New Voucher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvVoucher
            // 
            dgvVoucher.Anchor = AnchorStyles.Left;
            dgvVoucher.AutoGenerateColumns = false;
            dgvVoucher.BackgroundColor = Color.White;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvVoucher.DataSource = voucherBindingSource3;
            dgvVoucher.Location = new Point(21, 53);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(212, 573);
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
            // frmShowVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1096, 690);
            Controls.Add(panel1);
            Name = "frmShowVoucher";
            Text = "Voucher";
            Load += frmShowVoucher_Load;
            DoubleClick += frmShowVoucher_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnVoucher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVoucher).EndInit();
            pnShow.ResumeLayout(false);
            pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
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
        private Label label3;
        private NumericUpDown numCondition;
        private DateTimePicker dpkEXP;
        private Button btUpdate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private RadioButton rdExpired;
        private Button btSearch;
        private TextBox txtSearch;
        private Button button1;
        private DataGridView dgvVoucher;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}