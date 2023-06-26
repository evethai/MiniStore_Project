namespace MiniStoreWinF.DashBoard
{
    partial class frmAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnAdd = new Button();
            btnView = new Button();
            cbRoles = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvAuthorization = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            check = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            dgvPer = new DataGridView();
            role = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            permissionBindingSource = new BindingSource(components);
            permissionDetailBindingSource = new BindingSource(components);
            btMoMo = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthorization).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1177, 712);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(btMoMo);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(cbRoles);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 134);
            panel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(1003, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add New Role";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(228, 16);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 29);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(8, 16);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(198, 29);
            cbRoles.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvAuthorization, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 145);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1171, 564);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvAuthorization
            // 
            dgvAuthorization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAuthorization.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuthorization.BackgroundColor = SystemColors.Window;
            dgvAuthorization.BorderStyle = BorderStyle.None;
            dgvAuthorization.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAuthorization.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAuthorization.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthorization.Columns.AddRange(new DataGridViewColumn[] { id, name, check });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 100, 30);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAuthorization.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAuthorization.Dock = DockStyle.Fill;
            dgvAuthorization.Location = new Point(0, 0);
            dgvAuthorization.Margin = new Padding(0);
            dgvAuthorization.Name = "dgvAuthorization";
            dgvAuthorization.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAuthorization.RowTemplate.Height = 27;
            dgvAuthorization.ShowCellErrors = false;
            dgvAuthorization.ShowCellToolTips = false;
            dgvAuthorization.ShowEditingIcon = false;
            dgvAuthorization.ShowRowErrors = false;
            dgvAuthorization.Size = new Size(585, 564);
            dgvAuthorization.TabIndex = 0;
            dgvAuthorization.CellContentClick += dgvAuthorization_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Width = 150;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.Width = 177;
            // 
            // check
            // 
            check.HeaderText = "Authorization";
            check.Name = "check";
            check.Width = 210;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(588, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 558);
            panel1.TabIndex = 1;
            // 
            // dgvPer
            // 
            dgvPer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPer.BackgroundColor = SystemColors.Window;
            dgvPer.BorderStyle = BorderStyle.None;
            dgvPer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPer.Columns.AddRange(new DataGridViewColumn[] { role, num });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 100, 30);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPer.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPer.Dock = DockStyle.Top;
            dgvPer.Location = new Point(0, 0);
            dgvPer.Margin = new Padding(0);
            dgvPer.Name = "dgvPer";
            dgvPer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPer.RowTemplate.Height = 27;
            dgvPer.ShowCellErrors = false;
            dgvPer.ShowCellToolTips = false;
            dgvPer.ShowEditingIcon = false;
            dgvPer.ShowRowErrors = false;
            dgvPer.Size = new Size(580, 317);
            dgvPer.TabIndex = 1;
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            role.Width = 166;
            // 
            // num
            // 
            num.HeaderText = "Quantity";
            num.Name = "num";
            num.Width = 195;
            // 
            // permissionBindingSource
            // 
            permissionBindingSource.DataSource = typeof(Repository.Models.Permission);
            // 
            // permissionDetailBindingSource
            // 
            permissionDetailBindingSource.DataSource = typeof(Repository.Models.PermissionDetail);
            // 
            // btMoMo
            // 
            btMoMo.BackgroundImageLayout = ImageLayout.Center;
            btMoMo.Location = new Point(1003, 16);
            btMoMo.Name = "btMoMo";
            btMoMo.Size = new Size(158, 36);
            btMoMo.TabIndex = 5;
            btMoMo.Text = "MoMo";
            btMoMo.UseVisualStyleBackColor = true;
            btMoMo.Click += btMoMo_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1177, 712);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuthorization).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPer).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionDetailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private BindingSource permissionDetailBindingSource;
        private DataGridView dgvAuthorization;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn check;
        private ComboBox cbRoles;
        private Button btnView;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private DataGridView dgvPer;
        private BindingSource permissionBindingSource;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn num;
        private Button btMoMo;
    }
}