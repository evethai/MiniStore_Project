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
            dgvVoucher = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            voucherBindingSource3 = new BindingSource(components);
            voucherBindingSource2 = new BindingSource(components);
            voucherBindingSource1 = new BindingSource(components);
            voucherBindingSource = new BindingSource(components);
            button1 = new Button();
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
            pnVoucher = new Panel();
            lbName = new Label();
            lbPrice = new Label();
            lbDate = new Label();
            pbVoucher = new PictureBox();
            txtSearch = new TextBox();
            btSearch = new Button();
            rdExpired = new RadioButton();
            rdInUse = new RadioButton();
            lbAnnou = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).BeginInit();
            pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).BeginInit();
            pnVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoucher).BeginInit();
            SuspendLayout();
            // 
            // dgvVoucher
            // 
            dgvVoucher.AutoGenerateColumns = false;
            dgvVoucher.BackgroundColor = Color.White;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvVoucher.DataSource = voucherBindingSource3;
            dgvVoucher.Location = new Point(12, 159);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(212, 382);
            dgvVoucher.TabIndex = 0;
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
            // voucherBindingSource3
            // 
            voucherBindingSource3.DataSource = typeof(Repository.Models.Voucher);
            // 
            // button1
            // 
            button1.Location = new Point(242, 484);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 1;
            button1.Text = "New Voucher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            pnShow.Location = new Point(242, 182);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(702, 296);
            pnShow.TabIndex = 2;
            pnShow.Visible = false;
            pnShow.Click += pnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 197);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 15;
            label3.Text = "Condition";
            // 
            // numCondition
            // 
            numCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCondition.Location = new Point(145, 197);
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
            btUpdate.Location = new Point(536, 181);
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
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(145, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 34);
            txtPrice.TabIndex = 9;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(145, 93);
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
            label2.Location = new Point(64, 93);
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
            // pnVoucher
            // 
            pnVoucher.Controls.Add(lbName);
            pnVoucher.Controls.Add(lbPrice);
            pnVoucher.Controls.Add(lbDate);
            pnVoucher.Controls.Add(pbVoucher);
            pnVoucher.Location = new Point(242, 182);
            pnVoucher.Name = "pnVoucher";
            pnVoucher.Size = new Size(792, 296);
            pnVoucher.TabIndex = 24;
            pnVoucher.Click += pnVoucher_Click;
            pnVoucher.DoubleClick += pnVoucher_DoubleClick;
            // 
            // lbName
            // 
            lbName.BackColor = Color.Azure;
            lbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.DarkSlateGray;
            lbName.Location = new Point(136, 175);
            lbName.Name = "lbName";
            lbName.Size = new Size(278, 40);
            lbName.TabIndex = 22;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            lbPrice.BackColor = Color.FromArgb(0, 192, 192);
            lbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.ForeColor = Color.DarkSlateGray;
            lbPrice.Location = new Point(579, 146);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(175, 69);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            lbPrice.Click += label10_Click;
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.Azure;
            lbDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDate.ForeColor = Color.DarkSlateGray;
            lbDate.Location = new Point(228, 223);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(91, 38);
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
            pbVoucher.Size = new Size(792, 296);
            pbVoucher.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoucher.TabIndex = 19;
            pbVoucher.TabStop = false;
            pbVoucher.Click += pbVoucher_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(242, 518);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(136, 27);
            txtSearch.TabIndex = 15;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(384, 517);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(136, 29);
            btSearch.TabIndex = 16;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // rdExpired
            // 
            rdExpired.AutoSize = true;
            rdExpired.Location = new Point(98, 129);
            rdExpired.Name = "rdExpired";
            rdExpired.Size = new Size(80, 24);
            rdExpired.TabIndex = 17;
            rdExpired.TabStop = true;
            rdExpired.Text = "Expired";
            rdExpired.UseVisualStyleBackColor = true;
            rdExpired.CheckedChanged += rdExpired_CheckedChanged;
            // 
            // rdInUse
            // 
            rdInUse.AutoSize = true;
            rdInUse.Location = new Point(12, 129);
            rdInUse.Name = "rdInUse";
            rdInUse.Size = new Size(70, 24);
            rdInUse.TabIndex = 18;
            rdInUse.TabStop = true;
            rdInUse.Text = "In Use";
            rdInUse.UseVisualStyleBackColor = true;
            rdInUse.CheckedChanged += rdInUse_CheckedChanged;
            // 
            // lbAnnou
            // 
            lbAnnou.AutoSize = true;
            lbAnnou.Location = new Point(242, 159);
            lbAnnou.Name = "lbAnnou";
            lbAnnou.Size = new Size(206, 20);
            lbAnnou.TabIndex = 23;
            lbAnnou.Text = "*Click to see detail of voucher";
            lbAnnou.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 45);
            label10.Name = "label10";
            label10.Size = new Size(360, 46);
            label10.TabIndex = 25;
            label10.Text = "Voucher of MiniStore";
            // 
            // frmShowVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1054, 611);
            Controls.Add(label10);
            Controls.Add(pnVoucher);
            Controls.Add(lbAnnou);
            Controls.Add(rdInUse);
            Controls.Add(pnShow);
            Controls.Add(rdExpired);
            Controls.Add(btSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(dgvVoucher);
            Name = "frmShowVoucher";
            Text = "Voucher";
            Load += frmShowVoucher_Load;
            DoubleClick += frmShowVoucher_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).EndInit();
            pnShow.ResumeLayout(false);
            pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCondition).EndInit();
            pnVoucher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVoucher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVoucher;
        private BindingSource voucherBindingSource;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private BindingSource voucherBindingSource1;
        private BindingSource voucherBindingSource2;
        private Panel pnShow;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtID;
        private Label label6;
        private Button btUpdate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtName;
        private DateTimePicker dpkEXP;
        private TextBox txtSearch;
        private Button btSearch;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private RadioButton rdExpired;
        private RadioButton rdInUse;
        private PictureBox pbVoucher;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource voucherBindingSource3;
        public Label lbPrice;
        public Label lbDate;
        public Label lbName;
        private Label lbAnnou;
        private Panel pnVoucher;
        private Label label10;
        private Label label3;
        private NumericUpDown numCondition;
    }
}