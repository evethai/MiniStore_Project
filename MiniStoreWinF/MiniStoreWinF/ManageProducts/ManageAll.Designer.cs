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
            button2 = new Button();
            button1 = new Button();
            AUTHORIZATION = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnProduct = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 152);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(253, 66);
            button2.TabIndex = 1;
            button2.Text = "Supplier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 78);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(253, 66);
            button1.TabIndex = 1;
            button1.Text = "Unit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AUTHORIZATION
            // 
            AUTHORIZATION.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AUTHORIZATION.ImageAlign = ContentAlignment.MiddleLeft;
            AUTHORIZATION.Location = new Point(6, 4);
            AUTHORIZATION.Margin = new Padding(6, 4, 6, 4);
            AUTHORIZATION.Name = "AUTHORIZATION";
            AUTHORIZATION.Size = new Size(253, 66);
            AUTHORIZATION.TabIndex = 1;
            AUTHORIZATION.Text = "Product";
            AUTHORIZATION.UseVisualStyleBackColor = true;
            AUTHORIZATION.Click += AUTHORIZATION_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(564, 160);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(AUTHORIZATION);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(267, 0);
            flowLayoutPanel1.MinimumSize = new Size(267, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(267, 954);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // pnProduct
            // 
            pnProduct.BorderStyle = BorderStyle.Fixed3D;
            pnProduct.Dock = DockStyle.Fill;
            pnProduct.Location = new Point(267, 0);
            pnProduct.Name = "pnProduct";
            pnProduct.Size = new Size(1619, 954);
            pnProduct.TabIndex = 4;
            // 
            // ManageAll
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1886, 954);
            Controls.Add(pnProduct);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ManageAll";
            Text = "ManageAll";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button1;
        private Button AUTHORIZATION;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnProduct;
    }
}