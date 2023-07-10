namespace MiniStoreWinF.DashBoard
{
    partial class frmMoMo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoMo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtGmail = new TextBox();
            btnAdd = new Button();
            dgvList = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activeDataGridViewTextBoxColumn = new DataGridViewCheckBoxColumn();
            moMoBindingSource = new BindingSource(components);
            btnUpdate = new Button();
            btnUse = new Button();
            txtSave = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moMoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 231);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 289);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 21);
            label2.TabIndex = 0;
            label2.Text = "Full Name (Account MoMo)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 334);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 0;
            label3.Text = "Gmail";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(297, 235);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(274, 29);
            txtPhone.TabIndex = 1;
            txtPhone.Text = "0";
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(297, 283);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 29);
            txtName.TabIndex = 2;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(297, 334);
            txtGmail.Margin = new Padding(4);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(274, 29);
            txtGmail.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(475, 401);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvList
            // 
            dgvList.AutoGenerateColumns = false;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvList.BackgroundColor = SystemColors.ButtonHighlight;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, gmailDataGridViewTextBoxColumn, activeDataGridViewTextBoxColumn });
            dgvList.DataSource = moMoBindingSource;
            dgvList.Dock = DockStyle.Top;
            dgvList.Location = new Point(0, 0);
            dgvList.Margin = new Padding(4);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowTemplate.Height = 27;
            dgvList.Size = new Size(819, 180);
            dgvList.TabIndex = 3;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gmailDataGridViewTextBoxColumn
            // 
            gmailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gmailDataGridViewTextBoxColumn.DataPropertyName = "Gmail";
            gmailDataGridViewTextBoxColumn.HeaderText = "Gmail";
            gmailDataGridViewTextBoxColumn.Name = "gmailDataGridViewTextBoxColumn";
            gmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            activeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            activeDataGridViewTextBoxColumn.HeaderText = "Active";
            activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            activeDataGridViewTextBoxColumn.ReadOnly = true;
            activeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            activeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // moMoBindingSource
            // 
            moMoBindingSource.DataSource = typeof(Repository.Models.MoMo);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 401);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 28);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUse
            // 
            btnUse.BackColor = Color.FromArgb(128, 255, 128);
            btnUse.Location = new Point(623, 235);
            btnUse.Margin = new Padding(4);
            btnUse.Name = "btnUse";
            btnUse.Size = new Size(144, 130);
            btnUse.TabIndex = 5;
            btnUse.Text = "USE";
            btnUse.UseVisualStyleBackColor = false;
            btnUse.Click += btnUse_Click;
            // 
            // txtSave
            // 
            txtSave.AutoSize = true;
            txtSave.Location = new Point(734, 15);
            txtSave.Margin = new Padding(4, 0, 4, 0);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(13, 21);
            txtSave.TabIndex = 6;
            txtSave.Text = ".";
            txtSave.Visible = false;
            // 
            // frmMoMo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(819, 497);
            Controls.Add(txtSave);
            Controls.Add(btnUse);
            Controls.Add(btnUpdate);
            Controls.Add(dgvList);
            Controls.Add(btnAdd);
            Controls.Add(txtGmail);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(835, 536);
            MinimumSize = new Size(835, 536);
            Name = "frmMoMo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoMo";
            Load += frmMoMo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)moMoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtGmail;
        private Button btnAdd;
        private DataGridView dgvList;
        private BindingSource moMoBindingSource;
        private Button btnUpdate;
        private Button btnUse;
        private Label txtSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gmailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewTextBoxColumn;
    }
}