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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubSalary));
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            cbName = new ComboBox();
            dtpList = new DateTimePicker();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvSub = new DataGridView();
            idSubDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            describeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeBeginDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            timeEndDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subSalaryBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btEdit = new Button();
            txtSaveID = new Label();
            btAdd = new Button();
            groupBox5 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvSubDetail = new DataGridView();
            idDetailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdEmpSub = new DataGridViewTextBoxColumn();
            Sub = new DataGridViewTextBoxColumn();
            timeBeginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subDetailBindingSource = new BindingSource(components);
            numericUpDown1 = new NumericUpDown();
            detailAdvanceSalaryBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            panel7 = new Panel();
            cbOrderby = new ComboBox();
            btFilter = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvAdv = new DataGridView();
            idAdvanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdEmp = new DataGridViewTextBoxColumn();
            dateAsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            advanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btAddnew_Adv = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).BeginInit();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            panel7.SuspendLayout();
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
            dgvSub.Columns.AddRange(new DataGridViewColumn[] { idSubDataGridViewTextBoxColumn, describeDataGridViewTextBoxColumn, moneyDataGridViewTextBoxColumn, timeBeginDataGridViewTextBoxColumn1, timeEndDataGridViewTextBoxColumn1, typeDataGridViewTextBoxColumn, conditionDataGridViewTextBoxColumn });
            dgvSub.DataSource = subSalaryBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSub.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSub.Dock = DockStyle.Fill;
            dgvSub.Location = new Point(4, 3);
            dgvSub.Margin = new Padding(4, 3, 4, 3);
            dgvSub.Name = "dgvSub";
            dgvSub.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 20, 20);
            dgvSub.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSub.RowTemplate.Height = 27;
            dgvSub.Size = new Size(834, 279);
            dgvSub.TabIndex = 7;
            dgvSub.CellClick += dgvSub_CellClick;
            dgvSub.RowPrePaint += dgvSub_RowPrePaint;
            // 
            // idSubDataGridViewTextBoxColumn
            // 
            idSubDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idSubDataGridViewTextBoxColumn.DataPropertyName = "IdSub";
            idSubDataGridViewTextBoxColumn.HeaderText = "Id";
            idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            idSubDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // describeDataGridViewTextBoxColumn
            // 
            describeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            describeDataGridViewTextBoxColumn.DataPropertyName = "Describe";
            describeDataGridViewTextBoxColumn.HeaderText = "Describe";
            describeDataGridViewTextBoxColumn.Name = "describeDataGridViewTextBoxColumn";
            describeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeBeginDataGridViewTextBoxColumn1
            // 
            timeBeginDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeBeginDataGridViewTextBoxColumn1.DataPropertyName = "TimeBegin";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            timeBeginDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            timeBeginDataGridViewTextBoxColumn1.HeaderText = "Time begin";
            timeBeginDataGridViewTextBoxColumn1.Name = "timeBeginDataGridViewTextBoxColumn1";
            timeBeginDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeEndDataGridViewTextBoxColumn1
            // 
            timeEndDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeEndDataGridViewTextBoxColumn1.DataPropertyName = "TimeEnd";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            timeEndDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            timeEndDataGridViewTextBoxColumn1.HeaderText = "Time end";
            timeEndDataGridViewTextBoxColumn1.Name = "timeEndDataGridViewTextBoxColumn1";
            timeEndDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            conditionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subSalaryBindingSource
            // 
            subSalaryBindingSource.DataSource = typeof(Repository.Models.SubSalary);
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
            tableLayoutPanel2.Controls.Add(dgvSubDetail, 0, 0);
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
            // dgvSubDetail
            // 
            dgvSubDetail.AutoGenerateColumns = false;
            dgvSubDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSubDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubDetail.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSubDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 30, 0);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSubDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSubDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubDetail.Columns.AddRange(new DataGridViewColumn[] { idDetailDataGridViewTextBoxColumn, IdEmpSub, Sub, timeBeginDataGridViewTextBoxColumn, timeEndDataGridViewTextBoxColumn });
            dgvSubDetail.DataSource = subDetailBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvSubDetail.DefaultCellStyle = dataGridViewCellStyle8;
            dgvSubDetail.Dock = DockStyle.Fill;
            dgvSubDetail.Location = new Point(4, 3);
            dgvSubDetail.Margin = new Padding(4, 3, 4, 3);
            dgvSubDetail.Name = "dgvSubDetail";
            dgvSubDetail.ReadOnly = true;
            dataGridViewCellStyle9.Padding = new Padding(0, 0, 20, 20);
            dgvSubDetail.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvSubDetail.RowTemplate.Height = 27;
            dgvSubDetail.Size = new Size(836, 278);
            dgvSubDetail.TabIndex = 8;
            dgvSubDetail.CellFormatting += dgvSubDetail_CellFormatting;
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            idDetailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            idDetailDataGridViewTextBoxColumn.HeaderText = "Id";
            idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            idDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdEmpSub
            // 
            IdEmpSub.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdEmpSub.DataPropertyName = "IdEmp";
            IdEmpSub.HeaderText = "Employee";
            IdEmpSub.Name = "IdEmpSub";
            IdEmpSub.ReadOnly = true;
            // 
            // Sub
            // 
            Sub.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sub.DataPropertyName = "IdSub";
            Sub.HeaderText = "Allowance";
            Sub.Name = "Sub";
            Sub.ReadOnly = true;
            // 
            // timeBeginDataGridViewTextBoxColumn
            // 
            timeBeginDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeBeginDataGridViewTextBoxColumn.DataPropertyName = "TimeBegin";
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            timeBeginDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            timeBeginDataGridViewTextBoxColumn.HeaderText = "Time begin";
            timeBeginDataGridViewTextBoxColumn.Name = "timeBeginDataGridViewTextBoxColumn";
            timeBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            timeEndDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeEndDataGridViewTextBoxColumn.DataPropertyName = "TimeEnd";
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = null;
            timeEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            timeEndDataGridViewTextBoxColumn.HeaderText = "Time end";
            timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            timeEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subDetailBindingSource
            // 
            subDetailBindingSource.DataSource = typeof(Repository.Models.SubDetail);
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
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(553, 316);
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
            dgvAdv.Columns.AddRange(new DataGridViewColumn[] { idAdvanceSalaryDataGridViewTextBoxColumn, IdEmp, dateAsDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn1, advanceSalaryDataGridViewTextBoxColumn });
            dgvAdv.DataSource = detailAdvanceSalaryBindingSource;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new Padding(0, 0, 20, 0);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvAdv.DefaultCellStyle = dataGridViewCellStyle12;
            dgvAdv.Dock = DockStyle.Fill;
            dgvAdv.Location = new Point(4, 3);
            dgvAdv.Margin = new Padding(4, 3, 4, 3);
            dgvAdv.Name = "dgvAdv";
            dgvAdv.ReadOnly = true;
            dataGridViewCellStyle13.Padding = new Padding(0, 0, 20, 20);
            dgvAdv.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvAdv.RowTemplate.Height = 27;
            dgvAdv.Size = new Size(545, 279);
            dgvAdv.TabIndex = 1;
            dgvAdv.CellFormatting += dgvAdv_CellFormatting;
            // 
            // idAdvanceSalaryDataGridViewTextBoxColumn
            // 
            idAdvanceSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idAdvanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "IdAdvanceSalary";
            idAdvanceSalaryDataGridViewTextBoxColumn.HeaderText = "ID";
            idAdvanceSalaryDataGridViewTextBoxColumn.Name = "idAdvanceSalaryDataGridViewTextBoxColumn";
            idAdvanceSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdEmp
            // 
            IdEmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdEmp.DataPropertyName = "IdEmp";
            IdEmp.HeaderText = "Employee";
            IdEmp.Name = "IdEmp";
            IdEmp.ReadOnly = true;
            // 
            // dateAsDataGridViewTextBoxColumn
            // 
            dateAsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateAsDataGridViewTextBoxColumn.DataPropertyName = "DateAs";
            dataGridViewCellStyle10.Format = "D";
            dataGridViewCellStyle10.NullValue = null;
            dateAsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            dateAsDataGridViewTextBoxColumn.HeaderText = "Date";
            dateAsDataGridViewTextBoxColumn.Name = "dateAsDataGridViewTextBoxColumn";
            dateAsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionADataGridViewTextBoxColumn1
            // 
            descriptionADataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionADataGridViewTextBoxColumn1.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionADataGridViewTextBoxColumn1.Name = "descriptionADataGridViewTextBoxColumn1";
            descriptionADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // advanceSalaryDataGridViewTextBoxColumn
            // 
            advanceSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            advanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "AdvanceSalary";
            dataGridViewCellStyle11.Format = "#,###,###";
            dataGridViewCellStyle11.NullValue = null;
            advanceSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            advanceSalaryDataGridViewTextBoxColumn.HeaderText = "Money";
            advanceSalaryDataGridViewTextBoxColumn.Name = "advanceSalaryDataGridViewTextBoxColumn";
            advanceSalaryDataGridViewTextBoxColumn.ReadOnly = true;
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
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)subSalaryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)subDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            panel7.ResumeLayout(false);
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
        private ComboBox cbName;
        private DataGridViewTextBoxColumn idSubSalaryDataGridViewTextBoxColumn;
        private NumericUpDown nmPaging;
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
        private ComboBox cbOrderby;
        private Button btFilter;
        private DataGridView dgvSubDetail;
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
        private DataGridViewTextBoxColumn idAdvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdEmp;
        private DataGridViewTextBoxColumn dateAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn advanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn describeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeBeginDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private BindingSource subSalaryBindingSource;
        private BindingSource subDetailBindingSource;
        private DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdEmpSub;
        private DataGridViewTextBoxColumn Sub;
        private DataGridViewTextBoxColumn timeBeginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
    }
}