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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditEachSalary));
            btSave = new Button();
            lblName = new Label();
            txtSalary = new TextBox();
            notiSave = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(155, 143);
            btSave.Margin = new Padding(5, 4, 5, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 34);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 39);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(135, 25);
            lblName.TabIndex = 0;
            lblName.Text = "New Salary for";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(277, 31);
            txtSalary.Margin = new Padding(5, 4, 5, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(155, 33);
            txtSalary.TabIndex = 2;
            txtSalary.KeyPress += txtNewGuard_KeyPress;
            // 
            // notiSave
            // 
            notiSave.Text = "notifyIcon1";
            notiSave.Visible = true;
            // 
            // frmEditEachSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 190);
            Controls.Add(btSave);
            Controls.Add(txtSalary);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(462, 229);
            MinimumSize = new Size(462, 229);
            Name = "frmEditEachSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit new Salary";
            Load += frmEditEachSalary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btSave;
        private Label lblName;
        private TextBox txtSalary;
        private NotifyIcon notiSave;
    }
}