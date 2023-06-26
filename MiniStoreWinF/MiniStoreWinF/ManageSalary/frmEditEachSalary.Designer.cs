namespace MiniStoreWinF.ManageSalary
{
    partial class frmEditEachSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditEachSalary));
            label6 = new Label();
            btSave = new Button();
            label5 = new Label();
            txtNewEmp = new TextBox();
            txtNewGuard = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 112);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 25);
            label6.TabIndex = 0;
            label6.Text = "New Salary for Guard";
            // 
            // btSave
            // 
            btSave.Location = new Point(371, 209);
            btSave.Margin = new Padding(5, 4, 5, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 34);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 53);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 0;
            label5.Text = "New Salary for Employee";
            // 
            // txtNewEmp
            // 
            txtNewEmp.Location = new Point(332, 53);
            txtNewEmp.Margin = new Padding(5, 4, 5, 4);
            txtNewEmp.Name = "txtNewEmp";
            txtNewEmp.Size = new Size(155, 33);
            txtNewEmp.TabIndex = 1;
            txtNewEmp.KeyPress += txtNewEmp_KeyPress;
            // 
            // txtNewGuard
            // 
            txtNewGuard.Location = new Point(332, 112);
            txtNewGuard.Margin = new Padding(5, 4, 5, 4);
            txtNewGuard.Name = "txtNewGuard";
            txtNewGuard.Size = new Size(155, 33);
            txtNewGuard.TabIndex = 2;
            txtNewGuard.KeyPress += txtNewGuard_KeyPress;
            // 
            // frmEditEachSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 278);
            Controls.Add(btSave);
            Controls.Add(label6);
            Controls.Add(txtNewGuard);
            Controls.Add(txtNewEmp);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(557, 317);
            MinimumSize = new Size(557, 317);
            Name = "frmEditEachSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditEachSalary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btSave;
        private Label label5;
        private TextBox txtNewEmp;
        private TextBox txtNewGuard;
    }
}