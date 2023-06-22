namespace MiniStoreWinF.ManageMember
{
    partial class CreateMember
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
            cbGender = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btAdd = new Button();
            btClose = new Button();
            LABEL = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btUpdate = new Button();
            btSearch = new Button();
            txtSearch = new TextBox();
            employeeBindingSource = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            dgvMember = new DataGridView();
            phoneMemberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pointDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btDelete = new Button();
            txtLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 102);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 201);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 249);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 290);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "DoB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 156);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Point";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 94);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(292, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(139, 148);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(171, 23);
            txtPoint.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 193);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 23);
            txtName.TabIndex = 8;
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(139, 284);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(250, 23);
            dtDoB.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(139, 241);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(94, 23);
            cbGender.TabIndex = 17;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(20, 324);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 18;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(1005, 511);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 19;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // LABEL
            // 
            LABEL.AutoSize = true;
            LABEL.BackColor = SystemColors.ButtonFace;
            LABEL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL.ForeColor = Color.Red;
            LABEL.Location = new Point(200, 23);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(247, 25);
            LABEL.TabIndex = 20;
            LABEL.Text = "CREATE ACCOUNT MEMBER";
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
            btUpdate.Location = new Point(111, 324);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(75, 23);
            btUpdate.TabIndex = 21;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(364, 323);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 22;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(200, 323);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 23);
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
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { phoneMemberDataGridViewTextBoxColumn, pointDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, doBDataGridViewTextBoxColumn, ordersDataGridViewTextBoxColumn });
            dgvMember.DataSource = memberBindingSource;
            dgvMember.Location = new Point(-1, 372);
            dgvMember.Name = "dgvMember";
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(646, 150);
            dgvMember.TabIndex = 24;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // phoneMemberDataGridViewTextBoxColumn
            // 
            phoneMemberDataGridViewTextBoxColumn.DataPropertyName = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.HeaderText = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.Name = "phoneMemberDataGridViewTextBoxColumn";
            // 
            // pointDataGridViewTextBoxColumn
            // 
            pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            pointDataGridViewTextBoxColumn.HeaderText = "Point";
            pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // doBDataGridViewTextBoxColumn
            // 
            doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(664, 372);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 25;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // txtLoad
            // 
            txtLoad.Location = new Point(664, 499);
            txtLoad.Name = "txtLoad";
            txtLoad.Size = new Size(75, 23);
            txtLoad.TabIndex = 26;
            txtLoad.Text = "Load";
            txtLoad.UseVisualStyleBackColor = true;
            txtLoad.Click += txtLoad_Click;
            // 
            // CreateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 546);
            Controls.Add(txtLoad);
            Controls.Add(btDelete);
            Controls.Add(dgvMember);
            Controls.Add(txtSearch);
            Controls.Add(btSearch);
            Controls.Add(btUpdate);
            Controls.Add(LABEL);
            Controls.Add(btClose);
            Controls.Add(btAdd);
            Controls.Add(cbGender);
            Controls.Add(dtDoB);
            Controls.Add(txtName);
            Controls.Add(txtPoint);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CreateMember";
            Text = "CreateMember";
            Load += CreateMember_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox cbGender;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btAdd;
        private Button btClose;
        private Label LABEL;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btUpdate;
        private Button btSearch;
        private TextBox txtSearch;
        private BindingSource employeeBindingSource;
        private BindingSource memberBindingSource;
        private DataGridView dgvMember;
        private DataGridViewTextBoxColumn phoneMemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private Button btDelete;
        private Button txtLoad;
    }
}