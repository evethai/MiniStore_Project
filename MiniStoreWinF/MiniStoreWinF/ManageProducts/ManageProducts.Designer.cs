namespace MiniStoreWinF.ManageProducts
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            panel2 = new Panel();
            btCreateProducts = new Button();
            label1 = new Label();
            panel3 = new Panel();
            btUpdateRemoveEmployees = new Button();
            label2 = new Label();
            panel4 = new Panel();
            btShowProducts = new Button();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btCreateProducts);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(414, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 182);
            panel2.TabIndex = 2;
            // 
            // btCreateProducts
            // 
            btCreateProducts.BackgroundImage = (Image)resources.GetObject("btCreateProducts.BackgroundImage");
            btCreateProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btCreateProducts.ForeColor = SystemColors.ControlLight;
            btCreateProducts.Location = new Point(3, 45);
            btCreateProducts.Name = "btCreateProducts";
            btCreateProducts.Size = new Size(210, 134);
            btCreateProducts.TabIndex = 1;
            btCreateProducts.UseVisualStyleBackColor = true;
            btCreateProducts.Click += btCreateProducts_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 42);
            label1.TabIndex = 0;
            label1.Text = "Create Products";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btCreateProducts_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btUpdateRemoveEmployees);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(248, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 182);
            panel3.TabIndex = 2;
            // 
            // btUpdateRemoveEmployees
            // 
            btUpdateRemoveEmployees.BackgroundImage = (Image)resources.GetObject("btUpdateRemoveEmployees.BackgroundImage");
            btUpdateRemoveEmployees.BackgroundImageLayout = ImageLayout.Zoom;
            btUpdateRemoveEmployees.ForeColor = SystemColors.ControlLight;
            btUpdateRemoveEmployees.Location = new Point(3, 45);
            btUpdateRemoveEmployees.Name = "btUpdateRemoveEmployees";
            btUpdateRemoveEmployees.Size = new Size(210, 134);
            btUpdateRemoveEmployees.TabIndex = 1;
            btUpdateRemoveEmployees.UseVisualStyleBackColor = true;
            btUpdateRemoveEmployees.Click += btUpdateRemoveEmployees_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 42);
            label2.TabIndex = 0;
            label2.Text = "Update-Remove";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(btShowProducts);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(101, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 182);
            panel4.TabIndex = 3;
            // 
            // btShowProducts
            // 
            btShowProducts.BackgroundImage = (Image)resources.GetObject("btShowProducts.BackgroundImage");
            btShowProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btShowProducts.ForeColor = SystemColors.ControlLight;
            btShowProducts.Location = new Point(3, 45);
            btShowProducts.Name = "btShowProducts";
            btShowProducts.Size = new Size(210, 134);
            btShowProducts.TabIndex = 1;
            btShowProducts.UseVisualStyleBackColor = true;
            btShowProducts.Click += btShowProducts_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(210, 42);
            label3.TabIndex = 0;
            label3.Text = "Show Products";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += btShowProducts_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btCreateProducts;
        private Label label1;
        private Panel panel3;
        private Button btUpdateRemoveEmployees;
        private Label label2;
        private Panel panel4;
        private Button btShowProducts;
        private Label label3;
    }
}