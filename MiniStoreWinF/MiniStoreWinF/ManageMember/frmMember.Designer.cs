namespace MiniStoreWinF.ManageMember
{
    partial class frmMember
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            txtPoint = new TextBox();
            txtName = new TextBox();
            dtDoB = new DateTimePicker();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btAdd = new Button();
            LABEL = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btUpdate = new Button();
            btSearch = new Button();
            txtSearch = new TextBox();
            employeeBindingSource = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            dgvMember = new DataGridView();
            phoneMemberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cbGender = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 68);
            label1.Name = "label1";
            label1.Size = new Size(78, 31);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(548, 64);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(529, 163);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 271);
            label5.Name = "label5";
            label5.Size = new Size(56, 31);
            label5.TabIndex = 4;
            label5.Text = "DoB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 160);
            label2.Name = "label2";
            label2.Size = new Size(66, 31);
            label2.TabIndex = 5;
            label2.Text = "Point";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(145, 65);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(333, 38);
            txtPhone.TabIndex = 6;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtPoint
            // 
            txtPoint.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPoint.Location = new Point(145, 160);
            txtPoint.Margin = new Padding(3, 4, 3, 4);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(195, 38);
            txtPoint.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(642, 61);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 38);
            txtName.TabIndex = 8;
            // 
            // dtDoB
            // 
            dtDoB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDoB.Location = new Point(145, 264);
            dtDoB.Margin = new Padding(3, 4, 3, 4);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(285, 38);
            dtDoB.TabIndex = 10;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btAdd.Location = new Point(545, 359);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(111, 44);
            btAdd.TabIndex = 18;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // LABEL
            // 
            LABEL.AutoSize = true;
            LABEL.BackColor = Color.Transparent;
            LABEL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LABEL.ForeColor = Color.Black;
            LABEL.Location = new Point(9, 6);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(301, 38);
            LABEL.TabIndex = 20;
            LABEL.Text = "Member of MiniStore";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btUpdate.Location = new Point(426, 360);
            btUpdate.Margin = new Padding(3, 4, 3, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(111, 44);
            btUpdate.TabIndex = 21;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btSearch
            // 
            btSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btSearch.Location = new Point(305, 362);
            btSearch.Margin = new Padding(3, 4, 3, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(111, 44);
            btSearch.TabIndex = 22;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(48, 366);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 38);
            txtSearch.TabIndex = 23;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repository.Models.Employee);
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Repository.Models.Member);
            // 
            // dgvMember
            // 
            dgvMember.AutoGenerateColumns = false;
            dgvMember.BackgroundColor = Color.White;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { phoneMemberDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dgvMember.DataSource = memberBindingSource;
            dgvMember.Dock = DockStyle.Fill;
            dgvMember.Location = new Point(3, 434);
            dgvMember.Margin = new Padding(3, 4, 3, 4);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(1318, 231);
            dgvMember.TabIndex = 24;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // phoneMemberDataGridViewTextBoxColumn
            // 
            phoneMemberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneMemberDataGridViewTextBoxColumn.DataPropertyName = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.HeaderText = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneMemberDataGridViewTextBoxColumn.Name = "phoneMemberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(LABEL);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btUpdate);
            panel1.Controls.Add(txtPoint);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(dtDoB);
            panel1.Controls.Add(btAdd);
            panel1.Controls.Add(cbGender);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 424);
            panel1.TabIndex = 27;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(642, 160);
            cbGender.Margin = new Padding(2, 3, 2, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(107, 39);
            cbGender.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMember, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.3322449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.66775F));
            tableLayoutPanel1.Size = new Size(1324, 669);
            tableLayoutPanel1.TabIndex = 28;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1324, 669);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMember";
            Text = "CreateMember";
            Load += CreateMember_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtPoint;
        private TextBox txtName;
        private DateTimePicker dtDoB;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btAdd;
        private Label LABEL;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btUpdate;
        private Button btSearch;
        private TextBox txtSearch;
        private BindingSource employeeBindingSource;
        private BindingSource memberBindingSource;
        private DataGridView dgvMember;
        private Panel panel1;
        private ComboBox cbGender;
        private DataGridViewTextBoxColumn phoneMemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}