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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditEachTax));
            btSave = new Button();
            label6 = new Label();
            txtNewGuard = new TextBox();
            txtNewEmp = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(372, 184);
            btSave.Margin = new Padding(5, 4, 5, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 34);
            btSave.TabIndex = 6;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 87);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 3;
            label6.Text = "New Tax for Guard ";
            // 
            // txtNewGuard
            // 
            txtNewGuard.Location = new Point(333, 87);
            txtNewGuard.Margin = new Padding(5, 4, 5, 4);
            txtNewGuard.Name = "txtNewGuard";
            txtNewGuard.Size = new Size(155, 33);
            txtNewGuard.TabIndex = 7;
            txtNewGuard.KeyPress += txtNewGuard_KeyPress;
            // 
            // txtNewEmp
            // 
            txtNewEmp.Location = new Point(333, 28);
            txtNewEmp.Margin = new Padding(5, 4, 5, 4);
            txtNewEmp.Name = "txtNewEmp";
            txtNewEmp.Size = new Size(155, 33);
            txtNewEmp.TabIndex = 5;
            txtNewEmp.KeyPress += txtNewEmp_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 28);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(198, 25);
            label5.TabIndex = 4;
            label5.Text = "New Tax for Employee";
            // 
            // frmEditEachTax
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 240);
            Controls.Add(btSave);
            Controls.Add(label6);
            Controls.Add(txtNewGuard);
            Controls.Add(txtNewEmp);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(544, 279);
            MinimumSize = new Size(544, 279);
            Name = "frmEditEachTax";
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