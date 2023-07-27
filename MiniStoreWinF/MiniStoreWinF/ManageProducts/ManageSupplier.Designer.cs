namespace MiniStoreWinF.ManageProducts
{
    partial class ManageSupplier
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            idSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            btSearch = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.720993F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 442F));
            tableLayoutPanel1.Size = new Size(940, 506);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(3, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 436);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Of Supplier";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idSupplierDataGridViewTextBoxColumn, nameSupplierDataGridViewTextBoxColumn, addressSupplierDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn });
            dataGridView1.DataSource = supplierBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(928, 412);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idSupplierDataGridViewTextBoxColumn
            // 
            idSupplierDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idSupplierDataGridViewTextBoxColumn.DataPropertyName = "IdSupplier";
            idSupplierDataGridViewTextBoxColumn.HeaderText = "IdSupplier";
            idSupplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            idSupplierDataGridViewTextBoxColumn.Name = "idSupplierDataGridViewTextBoxColumn";
            // 
            // nameSupplierDataGridViewTextBoxColumn
            // 
            nameSupplierDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameSupplierDataGridViewTextBoxColumn.DataPropertyName = "NameSupplier";
            nameSupplierDataGridViewTextBoxColumn.HeaderText = "NameSupplier";
            nameSupplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameSupplierDataGridViewTextBoxColumn.Name = "nameSupplierDataGridViewTextBoxColumn";
            // 
            // addressSupplierDataGridViewTextBoxColumn
            // 
            addressSupplierDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressSupplierDataGridViewTextBoxColumn.DataPropertyName = "AddressSupplier";
            addressSupplierDataGridViewTextBoxColumn.HeaderText = "AddressSupplier";
            addressSupplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressSupplierDataGridViewTextBoxColumn.Name = "addressSupplierDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Note";
            noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Repository.Models.Supplier);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 58);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operation";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(79, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 25);
            txtSearch.TabIndex = 37;
            // 
            // btSearch
            // 
            btSearch.BackColor = SystemColors.ButtonShadow;
            btSearch.ForeColor = SystemColors.ActiveCaptionText;
            btSearch.Location = new Point(209, 24);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(84, 25);
            btSearch.TabIndex = 36;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // ManageSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(953, 541);
            Controls.Add(tableLayoutPanel1);
            Name = "ManageSupplier";
            Text = "ManageSupplier";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private BindingSource supplierBindingSource;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn idSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Button btSearch;
    }
}