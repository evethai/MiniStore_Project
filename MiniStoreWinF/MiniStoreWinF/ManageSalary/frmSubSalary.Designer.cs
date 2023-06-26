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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubSalary));
            dgvTotalSub = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDetailSubSalaryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subSalaryBindingSource = new BindingSource(components);
            txtTotal = new TextBox();
            btTotal = new Button();
            cbName = new ComboBox();
            dtpList = new DateTimePicker();
            groupBox2 = new GroupBox();
            dgvSub = new DataGridView();
            detailSubSalaryBindingSource = new BindingSource(components);
            txtSaveID = new Label();
            btEdit = new Button();
            btAdd = new Button();
            groupBox5 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dgvAdv = new DataGridView();
            detailAdvanceSalaryBindingSource = new BindingSource(components);
            btAddnew_Adv = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            idDetailSubSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subsidiesSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idAdvanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateAsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            advanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTotalSub
            // 
            dgvTotalSub.AutoGenerateColumns = false;
            dgvTotalSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTotalSub.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTotalSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalSub.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, idEmpDataGridViewTextBoxColumn, idDetailSubSalaryDataGridViewTextBoxColumn1, timeDataGridViewTextBoxColumn });
            dgvTotalSub.DataSource = subSalaryBindingSource;
            dgvTotalSub.GridColor = SystemColors.ButtonHighlight;
            dgvTotalSub.Location = new Point(10, 28);
            dgvTotalSub.Margin = new Padding(4, 3, 4, 3);
            dgvTotalSub.Name = "dgvTotalSub";
            dgvTotalSub.RowTemplate.Height = 27;
            dgvTotalSub.Size = new Size(442, 242);
            dgvTotalSub.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSubSalary";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 120;
            // 
            // idDetailSubSalaryDataGridViewTextBoxColumn1
            // 
            idDetailSubSalaryDataGridViewTextBoxColumn1.DataPropertyName = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn1.HeaderText = "Id Detail ";
            idDetailSubSalaryDataGridViewTextBoxColumn1.Name = "idDetailSubSalaryDataGridViewTextBoxColumn1";
            idDetailSubSalaryDataGridViewTextBoxColumn1.Width = 96;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 69;
            // 
            // subSalaryBindingSource
            // 
            subSalaryBindingSource.DataSource = typeof(Repository.Models.SubSalary);
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(203, 298);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(360, 29);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "Total allowance salary in month";
            // 
            // btTotal
            // 
            btTotal.Location = new Point(425, 26);
            btTotal.Margin = new Padding(4, 3, 4, 3);
            btTotal.Name = "btTotal";
            btTotal.Size = new Size(158, 31);
            btTotal.TabIndex = 4;
            btTotal.Text = "Search by name";
            btTotal.UseVisualStyleBackColor = true;
            btTotal.Click += btTotal_Click;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(222, 28);
            cbName.Margin = new Padding(4, 3, 4, 3);
            cbName.Name = "cbName";
            cbName.Size = new Size(163, 29);
            cbName.TabIndex = 3;
            // 
            // dtpList
            // 
            dtpList.CustomFormat = "MM/yyyy";
            dtpList.Format = DateTimePickerFormat.Custom;
            dtpList.Location = new Point(25, 28);
            dtpList.Margin = new Padding(4, 3, 4, 3);
            dtpList.Name = "dtpList";
            dtpList.Size = new Size(158, 29);
            dtpList.TabIndex = 1;
            dtpList.ValueChanged += dtpList_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSub);
            groupBox2.Controls.Add(txtSaveID);
            groupBox2.Controls.Add(btEdit);
            groupBox2.Controls.Add(btAdd);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(679, 345);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information salary allowance";
            // 
            // dgvSub
            // 
            dgvSub.AutoGenerateColumns = false;
            dgvSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSub.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { idDetailSubSalaryDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn, subsidiesSalaryDataGridViewTextBoxColumn, conditionDataGridViewTextBoxColumn });
            dgvSub.DataSource = detailSubSalaryBindingSource;
            dgvSub.Location = new Point(4, 37);
            dgvSub.Margin = new Padding(4, 3, 4, 3);
            dgvSub.Name = "dgvSub";
            dgvSub.RowTemplate.Height = 27;
            dgvSub.Size = new Size(513, 236);
            dgvSub.TabIndex = 5;
            dgvSub.CellMouseClick += dgvSub_CellMouseClick;
            // 
            // detailSubSalaryBindingSource
            // 
            detailSubSalaryBindingSource.DataSource = typeof(Repository.Models.DetailSubSalary);
            // 
            // txtSaveID
            // 
            txtSaveID.AutoSize = true;
            txtSaveID.Location = new Point(275, 215);
            txtSaveID.Margin = new Padding(4, 0, 4, 0);
            txtSaveID.Name = "txtSaveID";
            txtSaveID.Size = new Size(0, 21);
            txtSaveID.TabIndex = 6;
            txtSaveID.Visible = false;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(420, 280);
            btEdit.Margin = new Padding(4, 3, 4, 3);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(97, 29);
            btEdit.TabIndex = 3;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(315, 280);
            btAdd.Margin = new Padding(4, 3, 4, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(97, 29);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add new";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numericUpDown1);
            groupBox5.Controls.Add(dgvTotalSub);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(679, 344);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Information about employees salary allowance";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(397, 276);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 29);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += nmPaging_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpList);
            groupBox3.Controls.Add(btTotal);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(cbName);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(679, 344);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvAdv);
            groupBox4.Controls.Add(btAddnew_Adv);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(679, 345);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "List of employees with advance salary";
            // 
            // dgvAdv
            // 
            dgvAdv.AutoGenerateColumns = false;
            dgvAdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAdv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdv.Columns.AddRange(new DataGridViewColumn[] { idAdvanceSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn1, dateAsDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn1, advanceSalaryDataGridViewTextBoxColumn });
            dgvAdv.DataSource = detailAdvanceSalaryBindingSource;
            dgvAdv.Location = new Point(17, 37);
            dgvAdv.Margin = new Padding(4, 3, 4, 3);
            dgvAdv.Name = "dgvAdv";
            dgvAdv.RowTemplate.Height = 27;
            dgvAdv.Size = new Size(576, 236);
            dgvAdv.TabIndex = 1;
            // 
            // detailAdvanceSalaryBindingSource
            // 
            detailAdvanceSalaryBindingSource.DataSource = typeof(Repository.Models.DetailAdvanceSalary);
            // 
            // btAddnew_Adv
            // 
            btAddnew_Adv.Location = new Point(17, 279);
            btAddnew_Adv.Margin = new Padding(4, 3, 4, 3);
            btAddnew_Adv.Name = "btAddnew_Adv";
            btAddnew_Adv.Size = new Size(80, 29);
            btAddnew_Adv.TabIndex = 3;
            btAddnew_Adv.Text = "Add new ";
            btAddnew_Adv.UseVisualStyleBackColor = true;
            btAddnew_Adv.Click += btAddnew_Adv_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1412, 743);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(groupBox5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Margin = new Padding(3, 3, 20, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(683, 348);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(709, 3);
            panel4.Margin = new Padding(3, 3, 20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 348);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(709, 374);
            panel5.Margin = new Padding(3, 3, 20, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(683, 349);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(groupBox2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 374);
            panel6.Margin = new Padding(3, 3, 20, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(683, 349);
            panel6.TabIndex = 4;
            // 
            // idDetailSubSalaryDataGridViewTextBoxColumn
            // 
            idDetailSubSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn.HeaderText = "ID";
            idDetailSubSalaryDataGridViewTextBoxColumn.Name = "idDetailSubSalaryDataGridViewTextBoxColumn";
            idDetailSubSalaryDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionADataGridViewTextBoxColumn
            // 
            descriptionADataGridViewTextBoxColumn.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.HeaderText = "Description / note";
            descriptionADataGridViewTextBoxColumn.Name = "descriptionADataGridViewTextBoxColumn";
            descriptionADataGridViewTextBoxColumn.Width = 117;
            // 
            // subsidiesSalaryDataGridViewTextBoxColumn
            // 
            subsidiesSalaryDataGridViewTextBoxColumn.DataPropertyName = "SubsidiesSalary";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            subsidiesSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            subsidiesSalaryDataGridViewTextBoxColumn.HeaderText = "Subsidies Salary";
            subsidiesSalaryDataGridViewTextBoxColumn.Name = "subsidiesSalaryDataGridViewTextBoxColumn";
            subsidiesSalaryDataGridViewTextBoxColumn.Width = 135;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            conditionDataGridViewTextBoxColumn.HeaderText = "Condition (shifts)";
            conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            conditionDataGridViewTextBoxColumn.Width = 141;
            // 
            // idAdvanceSalaryDataGridViewTextBoxColumn
            // 
            idAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdAdvanceSalary";
            idAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "ID";
            idAdvanceSalaryDataGridViewTextBoxColumn.Name = "idAdvanceSalaryDataGridViewTextBoxColumn";
            idAdvanceSalaryDataGridViewTextBoxColumn.Width = 50;
            // 
            // idEmpDataGridViewTextBoxColumn1
            // 
            idEmpDataGridViewTextBoxColumn1.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn1.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn1.Name = "idEmpDataGridViewTextBoxColumn1";
            idEmpDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dateAsDataGridViewTextBoxColumn
            // 
            dateAsDataGridViewTextBoxColumn.DataPropertyName = "DateAs";
            dateAsDataGridViewTextBoxColumn.HeaderText = "Date";
            dateAsDataGridViewTextBoxColumn.Name = "dateAsDataGridViewTextBoxColumn";
            dateAsDataGridViewTextBoxColumn.Width = 67;
            // 
            // descriptionADataGridViewTextBoxColumn1
            // 
            descriptionADataGridViewTextBoxColumn1.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn1.HeaderText = "Description/note";
            descriptionADataGridViewTextBoxColumn1.Name = "descriptionADataGridViewTextBoxColumn1";
            descriptionADataGridViewTextBoxColumn1.Width = 151;
            // 
            // advanceSalaryDataGridViewTextBoxColumn
            // 
            advanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "AdvanceSalary";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            advanceSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            advanceSalaryDataGridViewTextBoxColumn.HeaderText = "Money";
            advanceSalaryDataGridViewTextBoxColumn.Name = "advanceSalaryDataGridViewTextBoxColumn";
            advanceSalaryDataGridViewTextBoxColumn.Width = 83;
            // 
            // frmSubSalary
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1412, 743);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSubSalary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSubSalary";
            Load += frmSubSalary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
        private Label txtSaveID;
        private TextBox txtTotal;
        private Button btTotal;
        private ComboBox cbName;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private BindingSource detailSubSalaryBindingSource;
        private BindingSource subSalaryBindingSource;
        private NumericUpDown nmPaging;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTotalSub;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDetailSubSalaryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridView dgvAdv;
        private BindingSource detailAdvanceSalaryBindingSource;
        private Button btAddnew_Adv;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private DataGridViewTextBoxColumn idDetailSubSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subsidiesSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAdvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn advanceSalaryDataGridViewTextBoxColumn;
    }
}