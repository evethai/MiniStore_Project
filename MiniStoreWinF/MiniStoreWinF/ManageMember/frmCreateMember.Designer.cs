namespace MiniStoreWinF.ManageMember
{
    partial class frmCreateMember
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
            panel1 = new Panel();
            txtPhone = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtPoint = new TextBox();
            txtName = new TextBox();
            dtDoB = new DateTimePicker();
            btAdd = new Button();
            cbGender = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPoint);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(dtDoB);
            panel1.Controls.Add(btAdd);
            panel1.Controls.Add(cbGender);
            panel1.Location = new Point(13, 132);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 377);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(112, 20);
            txtPhone.Margin = new Padding(4, 4, 4, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(219, 29);
            txtPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 252);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 4;
            label5.Text = "DoB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 5;
            label2.Text = "Point";
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(112, 76);
            txtPoint.Margin = new Padding(4, 4, 4, 4);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(219, 29);
            txtPoint.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 134);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 29);
            txtName.TabIndex = 8;
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(112, 252);
            dtDoB.Margin = new Padding(4, 4, 4, 4);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(320, 29);
            dtDoB.TabIndex = 10;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(323, 305);
            btAdd.Margin = new Padding(4, 4, 4, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(96, 32);
            btAdd.TabIndex = 18;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(112, 190);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(120, 29);
            cbGender.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 21);
            label6.TabIndex = 29;
            label6.Text = "Create New Member";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 106);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(374, 21);
            label7.TabIndex = 30;
            label7.Text = "*Require all the necessary information to be entered.";
            // 
            // frmCreateMember
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(477, 515);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmCreateMember";
            Text = "Create Member";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtPhone;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox txtPoint;
        private TextBox txtName;
        private DateTimePicker dtDoB;
        private Button btAdd;
        private ComboBox cbGender;
        private Label label6;
        private Label label7;
    }
}