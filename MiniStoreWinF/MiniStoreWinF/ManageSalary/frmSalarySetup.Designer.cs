namespace MiniStoreWinF.ManageSalary
{
    partial class frmSalarySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalarySetup));
            gb1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            txtGuard = new TextBox();
            txtEmp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            employeeBindingSource = new BindingSource(components);
            gb2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btEdit = new Button();
            dgvPer = new DataGridView();
            permission1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basicSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            permissionBindingSource = new BindingSource(components);
            txtSave = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnEditHstl = new Button();
            dgvHstl = new DataGridView();
            bhxhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bhytDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bhtnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gtgcBanthanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gtgcNptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            luongToiThieuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mucBhToiDaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heSoTinhLuongBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gb1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            gb2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHstl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heSoTinhLuongBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ButtonHighlight;
            gb1.Controls.Add(tableLayoutPanel3);
            gb1.Dock = DockStyle.Fill;
            gb1.Location = new Point(0, 0);
            gb1.Margin = new Padding(5, 4, 5, 4);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(5, 4, 5, 4);
            gb1.Size = new Size(1053, 210);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1043, 176);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtGuard);
            panel4.Controls.Add(txtEmp);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1037, 134);
            panel4.TabIndex = 6;
            // 
            // txtGuard
            // 
            txtGuard.Anchor = AnchorStyles.Left;
            txtGuard.Enabled = false;
            txtGuard.Location = new Point(206, 71);
            txtGuard.Margin = new Padding(5, 4, 5, 4);
            txtGuard.Name = "txtGuard";
            txtGuard.Size = new Size(155, 33);
            txtGuard.TabIndex = 3;
            // 
            // txtEmp
            // 
            txtEmp.Anchor = AnchorStyles.Left;
            txtEmp.Enabled = false;
            txtEmp.Location = new Point(206, 30);
            txtEmp.Margin = new Padding(5, 4, 5, 4);
            txtEmp.Name = "txtEmp";
            txtEmp.Size = new Size(155, 33);
            txtEmp.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(5, 79);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "Number Guard";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 1;
            label1.Text = "Number Employees";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(5, 144);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(1033, 28);
            button1.TabIndex = 4;
            button1.Text = "Detail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // gb2
            // 
            gb2.Controls.Add(tableLayoutPanel2);
            gb2.Controls.Add(txtSave);
            gb2.Dock = DockStyle.Fill;
            gb2.Location = new Point(0, 0);
            gb2.Margin = new Padding(5, 4, 5, 4);
            gb2.Name = "gb2";
            gb2.Padding = new Padding(5, 4, 5, 4);
            gb2.Size = new Size(1053, 210);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btEdit, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvPer, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1043, 176);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btEdit
            // 
            btEdit.Dock = DockStyle.Fill;
            btEdit.Location = new Point(5, 144);
            btEdit.Margin = new Padding(5, 4, 5, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(1033, 28);
            btEdit.TabIndex = 2;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // dgvPer
            // 
            dgvPer.AutoGenerateColumns = false;
            dgvPer.BackgroundColor = SystemColors.Window;
            dgvPer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPer.Columns.AddRange(new DataGridViewColumn[] { permission1DataGridViewTextBoxColumn, basicSalaryDataGridViewTextBoxColumn });
            dgvPer.DataSource = permissionBindingSource;
            dgvPer.Dock = DockStyle.Fill;
            dgvPer.GridColor = SystemColors.Window;
            dgvPer.Location = new Point(3, 3);
            dgvPer.Name = "dgvPer";
            dgvPer.ReadOnly = true;
            dgvPer.RowTemplate.Height = 27;
            dgvPer.Size = new Size(1037, 134);
            dgvPer.TabIndex = 3;
            dgvPer.CellClick += dgvPer_CellClick;
            // 
            // permission1DataGridViewTextBoxColumn
            // 
            permission1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            permission1DataGridViewTextBoxColumn.DataPropertyName = "Permission1";
            permission1DataGridViewTextBoxColumn.HeaderText = "Role";
            permission1DataGridViewTextBoxColumn.Name = "permission1DataGridViewTextBoxColumn";
            permission1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            basicSalaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            basicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary(hour)";
            basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionBindingSource
            // 
            permissionBindingSource.DataSource = typeof(Repository.Models.Permission);
            // 
            // txtSave
            // 
            txtSave.AutoSize = true;
            txtSave.Location = new Point(970, 30);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(0, 25);
            txtSave.TabIndex = 4;
            txtSave.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1053, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btnEditHstl, 0, 1);
            tableLayoutPanel4.Controls.Add(dgvHstl, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 30);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(1043, 178);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnEditHstl
            // 
            btnEditHstl.Dock = DockStyle.Fill;
            btnEditHstl.Location = new Point(3, 145);
            btnEditHstl.Name = "btnEditHstl";
            btnEditHstl.Size = new Size(1037, 30);
            btnEditHstl.TabIndex = 0;
            btnEditHstl.Text = "Edit";
            btnEditHstl.UseVisualStyleBackColor = true;
            btnEditHstl.Click += btnEditHstl_Click;
            // 
            // dgvHstl
            // 
            dgvHstl.AutoGenerateColumns = false;
            dgvHstl.BackgroundColor = SystemColors.Window;
            dgvHstl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHstl.Columns.AddRange(new DataGridViewColumn[] { bhxhDataGridViewTextBoxColumn, bhytDataGridViewTextBoxColumn, bhtnDataGridViewTextBoxColumn, gtgcBanthanDataGridViewTextBoxColumn, gtgcNptDataGridViewTextBoxColumn, luongToiThieuDataGridViewTextBoxColumn, mucBhToiDaDataGridViewTextBoxColumn });
            dgvHstl.DataSource = heSoTinhLuongBindingSource;
            dgvHstl.Dock = DockStyle.Fill;
            dgvHstl.Location = new Point(3, 3);
            dgvHstl.Name = "dgvHstl";
            dgvHstl.ReadOnly = true;
            dgvHstl.RowTemplate.Height = 27;
            dgvHstl.Size = new Size(1037, 136);
            dgvHstl.TabIndex = 0;
            // 
            // bhxhDataGridViewTextBoxColumn
            // 
            bhxhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bhxhDataGridViewTextBoxColumn.DataPropertyName = "Bhxh";
            bhxhDataGridViewTextBoxColumn.HeaderText = "Social insurance";
            bhxhDataGridViewTextBoxColumn.Name = "bhxhDataGridViewTextBoxColumn";
            bhxhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bhytDataGridViewTextBoxColumn
            // 
            bhytDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bhytDataGridViewTextBoxColumn.DataPropertyName = "Bhyt";
            bhytDataGridViewTextBoxColumn.HeaderText = "Health insurance";
            bhytDataGridViewTextBoxColumn.Name = "bhytDataGridViewTextBoxColumn";
            bhytDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bhtnDataGridViewTextBoxColumn
            // 
            bhtnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bhtnDataGridViewTextBoxColumn.DataPropertyName = "Bhtn";
            bhtnDataGridViewTextBoxColumn.HeaderText = "Unemployment insurance";
            bhtnDataGridViewTextBoxColumn.Name = "bhtnDataGridViewTextBoxColumn";
            bhtnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gtgcBanthanDataGridViewTextBoxColumn
            // 
            gtgcBanthanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gtgcBanthanDataGridViewTextBoxColumn.DataPropertyName = "GtgcBanthan";
            gtgcBanthanDataGridViewTextBoxColumn.HeaderText = "Reduce personal circumstances";
            gtgcBanthanDataGridViewTextBoxColumn.Name = "gtgcBanthanDataGridViewTextBoxColumn";
            gtgcBanthanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gtgcNptDataGridViewTextBoxColumn
            // 
            gtgcNptDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gtgcNptDataGridViewTextBoxColumn.DataPropertyName = "GtgcNpt";
            gtgcNptDataGridViewTextBoxColumn.HeaderText = "Reduce the situation of dependents";
            gtgcNptDataGridViewTextBoxColumn.Name = "gtgcNptDataGridViewTextBoxColumn";
            gtgcNptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luongToiThieuDataGridViewTextBoxColumn
            // 
            luongToiThieuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            luongToiThieuDataGridViewTextBoxColumn.DataPropertyName = "LuongToiThieu";
            luongToiThieuDataGridViewTextBoxColumn.HeaderText = "Minimum wage";
            luongToiThieuDataGridViewTextBoxColumn.Name = "luongToiThieuDataGridViewTextBoxColumn";
            luongToiThieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mucBhToiDaDataGridViewTextBoxColumn
            // 
            mucBhToiDaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mucBhToiDaDataGridViewTextBoxColumn.DataPropertyName = "MucBhToiDa";
            mucBhToiDaDataGridViewTextBoxColumn.HeaderText = "Maximum premium";
            mucBhToiDaDataGridViewTextBoxColumn.Name = "mucBhToiDaDataGridViewTextBoxColumn";
            mucBhToiDaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heSoTinhLuongBindingSource
            // 
            heSoTinhLuongBindingSource.DataSource = typeof(Repository.Models.HeSoTinhLuong);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1084, 721);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(gb1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(3, 3, 20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 214);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(gb2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 244);
            panel2.Margin = new Padding(3, 3, 20, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 214);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 483);
            panel3.Margin = new Padding(3, 3, 20, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 216);
            panel3.TabIndex = 4;
            // 
            // frmSalarySetup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1084, 721);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmSalarySetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalarySetup";
            Load += frmSalarySetup_Load;
            gb1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPer).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHstl).EndInit();
            ((System.ComponentModel.ISupportInitialize)heSoTinhLuongBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private BindingSource employeeBindingSource;
        private Label label2;
        private Label label1;
        private TextBox txtGuard;
        private TextBox txtEmp;
        private Button button1;
        private GroupBox gb2;
        private TextBox txtSaGuard;
        private TextBox txtSaEmp;
        private Button btEdit;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvPer;
        private BindingSource permissionBindingSource;
        private DataGridViewTextBoxColumn permission1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private Label txtSave;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvHstl;
        private BindingSource heSoTinhLuongBindingSource;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnEditHstl;
        private DataGridViewTextBoxColumn bhxhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bhytDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bhtnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gtgcBanthanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gtgcNptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn luongToiThieuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mucBhToiDaDataGridViewTextBoxColumn;
    }
}