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
            label10 = new Label();
            pnVoucher = new Panel();
            lbName = new Label();
            lbPrice = new Label();
            lbDate = new Label();
            pbVoucher = new PictureBox();
            rdInUse = new RadioButton();
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
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pnVoucher);
            panel1.Controls.Add(rdInUse);
            panel1.Controls.Add(pnShow);
            panel1.Controls.Add(rdExpired);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgvVoucher);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 690);
            panel1.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(308, 1);
            label10.Name = "label10";
            label10.Size = new Size(360, 46);
            label10.TabIndex = 35;
            label10.Text = "Voucher of MiniStore";
            // 
            // pnVoucher
            // 
            pnVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnVoucher.Controls.Add(lbName);
            pnVoucher.Controls.Add(lbPrice);
            pnVoucher.Controls.Add(lbDate);
            pnVoucher.Controls.Add(pbVoucher);
            pnVoucher.Location = new Point(308, 117);
            pnVoucher.Name = "pnVoucher";
            pnVoucher.Size = new Size(1010, 296);
            pnVoucher.TabIndex = 34;
            pnVoucher.Click += pnVoucher_Click;
            pnVoucher.DoubleClick += pnVoucher_Click;
            pnVoucher.MouseClick += pnVoucher_MouseClick;
            // 
            // lbName
            // 
            lbName.BackColor = Color.Azure;
            lbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.DarkSlateGray;
            lbName.Location = new Point(239, 175);
            lbName.Name = "lbName";
            lbName.Size = new Size(238, 40);
            lbName.TabIndex = 22;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            lbPrice.BackColor = Color.FromArgb(0, 192, 192);
            lbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.ForeColor = Color.DarkSlateGray;
            lbPrice.Location = new Point(742, 137);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(217, 69);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.Azure;
            lbDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDate.ForeColor = Color.DarkSlateGray;
            lbDate.Location = new Point(307, 215);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(91, 38);
            lbDate.TabIndex = 21;
            lbDate.Text = "Date";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbVoucher
            // 
            pbVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbVoucher.Image = (Image)resources.GetObject("pbVoucher.Image");
            pbVoucher.Location = new Point(3, 0);
            pbVoucher.Name = "pbVoucher";
            pbVoucher.Size = new Size(1007, 296);
            pbVoucher.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoucher.TabIndex = 19;
            pbVoucher.TabStop = false;
            pbVoucher.Click += pbVoucher_Click;
            // 
            // rdInUse
            // 
            rdInUse.Anchor = AnchorStyles.Left;
            rdInUse.AutoSize = true;
            rdInUse.Location = new Point(21, 23);
            rdInUse.Name = "rdInUse";
            rdInUse.Size = new Size(70, 24);
            rdInUse.TabIndex = 32;
            rdInUse.TabStop = true;
            rdInUse.Text = "In Use";
            rdInUse.UseVisualStyleBackColor = true;
            rdInUse.CheckedChanged += rdInUse_CheckedChanged;
            // 
            // pnShow
            // 
            pnShow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            pnShow.Location = new Point(312, 419);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(1010, 207);
            pnShow.TabIndex = 28;
            pnShow.Click += pnShow_Click;
            pnShow.MouseClick += pnShow_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 145);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 15;
            label3.Text = "Condition";
            // 
            // numCondition
            // 
            numCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCondition.Location = new Point(501, 145);
            numCondition.Name = "numCondition";
            numCondition.Size = new Size(149, 34);
            numCondition.TabIndex = 14;
            // 
            // dpkEXP
            // 
            dpkEXP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkEXP.Location = new Point(423, 96);
            dpkEXP.Name = "dpkEXP";
            dpkEXP.Size = new Size(227, 34);
            dpkEXP.TabIndex = 13;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btUpdate.Location = new Point(740, 140);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(118, 43);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(544, 30);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 34);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(145, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 34);
            txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(142, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 34);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(145, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(149, 34);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 94);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 5;
            label6.Text = "EXP Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(423, 36);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 147);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Voucher";
            // 
            // rdExpired
            // 
            rdExpired.Anchor = AnchorStyles.Left;
            rdExpired.AutoSize = true;
            rdExpired.Location = new Point(107, 23);
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
            btSearch.Location = new Point(454, 70);
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
            txtSearch.Location = new Point(311, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(136, 27);
            txtSearch.TabIndex = 29;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(598, 70);
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
            ClientSize = new Size(1334, 690);
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
    }
}