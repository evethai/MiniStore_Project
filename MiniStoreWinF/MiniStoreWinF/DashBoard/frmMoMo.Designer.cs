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
            moMoBindingSource1 = new BindingSource(components);
            moMoBindingSource = new BindingSource(components);
            btnUpdate = new Button();
            btnUse = new Button();
            txtSave = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moMoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moMoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 170);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 217);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 0;
            label2.Text = "Full Name (Account MoMo)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 253);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 0;
            label3.Text = "Gmail";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(216, 173);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 25);
            txtPhone.TabIndex = 1;
            txtPhone.Text = "0";
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 212);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 25);
            txtName.TabIndex = 1;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(216, 253);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(214, 25);
            txtGmail.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(355, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
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
            dgvList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, gmailDataGridViewTextBoxColumn });
            dgvList.DataSource = moMoBindingSource1;
            dgvList.Location = new Point(12, 12);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 27;
            dgvList.Size = new Size(402, 127);
            dgvList.TabIndex = 3;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 44;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.Width = 69;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // gmailDataGridViewTextBoxColumn
            // 
            gmailDataGridViewTextBoxColumn.DataPropertyName = "Gmail";
            gmailDataGridViewTextBoxColumn.HeaderText = "Gmail";
            gmailDataGridViewTextBoxColumn.Name = "gmailDataGridViewTextBoxColumn";
            gmailDataGridViewTextBoxColumn.Width = 66;
            // 
            // moMoBindingSource1
            // 
            moMoBindingSource1.DataSource = typeof(Repository.Models.MoMo);
            // 
            // moMoBindingSource
            // 
            moMoBindingSource.DataSource = typeof(Repository.Models.MoMo);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(216, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUse
            // 
            btnUse.BackColor = Color.FromArgb(128, 255, 128);
            btnUse.Location = new Point(470, 173);
            btnUse.Name = "btnUse";
            btnUse.Size = new Size(112, 105);
            btnUse.TabIndex = 5;
            btnUse.Text = "USE";
            btnUse.UseVisualStyleBackColor = false;
            btnUse.Click += btnUse_Click;
            // 
            // txtSave
            // 
            txtSave.AutoSize = true;
            txtSave.Location = new Point(571, 12);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(11, 17);
            txtSave.TabIndex = 6;
            txtSave.Text = ".";
            txtSave.Visible = false;
            // 
            // frmMoMo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(594, 358);
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
            MaximumSize = new Size(610, 397);
            Name = "frmMoMo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMoMo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)moMoBindingSource1).EndInit();
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gmailDataGridViewTextBoxColumn;
        private BindingSource moMoBindingSource1;
        private Label txtSave;
    }
}