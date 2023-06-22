namespace MiniStoreWinF.ManageSalary
{
    partial class frmAddNewAdvSalary
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
            gbAdd = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new TextBox();
            txtDis = new TextBox();
            dtpDate = new DateTimePicker();
            cbName = new ComboBox();
            BtOK = new Button();
            gbAdd.SuspendLayout();
            SuspendLayout();
            // 
            // gbAdd
            // 
            gbAdd.BackColor = SystemColors.ButtonHighlight;
            gbAdd.Controls.Add(label4);
            gbAdd.Controls.Add(label3);
            gbAdd.Controls.Add(label2);
            gbAdd.Controls.Add(label1);
            gbAdd.Controls.Add(txtTotal);
            gbAdd.Controls.Add(txtDis);
            gbAdd.Controls.Add(dtpDate);
            gbAdd.Controls.Add(cbName);
            gbAdd.Controls.Add(BtOK);
            gbAdd.Location = new Point(3, 2);
            gbAdd.Margin = new Padding(5, 4, 5, 4);
            gbAdd.Name = "gbAdd";
            gbAdd.Padding = new Padding(5, 4, 5, 4);
            gbAdd.Size = new Size(517, 410);
            gbAdd.TabIndex = 4;
            gbAdd.TabStop = false;
            gbAdd.Text = "Add New Advance Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 275);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 4;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 202);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Discribe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 127);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(167, 263);
            txtTotal.Margin = new Padding(5, 4, 5, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(312, 33);
            txtTotal.TabIndex = 4;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(167, 190);
            txtDis.Margin = new Padding(5, 4, 5, 4);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(312, 33);
            txtDis.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(167, 118);
            dtpDate.Margin = new Padding(5, 4, 5, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(312, 33);
            dtpDate.TabIndex = 2;
            // 
            // cbName
            // 
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(167, 44);
            cbName.Margin = new Padding(5, 4, 5, 4);
            cbName.Name = "cbName";
            cbName.Size = new Size(312, 33);
            cbName.TabIndex = 1;
            // 
            // BtOK
            // 
            BtOK.Location = new Point(256, 356);
            BtOK.Margin = new Padding(5, 4, 5, 4);
            BtOK.Name = "BtOK";
            BtOK.Size = new Size(118, 34);
            BtOK.TabIndex = 5;
            BtOK.Text = "OK";
            BtOK.UseVisualStyleBackColor = true;
            BtOK.Click += BtOK_Click;
            // 
            // frmAddNewAdvSalary
            // 
            AcceptButton = BtOK;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 416);
            Controls.Add(gbAdd);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmAddNewAdvSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewAdvSalary";
            Load += frmAddNewAdvSalary_Load;
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTotal;
        private TextBox txtDis;
        private DateTimePicker dtpDate;
        private ComboBox cbName;
        private Button BtOK;
    }
}