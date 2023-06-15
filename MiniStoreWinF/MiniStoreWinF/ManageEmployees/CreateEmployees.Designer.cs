namespace MiniStoreWinF.ManageEmployees
{
    partial class CreateEmployees
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btNextCreate = new Button();
            panel2 = new Panel();
            txtAddName = new TextBox();
            txtAddCCCD = new TextBox();
            txtAddPhone = new TextBox();
            txtAddAddress = new TextBox();
            panel3 = new Panel();
            rdAddMale = new RadioButton();
            rdAddFemale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtAddAddress);
            panel1.Controls.Add(txtAddPhone);
            panel1.Controls.Add(txtAddCCCD);
            panel1.Controls.Add(txtAddName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btNextCreate);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 525);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 27);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 7;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(496, 27);
            label7.Name = "label7";
            label7.Size = new Size(111, 38);
            label7.TabIndex = 6;
            label7.Text = "Picture";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 417);
            label6.Name = "label6";
            label6.Size = new Size(111, 38);
            label6.TabIndex = 5;
            label6.Text = "Address";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 339);
            label5.Name = "label5";
            label5.Size = new Size(111, 38);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 261);
            label4.Name = "label4";
            label4.Size = new Size(111, 38);
            label4.TabIndex = 3;
            label4.Text = "DoB";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 183);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 3;
            label3.Text = "CCCD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btNextCreate
            // 
            btNextCreate.BackColor = SystemColors.ActiveCaption;
            btNextCreate.Location = new Point(772, 453);
            btNextCreate.Name = "btNextCreate";
            btNextCreate.Size = new Size(94, 49);
            btNextCreate.TabIndex = 0;
            btNextCreate.Text = "NEXT";
            btNextCreate.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 40);
            panel2.TabIndex = 1;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(159, 31);
            txtAddName.Multiline = true;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(262, 34);
            txtAddName.TabIndex = 8;
            // 
            // txtAddCCCD
            // 
            txtAddCCCD.Location = new Point(159, 187);
            txtAddCCCD.Multiline = true;
            txtAddCCCD.Name = "txtAddCCCD";
            txtAddCCCD.Size = new Size(262, 34);
            txtAddCCCD.TabIndex = 9;
            // 
            // txtAddPhone
            // 
            txtAddPhone.Location = new Point(159, 346);
            txtAddPhone.Multiline = true;
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(262, 34);
            txtAddPhone.TabIndex = 10;
            // 
            // txtAddAddress
            // 
            txtAddAddress.Location = new Point(159, 417);
            txtAddAddress.Multiline = true;
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(262, 34);
            txtAddAddress.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(rdAddFemale);
            panel3.Controls.Add(rdAddMale);
            panel3.Location = new Point(159, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 38);
            panel3.TabIndex = 12;
            // 
            // rdAddMale
            // 
            rdAddMale.AutoSize = true;
            rdAddMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdAddMale.Location = new Point(18, 6);
            rdAddMale.Name = "rdAddMale";
            rdAddMale.Size = new Size(70, 27);
            rdAddMale.TabIndex = 0;
            rdAddMale.TabStop = true;
            rdAddMale.Text = "Male";
            rdAddMale.UseVisualStyleBackColor = true;
            // 
            // rdAddFemale
            // 
            rdAddFemale.AutoSize = true;
            rdAddFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdAddFemale.Location = new Point(138, 6);
            rdAddFemale.Name = "rdAddFemale";
            rdAddFemale.Size = new Size(88, 27);
            rdAddFemale.TabIndex = 1;
            rdAddFemale.TabStop = true;
            rdAddFemale.Text = "Female";
            rdAddFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(159, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(613, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 183);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // CreateEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CreateEmployees";
            Text = "CreateEmployees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btNextCreate;
        private Panel panel2;
        private Label label8;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private RadioButton rdAddFemale;
        private RadioButton rdAddMale;
        private TextBox txtAddAddress;
        private TextBox txtAddPhone;
        private TextBox txtAddCCCD;
        private TextBox txtAddName;
    }
}