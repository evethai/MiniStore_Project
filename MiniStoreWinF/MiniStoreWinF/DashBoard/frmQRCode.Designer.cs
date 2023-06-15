namespace MiniStoreWinF.DashBoard
{
    partial class frmQRCode
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
            pictureBox1 = new PictureBox();
            txt_phone = new TextBox();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_sotien = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Phone = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(99, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(56, 55);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(276, 25);
            txt_phone.TabIndex = 2;
            txt_phone.Text = "0379990249";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(56, 97);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(276, 25);
            txt_name.TabIndex = 2;
            txt_name.Text = "Nguyen Quoc Thai";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(56, 138);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(276, 25);
            txt_email.TabIndex = 2;
            txt_email.Text = "thainguyendcs@gmail.com";
            // 
            // txt_sotien
            // 
            txt_sotien.Location = new Point(56, 184);
            txt_sotien.Name = "txt_sotien";
            txt_sotien.Size = new Size(276, 25);
            txt_sotien.TabIndex = 2;
            txt_sotien.Text = "50000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Phone);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(txt_sotien);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Location = new Point(392, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 212);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 184);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 3;
            label3.Text = "Số tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 141);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 3;
            label2.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(6, 55);
            Phone.Name = "Phone";
            Phone.Size = new Size(44, 17);
            Phone.TabIndex = 3;
            Phone.Text = "Phone";
            // 
            // button1
            // 
            button1.Location = new Point(414, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmQRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "frmQRCode";
            Text = "frmQRCode";
            Load += frmQRCode_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_phone;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_sotien;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Phone;
        private Button button1;
    }
}