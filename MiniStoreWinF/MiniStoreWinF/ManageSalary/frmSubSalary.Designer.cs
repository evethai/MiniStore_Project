namespace MiniStoreWinF.ManageSalary
{
    partial class frmSubSalary
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
            groupBox1 = new GroupBox();
            dgvTotalSub = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDetailSubSalaryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subSalaryBindingSource = new BindingSource(components);
            txtTotal = new TextBox();
            btTotal = new Button();
            cbName = new ComboBox();
            btShow = new Button();
            dtpList = new DateTimePicker();
            groupBox2 = new GroupBox();
            txtSaveID = new Label();
            btEdit = new Button();
            dgvSub = new DataGridView();
            idDetailSubSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subsidiesSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailSubSalaryBindingSource = new BindingSource(components);
            btAdd = new Button();
            nmPaging = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nmPaging);
            groupBox1.Controls.Add(dgvTotalSub);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(btTotal);
            groupBox1.Controls.Add(cbName);
            groupBox1.Controls.Add(btShow);
            groupBox1.Controls.Add(dtpList);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information about employees salary allowance";
            // 
            // dgvTotalSub
            // 
            dgvTotalSub.AutoGenerateColumns = false;
            dgvTotalSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalSub.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, idEmpDataGridViewTextBoxColumn, idDetailSubSalaryDataGridViewTextBoxColumn1, timeDataGridViewTextBoxColumn });
            dgvTotalSub.DataSource = subSalaryBindingSource;
            dgvTotalSub.Location = new Point(34, 61);
            dgvTotalSub.Name = "dgvTotalSub";
            dgvTotalSub.RowTemplate.Height = 27;
            dgvTotalSub.Size = new Size(416, 150);
            dgvTotalSub.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSubSalary";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            // 
            // idDetailSubSalaryDataGridViewTextBoxColumn1
            // 
            idDetailSubSalaryDataGridViewTextBoxColumn1.DataPropertyName = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn1.HeaderText = "Id Detail ";
            idDetailSubSalaryDataGridViewTextBoxColumn1.Name = "idDetailSubSalaryDataGridViewTextBoxColumn1";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // subSalaryBindingSource
            // 
            subSalaryBindingSource.DataSource = typeof(Repository.Models.SubSalary);
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(589, 186);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 25);
            txtTotal.TabIndex = 5;
            // 
            // btTotal
            // 
            btTotal.Location = new Point(483, 186);
            btTotal.Name = "btTotal";
            btTotal.Size = new Size(100, 25);
            btTotal.TabIndex = 4;
            btTotal.Text = "Total in Month";
            btTotal.UseVisualStyleBackColor = true;
            btTotal.Click += btTotal_Click;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(483, 72);
            cbName.Name = "cbName";
            cbName.Size = new Size(158, 25);
            cbName.TabIndex = 3;
            // 
            // btShow
            // 
            btShow.Location = new Point(705, 186);
            btShow.Name = "btShow";
            btShow.Size = new Size(100, 24);
            btShow.TabIndex = 2;
            btShow.Text = "View All";
            btShow.UseVisualStyleBackColor = true;
            btShow.Click += btShow_Click;
            // 
            // dtpList
            // 
            dtpList.CustomFormat = "MM/yyyy";
            dtpList.Format = DateTimePickerFormat.Custom;
            dtpList.Location = new Point(653, 72);
            dtpList.Name = "dtpList";
            dtpList.Size = new Size(158, 25);
            dtpList.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSaveID);
            groupBox2.Controls.Add(btEdit);
            groupBox2.Controls.Add(dgvSub);
            groupBox2.Controls.Add(btAdd);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(811, 236);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information salary allowance";
            // 
            // txtSaveID
            // 
            txtSaveID.AutoSize = true;
            txtSaveID.Location = new Point(214, 174);
            txtSaveID.Name = "txtSaveID";
            txtSaveID.Size = new Size(0, 17);
            txtSaveID.TabIndex = 6;
            txtSaveID.Visible = false;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(122, 168);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 3;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // dgvSub
            // 
            dgvSub.AutoGenerateColumns = false;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { idDetailSubSalaryDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn, subsidiesSalaryDataGridViewTextBoxColumn, conditionDataGridViewTextBoxColumn });
            dgvSub.DataSource = detailSubSalaryBindingSource;
            dgvSub.Location = new Point(34, 24);
            dgvSub.Name = "dgvSub";
            dgvSub.RowTemplate.Height = 27;
            dgvSub.Size = new Size(416, 138);
            dgvSub.TabIndex = 5;
            dgvSub.CellMouseClick += dgvSub_CellMouseClick;
            // 
            // idDetailSubSalaryDataGridViewTextBoxColumn
            // 
            idDetailSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn.HeaderText = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn.Name = "idDetailSubSalaryDataGridViewTextBoxColumn";
            // 
            // descriptionADataGridViewTextBoxColumn
            // 
            descriptionADataGridViewTextBoxColumn.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.HeaderText = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.Name = "descriptionADataGridViewTextBoxColumn";
            // 
            // subsidiesSalaryDataGridViewTextBoxColumn
            // 
            subsidiesSalaryDataGridViewTextBoxColumn.DataPropertyName = "SubsidiesSalary";
            subsidiesSalaryDataGridViewTextBoxColumn.HeaderText = "SubsidiesSalary";
            subsidiesSalaryDataGridViewTextBoxColumn.Name = "subsidiesSalaryDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // detailSubSalaryBindingSource
            // 
            detailSubSalaryBindingSource.DataSource = typeof(Repository.Models.DetailSubSalary);
            // 
            // btAdd
            // 
            btAdd.Location = new Point(34, 168);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add new";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // nmPaging
            // 
            nmPaging.Location = new Point(359, 217);
            nmPaging.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmPaging.Name = "nmPaging";
            nmPaging.Size = new Size(91, 25);
            nmPaging.TabIndex = 14;
            nmPaging.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmPaging.ValueChanged += nmPaging_ValueChanged;
            // 
            // frmSubSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 525);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSubSalary";
            Text = "frmSubSalary";
            Load += frmSubSalary_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmPaging).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btAdd;
        private Button btEdit;
        private DataGridView dgvSub;
        private DataGridViewTextBoxColumn descriptionSDataGridViewTextBoxColumn;
        private DateTimePicker dtpList;
        private Button btShow;
        private Label txtSaveID;
        private TextBox txtTotal;
        private Button btTotal;
        private ComboBox cbName;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDetailSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subsidiesSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private BindingSource detailSubSalaryBindingSource;
        private DataGridView dgvTotalSub;
        private BindingSource subSalaryBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDetailSubSalaryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private NumericUpDown nmPaging;
    }
}