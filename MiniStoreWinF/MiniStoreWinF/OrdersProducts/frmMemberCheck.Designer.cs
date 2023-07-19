namespace MiniStoreWinF.OrdersProducts
{
    partial class frmMemberCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberCheck));
            pnlCheckMember = new Panel();
            dgvListMember = new DataGridView();
            phoneMemberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pointDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberBindingSource = new BindingSource(components);
            btCloseMemberCheck = new Button();
            btCreateMember = new Button();
            lbPhoneMember = new Label();
            txtSearchMember = new TextBox();
            btCheckPhoneMember = new Button();
            pnlCreateMember = new Panel();
            dtDoBNewMember = new DateTimePicker();
            cbGenderNewMember = new ComboBox();
            txtPhoneNewMember = new TextBox();
            txtNameNewMember = new TextBox();
            btCreateSusscessMember = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlCheckMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            pnlCreateMember.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCheckMember
            // 
            pnlCheckMember.Controls.Add(dgvListMember);
            pnlCheckMember.Controls.Add(btCloseMemberCheck);
            pnlCheckMember.Controls.Add(btCreateMember);
            pnlCheckMember.Controls.Add(lbPhoneMember);
            pnlCheckMember.Controls.Add(txtSearchMember);
            pnlCheckMember.Controls.Add(btCheckPhoneMember);
            pnlCheckMember.Dock = DockStyle.Top;
            pnlCheckMember.Location = new Point(0, 0);
            pnlCheckMember.Name = "pnlCheckMember";
            pnlCheckMember.Size = new Size(705, 214);
            pnlCheckMember.TabIndex = 5;
            // 
            // dgvListMember
            // 
            dgvListMember.AutoGenerateColumns = false;
            dgvListMember.BackgroundColor = SystemColors.Control;
            dgvListMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListMember.Columns.AddRange(new DataGridViewColumn[] { phoneMemberDataGridViewTextBoxColumn, pointDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, doBDataGridViewTextBoxColumn });
            dgvListMember.DataSource = memberBindingSource;
            dgvListMember.Location = new Point(0, 119);
            dgvListMember.Name = "dgvListMember";
            dgvListMember.RowHeadersWidth = 51;
            dgvListMember.RowTemplate.Height = 29;
            dgvListMember.Size = new Size(702, 95);
            dgvListMember.TabIndex = 6;
            dgvListMember.Visible = false;
            // 
            // phoneMemberDataGridViewTextBoxColumn
            // 
            phoneMemberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneMemberDataGridViewTextBoxColumn.DataPropertyName = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.HeaderText = "PhoneMember";
            phoneMemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneMemberDataGridViewTextBoxColumn.Name = "phoneMemberDataGridViewTextBoxColumn";
            // 
            // pointDataGridViewTextBoxColumn
            // 
            pointDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            pointDataGridViewTextBoxColumn.HeaderText = "Point";
            pointDataGridViewTextBoxColumn.MinimumWidth = 6;
            pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // doBDataGridViewTextBoxColumn
            // 
            doBDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            doBDataGridViewTextBoxColumn.MinimumWidth = 6;
            doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Repository.Models.Member);
            // 
            // btCloseMemberCheck
            // 
            btCloseMemberCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCloseMemberCheck.Image = (Image)resources.GetObject("btCloseMemberCheck.Image");
            btCloseMemberCheck.Location = new Point(598, 32);
            btCloseMemberCheck.Name = "btCloseMemberCheck";
            btCloseMemberCheck.Size = new Size(98, 64);
            btCloseMemberCheck.TabIndex = 4;
            btCloseMemberCheck.Text = "Lose";
            btCloseMemberCheck.TextAlign = ContentAlignment.BottomCenter;
            btCloseMemberCheck.UseVisualStyleBackColor = true;
            btCloseMemberCheck.Click += btCloseMemberCheck_Click;
            // 
            // btCreateMember
            // 
            btCreateMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateMember.Image = (Image)resources.GetObject("btCreateMember.Image");
            btCreateMember.ImageAlign = ContentAlignment.TopCenter;
            btCreateMember.Location = new Point(479, 31);
            btCreateMember.Name = "btCreateMember";
            btCreateMember.Size = new Size(98, 65);
            btCreateMember.TabIndex = 3;
            btCreateMember.Text = "Create";
            btCreateMember.TextAlign = ContentAlignment.BottomCenter;
            btCreateMember.UseVisualStyleBackColor = true;
            btCreateMember.Click += btCreateMember_Click;
            // 
            // lbPhoneMember
            // 
            lbPhoneMember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhoneMember.Image = (Image)resources.GetObject("lbPhoneMember.Image");
            lbPhoneMember.ImageAlign = ContentAlignment.TopCenter;
            lbPhoneMember.Location = new Point(68, 31);
            lbPhoneMember.Name = "lbPhoneMember";
            lbPhoneMember.Size = new Size(72, 61);
            lbPhoneMember.TabIndex = 2;
            lbPhoneMember.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(146, 48);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(195, 27);
            txtSearchMember.TabIndex = 0;
            // 
            // btCheckPhoneMember
            // 
            btCheckPhoneMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCheckPhoneMember.Image = (Image)resources.GetObject("btCheckPhoneMember.Image");
            btCheckPhoneMember.ImageAlign = ContentAlignment.TopCenter;
            btCheckPhoneMember.Location = new Point(360, 31);
            btCheckPhoneMember.Name = "btCheckPhoneMember";
            btCheckPhoneMember.Size = new Size(98, 65);
            btCheckPhoneMember.TabIndex = 1;
            btCheckPhoneMember.Text = "Check";
            btCheckPhoneMember.TextAlign = ContentAlignment.BottomCenter;
            btCheckPhoneMember.UseVisualStyleBackColor = true;
            btCheckPhoneMember.Click += btCheckPhoneMember_Click;
            // 
            // pnlCreateMember
            // 
            pnlCreateMember.Controls.Add(dtDoBNewMember);
            pnlCreateMember.Controls.Add(cbGenderNewMember);
            pnlCreateMember.Controls.Add(txtPhoneNewMember);
            pnlCreateMember.Controls.Add(txtNameNewMember);
            pnlCreateMember.Controls.Add(btCreateSusscessMember);
            pnlCreateMember.Controls.Add(label6);
            pnlCreateMember.Controls.Add(label4);
            pnlCreateMember.Controls.Add(label3);
            pnlCreateMember.Controls.Add(label2);
            pnlCreateMember.Dock = DockStyle.Fill;
            pnlCreateMember.Location = new Point(0, 214);
            pnlCreateMember.Name = "pnlCreateMember";
            pnlCreateMember.Size = new Size(705, 248);
            pnlCreateMember.TabIndex = 6;
            pnlCreateMember.Visible = false;
            // 
            // dtDoBNewMember
            // 
            dtDoBNewMember.Format = DateTimePickerFormat.Custom;
            dtDoBNewMember.Location = new Point(475, 26);
            dtDoBNewMember.Name = "dtDoBNewMember";
            dtDoBNewMember.Size = new Size(195, 27);
            dtDoBNewMember.TabIndex = 16;
            // 
            // cbGenderNewMember
            // 
            cbGenderNewMember.FormattingEnabled = true;
            cbGenderNewMember.Location = new Point(146, 110);
            cbGenderNewMember.Name = "cbGenderNewMember";
            cbGenderNewMember.Size = new Size(195, 28);
            cbGenderNewMember.TabIndex = 15;
            // 
            // txtPhoneNewMember
            // 
            txtPhoneNewMember.Location = new Point(146, 188);
            txtPhoneNewMember.Name = "txtPhoneNewMember";
            txtPhoneNewMember.Size = new Size(195, 27);
            txtPhoneNewMember.TabIndex = 14;
            // 
            // txtNameNewMember
            // 
            txtNameNewMember.Location = new Point(146, 26);
            txtNameNewMember.Name = "txtNameNewMember";
            txtNameNewMember.Size = new Size(195, 27);
            txtNameNewMember.TabIndex = 11;
            // 
            // btCreateSusscessMember
            // 
            btCreateSusscessMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCreateSusscessMember.Image = (Image)resources.GetObject("btCreateSusscessMember.Image");
            btCreateSusscessMember.ImageAlign = ContentAlignment.TopCenter;
            btCreateSusscessMember.Location = new Point(512, 98);
            btCreateSusscessMember.Name = "btCreateSusscessMember";
            btCreateSusscessMember.Size = new Size(98, 65);
            btCreateSusscessMember.TabIndex = 9;
            btCreateSusscessMember.Text = "ADD";
            btCreateSusscessMember.TextAlign = ContentAlignment.BottomCenter;
            btCreateSusscessMember.UseVisualStyleBackColor = true;
            btCreateSusscessMember.Click += btCreateSusscessMember_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(68, 171);
            label6.Name = "label6";
            label6.Size = new Size(72, 61);
            label6.TabIndex = 8;
            label6.Text = "Phone";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(386, 11);
            label4.Name = "label4";
            label4.Size = new Size(72, 61);
            label4.TabIndex = 6;
            label4.Text = "DoB: ";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(68, 93);
            label3.Name = "label3";
            label3.Size = new Size(72, 61);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(68, 15);
            label2.Name = "label2";
            label2.Size = new Size(72, 61);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // frmMemberCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 462);
            Controls.Add(pnlCreateMember);
            Controls.Add(pnlCheckMember);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMemberCheck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Check";
            pnlCheckMember.ResumeLayout(false);
            pnlCheckMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            pnlCreateMember.ResumeLayout(false);
            pnlCreateMember.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCheckMember;
        private DataGridView dgvListMember;
        private Button btCloseMemberCheck;
        private Button btCreateMember;
        private Label lbPhoneMember;
        private TextBox txtSearchMember;
        private Button btCheckPhoneMember;
        private Panel pnlCreateMember;
        private DateTimePicker dtDoBNewMember;
        private ComboBox cbGenderNewMember;
        private TextBox txtPhoneNewMember;
        private TextBox txtNameNewMember;
        private Button btCreateSusscessMember;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn phoneMemberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private BindingSource memberBindingSource;
    }
}