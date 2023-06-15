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
            label6.Location = new Point(12, 76);
            label6.Name = "label6";
            label6.Size = new Size(134, 17);
            label6.TabIndex = 0;
            label6.Text = "New Salary for Guard";
            // 
            // btSave
            // 
            btSave.Location = new Point(236, 142);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 36);
            label5.Name = "label5";
            label5.Size = new Size(155, 17);
            label5.TabIndex = 0;
            label5.Text = "New Salary for Employee";
            // 
            // txtNewEmp
            // 
            txtNewEmp.Location = new Point(211, 36);
            txtNewEmp.Name = "txtNewEmp";
            txtNewEmp.Size = new Size(100, 25);
            txtNewEmp.TabIndex = 1;
            txtNewEmp.KeyPress += txtNewEmp_KeyPress;
            // 
            // txtNewGuard
            // 
            txtNewGuard.Location = new Point(211, 76);
            txtNewGuard.Name = "txtNewGuard";
            txtNewGuard.Size = new Size(100, 25);
            txtNewGuard.TabIndex = 2;
            txtNewGuard.KeyPress += txtNewGuard_KeyPress;
            // 
            // frmEditEachSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 189);
            Controls.Add(btSave);
            Controls.Add(label6);
            Controls.Add(txtNewGuard);
            Controls.Add(txtNewEmp);
            Controls.Add(label5);
            Name = "frmEditEachSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditEachSalary";
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