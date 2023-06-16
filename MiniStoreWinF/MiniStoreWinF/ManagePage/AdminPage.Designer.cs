﻿namespace MiniStoreWinF.ManagePage
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            panel1 = new Panel();
            btManageEmployees = new Button();
            lbManagaEmployees = new Label();
            panel2 = new Panel();
            btManageProducts = new Button();
            label1 = new Label();
            panel3 = new Panel();
            btManageSalary = new Button();
            label2 = new Label();
            panel4 = new Panel();
            btManageTimekeeping = new Button();
            label3 = new Label();
            panel5 = new Panel();
            btManageVenrune = new Button();
            label4 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btManageEmployees);
            panel1.Controls.Add(lbManagaEmployees);
            panel1.Location = new Point(12, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 182);
            panel1.TabIndex = 0;
            // 
            // btManageEmployees
            // 
            btManageEmployees.BackgroundImage = (Image)resources.GetObject("btManageEmployees.BackgroundImage");
            btManageEmployees.BackgroundImageLayout = ImageLayout.Zoom;
            btManageEmployees.ForeColor = SystemColors.ControlLight;
            btManageEmployees.Location = new Point(3, 45);
            btManageEmployees.Name = "btManageEmployees";
            btManageEmployees.Size = new Size(210, 134);
            btManageEmployees.TabIndex = 1;
            btManageEmployees.UseVisualStyleBackColor = true;
            btManageEmployees.Click += btManageEmployees_Click;
            // 
            // lbManagaEmployees
            // 
            lbManagaEmployees.BorderStyle = BorderStyle.Fixed3D;
            lbManagaEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbManagaEmployees.Location = new Point(3, 0);
            lbManagaEmployees.Name = "lbManagaEmployees";
            lbManagaEmployees.Size = new Size(210, 42);
            lbManagaEmployees.TabIndex = 0;
            lbManagaEmployees.Text = "Employee";
            lbManagaEmployees.TextAlign = ContentAlignment.MiddleCenter;
            lbManagaEmployees.Click += btManageEmployees_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btManageProducts);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(304, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 182);
            panel2.TabIndex = 2;
            // 
            // btManageProducts
            // 
            btManageProducts.BackgroundImage = (Image)resources.GetObject("btManageProducts.BackgroundImage");
            btManageProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btManageProducts.Location = new Point(3, 45);
            btManageProducts.Name = "btManageProducts";
            btManageProducts.Size = new Size(210, 134);
            btManageProducts.TabIndex = 1;
            btManageProducts.UseVisualStyleBackColor = true;
            btManageProducts.Click += btManageProducts_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 42);
            label1.TabIndex = 0;
            label1.Text = "Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btManageProducts_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btManageSalary);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(594, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 182);
            panel3.TabIndex = 3;
            // 
            // btManageSalary
            // 
            btManageSalary.BackgroundImage = (Image)resources.GetObject("btManageSalary.BackgroundImage");
            btManageSalary.BackgroundImageLayout = ImageLayout.Zoom;
            btManageSalary.Location = new Point(3, 45);
            btManageSalary.Name = "btManageSalary";
            btManageSalary.Size = new Size(210, 134);
            btManageSalary.TabIndex = 1;
            btManageSalary.UseVisualStyleBackColor = true;
            btManageSalary.Click += btManageSalary_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 42);
            label2.TabIndex = 0;
            label2.Text = "Salary";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += btManageSalary_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btManageTimekeeping);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(9, 363);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 182);
            panel4.TabIndex = 4;
            // 
            // btManageTimekeeping
            // 
            btManageTimekeeping.BackgroundImage = (Image)resources.GetObject("btManageTimekeeping.BackgroundImage");
            btManageTimekeeping.BackgroundImageLayout = ImageLayout.Zoom;
            btManageTimekeeping.Location = new Point(3, 48);
            btManageTimekeeping.Name = "btManageTimekeeping";
            btManageTimekeeping.Size = new Size(210, 134);
            btManageTimekeeping.TabIndex = 1;
            btManageTimekeeping.UseVisualStyleBackColor = true;
            btManageTimekeeping.Click += btManageTimekeeping_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(210, 42);
            label3.TabIndex = 0;
            label3.Text = "Timekeeping";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += btManageTimekeeping_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btManageVenrune);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(304, 363);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 182);
            panel5.TabIndex = 4;
            // 
            // btManageVenrune
            // 
            btManageVenrune.BackgroundImage = (Image)resources.GetObject("btManageVenrune.BackgroundImage");
            btManageVenrune.BackgroundImageLayout = ImageLayout.Zoom;
            btManageVenrune.Location = new Point(3, 45);
            btManageVenrune.Name = "btManageVenrune";
            btManageVenrune.Size = new Size(210, 134);
            btManageVenrune.TabIndex = 1;
            btManageVenrune.UseVisualStyleBackColor = true;
            btManageVenrune.Click += btManageVenrune_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 42);
            label4.TabIndex = 0;
            label4.Text = "Revenue";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += btManageVenrune_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(1, -2);
            panel6.Name = "panel6";
            panel6.Size = new Size(822, 140);
            panel6.TabIndex = 5;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 629);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btManageEmployees;
        private Label lbManagaEmployees;
        private Panel panel2;
        private Button btManageProducts;
        private Label label1;
        private Panel panel3;
        private Button btManageSalary;
        private Label label2;
        private Panel panel4;
        private Button btManageTimekeeping;
        private Label label3;
        private Panel panel5;
        private Button btManageVenrune;
        private Label label4;
        private Panel panel6;
    }
}