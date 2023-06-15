namespace MiniStoreWinF.ManageEmployees
{
    partial class ManageEmloyee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmloyee));
            panel1 = new Panel();
            btShowEmployees = new Button();
            lbShowEmployees = new Label();
            panel2 = new Panel();
            btCreateEmployees = new Button();
            label1 = new Label();
            panel3 = new Panel();
            btUpdateRemoveEmployees = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btShowEmployees);
            panel1.Controls.Add(lbShowEmployees);
            panel1.Location = new Point(43, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 182);
            panel1.TabIndex = 1;
            // 
            // btShowEmployees
            // 
            btShowEmployees.BackgroundImage = (Image)resources.GetObject("btShowEmployees.BackgroundImage");
            btShowEmployees.BackgroundImageLayout = ImageLayout.Zoom;
            btShowEmployees.ForeColor = SystemColors.ControlLight;
            btShowEmployees.Location = new Point(3, 45);
            btShowEmployees.Name = "btShowEmployees";
            btShowEmployees.Size = new Size(210, 134);
            btShowEmployees.TabIndex = 1;
            btShowEmployees.UseVisualStyleBackColor = true;
            btShowEmployees.Click += btShowEmployees_Click;
            // 
            // lbShowEmployees
            // 
            lbShowEmployees.BorderStyle = BorderStyle.Fixed3D;
            lbShowEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbShowEmployees.Location = new Point(0, 0);
            lbShowEmployees.Name = "lbShowEmployees";
            lbShowEmployees.Size = new Size(210, 42);
            lbShowEmployees.TabIndex = 0;
            lbShowEmployees.Text = "Show Employees";
            lbShowEmployees.TextAlign = ContentAlignment.MiddleCenter;
            lbShowEmployees.Click += btShowEmployees_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btCreateEmployees);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(351, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 182);
            panel2.TabIndex = 2;
            // 
            // btCreateEmployees
            // 
            btCreateEmployees.BackgroundImage = (Image)resources.GetObject("btCreateEmployees.BackgroundImage");
            btCreateEmployees.BackgroundImageLayout = ImageLayout.Zoom;
            btCreateEmployees.ForeColor = SystemColors.ControlLight;
            btCreateEmployees.Location = new Point(3, 45);
            btCreateEmployees.Name = "btCreateEmployees";
            btCreateEmployees.Size = new Size(210, 134);
            btCreateEmployees.TabIndex = 1;
            btCreateEmployees.UseVisualStyleBackColor = true;
            btCreateEmployees.Click += btCreateEmployees_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 42);
            label1.TabIndex = 0;
            label1.Text = "Create Employees";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btCreateEmployees_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btUpdateRemoveEmployees);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(206, 376);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 182);
            panel3.TabIndex = 3;
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
            label2.Text = "Update -Remove";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += btUpdateRemoveEmployees_Click;
            // 
            // ManageEmloyee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 608);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageEmloyee";
            Text = "ManageEmloyee";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btShowEmployees;
        private Label lbShowEmployees;
        private Panel panel2;
        private Button btCreateEmployees;
        private Label label1;
        private Panel panel3;
        private Button btUpdateRemoveEmployees;
        private Label label2;
    }
}