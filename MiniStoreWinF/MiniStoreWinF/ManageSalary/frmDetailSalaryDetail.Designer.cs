namespace MiniStoreWinF.ManageSalary
{
    partial class frmDetailSalaryDetail
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
            dataGridView1 = new DataGridView();
            btPre = new Button();
            btNext = new Button();
            lab = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtHour = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtOrder = new TextBox();
            txtRevenus = new TextBox();
            txtTime = new Label();
            txtName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 71);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(581, 92);
            dataGridView1.TabIndex = 1;
            // 
            // btPre
            // 
            btPre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPre.Location = new Point(600, 171);
            btPre.Margin = new Padding(4);
            btPre.Name = "btPre";
            btPre.Size = new Size(44, 28);
            btPre.TabIndex = 2;
            btPre.Text = "<";
            btPre.UseVisualStyleBackColor = true;
            btPre.Click += btPre_Click;
            // 
            // btNext
            // 
            btNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btNext.Location = new Point(685, 171);
            btNext.Margin = new Padding(4);
            btNext.Name = "btNext";
            btNext.Size = new Size(46, 28);
            btNext.TabIndex = 3;
            btNext.Text = ">";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(20, 71);
            lab.Margin = new Padding(4, 0, 4, 0);
            lab.Name = "lab";
            lab.Size = new Size(42, 21);
            lab.TabIndex = 4;
            lab.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 4;
            label2.Text = "Time Check-In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 4;
            label3.Text = "Time Check-Out";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 5;
            label1.Text = "Sum Hours";
            // 
            // txtHour
            // 
            txtHour.Enabled = false;
            txtHour.Location = new Point(152, 218);
            txtHour.Margin = new Padding(4);
            txtHour.Name = "txtHour";
            txtHour.Size = new Size(173, 29);
            txtHour.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 276);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 5;
            label4.Text = "Sum Orders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 336);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 5;
            label5.Text = "Sum Revenues";
            // 
            // txtOrder
            // 
            txtOrder.Enabled = false;
            txtOrder.Location = new Point(152, 272);
            txtOrder.Margin = new Padding(4);
            txtOrder.Name = "txtOrder";
            txtOrder.Size = new Size(173, 29);
            txtOrder.TabIndex = 6;
            // 
            // txtRevenus
            // 
            txtRevenus.Enabled = false;
            txtRevenus.Location = new Point(152, 333);
            txtRevenus.Margin = new Padding(4);
            txtRevenus.Name = "txtRevenus";
            txtRevenus.Size = new Size(173, 29);
            txtRevenus.TabIndex = 6;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTime.Location = new Point(342, 32);
            txtTime.Margin = new Padding(4, 0, 4, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(61, 21);
            txtTime.TabIndex = 4;
            txtTime.Text = "Month";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(20, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(56, 21);
            txtName.TabIndex = 7;
            txtName.Text = "Name";
            // 
            // frmDetailSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(744, 381);
            Controls.Add(txtName);
            Controls.Add(txtRevenus);
            Controls.Add(txtOrder);
            Controls.Add(txtHour);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTime);
            Controls.Add(lab);
            Controls.Add(btNext);
            Controls.Add(btPre);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(760, 420);
            Name = "frmDetailSalaryDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDetailSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btPre;
        private Button btNext;
        private Label lab;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtHour;
        private Label label4;
        private Label label5;
        private TextBox txtOrder;
        private TextBox txtRevenus;
        private Label txtTime;
        private Label txtName;
    }
}