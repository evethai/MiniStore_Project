namespace MiniStoreWinF.ManageSalary
{
    partial class frmAdvSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvSalary));
            dgvAdv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            IdEmp = new DataGridViewTextBoxColumn();
            DateAs = new DataGridViewTextBoxColumn();
            DescriptionA = new DataGridViewTextBoxColumn();
            AdvanceSalary = new DataGridViewTextBoxColumn();
            Salaries = new DataGridViewTextBoxColumn();
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateAsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            advanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailAdvanceSalaryBindingSource1 = new BindingSource(components);
            gbAdv = new GroupBox();
            btAdd = new Button();
            label5 = new Label();
            cbSearch = new ComboBox();
            dtpTo = new DateTimePicker();
            btSearch = new Button();
            dtpFrom = new DateTimePicker();
            btFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource1).BeginInit();
            gbAdv.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdv
            // 
            dgvAdv.AutoGenerateColumns = false;
            dgvAdv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdv.Columns.AddRange(new DataGridViewColumn[] { Column1, IdEmp, DateAs, DescriptionA, AdvanceSalary, Salaries, idEmpDataGridViewTextBoxColumn, dateAsDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn, advanceSalaryDataGridViewTextBoxColumn });
            dgvAdv.DataSource = detailAdvanceSalaryBindingSource1;
            dgvAdv.Location = new Point(6, 133);
            dgvAdv.Name = "dgvAdv";
            dgvAdv.RowTemplate.Height = 27;
            dgvAdv.Size = new Size(543, 397);
            dgvAdv.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "IdadvanceSalary";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // IdEmp
            // 
            IdEmp.DataPropertyName = "IdEmp";
            IdEmp.HeaderText = "IdEmp";
            IdEmp.Name = "IdEmp";
            // 
            // DateAs
            // 
            DateAs.DataPropertyName = "DateAs";
            DateAs.HeaderText = "DateAs";
            DateAs.Name = "DateAs";
            // 
            // DescriptionA
            // 
            DescriptionA.DataPropertyName = "DescriptionA";
            DescriptionA.HeaderText = "DescriptionA";
            DescriptionA.Name = "DescriptionA";
            // 
            // AdvanceSalary
            // 
            AdvanceSalary.DataPropertyName = "AdvanceSalary";
            AdvanceSalary.HeaderText = "AdvanceSalary";
            AdvanceSalary.Name = "AdvanceSalary";
            // 
            // Salaries
            // 
            Salaries.DataPropertyName = "Salaries";
            Salaries.HeaderText = "Salaries";
            Salaries.Name = "Salaries";
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "IdEmp";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            // 
            // dateAsDataGridViewTextBoxColumn
            // 
            dateAsDataGridViewTextBoxColumn.DataPropertyName = "DateAs";
            dateAsDataGridViewTextBoxColumn.HeaderText = "DateAs";
            dateAsDataGridViewTextBoxColumn.Name = "dateAsDataGridViewTextBoxColumn";
            // 
            // descriptionADataGridViewTextBoxColumn
            // 
            descriptionADataGridViewTextBoxColumn.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.HeaderText = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.Name = "descriptionADataGridViewTextBoxColumn";
            // 
            // advanceSalaryDataGridViewTextBoxColumn
            // 
            advanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "AdvanceSalary";
            advanceSalaryDataGridViewTextBoxColumn.HeaderText = "AdvanceSalary";
            advanceSalaryDataGridViewTextBoxColumn.Name = "advanceSalaryDataGridViewTextBoxColumn";
            // 
            // detailAdvanceSalaryBindingSource1
            // 
            detailAdvanceSalaryBindingSource1.DataSource = typeof(Repository.Models.DetailAdvanceSalary);
            // 
            // gbAdv
            // 
            gbAdv.Controls.Add(btAdd);
            gbAdv.Controls.Add(label5);
            gbAdv.Controls.Add(cbSearch);
            gbAdv.Controls.Add(dtpTo);
            gbAdv.Controls.Add(btSearch);
            gbAdv.Controls.Add(dtpFrom);
            gbAdv.Controls.Add(btFilter);
            gbAdv.Dock = DockStyle.Top;
            gbAdv.Location = new Point(0, 0);
            gbAdv.Name = "gbAdv";
            gbAdv.Size = new Size(549, 127);
            gbAdv.TabIndex = 1;
            gbAdv.TabStop = false;
            gbAdv.Text = "List of employees with advance salary";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(468, 98);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Add new ";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(162, 21);
            label5.Name = "label5";
            label5.Size = new Size(33, 25);
            label5.TabIndex = 6;
            label5.Text = "To";
            // 
            // cbSearch
            // 
            cbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(6, 96);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(121, 25);
            cbSearch.TabIndex = 8;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(201, 21);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 25);
            dtpTo.TabIndex = 5;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(133, 96);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(134, 25);
            btSearch.TabIndex = 7;
            btSearch.Text = "Search by Name";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(6, 22);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 25);
            dtpFrom.TabIndex = 4;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(347, 21);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(45, 25);
            btFilter.TabIndex = 2;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // frmAdvSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 542);
            Controls.Add(gbAdv);
            Controls.Add(dgvAdv);
            Name = "frmAdvSalary";
            Text = "frmAdvSalary";
            Load += frmAdvSalary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource1).EndInit();
            gbAdv.ResumeLayout(false);
            gbAdv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdv;
        private GroupBox gbAdv;
        private Button btFilter;
        private Button btAdd;
        private Label label5;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private BindingSource detailAdvanceSalaryBindingSource1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn IdEmp;
        private DataGridViewTextBoxColumn DateAs;
        private DataGridViewTextBoxColumn DescriptionA;
        private DataGridViewTextBoxColumn AdvanceSalary;
        private DataGridViewTextBoxColumn Salaries;
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn advanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salariesDataGridViewTextBoxColumn;
        private Button btSearch;
        private ComboBox cbSearch;
    }
}