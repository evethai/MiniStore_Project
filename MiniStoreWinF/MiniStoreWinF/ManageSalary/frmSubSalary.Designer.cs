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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubSalary));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            subSalaryBindingSource = new BindingSource(components);
            txtTotal = new TextBox();
            cbName = new ComboBox();
            dtpList = new DateTimePicker();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvSub = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dateCreateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateEffectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailSubSalaryBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btEdit = new Button();
            txtSaveID = new Label();
            btAdd = new Button();
            groupBox5 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvTotalSub = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            idDetailSubSalaryDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            numericUpDown1 = new NumericUpDown();
            detailAdvanceSalaryBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            panel7 = new Panel();
            cbOrderby = new ComboBox();
            btFilter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvAdv = new DataGridView();
            idAdvanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateAsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            advanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btAddnew_Adv = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).BeginInit();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdv).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // subSalaryBindingSource
            // 
            subSalaryBindingSource.DataSource = typeof(Repository.Models.SubSalary);
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(227, 15);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(158, 29);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "0";
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(4, 20);
            cbName.Margin = new Padding(4, 3, 4, 3);
            cbName.Name = "cbName";
            cbName.Size = new Size(158, 29);
            cbName.TabIndex = 3;
            // 
            // dtpList
            // 
            dtpList.CustomFormat = "MM/yyyy";
            dtpList.Format = DateTimePickerFormat.Custom;
            dtpList.Location = new Point(187, 20);
            dtpList.Margin = new Padding(4, 3, 4, 3);
            dtpList.Name = "dtpList";
            dtpList.Size = new Size(101, 29);
            dtpList.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(850, 345);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information salary allowance";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgvSub, 0, 0);
            tableLayoutPanel3.Controls.Add(panel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(842, 317);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // dgvSub
            // 
            dgvSub.AutoGenerateColumns = false;
            dgvSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSub.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSub.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSub.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dateCreateDataGridViewTextBoxColumn, dateEffectDataGridViewTextBoxColumn });
            dgvSub.DataSource = detailSubSalaryBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSub.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSub.Dock = DockStyle.Fill;
            dgvSub.Location = new Point(4, 3);
            dgvSub.Margin = new Padding(4, 3, 4, 3);
            dgvSub.Name = "dgvSub";
            dgvSub.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 20, 20);
            dgvSub.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSub.RowTemplate.Height = 27;
            dgvSub.Size = new Size(834, 279);
            dgvSub.TabIndex = 7;
            dgvSub.CellMouseClick += dgvSub_CellMouseClick_1;
            dgvSub.RowPrePaint += dgvSub_RowPrePaint;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "IdDetailSubSalary";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "DescriptionA";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "SubsidiesSalary";
            dataGridViewTextBoxColumn4.HeaderText = "Amount";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Condition";
            dataGridViewTextBoxColumn5.HeaderText = "Condition(number of sheet)";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            dateCreateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            dateCreateDataGridViewTextBoxColumn.HeaderText = "Date create";
            dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            dateCreateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEffectDataGridViewTextBoxColumn
            // 
            dateEffectDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateEffectDataGridViewTextBoxColumn.DataPropertyName = "DateEffect";
            dateEffectDataGridViewTextBoxColumn.HeaderText = "Date effect";
            dateEffectDataGridViewTextBoxColumn.Name = "dateEffectDataGridViewTextBoxColumn";
            dateEffectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailSubSalaryBindingSource
            // 
            detailSubSalaryBindingSource.DataSource = typeof(Repository.Models.DetailSubSalary);
            // 
            // panel2
            // 
            panel2.Controls.Add(btEdit);
            panel2.Controls.Add(txtSaveID);
            panel2.Controls.Add(btAdd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 26);
            panel2.TabIndex = 8;
            // 
            // btEdit
            // 
            btEdit.Dock = DockStyle.Right;
            btEdit.Location = new Point(678, 0);
            btEdit.Margin = new Padding(4, 3, 4, 3);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(158, 26);
            btEdit.TabIndex = 3;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // txtSaveID
            // 
            txtSaveID.AutoSize = true;
            txtSaveID.Location = new Point(279, 0);
            txtSaveID.Margin = new Padding(4, 0, 4, 0);
            txtSaveID.Name = "txtSaveID";
            txtSaveID.Size = new Size(0, 21);
            txtSaveID.TabIndex = 6;
            txtSaveID.Visible = false;
            // 
            // btAdd
            // 
            btAdd.Dock = DockStyle.Left;
            btAdd.Location = new Point(0, 0);
            btAdd.Margin = new Padding(4, 3, 4, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(143, 26);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add new";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel2);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(850, 344);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Information about employees salary allowance";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvTotalSub, 0, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(844, 316);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // dgvTotalSub
            // 
            dgvTotalSub.AutoGenerateColumns = false;
            dgvTotalSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTotalSub.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTotalSub.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTotalSub.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 30, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTotalSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTotalSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalSub.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, idEmpDataGridViewTextBoxColumn2, idDetailSubSalaryDataGridViewTextBoxColumn2, timeDataGridViewTextBoxColumn1 });
            dgvTotalSub.DataSource = subSalaryBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTotalSub.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTotalSub.Dock = DockStyle.Fill;
            dgvTotalSub.Location = new Point(4, 3);
            dgvTotalSub.Margin = new Padding(4, 3, 4, 3);
            dgvTotalSub.Name = "dgvTotalSub";
            dgvTotalSub.ReadOnly = true;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 20, 20);
            dgvTotalSub.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvTotalSub.RowTemplate.Height = 27;
            dgvTotalSub.Size = new Size(836, 278);
            dgvTotalSub.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "IdSubSalary";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // idEmpDataGridViewTextBoxColumn2
            // 
            idEmpDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idEmpDataGridViewTextBoxColumn2.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn2.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn2.Name = "idEmpDataGridViewTextBoxColumn2";
            idEmpDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // idDetailSubSalaryDataGridViewTextBoxColumn2
            // 
            idDetailSubSalaryDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDetailSubSalaryDataGridViewTextBoxColumn2.DataPropertyName = "IdDetailSubSalary";
            idDetailSubSalaryDataGridViewTextBoxColumn2.HeaderText = "Id Detail";
            idDetailSubSalaryDataGridViewTextBoxColumn2.Name = "idDetailSubSalaryDataGridViewTextBoxColumn2";
            idDetailSubSalaryDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            timeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            timeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Right;
            numericUpDown1.Location = new Point(683, 287);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(158, 29);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += nmPaging_ValueChanged;
            // 
            // detailAdvanceSalaryBindingSource
            // 
            detailAdvanceSalaryBindingSource.DataSource = typeof(Repository.Models.DetailAdvanceSalary);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel7);
            groupBox3.Controls.Add(panel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(559, 344);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(cbOrderby);
            panel7.Controls.Add(btFilter);
            panel7.Controls.Add(dtpList);
            panel7.Controls.Add(cbName);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(553, 100);
            panel7.TabIndex = 23;
            // 
            // cbOrderby
            // 
            cbOrderby.FormattingEnabled = true;
            cbOrderby.Items.AddRange(new object[] { "Descending", "Ascending" });
            cbOrderby.Location = new Point(312, 20);
            cbOrderby.Name = "cbOrderby";
            cbOrderby.Size = new Size(128, 29);
            cbOrderby.TabIndex = 19;
            cbOrderby.Text = "Descending";
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(463, 20);
            btFilter.Margin = new Padding(4);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(71, 29);
            btFilter.TabIndex = 20;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 57);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 21;
            label1.Text = "Total allowance";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(559, 345);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "List of employees with advance salary";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvAdv, 0, 0);
            tableLayoutPanel4.Controls.Add(btAddnew_Adv, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 25);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(553, 317);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // dgvAdv
            // 
            dgvAdv.AutoGenerateColumns = false;
            dgvAdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAdv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdv.Columns.AddRange(new DataGridViewColumn[] { idAdvanceSalaryDataGridViewTextBoxColumn, idEmpDataGridViewTextBoxColumn1, dateAsDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn1, advanceSalaryDataGridViewTextBoxColumn });
            dgvAdv.DataSource = detailAdvanceSalaryBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvAdv.DefaultCellStyle = dataGridViewCellStyle7;
            dgvAdv.Dock = DockStyle.Fill;
            dgvAdv.Location = new Point(4, 3);
            dgvAdv.Margin = new Padding(4, 3, 4, 3);
            dgvAdv.Name = "dgvAdv";
            dgvAdv.ReadOnly = true;
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 20, 20);
            dgvAdv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvAdv.RowTemplate.Height = 27;
            dgvAdv.Size = new Size(545, 279);
            dgvAdv.TabIndex = 1;
            // 
            // idAdvanceSalaryDataGridViewTextBoxColumn
            // 
            idAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdAdvanceSalary";
            idAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "ID";
            idAdvanceSalaryDataGridViewTextBoxColumn.Name = "idAdvanceSalaryDataGridViewTextBoxColumn";
            idAdvanceSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            idAdvanceSalaryDataGridViewTextBoxColumn.Width = 70;
            // 
            // idEmpDataGridViewTextBoxColumn1
            // 
            idEmpDataGridViewTextBoxColumn1.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn1.HeaderText = "Id Employee";
            idEmpDataGridViewTextBoxColumn1.Name = "idEmpDataGridViewTextBoxColumn1";
            idEmpDataGridViewTextBoxColumn1.ReadOnly = true;
            idEmpDataGridViewTextBoxColumn1.Width = 140;
            // 
            // dateAsDataGridViewTextBoxColumn
            // 
            dateAsDataGridViewTextBoxColumn.DataPropertyName = "DateAs";
            dateAsDataGridViewTextBoxColumn.HeaderText = "Date";
            dateAsDataGridViewTextBoxColumn.Name = "dateAsDataGridViewTextBoxColumn";
            dateAsDataGridViewTextBoxColumn.ReadOnly = true;
            dateAsDataGridViewTextBoxColumn.Width = 87;
            // 
            // descriptionADataGridViewTextBoxColumn1
            // 
            descriptionADataGridViewTextBoxColumn1.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn1.HeaderText = "Description/note";
            descriptionADataGridViewTextBoxColumn1.Name = "descriptionADataGridViewTextBoxColumn1";
            descriptionADataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionADataGridViewTextBoxColumn1.Width = 171;
            // 
            // advanceSalaryDataGridViewTextBoxColumn
            // 
            advanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "AdvanceSalary";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            advanceSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            advanceSalaryDataGridViewTextBoxColumn.HeaderText = "Money";
            advanceSalaryDataGridViewTextBoxColumn.Name = "advanceSalaryDataGridViewTextBoxColumn";
            advanceSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            advanceSalaryDataGridViewTextBoxColumn.Width = 103;
            // 
            // btAddnew_Adv
            // 
            btAddnew_Adv.Dock = DockStyle.Right;
            btAddnew_Adv.Location = new Point(391, 288);
            btAddnew_Adv.Margin = new Padding(4, 3, 4, 3);
            btAddnew_Adv.Name = "btAddnew_Adv";
            btAddnew_Adv.Size = new Size(158, 26);
            btAddnew_Adv.TabIndex = 3;
            btAddnew_Adv.Text = "Add new ";
            btAddnew_Adv.UseVisualStyleBackColor = true;
            btAddnew_Adv.Click += btAddnew_Adv_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
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
            tableLayoutPanel1.Size = new Size(1463, 743);
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
            panel3.Size = new Size(854, 348);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(880, 3);
            panel4.Margin = new Padding(3, 3, 20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(563, 348);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(880, 374);
            panel5.Margin = new Padding(3, 3, 20, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(563, 349);
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
            panel6.Size = new Size(854, 349);
            panel6.TabIndex = 4;
            // 
            // frmSubSalary
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1463, 743);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSubSalary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSubSalary";
            Load += frmSubSalary_Load;
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailSubSalaryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTotalSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdv).EndInit();
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
        private ComboBox cbName;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private BindingSource detailSubSalaryBindingSource;
        private BindingSource subSalaryBindingSource;
        private NumericUpDown nmPaging;
        private Panel panel1;
        private Panel panel2;
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
        private ComboBox cbOrderby;
        private Button btFilter;
        private Label label1;
        private DataGridView dgvTotalSub;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEffectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idDetailSubSalaryDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private Panel panel7;
    }
}