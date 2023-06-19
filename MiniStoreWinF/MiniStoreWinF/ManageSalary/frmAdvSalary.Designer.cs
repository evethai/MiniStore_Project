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
            idEmpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateAsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            advanceSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailAdvanceSalaryBindingSource1 = new BindingSource(components);
            gbAdv = new GroupBox();
            label5 = new Label();
            cbSearch = new ComboBox();
            dtpTo = new DateTimePicker();
            btSearch = new Button();
            dtpFrom = new DateTimePicker();
            btFilter = new Button();
            btAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailAdvanceSalaryBindingSource1).BeginInit();
            gbAdv.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdv
            // 
            dgvAdv.AutoGenerateColumns = false;
            dgvAdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAdv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdv.Columns.AddRange(new DataGridViewColumn[] { idEmpDataGridViewTextBoxColumn, dateAsDataGridViewTextBoxColumn, descriptionADataGridViewTextBoxColumn, advanceSalaryDataGridViewTextBoxColumn });
            dgvAdv.DataSource = detailAdvanceSalaryBindingSource1;
            dgvAdv.Location = new Point(302, 200);
            dgvAdv.Margin = new Padding(5, 4, 5, 4);
            dgvAdv.Name = "dgvAdv";
            dgvAdv.RowTemplate.Height = 27;
            dgvAdv.Size = new Size(433, 289);
            dgvAdv.TabIndex = 0;
            // 
            // idEmpDataGridViewTextBoxColumn
            // 
            idEmpDataGridViewTextBoxColumn.DataPropertyName = "IdEmp";
            idEmpDataGridViewTextBoxColumn.HeaderText = "Id";
            idEmpDataGridViewTextBoxColumn.Name = "idEmpDataGridViewTextBoxColumn";
            idEmpDataGridViewTextBoxColumn.Width = 53;
            // 
            // dateAsDataGridViewTextBoxColumn
            // 
            dateAsDataGridViewTextBoxColumn.DataPropertyName = "DateAs";
            dateAsDataGridViewTextBoxColumn.HeaderText = "Date ";
            dateAsDataGridViewTextBoxColumn.Name = "dateAsDataGridViewTextBoxColumn";
            dateAsDataGridViewTextBoxColumn.Width = 81;
            // 
            // descriptionADataGridViewTextBoxColumn
            // 
            descriptionADataGridViewTextBoxColumn.DataPropertyName = "DescriptionA";
            descriptionADataGridViewTextBoxColumn.HeaderText = "Description / note";
            descriptionADataGridViewTextBoxColumn.Name = "descriptionADataGridViewTextBoxColumn";
            descriptionADataGridViewTextBoxColumn.Width = 137;
            // 
            // advanceSalaryDataGridViewTextBoxColumn
            // 
            advanceSalaryDataGridViewTextBoxColumn.DataPropertyName = "AdvanceSalary";
            advanceSalaryDataGridViewTextBoxColumn.HeaderText = "Money";
            advanceSalaryDataGridViewTextBoxColumn.Name = "advanceSalaryDataGridViewTextBoxColumn";
            advanceSalaryDataGridViewTextBoxColumn.Width = 95;
            // 
            // detailAdvanceSalaryBindingSource1
            // 
            detailAdvanceSalaryBindingSource1.DataSource = typeof(Repository.Models.DetailAdvanceSalary);
            // 
            // gbAdv
            // 
            gbAdv.Controls.Add(label5);
            gbAdv.Controls.Add(cbSearch);
            gbAdv.Controls.Add(dtpTo);
            gbAdv.Controls.Add(btSearch);
            gbAdv.Controls.Add(dtpFrom);
            gbAdv.Controls.Add(btFilter);
            gbAdv.Dock = DockStyle.Top;
            gbAdv.Location = new Point(0, 0);
            gbAdv.Margin = new Padding(5, 4, 5, 4);
            gbAdv.Name = "gbAdv";
            gbAdv.Padding = new Padding(5, 4, 5, 4);
            gbAdv.Size = new Size(1538, 187);
            gbAdv.TabIndex = 1;
            gbAdv.TabStop = false;
            gbAdv.Text = "List of employees with advance salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(491, 47);
            label5.Margin = new Padding(5, 0, 5, 0);
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
            cbSearch.Location = new Point(302, 142);
            cbSearch.Margin = new Padding(5, 4, 5, 4);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(199, 33);
            cbSearch.TabIndex = 8;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(566, 47);
            dtpTo.Margin = new Padding(5, 4, 5, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(169, 33);
            dtpTo.TabIndex = 5;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(566, 142);
            btSearch.Margin = new Padding(5, 4, 5, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(169, 37);
            btSearch.TabIndex = 7;
            btSearch.Text = "Search by Name";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(302, 43);
            dtpFrom.Margin = new Padding(5, 4, 5, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(169, 33);
            dtpFrom.TabIndex = 4;
            // 
            // btFilter
            // 
            btFilter.BackgroundImage = (Image)resources.GetObject("btFilter.BackgroundImage");
            btFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btFilter.Location = new Point(745, 47);
            btFilter.Margin = new Padding(5, 4, 5, 4);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(63, 31);
            btFilter.TabIndex = 2;
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(745, 455);
            btAdd.Margin = new Padding(5, 4, 5, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(98, 34);
            btAdd.TabIndex = 2;
            btAdd.Text = "Add new ";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // frmAdvSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 797);
            Controls.Add(btAdd);
            Controls.Add(gbAdv);
            Controls.Add(dgvAdv);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmAdvSalary";
            StartPosition = FormStartPosition.CenterScreen;
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
        private DataGridViewTextBoxColumn idadvanceSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salariesDataGridViewTextBoxColumn;
        private Button btSearch;
        private ComboBox cbSearch;
        private DataGridViewTextBoxColumn idEmpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn advanceSalaryDataGridViewTextBoxColumn;
    }
}