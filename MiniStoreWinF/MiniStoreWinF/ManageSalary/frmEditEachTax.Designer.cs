namespace MiniStoreWinF.ManageSalary
{
    partial class frmEditEachTax
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
            btSave = new Button();
            label6 = new Label();
            txtNewGuard = new TextBox();
            txtNewEmp = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(237, 125);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 6;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 59);
            label6.Name = "label6";
            label6.Size = new Size(122, 17);
            label6.TabIndex = 3;
            label6.Text = "New Tax for Guard ";
            // 
            // txtNewGuard
            // 
            txtNewGuard.Location = new Point(212, 59);
            txtNewGuard.Name = "txtNewGuard";
            txtNewGuard.Size = new Size(100, 25);
            txtNewGuard.TabIndex = 7;
            txtNewGuard.KeyPress += txtNewGuard_KeyPress;
            // 
            // txtNewEmp
            // 
            txtNewEmp.Location = new Point(212, 19);
            txtNewEmp.Name = "txtNewEmp";
            txtNewEmp.Size = new Size(100, 25);
            txtNewEmp.TabIndex = 5;
            txtNewEmp.KeyPress += txtNewEmp_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(139, 17);
            label5.TabIndex = 4;
            label5.Text = "New Tax for Employee";
            // 
            // frmEditEachTax
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 163);
            Controls.Add(btSave);
            Controls.Add(label6);
            Controls.Add(txtNewGuard);
            Controls.Add(txtNewEmp);
            Controls.Add(label5);
            Name = "frmEditEachTax";
            Text = "frmEditEachTax";
            Load += frmEditEachTax_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private Label label6;
        private TextBox txtNewGuard;
        private TextBox txtNewEmp;
        private Label label5;
    }
}