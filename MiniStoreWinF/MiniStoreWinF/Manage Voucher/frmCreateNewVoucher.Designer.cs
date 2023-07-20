namespace MiniStoreWinF.Manage_Voucher
{
    partial class frmCreateNewVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewVoucher));
            pnAdd = new Panel();
            btBack = new Button();
            label2 = new Label();
            numAddCondition = new NumericUpDown();
            label3 = new Label();
            dpkNewDate = new DateTimePicker();
            btAdd = new Button();
            txtNewQuantity = new TextBox();
            txtNewPrice = new TextBox();
            txtAddName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label1 = new Label();
            pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddCondition).BeginInit();
            SuspendLayout();
            // 
            // pnAdd
            // 
            pnAdd.BorderStyle = BorderStyle.Fixed3D;
            pnAdd.Controls.Add(btBack);
            pnAdd.Controls.Add(label2);
            pnAdd.Controls.Add(numAddCondition);
            pnAdd.Controls.Add(label3);
            pnAdd.Controls.Add(dpkNewDate);
            pnAdd.Controls.Add(btAdd);
            pnAdd.Controls.Add(txtNewQuantity);
            pnAdd.Controls.Add(txtNewPrice);
            pnAdd.Controls.Add(txtAddName);
            pnAdd.Controls.Add(label7);
            pnAdd.Controls.Add(label8);
            pnAdd.Controls.Add(label9);
            pnAdd.Controls.Add(label11);
            pnAdd.Location = new Point(13, 90);
            pnAdd.Margin = new Padding(4, 3, 4, 3);
            pnAdd.Name = "pnAdd";
            pnAdd.Size = new Size(379, 442);
            pnAdd.TabIndex = 15;
            // 
            // btBack
            // 
            btBack.Image = (Image)resources.GetObject("btBack.Image");
            btBack.ImageAlign = ContentAlignment.MiddleLeft;
            btBack.Location = new Point(4, 364);
            btBack.Margin = new Padding(4, 3, 4, 3);
            btBack.Name = "btBack";
            btBack.Size = new Size(108, 42);
            btBack.TabIndex = 17;
            btBack.Text = "Back";
            btBack.TextAlign = ContentAlignment.MiddleRight;
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 409);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 13);
            label2.TabIndex = 17;
            label2.Text = "*Require all the necessary information to be entered.";
            // 
            // numAddCondition
            // 
            numAddCondition.Location = new Point(121, 150);
            numAddCondition.Margin = new Padding(4, 3, 4, 3);
            numAddCondition.Name = "numAddCondition";
            numAddCondition.Size = new Size(116, 29);
            numAddCondition.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 14;
            label3.Text = "Condition";
            // 
            // dpkNewDate
            // 
            dpkNewDate.Location = new Point(131, 277);
            dpkNewDate.Margin = new Padding(4, 3, 4, 3);
            dpkNewDate.Name = "dpkNewDate";
            dpkNewDate.Size = new Size(228, 29);
            dpkNewDate.TabIndex = 13;
            // 
            // btAdd
            // 
            btAdd.Image = (Image)resources.GetObject("btAdd.Image");
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(265, 364);
            btAdd.Margin = new Padding(4, 3, 4, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(108, 42);
            btAdd.TabIndex = 12;
            btAdd.Text = "Create";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // txtNewQuantity
            // 
            txtNewQuantity.Location = new Point(131, 220);
            txtNewQuantity.Margin = new Padding(4, 3, 4, 3);
            txtNewQuantity.Name = "txtNewQuantity";
            txtNewQuantity.Size = new Size(97, 29);
            txtNewQuantity.TabIndex = 10;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(121, 95);
            txtNewPrice.Margin = new Padding(4, 3, 4, 3);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(140, 29);
            txtNewPrice.TabIndex = 9;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(121, 35);
            txtAddName.Margin = new Padding(4, 3, 4, 3);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(140, 29);
            txtAddName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 280);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 5;
            label7.Text = "EXP Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 220);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 4;
            label8.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 95);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 3;
            label9.Text = "Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 42);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 1;
            label11.Text = "Name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 55);
            label1.TabIndex = 16;
            label1.Text = "New Voucher";
            // 
            // frmCreateNewVoucher
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 546);
            Controls.Add(label1);
            Controls.Add(pnAdd);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmCreateNewVoucher";
            Text = "Create New Voucher";
            pnAdd.ResumeLayout(false);
            pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddCondition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnAdd;
        private NumericUpDown numAddCondition;
        private Label label3;
        private DateTimePicker dpkNewDate;
        private Button btAdd;
        private TextBox txtNewQuantity;
        private TextBox txtNewPrice;
        private TextBox txtAddName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label1;
        private Label label2;
        private Button btBack;
    }
}