namespace MiniStoreWinF.ManageProducts
{
    partial class ManageAll
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
            groupBox4 = new GroupBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            AUTHORIZATION = new Button();
            label1 = new Label();
            pnProduct = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Navy;
            groupBox4.Location = new Point(3, 159);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(276, 73);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 23);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(270, 47);
            button2.TabIndex = 1;
            button2.Text = "Supplier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Navy;
            groupBox3.Location = new Point(3, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 72);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 23);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(270, 46);
            button1.TabIndex = 1;
            button1.Text = "Unit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AUTHORIZATION);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 72);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // AUTHORIZATION
            // 
            AUTHORIZATION.Dock = DockStyle.Fill;
            AUTHORIZATION.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AUTHORIZATION.ImageAlign = ContentAlignment.MiddleLeft;
            AUTHORIZATION.Location = new Point(3, 23);
            AUTHORIZATION.Margin = new Padding(5, 4, 5, 4);
            AUTHORIZATION.Name = "AUTHORIZATION";
            AUTHORIZATION.Size = new Size(270, 46);
            AUTHORIZATION.TabIndex = 1;
            AUTHORIZATION.Text = "Product";
            AUTHORIZATION.UseVisualStyleBackColor = true;
            AUTHORIZATION.Click += AUTHORIZATION_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // pnProduct
            // 
            pnProduct.ColumnCount = 1;
            pnProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnProduct.Location = new Point(290, 0);
            pnProduct.Name = "pnProduct";
            pnProduct.RowCount = 1;
            pnProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnProduct.Size = new Size(1082, 764);
            pnProduct.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Location = new Point(2, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(282, 235);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ManageAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 764);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnProduct);
            Controls.Add(label1);
            Name = "ManageAll";
            Text = "ManageAll";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label label1;
        private TableLayoutPanel pnProduct;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button1;
        private Button AUTHORIZATION;
    }
}