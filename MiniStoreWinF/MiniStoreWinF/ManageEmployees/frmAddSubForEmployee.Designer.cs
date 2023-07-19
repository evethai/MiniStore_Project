namespace MiniStoreWinF.ManageEmployees
{
    partial class frmAddSubForEmployee
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
            cbTypeSub = new ComboBox();
            dtpTimeEnd = new DateTimePicker();
            dtpTimeStart = new DateTimePicker();
            btAddSub = new Button();
            idEmp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbTypeSub
            // 
            cbTypeSub.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeSub.FormattingEnabled = true;
            cbTypeSub.Location = new Point(87, 88);
            cbTypeSub.Name = "cbTypeSub";
            cbTypeSub.Size = new Size(100, 23);
            cbTypeSub.TabIndex = 1;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.Location = new Point(87, 192);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.Size = new Size(200, 23);
            dtpTimeEnd.TabIndex = 2;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.Location = new Point(87, 138);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.Size = new Size(200, 23);
            dtpTimeStart.TabIndex = 3;
            // 
            // btAddSub
            // 
            btAddSub.Location = new Point(212, 238);
            btAddSub.Name = "btAddSub";
            btAddSub.Size = new Size(75, 23);
            btAddSub.TabIndex = 4;
            btAddSub.Text = "Add";
            btAddSub.UseVisualStyleBackColor = true;
            btAddSub.Click += btAddSub_Click;
            // 
            // idEmp
            // 
            idEmp.Enabled = false;
            idEmp.Location = new Point(87, 44);
            idEmp.Name = "idEmp";
            idEmp.Size = new Size(100, 23);
            idEmp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 6;
            label1.Text = "Add New Allowance For Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Id Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Id Allowance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 138);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Day Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 192);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Day End";
            // 
            // button1
            // 
            button1.Location = new Point(12, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAddSubForEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 279);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idEmp);
            Controls.Add(btAddSub);
            Controls.Add(dtpTimeStart);
            Controls.Add(dtpTimeEnd);
            Controls.Add(cbTypeSub);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddSubForEmployee";
            Text = "Add New Allowance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbTypeSub;
        private DateTimePicker dtpTimeEnd;
        private DateTimePicker dtpTimeStart;
        private Button btAddSub;
        private TextBox idEmp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}