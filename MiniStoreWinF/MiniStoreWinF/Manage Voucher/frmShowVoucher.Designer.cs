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
            dgvVoucher = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            voucherBindingSource2 = new BindingSource(components);
            voucherBindingSource1 = new BindingSource(components);
            voucherBindingSource = new BindingSource(components);
            button1 = new Button();
            pnShow = new Panel();
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
            numAddCondition = new NumericUpDown();
            label3 = new Label();
            pnAdd = new Panel();
            dpkNewDate = new DateTimePicker();
            btAdd = new Button();
            txtNewQuantity = new TextBox();
            txtNewPrice = new TextBox();
            txtAddName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtSearch = new TextBox();
            btSearch = new Button();
            rdExpired = new RadioButton();
            rdInUse = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).BeginInit();
            pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddCondition).BeginInit();
            pnAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVoucher
            // 
            dgvVoucher.AutoGenerateColumns = false;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            dgvVoucher.DataSource = voucherBindingSource2;
            dgvVoucher.Location = new Point(12, 37);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(212, 283);
            dgvVoucher.TabIndex = 0;
            dgvVoucher.CellDoubleClick += dgvVoucher_CellDoubleClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // voucherBindingSource2
            // 
            voucherBindingSource2.DataSource = typeof(Repository.Models.Voucher);
            // 
            // voucherBindingSource1
            // 
            voucherBindingSource1.DataSource = typeof(Repository.Models.Voucher);
            // 
            // voucherBindingSource
            // 
            voucherBindingSource.DataSource = typeof(Repository.Models.Voucher);
            // 
            // button1
            // 
            button1.Location = new Point(256, 104);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 1;
            button1.Text = "New Voucher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnShow
            // 
            pnShow.BorderStyle = BorderStyle.Fixed3D;
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
            pnShow.Location = new Point(372, 37);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(595, 214);
            pnShow.TabIndex = 2;
            // 
            // dpkEXP
            // 
            dpkEXP.Location = new Point(375, 88);
            dpkEXP.Name = "dpkEXP";
            dpkEXP.Size = new Size(203, 27);
            dpkEXP.TabIndex = 13;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(494, 178);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(375, 33);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(86, 27);
            txtQuantity.TabIndex = 10;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 91);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "EXP Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 33);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 147);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 93);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Voucher";
            // 
            // numAddCondition
            // 
            numAddCondition.Location = new Point(108, 143);
            numAddCondition.Name = "numAddCondition";
            numAddCondition.Size = new Size(103, 27);
            numAddCondition.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 14;
            label3.Text = "Condition";
            // 
            // pnAdd
            // 
            pnAdd.BorderStyle = BorderStyle.Fixed3D;
            pnAdd.Controls.Add(numAddCondition);
            pnAdd.Controls.Add(label3);
            pnAdd.Controls.Add(dpkNewDate);
            pnAdd.Controls.Add(btAdd);
            pnAdd.Controls.Add(txtNewQuantity);
            pnAdd.Controls.Add(txtNewPrice);
            pnAdd.Controls.Add(txtAddName);
            pnAdd.Controls.Add(label7);
            pnAdd.Controls.Add(label8);
            pnAdd.Controls.Add(label9);
            pnAdd.Controls.Add(label11);
            pnAdd.Location = new Point(372, 281);
            pnAdd.Name = "pnAdd";
            pnAdd.Size = new Size(595, 195);
            pnAdd.TabIndex = 14;
            pnAdd.Visible = false;
            // 
            // dpkNewDate
            // 
            dpkNewDate.Location = new Point(375, 88);
            dpkNewDate.Name = "dpkNewDate";
            dpkNewDate.Size = new Size(203, 27);
            dpkNewDate.TabIndex = 13;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(494, 159);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 12;
            btAdd.Text = "Create";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // txtNewQuantity
            // 
            txtNewQuantity.Location = new Point(375, 33);
            txtNewQuantity.Name = "txtNewQuantity";
            txtNewQuantity.Size = new Size(86, 27);
            txtNewQuantity.TabIndex = 10;
            txtNewQuantity.KeyPress += txtNewQuantity_KeyPress;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(108, 91);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(125, 27);
            txtNewPrice.TabIndex = 9;
            txtNewPrice.KeyPress += txtNewPrice_KeyPress;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(108, 33);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(125, 27);
            txtAddName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 91);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 5;
            label7.Text = "EXP Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(292, 33);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 4;
            label8.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 91);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 3;
            label9.Text = "Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 40);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 1;
            label11.Text = "Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(230, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(136, 27);
            txtSearch.TabIndex = 15;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(256, 69);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(110, 29);
            btSearch.TabIndex = 16;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // rdExpired
            // 
            rdExpired.AutoSize = true;
            rdExpired.Location = new Point(110, 7);
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
            rdInUse.Location = new Point(12, 7);
            rdInUse.Name = "rdInUse";
            rdInUse.Size = new Size(70, 24);
            rdInUse.TabIndex = 18;
            rdInUse.TabStop = true;
            rdInUse.Text = "In Use";
            rdInUse.UseVisualStyleBackColor = true;
            rdInUse.CheckedChanged += rdInUse_CheckedChanged;
            // 
            // frmShowVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(979, 527);
            Controls.Add(rdInUse);
            Controls.Add(rdExpired);
            Controls.Add(btSearch);
            Controls.Add(txtSearch);
            Controls.Add(pnAdd);
            Controls.Add(pnShow);
            Controls.Add(button1);
            Controls.Add(dgvVoucher);
            Name = "frmShowVoucher";
            Text = "Voucher";
            Load += frmShowVoucher_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)voucherBindingSource).EndInit();
            pnShow.ResumeLayout(false);
            pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddCondition).EndInit();
            pnAdd.ResumeLayout(false);
            pnAdd.PerformLayout();
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
        private Panel pnAdd;
        private DateTimePicker dpkNewDate;
        private Button btAdd;
        private TextBox txtNewQuantity;
        private TextBox txtNewPrice;
        private TextBox txtAddName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox txtSearch;
        private Button btSearch;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private RadioButton rdExpired;
        private RadioButton rdInUse;
        private NumericUpDown numAddCondition;
        private Label label3;
    }
}