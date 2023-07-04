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
            groupBox1 = new GroupBox();
            btClear = new Button();
            btLoad = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            txtNoteSupplier = new TextBox();
            txtAdressSupplier = new TextBox();
            txtNameSupplier = new TextBox();
            txtIDSupplier = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            supplierBindingSource = new BindingSource(components);
            idSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressSupplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.720993F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.27901F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1129, 595);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btClear);
            groupBox1.Controls.Add(btLoad);
            groupBox1.Controls.Add(btUpdate);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(txtNoteSupplier);
            groupBox1.Controls.Add(txtAdressSupplier);
            groupBox1.Controls.Add(txtNameSupplier);
            groupBox1.Controls.Add(txtIDSupplier);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 589);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Of Supplier";
            // 
            // btClear
            // 
            btClear.BackColor = Color.FromArgb(255, 128, 0);
            btClear.ForeColor = SystemColors.ControlLightLight;
            btClear.Location = new Point(78, 338);
            btClear.Name = "btClear";
            btClear.Size = new Size(96, 32);
            btClear.TabIndex = 11;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btLoad
            // 
            btLoad.BackColor = Color.FromArgb(255, 128, 0);
            btLoad.ForeColor = SystemColors.ControlLightLight;
            btLoad.Location = new Point(230, 338);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(96, 32);
            btLoad.TabIndex = 10;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = false;
            btLoad.Click += btLoad_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btUpdate.ForeColor = SystemColors.ControlLightLight;
            btUpdate.Location = new Point(230, 266);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(96, 32);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(255, 128, 0);
            btAdd.ForeColor = SystemColors.ControlLightLight;
            btAdd.Location = new Point(78, 266);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(96, 32);
            btAdd.TabIndex = 8;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // txtNoteSupplier
            // 
            txtNoteSupplier.Location = new Point(105, 208);
            txtNoteSupplier.Name = "txtNoteSupplier";
            txtNoteSupplier.Size = new Size(272, 27);
            txtNoteSupplier.TabIndex = 7;
            // 
            // txtAdressSupplier
            // 
            txtAdressSupplier.Location = new Point(105, 152);
            txtAdressSupplier.Name = "txtAdressSupplier";
            txtAdressSupplier.Size = new Size(272, 27);
            txtAdressSupplier.TabIndex = 6;
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new Point(105, 104);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(272, 27);
            txtNameSupplier.TabIndex = 5;
            // 
            // txtIDSupplier
            // 
            txtIDSupplier.Location = new Point(105, 56);
            txtIDSupplier.Name = "txtIDSupplier";
            txtIDSupplier.Size = new Size(272, 27);
            txtIDSupplier.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 208);
            label4.Name = "label4";
            label4.Size = new Size(64, 31);
            label4.TabIndex = 3;
            label4.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 152);
            label3.Name = "label3";
            label3.Size = new Size(97, 31);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 96);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 56);
            label1.Name = "label1";
            label1.Size = new Size(36, 31);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(395, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(731, 589);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Of Supplier";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idSupplierDataGridViewTextBoxColumn, nameSupplierDataGridViewTextBoxColumn, addressSupplierDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn });
            dataGridView1.DataSource = supplierBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(725, 563);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Repository.Models.Supplier);
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
            // ManageSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 636);
            Controls.Add(tableLayoutPanel1);
            Name = "ManageSupplier";
            Text = "ManageSupplier";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtNoteSupplier;
        private TextBox txtAdressSupplier;
        private TextBox txtNameSupplier;
        private TextBox txtIDSupplier;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource supplierBindingSource;
        private GroupBox groupBox2;
        private Button btLoad;
        private Button btUpdate;
        private Button btAdd;
        private Button btClear;
        private DataGridViewTextBoxColumn idSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressSupplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}